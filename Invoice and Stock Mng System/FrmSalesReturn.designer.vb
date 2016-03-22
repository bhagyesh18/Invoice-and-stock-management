<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalesReturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSalesReturn))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TxtQty = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmbComID = New System.Windows.Forms.ComboBox
        Me.CmbItemName = New System.Windows.Forms.ComboBox
        Me.BtnIns = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtNCancel = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DgridsaleRet = New System.Windows.Forms.DataGridView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmbSaleRetNo = New System.Windows.Forms.ComboBox
        Me.TxtCusName = New System.Windows.Forms.TextBox
        Me.CmbCusId = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtRetDate = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgridsaleRet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtQty
        '
        Me.TxtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQty.Location = New System.Drawing.Point(339, 35)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(130, 23)
        Me.TxtQty.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Item Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(174, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Company ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(336, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Quntity"
        '
        'CmbComID
        '
        Me.CmbComID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbComID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbComID.FormattingEnabled = True
        Me.CmbComID.Location = New System.Drawing.Point(177, 34)
        Me.CmbComID.Name = "CmbComID"
        Me.CmbComID.Size = New System.Drawing.Size(130, 24)
        Me.CmbComID.TabIndex = 6
        '
        'CmbItemName
        '
        Me.CmbItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbItemName.FormattingEnabled = True
        Me.CmbItemName.Location = New System.Drawing.Point(15, 34)
        Me.CmbItemName.Name = "CmbItemName"
        Me.CmbItemName.Size = New System.Drawing.Size(130, 24)
        Me.CmbItemName.TabIndex = 5
        '
        'BtnIns
        '
        Me.BtnIns.BackColor = System.Drawing.Color.Transparent
        Me.BtnIns.BackgroundImage = CType(resources.GetObject("BtnIns.BackgroundImage"), System.Drawing.Image)
        Me.BtnIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnIns.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnIns.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnIns.FlatAppearance.BorderSize = 0
        Me.BtnIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIns.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIns.ForeColor = System.Drawing.Color.White
        Me.BtnIns.Location = New System.Drawing.Point(168, 20)
        Me.BtnIns.Name = "BtnIns"
        Me.BtnIns.Size = New System.Drawing.Size(130, 31)
        Me.BtnIns.TabIndex = 9
        Me.BtnIns.Text = "INSERT ITEM"
        Me.BtnIns.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnIns.UseVisualStyleBackColor = False
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
        Me.BtnAdd.Location = New System.Drawing.Point(40, 20)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(130, 31)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "NEW"
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
        Me.BtnUpdate.Location = New System.Drawing.Point(296, 20)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(130, 31)
        Me.BtnUpdate.TabIndex = 10
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtNCancel
        '
        Me.BtNCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtNCancel.BackgroundImage = CType(resources.GetObject("BtNCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtNCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtNCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtNCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtNCancel.FlatAppearance.BorderSize = 0
        Me.BtNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtNCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNCancel.ForeColor = System.Drawing.Color.White
        Me.BtNCancel.Location = New System.Drawing.Point(424, 20)
        Me.BtNCancel.Name = "BtNCancel"
        Me.BtNCancel.Size = New System.Drawing.Size(130, 31)
        Me.BtNCancel.TabIndex = 11
        Me.BtNCancel.Text = "CANCEL"
        Me.BtNCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtNCancel.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmbItemName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtQty)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.CmbComID)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(591, 68)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'DgridsaleRet
        '
        Me.DgridsaleRet.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgridsaleRet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgridsaleRet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgridsaleRet.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgridsaleRet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgridsaleRet.Location = New System.Drawing.Point(12, 242)
        Me.DgridsaleRet.Name = "DgridsaleRet"
        Me.DgridsaleRet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridsaleRet.Size = New System.Drawing.Size(591, 174)
        Me.DgridsaleRet.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CmbSaleRetNo)
        Me.GroupBox1.Controls.Add(Me.TxtCusName)
        Me.GroupBox1.Controls.Add(Me.CmbCusId)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtRetDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 83)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'CmbSaleRetNo
        '
        Me.CmbSaleRetNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSaleRetNo.FormattingEnabled = True
        Me.CmbSaleRetNo.Location = New System.Drawing.Point(119, 17)
        Me.CmbSaleRetNo.Name = "CmbSaleRetNo"
        Me.CmbSaleRetNo.Size = New System.Drawing.Size(130, 24)
        Me.CmbSaleRetNo.TabIndex = 0
        '
        'TxtCusName
        '
        Me.TxtCusName.Location = New System.Drawing.Point(448, 49)
        Me.TxtCusName.Name = "TxtCusName"
        Me.TxtCusName.ReadOnly = True
        Me.TxtCusName.Size = New System.Drawing.Size(130, 23)
        Me.TxtCusName.TabIndex = 4
        '
        'CmbCusId
        '
        Me.CmbCusId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCusId.FormattingEnabled = True
        Me.CmbCusId.Location = New System.Drawing.Point(448, 17)
        Me.CmbCusId.MaxDropDownItems = 10
        Me.CmbCusId.Name = "CmbCusId"
        Me.CmbCusId.Size = New System.Drawing.Size(130, 24)
        Me.CmbCusId.Sorted = True
        Me.CmbCusId.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(345, 54)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(97, 15)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = "Customer Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(367, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Customer ID"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Location = New System.Drawing.Point(257, 17)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(25, 25)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(40, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Return Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sales Invoice No."
        '
        'TxtRetDate
        '
        Me.TxtRetDate.Location = New System.Drawing.Point(119, 48)
        Me.TxtRetDate.Name = "TxtRetDate"
        Me.TxtRetDate.ReadOnly = True
        Me.TxtRetDate.Size = New System.Drawing.Size(130, 23)
        Me.TxtRetDate.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BtNCancel)
        Me.GroupBox3.Controls.Add(Me.BtnUpdate)
        Me.GroupBox3.Controls.Add(Me.BtnIns)
        Me.GroupBox3.Controls.Add(Me.BtnAdd)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(12, 417)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(591, 63)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        'FrmSalesReturn
        '
        Me.AcceptButton = Me.BtnIns
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(617, 491)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgridsaleRet)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmSalesReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Return"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgridsaleRet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnIns As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtNCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DgridsaleRet As System.Windows.Forms.DataGridView
    Friend WithEvents CmbComID As System.Windows.Forms.ComboBox
    Friend WithEvents CmbItemName As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbSaleRetNo As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCusName As System.Windows.Forms.TextBox
    Friend WithEvents CmbCusId As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtRetDate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
