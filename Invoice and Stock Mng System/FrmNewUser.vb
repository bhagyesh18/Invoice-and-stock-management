Imports System.Data.SqlClient
Public Class FrmNewUser

    Dim con As New DataConnection
    Dim ds As New DataSet
    Dim cmd As New SqlCommand

    Private Sub FrmNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain
        CmbRole.SelectedIndex = 0
        get_User_Data()
    End Sub

    Private Sub FrmNewUser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ToolTip.Active = False
    End Sub

    Private Sub FrmNewUser_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        ToolTip.Active = False
    End Sub

    Sub get_User_Data()
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("Login")
            DgridUserList.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Function check() As Boolean
        Try
            If TxtUname.Text.Length < 1 Or TxtUname.Text.Length > 30 Then
                ToolTip.Active = True
                ToolTip.Show(" User Name must be length of 1 to 30 ", TxtUname)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" User Name must be length of 1 to 30 ", TxtUname)
                TxtUname.Focus()
                Return True
            End If
            '---------------------
            If TxtPword.Text.Length < 4 Or TxtPword.Text.Length > 30 Then
                ToolTip.Active = True
                ToolTip.Show(" Password must be length of 4 to 30 ", TxtPword)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Password must be length of 4 to 30 ", TxtPword)
                TxtPword.Focus()
                Return True
            End If
            '---------------------
            If TxtPword.Text <> TxtConfPass.Text Then
                ToolTip.Active = True
                ToolTip.Show(" Passwords are not Matched ", TxtConfPass)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Passwords are not Matched ", TxtConfPass)
                TxtConfPass.Focus()
                Return True
            End If
            '---------------------
            If CmbRole.SelectedIndex = 0 Then
                ToolTip.Active = True
                ToolTip.Show(" Please Select any User Role ", CmbRole)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Please Select any User Role ", CmbRole)
                CmbRole.Focus()
                Return True
            End If
            '---------------------
            If TxtFname.Text = "" Then
                ToolTip.Active = True
                ToolTip.Show(" Enter FullName of User ", TxtFname)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Enter FullName of User ", TxtFname)
                TxtFname.Focus()
                Return True
            End If
            '---------------------
            If TxtEmail.Text.Length < 3 Then
                ToolTip.Active = True
                ToolTip.Show(" Enter email of User ", TxtEmail)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Enter email of User ", TxtEmail)
                TxtEmail.Focus()
                Return True
            End If
            '---------------------
            If TxtPno.Text.Length > 8 Or TxtPno.Text.Length < 12 Then
                Dim i As Char
                For Each i In TxtPno.Text
                    If Char.IsDigit(i) = False Then
                        ToolTip.Active = True
                        ToolTip.Show(" Enter Valid Phone Number of User ", TxtPno)
                        ToolTip.Active = False
                        ToolTip.Active = True
                        ToolTip.Show(" Enter Valid Phone Number of User ", TxtPno)
                        TxtPno.Focus()
                        Return True
                        Exit For
                    End If
                Next
            Else
                ToolTip.Active = True
                ToolTip.Show(" Enter Valid Phone Number of User ", TxtPno)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Enter Valid Phone Number of User ", TxtPno)
                TxtPno.Focus()
                Return True
            End If
        Catch ex As Exception
        End Try
    End Function

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsert.Click
        If check() = True Then
            Exit Sub
        Else
            ToolTip.Active = False
        End If

        Dim i As Integer
        Dim str As String
        Try
            con.OpenConnection()
            If CmbRole.SelectedIndex <> 0 Then
                i = MessageBox.Show(" Are You sure to Insert User? ", "New User", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If i = 6 Then
                    str = "insert into Login values('" & TxtUname.Text & "','" & TxtPword.Text & "','" & CmbRole.SelectedItem & "','" & TxtFname.Text & "','" & TxtEmail.Text & "'," & TxtPno.Text & ") "
                    cmd.CommandText = str
                    cmd.Connection = con.sqlcon
                    cmd.ExecuteNonQuery()
                    TxtUname.Text = ""
                    TxtPword.Text = ""
                    TxtConfPass.Text = ""
                    TxtFname.Text = ""
                    TxtEmail.Text = ""
                    TxtPno.Text = ""
                    get_User_Data()

                    MessageBox.Show(" One Row Inserted sucessfully ....", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MsgBox(" Please Select User Role ")
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancle.Click
        Me.Close()
    End Sub

    Private Sub BtnInsert_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnInsert.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile("Btn\ins_down.png")
            BtnInsert.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnInsert_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInsert.MouseHover, BtnInsert.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\ins_over.png")
            BtnInsert.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnInsert_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInsert.MouseLeave, BtnInsert.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\ins_out.png")
            BtnInsert.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnCancle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnCancle.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile("Btn\cancel_down.png")
            BtnCancle.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnCancle_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancle.MouseHover, BtnCancle.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\cancel_over.png")
            BtnCancle.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnCancle_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancle.MouseLeave, BtnCancle.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\cancel_out.png")
            BtnCancle.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub

End Class