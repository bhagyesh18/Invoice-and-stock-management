<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchaseReturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPurchaseReturn))
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
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DgridPurRet = New System.Windows.Forms.DataGridView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmbPurRetNo = New System.Windows.Forms.ComboBox
        Me.TxtSuppName = New System.Windows.Forms.TextBox
        Me.CmbSuppId = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtRetDate = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgridPurRet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtQty
        '
        Me.TxtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQty.Location = New System.Drawing.Point(333, 35)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(130, 23)
        Me.TxtQty.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 16)
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
        Me.Label3.Location = New System.Drawing.Point(168, 16)
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
        Me.Label4.Location = New System.Drawing.Point(330, 16)
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
        Me.CmbComID.Location = New System.Drawing.Point(171, 34)
        Me.CmbComID.Name = "CmbComID"
        Me.CmbComID.Size = New System.Drawing.Size(130, 24)
        Me.CmbComID.TabIndex = 6
        '
        'CmbItemName
        '
        Me.CmbItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbItemName.FormattingEnabled = True
        Me.CmbItemName.Location = New System.Drawing.Point(9, 34)
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
        Me.BtnIns.Location = New System.Drawing.Point(169, 20)
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
        Me.BtnAdd.Location = New System.Drawing.Point(41, 20)
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
        Me.BtnUpdate.Location = New System.Drawing.Point(297, 20)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(130, 31)
        Me.BtnUpdate.TabIndex = 10
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = False
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
        Me.BtnCancel.Location = New System.Drawing.Point(425, 20)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(130, 31)
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = False
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(591, 68)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'DgridPurRet
        '
        Me.DgridPurRet.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgridPurRet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgridPurRet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgridPurRet.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgridPurRet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgridPurRet.Location = New System.Drawing.Point(12, 242)
        Me.DgridPurRet.Name = "DgridPurRet"
        Me.DgridPurRet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridPurRet.Size = New System.Drawing.Size(591, 174)
        Me.DgridPurRet.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CmbPurRetNo)
        Me.GroupBox1.Controls.Add(Me.TxtSuppName)
        Me.GroupBox1.Controls.Add(Me.CmbSuppId)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtRetDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 83)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'CmbPurRetNo
        '
        Me.CmbPurRetNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPurRetNo.FormattingEnabled = True
        Me.CmbPurRetNo.Location = New System.Drawing.Point(119, 17)
        Me.CmbPurRetNo.Name = "CmbPurRetNo"
        Me.CmbPurRetNo.Size = New System.Drawing.Size(130, 24)
        Me.CmbPurRetNo.TabIndex = 0
        '
        'TxtSuppName
        '
        Me.TxtSuppName.Location = New System.Drawing.Point(448, 49)
        Me.TxtSuppName.Name = "TxtSuppName"
        Me.TxtSuppName.ReadOnly = True
        Me.TxtSuppName.Size = New System.Drawing.Size(130, 23)
        Me.TxtSuppName.TabIndex = 4
        '
        'CmbSuppId
        '
        Me.CmbSuppId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSuppId.FormattingEnabled = True
        Me.CmbSuppId.Location = New System.Drawing.Point(448, 17)
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
        Me.Label25.Location = New System.Drawing.Point(352, 54)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(90, 15)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = "Suppliar Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(374, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 15)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Suppliar ID"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
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
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Return Invoice No."
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
        Me.GroupBox3.Controls.Add(Me.BtnCancel)
        Me.GroupBox3.Controls.Add(Me.BtnUpdate)
        Me.GroupBox3.Controls.Add(Me.BtnIns)
        Me.GroupBox3.Controls.Add(Me.BtnAdd)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(12, 416)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(591, 63)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        'FrmPurchaseReturn
        '
        Me.AcceptButton = Me.BtnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(617, 491)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgridPurRet)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmPurchaseReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Return"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgridPurRet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DgridPurRet As System.Windows.Forms.DataGridView
    Friend WithEvents CmbComID As System.Windows.Forms.ComboBox
    Friend WithEvents CmbItemName As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbPurRetNo As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSuppName As System.Windows.Forms.TextBox
    Friend WithEvents CmbSuppId As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtRetDate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
