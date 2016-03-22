Imports System.Data.SqlClient
Public Class FrmRemoveUser

    Private Sub FrmRemoveUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub CmbUserName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbUserName.SelectedIndexChanged
        Dim con As New DataConnection
        Dim txtds As New DataSet

        Try
            con.OpenConnection()
            txtds.Clear()
            txtds = con.FillDataTable("Login")

            TxtPword.Text = txtds.Tables(0).Rows(CmbUserName.SelectedIndex).Item(1).ToString
            TxtRole.Text = txtds.Tables(0).Rows(CmbUserName.SelectedIndex).Item(2).ToString
            TxtFname.Text = txtds.Tables(0).Rows(CmbUserName.SelectedIndex).Item(3).ToString
            TxtEmail.Text = txtds.Tables(0).Rows(CmbUserName.SelectedIndex).Item(4).ToString 'D:\TYBCA\Invoice and Stock Mng System\Invoice and Stock Mng System\FrmChangeUser.vb
            TxtPno.Text = txtds.Tables(0).Rows(CmbUserName.SelectedIndex).Item(5).ToString
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim cmd As New SqlCommand
        Dim con As New DataConnection
        Dim ds As New DataSet
        Dim i As Integer = CmbUserName.SelectedIndex
        Dim j As Integer

        Try
            con.OpenConnection()
            j = MessageBox.Show(" Are You sure to Delete User? ", "User Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If j = 6 Then
                ds = con.FillDataTable("Login")

                If ds.Tables(0).Rows(i).Item(2) = "admin" Then
                    MsgBox("Administrator can not be Deleted", MsgBoxStyle.OkOnly, "Stop")
                Else
                    cmd.Connection = con.sqlcon
                    cmd.CommandText = "Delete from Login WHERE  (username='" & ds.Tables(0).Rows(i).Item(0) & "');"
                    cmd.ExecuteNonQuery()
                End If

                ds = con.FillDataTable("Login")
                CmbUserName.DataSource = ds.Tables(0)
                CmbUserName.DisplayMember = "username"
                DgridUserList.DataSource = ds.Tables(0)
                MessageBox.Show(" One Row Deleted sucessfully ....", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub ButCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancle.Click
        Me.Close()
    End Sub

    Private Sub BtnDelete_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnDelete.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile("Btn\del_down.png")
            BtnDelete.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnDelete_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete.MouseHover, BtnDelete.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\del_over.png")
            BtnDelete.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnDelete_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete.MouseLeave, BtnDelete.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\del_out.png")
            BtnDelete.BackgroundImage = img
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