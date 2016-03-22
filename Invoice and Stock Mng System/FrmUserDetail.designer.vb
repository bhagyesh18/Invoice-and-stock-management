<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserDetail))
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbusername = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgridlogindetail = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnDelAll = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgridlogindetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, -80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Search By User Name"
        '
        'cmbusername
        '
        Me.cmbusername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbusername.FormattingEnabled = True
        Me.cmbusername.Location = New System.Drawing.Point(84, 87)
        Me.cmbusername.Name = "cmbusername"
        Me.cmbusername.Size = New System.Drawing.Size(100, 24)
        Me.cmbusername.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dgridlogindetail)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 284)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login Details"
        '
        'dgridlogindetail
        '
        Me.dgridlogindetail.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgridlogindetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgridlogindetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgridlogindetail.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgridlogindetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgridlogindetail.Location = New System.Drawing.Point(8, 20)
        Me.dgridlogindetail.Name = "dgridlogindetail"
        Me.dgridlogindetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgridlogindetail.Size = New System.Drawing.Size(486, 257)
        Me.dgridlogindetail.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Search :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelete.BackgroundImage = CType(resources.GetObject("BtnDelete.BackgroundImage"), System.Drawing.Image)
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(322, 86)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(95, 24)
        Me.BtnDelete.TabIndex = 17
        Me.BtnDelete.Text = "DELETE  "
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnDelAll
        '
        Me.BtnDelAll.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelAll.BackgroundImage = CType(resources.GetObject("BtnDelAll.BackgroundImage"), System.Drawing.Image)
        Me.BtnDelAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnDelAll.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnDelAll.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnDelAll.FlatAppearance.BorderSize = 0
        Me.BtnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelAll.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelAll.ForeColor = System.Drawing.Color.White
        Me.BtnDelAll.Location = New System.Drawing.Point(417, 86)
        Me.BtnDelAll.Name = "BtnDelAll"
        Me.BtnDelAll.Size = New System.Drawing.Size(95, 24)
        Me.BtnDelAll.TabIndex = 18
        Me.BtnDelAll.Text = "DELETE ALL"
        Me.BtnDelAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelAll.UseVisualStyleBackColor = False
        '
        'FrmUserDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(524, 413)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnDelAll)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbusername)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmUserDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUserDetail"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgridlogindetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbusername As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgridlogindetail As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnDelAll As System.Windows.Forms.Button
End Class
