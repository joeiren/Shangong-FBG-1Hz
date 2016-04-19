Imports System.Runtime.InteropServices
Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions

Namespace Opring.Utils
    Public Class cIniFile

        Private fileName As String
        Private fileContents As String = Nothing

        Public Sub New(ByVal fileName As String)
            Me.fileName = fileName

            If File.Exists(fileName) Then
                Dim reader As StreamReader = File.OpenText(fileName)
                fileContents = reader.ReadToEnd()
                reader.Close()
                reader.Dispose()
            End If
        End Sub

        Public ReadOnly Property SectionNames As String()
            Get
                Dim regexPattern As String = "/[(?<SectionName>/w*)/]"
                Dim r As Regex = New Regex(regexPattern)
                Dim matches As MatchCollection = r.Matches(fileContents)

                Dim results() As String
                ReDim results(matches.Count)
                For i As Integer = 0 To matches.Count - 1
                    results(i) = matches(i).Result("${SectionName}")
                Next
                Return results
            End Get
        End Property

        Public Function GetSectionString(ByVal sectionName As String) As String
            Dim regexPattern As String = "(/[" + sectionName + "/]" + "(?<SectionString>.*)/[)"
            Dim r As Regex = New Regex(regexPattern, RegexOptions.Singleline)
            If r.IsMatch(fileContents) Then
                Return r.Match(fileContents).Result("${SectionString}")
            End If

            Return String.Empty
        End Function

        Public Function GetKeyString(ByVal sectionName As String, ByVal keyName As String)
            Dim sectionString As String = GetSectionString(sectionName)
            Dim regexPattern As String = "(" + keyName + "=(?<value>.*)/r/n)"
            Dim r As Regex = New Regex(regexPattern)
            If r.IsMatch(fileContents) Then
                Return r.Match(fileContents).Result("${value}")
            End If

            Return String.Empty
        End Function

        '读取ini文件内容
        Public Function ReadIni(ByVal section As String, ByVal keyword As String, ByVal defaultValue As String, ByVal filepath As String) As String
            Dim str As String = LSet(str, 256)
            GetPrivateProfileString(section, keyword, defaultValue, str, Len(str), filepath)
            Return Microsoft.VisualBasic.Left(str, InStr(str, Chr(0)) - 1)
        End Function

        '写入Ini文件内容
        Public Function WriteIni(ByVal Section As String, ByVal keyword As String, ByVal defaultvalue As String, ByVal filepath As String) As Long
            WriteIni = WritePrivateProfileString(Section, keyword, defaultvalue, filepath)
        End Function


        Public Function ReadIni(ByVal section As String, ByVal keyword As String, ByVal defaultValue As String) As String
            Dim str As String = LSet(str, 256)
            GetPrivateProfileString(section, keyword, defaultValue, str, Len(str), fileName)
            Return Microsoft.VisualBasic.Left(str, InStr(str, Chr(0)) - 1)
        End Function

        '写入Ini文件内容
        Public Function WriteIni(ByVal Section As String, ByVal keyword As String, ByVal defaultvalue As String) As Long
            WriteIni = WritePrivateProfileString(Section, keyword, defaultvalue, fileName)
        End Function


        Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32

        Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    End Class

End Namespace

