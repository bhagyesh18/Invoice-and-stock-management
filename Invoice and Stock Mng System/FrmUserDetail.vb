Imports System.Data.SqlClient

Public Class FrmUserDetail

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain
        Login()
    End Sub

    Sub Login()
        Dim con As New DataConnection
        Dim dsitem As New DataSet
        Try
            con.OpenConnection()
            dsitem.Clear()
            dsitem = con.FillDataTable("login")
            cmbusername.DataSource = dsitem.Tables(0)
            cmbusername.DisplayMember = "username"
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub txtusername_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusername.SelectedIndexChanged
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            Dim str = "select * from login_detail where username='" & cmbusername.Text & "';"
            ds.Clear()
            ds = con.FillDataTableCustom(str)
            dgridlogindetail.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim con As New DataConnection
        Dim cmd As New SqlCommand
        Try
            con.OpenConnection()

            Dim i As Integer = dgridlogindetail.CurrentCell.RowIndex
            Dim d As String = dgridlogindetail.Item(1, i).Value.ToString
            Dim t1 As String = dgridlogindetail.Item(2, i).Value.ToString
            Dim t2 As String = dgridlogindetail.Item(3, i).Value.ToString

            Dim str = "delete from login_detail where username='" & cmbusername.Text & "' and logindate='" & d & "' and logintime='" & t1 & "' and logouttime='" & t2 & "';"
            cmd.CommandText = str
            cmd.Connection = con.sqlcon
            cmd.ExecuteNonQuery()

            txtusername_SelectedIndexChanged(sender, e)
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelAll.Click
        Dim con As New DataConnection
        Dim cmd As New SqlCommand
        Try
            con.OpenConnection()
            Dim str = "delete from login_detail where username='" & cmbusername.Text & "';"
            cmd.CommandText = str
            cmd.Connection = con.sqlcon
            cmd.ExecuteNonQuery()

            txtusername_SelectedIndexChanged(sender, e)
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
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

    Private Sub BtnDelAll_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnDelAll.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile("Btn\cancel_down.png")
            BtnDelAll.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnDelAll_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelAll.MouseHover, BtnDelAll.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\cancel_over.png")
            BtnDelAll.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnDelAll_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelAll.MouseLeave, BtnDelAll.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\cancel_out.png")
            BtnDelAll.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub

End Class
