Imports System.IO
Imports System.Text

Namespace Opring.Utils
    Public Class CsvAccess
        Implements IDisposable

        Public Sub New()
            reader = Nothing
            writer = Nothing
        End Sub

        Public Sub OpenFile(ByVal csvFile As String)
            reader = New StreamReader(csvFile)
        End Sub

        Public Sub CloseFile()
            Me.Dispose(True)
        End Sub

        Public Function GetLine() As String()
            Dim line As String = reader.ReadLine()
            If line Is Nothing Then Return Nothing
            Dim elemsInLine() As String = line.Split(","c)
            Return elemsInLine
        End Function

        Public Function ReadFile(ByVal csvFile As String) As List(Of String())
            Me.OpenFile(csvFile)
            Dim fileLines As List(Of String()) = New List(Of String())()
            Dim lineElems() As String
            While True
                lineElems = Me.GetLine()
                If lineElems Is Nothing Then Exit While
                fileLines.Add(lineElems)
            End While
            Me.CloseFile()
            Return fileLines
        End Function

#Region "IDisposable Support"
        Private disposedValue As Boolean ' 检测冗余的调用

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO:  释放托管状态(托管对象)。
                    If reader IsNot Nothing Then
                        reader.Dispose()
                        reader = Nothing
                    End If
                    If writer IsNot Nothing Then
                        writer.Dispose()
                        writer = Nothing
                    End If
                End If

                ' TODO:  释放非托管资源(非托管对象)并重写下面的 Finalize()。
                ' TODO:  将大型字段设置为 null。
            End If
            Me.disposedValue = True
        End Sub

        ' TODO:  仅当上面的 Dispose(ByVal disposing As Boolean)具有释放非托管资源的代码时重写 Finalize()。
        'Protected Overrides Sub Finalize()
        '    ' 不要更改此代码。    请将清理代码放入上面的 Dispose(ByVal disposing As Boolean)中。
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' Visual Basic 添加此代码是为了正确实现可处置模式。
        Public Sub Dispose() Implements IDisposable.Dispose
            ' 不要更改此代码。    请将清理代码放入上面的 Dispose (disposing As Boolean)中。
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region


        Private reader As StreamReader
        Private writer As StreamWriter
    End Class

    Public Class csvWriter
        Private sw As StreamWriter
        Public Sub New(ByVal sFileName As String, ByVal columns As DataGridViewColumnCollection)
            Try
                sw = New StreamWriter(New FileStream(sFileName, FileMode.Create), Encoding.GetEncoding("GB2312"))
                Dim strColu As StringBuilder = New StringBuilder()

                For i As Integer = 0 To columns.Count - 1
                    strColu.Append(columns(i).HeaderText)
                    strColu.Append(",")
                Next
                strColu.Remove(strColu.Length - 1, 1)
                sw.WriteLine(strColu)
                sw.Flush()
            Catch ex As Exception

            End Try

        End Sub

        Public Sub New(ByVal sFileName As String, ByVal columns() As String)

            If File.Exists(sFileName) Then
                sw = New StreamWriter(New FileStream(sFileName, FileMode.Append), Encoding.GetEncoding("GB2312"))
            Else
                Try
                    sw = New StreamWriter(New FileStream(sFileName, FileMode.Create), Encoding.GetEncoding("GB2312"))
                    Dim strColu As StringBuilder = New StringBuilder()

                    For i As Integer = 0 To columns.Count - 1
                        strColu.Append(columns(i))
                        strColu.Append(",")
                    Next
                    strColu.Remove(strColu.Length - 1, 1)
                    sw.WriteLine(strColu)
                    sw.Flush()
                Catch ex As Exception

                End Try
            End If
        End Sub

        Public Sub AppendLine(ByVal time As DateTime, ByVal values() As Double)
            Dim strValue As StringBuilder = New StringBuilder()

            strValue.Append(time)
            strValue.Append(",")
            For i As Integer = 0 To values.Count - 1
                strValue.Append(values(i))
                strValue.Append(",")
            Next
            strValue.Remove(strValue.Length - 1, 1)
            sw.WriteLine(strValue)
            sw.Flush()
        End Sub

        Public Sub AppendLine(ByVal ParamArray values() As Object)
            Dim strValue As StringBuilder = New StringBuilder()

            For i As Integer = 0 To values.Count - 1
                strValue.Append(values(i))
                strValue.Append(",")
            Next
            strValue.Remove(strValue.Length - 1, 1)
            sw.WriteLine(strValue)
            sw.Flush()
        End Sub

        Public Sub Close()
            sw.Close()
        End Sub



    End Class
End Namespace


