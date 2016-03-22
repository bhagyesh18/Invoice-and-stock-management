<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRemoveUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRemoveUser))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label6 = New System.Windows.Forms.Label
        Me.GpChangeUser = New System.Windows.Forms.GroupBox
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnCancle = New System.Windows.Forms.Button
        Me.TxtRole = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtFname = New System.Windows.Forms.TextBox
        Me.TxtEmail = New System.Windows.Forms.TextBox
        Me.TxtPno = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbUserName = New System.Windows.Forms.ComboBox
        Me.TxtPword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DgridUserList = New System.Windows.Forms.DataGridView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GpChangeUser.SuspendLayout()
        CType(Me.DgridUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Phone No."
        '
        'GpChangeUser
        '
        Me.GpChangeUser.BackColor = System.Drawing.Color.Transparent
        Me.GpChangeUser.Controls.Add(Me.BtnDelete)
        Me.GpChangeUser.Controls.Add(Me.BtnCancle)
        Me.GpChangeUser.Controls.Add(Me.Label6)
        Me.GpChangeUser.Controls.Add(Me.TxtRole)
        Me.GpChangeUser.Controls.Add(Me.Label5)
        Me.GpChangeUser.Controls.Add(Me.Label4)
        Me.GpChangeUser.Controls.Add(Me.TxtFname)
        Me.GpChangeUser.Controls.Add(Me.TxtEmail)
        Me.GpChangeUser.Controls.Add(Me.TxtPno)
        Me.GpChangeUser.Controls.Add(Me.Label3)
        Me.GpChangeUser.Controls.Add(Me.CmbUserName)
        Me.GpChangeUser.Controls.Add(Me.TxtPword)
        Me.GpChangeUser.Controls.Add(Me.Label2)
        Me.GpChangeUser.Controls.Add(Me.Label1)
        Me.GpChangeUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpChangeUser.ForeColor = System.Drawing.Color.Black
        Me.GpChangeUser.Location = New System.Drawing.Point(12, 88)
        Me.GpChangeUser.Name = "GpChangeUser"
        Me.GpChangeUser.Size = New System.Drawing.Size(237, 330)
        Me.GpChangeUser.TabIndex = 0
        Me.GpChangeUser.TabStop = False
        Me.GpChangeUser.Text = "Delete User Detail"
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelete.BackgroundImage = CType(resources.GetObject("BtnDelete.BackgroundImage"), System.Drawing.Image)
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(20, 284)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(100, 31)
        Me.BtnDelete.TabIndex = 6
        Me.BtnDelete.Text = "DELETE"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnCancle
        '
        Me.BtnCancle.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancle.BackgroundImage = CType(resources.GetObject("BtnCancle.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancle.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCancle.FlatAppearance.BorderSize = 0
        Me.BtnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancle.ForeColor = System.Drawing.Color.White
        Me.BtnCancle.Location = New System.Drawing.Point(120, 284)
        Me.BtnCancle.Name = "BtnCancle"
        Me.BtnCancle.Size = New System.Drawing.Size(100, 31)
        Me.BtnCancle.TabIndex = 7
        Me.BtnCancle.Text = "CANCEL"
        Me.BtnCancle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancle.UseVisualStyleBackColor = False
        '
        'TxtRole
        '
        Me.TxtRole.Location = New System.Drawing.Point(120, 106)
        Me.TxtRole.Name = "TxtRole"
        Me.TxtRole.Size = New System.Drawing.Size(100, 23)
        Me.TxtRole.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Full Name"
        '
        'TxtFname
        '
        Me.TxtFname.Location = New System.Drawing.Point(120, 147)
        Me.TxtFname.Name = "TxtFname"
        Me.TxtFname.Size = New System.Drawing.Size(100, 23)
        Me.TxtFname.TabIndex = 3
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(120, 189)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(100, 23)
        Me.TxtEmail.TabIndex = 4
        '
        'TxtPno
        '
        Me.TxtPno.Location = New System.Drawing.Point(120, 231)
        Me.TxtPno.Name = "TxtPno"
        Me.TxtPno.Size = New System.Drawing.Size(100, 23)
        Me.TxtPno.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Role"
        '
        'CmbUserName
        '
        Me.CmbUserName.AllowDrop = True
        Me.CmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUserName.Location = New System.Drawing.Point(120, 29)
        Me.CmbUserName.Name = "CmbUserName"
        Me.CmbUserName.Size = New System.Drawing.Size(100, 24)
        Me.CmbUserName.TabIndex = 0
        '
        'TxtPword
        '
        Me.TxtPword.Location = New System.Drawing.Point(120, 66)
        Me.TxtPword.Name = "TxtPword"
        Me.TxtPword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPword.Size = New System.Drawing.Size(100, 23)
        Me.TxtPword.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "PassWord"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "User Name"
        '
        'DgridUserList
        '
        Me.DgridUserList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgridUserList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgridUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgridUserList.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgridUserList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgridUserList.Location = New System.Drawing.Point(255, 97)
        Me.DgridUserList.Name = "DgridUserList"
        Me.DgridUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridUserList.Size = New System.Drawing.Size(666, 321)
        Me.DgridUserList.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'FrmRemoveUser
        '
        Me.AcceptButton = Me.BtnDelete
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.BtnCancle
        Me.ClientSize = New System.Drawing.Size(934, 430)
        Me.Controls.Add(Me.DgridUserList)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GpChangeUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmRemoveUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remove User"
        Me.GpChangeUser.ResumeLayout(False)
        Me.GpChangeUser.PerformLayout()
        CType(Me.DgridUserList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GpChangeUser As System.Windows.Forms.GroupBox
    Friend WithEvents TxtRole As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtFname As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtPno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents CmbUserName As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgridUserList As System.Windows.Forms.DataGridView
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnCancle As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
