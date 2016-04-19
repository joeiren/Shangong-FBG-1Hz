Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraCharts
Imports ArcOpt.Opring.Utils
Imports ArcOpt.Opring.Instrument
Imports ArcOpt.Opring.Algorithms
Imports System.IO
Imports GlobalModel
Imports SG.PhysicDataHandle

Public Class frmMain
    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()

        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime

        mEntry = New HandleEntry()
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        NavBarGroupControlContainer1.Height = navBarControl.Height - 70
        DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(Me, GetType(SplashScreen1), True, True)
        Me.SetupGUI()
        Me.InitChart()
        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()

    End Sub

    Private Sub frmMain_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        NavBarGroupControlContainer1.Height = navBarControl.Height - 70
        gcData.Height = NavBarGroupControlContainer1.Height - gcData.Top + NavBarGroupControlContainer1.Top
    End Sub

    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
    End Sub

    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub

    Private Sub SetupGUI()
        For Each port As String In IO.Ports.SerialPort.GetPortNames
            cbCom.Items.Add(port)
        Next
        cbCom.Sorted = True
        If cbCom.Items.Count > 0 Then cbCom.Text = cbCom.Items(0).ToString()

        cbBaud.Text = 115200
        cbBaud.Items.Add("115200")
        cbBaud.Items.Add("19200")
        cbBaud.Items.Add("9600")

        mIniFile = New cIniFile(IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "System.ini"))
        Dim value As String
        mComDataBit = mIniFile.ReadIni("COM", "DataBits", 8)
        value = mIniFile.ReadIni("COM", "Parity", 0)
        mComParity = [Enum].Parse(GetType(IO.Ports.Parity), value)
        value = mIniFile.ReadIni("COM", "StopBit", 1)
        mComStopBit = [Enum].Parse(GetType(IO.Ports.StopBits), value)
        mComTimeOut = mIniFile.ReadIni("COM", "TimeOut", 3)

        value = mIniFile.ReadIni("Sweep", "ScanPower", 1)
        iScanPower.EditValue = value = 1
        value = mIniFile.ReadIni("Sweep", "ScanChannels", MaxChannelCount)
        eChRange.EditValue = value
        MaxChannelCount = value
        cbChannel.Items.Clear()
        For i As Integer = 1 To MaxChannelCount
            cbChannel.Items.Add(i)
        Next
        cbChannel.Text = 1
        cbGrating.Items.Clear()
        For i As Integer = 1 To 30
            cbGrating.Items.Add(i)
        Next
        cbGrating.Text = 1

    End Sub

    Private Sub InitChart()
        Dim fileName As String
        fileName = Application.StartupPath + "\Data\Dummy.csv"

        If File.Exists(fileName) Then
            LoadFileDataToPlot(fileName)
        End If

    End Sub

    Private Sub iConnect_ItemClick(sender As Object, e As ItemClickEventArgs) Handles iConnect.ItemClick
        Dim success As Boolean

        mInstFBG = New Inst_FBGDemodulator()
        success = mInstFBG.Initialize(cbCom.Text, cbBaud.Text, mComParity, mComStopBit, mComTimeOut, False)
        If Not success Then
            MessageBox.Show("Failed to connect to Tunable Laser Module", "FBG", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        MessageBox.Show("TLM is connected!", "FBG", MessageBoxButtons.OK, MessageBoxIcon.Information)
        iConnect.Enabled = False
        txtSN.Text = mInstFBG.SN


    End Sub
    Private Sub iDisconnect_ItemClick(sender As Object, e As ItemClickEventArgs) Handles iDisconnect.ItemClick
        If mInstFBG IsNot Nothing Then
            mInstFBG.Close()
            mInstFBG = Nothing
        End If
        iConnect.Enabled = True
    End Sub
    Private Sub iStartSweep_ItemClick(sender As Object, e As ItemClickEventArgs) Handles iStartSweep.ItemClick
        Dim success As Boolean
        ReDim mWavelength(MaxChannelCount - 1)
        ReDim mPower(MaxChannelCount - 1)
        mSweepStartTime = Now
        mSweepInterval = mIniFile.ReadIni("Sweep", "TimeInterval", 2)
        mSaveInterval = mIniFile.ReadIni("Sweep", "TimeSaveInterval", 2)
        mScanChannels = eChRange.EditValue
        mIsGroupQuery = iGroupQuery.EditValue
        If mScanChannels < 1 Then mScanChannels = 1
        'If mScanChannels > MaxChannelCount Then mScanChannels = MaxChannelCount
        MaxChannelCount = mScanChannels

        mEntry.SetMaxChannelCount(MaxChannelCount)
        ReDim mChannelRawData(MaxChannelCount - 1)
        ReDim mDemulatorData(MaxChannelCount - 1)

        cbChannel.Items.Clear()
        For i As Integer = 1 To MaxChannelCount
            cbChannel.Items.Add(i)
        Next

        'make sure first reading will be saved
        mLastSaveTime = Now.Subtract(New TimeSpan(0, 0, mSaveInterval + 1))

        For i As Integer = 0 To mDemulatorData.Length - 1
            mDemulatorData(i).SampleTime = New List(Of Date)
            mDemulatorData(i).GratingWavelength = Nothing
            mDemulatorData(i).GratingPower = Nothing
        Next
        If mSeriesScan IsNot Nothing Then
            mSeriesScan.Points.Clear()
            mSeriesScan = Nothing
        End If

        If IsNumeric(cbChannel.Text) Then
            mChannel = cbChannel.Text
        Else
            mChannel = 1
        End If
        If IsNumeric(cbGrating.Text) Then
            mGrating = cbGrating.Text
        Else
            mGrating = 1
        End If

        mIsDebugMode = iDebugMode.EditValue
        If mIsDebugMode Then
            ShowChartwavelength(False)
        Else
            ShowChartwavelength(True)
        End If

        If mInstFBG Is Nothing Then
            MessageBox.Show("Please connect to module first!", "FBG", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            siInfo.Caption = "Sweep Running..."
            ChartWavelength.Series.Clear()
            timerSweep.Interval = 1000 * mSweepInterval
            timerSweep.Enabled = True
        End If
    End Sub

    Private Sub iStopSweep_ItemClick(sender As Object, e As ItemClickEventArgs) Handles iStopSweep.ItemClick
        timerSweep.Enabled = False
        MessageBox.Show("Sweept Stopped!", "FBG", MessageBoxButtons.OK, MessageBoxIcon.Information)
        siInfo.Caption = "Sweep Stopped!"
        SaveRawData()
    End Sub

    Private Sub timerSweep_Tick(sender As Object, e As EventArgs) Handles timerSweep.Tick
        Try
            Application.DoEvents()
            If Not mInstFBG.SweepDone Then Return

            If mIsDebugMode Then
                GetRawData()

            Else
                If mIsGroupQuery Then
                    GetWavelengthDataByGroup()
                    mEntry.DataHanleEntry(mDemulatorData)
                Else
                    GetWavelengthData()

                    mEntry.DataHanleEntry(mDemulatorData)
                End If

                If iScanPower.EditValue Then
                    GetPowerData()
                End If
                UpdateGrids()
            End If

        Catch ex As Exception
            timerSweep.Enabled = False
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub GetRawData()

        ' If cbChannel.Text >= 1 Then mChannel = cbChannel.Text

        ' For i As Integer = 0 To MaxChannelCount - 1
        mChannelRawData(mChannel - 1) = mInstFBG.GetRawData(mChannel - 1)
        ' Next

        SaveRawData_Debug()

        UpdateChart_Debug()

    End Sub

    Private Sub GetWavelengthData()
        Dim t As Date
        Dim d() As Double

        ' total 16 channels, there are multiple wavelengths per channel
        For i As Integer = 0 To mScanChannels - 1
            d = mInstFBG.GetWavelength(i)
            If d IsNot Nothing Then
                mWavelength(i) = d.ToArray()
                t = Now
                mDemulatorData(i).SampleTime.Add(t)
                If mDemulatorData(i).GratingWavelength Is Nothing Then
                    ReDim mDemulatorData(i).GratingWavelength(mWavelength(i).Length - 1)
                    For j As Integer = 0 To mWavelength(i).Length - 1
                        mDemulatorData(i).GratingWavelength(j) = New ArrayList()
                    Next
                End If
                For j As Integer = 0 To mWavelength(i).Length - 1
                    mDemulatorData(i).GratingWavelength(j).Add(mWavelength(i)(j))
                Next
            End If
        Next

        If cbChannel.Items.Count < 1 Then
            cbChannel.Items.Clear()
            For i As Integer = 1 To MaxChannelCount
                cbChannel.Items.Add(i)
            Next

            cbGrating.Items.Clear()
            For i As Integer = 1 To mWavelength(0).Length
                cbGrating.Items.Add(i)
            Next

        End If

        SaveRawData()

        UpdateChart()


    End Sub

    Private Sub GetWavelengthDataByGroup()
        Dim t As Date

        ' total 32 channels * 30 grating
        mDemulatorData = mInstFBG.GetWavelengthByGroup()

        For i As Integer = 0 To mDemulatorData.Count - 1
            Dim d(29) As Double
            mWavelength(i) = d
            For j As Integer = 0 To 29
                mWavelength(i)(j) = mDemulatorData(i).GratingWavelength(j)(0)
            Next
        Next

        If cbChannel.Items.Count < 1 Then
            cbChannel.Items.Clear()
            For i As Integer = 1 To MaxChannelCount
                cbChannel.Items.Add(i)
            Next
            cbChannel.Text = 1
            cbGrating.Items.Clear()
            For i As Integer = 1 To 30
                cbGrating.Items.Add(i)
            Next
            cbGrating.Text = 1
        End If

        SaveRawData()

        UpdateChart()


    End Sub

    Private Sub GetPowerData()
        Dim t As Date
        Dim d() As Double

        ' total 16 channels, there are multiple wavelengths per channel
        For i As Integer = 0 To mScanChannels - 1
            d = mInstFBG.GetPower(i)
            If d IsNot Nothing Then
                mPower(i) = d.ToArray()
                't = Now
                'mDemulatorData(i).SampleTime.Add(t)
                If mDemulatorData(i).GratingPower Is Nothing Then
                    ReDim mDemulatorData(i).GratingPower(mPower(i).Length - 1)
                    For j As Integer = 0 To mWavelength(i).Length - 1
                        mDemulatorData(i).GratingPower(j) = New ArrayList()
                    Next
                End If
                For j As Integer = 0 To mPower(i).Length - 1
                    mDemulatorData(i).GratingPower(j).Add(mPower(i)(j))
                Next
            End If
        Next

        If cbChannel.Items.Count < 1 Then
            cbChannel.Items.Clear()
            For i As Integer = 1 To 16
                cbChannel.Items.Add(i)
            Next
            cbChannel.Text = 1

            cbGrating.Items.Clear()
            For i As Integer = 1 To mPower(0).Length
                cbGrating.Items.Add(i)
            Next
            cbGrating.Text = 1
        End If

        SaveRawData_Power()

        UpdateChart_Power()

    End Sub

    Private Sub UpdateChart()

        If mDemulatorData Is Nothing Then Return
        If mDemulatorData(0).GratingWavelength Is Nothing Then Return

        Dim ChartTimeSpan As Integer = mIniFile.ReadIni("Sweep", "ChartTimeSpan", 120)
        Dim minDate As DateTime = Now.AddSeconds(-ChartTimeSpan)
        Dim pointsToRemoveCount As Integer

        Try
            If mSeriesScan Is Nothing Then
                mSeriesScan = New Series("Wave" + mGrating.ToString() + "_Ch" + mChannel.ToString(), ViewType.SwiftPlot)
                mSeriesScan.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime

                Dim lineView As SwiftPlotSeriesView = New SwiftPlotSeriesView()
                lineView.LineStyle.Thickness = 2
                mSeriesScan.View = lineView
                ChartWavelength.Series.Add(mSeriesScan)

                mSeriesScan.Points.BeginUpdate()
                For i As Integer = 0 To mDemulatorData(mChannel - 1).SampleTime.Count - 1
                    mSeriesScan.Points.Add(New SeriesPoint(mDemulatorData(mChannel - 1).SampleTime(i), mDemulatorData(mChannel - 1).GratingWavelength(mGrating - 1)(i)))
                Next

                mSeriesScan.Points.EndUpdate()
            End If

            mSeriesScan.Points.BeginUpdate()
            For Each dPoint As SeriesPoint In mSeriesScan.Points
                If dPoint.DateTimeArgument < minDate Then
                    pointsToRemoveCount += 1
                End If
            Next
            Dim j As Integer = mDemulatorData(0).SampleTime.Count
            mSeriesScan.Points.Add(New SeriesPoint(mDemulatorData(mChannel - 1).SampleTime(j - 1), mDemulatorData(mChannel - 1).GratingWavelength(mGrating - 1)(j - 1)))
            If pointsToRemoveCount > 0 Then
                mSeriesScan.Points.RemoveRange(0, pointsToRemoveCount)
            End If
            mSeriesScan.Points.EndUpdate()

            Dim xyDiagram As DevExpress.XtraCharts.SwiftPlotDiagram
            xyDiagram = ChartWavelength.Diagram
            xyDiagram.AxisY.VisualRange.AutoSideMargins = False
            xyDiagram.AxisX.VisualRange.AutoSideMargins = True
            xyDiagram.AxisX.WholeRange.AutoSideMargins = True

            Dim min, max As Double
            Dim subArray As List(Of Double) = New List(Of Double)
            If mSeriesScan.Points.Count > 2 Then
                'For j = pointsToRemoveCount + 1 To mDemulatorData(mChannel - 1).GratingWavelength(mGrating - 1).Count - 1
                '    subArray.Add(mDemulatorData(mChannel - 1).GratingWavelength(mGrating - 1)(j))
                'Next
                For j = 0 To mSeriesScan.Points.Count - 1
                    subArray.Add(mSeriesScan.Points(j).Values(0))
                Next
                min = subArray.Min    'mDemulatorData(mChannel - 1).GratingWavelength(mGrating - 1).ToArray.Min
                max = subArray.Max   'mDemulatorData(mChannel - 1).GratingWavelength(mGrating - 1).ToArray.Max

                If max - min < 0.01 Then
                    xyDiagram.AxisY.VisualRange.MaxValue = max + 0.5 * (0.01 - max + min)
                    xyDiagram.AxisY.VisualRange.MinValue = min - 0.5 * (0.01 - max + min)
                Else
                    xyDiagram.AxisY.VisualRange.MinValue = min - 0.5 * (max - min)
                    xyDiagram.AxisY.VisualRange.MaxValue = max + 0.5 * (max - min)
                End If

                xyDiagram.AxisY.VisualRange.SideMarginsValue = 0
            End If

            xyDiagram.AxisY.GridLines.LineStyle.DashStyle = DashStyle.Dash
            xyDiagram.AxisY.GridLines.Visible = True
            xyDiagram.AxisX.VisualRange.Auto = True

            'Application.DoEvents()
            ChartWavelength.Update()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub UpdateChart_Power()

        If mDemulatorData Is Nothing Then Return
        If mDemulatorData(0).GratingWavelength Is Nothing Then Return

        Try
            ChartPower.Series.Clear()
            mSeriesPowerWavelength = Nothing
            If mSeriesPowerWavelength Is Nothing Then
                mSeriesPowerWavelength = New Series("Ch" + mChannel.ToString(), ViewType.Point)

                mSeriesPowerWavelength.ArgumentScaleType = ScaleType.Numerical
                ChartPower.Series.Add(mSeriesPowerWavelength)

                mSeriesPowerWavelength.Points.BeginUpdate()
                For i As Integer = 0 To mDemulatorData(mChannel - 1).GratingWavelength.Count - 1
                    Dim lastIndex As Integer = mDemulatorData(mChannel - 1).GratingWavelength(i).Count - 1
                    If mDemulatorData(mChannel - 1).GratingWavelength(i)(lastIndex) <> 0 Then
                        mSeriesPowerWavelength.Points.Add(New SeriesPoint(mDemulatorData(mChannel - 1).GratingWavelength(i)(lastIndex), mDemulatorData(mChannel - 1).GratingPower(i)(lastIndex)))
                    End If
                Next

                mSeriesPowerWavelength.Points.EndUpdate()
            End If

            ChartPower.Series(0).LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            ChartPower.Series(0).Label.PointOptions.Pattern = "{V}" '"{A}:{V}"
            ChartPower.Series(0).Label.LineLength = 25
            'ChartPower.Series(0).Label

            Dim xyDiagram As XYDiagram = ChartPower.Diagram
            xyDiagram.AxisX.Title.Text = "Wavelength (nm)"
            xyDiagram.AxisY.Title.Text = "Power (dBm)"

            ChartPower.Update()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub UpdateChart_Debug()

        If mChannelRawData Is Nothing Then Return

        Try
            ChartPower.Series.Clear()
            ChartPower.Update()
            mSeriesPowerWavelength = Nothing
            If mSeriesPowerWavelength Is Nothing Then
                mSeriesPowerWavelength = New Series("Ch" + mChannel.ToString(), ViewType.Line)

                mSeriesPowerWavelength.ArgumentScaleType = ScaleType.Numerical
                ChartPower.Series.Add(mSeriesPowerWavelength)

                mSeriesPowerWavelength.Points.BeginUpdate()
                For i As Integer = 0 To mChannelRawData(mChannel - 1).Frequency.Count - 1
                    mSeriesPowerWavelength.Points.Add(New SeriesPoint(299792458 / mChannelRawData(mChannel - 1).Frequency(i), mChannelRawData(mChannel - 1).Power(i)))
                Next

                mSeriesPowerWavelength.Points.EndUpdate()
            End If

            Dim xyDiagram As XYDiagram = ChartPower.Diagram
            xyDiagram.AxisX.Title.Text = "Frequency_GHz"
            xyDiagram.AxisY.Title.Text = "ADC"

            ChartPower.Update()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub UpdateGrids()

        dtData = New DataTable("Results")
        dtData.Columns.Add("Channel", GetType(Integer))
        dtData.Columns.Add("Parameter", GetType(String))
        dtData.Columns.Add("Wavelength(nm)", GetType(Double))
        dtData.Columns.Add("Power(dBm)", GetType(Double))

        If mWavelength Is Nothing Then
            dtData.Rows.Add("1", "Wave_0", 1564)
        Else
            For i As Integer = 1 To mScanChannels  'mWavelength.Length
                Dim emptyChannel As Boolean = True
                For j As Integer = 1 To mWavelength(i - 1).Length
                    If mWavelength(i - 1)(j - 1) <> 0 Then
                        emptyChannel = False
                        If iScanPower.EditValue Then
                            dtData.Rows.Add(i.ToString(), "Wave_" + j.ToString(), mWavelength(i - 1)(j - 1).ToString(), mPower(i - 1)(j - 1).ToString())
                        Else
                            dtData.Rows.Add(i.ToString(), "Wave_" + j.ToString(), mWavelength(i - 1)(j - 1).ToString(), Double.NaN)
                        End If
                    End If
                Next

                If emptyChannel Then dtData.Rows.Add(i.ToString(), "No Signal", 0)
            Next
        End If

        gcData.DataMember = Nothing
        gcData.DataSource = dtData
    End Sub

    Private Sub cbGrating_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGrating.SelectedIndexChanged
        If IsNumeric(cbChannel.Text) Then
            mChannel = cbChannel.Text
        Else
            mChannel = 1
        End If
        If IsNumeric(cbGrating.Text) Then
            mGrating = cbGrating.Text
        Else
            mGrating = 1
        End If

        If Not mIsDebugMode And mSeriesScan IsNot Nothing Then
            If ChartWavelength.Series.Contains(mSeriesScan) Then ChartWavelength.Series.Remove(mSeriesScan)
            mSeriesScan.Points.Clear()
            mSeriesScan = Nothing

            UpdateChart()
        End If
    End Sub

    Private Sub cbChannel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbChannel.SelectedIndexChanged
        If IsNumeric(cbChannel.Text) Then
            mChannel = cbChannel.Text
        Else
            mChannel = 1
        End If
        If IsNumeric(cbGrating.Text) Then
            mGrating = cbGrating.Text
        Else
            mGrating = 1
        End If

        If Not mIsDebugMode And mSeriesScan IsNot Nothing Then
            If ChartWavelength.Series.Contains(mSeriesScan) Then ChartWavelength.Series.Remove(mSeriesScan)
            mSeriesScan.Points.Clear()
            mSeriesScan = Nothing

            UpdateChart()
        End If
    End Sub


    Private Sub iLoadData_ItemClick(sender As Object, e As ItemClickEventArgs) Handles iLoadData.ItemClick
        Dim fileName As String
        Dim fileDialogue As OpenFileDialog = New OpenFileDialog()
        fileDialogue.InitialDirectory = Application.StartupPath + "\Data"
        fileDialogue.Title = "Save Plot"
        If fileDialogue.ShowDialog = Windows.Forms.DialogResult.OK Then
            fileName = fileDialogue.FileName
            LoadFileDataToPlot(fileName)
        Else
            Return
        End If
    End Sub

    Private Sub iExport_ItemClick(sender As Object, e As ItemClickEventArgs) Handles iExport.ItemClick
        Dim fileName, ext As String
        Dim fileDialogue As SaveFileDialog = New SaveFileDialog()
        fileDialogue.InitialDirectory = Application.StartupPath + "\Data"
        fileDialogue.Title = "Save Plot"
        If fileDialogue.ShowDialog = Windows.Forms.DialogResult.OK Then
            fileName = fileDialogue.FileName
            ext = fileDialogue.FileName.Split("."c)(1)
        Else
            Return
        End If

        Dim chart As ChartControl = ChartWavelength
        If chart IsNot Nothing Then
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            If ext = "rtf" Then
                chart.ExportToRtf(fileName)
            ElseIf ext = "pdf" Then
                chart.ExportToPdf(fileName)
            ElseIf ext = "mht" Then
                chart.ExportToMht(fileName)
            ElseIf ext = "html" Then
                chart.ExportToHtml(fileName)
            ElseIf ext = "xls" Then
                chart.ExportToXls(fileName)
            ElseIf ext = "xlsx" Then
                chart.ExportToXlsx(fileName)
            Else
                chart.ExportToImage(fileName, Imaging.ImageFormat.Png)
            End If
            Cursor.Current = currentCursor
        End If
    End Sub

    Private Sub iChartWizard_ItemClick(sender As Object, e As ItemClickEventArgs) Handles iChartWizard.ItemClick

        Dim chartWizard As New Wizard.ChartWizard(ChartWavelength)
        chartWizard.ShowDialog()
        ChartWavelength.Update()

    End Sub

    Private Sub iPrintPreview_ItemClick(sender As Object, e As ItemClickEventArgs) Handles iPrintPreview.ItemClick
        ChartWavelength.OptionsPrint.SizeMode = Printing.PrintSizeMode.Zoom
        ChartWavelength.ShowPrintPreview()
    End Sub

    Private Sub LoadFileDataToPlot(ByVal fileName As String)
        Dim csvReader As CsvAccess = New CsvAccess()
        Dim fileLines As List(Of String())
        fileLines = csvReader.ReadFile(fileName)
        Dim dataPoints As Integer = fileLines.Count - 2

        UpdateChart()
        UpdateGrids()

    End Sub


    Private Sub SaveRawData()
        Dim fileName As String
        Dim s As String
        Dim columns() As String
        Dim gratingCount As Integer
        Dim csvRaw As csvWriter
        Dim i, j, k As Integer

        Try
            If Now.Subtract(mLastSaveTime).TotalSeconds < mSaveInterval - 0.5 * mSweepInterval Then Return

            For i = 0 To MaxChannelCount - 1
                gratingCount = mDemulatorData(i).GratingWavelength.Length - 1
                ReDim columns(gratingCount)
                fileName = Application.StartupPath + "\Data\" + txtSN.Text + "_Wavelength_" + "CH" + i.ToString() + "_" + mSweepStartTime.ToString("yyyyMMddHHmmss") + "_Raw.csv"

                columns(0) = "Time"
                For j = 1 To gratingCount
                    columns(j) = "Wavelength_" + j.ToString()
                Next

                csvRaw = New csvWriter(fileName, columns)

                k = mDemulatorData(i).SampleTime.Count - 1
                s = mDemulatorData(i).SampleTime(k).ToString("yyyyMMdd HH:mm:ss")
                For j = 0 To gratingCount - 1
                    s += "," + mDemulatorData(i).GratingWavelength(j)(k).ToString()
                Next
                csvRaw.AppendLine(s)

                csvRaw.Close()
            Next
        Catch
            If csvRaw IsNot Nothing Then csvRaw.Close()
        End Try

        mLastSaveTime = Now
    End Sub

    Private Sub SaveRawData_Power()
        Dim fileName As String
        Dim s As String
        Dim columns() As String
        Dim gratingCount As Integer
        Dim csvRaw As csvWriter
        Dim i, j, k As Integer

        Try
            If Now.Subtract(mLastSaveTime).TotalSeconds < mSaveInterval - 0.5 * mSweepInterval Then Return

            For i = 0 To MaxChannelCount - 1
                gratingCount = mDemulatorData(i).GratingWavelength.Length - 1
                ReDim columns(gratingCount)
                fileName = Application.StartupPath + "\Data\" + txtSN.Text + "_Power_" + "CH" + i.ToString() + "_" + mSweepStartTime.ToString("yyyyMMddHHmmss") + "_Raw.csv"

                columns(0) = "Time"
                For j = 1 To gratingCount
                    columns(j) = "Power_" + j.ToString()
                Next

                csvRaw = New csvWriter(fileName, columns)

                k = mDemulatorData(i).SampleTime.Count - 1
                s = mDemulatorData(i).SampleTime(k).ToString("yyyyMMdd HH:mm:ss")
                For j = 0 To gratingCount - 1
                    s += "," + mDemulatorData(i).GratingPower(j)(k).ToString()
                Next
                csvRaw.AppendLine(s)

                csvRaw.Close()
            Next
        Catch
            If csvRaw IsNot Nothing Then csvRaw.Close()
        End Try

        mLastSaveTime = Now
    End Sub

    Private Sub SaveRawData_Debug()
        Dim fileName As String
        Dim s, t As String
        Dim columns() As String
        Dim csvRaw As csvWriter
        Dim i, j, k As Integer

        Try
            If Now.Subtract(mLastSaveTime).TotalSeconds < mSaveInterval - 0.5 * mSweepInterval Then Return

            For i = 0 To MaxChannelCount - 1
                If i <> mChannel - 1 Then Continue For
                If mChannelRawData(i).Frequency Is Nothing Then Continue For
                If mChannelRawData(i).Frequency.Count = 0 Then Continue For

                ReDim columns(2)
                fileName = Application.StartupPath + "\Data\" + txtSN.Text.ToString() + "_CH" + i.ToString() + "_Debug_Raw.csv"

                columns(0) = "Time"
                columns(1) = "Frequency"
                columns(2) = "Power"

                csvRaw = New csvWriter(fileName, columns)

                t = Now.ToString("yyyyMMdd HH:mm:ss")
                For j = 0 To mChannelRawData(i).Frequency.Count - 1
                    s = t + "," + mChannelRawData(i).Frequency(j).ToString() + "," + mChannelRawData(i).Power(j).ToString()
                    csvRaw.AppendLine(s)
                Next


                csvRaw.Close()
            Next
        Catch ex As Exception
            If csvRaw IsNot Nothing Then csvRaw.Close()
        End Try

        mLastSaveTime = Now
    End Sub

#Region "member"
    Private mIniFile As cIniFile
    Private mComDataBit As Integer
    Private mComParity As IO.Ports.Parity
    Private mComStopBit As IO.Ports.StopBits
    Private mComTimeOut As Double

    Private mWavelength() As Array
    Private mPower() As Array
    Private mDemulatorData(MaxChannelCount - 1) As ChannelDataStructure
    Private mSeriesScan As Series
    Private mSeriesPowerWavelength As Series
    Private mChannel As Integer
    Private mGrating As Integer
    Private mSweepStartTime As Date
    Private mSweepInterval As Integer
    Private mSaveInterval As Integer
    Private mLastSaveTime As Date
    Private mScanChannels As Integer

    Private dtData As DataTable

    Private mInstFBG As Inst_FBGDemodulator

    Private mChannelRawData(MaxChannelCount - 1) As Inst_FBGDemodulator.ChannelRawDataStructure
    Private fRawData As frmRawData

    Private mIsDebugMode As Boolean

    Private mIsGroupQuery As Boolean

    Private MaxChannelCount As Integer = 32

    Dim mEntry As New HandleEntry
#End Region

    Private Sub iScanPower_EditValueChanged(sender As Object, e As EventArgs) Handles iScanPower.EditValueChanged
        ShowChartPower(iScanPower.EditValue)
    End Sub

    Private Sub ShowChartPower(ByVal ToShow As Boolean)
        If ToShow Then
            Me.LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            Me.LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.Refresh()
        End If
    End Sub

    Private Sub ShowChartwavelength(ByVal ToShow As Boolean)
        If ToShow Then
            Me.LayoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            Me.LayoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.Refresh()
        End If
    End Sub

End Class

'Public Structure ChannelDataStructure
'    Public GratingCount As Integer
'    Public SampleTime As List(Of Date)
'    Public GratingWavelength() As ArrayList
'    Public GratingPower() As ArrayList
'End Structure


