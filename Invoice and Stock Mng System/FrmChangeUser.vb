Imports System.Data.SqlClient

Public Class FrmChangeUser

    Private Sub FrmChangeUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New DataConnection
        Dim ds As New DataSet

        Try
            Me.MdiParent = FrmMain

            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("Login")
            CmbUserName.DataSource = ds.Tables(0)
            CmbUserName.DisplayMember = "username"
            DgridUserList.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub FrmChangeUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click, CmbRole.Click, CmbUserName.Click, DgridUserList.Click, Label1.Click, Label2.Click, Label3.Click
        Me.Focus()
    End Sub

    Private Sub FrmChangeUser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ToolTip.Active = False
    End Sub

    Private Sub FrmChangeUser_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        ToolTip.Active = False
    End Sub

    Private Sub CmbUserName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbUserName.SelectedIndexChanged
        Dim con As New DataConnection
        Dim txtds As New DataSet

        Try
            con.OpenConnection()
            txtds.Clear()
            txtds = con.FillDataTable("Login")

            TxtPword.Text = txtds.Tables(0).Rows(CmbUserName.SelectedIndex).Item(1).ToString
            TxtConfPass.Text = TxtPword.Text
            CmbRole.Text = txtds.Tables(0).Rows(CmbUserName.SelectedIndex).Item(2).ToString
            TxtFname.Text = txtds.Tables(0).Rows(CmbUserName.SelectedIndex).Item(3).ToString
            TxtEmail.Text = txtds.Tables(0).Rows(CmbUserName.SelectedIndex).Item(4).ToString
            TxtPno.Text = txtds.Tables(0).Rows(CmbUserName.SelectedIndex).Item(5).ToString
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If check() = True Then
            Exit Sub
        Else
            ToolTip.Active = False
        End If

        Dim cmd As New SqlCommand
        Dim con As New DataConnection
        Dim ds As New DataSet
        Dim i As Integer

        Try
            con.OpenConnection()
            i = MessageBox.Show(" Are You sure to Update User ? ", "User Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If i = 6 Then
                ds = con.FillDataTable("Login")
                cmd.Connection = con.sqlcon
                cmd.CommandText = "UPDATE Login SET password='" & TxtPword.Text & "',role='" & CmbRole.SelectedItem.ToString & "',fullname='" & TxtFname.Text & "',email='" & TxtEmail.Text & " ',phone='" & TxtPno.Text & "' WHERE  (username='" & ds.Tables(0).Rows(CmbUserName.SelectedIndex).Item(0) & "');"
                cmd.ExecuteNonQuery()
                ds = con.FillDataTable("Login")
                DgridUserList.DataSource = ds.Tables(0)

                MessageBox.Show(" One Row Updated sucessfully ....", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Function check() As Boolean
        Try
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

    Private Sub ButCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancle.Click
        Me.Close()
    End Sub

    Private Sub BtnUpdate_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnUpdate.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile("Btn\update_down.png")
            BtnUpdate.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnUpdate_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUpdate.MouseHover, BtnUpdate.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\update_over.png")
            BtnUpdate.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnUpdate_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUpdate.MouseLeave, BtnUpdate.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\update_out.png")
            BtnUpdate.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnUpdate_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnUpdate.MouseUp
        Try
            Dim img As Image
            img = Image.FromFile("Btn\update_out.png")
            BtnUpdate.BackgroundImage = img
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
    Private Sub BtnCancle_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnCancle.MouseUp
        Try
            Dim img As Image
            img = Image.FromFile("Btn\cancel_out.png")
            BtnCancle.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub

End Class