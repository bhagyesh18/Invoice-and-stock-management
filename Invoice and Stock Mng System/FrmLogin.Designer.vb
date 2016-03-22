<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.BtnCancle = New System.Windows.Forms.Button
        Me.CompName = New System.Windows.Forms.PictureBox
        Me.TxtPword = New System.Windows.Forms.TextBox
        Me.TxtUname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnLogin = New System.Windows.Forms.Button
        CType(Me.CompName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancle
        '
        Me.BtnCancle.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancle.BackgroundImage = CType(resources.GetObject("BtnCancle.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancle.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCancle.FlatAppearance.BorderSize = 0
        Me.BtnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancle.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancle.ForeColor = System.Drawing.Color.White
        Me.BtnCancle.Location = New System.Drawing.Point(359, 247)
        Me.BtnCancle.Name = "BtnCancle"
        Me.BtnCancle.Size = New System.Drawing.Size(128, 31)
        Me.BtnCancle.TabIndex = 3
        Me.BtnCancle.Text = "CANCEL  "
        Me.BtnCancle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancle.UseVisualStyleBackColor = False
        '
        'CompName
        '
        Me.CompName.BackColor = System.Drawing.Color.Transparent
        Me.CompName.Image = CType(resources.GetObject("CompName.Image"), System.Drawing.Image)
        Me.CompName.Location = New System.Drawing.Point(5, 25)
        Me.CompName.Name = "CompName"
        Me.CompName.Size = New System.Drawing.Size(432, 45)
        Me.CompName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CompName.TabIndex = 11
        Me.CompName.TabStop = False
        '
        'TxtPword
        '
        Me.TxtPword.BackColor = System.Drawing.Color.Silver
        Me.TxtPword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtPword.Location = New System.Drawing.Point(287, 163)
        Me.TxtPword.Name = "TxtPword"
        Me.TxtPword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TxtPword.Size = New System.Drawing.Size(200, 30)
        Me.TxtPword.TabIndex = 1
        '
        'TxtUname
        '
        Me.TxtUname.BackColor = System.Drawing.Color.Silver
        Me.TxtUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtUname.Location = New System.Drawing.Point(287, 109)
        Me.TxtUname.Name = "TxtUname"
        Me.TxtUname.Size = New System.Drawing.Size(200, 30)
        Me.TxtUname.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(169, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(169, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User Name"
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.BackgroundImage = CType(resources.GetObject("BtnLogin.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Location = New System.Drawing.Point(231, 247)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(128, 31)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "LOGIN   "
        Me.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.BtnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.BtnCancle
        Me.ClientSize = New System.Drawing.Size(521, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.BtnCancle)
        Me.Controls.Add(Me.CompName)
        Me.Controls.Add(Me.TxtPword)
        Me.Controls.Add(Me.TxtUname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.CompName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancle As System.Windows.Forms.Button
    Friend WithEvents CompName As System.Windows.Forms.PictureBox
    Friend WithEvents TxtPword As System.Windows.Forms.TextBox
    Friend WithEvents TxtUname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
End Class
