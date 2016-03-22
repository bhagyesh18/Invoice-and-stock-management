<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MenuMdi = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.FileMenuUser = New System.Windows.Forms.ToolStripMenuItem
        Me.FileMenuUserInsert = New System.Windows.Forms.ToolStripMenuItem
        Me.FileMenuUserChange = New System.Windows.Forms.ToolStripMenuItem
        Me.FileMenuUserRemove = New System.Windows.Forms.ToolStripMenuItem
        Me.FileMenuUserDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator
        Me.FileMenuOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.FileMenuOpenItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FileMenuOpenCustomer = New System.Windows.Forms.ToolStripMenuItem
        Me.FileMenuOpenSupplier = New System.Windows.Forms.ToolStripMenuItem
        Me.TexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FileMenuCloseAll = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.FileMenuLogOut = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.TransMenuPurchase = New System.Windows.Forms.ToolStripMenuItem
        Me.TransMenuPurRet = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.TransMenuSales = New System.Windows.Forms.ToolStripMenuItem
        Me.TransMenuSaleRet = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportMenuUserRpt = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportMenuStockRpt = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.ReportMenuPurRpt = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportMenuPurRetRpt = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.ReportMenuSalesRpt = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportMenuSaleRetRpt = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.ReportMenuCustom = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportMenuCustomUser = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator
        Me.ReportMenuCustomPur = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportMenuCustomPurRet = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator
        Me.ReportMenuCustomSales = New System.Windows.Forms.ToolStripMenuItem
        Me.urnToolStripMenuItemSalesRet = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsMenuSendEmail = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsMenuSetBG = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolsMenuCalc = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsMenuNotepad = New System.Windows.Forms.ToolStripMenuItem
        Me.LayoutMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.LayoutMenuCascade = New System.Windows.Forms.ToolStripMenuItem
        Me.LayoutMenuHorizontal = New System.Windows.Forms.ToolStripMenuItem
        Me.LayoutMenuVertical = New System.Windows.Forms.ToolStripMenuItem
        Me.LayoutMenuArrang = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenuSysHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenuAboutSys = New System.Windows.Forms.ToolStripMenuItem
        Me.FrmMainStatus = New System.Windows.Forms.StatusStrip
        Me.LblStockItem = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusLblSpace = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusLblTime = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialogBG = New System.Windows.Forms.OpenFileDialog
        Me.MenuMdi.SuspendLayout()
        Me.FrmMainStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuMdi
        '
        Me.MenuMdi.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuMdi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.TransMenu, Me.ReportMenu, Me.ToolsMenu, Me.LayoutMenu, Me.HelpMenu})
        Me.MenuMdi.Location = New System.Drawing.Point(0, 0)
        Me.MenuMdi.Name = "MenuMdi"
        Me.MenuMdi.Size = New System.Drawing.Size(790, 24)
        Me.MenuMdi.TabIndex = 0
        Me.MenuMdi.Text = "MenuStrip1"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenuUser, Me.FileMenuUserDetail, Me.ToolStripMenuItem7, Me.FileMenuOpen, Me.FileMenuCloseAll, Me.ToolStripMenuItem1, Me.FileMenuLogOut, Me.ExitToolStripMenuItem})
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(42, 20)
        Me.FileMenu.Text = "&File"
        '
        'FileMenuUser
        '
        Me.FileMenuUser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenuUserInsert, Me.FileMenuUserChange, Me.FileMenuUserRemove})
        Me.FileMenuUser.Image = CType(resources.GetObject("FileMenuUser.Image"), System.Drawing.Image)
        Me.FileMenuUser.Name = "FileMenuUser"
        Me.FileMenuUser.Size = New System.Drawing.Size(197, 22)
        Me.FileMenuUser.Text = "&User"
        Me.FileMenuUser.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'FileMenuUserInsert
        '
        Me.FileMenuUserInsert.Image = CType(resources.GetObject("FileMenuUserInsert.Image"), System.Drawing.Image)
        Me.FileMenuUserInsert.Name = "FileMenuUserInsert"
        Me.FileMenuUserInsert.Size = New System.Drawing.Size(174, 22)
        Me.FileMenuUserInsert.Text = "&Insert User"
        '
        'FileMenuUserChange
        '
        Me.FileMenuUserChange.Image = CType(resources.GetObject("FileMenuUserChange.Image"), System.Drawing.Image)
        Me.FileMenuUserChange.Name = "FileMenuUserChange"
        Me.FileMenuUserChange.Size = New System.Drawing.Size(174, 22)
        Me.FileMenuUserChange.Text = "&Change User"
        '
        'FileMenuUserRemove
        '
        Me.FileMenuUserRemove.Image = CType(resources.GetObject("FileMenuUserRemove.Image"), System.Drawing.Image)
        Me.FileMenuUserRemove.Name = "FileMenuUserRemove"
        Me.FileMenuUserRemove.Size = New System.Drawing.Size(174, 22)
        Me.FileMenuUserRemove.Text = "&Remove User"
        '
        'FileMenuUserDetail
        '
        Me.FileMenuUserDetail.Image = CType(resources.GetObject("FileMenuUserDetail.Image"), System.Drawing.Image)
        Me.FileMenuUserDetail.Name = "FileMenuUserDetail"
        Me.FileMenuUserDetail.Size = New System.Drawing.Size(197, 22)
        Me.FileMenuUserDetail.Text = "&UserDetail"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(194, 6)
        '
        'FileMenuOpen
        '
        Me.FileMenuOpen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenuOpenItem, Me.FileMenuOpenCustomer, Me.FileMenuOpenSupplier, Me.TexToolStripMenuItem})
        Me.FileMenuOpen.Image = CType(resources.GetObject("FileMenuOpen.Image"), System.Drawing.Image)
        Me.FileMenuOpen.Name = "FileMenuOpen"
        Me.FileMenuOpen.Size = New System.Drawing.Size(197, 22)
        Me.FileMenuOpen.Text = "&Open"
        '
        'FileMenuOpenItem
        '
        Me.FileMenuOpenItem.Image = CType(resources.GetObject("FileMenuOpenItem.Image"), System.Drawing.Image)
        Me.FileMenuOpenItem.Name = "FileMenuOpenItem"
        Me.FileMenuOpenItem.Size = New System.Drawing.Size(151, 22)
        Me.FileMenuOpenItem.Text = "&Items"
        '
        'FileMenuOpenCustomer
        '
        Me.FileMenuOpenCustomer.Image = CType(resources.GetObject("FileMenuOpenCustomer.Image"), System.Drawing.Image)
        Me.FileMenuOpenCustomer.Name = "FileMenuOpenCustomer"
        Me.FileMenuOpenCustomer.Size = New System.Drawing.Size(151, 22)
        Me.FileMenuOpenCustomer.Text = "&Customer"
        '
        'FileMenuOpenSupplier
        '
        Me.FileMenuOpenSupplier.Image = CType(resources.GetObject("FileMenuOpenSupplier.Image"), System.Drawing.Image)
        Me.FileMenuOpenSupplier.Name = "FileMenuOpenSupplier"
        Me.FileMenuOpenSupplier.Size = New System.Drawing.Size(151, 22)
        Me.FileMenuOpenSupplier.Text = "&Supplier"
        '
        'TexToolStripMenuItem
        '
        Me.TexToolStripMenuItem.Image = CType(resources.GetObject("TexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TexToolStripMenuItem.Name = "TexToolStripMenuItem"
        Me.TexToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TexToolStripMenuItem.Text = "&Tax"
        '
        'FileMenuCloseAll
        '
        Me.FileMenuCloseAll.Name = "FileMenuCloseAll"
        Me.FileMenuCloseAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.FileMenuCloseAll.Size = New System.Drawing.Size(197, 22)
        Me.FileMenuCloseAll.Text = "&Close All"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(194, 6)
        '
        'FileMenuLogOut
        '
        Me.FileMenuLogOut.Image = CType(resources.GetObject("FileMenuLogOut.Image"), System.Drawing.Image)
        Me.FileMenuLogOut.Name = "FileMenuLogOut"
        Me.FileMenuLogOut.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.FileMenuLogOut.Size = New System.Drawing.Size(197, 22)
        Me.FileMenuLogOut.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'TransMenu
        '
        Me.TransMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransMenuPurchase, Me.TransMenuPurRet, Me.ToolStripMenuItem2, Me.TransMenuSales, Me.TransMenuSaleRet})
        Me.TransMenu.Name = "TransMenu"
        Me.TransMenu.Size = New System.Drawing.Size(98, 20)
        Me.TransMenu.Text = "&Transaction"
        '
        'TransMenuPurchase
        '
        Me.TransMenuPurchase.Image = CType(resources.GetObject("TransMenuPurchase.Image"), System.Drawing.Image)
        Me.TransMenuPurchase.Name = "TransMenuPurchase"
        Me.TransMenuPurchase.Size = New System.Drawing.Size(197, 22)
        Me.TransMenuPurchase.Text = "&Purchase Entry"
        '
        'TransMenuPurRet
        '
        Me.TransMenuPurRet.Image = CType(resources.GetObject("TransMenuPurRet.Image"), System.Drawing.Image)
        Me.TransMenuPurRet.Name = "TransMenuPurRet"
        Me.TransMenuPurRet.Size = New System.Drawing.Size(197, 22)
        Me.TransMenuPurRet.Text = "P&urchase Return"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(194, 6)
        '
        'TransMenuSales
        '
        Me.TransMenuSales.Image = CType(resources.GetObject("TransMenuSales.Image"), System.Drawing.Image)
        Me.TransMenuSales.Name = "TransMenuSales"
        Me.TransMenuSales.Size = New System.Drawing.Size(197, 22)
        Me.TransMenuSales.Text = "&Sales Entry"
        '
        'TransMenuSaleRet
        '
        Me.TransMenuSaleRet.Image = CType(resources.GetObject("TransMenuSaleRet.Image"), System.Drawing.Image)
        Me.TransMenuSaleRet.Name = "TransMenuSaleRet"
        Me.TransMenuSaleRet.Size = New System.Drawing.Size(197, 22)
        Me.TransMenuSaleRet.Text = "S&ales Return"
        '
        'ReportMenu
        '
        Me.ReportMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportMenuUserRpt, Me.ReportMenuStockRpt, Me.ToolStripMenuItem4, Me.ReportMenuPurRpt, Me.ReportMenuPurRetRpt, Me.ToolStripMenuItem5, Me.ReportMenuSalesRpt, Me.ReportMenuSaleRetRpt, Me.ToolStripMenuItem6, Me.ReportMenuCustom})
        Me.ReportMenu.Name = "ReportMenu"
        Me.ReportMenu.Size = New System.Drawing.Size(63, 20)
        Me.ReportMenu.Text = "&Report"
        '
        'ReportMenuUserRpt
        '
        Me.ReportMenuUserRpt.Image = CType(resources.GetObject("ReportMenuUserRpt.Image"), System.Drawing.Image)
        Me.ReportMenuUserRpt.Name = "ReportMenuUserRpt"
        Me.ReportMenuUserRpt.Size = New System.Drawing.Size(245, 22)
        Me.ReportMenuUserRpt.Text = "&User Detail Report"
        '
        'ReportMenuStockRpt
        '
        Me.ReportMenuStockRpt.Image = CType(resources.GetObject("ReportMenuStockRpt.Image"), System.Drawing.Image)
        Me.ReportMenuStockRpt.Name = "ReportMenuStockRpt"
        Me.ReportMenuStockRpt.Size = New System.Drawing.Size(245, 22)
        Me.ReportMenuStockRpt.Text = "S&tock Report"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(242, 6)
        '
        'ReportMenuPurRpt
        '
        Me.ReportMenuPurRpt.Image = CType(resources.GetObject("ReportMenuPurRpt.Image"), System.Drawing.Image)
        Me.ReportMenuPurRpt.Name = "ReportMenuPurRpt"
        Me.ReportMenuPurRpt.Size = New System.Drawing.Size(245, 22)
        Me.ReportMenuPurRpt.Text = "&Purchase Report"
        '
        'ReportMenuPurRetRpt
        '
        Me.ReportMenuPurRetRpt.Image = CType(resources.GetObject("ReportMenuPurRetRpt.Image"), System.Drawing.Image)
        Me.ReportMenuPurRetRpt.Name = "ReportMenuPurRetRpt"
        Me.ReportMenuPurRetRpt.Size = New System.Drawing.Size(245, 22)
        Me.ReportMenuPurRetRpt.Text = "P&urchase Return Report"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(242, 6)
        '
        'ReportMenuSalesRpt
        '
        Me.ReportMenuSalesRpt.Image = CType(resources.GetObject("ReportMenuSalesRpt.Image"), System.Drawing.Image)
        Me.ReportMenuSalesRpt.Name = "ReportMenuSalesRpt"
        Me.ReportMenuSalesRpt.Size = New System.Drawing.Size(245, 22)
        Me.ReportMenuSalesRpt.Text = "&Sales Report"
        '
        'ReportMenuSaleRetRpt
        '
        Me.ReportMenuSaleRetRpt.Image = CType(resources.GetObject("ReportMenuSaleRetRpt.Image"), System.Drawing.Image)
        Me.ReportMenuSaleRetRpt.Name = "ReportMenuSaleRetRpt"
        Me.ReportMenuSaleRetRpt.Size = New System.Drawing.Size(245, 22)
        Me.ReportMenuSaleRetRpt.Text = "S&ales Return Report"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(242, 6)
        '
        'ReportMenuCustom
        '
        Me.ReportMenuCustom.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportMenuCustomUser, Me.ToolStripMenuItem11, Me.ReportMenuCustomPur, Me.ReportMenuCustomPurRet, Me.ToolStripMenuItem10, Me.ReportMenuCustomSales, Me.urnToolStripMenuItemSalesRet})
        Me.ReportMenuCustom.Image = CType(resources.GetObject("ReportMenuCustom.Image"), System.Drawing.Image)
        Me.ReportMenuCustom.Name = "ReportMenuCustom"
        Me.ReportMenuCustom.Size = New System.Drawing.Size(245, 22)
        Me.ReportMenuCustom.Text = "&Custom Report"
        '
        'ReportMenuCustomUser
        '
        Me.ReportMenuCustomUser.Image = CType(resources.GetObject("ReportMenuCustomUser.Image"), System.Drawing.Image)
        Me.ReportMenuCustomUser.Name = "ReportMenuCustomUser"
        Me.ReportMenuCustomUser.Size = New System.Drawing.Size(197, 22)
        Me.ReportMenuCustomUser.Text = "&User Detail"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(194, 6)
        '
        'ReportMenuCustomPur
        '
        Me.ReportMenuCustomPur.Image = CType(resources.GetObject("ReportMenuCustomPur.Image"), System.Drawing.Image)
        Me.ReportMenuCustomPur.Name = "ReportMenuCustomPur"
        Me.ReportMenuCustomPur.Size = New System.Drawing.Size(197, 22)
        Me.ReportMenuCustomPur.Text = "&Purchase"
        '
        'ReportMenuCustomPurRet
        '
        Me.ReportMenuCustomPurRet.Image = CType(resources.GetObject("ReportMenuCustomPurRet.Image"), System.Drawing.Image)
        Me.ReportMenuCustomPurRet.Name = "ReportMenuCustomPurRet"
        Me.ReportMenuCustomPurRet.Size = New System.Drawing.Size(197, 22)
        Me.ReportMenuCustomPurRet.Text = "P&urchase Return"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(194, 6)
        '
        'ReportMenuCustomSales
        '
        Me.ReportMenuCustomSales.Image = CType(resources.GetObject("ReportMenuCustomSales.Image"), System.Drawing.Image)
        Me.ReportMenuCustomSales.Name = "ReportMenuCustomSales"
        Me.ReportMenuCustomSales.Size = New System.Drawing.Size(197, 22)
        Me.ReportMenuCustomSales.Text = "&Sales"
        '
        'urnToolStripMenuItemSalesRet
        '
        Me.urnToolStripMenuItemSalesRet.Image = CType(resources.GetObject("urnToolStripMenuItemSalesRet.Image"), System.Drawing.Image)
        Me.urnToolStripMenuItemSalesRet.Name = "urnToolStripMenuItemSalesRet"
        Me.urnToolStripMenuItemSalesRet.Size = New System.Drawing.Size(197, 22)
        Me.urnToolStripMenuItemSalesRet.Text = "S&ales Return"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsMenuSendEmail, Me.ToolsMenuSetBG, Me.ToolStripMenuItem3, Me.ToolsMenuCalc, Me.ToolsMenuNotepad})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(55, 20)
        Me.ToolsMenu.Text = "T&ools"
        '
        'ToolsMenuSendEmail
        '
        Me.ToolsMenuSendEmail.Image = CType(resources.GetObject("ToolsMenuSendEmail.Image"), System.Drawing.Image)
        Me.ToolsMenuSendEmail.Name = "ToolsMenuSendEmail"
        Me.ToolsMenuSendEmail.Size = New System.Drawing.Size(188, 22)
        Me.ToolsMenuSendEmail.Text = "&Send Email"
        '
        'ToolsMenuSetBG
        '
        Me.ToolsMenuSetBG.Name = "ToolsMenuSetBG"
        Me.ToolsMenuSetBG.Size = New System.Drawing.Size(188, 22)
        Me.ToolsMenuSetBG.Text = "Set&Background"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(185, 6)
        '
        'ToolsMenuCalc
        '
        Me.ToolsMenuCalc.Image = CType(resources.GetObject("ToolsMenuCalc.Image"), System.Drawing.Image)
        Me.ToolsMenuCalc.Name = "ToolsMenuCalc"
        Me.ToolsMenuCalc.Size = New System.Drawing.Size(188, 22)
        Me.ToolsMenuCalc.Text = "&Calculator"
        '
        'ToolsMenuNotepad
        '
        Me.ToolsMenuNotepad.Image = CType(resources.GetObject("ToolsMenuNotepad.Image"), System.Drawing.Image)
        Me.ToolsMenuNotepad.Name = "ToolsMenuNotepad"
        Me.ToolsMenuNotepad.Size = New System.Drawing.Size(188, 22)
        Me.ToolsMenuNotepad.Text = "&Notepad"
        '
        'LayoutMenu
        '
        Me.LayoutMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LayoutMenuCascade, Me.LayoutMenuHorizontal, Me.LayoutMenuVertical, Me.LayoutMenuArrang})
        Me.LayoutMenu.Name = "LayoutMenu"
        Me.LayoutMenu.Size = New System.Drawing.Size(65, 20)
        Me.LayoutMenu.Text = "&Layout"
        '
        'LayoutMenuCascade
        '
        Me.LayoutMenuCascade.Name = "LayoutMenuCascade"
        Me.LayoutMenuCascade.Size = New System.Drawing.Size(173, 22)
        Me.LayoutMenuCascade.Text = "&Cascade"
        '
        'LayoutMenuHorizontal
        '
        Me.LayoutMenuHorizontal.Name = "LayoutMenuHorizontal"
        Me.LayoutMenuHorizontal.Size = New System.Drawing.Size(173, 22)
        Me.LayoutMenuHorizontal.Text = "&Horizontal"
        '
        'LayoutMenuVertical
        '
        Me.LayoutMenuVertical.Name = "LayoutMenuVertical"
        Me.LayoutMenuVertical.Size = New System.Drawing.Size(173, 22)
        Me.LayoutMenuVertical.Text = "&Vertical"
        '
        'LayoutMenuArrang
        '
        Me.LayoutMenuArrang.Name = "LayoutMenuArrang"
        Me.LayoutMenuArrang.Size = New System.Drawing.Size(173, 22)
        Me.LayoutMenuArrang.Text = "&Arrang Icons"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpMenuSysHelp, Me.HelpMenuAboutSys})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(48, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'HelpMenuSysHelp
        '
        Me.HelpMenuSysHelp.Image = CType(resources.GetObject("HelpMenuSysHelp.Image"), System.Drawing.Image)
        Me.HelpMenuSysHelp.Name = "HelpMenuSysHelp"
        Me.HelpMenuSysHelp.Size = New System.Drawing.Size(397, 22)
        Me.HelpMenuSysHelp.Text = "&System Help"
        '
        'HelpMenuAboutSys
        '
        Me.HelpMenuAboutSys.Image = CType(resources.GetObject("HelpMenuAboutSys.Image"), System.Drawing.Image)
        Me.HelpMenuAboutSys.Name = "HelpMenuAboutSys"
        Me.HelpMenuAboutSys.Size = New System.Drawing.Size(397, 22)
        Me.HelpMenuAboutSys.Text = "&About Invoice And Stock Management System"
        '
        'FrmMainStatus
        '
        Me.FrmMainStatus.BackColor = System.Drawing.Color.White
        Me.FrmMainStatus.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.FrmMainStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblStockItem, Me.StatusLblSpace, Me.StatusLblTime})
        Me.FrmMainStatus.Location = New System.Drawing.Point(0, 424)
        Me.FrmMainStatus.Name = "FrmMainStatus"
        Me.FrmMainStatus.Size = New System.Drawing.Size(790, 29)
        Me.FrmMainStatus.TabIndex = 2
        Me.FrmMainStatus.Text = "StatusStrip"
        '
        'LblStockItem
        '
        Me.LblStockItem.AutoSize = False
        Me.LblStockItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LblStockItem.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockItem.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.LblStockItem.Name = "LblStockItem"
        Me.LblStockItem.Size = New System.Drawing.Size(600, 24)
        Me.LblStockItem.Text = ">> Item Stock"
        '
        'StatusLblSpace
        '
        Me.StatusLblSpace.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLblSpace.ForeColor = System.Drawing.Color.Maroon
        Me.StatusLblSpace.Name = "StatusLblSpace"
        Me.StatusLblSpace.Size = New System.Drawing.Size(26, 24)
        Me.StatusLblSpace.Text = " | "
        '
        'StatusLblTime
        '
        Me.StatusLblTime.AutoSize = False
        Me.StatusLblTime.BackColor = System.Drawing.Color.DarkSlateGray
        Me.StatusLblTime.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLblTime.ForeColor = System.Drawing.Color.White
        Me.StatusLblTime.Name = "StatusLblTime"
        Me.StatusLblTime.Size = New System.Drawing.Size(140, 24)
        Me.StatusLblTime.Text = "00 : 00 : 00 AM"
        Me.StatusLblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'OpenFileDialogBG
        '
        Me.OpenFileDialogBG.FileName = "OpenFileDialog1"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(790, 453)
        Me.Controls.Add(Me.FrmMainStatus)
        Me.Controls.Add(Me.MenuMdi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuMdi
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice & Stock Management System - NEW WAY Tech-Solution"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuMdi.ResumeLayout(False)
        Me.MenuMdi.PerformLayout()
        Me.FrmMainStatus.ResumeLayout(False)
        Me.FrmMainStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuMdi As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenuUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenuUserInsert As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenuLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenuUserChange As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenuUserRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransMenuPurchase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LayoutMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LayoutMenuCascade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LayoutMenuHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LayoutMenuVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LayoutMenuArrang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FrmMainStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents FileMenuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenuOpenCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenuOpenSupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenuOpenItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TransMenuSales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenuUserDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenuSendEmail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenuSetBG As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusLblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TransMenuPurRet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportMenuSalesRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportMenuPurRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportMenuUserRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportMenuStockRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolsMenuCalc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenuNotepad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenuAboutSys As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransMenuSaleRet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReportMenuPurRetRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReportMenuSaleRetRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LblStockItem As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusLblSpace As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FileMenuCloseAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialogBG As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ReportMenuCustom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportMenuCustomUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReportMenuCustomPur As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportMenuCustomPurRet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReportMenuCustomSales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents urnToolStripMenuItemSalesRet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenuSysHelp As System.Windows.Forms.ToolStripMenuItem
End Class
