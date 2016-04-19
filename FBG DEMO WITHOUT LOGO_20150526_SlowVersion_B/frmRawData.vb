Imports ArcOpt.Opring.Instrument.Inst_FBGDemodulator
Imports DevExpress.XtraCharts

Public Class frmRawData
    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        If cbChannel.Items.Count < 1 Then
            For i As Integer = 1 To 16
                cbChannel.Items.Add(i)
            Next
        End If
    End Sub

    Public Sub ShowData(ByVal rawData() As ChannelRawDataStructure)
        cbChannel.Text = 1
        mChannel = cbChannel.Text
        mRawData = rawData
        UpdateChart()
    End Sub

    Private Sub UpdateChart()

        If mRawData Is Nothing Then Return

        Try
            ChartPower.Series.Clear()
            mSeriesPowerWavelength = Nothing
            If mSeriesPowerWavelength Is Nothing Then
                mSeriesPowerWavelength = New Series("Ch" + mChannel.ToString(), ViewType.Point)

                mSeriesPowerWavelength.ArgumentScaleType = ScaleType.Numerical
                ChartPower.Series.Add(mSeriesPowerWavelength)

                mSeriesPowerWavelength.Points.BeginUpdate()
                For i As Integer = 0 To mRawData(mChannel - 1).Frequency.Count - 1
                    mSeriesPowerWavelength.Points.Add(New SeriesPoint(mRawData(mChannel - 1).Frequency(i), mRawData(mChannel - 1).Power(i)))
                Next

                mSeriesPowerWavelength.Points.EndUpdate()
            End If

            ChartPower.Series(0).LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            ChartPower.Series(0).Label.PointOptions.Pattern = "{A}:{V}"
            ChartPower.Series(0).Label.LineLength = 25
            'ChartPower.Series(0).Label
            ChartPower.Update()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmRawData_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private mRawData() As ChannelRawDataStructure
    Private mChannel As Integer
    Private mSeriesPowerWavelength As DevExpress.XtraCharts.Series

    Private Sub cbChannel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbChannel.SelectedIndexChanged
        mChannel = cbChannel.SelectedValue
        UpdateChart()
    End Sub
End Class