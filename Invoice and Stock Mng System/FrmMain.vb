Imports System.Data.SqlClient
Imports System.IO

Public Class FrmMain

    Public Shared dir As String = Directory.GetCurrentDirectory()
    Dim flag As Boolean = False
    Public Shared bgflag As Boolean = False

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ListItem.List()
            Timer1.Stop()
            Me.FileMenu.Enabled = False
            Me.TransMenu.Enabled = False
            Me.LayoutMenu.Enabled = False
            Me.ToolsMenu.Enabled = False
            Me.ReportMenu.Enabled = False
            Me.HelpMenu.Enabled = False

            FrmLogin.ShowDialog()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub FrmMain_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        LblStockItem.Width = Me.Width - 200
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim h = Date.Now.Hour
        Dim m = Date.Now.Minute
        Dim s = Date.Now.Second
        Dim am_pm = "AM"

        If h > 12 Then
            h = h - 12
            am_pm = "PM"
        End If
        StatusLblTime.Text = h & " : " & m & " : " & s & "  " & am_pm

        ScrollItem()
    End Sub

    Sub ScrollItem()
        LblStockItem.Text = ListItem.str
        ListItem.str = ListItem.str.Substring(1) + ListItem.str.Substring(0, 1)
    End Sub

    Private Sub FrmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim i As MsgBoxResult = MsgBox(" Are you sure? " & vbCrLf & " You want to Logout & Quit " & vbTab & vbTab & vbTab & vbTab, MsgBoxStyle.YesNo, "Logout & Exit")
        If i = MsgBoxResult.Yes Then
            logout()
        Else
            e.Cancel = True
        End If
    End Sub

    Sub logout()
        Dim con As New DataConnection
        Dim cmd As New SqlCommand
        Try
            Dim str As String
            con.OpenConnection()
            Dim ti = Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second
            str = "update login_detail set logouttime='" & ti & "' where logouttime='';"
            cmd.Connection = con.sqlcon
            cmd.CommandText = str
            cmd.ExecuteNonQuery()

            Dim frm As New Form
            For Each frm In Me.MdiChildren
                frm.Close()
            Next

        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.ApplicationModal)
        End Try
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenuLogOut.Click
        Dim i As MsgBoxResult = MsgBox(" Are you sure? " & vbCrLf & " You want to Logout? " & vbTab & vbTab & vbTab & vbTab, MsgBoxStyle.YesNo, "Logout")
        If i = MsgBoxResult.Yes Then
            logout()
        Else
            Exit Sub
        End If

        Me.FileMenu.Enabled = False
        Me.TransMenu.Enabled = False
        Me.LayoutMenu.Enabled = False
        Me.ToolsMenu.Enabled = False
        Me.ReportMenu.Enabled = False
        Me.HelpMenu.Enabled = False
        Me.Text = "NEW WAY Tech-Solution :: "
        FrmLogin.ShowDialog()
    End Sub

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenuUserInsert.Click
        Try
            FrmNewUser.Show()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub FileMenuUserChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenuUserChange.Click
        Try
            FrmChangeUser.Show()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub FileMenuUserRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenuUserRemove.Click
        Try
            FrmRemoveUser.Show()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Try
            Dim i As MsgBoxResult = MsgBox(" Are you sure? " & vbCrLf & " You want to Logout & Quit " & vbTab & vbTab & vbTab & vbTab, MsgBoxStyle.YesNo, "Logout & Exit")
            If i = MsgBoxResult.Yes Then
                logout()
            Else
                Exit Sub
            End If
            End
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LayoutMenuCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LayoutMenuHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LayoutMenuVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub ArrangIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LayoutMenuArrang.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransMenuPurchase.Click
        FrmPurchase.Show()
    End Sub

    Private Sub FileMenuOpenCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenuOpenCustomer.Click
        FrmCustomer.Show()
    End Sub

    Private Sub FileMenuOpenSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenuOpenSupplier.Click
        FrmSupplier.Show()
    End Sub

    Private Sub FileMenuOpenItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenuOpenItem.Click
        FrmItem.Show()
    End Sub

    Private Sub TransMenuSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransMenuSales.Click
        FrmSales.Show()
    End Sub

    Private Sub FileMenuUserDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenuUserDetail.Click
        FrmUserDetail.Show()
    End Sub

    Private Sub ToolsMenuSendEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsMenuSendEmail.Click
        FrmEmail.Show()
    End Sub

    Private Sub ToolsMenuSetBG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsMenuSetBG.Click
