Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits RibbonForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.ArcOpt.SplashScreen1), True, True)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel2 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim PointOptions2 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim PointSeriesView3 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
        Dim PointSeriesView4 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
        Dim SwiftPlotDiagram2 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
        Dim Series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView4 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim Series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SwiftPlotSeriesView5 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Dim SwiftPlotSeriesView6 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
        Me.splitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.navBarControl = New DevExpress.XtraNavBar.NavBarControl()
        Me.controlGroup = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSN = New DevExpress.XtraEditors.TextEdit()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.appMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.popupControlContainer2 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.buttonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.iLoadData = New DevExpress.XtraBars.BarButtonItem()
        Me.iExit = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.iHelp = New DevExpress.XtraBars.BarButtonItem()
        Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
        Me.siInfo = New DevExpress.XtraBars.BarStaticItem()
        Me.alignButtonGroup = New DevExpress.XtraBars.BarButtonGroup()
        Me.iBoldFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.iItalicFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.iUnderlinedFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.fontStyleButtonGroup = New DevExpress.XtraBars.BarButtonGroup()
        Me.iLeftTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.iCenterTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.iRightTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.iChartWizard = New DevExpress.XtraBars.BarButtonItem()
        Me.iExport = New DevExpress.XtraBars.BarButtonItem()
        Me.iPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.iStartSweep = New DevExpress.XtraBars.BarButtonItem()
        Me.iStopSweep = New DevExpress.XtraBars.BarButtonItem()
        Me.iConnect = New DevExpress.XtraBars.BarButtonItem()
        Me.iDisconnect = New DevExpress.XtraBars.BarButtonItem()
        Me.iUpdate = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.iSaveData = New DevExpress.XtraBars.BarButtonItem()
        Me.iScanPower = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.eChRange = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.iDebugMode = New DevExpress.XtraBars.BarEditItem()
        Me.iGroupQuery = New DevExpress.XtraBars.BarEditItem()
        Me.ribbonImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.homeRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.skinsRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.fileRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.helpRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.helpRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChannel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParameter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWavelength = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPower = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbGrating = New System.Windows.Forms.ComboBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cbChannel = New System.Windows.Forms.ComboBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cbCom = New System.Windows.Forms.ComboBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbBaud = New System.Windows.Forms.ComboBox()
        Me.inboxItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.outboxItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.draftsItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.trashItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.calendarItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.tasksItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.navbarImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.navbarImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ChartPower = New DevExpress.XtraCharts.ChartControl()
        Me.ChartWavelength = New DevExpress.XtraCharts.ChartControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.spITLA = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timerSweep = New System.Windows.Forms.Timer(Me.components)
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.timerSaveData = New System.Windows.Forms.Timer(Me.components)
        Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem3 = New DevExpress.XtraBars.BarEditItem()
        Me.timerGatherData = New System.Windows.Forms.Timer(Me.components)
        CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainerControl.SuspendLayout()
        CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navBarControl.SuspendLayout()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        CType(Me.txtSN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupControlContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popupControlContainer2.SuspendLayout()
        CType(Me.buttonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ChartPower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartWavelength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SwiftPlotSeriesView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitContainerControl
        '
        Me.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainerControl.Location = New System.Drawing.Point(0, 147)
        Me.splitContainerControl.Name = "splitContainerControl"
        Me.splitContainerControl.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.splitContainerControl.Panel1.Controls.Add(Me.navBarControl)
        Me.splitContainerControl.Panel1.Text = "Panel1"
        Me.splitContainerControl.Panel2.Controls.Add(Me.LayoutControl1)
        Me.splitContainerControl.Panel2.Text = "Panel2"
        Me.splitContainerControl.Size = New System.Drawing.Size(1193, 476)
        Me.splitContainerControl.SplitterPosition = 445
        Me.splitContainerControl.TabIndex = 1
        Me.splitContainerControl.Text = "splitContainerControl1"
        '
        'navBarControl
        '
        Me.navBarControl.ActiveGroup = Me.controlGroup
        Me.navBarControl.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navBarControl.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.controlGroup})
        Me.navBarControl.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.inboxItem, Me.outboxItem, Me.draftsItem, Me.trashItem, Me.calendarItem, Me.tasksItem, Me.NavBarItem1, Me.NavBarItem2})
        Me.navBarControl.LargeImages = Me.navbarImageCollectionLarge
        Me.navBarControl.Location = New System.Drawing.Point(0, 0)
        Me.navBarControl.Name = "navBarControl"
        Me.navBarControl.OptionsNavPane.ExpandedWidth = 445
        Me.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar
        Me.navBarControl.Size = New System.Drawing.Size(445, 466)
        Me.navBarControl.SmallImages = Me.navbarImageCollection
        Me.navBarControl.StoreDefaultPaintStyleName = True
        Me.navBarControl.TabIndex = 1
        Me.navBarControl.Text = "navBarControl1"
        '
        'controlGroup
        '
        Me.controlGroup.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.controlGroup.Appearance.Options.UseFont = True
        Me.controlGroup.Caption = "Setting & Result"
        Me.controlGroup.ControlContainer = Me.NavBarGroupControlContainer1
        Me.controlGroup.Expanded = True
        Me.controlGroup.GroupClientHeight = 629
        Me.controlGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.controlGroup.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.inboxItem), New DevExpress.XtraNavBar.NavBarItemLink(Me.outboxItem), New DevExpress.XtraNavBar.NavBarItemLink(Me.draftsItem), New DevExpress.XtraNavBar.NavBarItemLink(Me.trashItem), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2)})
        Me.controlGroup.LargeImageIndex = 0
        Me.controlGroup.Name = "controlGroup"
        Me.controlGroup.SmallImage = CType(resources.GetObject("controlGroup.SmallImage"), System.Drawing.Image)
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.AllowDrop = True
        Me.NavBarGroupControlContainer1.Controls.Add(Me.LabelControl8)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.txtSN)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.gcData)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.GroupControl2)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.GroupControl1)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(437, 622)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(2, 15)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(21, 19)
        Me.LabelControl8.TabIndex = 40
        Me.LabelControl8.Text = "SN"
        '
        'txtSN
        '
        Me.txtSN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSN.Location = New System.Drawing.Point(43, 13)
        Me.txtSN.MenuManager = Me.ribbonControl
        Me.txtSN.Name = "txtSN"
        Me.txtSN.Properties.Appearance.Font = New System.Drawing.Font("Lucida Console", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSN.Properties.Appearance.Options.UseFont = True
        Me.txtSN.Size = New System.Drawing.Size(387, 20)
        Me.txtSN.TabIndex = 41
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.appMenu
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.ribbonImageCollection
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.iLoadData, Me.iExit, Me.iHelp, Me.iAbout, Me.siInfo, Me.alignButtonGroup, Me.iBoldFontStyle, Me.iItalicFontStyle, Me.iUnderlinedFontStyle, Me.fontStyleButtonGroup, Me.iLeftTextAlign, Me.iCenterTextAlign, Me.iRightTextAlign, Me.rgbiSkins, Me.iChartWizard, Me.iExport, Me.iPrintPreview, Me.iStartSweep, Me.iStopSweep, Me.iConnect, Me.iDisconnect, Me.iUpdate, Me.BarEditItem1, Me.iSaveData, Me.iScanPower, Me.eChRange, Me.iDebugMode, Me.iGroupQuery})
        Me.ribbonControl.LargeImages = Me.ribbonImageCollectionLarge
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 100
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.iAbout)
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.homeRibbonPage, Me.helpRibbonPage})
        Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemTextEdit1, Me.RepositoryItemSpinEdit1, Me.RepositoryItemCheckEdit3, Me.RepositoryItemSpinEdit2, Me.RepositoryItemComboBox1, Me.RepositoryItemCheckEdit4})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl.Size = New System.Drawing.Size(1193, 147)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.iLoadData)
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.iHelp)
        '
        'appMenu
        '
        Me.appMenu.BottomPaneControlContainer = Me.popupControlContainer2
        Me.appMenu.ItemLinks.Add(Me.iLoadData)
        Me.appMenu.ItemLinks.Add(Me.iExit)
        Me.appMenu.Name = "appMenu"
        Me.appMenu.Ribbon = Me.ribbonControl
        Me.appMenu.ShowRightPane = True
        '
        'popupControlContainer2
        '
        Me.popupControlContainer2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.popupControlContainer2.Appearance.Options.UseBackColor = True
        Me.popupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popupControlContainer2.Controls.Add(Me.buttonEdit)
        Me.popupControlContainer2.Location = New System.Drawing.Point(238, 253)
        Me.popupControlContainer2.Name = "popupControlContainer2"
        Me.popupControlContainer2.Ribbon = Me.ribbonControl
        Me.popupControlContainer2.Size = New System.Drawing.Size(118, 24)
        Me.popupControlContainer2.TabIndex = 7
        Me.popupControlContainer2.Visible = False
        '
        'buttonEdit
        '
        Me.buttonEdit.EditValue = "Some Text"
        Me.buttonEdit.Location = New System.Drawing.Point(3, 4)
        Me.buttonEdit.MenuManager = Me.ribbonControl
        Me.buttonEdit.Name = "buttonEdit"
        Me.buttonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.buttonEdit.Size = New System.Drawing.Size(100, 20)
        Me.buttonEdit.TabIndex = 0
        '
        'iLoadData
        '
        Me.iLoadData.Caption = "Load Data"
        Me.iLoadData.Description = "Creates a new, blank file."
        Me.iLoadData.Glyph = CType(resources.GetObject("iLoadData.Glyph"), System.Drawing.Image)
        Me.iLoadData.Hint = "Creates a new, blank file"
        Me.iLoadData.Id = 1
        Me.iLoadData.ImageIndex = 0
        Me.iLoadData.LargeGlyph = CType(resources.GetObject("iLoadData.LargeGlyph"), System.Drawing.Image)
        Me.iLoadData.LargeImageIndex = 0
        Me.iLoadData.Name = "iLoadData"
        Me.iLoadData.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'iExit
        '
        Me.iExit.Caption = "Exit"
        Me.iExit.Description = "Closes this program after prompting you to save unsaved data."
        Me.iExit.Hint = "Closes this program after prompting you to save unsaved data"
        Me.iExit.Id = 20
        Me.iExit.ImageIndex = 6
        Me.iExit.LargeImageIndex = 6
        Me.iExit.Name = "iExit"
        '
        'ribbonImageCollection
        '
        Me.ribbonImageCollection.ImageStream = CType(resources.GetObject("ribbonImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png")
        '
        'iHelp
        '
        Me.iHelp.Caption = "Help"
        Me.iHelp.Description = "Start the program help system."
        Me.iHelp.Hint = "Start the program help system"
        Me.iHelp.Id = 22
        Me.iHelp.ImageIndex = 7
        Me.iHelp.LargeImageIndex = 7
        Me.iHelp.Name = "iHelp"
        '
        'iAbout
        '
        Me.iAbout.Caption = "About"
        Me.iAbout.Description = "Displays general program information."
        Me.iAbout.Hint = "Displays general program information"
        Me.iAbout.Id = 24
        Me.iAbout.ImageIndex = 8
        Me.iAbout.LargeImageIndex = 8
        Me.iAbout.Name = "iAbout"
        '
        'siInfo
        '
        Me.siInfo.Id = 32
        Me.siInfo.Name = "siInfo"
        Me.siInfo.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'alignButtonGroup
        '
        Me.alignButtonGroup.Caption = "Align Commands"
        Me.alignButtonGroup.Id = 52
        Me.alignButtonGroup.ItemLinks.Add(Me.iBoldFontStyle)
        Me.alignButtonGroup.ItemLinks.Add(Me.iItalicFontStyle)
        Me.alignButtonGroup.ItemLinks.Add(Me.iUnderlinedFontStyle)
        Me.alignButtonGroup.Name = "alignButtonGroup"
        '
        'iBoldFontStyle
        '
        Me.iBoldFontStyle.Caption = "Bold"
        Me.iBoldFontStyle.Id = 53
        Me.iBoldFontStyle.ImageIndex = 9
        Me.iBoldFontStyle.Name = "iBoldFontStyle"
        '
        'iItalicFontStyle
        '
        Me.iItalicFontStyle.Caption = "Italic"
        Me.iItalicFontStyle.Id = 54
        Me.iItalicFontStyle.ImageIndex = 10
        Me.iItalicFontStyle.Name = "iItalicFontStyle"
        '
        'iUnderlinedFontStyle
        '
        Me.iUnderlinedFontStyle.Caption = "Underlined"
        Me.iUnderlinedFontStyle.Id = 55
        Me.iUnderlinedFontStyle.ImageIndex = 11
        Me.iUnderlinedFontStyle.Name = "iUnderlinedFontStyle"
        '
        'fontStyleButtonGroup
        '
        Me.fontStyleButtonGroup.Caption = "Font Style"
        Me.fontStyleButtonGroup.Id = 56
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iLeftTextAlign)
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iCenterTextAlign)
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iRightTextAlign)
        Me.fontStyleButtonGroup.Name = "fontStyleButtonGroup"
        '
        'iLeftTextAlign
        '
        Me.iLeftTextAlign.Caption = "Left"
        Me.iLeftTextAlign.Id = 57
        Me.iLeftTextAlign.ImageIndex = 12
        Me.iLeftTextAlign.Name = "iLeftTextAlign"
        '
        'iCenterTextAlign
        '
        Me.iCenterTextAlign.Caption = "Center"
        Me.iCenterTextAlign.Id = 58
        Me.iCenterTextAlign.ImageIndex = 13
        Me.iCenterTextAlign.Name = "iCenterTextAlign"
        '
        'iRightTextAlign
        '
        Me.iRightTextAlign.Caption = "Right"
        Me.iRightTextAlign.Id = 59
        Me.iRightTextAlign.ImageIndex = 14
        Me.iRightTextAlign.Name = "iRightTextAlign"
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Caption = "Skins"
        '
        '
        '
        Me.rgbiSkins.Gallery.AllowHoverImages = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rgbiSkins.Gallery.ColumnCount = 4
        Me.rgbiSkins.Gallery.FixedHoverImageSize = False
        Me.rgbiSkins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
        Me.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
        Me.rgbiSkins.Gallery.RowCount = 4
        Me.rgbiSkins.Id = 60
        Me.rgbiSkins.Name = "rgbiSkins"
        '
        'iChartWizard
        '
        Me.iChartWizard.Caption = "Run Chart Wizard"
        Me.iChartWizard.Glyph = CType(resources.GetObject("iChartWizard.Glyph"), System.Drawing.Image)
        Me.iChartWizard.Id = 62
        Me.iChartWizard.LargeGlyph = CType(resources.GetObject("iChartWizard.LargeGlyph"), System.Drawing.Image)
        Me.iChartWizard.Name = "iChartWizard"
        Me.iChartWizard.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'iExport
        '
        Me.iExport.Caption = "Export"
        Me.iExport.Glyph = CType(resources.GetObject("iExport.Glyph"), System.Drawing.Image)
        Me.iExport.Id = 63
        Me.iExport.LargeGlyph = CType(resources.GetObject("iExport.LargeGlyph"), System.Drawing.Image)
        Me.iExport.Name = "iExport"
        Me.iExport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'iPrintPreview
        '
        Me.iPrintPreview.Caption = "Print Preview"
        Me.iPrintPreview.Glyph = CType(resources.GetObject("iPrintPreview.Glyph"), System.Drawing.Image)
        Me.iPrintPreview.Id = 64
        Me.iPrintPreview.LargeGlyph = CType(resources.GetObject("iPrintPreview.LargeGlyph"), System.Drawing.Image)
        Me.iPrintPreview.Name = "iPrintPreview"
        '
        'iStartSweep
        '
        Me.iStartSweep.Caption = "Start Sweep"
        Me.iStartSweep.Glyph = CType(resources.GetObject("iStartSweep.Glyph"), System.Drawing.Image)
        Me.iStartSweep.Id = 65
        Me.iStartSweep.LargeGlyph = CType(resources.GetObject("iStartSweep.LargeGlyph"), System.Drawing.Image)
        Me.iStartSweep.LargeWidth = 60
        Me.iStartSweep.Name = "iStartSweep"
        Me.iStartSweep.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'iStopSweep
        '
        Me.iStopSweep.Caption = "Stop  Sweep"
        Me.iStopSweep.Glyph = CType(resources.GetObject("iStopSweep.Glyph"), System.Drawing.Image)
        Me.iStopSweep.Id = 66
        Me.iStopSweep.LargeGlyph = CType(resources.GetObject("iStopSweep.LargeGlyph"), System.Drawing.Image)
        Me.iStopSweep.LargeWidth = 60
        Me.iStopSweep.Name = "iStopSweep"
        Me.iStopSweep.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'iConnect
        '
        Me.iConnect.Caption = "Connet"
        Me.iConnect.Glyph = CType(resources.GetObject("iConnect.Glyph"), System.Drawing.Image)
        Me.iConnect.Id = 69
        Me.iConnect.LargeGlyph = CType(resources.GetObject("iConnect.LargeGlyph"), System.Drawing.Image)
        Me.iConnect.LargeWidth = 60
        Me.iConnect.Name = "iConnect"
        Me.iConnect.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'iDisconnect
        '
        Me.iDisconnect.Caption = "Close"
        Me.iDisconnect.Glyph = CType(resources.GetObject("iDisconnect.Glyph"), System.Drawing.Image)
        Me.iDisconnect.Id = 70
        Me.iDisconnect.LargeGlyph = CType(resources.GetObject("iDisconnect.LargeGlyph"), System.Drawing.Image)
        Me.iDisconnect.LargeWidth = 60
        Me.iDisconnect.Name = "iDisconnect"
        Me.iDisconnect.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'iUpdate
        '
        Me.iUpdate.Caption = "Update"
        Me.iUpdate.Glyph = CType(resources.GetObject("iUpdate.Glyph"), System.Drawing.Image)
        Me.iUpdate.Id = 71
        Me.iUpdate.LargeGlyph = CType(resources.GetObject("iUpdate.LargeGlyph"), System.Drawing.Image)
        Me.iUpdate.LargeWidth = 60
        Me.iUpdate.Name = "iUpdate"
        Me.iUpdate.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemPictureEdit1
        Me.BarEditItem1.Id = 72
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.Width = 500
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'iSaveData
        '
        Me.iSaveData.Caption = "Save Data"
        Me.iSaveData.Glyph = CType(resources.GetObject("iSaveData.Glyph"), System.Drawing.Image)
        Me.iSaveData.Id = 87
        Me.iSaveData.LargeGlyph = CType(resources.GetObject("iSaveData.LargeGlyph"), System.Drawing.Image)
        Me.iSaveData.Name = "iSaveData"
        '
        'iScanPower
        '
        Me.iScanPower.Caption = "Scan Power"
        Me.iScanPower.Edit = Me.RepositoryItemCheckEdit4
        Me.iScanPower.Id = 89
        Me.iScanPower.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Immediate
        Me.iScanPower.Name = "iScanPower"
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Caption = "Check"
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        '
        'eChRange
        '
        Me.eChRange.Caption = "CH Range  "
        Me.eChRange.CausesValidation = True
        Me.eChRange.Edit = Me.RepositoryItemSpinEdit1
        Me.eChRange.EditHeight = 30
        Me.eChRange.Enabled = False
        Me.eChRange.Id = 91
        Me.eChRange.Name = "eChRange"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {16, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'iDebugMode
        '
        Me.iDebugMode.Caption = "DebugMode"
        Me.iDebugMode.Edit = Me.RepositoryItemCheckEdit4
        Me.iDebugMode.Id = 95
        Me.iDebugMode.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Immediate
        Me.iDebugMode.Name = "iDebugMode"
        '
        'iGroupQuery
        '
        Me.iGroupQuery.Caption = "Fast Scan  "
        Me.iGroupQuery.Edit = Me.RepositoryItemCheckEdit4
        Me.iGroupQuery.Id = 99
        Me.iGroupQuery.Name = "iGroupQuery"
        '
        'ribbonImageCollectionLarge
        '
        Me.ribbonImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.ribbonImageCollectionLarge.ImageStream = CType(resources.GetObject("ribbonImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png")
        '
        'homeRibbonPage
        '
        Me.homeRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.skinsRibbonPageGroup, Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.fileRibbonPageGroup, Me.RibbonPageGroup4, Me.RibbonPageGroup3, Me.RibbonPageGroup5})
        Me.homeRibbonPage.Name = "homeRibbonPage"
        Me.homeRibbonPage.Text = "Home"
        '
        'skinsRibbonPageGroup
        '
        Me.skinsRibbonPageGroup.ItemLinks.Add(Me.rgbiSkins)
        Me.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup"
        Me.skinsRibbonPageGroup.ShowCaptionButton = False
        Me.skinsRibbonPageGroup.Text = "Skins"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.iChartWizard)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Wizard"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.iPrintPreview)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.iExport)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Print And Export"
        '
        'fileRibbonPageGroup
        '
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iLoadData)
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iSaveData)
        Me.fileRibbonPageGroup.Name = "fileRibbonPageGroup"
        Me.fileRibbonPageGroup.Text = "File"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.iConnect)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.iDisconnect)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.iUpdate)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "COM"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.iStartSweep)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.iStopSweep)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Measurement"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.iScanPower)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.iDebugMode)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.eChRange)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.iGroupQuery)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Scan Setting"
        '
        'helpRibbonPage
        '
        Me.helpRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.helpRibbonPageGroup})
        Me.helpRibbonPage.Name = "helpRibbonPage"
        Me.helpRibbonPage.Text = "Help"
        '
        'helpRibbonPageGroup
        '
        Me.helpRibbonPageGroup.ItemLinks.Add(Me.iHelp)
        Me.helpRibbonPageGroup.ItemLinks.Add(Me.iAbout)
        Me.helpRibbonPageGroup.Name = "helpRibbonPageGroup"
        Me.helpRibbonPageGroup.Text = "Help"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Caption = "Check"
        Me.RepositoryItemCheckEdit3.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'RepositoryItemSpinEdit2
        '
        Me.RepositoryItemSpinEdit2.AutoHeight = False
        Me.RepositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.siInfo)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 623)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1193, 31)
        '
        'gcData
        '
        Me.gcData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridLevelNode2.RelationName = "Level1"
        Me.gcData.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.gcData.Location = New System.Drawing.Point(0, 218)
        Me.gcData.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.gcData.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcData.MainView = Me.GridView1
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.gcData.Size = New System.Drawing.Size(430, 374)
        Me.gcData.TabIndex = 36
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 30
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChannel, Me.colParameter, Me.colWavelength, Me.colPower})
        Me.GridView1.GridControl = Me.gcData
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.PaintStyleName = "Skin"
        Me.GridView1.RowHeight = 30
        '
        'colChannel
        '
        Me.colChannel.AppearanceCell.Font = New System.Drawing.Font("Lucida Console", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colChannel.AppearanceCell.Options.UseFont = True
        Me.colChannel.AppearanceHeader.Font = New System.Drawing.Font("Lucida Console", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colChannel.AppearanceHeader.Options.UseFont = True
        Me.colChannel.Caption = "Channel"
        Me.colChannel.FieldName = "Channel"
        Me.colChannel.Name = "colChannel"
        Me.colChannel.Visible = True
        Me.colChannel.VisibleIndex = 0
        Me.colChannel.Width = 92
        '
        'colParameter
        '
        Me.colParameter.AppearanceCell.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colParameter.AppearanceCell.Options.UseFont = True
        Me.colParameter.AppearanceHeader.Font = New System.Drawing.Font("Lucida Console", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colParameter.AppearanceHeader.Options.UseFont = True
        Me.colParameter.Caption = "Parameter"
        Me.colParameter.FieldName = "Parameter"
        Me.colParameter.Name = "colParameter"
        Me.colParameter.Visible = True
        Me.colParameter.VisibleIndex = 1
        Me.colParameter.Width = 106
        '
        'colWavelength
        '
        Me.colWavelength.AppearanceCell.Font = New System.Drawing.Font("Lucida Console", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colWavelength.AppearanceCell.Options.UseFont = True
        Me.colWavelength.AppearanceHeader.Font = New System.Drawing.Font("Lucida Console", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colWavelength.AppearanceHeader.Options.UseFont = True
        Me.colWavelength.Caption = "Wavelength(nm)"
        Me.colWavelength.FieldName = "Wavelength(nm)"
        Me.colWavelength.Name = "colWavelength"
        Me.colWavelength.Visible = True
        Me.colWavelength.VisibleIndex = 2
        Me.colWavelength.Width = 121
        '
        'colPower
        '
        Me.colPower.AppearanceCell.Font = New System.Drawing.Font("Lucida Console", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPower.AppearanceCell.Options.UseFont = True
        Me.colPower.AppearanceHeader.Font = New System.Drawing.Font("Lucida Console", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPower.AppearanceHeader.Options.UseFont = True
        Me.colPower.Caption = "Power(dBm)"
        Me.colPower.FieldName = "Power(dBm)"
        Me.colPower.Name = "colPower"
        Me.colPower.Visible = True
        Me.colPower.VisibleIndex = 3
        Me.colPower.Width = 115
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.cbGrating)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.cbChannel)
        Me.GroupControl2.Location = New System.Drawing.Point(1, 139)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(429, 64)
        Me.GroupControl2.TabIndex = 35
        Me.GroupControl2.Text = "Frequency"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(185, 33)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 15)
        Me.LabelControl3.TabIndex = 33
        Me.LabelControl3.Text = "Grating"
        '
        'cbGrating
        '
        Me.cbGrating.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbGrating.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrating.FormattingEnabled = True
        Me.cbGrating.Location = New System.Drawing.Point(237, 31)
        Me.cbGrating.Name = "cbGrating"
        Me.cbGrating.Size = New System.Drawing.Size(182, 20)
        Me.cbGrating.TabIndex = 32
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(10, 33)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(17, 15)
        Me.LabelControl6.TabIndex = 22
        Me.LabelControl6.Text = "CH"
        '
        'cbChannel
        '
        Me.cbChannel.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChannel.FormattingEnabled = True
        Me.cbChannel.Location = New System.Drawing.Point(42, 31)
        Me.cbChannel.Name = "cbChannel"
        Me.cbChannel.Size = New System.Drawing.Size(134, 20)
        Me.cbChannel.TabIndex = 31
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.cbCom)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.cbBaud)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 51)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(429, 79)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "COM"
        '
        'cbCom
        '
        Me.cbCom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCom.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCom.FormattingEnabled = True
        Me.cbCom.Location = New System.Drawing.Point(127, 23)
        Me.cbCom.Name = "cbCom"
        Me.cbCom.Size = New System.Drawing.Size(292, 20)
        Me.cbCom.TabIndex = 30
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(10, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 15)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "Com Port"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(10, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 15)
        Me.LabelControl2.TabIndex = 18
        Me.LabelControl2.Text = "Baud Rate"
        '
        'cbBaud
        '
        Me.cbBaud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBaud.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBaud.FormattingEnabled = True
        Me.cbBaud.Location = New System.Drawing.Point(127, 52)
        Me.cbBaud.Name = "cbBaud"
        Me.cbBaud.Size = New System.Drawing.Size(292, 20)
        Me.cbBaud.TabIndex = 29
        '
        'inboxItem
        '
        Me.inboxItem.Caption = "Inbox"
        Me.inboxItem.Name = "inboxItem"
        Me.inboxItem.SmallImageIndex = 0
        '
        'outboxItem
        '
        Me.outboxItem.Caption = "Outbox"
        Me.outboxItem.Name = "outboxItem"
        Me.outboxItem.SmallImageIndex = 1
        '
        'draftsItem
        '
        Me.draftsItem.Caption = "Drafts"
        Me.draftsItem.Name = "draftsItem"
        Me.draftsItem.SmallImageIndex = 2
        '
        'trashItem
        '
        Me.trashItem.Caption = "Trash"
        Me.trashItem.Name = "trashItem"
        Me.trashItem.SmallImageIndex = 3
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "NavBarItem1"
        Me.NavBarItem1.Name = "NavBarItem1"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "NavBarItem2"
        Me.NavBarItem2.Name = "NavBarItem2"
        '
        'calendarItem
        '
        Me.calendarItem.Caption = "Calendar"
        Me.calendarItem.Name = "calendarItem"
        Me.calendarItem.SmallImageIndex = 4
        '
        'tasksItem
        '
        Me.tasksItem.Caption = "Tasks"
        Me.tasksItem.Name = "tasksItem"
        Me.tasksItem.SmallImageIndex = 5
        '
        'navbarImageCollectionLarge
        '
        Me.navbarImageCollectionLarge.ImageStream = CType(resources.GetObject("navbarImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_16x16.png")
        Me.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_16x16.png")
        '
        'navbarImageCollection
        '
        Me.navbarImageCollection.ImageStream = CType(resources.GetObject("navbarImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent
        Me.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png")
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ChartPower)
        Me.LayoutControl1.Controls.Add(Me.ChartWavelength)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(731, 466)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ChartPower
        '
        Me.ChartPower.AppearanceNameSerializable = "Light"
        XyDiagram2.AxisX.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        XyDiagram2.AxisX.Title.Text = "Wavelength (nm)"
        XyDiagram2.AxisX.Title.Visible = True
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        XyDiagram2.AxisY.Title.Text = "Power (dBm)"
        XyDiagram2.AxisY.Title.Visible = True
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartPower.Diagram = XyDiagram2
        Me.ChartPower.Location = New System.Drawing.Point(12, 237)
        Me.ChartPower.Name = "ChartPower"
        Me.ChartPower.PaletteName = "Default"
        PointSeriesLabel2.LineLength = 20
        PointOptions2.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.FixedPoint
        PointOptions2.ArgumentNumericOptions.Precision = 0
        PointOptions2.Pattern = "{A} : {V}"
        PointOptions2.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        PointSeriesLabel2.PointOptions = PointOptions2
        PointSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint
        Series4.Label = PointSeriesLabel2
        Series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series4.Name = "Series 1"
        Series4.View = PointSeriesView3
        Me.ChartPower.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series4}
        Me.ChartPower.SeriesTemplate.View = PointSeriesView4
        Me.ChartPower.Size = New System.Drawing.Size(707, 217)
        Me.ChartPower.TabIndex = 4
        '
        'ChartWavelength
        '
        SwiftPlotDiagram2.AxisX.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        SwiftPlotDiagram2.AxisX.Title.Text = "Time"
        SwiftPlotDiagram2.AxisX.Title.Visible = True
        SwiftPlotDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        SwiftPlotDiagram2.AxisY.Label.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.FixedPoint
        SwiftPlotDiagram2.AxisY.Label.NumericOptions.Precision = 4
        SwiftPlotDiagram2.AxisY.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        SwiftPlotDiagram2.AxisY.Title.Text = "Wavelength(nm)"
        SwiftPlotDiagram2.AxisY.Title.Visible = True
        SwiftPlotDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartWavelength.Diagram = SwiftPlotDiagram2
        Me.ChartWavelength.Location = New System.Drawing.Point(12, 12)
        Me.ChartWavelength.Name = "ChartWavelength"
        Series5.Name = "Series 1"
        SwiftPlotSeriesView4.LineStyle.Thickness = 2
        Series5.View = SwiftPlotSeriesView4
        Series6.Name = "Series 2"
        SwiftPlotSeriesView5.LineStyle.Thickness = 2
        Series6.View = SwiftPlotSeriesView5
        Series6.Visible = False
        Me.ChartWavelength.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series5, Series6}
        SwiftPlotSeriesView6.LineStyle.Thickness = 2
        Me.ChartWavelength.SeriesTemplate.View = SwiftPlotSeriesView6
        Me.ChartWavelength.Size = New System.Drawing.Size(707, 221)
        Me.ChartWavelength.TabIndex = 0
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(731, 466)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ChartWavelength
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(711, 225)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ChartPower
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 225)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(711, 221)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'spITLA
        '
        Me.spITLA.ReadBufferSize = 24576
        '
        'timerSweep
        '
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem2.Id = 88
        Me.BarStaticItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarEditItem2
        '
        Me.BarEditItem2.Caption = "Scan Power"
        Me.BarEditItem2.Edit = Me.RepositoryItemCheckEdit2
        Me.BarEditItem2.Id = 89
        Me.BarEditItem2.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Immediate
        Me.BarEditItem2.Name = "BarEditItem2"
        '
        'BarEditItem3
        '
        Me.BarEditItem3.Caption = "DebugMode"
        Me.BarEditItem3.Edit = Me.RepositoryItemCheckEdit3
        Me.BarEditItem3.EditHeight = 30
        Me.BarEditItem3.Id = 95
        Me.BarEditItem3.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Immediate
        Me.BarEditItem3.Name = "BarEditItem3"
        '
        'timerGatherData
        '
        '
        'frmMain
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 654)
        Me.Controls.Add(Me.splitContainerControl)
        Me.Controls.Add(Me.popupControlContainer2)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Ribbon = Me.ribbonControl
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "Tunable Laser Module | Rev 1.4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainerControl.ResumeLayout(False)
        CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navBarControl.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.PerformLayout()
        CType(Me.txtSN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControlContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popupControlContainer2.ResumeLayout(False)
        CType(Me.buttonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartPower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SwiftPlotSeriesView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartWavelength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents splitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents siInfo As DevExpress.XtraBars.BarStaticItem
    Private WithEvents homeRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents fileRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents iLoadData As DevExpress.XtraBars.BarButtonItem
    Private WithEvents alignButtonGroup As DevExpress.XtraBars.BarButtonGroup
    Private WithEvents iBoldFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iItalicFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iUnderlinedFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents fontStyleButtonGroup As DevExpress.XtraBars.BarButtonGroup
    Private WithEvents iLeftTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iCenterTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iRightTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents skinsRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
    Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents helpRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents helpRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents iHelp As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iAbout As DevExpress.XtraBars.BarButtonItem
    Private WithEvents appMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private WithEvents popupControlContainer2 As DevExpress.XtraBars.PopupControlContainer
    Private WithEvents buttonEdit As DevExpress.XtraEditors.ButtonEdit
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents ribbonImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents ribbonImageCollectionLarge As DevExpress.Utils.ImageCollection
    Private WithEvents navBarControl As DevExpress.XtraNavBar.NavBarControl
    Private WithEvents controlGroup As DevExpress.XtraNavBar.NavBarGroup
    Private WithEvents inboxItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents outboxItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents draftsItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents trashItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents calendarItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents tasksItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents navbarImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents navbarImageCollectionLarge As DevExpress.Utils.ImageCollection
    Friend WithEvents ChartWavelength As DevExpress.XtraCharts.ChartControl
    Friend WithEvents iChartWizard As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents iExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents iPrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents iStartSweep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents iStopSweep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents iConnect As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents iDisconnect As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents iUpdate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spITLA As System.IO.Ports.SerialPort
    Friend WithEvents cbChannel As System.Windows.Forms.ComboBox
    Friend WithEvents cbCom As System.Windows.Forms.ComboBox
    Friend WithEvents cbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents iSaveData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChannel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParameter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWavelength As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents timerSweep As System.Windows.Forms.Timer
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbGrating As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents timerSaveData As System.Windows.Forms.Timer
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents ChartPower As DevExpress.XtraCharts.ChartControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colPower As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents iScanPower As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents eChRange As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents iDebugMode As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents iGroupQuery As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BarEditItem3 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents timerGatherData As System.Windows.Forms.Timer

End Class
