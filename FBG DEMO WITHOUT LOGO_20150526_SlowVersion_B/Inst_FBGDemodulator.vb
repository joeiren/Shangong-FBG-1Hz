Imports GlobalModel

Namespace Opring.Instrument
    Public Class Inst_FBGDemodulator

        Public Enum FunctionCode
            Wavelength = 1
            Power
            SN
            ScanStep
            GetRawData

            GetWavelengthByGroup = 8
        End Enum

        Public Enum DataGroup
            FirstHalf
            SecondHalf
        End Enum

        Structure ChannelRawDataStructure
            Public Frequency As ArrayList
            Public Power As ArrayList
        End Structure

        Public ErrorCode() As String = {"Response Too Short", "Response Length Wrong", "No Response"}

        Protected mPort As IO.Ports.SerialPort
        Private mStartFrequency As Integer
        Private mStopFrequency As Integer
        Private mStepFrequency As Integer
        Const mDeviceID As Byte = &H10
        Private mFunctionCode As FunctionCode
        Private csvLog As Utils.csvWriter
        Private mSN As String
        Private mScanStep As Double

        Function Initialize(ByVal sPort As String, ByVal BaudRate As Integer, ByVal parity As IO.Ports.Parity, ByVal stopBits As IO.Ports.StopBits, _
                            ByVal timeOut As Double, ByVal RaiseError As Boolean) As Boolean

            Dim ex As Exception = Nothing

            mPort = New IO.Ports.SerialPort(sPort, BaudRate, parity, 8, stopBits)
            With mPort
                .ReadBufferSize = 24576
                .ReadTimeout = 1000 * timeOut
                .WriteTimeout = 1000 * timeOut
            End With

            'test if port can be opened
            Try
                mPort.Open()
            Catch ex
                'return error for failing to open port
                If RaiseError Then MessageBox.Show(ex.Message, "FBG Demodulator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return Nothing
            End Try

            Dim columns(3) As String
            columns(0) = "Time"
            columns(1) = "Content"
            columns(2) = "SN"
            Dim fileName As String
            fileName = Application.StartupPath + "\Data\ModuleErrorLog.csv"
            csvLog = New Utils.csvWriter(fileName, columns)

            Return True
        End Function

        Private Sub LogError(ByVal response() As Byte, ByVal errorCode As String)
            Dim s As String = ""
            s = Now.ToString("yyyyMMdd HH:mm:ss") + ","
            For i = 0 To response.Count - 1
                s += response(i).ToString + " "
            Next
            s += "," + errorCode
            s += "," + mSN
            csvLog.AppendLine(s)

        End Sub

        Public ReadOnly Property SN As String
            Get
                Dim sCmdHead(3), sCmd(5) As Byte
                Dim CRC As UShort
                Dim response() As Byte
                Dim a1, a2, a3, a4 As String

                sCmdHead(0) = mDeviceID
                sCmdHead(1) = Int(FunctionCode.SN)
                sCmdHead(2) = &H6
                sCmdHead(3) = 0
                CRC = w2Math.CheckSum.CRC16(sCmdHead)

                For i As Integer = 0 To 3
                    sCmd(i) = sCmdHead(i)
                Next
                sCmd(4) = CRC And &HFF
                sCmd(5) = CRC >> 8

                response = QueryByte(sCmd, 100)

                If response.Count < 4 Then
                    LogError(response, ErrorCode(0))
                    mSN = " "
                Else
                    a1 = Hex(response(3))
                    a2 = Hex(response(4))
                    a3 = Hex(response(5))
                    a4 = Hex(response(6))
                    If a1.Length = 1 Then a1 = "0" + a1
                    If a2.Length = 1 Then a2 = "0" + a2
                    If a3.Length = 1 Then a3 = "0" + a3
                    If a4.Length = 1 Then a4 = "0" + a4
                    mSN = Val("&H" + a1 + a2 + a3 + a4)
                End If

                Return mSN
            End Get
        End Property

        Public Property ScanStep As Integer
            Get
                Return mScanStep
            End Get
            Set(value As Integer)

                Dim sCmdHead(3), sCmd(5) As Byte
                Dim CRC As UShort
                Dim response() As Byte

                sCmdHead(0) = mDeviceID
                sCmdHead(1) = Int(FunctionCode.ScanStep)
                sCmdHead(2) = &H6
                sCmdHead(3) = value
                CRC = w2Math.CheckSum.CRC16(sCmdHead)

                For i As Integer = 0 To 3
                    sCmd(i) = sCmdHead(i)
                Next
                sCmd(4) = CRC And &HFF
                sCmd(5) = CRC >> 8

                response = QueryByte(sCmd, 100)

                If response.Count < 6 Then
                    LogError(response, ErrorCode(0))
                    mScanStep = 0
                Else
                    mScanStep = Val(response(3))
                    If mScanStep = value Then
                        MessageBox.Show("Scan step is set to " + mScanStep.ToString(), "FBG", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Scan step is set to " + mScanStep.ToString(), "FBG", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            End Set
        End Property

        Public Function SweepDone() As Boolean
            Dim sCmdHead(3), sCmd(5) As Byte
            Dim response() As Byte
            Dim CRC As UShort

            sCmdHead(0) = mDeviceID
            sCmdHead(1) = &H20
            sCmdHead(2) = &H6
            sCmdHead(3) = 0
            CRC = w2Math.CheckSum.CRC16(sCmdHead)

            For i As Integer = 0 To 3
                sCmd(i) = sCmdHead(i)
            Next
            sCmd(4) = CRC And &HFF
            sCmd(5) = CRC >> 8

            For t As Integer = 0 To 1
                mPort.DiscardOutBuffer()
                mPort.DiscardInBuffer()
                mPort.Write(sCmd, 0, sCmd.Length)
                System.Threading.Thread.Sleep(100)
                Dim bytesToRead, j As Integer
                bytesToRead = mPort.BytesToRead
                j = 0
                While bytesToRead < 5 And j < 60
                    System.Threading.Thread.Sleep(50)
                    bytesToRead = mPort.BytesToRead
                    j += 1
                End While

                ReDim response(bytesToRead)
                For i As Integer = 0 To bytesToRead - 1
                    response(i) = mPort.ReadByte()
                Next

                If response.Count < 5 Then
                    LogError(response, ErrorCode(0))
                    If t = 1 Then
                        Return False
                    End If
                Else
                    If response(3) = 1 Then Return True
                End If
            Next

            Return False

        End Function

        Public Function GetWavelength(ByVal channel As Integer) As Double()
            Dim sCmdHead(3), sCmd(5) As Byte
            Dim response() As Byte
            Dim CRC As UShort
            Dim a1, a2, a3 As String
            sCmdHead(0) = mDeviceID
            sCmdHead(1) = Int(FunctionCode.Wavelength)
            sCmdHead(2) = &H6
            sCmdHead(3) = channel
            CRC = w2Math.CheckSum.CRC16(sCmdHead)

            For i As Integer = 0 To 3
                sCmd(i) = sCmdHead(i)
            Next
            sCmd(4) = CRC And &HFF
            sCmd(5) = CRC >> 8

            response = QueryByte(sCmd)

            ' Query once again
            If response.Count < 54 Then
                response = QueryByte(sCmd)
            End If

            If response.Count < 3 Then
                LogError(response, ErrorCode(0))
                Return Nothing
            End If

            Dim grateCount As Integer = response(2)
            grateCount = (grateCount - 6) / 4
            If response.Count < 4 * (grateCount - 1) Then
                LogError(response, ErrorCode(1))
                Return Nothing
            End If

            Try
                Dim wavelength(grateCount - 1) As Double
                For i As Integer = 0 To grateCount - 1
                    a1 = Hex(response(5 + 4 * i))
                    a2 = Hex(response(6 + 4 * i))
                    a3 = Hex(response(7 + 4 * i))
                    If a1.Length = 1 Then a1 = "0" + a1
                    If a2.Length = 1 Then a2 = "0" + a2
                    If a3.Length = 1 Then a3 = "0" + a3
                    wavelength(i) = Val("&H" + a1 + a2 + a3) / 10000
                Next

                Return wavelength
            Catch ex As Exception
                LogError(response, ErrorCode(1))
                Return Nothing
            End Try

        End Function

        Public Function GetWavelengthByGroup() As ChannelDataStructure()
            Dim mDemulatorData(31) As ChannelDataStructure
            Dim GratingCount As Integer = 30
            Dim ChannelCount As Integer = 32
            Dim response() As Byte
            Dim a1, a2, a3 As String
            Dim i, j As Integer
            Dim wavelength As Double

            For i = 0 To ChannelCount - 1
                mDemulatorData(i).SampleTime = New List(Of Date)
                mDemulatorData(i).GratingWavelength = Nothing
                mDemulatorData(i).GratingPower = Nothing
            Next

            response = GetWavelengthGroupData(DataGroup.FirstHalf)
            Try
                For i = 0 To 15
                    If mDemulatorData(i).GratingWavelength Is Nothing Then
                        ReDim mDemulatorData(i).GratingWavelength(29)
                        For j = 0 To GratingCount - 1
                            mDemulatorData(i).GratingWavelength(j) = New ArrayList()
                        Next
                    End If

                    If mDemulatorData(i).SampleTime Is Nothing Then
                        mDemulatorData(i).SampleTime = New List(Of Date)
                    End If
                    mDemulatorData(i).SampleTime.Add(Now)

                    For j = 0 To 29
                        a1 = Hex(response(7 + i * 121 + 4 * j))
                        a2 = Hex(response(8 + i * 121 + 4 * j))
                        a3 = Hex(response(9 + i * 121 + 4 * j))
                        If a1.Length = 1 Then a1 = "0" + a1
                        If a2.Length = 1 Then a2 = "0" + a2
                        If a3.Length = 1 Then a3 = "0" + a3
                        wavelength = Val("&H" + a1 + a2 + a3) / 10000
                        mDemulatorData(i).GratingWavelength(j).Add(wavelength)
                    Next
                Next
            Catch ex As Exception
                LogError(response, ErrorCode(1))
                Return Nothing
            End Try

            response = GetWavelengthGroupData(DataGroup.SecondHalf)
            Try
                For i = 16 To ChannelCount - 1
                    mDemulatorData(i).SampleTime.Add(Now)
                    If mDemulatorData(i).GratingWavelength Is Nothing Then
                        ReDim mDemulatorData(i).GratingWavelength(29)
                        For j = 0 To GratingCount - 1
                            mDemulatorData(i).GratingWavelength(j) = New ArrayList()
                        Next
                    End If
                    For j = 0 To 29
                        a1 = Hex(response(7 + (i - 16) * 121 + 4 * j))
                        a2 = Hex(response(8 + (i - 16) * 121 + 4 * j))
                        a3 = Hex(response(9 + (i - 16) * 121 + 4 * j))
                        If a1.Length = 1 Then a1 = "0" + a1
                        If a2.Length = 1 Then a2 = "0" + a2
                        If a3.Length = 1 Then a3 = "0" + a3
                        wavelength = Val("&H" + a1 + a2 + a3) / 10000
                        mDemulatorData(i).GratingWavelength(j).Add(wavelength)
                    Next
                Next
            Catch ex As Exception
                LogError(response, ErrorCode(1))
                Return Nothing
            End Try

            Return mDemulatorData

        End Function

        Public Function GetWavelengthGroupData(ByVal group As DataGroup) As Byte()
            Dim sCmdHead(3), sCmd(5) As Byte
            Dim response() As Byte
            Dim CRC As UShort


            sCmdHead(0) = mDeviceID
            sCmdHead(1) = Int(FunctionCode.GetWavelengthByGroup)
            sCmdHead(2) = &H6
            If group = DataGroup.FirstHalf Then
                sCmdHead(3) = &H0
            Else
                sCmdHead(3) = &H1
            End If
            CRC = w2Math.CheckSum.CRC16(sCmdHead)


            For i = 0 To 3
                sCmd(i) = sCmdHead(i)
            Next
            sCmd(4) = CRC And &HFF
            sCmd(5) = CRC >> 8

            response = QueryByte(sCmd, 200)

            ' Query once again
            If response.Count < 1943 Then
                response = QueryByte(sCmd)
            End If

            If response.Count < 1943 Then
                LogError(response, ErrorCode(0))
                Return Nothing
            End If

            Return response

        End Function

        Public Function GetPower(ByVal channel As Integer) As Double()
            Dim sCmdHead(3), sCmd(5) As Byte
            Dim response() As Byte
            Dim CRC As UShort
            Dim a1, a2, a3 As String
            sCmdHead(0) = mDeviceID
            sCmdHead(1) = Int(FunctionCode.Power)
            sCmdHead(2) = &H6
            sCmdHead(3) = channel
            CRC = w2Math.CheckSum.CRC16(sCmdHead)

            For i As Integer = 0 To 3
                sCmd(i) = sCmdHead(i)
            Next
            sCmd(4) = CRC And &HFF
            sCmd(5) = CRC >> 8

            response = QueryByte(sCmd)

            ' Query once again
            If response.Count < 54 Then
                response = QueryByte(sCmd)
            End If

            If response.Count < 3 Then
                LogError(response, ErrorCode(0))
                Return Nothing
            End If

            Dim grateCount As Integer = response(2)
            grateCount = (grateCount - 6) / 4
            If response.Count < 4 * (grateCount - 1) Then
                LogError(response, ErrorCode(1))
                Return Nothing
            End If

            Try
                Dim power(grateCount - 1) As Double
                For i As Integer = 0 To grateCount - 1
                    a1 = Hex(response(5 + 4 * i))
                    a2 = Hex(response(6 + 4 * i))
                    a3 = Hex(response(7 + 4 * i))
                    If a1.Length = 1 Then a1 = "0" + a1
                    If a2.Length = 1 Then a2 = "0" + a2
                    If a3.Length = 1 Then a3 = "0" + a3
                    power(i) = CLng("&H" + a1 + a2 + a3 Or &HFFFF0000) / 10
                Next

                Return power
            Catch ex As Exception
                LogError(response, ErrorCode(1))
                Return Nothing
            End Try

        End Function

        Public Function GetRawData(ByVal channel As Integer) As ChannelRawDataStructure
            Dim sCmdHead(3), sCmd(5) As Byte
            Dim response() As Byte
            Dim CRC As UShort
            Dim a1, a2, a3 As String
            Dim startFreq, stepFreq, dataLength As Integer
            Dim rawData As ChannelRawDataStructure = New ChannelRawDataStructure()
            rawData.Frequency = New ArrayList()
            rawData.Power = New ArrayList()

            sCmdHead(0) = mDeviceID
            sCmdHead(1) = Int(FunctionCode.GetRawData)
            sCmdHead(2) = &H6
            sCmdHead(3) = channel
            CRC = w2Math.CheckSum.CRC16(sCmdHead)

            For i As Integer = 0 To 3
                sCmd(i) = sCmdHead(i)
            Next
            sCmd(4) = CRC And &HFF
            sCmd(5) = CRC >> 8

            response = QueryByte(sCmd, 1100)

            ' Query once again
            If response.Count < 54 Then
                response = QueryByte(sCmd, 100)
            End If

            If response.Count < 3 Then
                LogError(response, ErrorCode(0))
                Return Nothing
            End If

            dataLength = Val(response(2)) * 256 + Val(response(3))
            dataLength = (dataLength - 11) / 2

            If response.Count - 12 <> 2 * dataLength Then
                LogError(response, ErrorCode(1))
                Return Nothing
            End If

            'Get Start Frequency
            a1 = response(5)
            a2 = response(6)
            a3 = response(7)
            startFreq = Val(a1) * 65536 + Val(a2) * 256 + Val(a3)
            stepFreq = response(8)

            Try
                For i As Integer = 0 To dataLength - 3
                    a1 = response(9 + 2 * i)
                    a2 = response(10 + 2 * i)

                    rawData.Frequency.Add(startFreq + stepFreq * i)
                    rawData.Power.Add(256 * Val(a1) + Val(a2))
                Next

                Return rawData
            Catch ex As Exception
                LogError(response, ErrorCode(1))
                Return Nothing
            End Try

        End Function

        Public Function QueryString(ByVal sCmd As String) As String
            Dim s As String

            SendCmd(sCmd)

            s = mPort.ReadExisting()
            Return s
        End Function

        Public Function QueryHexString(ByVal sCmd As String) As String
            Dim s As String = Nothing
            Dim t As String = Nothing
            Dim i, n As Integer
            Dim hexBytes() As Byte

            Dim ex As Exception = Nothing

            Try
                SendCmd(sCmd)

                i = 0
                While mPort.BytesToRead < 1
                    System.Threading.Thread.Sleep(200)
                    i = i + 1
                    If i > 30 Then Return vbNullString
                End While
                System.Threading.Thread.Sleep(2000)

                n = mPort.BytesToRead
                i = mPort.ReadBufferSize()
                ReDim hexBytes(n - 1)
                For i = 0 To n - 1
                    hexBytes(i) = mPort.ReadByte()
                    's += hexBytes(i)
                    'If hexBytes(i) = 10 Or hexBytes(i) = 58 Or hexBytes(i) = 45 Or hexBytes(i) = 46 Then
                    '    s += Chr(hexBytes(i))
                    'ElseIf hexBytes(i) = 44 Then
                    '    s += Chr(hexBytes(i)) + vbTab
                    'Else
                    t = Convert.ToString(hexBytes(i), 16).ToUpper
                    If t.Length = 1 Then t = "0" + t
                    s += t    ' + " "
                    'End If
                Next

                Return s
            Catch ex
                'return error for failing to open port
                MessageBox.Show(ex.Message, "ITLA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return vbNullString
            End Try

        End Function

        Public Function QueryValue(ByVal sCmd As String) As Double
            Dim s As String = QueryString(sCmd)
            If IsNumeric(s) Then
                Return Convert.ToDouble(s)
            Else
                Return Double.NaN
            End If
        End Function

        Public Function QueryByte(ByVal sCmd() As Byte) As Byte()
            Dim response() As Byte
            response = QueryByte(sCmd, 70)
            Return response
        End Function

        Public Function QueryByte(ByVal sCmd() As Byte, ByVal delay_ms As Integer) As Byte()
            mPort.DiscardOutBuffer()
            mPort.DiscardInBuffer()
            mPort.Write(sCmd, 0, sCmd.Length)

            Dim i, j As Integer
            If delay_ms > 200 Then
                i = delay_ms / 200
                For j = 0 To i - 1
                    System.Threading.Thread.Sleep(200)
                Next
            Else
                System.Threading.Thread.Sleep(delay_ms)
            End If
            Dim response() As Byte
            Dim bytesToRead As Integer
            bytesToRead = mPort.BytesToRead
            ReDim response(bytesToRead)
            For i = 0 To bytesToRead - 1
                response(i) = mPort.ReadByte()
            Next
            Return response
        End Function

        Protected Sub SendCmd(ByVal sCmd As String)
            'clear buffer
            mPort.DiscardOutBuffer()
            mPort.DiscardInBuffer()
            mPort.ReadExisting()
            'send command
            sCmd += ControlChars.CrLf
            mPort.Write(sCmd)

            System.Threading.Thread.Sleep(100)
        End Sub

        Public Sub SendCommandAndClearBuffer(ByVal sCmd As String)
            SendCmd(sCmd)
            ClearInputBuffer()
        End Sub

        Public Function ReadLine() As String
            Dim s As String

            Try
                s = mPort.ReadLine()
                s = s.Replace(ControlChars.Lf, "")
            Catch ex As Exception
                Return ""
            End Try

            Return s
        End Function

        Public Sub ClearInputBuffer()
            Try
                mPort.NewLine = ">"
                mPort.ReadLine()
            Catch ex As Exception
                'ignore
            End Try
            mPort.NewLine = ControlChars.Lf
        End Sub

        Public Sub Close()
            If Not mPort Is Nothing Then mPort.Close()
            If Not csvLog Is Nothing Then csvLog.Close()
        End Sub
    End Class

End Namespace