agin:
        Dim str, bgname, path As String
        Dim i As Integer

        Try
            OpenFileDialogBG.Multiselect = False
            OpenFileDialogBG.Filter = "All Image *.jpg;*.jpeg;*.gif;*.bmp;*.png|*.JPG;*.JPEG;*.GIF;*.BMP;*.PNG"
            OpenFileDialogBG.ShowDialog()

            If OpenFileDialogBG.FileName <> "" Then
                Me.BackgroundImage = Image.FromFile(OpenFileDialogBG.FileName)

                str = OpenFileDialogBG.FileName
                i = str.LastIndexOf("\")
                bgname = str.Substring(i + 1)
                My.Settings.Main_BG = bgname
                path = dir & "\image\" & bgname

                If File.Exists(path) = False Then
                    File.Copy(OpenFileDialogBG.FileName, dir & "\image\" & bgname, True)
                End If
            End If
        Catch ex As Exception
            GoTo agin
        End Try
    End Sub

    Private Sub TransMenuPurRet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransMenuPurRet.Click
        FrmPurchaseReturn.Show()
    End Sub

    Private Sub ToolsMenuCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsMenuCalc.Click
        Shell("calc.exe")
    End Sub

    Private Sub ToolsMenuNotepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsMenuNotepad.Click
        Shell("notepad.exe")
    End Sub

    Private Sub TransMenuSaleRet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransMenuSaleRet.Click
        FrmSalesReturn.Show()
    End Sub

    Private Sub FileMenuCloseAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenuCloseAll.Click
        Dim frm As New Form

        For Each frm In Me.MdiChildren
            frm.Close()
        Next
    End Sub

    Private Sub ReportMenuUserRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportMenuUserRpt.Click
        FrmRptUserDetail.Show()
    End Sub

    Private Sub ReportMenuStockRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportMenuStockRpt.Click
        FrmRptStock.Show()
    End Sub

    Private Sub ReportMenuPurRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportMenuPurRpt.Click
        FrmRptPurchaseItem.Show()
    End Sub

    Private Sub ReportMenuPurRetRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportMenuPurRetRpt.Click
        FrmRptPurchaseRet.Show()
    End Sub

    Private Sub ReportMenuSalesRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportMenuSalesRpt.Click
        FrmRptSales.Show()
    End Sub

    Private Sub ReportMenuSaleRetRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportMenuSaleRetRpt.Click
        FrmRptSalesRet.Show()
    End Sub

    Private Sub TexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TexToolStripMenuItem.Click
        FrmTax.Show()
    End Sub

    Private Sub ReportMenuCustomUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportMenuCustomUser.Click
        FrmRptUserDetailPara.show()
    End Sub

    Private Sub ReportMenuCustomPur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportMenuCustomPur.Click
        FrmRptPurchaseItemPara.Show()
    End Sub

    Private Sub ReportMenuCustomPurRet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportMenuCustomPurRet.Click
        FrmRptPurchaseRetPara.Show()
    End Sub

    Private Sub ReportMenuCustomSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportMenuCustomSales.Click
        FrmRptSalesPara.Show()
    End Sub

    Private Sub urnToolStripMenuItemSalesRet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles urnToolStripMenuItemSalesRet.Click
        FrmRptSalesRetPara.Show()
    End Sub

    Private Sub HelpMenuSysHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpMenuSysHelp.Click
        FrmSysHelp.Show()
    End Sub

    Private Sub HelpMenuAboutSys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpMenuAboutSys.Click
        FrmAboutUsHelp.Show()
    End Sub
End Class