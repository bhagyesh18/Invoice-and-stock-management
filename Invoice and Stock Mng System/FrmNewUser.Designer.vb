<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewUser))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GpCreateUser = New System.Windows.Forms.GroupBox
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnCancle = New System.Windows.Forms.Button
        Me.TxtConfPass = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtFname = New System.Windows.Forms.TextBox
        Me.TxtEmail = New System.Windows.Forms.TextBox
        Me.TxtPno = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbRole = New System.Windows.Forms.ComboBox
        Me.TxtPword = New System.Windows.Forms.TextBox
        Me.TxtUname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DgridUserList = New System.Windows.Forms.DataGridView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GpCreateUser.SuspendLayout()
        CType(Me.DgridUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GpCreateUser
        '
        Me.GpCreateUser.BackColor = System.Drawing.Color.Transparent
        Me.GpCreateUser.Controls.Add(Me.BtnInsert)
        Me.GpCreateUser.Controls.Add(Me.BtnCancle)
        Me.GpCreateUser.Controls.Add(Me.TxtConfPass)
        Me.GpCreateUser.Controls.Add(Me.Label7)
        Me.GpCreateUser.Controls.Add(Me.Label6)
        Me.GpCreateUser.Controls.Add(Me.Label5)
        Me.GpCreateUser.Controls.Add(Me.Label4)
        Me.GpCreateUser.Controls.Add(Me.TxtFname)
        Me.GpCreateUser.Controls.Add(Me.TxtEmail)
        Me.GpCreateUser.Controls.Add(Me.TxtPno)
        Me.GpCreateUser.Controls.Add(Me.Label3)
        Me.GpCreateUser.Controls.Add(Me.CmbRole)
        Me.GpCreateUser.Controls.Add(Me.TxtPword)
        Me.GpCreateUser.Controls.Add(Me.TxtUname)
        Me.GpCreateUser.Controls.Add(Me.Label2)
        Me.GpCreateUser.Controls.Add(Me.Label1)
        Me.GpCreateUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpCreateUser.ForeColor = System.Drawing.Color.Black
        Me.GpCreateUser.Location = New System.Drawing.Point(12, 84)
        Me.GpCreateUser.Name = "GpCreateUser"
        Me.GpCreateUser.Size = New System.Drawing.Size(237, 330)
        Me.GpCreateUser.TabIndex = 0
        Me.GpCreateUser.TabStop = False
        Me.GpCreateUser.Text = "Create New User"
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
        Me.BtnInsert.Location = New System.Drawing.Point(14, 284)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(100, 31)
        Me.BtnInsert.TabIndex = 7
        Me.BtnInsert.Text = "INSERT"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = False
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
        Me.BtnCancle.Location = New System.Drawing.Point(114, 284)
        Me.BtnCancle.Name = "BtnCancle"
        Me.BtnCancle.Size = New System.Drawing.Size(100, 31)
        Me.BtnCancle.TabIndex = 8
        Me.BtnCancle.Text = "CANCEL"
        Me.BtnCancle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancle.UseVisualStyleBackColor = False
        '
        'TxtConfPass
        '
        Me.TxtConfPass.Location = New System.Drawing.Point(114, 95)
        Me.TxtConfPass.Name = "TxtConfPass"
        Me.TxtConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtConfPass.Size = New System.Drawing.Size(100, 23)
        Me.TxtConfPass.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 15)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Confirm PassWord"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Phone No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 209)
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
        Me.Label4.Location = New System.Drawing.Point(7, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Full Name"
        '
        'TxtFname
        '
        Me.TxtFname.Location = New System.Drawing.Point(114, 166)
        Me.TxtFname.Name = "TxtFname"
        Me.TxtFname.Size = New System.Drawing.Size(100, 23)
        Me.TxtFname.TabIndex = 4
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(114, 204)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(100, 23)
        Me.TxtEmail.TabIndex = 5
        '
        'TxtPno
        '
        Me.TxtPno.Location = New System.Drawing.Point(114, 242)
        Me.TxtPno.Name = "TxtPno"
        Me.TxtPno.Size = New System.Drawing.Size(100, 23)
        Me.TxtPno.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Role"
        '
        'CmbRole
        '
        Me.CmbRole.AllowDrop = True
        Me.CmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRole.Items.AddRange(New Object() {"--- select ---", "admin", "employee"})
        Me.CmbRole.Location = New System.Drawing.Point(114, 129)
        Me.CmbRole.Name = "CmbRole"
        Me.CmbRole.Size = New System.Drawing.Size(100, 24)
        Me.CmbRole.TabIndex = 3
        '
        'TxtPword
        '
        Me.TxtPword.Location = New System.Drawing.Point(114, 62)
        Me.TxtPword.Name = "TxtPword"
        Me.TxtPword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPword.Size = New System.Drawing.Size(100, 23)
        Me.TxtPword.TabIndex = 1
        '
        'TxtUname
        '
        Me.TxtUname.Location = New System.Drawing.Point(114, 29)
        Me.TxtUname.Name = "TxtUname"
        Me.TxtUname.Size = New System.Drawing.Size(100, 23)
        Me.TxtUname.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 67)
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
        Me.Label1.Location = New System.Drawing.Point(6, 34)
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
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgridUserList.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgridUserList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgridUserList.Location = New System.Drawing.Point(255, 93)
        Me.DgridUserList.Name = "DgridUserList"
        Me.DgridUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridUserList.Size = New System.Drawing.Size(667, 321)
        Me.DgridUserList.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(297, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
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
        'FrmNewUser
        '
        Me.AcceptButton = Me.BtnInsert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.BtnCancle
        Me.ClientSize = New System.Drawing.Size(934, 430)
        Me.Controls.Add(Me.DgridUserList)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GpCreateUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New User"
        Me.GpCreateUser.ResumeLayout(False)
        Me.GpCreateUser.PerformLayout()
        CType(Me.DgridUserList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GpCreateUser As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtFname As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtPno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents CmbRole As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPword As System.Windows.Forms.TextBox
    Friend WithEvents TxtUname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgridUserList As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtConfPass As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnCancle As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
End Class
