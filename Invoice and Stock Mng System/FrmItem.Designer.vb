<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItem))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtQty = New System.Windows.Forms.TextBox
        Me.TxtMinQty = New System.Windows.Forms.TextBox
        Me.TxtRate = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblTotalItem = New System.Windows.Forms.Label
        Me.DGridItemList = New System.Windows.Forms.DataGridView
        Me.CmbCompId = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Txtdisc = New System.Windows.Forms.TextBox
        Me.GRBItem = New System.Windows.Forms.GroupBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.TxtItemName = New System.Windows.Forms.TextBox
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.CompName = New System.Windows.Forms.PictureBox
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGridItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRBItem.SuspendLayout()
        CType(Me.CompName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(57, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Company ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(71, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Minimum Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(94, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Rate"
        '
        'TxtQty
        '
        Me.TxtQty.BackColor = System.Drawing.Color.White
        Me.TxtQty.Enabled = False
        Me.TxtQty.Location = New System.Drawing.Point(138, 110)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(141, 23)
        Me.TxtQty.TabIndex = 3
        '
        'TxtMinQty
        '
        Me.TxtMinQty.Location = New System.Drawing.Point(138, 149)
        Me.TxtMinQty.Name = "TxtMinQty"
        Me.TxtMinQty.Size = New System.Drawing.Size(141, 23)
        Me.TxtMinQty.TabIndex = 4
        '
        'TxtRate
        '
        Me.TxtRate.Location = New System.Drawing.Point(138, 227)
        Me.TxtRate.Name = "TxtRate"
        Me.TxtRate.Size = New System.Drawing.Size(141, 23)
        Me.TxtRate.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(35, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Total Records"
        '
        'LblTotalItem
        '
        Me.LblTotalItem.BackColor = System.Drawing.Color.White
        Me.LblTotalItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblTotalItem.Location = New System.Drawing.Point(138, 266)
        Me.LblTotalItem.Name = "LblTotalItem"
        Me.LblTotalItem.Size = New System.Drawing.Size(141, 23)
        Me.LblTotalItem.TabIndex = 7
        Me.LblTotalItem.Text = "0"
        '
        'DGridItemList
        '
        Me.DGridItemList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGridItemList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGridItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGridItemList.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGridItemList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGridItemList.Location = New System.Drawing.Point(402, 95)
        Me.DGridItemList.Name = "DGridItemList"
        Me.DGridItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGridItemList.Size = New System.Drawing.Size(480, 332)
        Me.DGridItemList.TabIndex = 1
        '
        'CmbCompId
        '
        Me.CmbCompId.FormattingEnabled = True
        Me.CmbCompId.Location = New System.Drawing.Point(138, 70)
        Me.CmbCompId.Name = "CmbCompId"
        Me.CmbCompId.Size = New System.Drawing.Size(141, 24)
        Me.CmbCompId.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(53, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Discount %"
        '
        'Txtdisc
        '
        Me.Txtdisc.Location = New System.Drawing.Point(138, 188)
        Me.Txtdisc.Name = "Txtdisc"
        Me.Txtdisc.Size = New System.Drawing.Size(141, 23)
        Me.Txtdisc.TabIndex = 5
        '
        'GRBItem
        '
        Me.GRBItem.BackColor = System.Drawing.Color.Transparent
        Me.GRBItem.Controls.Add(Me.BtnSearch)
        Me.GRBItem.Controls.Add(Me.BtnCancel)
        Me.GRBItem.Controls.Add(Me.TxtItemName)
        Me.GRBItem.Controls.Add(Me.Label6)
        Me.GRBItem.Controls.Add(Me.CmbCompId)
        Me.GRBItem.Controls.Add(Me.LblTotalItem)
        Me.GRBItem.Controls.Add(Me.BtnUpdate)
        Me.GRBItem.Controls.Add(Me.BtnInsert)
        Me.GRBItem.Controls.Add(Me.BtnAdd)
        Me.GRBItem.Controls.Add(Me.Label5)
        Me.GRBItem.Controls.Add(Me.TxtQty)
        Me.GRBItem.Controls.Add(Me.Label7)
        Me.GRBItem.Controls.Add(Me.TxtMinQty)
        Me.GRBItem.Controls.Add(Me.Label4)
        Me.GRBItem.Controls.Add(Me.Txtdisc)
        Me.GRBItem.Controls.Add(Me.Label3)
        Me.GRBItem.Controls.Add(Me.TxtRate)
        Me.GRBItem.Controls.Add(Me.Label2)
        Me.GRBItem.Controls.Add(Me.Label1)
        Me.GRBItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBItem.ForeColor = System.Drawing.Color.Black
        Me.GRBItem.Location = New System.Drawing.Point(12, 86)
        Me.GRBItem.Name = "GRBItem"
        Me.GRBItem.Size = New System.Drawing.Size(380, 341)
        Me.GRBItem.TabIndex = 0
        Me.GRBItem.TabStop = False
        Me.GRBItem.Text = "Supplier Detail"
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
        Me.BtnSearch.Location = New System.Drawing.Point(285, 29)
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
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(279, 301)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(90, 30)
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'TxtItemName
        '
        Me.TxtItemName.Location = New System.Drawing.Point(138, 31)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(141, 23)
        Me.TxtItemName.TabIndex = 0
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
        Me.BtnUpdate.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(189, 301)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(90, 30)
        Me.BtnUpdate.TabIndex = 9
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = False
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
        Me.BtnInsert.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsert.ForeColor = System.Drawing.Color.White
        Me.BtnInsert.Location = New System.Drawing.Point(99, 301)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(90, 30)
        Me.BtnInsert.TabIndex = 10
        Me.BtnInsert.Text = "INSERT"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = False
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
        Me.BtnAdd.Location = New System.Drawing.Point(9, 301)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(90, 30)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "ADD"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'CompName
        '
        Me.CompName.BackColor = System.Drawing.Color.Transparent
        Me.CompName.Image = CType(resources.GetObject("CompName.Image"), System.Drawing.Image)
        Me.CompName.Location = New System.Drawing.Point(5, 25)
        Me.CompName.Name = "CompName"
        Me.CompName.Size = New System.Drawing.Size(197, 45)
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
        'FrmItem
        '
        Me.AcceptButton = Me.BtnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(894, 440)
        Me.Controls.Add(Me.CompName)
        Me.Controls.Add(Me.GRBItem)
        Me.Controls.Add(Me.DGridItemList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Detail"
        CType(Me.DGridItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRBItem.ResumeLayout(False)
        Me.GRBItem.PerformLayout()
        CType(Me.CompName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtQty As System.Windows.Forms.TextBox
    Friend WithEvents TxtMinQty As System.Windows.Forms.TextBox
    Friend WithEvents TxtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblTotalItem As System.Windows.Forms.Label
    Friend WithEvents DGridItemList As System.Windows.Forms.DataGridView
    Friend WithEvents CmbCompId As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txtdisc As System.Windows.Forms.TextBox
    Friend WithEvents GRBItem As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents TxtItemName As System.Windows.Forms.TextBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents CompName As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
End Class
