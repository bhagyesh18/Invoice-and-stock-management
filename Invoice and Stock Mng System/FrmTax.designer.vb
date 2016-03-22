<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTax
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTax))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtTaxRate = New System.Windows.Forms.TextBox
        Me.DGridTax = New System.Windows.Forms.DataGridView
        Me.CmbTaxId = New System.Windows.Forms.ComboBox
        Me.BtnCancle = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DGridTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(68, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tax Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(54, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tax Rate"
        '
        'TxtTaxRate
        '
        Me.TxtTaxRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTaxRate.Location = New System.Drawing.Point(111, 124)
        Me.TxtTaxRate.Name = "TxtTaxRate"
        Me.TxtTaxRate.Size = New System.Drawing.Size(130, 23)
        Me.TxtTaxRate.TabIndex = 3
        '
        'DGridTax
        '
        Me.DGridTax.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGridTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGridTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGridTax.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGridTax.Location = New System.Drawing.Point(12, 200)
        Me.DGridTax.Name = "DGridTax"
        Me.DGridTax.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGridTax.Size = New System.Drawing.Size(297, 161)
        Me.DGridTax.TabIndex = 6
        '
        'CmbTaxId
        '
        Me.CmbTaxId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTaxId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTaxId.FormattingEnabled = True
        Me.CmbTaxId.Location = New System.Drawing.Point(111, 90)
        Me.CmbTaxId.Name = "CmbTaxId"
        Me.CmbTaxId.Size = New System.Drawing.Size(130, 24)
        Me.CmbTaxId.TabIndex = 7
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
        Me.BtnCancle.Location = New System.Drawing.Point(152, 157)
        Me.BtnCancle.Name = "BtnCancle"
        Me.BtnCancle.Size = New System.Drawing.Size(100, 31)
        Me.BtnCancle.TabIndex = 32
        Me.BtnCancle.Text = "CANCEL"
        Me.BtnCancle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancle.UseVisualStyleBackColor = False
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
        Me.BtnUpdate.Location = New System.Drawing.Point(52, 157)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(100, 31)
        Me.BtnUpdate.TabIndex = 31
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'FrmTax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(323, 375)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCancle)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.CmbTaxId)
        Me.Controls.Add(Me.DGridTax)
        Me.Controls.Add(Me.TxtTaxRate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FrmTax"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tax"
        CType(Me.DGridTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTaxRate As System.Windows.Forms.TextBox
    Friend WithEvents DGridTax As System.Windows.Forms.DataGridView
    Friend WithEvents CmbTaxId As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCancle As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
