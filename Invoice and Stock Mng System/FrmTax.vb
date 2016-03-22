Imports System.Data.SqlClient

Public Class FrmTax

    Private Sub FrmTax_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain
        Login()
    End Sub
    Sub Login()
        Dim con As New DataConnection
        Dim dstax As New DataSet
        Try
            con.OpenConnection()
            dstax.Clear()
            dstax = con.FillDataTable("tax")
            CmbTaxId.DataSource = dstax.Tables(0)
            CmbTaxId.DisplayMember = "tax_id"
            TxtTaxRate.Text = dstax.Tables(0).Rows(CmbTaxId.SelectedIndex).Item(1).ToString
            DGridTax.DataSource = dstax.Tables(0)
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancle.Click
        Me.Close()
    End Sub

    Private Sub CmbTaxId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTaxId.SelectedIndexChanged
        Dim con As New DataConnection
        Dim dstax As New DataSet
        Try
            con.OpenConnection()
            dstax.Clear()
            dstax = con.FillDataTable("tax")
            TxtTaxRate.Text = dstax.Tables(0).Rows(CmbTaxId.SelectedIndex).Item(1).ToString
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim con As New DataConnection
        Dim cmd As New SqlCommand

        If TxtTaxRate.Text = "" Then
            MsgBox("First Enter Tax Rate", MsgBoxStyle.Information, "Require")
        Else
            Try
                con.OpenConnection()
                Dim str As String = "update tax set tax_rate=" & TxtTaxRate.Text & " where tax_id='" & CmbTaxId.Text & "';"
                cmd.Connection = con.sqlcon
                cmd.CommandText = str
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                con.CloseConnection()
            End Try
        End If
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