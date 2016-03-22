<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPurchase))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtPurInvoNo = New System.Windows.Forms.TextBox
        Me.GRBMaster = New System.Windows.Forms.GroupBox
        Me.TxtPurDate = New System.Windows.Forms.TextBox
        Me.TxtSupName = New System.Windows.Forms.TextBox
        Me.BtnNewSupp = New System.Windows.Forms.Button
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.CmbSuppId = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.BtnNewItem = New System.Windows.Forms.Button
        Me.CmbCompId = New System.Windows.Forms.ComboBox
        Me.CmbItemName = New System.Windows.Forms.ComboBox
        Me.TxtAm = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.TxtRate = New System.Windows.Forms.TextBox
        Me.TxtDisc = New System.Windows.Forms.TextBox
        Me.TxtQty = New System.Windows.Forms.TextBox
        Me.GRBDetail = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PnlNewItem = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.BtnItemIns = New System.Windows.Forms.Button
        Me.BtnItemCancle = New System.Windows.Forms.Button
        Me.TxtMinQty = New System.Windows.Forms.TextBox
        Me.TxtItemName = New System.Windows.Forms.TextBox
        Me.TxtItemRate = New System.Windows.Forms.TextBox
        Me.TxtItemDisc = New System.Windows.Forms.TextBox
        Me.TxtComID = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PnlMisc = New System.Windows.Forms.Panel
        Me.BtnCancle = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnIns = New System.Windows.Forms.Button
        Me.DgridPurInv = New System.Windows.Forms.DataGridView
        Me.TxtAddVAT = New System.Windows.Forms.TextBox
        Me.TxtVat = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.TxtTotAmu = New System.Windows.Forms.TextBox
        Me.LblAddVat = New System.Windows.Forms.Label
        Me.LblVat = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtTotQty = New System.Windows.Forms.TextBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.PnlNewSpp = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.BtnSuppIns = New System.Windows.Forms.Button
        Me.BtnSuppCancle = New System.Windows.Forms.Button
        Me.TxtSuppPhone = New System.Windows.Forms.TextBox
        Me.TxtSuppId = New System.Windows.Forms.TextBox
        Me.TxtSuppAdd = New System.Windows.Forms.TextBox
        Me.TxtSuppName = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GRBMaster.SuspendLayout()
        Me.GRBDetail.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlNewItem.SuspendLayout()
        Me.PnlMisc.SuspendLayout()
        CType(Me.DgridPurInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlNewSpp.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase Invoice No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(423, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Suppliar ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Purchase Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Item Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(162, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Company ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(290, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(436, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Rate"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(544, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = " Amount"
        '
        'TxtPurInvoNo
        '
        Me.TxtPurInvoNo.BackColor = System.Drawing.Color.White
        Me.TxtPurInvoNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPurInvoNo.Location = New System.Drawing.Point(131, 21)
        Me.TxtPurInvoNo.Name = "TxtPurInvoNo"
        Me.TxtPurInvoNo.Size = New System.Drawing.Size(130, 23)
        Me.TxtPurInvoNo.TabIndex = 0
        '
        'GRBMaster
        '
        Me.GRBMaster.BackColor = System.Drawing.Color.Transparent
        Me.GRBMaster.Controls.Add(Me.TxtPurDate)
        Me.GRBMaster.Controls.Add(Me.TxtSupName)
        Me.GRBMaster.Controls.Add(Me.BtnNewSupp)
        Me.GRBMaster.Controls.Add(Me.BtnSearch)
        Me.GRBMaster.Controls.Add(Me.CmbSuppId)
        Me.GRBMaster.Controls.Add(Me.Label1)
        Me.GRBMaster.Controls.Add(Me.Label25)
        Me.GRBMaster.Controls.Add(Me.Label2)
        Me.GRBMaster.Controls.Add(Me.Label3)
        Me.GRBMaster.Controls.Add(Me.TxtPurInvoNo)
        Me.GRBMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBMaster.ForeColor = System.Drawing.Color.Black
        Me.GRBMaster.Location = New System.Drawing.Point(12, 86)
        Me.GRBMaster.Name = "GRBMaster"
        Me.GRBMaster.Size = New System.Drawing.Size(680, 87)
        Me.GRBMaster.TabIndex = 0
        Me.GRBMaster.TabStop = False
        '
        'TxtPurDate
        '
        Me.TxtPurDate.Location = New System.Drawing.Point(131, 51)
        Me.TxtPurDate.Name = "TxtPurDate"
        Me.TxtPurDate.Size = New System.Drawing.Size(130, 23)
        Me.TxtPurDate.TabIndex = 2
        '
        'TxtSupName
        '
        Me.TxtSupName.BackColor = System.Drawing.Color.White
        Me.TxtSupName.Location = New System.Drawing.Point(497, 50)
        Me.TxtSupName.Name = "TxtSupName"
        Me.TxtSupName.ReadOnly = True
        Me.TxtSupName.Size = New System.Drawing.Size(130, 23)
        Me.TxtSupName.TabIndex = 5
        Me.TxtSupName.TabStop = False
        '
        'BtnNewSupp
        '
        Me.BtnNewSupp.BackgroundImage = CType(resources.GetObject("BtnNewSupp.BackgroundImage"), System.Drawing.Image)
        Me.BtnNewSupp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewSupp.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnNewSupp.FlatAppearance.BorderSize = 0
        Me.BtnNewSupp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnNewSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNewSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNewSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewSupp.Location = New System.Drawing.Point(633, 20)
        Me.BtnNewSupp.Name = "BtnNewSupp"
        Me.BtnNewSupp.Size = New System.Drawing.Size(25, 25)
        Me.BtnNewSupp.TabIndex = 4
        Me.BtnNewSupp.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Location = New System.Drawing.Point(267, 20)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(25, 25)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'CmbSuppId
        '
        Me.CmbSuppId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSuppId.FormattingEnabled = True
        Me.CmbSuppId.Location = New System.Drawing.Point(497, 20)
        Me.CmbSuppId.MaxDropDownItems = 10
        Me.CmbSuppId.Name = "CmbSuppId"
        Me.CmbSuppId.Size = New System.Drawing.Size(130, 24)
        Me.CmbSuppId.Sorted = True
        Me.CmbSuppId.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(401, 55)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(90, 15)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Suppliar Name"
        '
        'BtnNewItem
        '
        Me.BtnNewItem.BackColor = System.Drawing.Color.Transparent
        Me.BtnNewItem.BackgroundImage = CType(resources.GetObject("BtnNewItem.BackgroundImage"), System.Drawing.Image)
        Me.BtnNewItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewItem.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnNewItem.FlatAppearance.BorderSize = 0
        Me.BtnNewItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnNewItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNewItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewItem.Location = New System.Drawing.Point(133, 34)
        Me.BtnNewItem.Name = "BtnNewItem"
        Me.BtnNewItem.Size = New System.Drawing.Size(25, 25)
        Me.BtnNewItem.TabIndex = 1
        Me.BtnNewItem.UseVisualStyleBackColor = False
        '
        'CmbCompId
        '
        Me.CmbCompId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCompId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCompId.FormattingEnabled = True
        Me.CmbCompId.Location = New System.Drawing.Point(165, 36)
        Me.CmbCompId.MaxDropDownItems = 10
        Me.CmbCompId.Name = "CmbCompId"
        Me.CmbCompId.Size = New System.Drawing.Size(120, 23)
        Me.CmbCompId.Sorted = True
        Me.CmbCompId.TabIndex = 2
        '
        'CmbItemName
        '
        Me.CmbItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbItemName.FormattingEnabled = True
        Me.CmbItemName.Location = New System.Drawing.Point(10, 36)
        Me.CmbItemName.MaxDropDownItems = 10
        Me.CmbItemName.Name = "CmbItemName"
        Me.CmbItemName.Size = New System.Drawing.Size(120, 23)
        Me.CmbItemName.TabIndex = 0
        '
        'TxtAm
        '
        Me.TxtAm.BackColor = System.Drawing.Color.White
        Me.TxtAm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAm.Location = New System.Drawing.Point(547, 38)
        Me.TxtAm.Name = "TxtAm"
        Me.TxtAm.Size = New System.Drawing.Size(120, 21)
        Me.TxtAm.TabIndex = 6
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(348, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 15)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Disc %"
        '
        'TxtRate
        '
        Me.TxtRate.BackColor = System.Drawing.SystemColors.Window
        Me.TxtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRate.Location = New System.Drawing.Point(439, 38)
        Me.TxtRate.Name = "TxtRate"
        Me.TxtRate.Size = New System.Drawing.Size(100, 21)
        Me.TxtRate.TabIndex = 5
        '
        'TxtDisc
        '
        Me.TxtDisc.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDisc.Location = New System.Drawing.Point(351, 38)
        Me.TxtDisc.Name = "TxtDisc"
        Me.TxtDisc.Size = New System.Drawing.Size(80, 21)
        Me.TxtDisc.TabIndex = 4
        '
        'TxtQty
        '
        Me.TxtQty.BackColor = System.Drawing.SystemColors.Window
        Me.TxtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQty.Location = New System.Drawing.Point(293, 38)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(50, 21)
        Me.TxtQty.TabIndex = 3
        '
        'GRBDetail
        '
        Me.GRBDetail.BackColor = System.Drawing.Color.Transparent
        Me.GRBDetail.Controls.Add(Me.Label4)
        Me.GRBDetail.Controls.Add(Me.TxtDisc)
        Me.GRBDetail.Controls.Add(Me.TxtQty)
        Me.GRBDetail.Controls.Add(Me.BtnNewItem)
        Me.GRBDetail.Controls.Add(Me.Label6)
        Me.GRBDetail.Controls.Add(Me.CmbItemName)
        Me.GRBDetail.Controls.Add(Me.Label8)
        Me.GRBDetail.Controls.Add(Me.CmbCompId)
        Me.GRBDetail.Controls.Add(Me.TxtRate)
        Me.GRBDetail.Controls.Add(Me.Label7)
        Me.GRBDetail.Controls.Add(Me.Label23)
        Me.GRBDetail.Controls.Add(Me.TxtAm)
        Me.GRBDetail.Controls.Add(Me.Label5)
        Me.GRBDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBDetail.ForeColor = System.Drawing.Color.Black
        Me.GRBDetail.Location = New System.Drawing.Point(12, 176)
        Me.GRBDetail.Name = "GRBDetail"
        Me.GRBDetail.Size = New System.Drawing.Size(680, 68)
        Me.GRBDetail.TabIndex = 1
        Me.GRBDetail.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PnlNewItem
        '
        Me.PnlNewItem.BackgroundImage = CType(resources.GetObject("PnlNewItem.BackgroundImage"), System.Drawing.Image)
        Me.PnlNewItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlNewItem.Controls.Add(Me.Label14)
        Me.PnlNewItem.Controls.Add(Me.BtnItemIns)
        Me.PnlNewItem.Controls.Add(Me.BtnItemCancle)
        Me.PnlNewItem.Controls.Add(Me.TxtMinQty)
        Me.PnlNewItem.Controls.Add(Me.TxtItemName)
        Me.PnlNewItem.Controls.Add(Me.TxtItemRate)
        Me.PnlNewItem.Controls.Add(Me.TxtItemDisc)
        Me.PnlNewItem.Controls.Add(Me.TxtComID)
        Me.PnlNewItem.Controls.Add(Me.Label15)
        Me.PnlNewItem.Controls.Add(Me.Label16)
        Me.PnlNewItem.Controls.Add(Me.Label24)
        Me.PnlNewItem.Controls.Add(Me.Label17)
        Me.PnlNewItem.Controls.Add(Me.Label18)
        Me.PnlNewItem.Location = New System.Drawing.Point(380, 580)
        Me.PnlNewItem.Name = "PnlNewItem"
        Me.PnlNewItem.Size = New System.Drawing.Size(320, 321)
        Me.PnlNewItem.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Teal
        Me.Label14.Location = New System.Drawing.Point(44, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(230, 37)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Add New Item"
        '
        'BtnItemIns
        '
        Me.BtnItemIns.BackColor = System.Drawing.Color.Transparent
        Me.BtnItemIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnItemIns.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnItemIns.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.BtnItemIns.FlatAppearance.BorderSize = 2
        Me.BtnItemIns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnItemIns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BtnItemIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnItemIns.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnItemIns.ForeColor = System.Drawing.Color.CadetBlue
        Me.BtnItemIns.Location = New System.Drawing.Point(29, 268)
        Me.BtnItemIns.Name = "BtnItemIns"
        Me.BtnItemIns.Size = New System.Drawing.Size(115, 31)
        Me.BtnItemIns.TabIndex = 5
        Me.BtnItemIns.Text = "Insert"
        Me.BtnItemIns.UseVisualStyleBackColor = False
        '
        'BtnItemCancle
        '
        Me.BtnItemCancle.BackColor = System.Drawing.Color.Transparent
        Me.BtnItemCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnItemCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnItemCancle.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.BtnItemCancle.FlatAppearance.BorderSize = 2
        Me.BtnItemCancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnItemCancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BtnItemCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnItemCancle.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnItemCancle.ForeColor = System.Drawing.Color.CadetBlue
        Me.BtnItemCancle.Location = New System.Drawing.Point(151, 268)
        Me.BtnItemCancle.Name = "BtnItemCancle"
        Me.BtnItemCancle.Size = New System.Drawing.Size(115, 31)
        Me.BtnItemCancle.TabIndex = 6
        Me.BtnItemCancle.Text = "Cancle"
        Me.BtnItemCancle.UseVisualStyleBackColor = False
        '
        'TxtMinQty
        '
        Me.TxtMinQty.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMinQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMinQty.Location = New System.Drawing.Point(151, 146)
        Me.TxtMinQty.Name = "TxtMinQty"
        Me.TxtMinQty.Size = New System.Drawing.Size(115, 23)
        Me.TxtMinQty.TabIndex = 2
        '
        'TxtItemName
        '
        Me.TxtItemName.BackColor = System.Drawing.SystemColors.Window
        Me.TxtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemName.Location = New System.Drawing.Point(152, 70)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(114, 23)
        Me.TxtItemName.TabIndex = 0
        '
        'TxtItemRate
        '
        Me.TxtItemRate.BackColor = System.Drawing.SystemColors.Window
        Me.TxtItemRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemRate.Location = New System.Drawing.Point(151, 222)
        Me.TxtItemRate.Name = "TxtItemRate"
        Me.TxtItemRate.Size = New System.Drawing.Size(114, 23)
        Me.TxtItemRate.TabIndex = 4
        '
        'TxtItemDisc
        '
        Me.TxtItemDisc.BackColor = System.Drawing.SystemColors.Window
        Me.TxtItemDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemDisc.Location = New System.Drawing.Point(151, 184)
        Me.TxtItemDisc.Name = "TxtItemDisc"
        Me.TxtItemDisc.Size = New System.Drawing.Size(114, 23)
        Me.TxtItemDisc.TabIndex = 3
        '
        'TxtComID
        '
        Me.TxtComID.BackColor = System.Drawing.SystemColors.Window
        Me.TxtComID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComID.Location = New System.Drawing.Point(152, 108)
        Me.TxtComID.Name = "TxtComID"
        Me.TxtComID.Size = New System.Drawing.Size(114, 23)
        Me.TxtComID.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(71, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 15)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Item Name :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(32, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 15)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Minimum Quantity :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(106, 225)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 15)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "Rate :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(84, 187)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 15)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Discount :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(72, 111)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 15)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Comany ID :"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 400
        Me.ToolTip1.BackColor = System.Drawing.Color.Maroon
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Attention"
        '
        'PnlMisc
        '
        Me.PnlMisc.BackColor = System.Drawing.Color.Transparent
        Me.PnlMisc.Controls.Add(Me.BtnCancle)
        Me.PnlMisc.Controls.Add(Me.BtnUpdate)
        Me.PnlMisc.Controls.Add(Me.BtnIns)
        Me.PnlMisc.Controls.Add(Me.DgridPurInv)
        Me.PnlMisc.Controls.Add(Me.TxtAddVAT)
        Me.PnlMisc.Controls.Add(Me.TxtVat)
        Me.PnlMisc.Controls.Add(Me.Label21)
        Me.PnlMisc.Controls.Add(Me.Label20)
        Me.PnlMisc.Controls.Add(Me.Label22)
        Me.PnlMisc.Controls.Add(Me.TxtTotAmu)
        Me.PnlMisc.Controls.Add(Me.LblAddVat)
        Me.PnlMisc.Controls.Add(Me.LblVat)
        Me.PnlMisc.Controls.Add(Me.Label19)
        Me.PnlMisc.Controls.Add(Me.TxtTotQty)
        Me.PnlMisc.Controls.Add(Me.BtnAdd)
        Me.PnlMisc.Location = New System.Drawing.Point(5, 247)
        Me.PnlMisc.Name = "PnlMisc"
        Me.PnlMisc.Size = New System.Drawing.Size(695, 315)
        Me.PnlMisc.TabIndex = 2
        '
        'BtnCancle
        '
        Me.BtnCancle.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancle.BackgroundImage = CType(resources.GetObject("BtnCancle.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancle.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCancle.FlatAppearance.BorderSize = 0
        Me.BtnCancle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.BtnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancle.ForeColor = System.Drawing.Color.White
        Me.BtnCancle.Location = New System.Drawing.Point(547, 272)
        Me.BtnCancle.Name = "BtnCancle"
        Me.BtnCancle.Size = New System.Drawing.Size(130, 31)
        Me.BtnCancle.TabIndex = 7
        Me.BtnCancle.Text = "CANCEL   "
        Me.BtnCancle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancle.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.BtnUpdate.BackgroundImage = CType(resources.GetObject("BtnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(419, 272)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(130, 31)
        Me.BtnUpdate.TabIndex = 6
        Me.BtnUpdate.Text = "UPDATE   "
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnIns
        '
        Me.BtnIns.BackColor = System.Drawing.Color.Transparent
        Me.BtnIns.BackgroundImage = CType(resources.GetObject("BtnIns.BackgroundImage"), System.Drawing.Image)
        Me.BtnIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnIns.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnIns.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnIns.FlatAppearance.BorderSize = 0
        Me.BtnIns.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.BtnIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIns.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIns.ForeColor = System.Drawing.Color.White
        Me.BtnIns.Location = New System.Drawing.Point(291, 272)
        Me.BtnIns.Name = "BtnIns"
        Me.BtnIns.Size = New System.Drawing.Size(130, 31)
        Me.BtnIns.TabIndex = 3
        Me.BtnIns.Text = "INSERT ITEM"
        Me.BtnIns.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnIns.UseVisualStyleBackColor = False
        '
        'DgridPurInv
        '
        Me.DgridPurInv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgridPurInv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgridPurInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgridPurInv.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgridPurInv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgridPurInv.Location = New System.Drawing.Point(7, 6)
        Me.DgridPurInv.Name = "DgridPurInv"
        Me.DgridPurInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridPurInv.Size = New System.Drawing.Size(680, 160)
        Me.DgridPurInv.TabIndex = 27
        Me.DgridPurInv.TabStop = False
        '
        'TxtAddVAT
        '
        Me.TxtAddVAT.BackColor = System.Drawing.Color.White
        Me.TxtAddVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddVAT.Location = New System.Drawing.Point(555, 205)
        Me.TxtAddVAT.Name = "TxtAddVAT"
        Me.TxtAddVAT.ReadOnly = True
        Me.TxtAddVAT.Size = New System.Drawing.Size(120, 23)
        Me.TxtAddVAT.TabIndex = 1
        Me.TxtAddVAT.TabStop = False
        '
        'TxtVat
        '
        Me.TxtVat.BackColor = System.Drawing.Color.White
        Me.TxtVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVat.Location = New System.Drawing.Point(555, 176)
        Me.TxtVat.Name = "TxtVat"
        Me.TxtVat.ReadOnly = True
        Me.TxtVat.Size = New System.Drawing.Size(120, 23)
        Me.TxtVat.TabIndex = 0
        Me.TxtVat.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(214, 180)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 15)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Total Quantity"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(470, 238)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 15)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Total Amount"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(421, 209)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(85, 15)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Additional VAT"
        '
        'TxtTotAmu
        '
        Me.TxtTotAmu.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTotAmu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotAmu.Location = New System.Drawing.Point(555, 234)
        Me.TxtTotAmu.Name = "TxtTotAmu"
        Me.TxtTotAmu.ReadOnly = True
        Me.TxtTotAmu.Size = New System.Drawing.Size(120, 23)
        Me.TxtTotAmu.TabIndex = 2
        Me.TxtTotAmu.TabStop = False
        '
        'LblAddVat
        '
        Me.LblAddVat.BackColor = System.Drawing.Color.Transparent
        Me.LblAddVat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAddVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddVat.ForeColor = System.Drawing.Color.GreenYellow
        Me.LblAddVat.Location = New System.Drawing.Point(509, 207)
        Me.LblAddVat.Name = "LblAddVat"
        Me.LblAddVat.Size = New System.Drawing.Size(40, 18)
        Me.LblAddVat.TabIndex = 26
        Me.LblAddVat.Text = "0.00"
        '
        'LblVat
        '
        Me.LblVat.BackColor = System.Drawing.Color.Transparent
        Me.LblVat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVat.ForeColor = System.Drawing.Color.GreenYellow
        Me.LblVat.Location = New System.Drawing.Point(509, 180)
        Me.LblVat.Name = "LblVat"
        Me.LblVat.Size = New System.Drawing.Size(40, 18)
        Me.LblVat.TabIndex = 23
        Me.LblVat.Text = "0.00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(439, 180)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 15)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Output VAT"
        '
        'TxtTotQty
        '
        Me.TxtTotQty.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTotQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotQty.Location = New System.Drawing.Point(301, 176)
        Me.TxtTotQty.Name = "TxtTotQty"
        Me.TxtTotQty.ReadOnly = True
        Me.TxtTotQty.Size = New System.Drawing.Size(50, 23)
        Me.TxtTotQty.TabIndex = 0
        Me.TxtTotQty.TabStop = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdd.BackgroundImage = CType(resources.GetObject("BtnAdd.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(163, 272)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(130, 31)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "NEW     "
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'PnlNewSpp
        '
        Me.PnlNewSpp.BackgroundImage = CType(resources.GetObject("PnlNewSpp.BackgroundImage"), System.Drawing.Image)
        Me.PnlNewSpp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlNewSpp.Controls.Add(Me.Label11)
        Me.PnlNewSpp.Controls.Add(Me.BtnSuppIns)
        Me.PnlNewSpp.Controls.Add(Me.BtnSuppCancle)
        Me.PnlNewSpp.Controls.Add(Me.TxtSuppPhone)
        Me.PnlNewSpp.Controls.Add(Me.TxtSuppId)
        Me.PnlNewSpp.Controls.Add(Me.TxtSuppAdd)
        Me.PnlNewSpp.Controls.Add(Me.TxtSuppName)
        Me.PnlNewSpp.Controls.Add(Me.Label12)
        Me.PnlNewSpp.Controls.Add(Me.Label9)
        Me.PnlNewSpp.Controls.Add(Me.Label13)
        Me.PnlNewSpp.Controls.Add(Me.Label10)
        Me.PnlNewSpp.Location = New System.Drawing.Point(10, 580)
        Me.PnlNewSpp.Name = "PnlNewSpp"
        Me.PnlNewSpp.Size = New System.Drawing.Size(357, 345)
        Me.PnlNewSpp.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(40, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(290, 37)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Add New Supplier"
        '
        'BtnSuppIns
        '
        Me.BtnSuppIns.BackColor = System.Drawing.Color.Transparent
        Me.BtnSuppIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSuppIns.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSuppIns.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.BtnSuppIns.FlatAppearance.BorderSize = 2
        Me.BtnSuppIns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnSuppIns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BtnSuppIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSuppIns.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuppIns.ForeColor = System.Drawing.Color.CadetBlue
        Me.BtnSuppIns.Location = New System.Drawing.Point(30, 289)
        Me.BtnSuppIns.Name = "BtnSuppIns"
        Me.BtnSuppIns.Size = New System.Drawing.Size(115, 31)
        Me.BtnSuppIns.TabIndex = 4
        Me.BtnSuppIns.Text = "Insert"
        Me.BtnSuppIns.UseVisualStyleBackColor = False
        '
        'BtnSuppCancle
        '
        Me.BtnSuppCancle.BackColor = System.Drawing.Color.Transparent
        Me.BtnSuppCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSuppCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSuppCancle.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.BtnSuppCancle.FlatAppearance.BorderSize = 2
        Me.BtnSuppCancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnSuppCancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BtnSuppCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSuppCancle.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuppCancle.ForeColor = System.Drawing.Color.CadetBlue
        Me.BtnSuppCancle.Location = New System.Drawing.Point(151, 289)
        Me.BtnSuppCancle.Name = "BtnSuppCancle"
        Me.BtnSuppCancle.Size = New System.Drawing.Size(115, 31)
        Me.BtnSuppCancle.TabIndex = 5
        Me.BtnSuppCancle.Text = "Cancle"
        Me.BtnSuppCancle.UseVisualStyleBackColor = False
        '
        'TxtSuppPhone
        '
        Me.TxtSuppPhone.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSuppPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSuppPhone.Location = New System.Drawing.Point(152, 243)
        Me.TxtSuppPhone.Name = "TxtSuppPhone"
        Me.TxtSuppPhone.Size = New System.Drawing.Size(115, 23)
        Me.TxtSuppPhone.TabIndex = 3
        '
        'TxtSuppId
        '
        Me.TxtSuppId.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSuppId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSuppId.Location = New System.Drawing.Point(152, 76)
        Me.TxtSuppId.Name = "TxtSuppId"
        Me.TxtSuppId.Size = New System.Drawing.Size(114, 23)
        Me.TxtSuppId.TabIndex = 0
        '
        'TxtSuppAdd
        '
        Me.TxtSuppAdd.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSuppAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSuppAdd.Location = New System.Drawing.Point(152, 154)
        Me.TxtSuppAdd.Multiline = True
        Me.TxtSuppAdd.Name = "TxtSuppAdd"
        Me.TxtSuppAdd.Size = New System.Drawing.Size(177, 71)
        Me.TxtSuppAdd.TabIndex = 2
        '
        'TxtSuppName
        '
        Me.TxtSuppName.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSuppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSuppName.Location = New System.Drawing.Point(152, 115)
        Me.TxtSuppName.Name = "TxtSuppName"
        Me.TxtSuppName.Size = New System.Drawing.Size(177, 23)
        Me.TxtSuppName.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(71, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 15)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Supplier ID :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(47, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Supplier Phone :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(39, 159)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 15)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Supplier Address :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(49, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 15)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Supplier Name :"
        '
        'FrmPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(704, 748)
        Me.Controls.Add(Me.PnlNewSpp)
        Me.Controls.Add(Me.PnlNewItem)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GRBMaster)
        Me.Controls.Add(Me.GRBDetail)
        Me.Controls.Add(Me.PnlMisc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmPurchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase"
        Me.GRBMaster.ResumeLayout(False)
        Me.GRBMaster.PerformLayout()
        Me.GRBDetail.ResumeLayout(False)
        Me.GRBDetail.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlNewItem.ResumeLayout(False)
        Me.PnlNewItem.PerformLayout()
        Me.PnlMisc.ResumeLayout(False)
        Me.PnlMisc.PerformLayout()
        CType(Me.DgridPurInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlNewSpp.ResumeLayout(False)
        Me.PnlNewSpp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtPurInvoNo As System.Windows.Forms.TextBox
    Friend WithEvents GRBMaster As System.Windows.Forms.GroupBox
    Friend WithEvents GRBDetail As System.Windows.Forms.GroupBox
    Friend WithEvents CmbCompId As System.Windows.Forms.ComboBox
    Friend WithEvents CmbItemName As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSuppId As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAm As System.Windows.Forms.TextBox
    Friend WithEvents TxtDisc As System.Windows.Forms.TextBox
    Friend WithEvents TxtQty As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PnlNewItem As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BtnItemIns As System.Windows.Forms.Button
    Friend WithEvents BtnItemCancle As System.Windows.Forms.Button
    Friend WithEvents TxtMinQty As System.Windows.Forms.TextBox
    Friend WithEvents TxtItemName As System.Windows.Forms.TextBox
    Friend WithEvents TxtComID As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtItemDisc As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtRate As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents BtnNewSupp As System.Windows.Forms.Button
    Friend WithEvents BtnNewItem As System.Windows.Forms.Button
    Friend WithEvents TxtItemRate As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TxtSupName As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtPurDate As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PnlMisc As System.Windows.Forms.Panel
    Friend WithEvents DgridPurInv As System.Windows.Forms.DataGridView
    Friend WithEvents TxtAddVAT As System.Windows.Forms.TextBox
    Friend WithEvents TxtVat As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents BtnIns As System.Windows.Forms.Button
    Friend WithEvents TxtTotAmu As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancle As System.Windows.Forms.Button
    Friend WithEvents LblAddVat As System.Windows.Forms.Label
    Friend WithEvents LblVat As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtTotQty As System.Windows.Forms.TextBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents PnlNewSpp As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnSuppIns As System.Windows.Forms.Button
    Friend WithEvents BtnSuppCancle As System.Windows.Forms.Button
    Friend WithEvents TxtSuppPhone As System.Windows.Forms.TextBox
    Friend WithEvents TxtSuppId As System.Windows.Forms.TextBox
    Friend WithEvents TxtSuppAdd As System.Windows.Forms.TextBox
    Friend WithEvents TxtSuppName As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
