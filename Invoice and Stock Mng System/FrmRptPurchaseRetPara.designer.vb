<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptPurchaseRetPara
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRptPurchaseRetPara))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.TxtstDate = New System.Windows.Forms.TextBox
        Me.TxtEndDate = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Cal = New System.Windows.Forms.MonthCalendar
        Me.BtnShow1 = New System.Windows.Forms.Button
        Me.BtnShow2 = New System.Windows.Forms.Button
        Me.BtnCreate = New System.Windows.Forms.Button
        Me.PurchaseReturn1 = New Invoice_and_Stock_Mng_System.PurchaseReturn
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 52)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.PurchaseReturn1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(932, 414)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'TxtstDate
        '
        Me.TxtstDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtstDate.Location = New System.Drawing.Point(141, 12)
        Me.TxtstDate.Name = "TxtstDate"
        Me.TxtstDate.Size = New System.Drawing.Size(100, 26)
        Me.TxtstDate.TabIndex = 1
        '
        'TxtEndDate
        '
        Me.TxtEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEndDate.Location = New System.Drawing.Point(319, 12)
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.Size = New System.Drawing.Size(100, 26)
        Me.TxtEndDate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Date Between"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(284, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To"
        '
        'Cal
        '
        Me.Cal.BackColor = System.Drawing.Color.Thistle
        Me.Cal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cal.Location = New System.Drawing.Point(673, 10)
        Me.Cal.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Cal.Name = "Cal"
        Me.Cal.TabIndex = 4
        Me.Cal.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cal.TitleForeColor = System.Drawing.Color.White
        Me.Cal.TrailingForeColor = System.Drawing.Color.DarkGray
        '
        'BtnShow1
        '
        Me.BtnShow1.BackColor = System.Drawing.Color.Transparent
        Me.BtnShow1.BackgroundImage = CType(resources.GetObject("BtnShow1.BackgroundImage"), System.Drawing.Image)
        Me.BtnShow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnShow1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnShow1.FlatAppearance.BorderSize = 0
        Me.BtnShow1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnShow1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnShow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShow1.Location = New System.Drawing.Point(247, 12)
        Me.BtnShow1.Name = "BtnShow1"
        Me.BtnShow1.Size = New System.Drawing.Size(25, 25)
        Me.BtnShow1.TabIndex = 5
        Me.BtnShow1.Text = "..."
        Me.BtnShow1.UseVisualStyleBackColor = False
        '
        'BtnShow2
        '
        Me.BtnShow2.BackColor = System.Drawing.Color.Transparent
        Me.BtnShow2.BackgroundImage = CType(resources.GetObject("BtnShow2.BackgroundImage"), System.Drawing.Image)
        Me.BtnShow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnShow2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnShow2.FlatAppearance.BorderSize = 0
        Me.BtnShow2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnShow2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnShow2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShow2.Location = New System.Drawing.Point(425, 12)
        Me.BtnShow2.Name = "BtnShow2"
        Me.BtnShow2.Size = New System.Drawing.Size(25, 25)
        Me.BtnShow2.TabIndex = 6
        Me.BtnShow2.Text = "..."
        Me.BtnShow2.UseVisualStyleBackColor = False
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.Transparent
        Me.BtnCreate.BackgroundImage = CType(resources.GetObject("BtnCreate.BackgroundImage"), System.Drawing.Image)
        Me.BtnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCreate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCreate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.ForeColor = System.Drawing.Color.White
        Me.BtnCreate.Location = New System.Drawing.Point(504, 10)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(130, 31)
        Me.BtnCreate.TabIndex = 17
        Me.BtnCreate.Tag = ""
        Me.BtnCreate.Text = "Create Report"
        Me.BtnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'FrmRptPurchaseRetPara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(932, 466)
        Me.Controls.Add(Me.Cal)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.BtnShow2)
        Me.Controls.Add(Me.BtnShow1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtEndDate)
        Me.Controls.Add(Me.TxtstDate)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FrmRptPurchaseRetPara"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parameterised Purchase Return Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TxtstDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cal As System.Windows.Forms.MonthCalendar
    Friend WithEvents BtnShow1 As System.Windows.Forms.Button
    Friend WithEvents BtnShow2 As System.Windows.Forms.Button
    Friend WithEvents BtnCreate As System.Windows.Forms.Button
    Friend WithEvents PurchaseReturn1 As Invoice_and_Stock_Mng_System.PurchaseReturn
End Class
