<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSysHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSysHelp))
        Me.RTBHelp = New System.Windows.Forms.RichTextBox
        Me.LBHelp = New System.Windows.Forms.ListBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RTBHelp
        '
        Me.RTBHelp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RTBHelp.Location = New System.Drawing.Point(177, 91)
        Me.RTBHelp.Name = "RTBHelp"
        Me.RTBHelp.ReadOnly = True
        Me.RTBHelp.Size = New System.Drawing.Size(565, 414)
        Me.RTBHelp.TabIndex = 1
        Me.RTBHelp.TabStop = False
        Me.RTBHelp.Text = ""
        '
        'LBHelp
        '
        Me.LBHelp.BackColor = System.Drawing.Color.Gray
        Me.LBHelp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBHelp.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBHelp.ForeColor = System.Drawing.Color.White
        Me.LBHelp.FormattingEnabled = True
        Me.LBHelp.ItemHeight = 18
        Me.LBHelp.Items.AddRange(New Object() {"USER", "LOGIN DETAIL", "ITEM STOCK", "CUSTOMER DETAIL", "SUPPLIER DETAIL", "TAX", "PURCHASE", "PURCHASE RETURN", "SALES", "SALES RETURN", "CUSTOM REPORT", "EMAIL SENDING"})
        Me.LBHelp.Location = New System.Drawing.Point(12, 91)
        Me.LBHelp.Name = "LBHelp"
        Me.LBHelp.Size = New System.Drawing.Size(159, 414)
        Me.LBHelp.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(358, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'FrmSysHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(754, 517)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LBHelp)
        Me.Controls.Add(Me.RTBHelp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmSysHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Help"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RTBHelp As System.Windows.Forms.RichTextBox
    Friend WithEvents LBHelp As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
