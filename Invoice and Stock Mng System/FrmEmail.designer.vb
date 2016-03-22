<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmail))
        Me.TxtSendTo = New System.Windows.Forms.TextBox
        Me.TxtSub = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.RTxtBody = New System.Windows.Forms.RichTextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnSent = New System.Windows.Forms.Button
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtSendTo
        '
        Me.TxtSendTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSendTo.Location = New System.Drawing.Point(66, 89)
        Me.TxtSendTo.Name = "TxtSendTo"
        Me.TxtSendTo.Size = New System.Drawing.Size(362, 23)
        Me.TxtSendTo.TabIndex = 0
        '
        'TxtSub
        '
        Me.TxtSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSub.Location = New System.Drawing.Point(66, 123)
        Me.TxtSub.Name = "TxtSub"
        Me.TxtSub.Size = New System.Drawing.Size(362, 23)
        Me.TxtSub.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Send To "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Subject "
        '
        'RTxtBody
        '
        Me.RTxtBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTxtBody.Location = New System.Drawing.Point(10, 155)
        Me.RTxtBody.Name = "RTxtBody"
        Me.RTxtBody.Size = New System.Drawing.Size(484, 246)
        Me.RTxtBody.TabIndex = 6
        Me.RTxtBody.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BtnSent
        '
        Me.BtnSent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSent.ForeColor = System.Drawing.Color.Black
        Me.BtnSent.Image = CType(resources.GetObject("BtnSent.Image"), System.Drawing.Image)
        Me.BtnSent.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSent.Location = New System.Drawing.Point(434, 87)
        Me.BtnSent.Name = "BtnSent"
        Me.BtnSent.Size = New System.Drawing.Size(60, 60)
        Me.BtnSent.TabIndex = 8
        Me.BtnSent.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Send"
        Me.BtnSent.UseVisualStyleBackColor = True
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
        'FrmEmail
        '
        Me.AcceptButton = Me.BtnSent
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(502, 411)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSent)
        Me.Controls.Add(Me.RTxtBody)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSub)
        Me.Controls.Add(Me.TxtSendTo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Email"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtSendTo As System.Windows.Forms.TextBox
    Friend WithEvents TxtSub As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RTxtBody As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSent As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
End Class
