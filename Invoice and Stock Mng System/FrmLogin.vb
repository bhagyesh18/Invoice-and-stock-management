Imports System.Data.SqlClient

Public Class FrmLogin

    Public Shared uname As String
    Dim con As New DataConnection
    Dim ds As New DataSet

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmMain.Timer1.Stop()
        FrmMain.StatusLblTime.Text = ""
        FrmMain.LblStockItem.Text = ""
        FrmMain.BackgroundImage = Nothing
        FrmMain.bgflag = False

        Me.Opacity = 0.2
        Dim op, opme As Double

        For op = 1.0 To 0.7 Step -0.05
            FrmMain.Opacity = op
            opme += 0.1
            Me.Opacity = opme
            System.Threading.Thread.Sleep(100)
            Application.DoEvents()
        Next

        Me.Opacity = 0.9

        TxtUname.Focus()

        con.OpenConnection()
        ds = con.FillDataTable("Login")
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Dim row As Integer = 0
        Dim flag As Integer = 0

        Try
            If TxtUname.Text <> Nothing And TxtPword.Text <> Nothing Then
                For row = 0 To ds.Tables(0).Rows.Count - 1

                    If TxtUname.Text = ds.Tables(0).Rows(row).Item(0) And _
                    TxtPword.Text = ds.Tables(0).Rows(row).Item(1) Then

                        If "admin" = ds.Tables(0).Rows(row).Item(2) Then
                            '--- Enable admin Access Properties
                            FrmMain.FileMenu.Enabled = True
                            FrmMain.FileMenuUser.Enabled = True
                            FrmMain.FileMenuLogOut.Enabled = True
                            FrmMain.FileMenuUserDetail.Enabled = True
                            FrmMain.TransMenu.Enabled = True
                            FrmMain.LayoutMenu.Enabled = True
                            FrmMain.ToolsMenu.Enabled = True
                            FrmMain.ToolsMenuSendEmail.Enabled = True
                            FrmMain.ReportMenu.Enabled = True
                            FrmMain.ReportMenuUserRpt.Enabled = True
                            FrmMain.ReportMenuCustomUser.Enabled = True
                            FrmMain.HelpMenu.Enabled = True
                        Else
                            '--- Disable admin Access Properties to other
                            FrmMain.FileMenu.Enabled = True
                            FrmMain.FileMenuUser.Enabled = False
                            FrmMain.FileMenuUserDetail.Enabled = False
                            FrmMain.TransMenu.Enabled = True
                            FrmMain.LayoutMenu.Enabled = True
                            FrmMain.ToolsMenu.Enabled = True
                            FrmMain.ToolsMenuSendEmail.Enabled = False
                            FrmMain.ReportMenu.Enabled = True
                            FrmMain.ReportMenuUserRpt.Enabled = False
                            FrmMain.ReportMenuCustomUser.Enabled = False
                            FrmMain.HelpMenu.Enabled = True
                        End If

                        flag = 1
                        Exit For
                    End If
                Next

                If flag = 1 Then
                    FrmMain.Text = "NEW WAY Tech-Solution :: " & TxtUname.Text.ToUpper & " is Logged in"
                    uname = TxtUname.Text

                    Dim cmd As New SqlCommand
                    Dim da = Date.Today
                    Dim ti = Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second
                    Dim str = "insert into login_detail values('" & uname & "','" & da & "','" & ti & "','')"
                    cmd.Connection = con.sqlcon
                    cmd.CommandText = str
                    cmd.ExecuteNonQuery()

                    TxtUname.Text = ""
                    TxtPword.Text = ""
                    TxtUname.Focus()
                    FrmMain.Timer1.Start()
                    Me.Close()
                Else
                    MessageBox.Show("Invalid UserName and Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show(" First Fill Up UserName and PassWord ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.OkOnly, "Stop")
        End Try
    End Sub

    Private Sub BtnCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancle.Click
        End
    End Sub

    Private Sub FrmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If FrmMain.bgflag = False Then
                FrmMain.BackgroundImage = Image.FromFile("image\" & My.Settings.Main_BG)
                FrmMain.bgflag = True
            End If

            FrmMain.Opacity = 1.0

            con.CloseConnection()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnLogin_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnLogin.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile(FrmMain.dir & "\Btn\login_down.png")
            BtnLogin.BackgroundImage = img
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub BtnLogin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLogin.MouseHover, BtnLogin.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile(FrmMain.dir & "\Btn\login_over.png")
            BtnLogin.BackgroundImage = img
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub BtnLogin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLogin.MouseLeave, BtnLogin.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile(FrmMain.dir & "\Btn\login_out.png")
            BtnLogin.BackgroundImage = img
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnCancle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnCancle.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile(FrmMain.dir & "\Btn\cancel_down.png")
            BtnCancle.BackgroundImage = img
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub BtnCancle_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancle.MouseHover, BtnCancle.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile(FrmMain.dir & "\Btn\cancel_over.png")
            BtnCancle.BackgroundImage = img
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub BtnCancle_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancle.MouseLeave, BtnCancle.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile(FrmMain.dir & "\Btn\cancel_out.png")
            BtnCancle.BackgroundImage = img
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class