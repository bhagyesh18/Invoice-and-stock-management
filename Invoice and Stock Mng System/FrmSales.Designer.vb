<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSales
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSales))
        Me.TxtSalesInvNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtVat = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtTotAm = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtAddVat = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtTotQty = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtSalesDate = New System.Windows.Forms.TextBox
        Me.CmbCustId = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGSales = New System.Windows.Forms.DataGridView
        Me.CmbItemName = New System.Windows.Forms.ComboBox
        Me.CmbCompId = New System.Windows.Forms.ComboBox
        Me.TxtSrNo = New System.Windows.Forms.TextBox
        Me.TxtRate = New System.Windows.Forms.TextBox
        Me.TxtQty = New System.Windows.Forms.TextBox
        Me.TxtAmu = New System.Windows.Forms.TextBox
        Me.TxtDisc = New System.Windows.Forms.TextBox
        Me.RTBCustDetail = New System.Windows.Forms.RichTextBox
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnNewCust = New System.Windows.Forms.Button
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.PrintInvoice = New System.Drawing.Printing.PrintDocument
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LblAddVat = New System.Windows.Forms.Label
        Me.LblVat = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PnlNewCus = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.BtnCusIns = New System.Windows.Forms.Button
        Me.BtnCusCancle = New System.Windows.Forms.Button
        Me.TxtCusPhone = New System.Windows.Forms.TextBox
        Me.TxtCusId = New System.Windows.Forms.TextBox
        Me.TxtCusAdd = New System.Windows.Forms.TextBox
        Me.TxtCusName = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.PnlNewCus.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtSalesInvNo
        '
        Me.TxtSalesInvNo.Location = New System.Drawing.Point(108, 18)
        Me.TxtSalesInvNo.Name = "TxtSalesInvNo"
        Me.TxtSalesInvNo.Size = New System.Drawing.Size(100, 20)
        Me.TxtSalesInvNo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(443, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Output Vat"
        '
        'TxtVat
        '
        Me.TxtVat.Location = New System.Drawing.Point(553, 13)
        Me.TxtVat.Name = "TxtVat"
        Me.TxtVat.ReadOnly = True
        Me.TxtVat.Size = New System.Drawing.Size(100, 20)
        Me.TxtVat.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(477, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total Amount"
        '
        'TxtTotAm
        '
        Me.TxtTotAm.Location = New System.Drawing.Point(553, 67)
        Me.TxtTotAm.Name = "TxtTotAm"
        Me.TxtTotAm.ReadOnly = True
        Me.TxtTotAm.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotAm.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(341, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Customer Id"
        '
        'TxtAddVat
        '
        Me.TxtAddVat.Location = New System.Drawing.Point(553, 39)
        Me.TxtAddVat.Name = "TxtAddVat"
        Me.TxtAddVat.ReadOnly = True
        Me.TxtAddVat.Size = New System.Drawing.Size(100, 20)
        Me.TxtAddVat.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(40, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sales Date "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(248, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total Quantity"
        '
        'TxtTotQty
        '
        Me.TxtTotQty.Location = New System.Drawing.Point(327, 13)
        Me.TxtTotQty.Name = "TxtTotQty"
        Me.TxtTotQty.ReadOnly = True
        Me.TxtTotQty.Size = New System.Drawing.Size(51, 20)
        Me.TxtTotQty.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(11, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Sales Invoice No "
        '
        'TxtSalesDate
        '
        Me.TxtSalesDate.Location = New System.Drawing.Point(108, 46)
        Me.TxtSalesDate.Name = "TxtSalesDate"
        Me.TxtSalesDate.ReadOnly = True
        Me.TxtSalesDate.Size = New System.Drawing.Size(100, 20)
        Me.TxtSalesDate.TabIndex = 2
        '
        'CmbCustId
        '
        Me.CmbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCustId.FormattingEnabled = True
        Me.CmbCustId.Location = New System.Drawing.Point(409, 19)
        Me.CmbCustId.Name = "CmbCustId"
        Me.CmbCustId.Size = New System.Drawing.Size(158, 21)
        Me.CmbCustId.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(429, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Additional Vat"
        '
        'DGSales
        '
        Me.DGSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGSales.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGSales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGSales.Location = New System.Drawing.Point(12, 261)
        Me.DGSales.Name = "DGSales"
        Me.DGSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGSales.Size = New System.Drawing.Size(658, 190)
        Me.DGSales.TabIndex = 18
        Me.DGSales.TabStop = False
        '
        'CmbItemName
        '
        Me.CmbItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbItemName.FormattingEnabled = True
        Me.CmbItemName.Location = New System.Drawing.Point(5, 30)
        Me.CmbItemName.Name = "CmbItemName"
        Me.CmbItemName.Size = New System.Drawing.Size(99, 21)
        Me.CmbItemName.TabIndex = 1
        '
        'CmbCompId
        '
        Me.CmbCompId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCompId.FormattingEnabled = True
        Me.CmbCompId.Location = New System.Drawing.Point(112, 30)
        Me.CmbCompId.Name = "CmbCompId"
        Me.CmbCompId.Size = New System.Drawing.Size(99, 21)
        Me.CmbCompId.TabIndex = 2
        '
        'TxtSrNo
        '
        Me.TxtSrNo.Location = New System.Drawing.Point(219, 31)
        Me.TxtSrNo.Name = "TxtSrNo"
        Me.TxtSrNo.Size = New System.Drawing.Size(100, 20)
        Me.TxtSrNo.TabIndex = 3
        '
        'TxtRate
        '
        Me.TxtRate.Location = New System.Drawing.Point(386, 31)
        Me.TxtRate.Name = "TxtRate"
        Me.TxtRate.Size = New System.Drawing.Size(100, 20)
        Me.TxtRate.TabIndex = 5
        '
        'TxtQty
        '
        Me.TxtQty.Location = New System.Drawing.Point(327, 31)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(51, 20)
        Me.TxtQty.TabIndex = 4
        '
        'TxtAmu
        '
        Me.TxtAmu.Location = New System.Drawing.Point(553, 31)
        Me.TxtAmu.Name = "TxtAmu"
        Me.TxtAmu.Size = New System.Drawing.Size(100, 20)
        Me.TxtAmu.TabIndex = 7
        '
        'TxtDisc
        '
        Me.TxtDisc.Location = New System.Drawing.Point(494, 31)
        Me.TxtDisc.Name = "TxtDisc"
        Me.TxtDisc.Size = New System.Drawing.Size(51, 20)
        Me.TxtDisc.TabIndex = 6
        '
        'RTBCustDetail
        '
        Me.RTBCustDetail.Location = New System.Drawing.Point(409, 46)
        Me.RTBCustDetail.Name = "RTBCustDetail"
        Me.RTBCustDetail.ReadOnly = True
        Me.RTBCustDetail.Size = New System.Drawing.Size(239, 55)
        Me.RTBCustDetail.TabIndex = 5
        Me.RTBCustDetail.Text = ""
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(523, 99)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(130, 31)
        Me.BtnCancel.TabIndex = 17
        Me.BtnCancel.Text = "CANCEL   "
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.White
        Me.BtnPrint.Location = New System.Drawing.Point(267, 99)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(130, 31)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.Text = "PRINT    "
        Me.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdd.BackgroundImage = CType(resources.GetObject("BtnAdd.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(11, 99)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(130, 31)
        Me.BtnAdd.TabIndex = 12
        Me.BtnAdd.Text = "NEW     "
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.BtnUpdate.BackgroundImage = CType(resources.GetObject("BtnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(395, 99)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(130, 31)
        Me.BtnUpdate.TabIndex = 13
        Me.BtnUpdate.Text = "UPDATE   "
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnInsert
        '
        Me.BtnInsert.BackColor = System.Drawing.Color.Transparent
        Me.BtnInsert.BackgroundImage = CType(resources.GetObject("BtnInsert.BackgroundImage"), System.Drawing.Image)
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnInsert.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnInsert.FlatAppearance.BorderSize = 0
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsert.ForeColor = System.Drawing.Color.White
        Me.BtnInsert.Location = New System.Drawing.Point(139, 99)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(130, 31)
        Me.BtnInsert.TabIndex = 3
        Me.BtnInsert.Text = "INSERT   "
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = False
        '
        'BtnNewCust
        '
        Me.BtnNewCust.BackgroundImage = CType(resources.GetObject("BtnNewCust.BackgroundImage"), System.Drawing.Image)
        Me.BtnNewCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewCust.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnNewCust.FlatAppearance.BorderSize = 0
        Me.BtnNewCust.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnNewCust.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNewCust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNewCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewCust.Location = New System.Drawing.Point(574, 17)
        Me.BtnNewCust.Name = "BtnNewCust"
        Me.BtnNewCust.Size = New System.Drawing.Size(25, 25)
        Me.BtnNewCust.TabIndex = 4
        Me.BtnNewCust.UseVisualStyleBackColor = True
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
        Me.BtnSearch.Location = New System.Drawing.Point(214, 15)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(25, 25)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'PrintInvoice
        '
        Me.PrintInvoice.DocumentName = "invoice"
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrev.BackgroundImage = CType(resources.GetObject("BtnPrev.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPrev.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnPrev.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnPrev.FlatAppearance.BorderSize = 0
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrev.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.ForeColor = System.Drawing.Color.White
        Me.BtnPrev.Location = New System.Drawing.Point(11, 62)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(130, 31)
        Me.BtnPrev.TabIndex = 16
        Me.BtnPrev.Tag = ""
        Me.BtnPrev.Text = "Print Preview"
        Me.BtnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrev.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.ShowIcon = False
        Me.PrintPreviewDialog1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Controls.Add(Me.BtnNewCust)
        Me.GroupBox1.Controls.Add(Me.CmbCustId)
        Me.GroupBox1.Controls.Add(Me.RTBCustDetail)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtSalesInvNo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtSalesDate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(322, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Customer Detail"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(239, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'LblAddVat
        '
        Me.LblAddVat.BackColor = System.Drawing.Color.Transparent
        Me.LblAddVat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAddVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddVat.ForeColor = System.Drawing.Color.OrangeRed
        Me.LblAddVat.Location = New System.Drawing.Point(507, 41)
        Me.LblAddVat.Name = "LblAddVat"
        Me.LblAddVat.Size = New System.Drawing.Size(40, 18)
        Me.LblAddVat.TabIndex = 28
        Me.LblAddVat.Text = "0.00"
        '
        'LblVat
        '
        Me.LblVat.BackColor = System.Drawing.Color.Transparent
        Me.LblVat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVat.ForeColor = System.Drawing.Color.OrangeRed
        Me.LblVat.Location = New System.Drawing.Point(507, 15)
        Me.LblVat.Name = "LblVat"
        Me.LblVat.Size = New System.Drawing.Size(40, 18)
        Me.LblVat.TabIndex = 27
        Me.LblVat.Text = "0.00"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.CmbItemName)
        Me.GroupBox2.Controls.Add(Me.TxtSrNo)
        Me.GroupBox2.Controls.Add(Me.TxtRate)
        Me.GroupBox2.Controls.Add(Me.TxtQty)
        Me.GroupBox2.Controls.Add(Me.TxtAmu)
        Me.GroupBox2.Controls.Add(Me.TxtDisc)
        Me.GroupBox2.Controls.Add(Me.CmbCompId)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(658, 64)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(2, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Item Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(324, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Quantity"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(550, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = " Amount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(384, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 15)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Rate"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(491, 13)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 15)
        Me.Label23.TabIndex = 12
        Me.Label23.Text = "Disc %"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(216, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 15)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Serial Number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(109, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 15)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Company ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BtnCancel)
        Me.GroupBox3.Controls.Add(Me.BtnUpdate)
        Me.GroupBox3.Controls.Add(Me.BtnPrint)
        Me.GroupBox3.Controls.Add(Me.BtnInsert)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.LblAddVat)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.LblVat)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtVat)
        Me.GroupBox3.Controls.Add(Me.TxtTotAm)
        Me.GroupBox3.Controls.Add(Me.BtnPrev)
        Me.GroupBox3.Controls.Add(Me.TxtAddVat)
        Me.GroupBox3.Controls.Add(Me.BtnAdd)
        Me.GroupBox3.Controls.Add(Me.TxtTotQty)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 454)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(658, 140)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'PnlNewCus
        '
        Me.PnlNewCus.BackgroundImage = CType(resources.GetObject("PnlNewCus.BackgroundImage"), System.Drawing.Image)
        Me.PnlNewCus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlNewCus.Controls.Add(Me.Label15)
        Me.PnlNewCus.Controls.Add(Me.BtnCusIns)
        Me.PnlNewCus.Controls.Add(Me.BtnCusCancle)
        Me.PnlNewCus.Controls.Add(Me.TxtCusPhone)
        Me.PnlNewCus.Controls.Add(Me.TxtCusId)
        Me.PnlNewCus.Controls.Add(Me.TxtCusAdd)
        Me.PnlNewCus.Controls.Add(Me.TxtCusName)
        Me.PnlNewCus.Controls.Add(Me.Label16)
        Me.PnlNewCus.Controls.Add(Me.Label17)
        Me.PnlNewCus.Controls.Add(Me.Label18)
        Me.PnlNewCus.Controls.Add(Me.Label19)
        Me.PnlNewCus.Location = New System.Drawing.Point(12, 600)
        Me.PnlNewCus.Name = "PnlNewCus"
        Me.PnlNewCus.Size = New System.Drawing.Size(357, 345)
        Me.PnlNewCus.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Teal
        Me.Label15.Location = New System.Drawing.Point(24, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(312, 37)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Add New Customer"
        '
        'BtnCusIns
        '
        Me.BtnCusIns.BackColor = System.Drawing.Color.Transparent
        Me.BtnCusIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCusIns.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCusIns.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.BtnCusIns.FlatAppearance.BorderSize = 2
        Me.BtnCusIns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnCusIns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BtnCusIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCusIns.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCusIns.ForeColor = System.Drawing.Color.CadetBlue
        Me.BtnCusIns.Location = New System.Drawing.Point(30, 289)
        Me.BtnCusIns.Name = "BtnCusIns"
        Me.BtnCusIns.Size = New System.Drawing.Size(115, 31)
        Me.BtnCusIns.TabIndex = 4
        Me.BtnCusIns.Text = "Insert"
        Me.BtnCusIns.UseVisualStyleBackColor = False
        '
        'BtnCusCancle
        '
        Me.BtnCusCancle.BackColor = System.Drawing.Color.Transparent
        Me.BtnCusCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCusCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCusCancle.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.BtnCusCancle.FlatAppearance.BorderSize = 2
        Me.BtnCusCancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnCusCancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BtnCusCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCusCancle.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCusCancle.ForeColor = System.Drawing.Color.CadetBlue
        Me.BtnCusCancle.Location = New System.Drawing.Point(151, 289)
        Me.BtnCusCancle.Name = "BtnCusCancle"
        Me.BtnCusCancle.Size = New System.Drawing.Size(115, 31)
        Me.BtnCusCancle.TabIndex = 5
        Me.BtnCusCancle.Text = "Cancel"
        Me.BtnCusCancle.UseVisualStyleBackColor = False
        '
        'TxtCusPhone
        '
        Me.TxtCusPhone.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCusPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCusPhone.Location = New System.Drawing.Point(152, 243)
        Me.TxtCusPhone.Name = "TxtCusPhone"
        Me.TxtCusPhone.Size = New System.Drawing.Size(115, 23)
        Me.TxtCusPhone.TabIndex = 3
        '
        'TxtCusId
        '
        Me.TxtCusId.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCusId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCusId.Location = New System.Drawing.Point(152, 76)
        Me.TxtCusId.Name = "TxtCusId"
        Me.TxtCusId.Size = New System.Drawing.Size(114, 23)
        Me.TxtCusId.TabIndex = 0
        '
        'TxtCusAdd
        '
        Me.TxtCusAdd.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCusAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCusAdd.Location = New System.Drawing.Point(152, 154)
        Me.TxtCusAdd.Multiline = True
        Me.TxtCusAdd.Name = "TxtCusAdd"
        Me.TxtCusAdd.Size = New System.Drawing.Size(177, 71)
        Me.TxtCusAdd.TabIndex = 2
        '
        'TxtCusName
        '
        Me.TxtCusName.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCusName.Location = New System.Drawing.Point(152, 115)
        Me.TxtCusName.Name = "TxtCusName"
        Me.TxtCusName.Size = New System.Drawing.Size(177, 23)
        Me.TxtCusName.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(64, 81)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 15)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Customer ID :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(40, 248)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 15)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Customer Phone :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(32, 159)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 15)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Customer Address :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(42, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(103, 15)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Customer Name :"
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
        'FrmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(685, 714)
        Me.Controls.Add(Me.PnlNewCus)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FrmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Entry"
        CType(Me.DGSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.PnlNewCus.ResumeLayout(False)
        Me.PnlNewCus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtSalesInvNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtVat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTotAm As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtAddVat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTotQty As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtSalesDate As System.Windows.Forms.TextBox
    Friend WithEvents CmbCustId As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGSales As System.Windows.Forms.DataGridView
    Friend WithEvents CmbItemName As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCompId As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSrNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtRate As System.Windows.Forms.TextBox
    Friend WithEvents TxtQty As System.Windows.Forms.TextBox
    Friend WithEvents TxtAmu As System.Windows.Forms.TextBox
    Friend WithEvents TxtDisc As System.Windows.Forms.TextBox
    Friend WithEvents RTBCustDetail As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnNewCust As System.Windows.Forms.Button
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents PrintInvoice As System.Drawing.Printing.PrintDocument
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblAddVat As System.Windows.Forms.Label
    Friend WithEvents LblVat As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PnlNewCus As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BtnCusIns As System.Windows.Forms.Button
    Friend WithEvents BtnCusCancle As System.Windows.Forms.Button
    Friend WithEvents TxtCusPhone As System.Windows.Forms.TextBox
    Friend WithEvents TxtCusId As System.Windows.Forms.TextBox
    Friend WithEvents TxtCusAdd As System.Windows.Forms.TextBox
    Friend WithEvents TxtCusName As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
