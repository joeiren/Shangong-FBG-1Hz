<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRawData
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XyDiagram3 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel3 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim PointOptions3 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim PointSeriesView5 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
        Dim PointSeriesView6 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
        Me.ChartPower = New DevExpress.XtraCharts.ChartControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cbChannel = New System.Windows.Forms.ComboBox()
        CType(Me.ChartPower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChartPower
        '
        Me.ChartPower.AppearanceNameSerializable = "Light"
        XyDiagram3.AxisX.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        XyDiagram3.AxisX.Title.Text = "Wavelength (nm)"
        XyDiagram3.AxisX.Title.Visible = True
        XyDiagram3.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram3.AxisY.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        XyDiagram3.AxisY.Title.Text = "Power (dBm)"
        XyDiagram3.AxisY.Title.Visible = True
        XyDiagram3.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartPower.Diagram = XyDiagram3
        Me.ChartPower.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartPower.Location = New System.Drawing.Point(0, 0)
        Me.ChartPower.Name = "ChartPower"
        Me.ChartPower.PaletteName = "Default"
        PointSeriesLabel3.LineLength = 20
        PointOptions3.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.FixedPoint
        PointOptions3.ArgumentNumericOptions.Precision = 0
        PointOptions3.Pattern = "{A} : {V}"
        PointOptions3.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        PointSeriesLabel3.PointOptions = PointOptions3
        PointSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint
        Series3.Label = PointSeriesLabel3
        Series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series3.Name = "Series 1"
        Series3.View = PointSeriesView5
        Me.ChartPower.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3}
        Me.ChartPower.SeriesTemplate.View = PointSeriesView6
        Me.ChartPower.Size = New System.Drawing.Size(749, 346)
        Me.ChartPower.TabIndex = 5
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.ChartPower)
        Me.PanelControl1.Location = New System.Drawing.Point(4, 48)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(749, 346)
        Me.PanelControl1.TabIndex = 6
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Controls.Add(Me.cbChannel)
        Me.PanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(749, 43)
        Me.PanelControl2.TabIndex = 7
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(10, 10)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(21, 17)
        Me.LabelControl6.TabIndex = 32
        Me.LabelControl6.Text = "CH"
        '
        'cbChannel
        '
        Me.cbChannel.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChannel.FormattingEnabled = True
        Me.cbChannel.Location = New System.Drawing.Point(42, 7)
        Me.cbChannel.Name = "cbChannel"
        Me.cbChannel.Size = New System.Drawing.Size(134, 23)
        Me.cbChannel.TabIndex = 33
        '
        'frmRawData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 395)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmRawData"
        Me.Text = "fRawData"
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartPower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChartPower As DevExpress.XtraCharts.ChartControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbChannel As System.Windows.Forms.ComboBox
End Class
