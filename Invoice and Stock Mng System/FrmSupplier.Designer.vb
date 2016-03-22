<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplier
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSupplier))
        Me.DGridSupplier = New System.Windows.Forms.DataGridView
        Me.GRBSupp = New System.Windows.Forms.GroupBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.TxtSuppNo = New System.Windows.Forms.TextBox
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.TxtSuppName = New System.Windows.Forms.TextBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.TxtSuppAdd = New System.Windows.Forms.TextBox
        Me.TxtSuppPhNo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CompName = New System.Windows.Forms.PictureBox
        CType(Me.DGridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRBSupp.SuspendLayout()
        CType(Me.CompName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGridSupplier
        '
        Me.DGridSupplier.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGridSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGridSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGridSupplier.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGridSupplier.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGridSupplier.Location = New System.Drawing.Point(407, 102)
        Me.DGridSupplier.Name = "DGridSupplier"
        Me.DGridSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGridSupplier.Size = New System.Drawing.Size(475, 304)
        Me.DGridSupplier.TabIndex = 1
        '
        'GRBSupp
        '
        Me.GRBSupp.BackColor = System.Drawing.Color.Transparent
        Me.GRBSupp.Controls.Add(Me.BtnSearch)
        Me.GRBSupp.Controls.Add(Me.BtnCancel)
        Me.GRBSupp.Controls.Add(Me.TxtSuppNo)
        Me.GRBSupp.Controls.Add(Me.BtnUpdate)
        Me.GRBSupp.Controls.Add(Me.TxtSuppName)
        Me.GRBSupp.Controls.Add(Me.BtnSave)
        Me.GRBSupp.Controls.Add(Me.BtnAdd)
        Me.GRBSupp.Controls.Add(Me.TxtSuppAdd)
        Me.GRBSupp.Controls.Add(Me.TxtSuppPhNo)
        Me.GRBSupp.Controls.Add(Me.Label5)
        Me.GRBSupp.Controls.Add(Me.Label6)
        Me.GRBSupp.Controls.Add(Me.Label7)
        Me.GRBSupp.Controls.Add(Me.Label8)
        Me.GRBSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBSupp.ForeColor = System.Drawing.Color.Black
        Me.GRBSupp.Location = New System.Drawing.Point(12, 93)
        Me.GRBSupp.Name = "GRBSupp"
        Me.GRBSupp.Size = New System.Drawing.Size(380, 313)
        Me.GRBSupp.TabIndex = 0
        Me.GRBSupp.TabStop = False
        Me.GRBSupp.Text = "Supplier Detail"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Location = New System.Drawing.Point(281, 29)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(85, 25)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.Text = "SEARCH"
        Me.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(276, 271)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(90, 31)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'TxtSuppNo
        '
        Me.TxtSuppNo.Location = New System.Drawing.Point(149, 31)
        Me.TxtSuppNo.Name = "TxtSuppNo"
        Me.TxtSuppNo.Size = New System.Drawing.Size(126, 23)
        Me.TxtSuppNo.TabIndex = 0
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.BtnUpdate.BackgroundImage = CType(resources.GetObject("BtnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(187, 271)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(90, 31)
        Me.BtnUpdate.TabIndex = 7
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'TxtSuppName
        '
        Me.TxtSuppName.Location = New System.Drawing.Point(149, 70)
        Me.TxtSuppName.Name = "TxtSuppName"
        Me.TxtSuppName.Size = New System.Drawing.Size(126, 23)
        Me.TxtSuppName.TabIndex = 2
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(98, 271)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(90, 31)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdd.BackgroundImage = CType(resources.GetObject("BtnAdd.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(9, 271)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(90, 31)
        Me.BtnAdd.TabIndex = 5
        Me.BtnAdd.Text = "ADD"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'TxtSuppAdd
        '
        Me.TxtSuppAdd.Location = New System.Drawing.Point(149, 109)
        Me.TxtSuppAdd.Multiline = True
        Me.TxtSuppAdd.Name = "TxtSuppAdd"
        Me.TxtSuppAdd.Size = New System.Drawing.Size(217, 99)
        Me.TxtSuppAdd.TabIndex = 3
        '
        'TxtSuppPhNo
        '
        Me.TxtSuppPhNo.Location = New System.Drawing.Point(149, 224)
        Me.TxtSuppPhNo.Name = "TxtSuppPhNo"
        Me.TxtSuppPhNo.Size = New System.Drawing.Size(126, 23)
        Me.TxtSuppPhNo.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(58, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Supplier ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(34, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Supplier Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(19, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Supplier Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(8, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Supplier Phone No"
        '
        'CompName
        '
        Me.CompName.BackColor = System.Drawing.Color.Transparent
        Me.CompName.Image = CType(resources.GetObject("CompName.Image"), System.Drawing.Image)
        Me.CompName.Location = New System.Drawing.Point(12, 19)
        Me.CompName.Name = "CompName"
        Me.CompName.Size = New System.Drawing.Size(255, 45)
        Me.CompName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CompName.TabIndex = 28
        Me.CompName.TabStop = False
        '
        'FrmSupplier
        '
        Me.AcceptButton = Me.BtnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(894, 418)
        Me.Controls.Add(Me.CompName)
        Me.Controls.Add(Me.GRBSupp)
        Me.Controls.Add(Me.DGridSupplier)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Detail"
        CType(Me.DGridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRBSupp.ResumeLayout(False)
        Me.GRBSupp.PerformLayout()
        CType(Me.CompName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGridSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents GRBSupp As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents TxtSuppNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents TxtSuppName As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtSuppAdd As System.Windows.Forms.TextBox
    Friend WithEvents TxtSuppPhNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CompName As System.Windows.Forms.PictureBox
End Class
