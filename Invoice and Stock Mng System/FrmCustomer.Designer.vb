<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomer))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtCustNo = New System.Windows.Forms.TextBox
        Me.TxtCustName = New System.Windows.Forms.TextBox
        Me.TxtCustAdd = New System.Windows.Forms.TextBox
        Me.TxtCustPhNo = New System.Windows.Forms.TextBox
        Me.DGridCustomer = New System.Windows.Forms.DataGridView
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.GRBCus = New System.Windows.Forms.GroupBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.CompName = New System.Windows.Forms.PictureBox
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGridCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRBCus.SuspendLayout()
        CType(Me.CompName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(34, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Customer Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Customer Phone No"
        '
        'TxtCustNo
        '
        Me.TxtCustNo.Location = New System.Drawing.Point(149, 31)
        Me.TxtCustNo.Name = "TxtCustNo"
        Me.TxtCustNo.Size = New System.Drawing.Size(130, 23)
        Me.TxtCustNo.TabIndex = 0
        '
        'TxtCustName
        '
        Me.TxtCustName.Location = New System.Drawing.Point(149, 70)
        Me.TxtCustName.Name = "TxtCustName"
        Me.TxtCustName.Size = New System.Drawing.Size(130, 23)
        Me.TxtCustName.TabIndex = 2
        '
        'TxtCustAdd
        '
        Me.TxtCustAdd.Location = New System.Drawing.Point(149, 109)
        Me.TxtCustAdd.Multiline = True
        Me.TxtCustAdd.Name = "TxtCustAdd"
        Me.TxtCustAdd.Size = New System.Drawing.Size(220, 99)
        Me.TxtCustAdd.TabIndex = 3
        '
        'TxtCustPhNo
        '
        Me.TxtCustPhNo.Location = New System.Drawing.Point(149, 224)
        Me.TxtCustPhNo.Name = "TxtCustPhNo"
        Me.TxtCustPhNo.Size = New System.Drawing.Size(130, 23)
        Me.TxtCustPhNo.TabIndex = 4
        '
        'DGridCustomer
        '
        Me.DGridCustomer.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGridCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGridCustomer.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGridCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGridCustomer.Location = New System.Drawing.Point(407, 102)
        Me.DGridCustomer.Name = "DGridCustomer"
        Me.DGridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGridCustomer.Size = New System.Drawing.Size(475, 304)
        Me.DGridCustomer.TabIndex = 1
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
        Me.BtnAdd.Location = New System.Drawing.Point(9, 270)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(90, 31)
        Me.BtnAdd.TabIndex = 5
        Me.BtnAdd.Text = "ADD"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'GRBCus
        '
        Me.GRBCus.BackColor = System.Drawing.Color.Transparent
        Me.GRBCus.Controls.Add(Me.BtnSearch)
        Me.GRBCus.Controls.Add(Me.BtnCancel)
        Me.GRBCus.Controls.Add(Me.TxtCustNo)
        Me.GRBCus.Controls.Add(Me.BtnUpdate)
        Me.GRBCus.Controls.Add(Me.TxtCustName)
        Me.GRBCus.Controls.Add(Me.BtnSave)
        Me.GRBCus.Controls.Add(Me.BtnAdd)
        Me.GRBCus.Controls.Add(Me.TxtCustAdd)
        Me.GRBCus.Controls.Add(Me.TxtCustPhNo)
        Me.GRBCus.Controls.Add(Me.Label1)
        Me.GRBCus.Controls.Add(Me.Label2)
        Me.GRBCus.Controls.Add(Me.Label3)
        Me.GRBCus.Controls.Add(Me.Label4)
        Me.GRBCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBCus.ForeColor = System.Drawing.Color.Black
        Me.GRBCus.Location = New System.Drawing.Point(12, 93)
        Me.GRBCus.Name = "GRBCus"
        Me.GRBCus.Size = New System.Drawing.Size(380, 313)
        Me.GRBCus.TabIndex = 0
        Me.GRBCus.TabStop = False
        Me.GRBCus.Text = "Customer Detail"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Location = New System.Drawing.Point(284, 29)
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
        Me.BtnCancel.Location = New System.Drawing.Point(279, 270)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(90, 31)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = False
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
        Me.BtnUpdate.Location = New System.Drawing.Point(189, 270)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(90, 31)
        Me.BtnUpdate.TabIndex = 7
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = False
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
        Me.BtnSave.Location = New System.Drawing.Point(99, 270)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(90, 31)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'CompName
        '
        Me.CompName.BackColor = System.Drawing.Color.Transparent
        Me.CompName.Image = CType(resources.GetObject("CompName.Image"), System.Drawing.Image)
        Me.CompName.Location = New System.Drawing.Point(5, 25)
        Me.CompName.Name = "CompName"
        Me.CompName.Size = New System.Drawing.Size(278, 45)
        Me.CompName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CompName.TabIndex = 29
        Me.CompName.TabStop = False
        '
        'ToolTip
        '
        Me.ToolTip.Active = False
        Me.ToolTip.AutomaticDelay = 400
        Me.ToolTip.BackColor = System.Drawing.Color.Maroon
        Me.ToolTip.ForeColor = System.Drawing.Color.White
        Me.ToolTip.IsBalloon = True
        Me.ToolTip.OwnerDraw = True
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip.ToolTipTitle = "Attention"
        '
        'FrmCustomer
        '
        Me.AcceptButton = Me.BtnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(894, 418)
        Me.Controls.Add(Me.CompName)
        Me.Controls.Add(Me.GRBCus)
        Me.Controls.Add(Me.DGridCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Detail"
        CType(Me.DGridCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRBCus.ResumeLayout(False)
        Me.GRBCus.PerformLayout()
        CType(Me.CompName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCustNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustName As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustAdd As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustPhNo As System.Windows.Forms.TextBox
    Friend WithEvents DGridCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents GRBCus As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents CompName As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
End Class
