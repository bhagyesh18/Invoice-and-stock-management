Imports System.Data.SqlClient
Public Class FrmSupplier

    Private Sub FrmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain
        FillSupplierDetail()
        BtnSave.Enabled = False
    End Sub
    Sub clear_all()
        TxtSuppNo.Text = ""
        TxtSuppName.Text = ""
        TxtSuppAdd.Text = ""
        TxtSuppPhNo.Text = ""
    End Sub
    Sub FillSupplierDetail()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("Supplier_master")
            DGridSupplier.DataSource = ds.Tables(0)
            TxtSuppNo.Text = ds.Tables(0).Rows(0).Item(0).ToString
            TxtSuppName.Text = ds.Tables(0).Rows(0).Item(1).ToString
            TxtSuppAdd.Text = ds.Tables(0).Rows(0).Item(2).ToString
            TxtSuppPhNo.Text = ds.Tables(0).Rows(0).Item(3).ToString
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        clear_all()
        BtnSave.Enabled = True
        BtnUpdate.Enabled = False
        TxtSuppNo.Enabled = False
        TxtSuppName.Focus()

        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("supplier_master")

            TxtSuppNo.Text = ds.Tables(0).Rows.Count + 101
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim con As New DataConnection
        Dim str As String
        Dim cmd As New SqlCommand
        If TxtSuppName.Text = "" Or TxtSuppAdd.Text = "" Or TxtSuppPhNo.Text = "" Then
            MsgBox(" Fill up the whole supplier information")
            TxtSuppName.Focus()
        Else
            Try
                con.OpenConnection()
                str = "insert into supplier_master values('" & TxtSuppNo.Text & "','" & TxtSuppName.Text & "','" & TxtSuppAdd.Text & "'," & TxtSuppPhNo.Text & ");"
                cmd.Connection = con.sqlcon
                cmd.CommandText = str
                cmd.ExecuteNonQuery()
                FillSupplierDetail()
            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                con.CloseConnection()
            End Try

            BtnSave.Enabled = False
            BtnUpdate.Enabled = True
            TxtSuppNo.Enabled = True
            TxtSuppNo.Focus()
        End If
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim con As New DataConnection
        Dim str As String
        Dim cmd As New SqlCommand
        If TxtSuppName.Text = "" Or TxtSuppAdd.Text = "" Or TxtSuppPhNo.Text = "" Then
            MsgBox(" Fill up the whole supplier information")
            TxtSuppName.Focus()
        Else
            Try
                con.OpenConnection()
                str = "update supplier_master set supp_name='" & TxtSuppName.Text & "',supp_add='" & TxtSuppAdd.Text & "',supp_phone=" & TxtSuppPhNo.Text & " where supp_id='" & TxtSuppNo.Text & "';"
                cmd.Connection = con.sqlcon
                cmd.CommandText = str
                cmd.ExecuteNonQuery()
                FillSupplierDetail()
            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                con.CloseConnection()
            End Try
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Dim con As New DataConnection
        Dim ds As New DataSet

        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("supplier_master where supp_id=" & TxtSuppNo.Text)

            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox(" Supplier " & TxtSuppNo.Text & " Not Found ", MsgBoxStyle.OkOnly, "Not Found")
                TxtSuppNo.Focus()
            Else
                TxtSuppNo.Text = ds.Tables(0).Rows(0).Item(0).ToString
                TxtSuppName.Text = ds.Tables(0).Rows(0).Item(1).ToString
                TxtSuppAdd.Text = ds.Tables(0).Rows(0).Item(2).ToString
                TxtSuppPhNo.Text = ds.Tables(0).Rows(0).Item(3).ToString
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub TxtSuppName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSuppName.Leave
        Dim str = TxtSuppName.Text
        Dim i As Char

        If str = "" Then
            'MsgBox("Fill the Supplier Name First", MsgBoxStyle.OkOnly, "Fill Detail")
            TxtSuppName.Focus()
        Else
            For Each i In str
                If Char.IsLetter(i) = True Or i = " " Then
                Else
                    MsgBox("Insert only Character [A-Z] [a-z] ", MsgBoxStyle.OkOnly, "Stop")
                    TxtSuppName.Text = ""
                    TxtSuppName.Focus()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub TxtSuppPhNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSuppPhNo.Leave
        Dim str = TxtSuppPhNo.Text
        Dim i As Char

        If str = "" Then
            MsgBox("Fill the Supplier PhoneNo. First", MsgBoxStyle.OkOnly, "Fill Detail")
            TxtSuppPhNo.Focus()
        Else
            For Each i In str
                If Char.IsDigit(i) = False Then
                    MsgBox("Insert only Digit  ", MsgBoxStyle.OkOnly, "Stop")
                    TxtSuppPhNo.Text = ""
                    TxtSuppPhNo.Focus()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub TxtSuppAdd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSuppAdd.Leave
        If TxtSuppAdd.Text = "" Then
            'MsgBox("Fill the Supplier Address First", MsgBoxStyle.OkOnly, "Fill Detail")
            TxtSuppAdd.Focus()
        End If
    End Sub

    Private Sub DGridSupplier_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGridSupplier.SelectionChanged
        Dim i = DGridSupplier.CurrentCell.RowIndex
        Dim con As New DataConnection
        Dim ds As New DataSet

        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("supplier_master")

            TxtSuppNo.Text = ds.Tables(0).Rows(i).Item(0).ToString
            TxtSuppName.Text = ds.Tables(0).Rows(i).Item(1).ToString
            TxtSuppAdd.Text = ds.Tables(0).Rows(i).Item(2).ToString
            TxtSuppPhNo.Text = ds.Tables(0).Rows(i).Item(3).ToString
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
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

    Private Sub BtnCancle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnCancel.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile("Btn\cancel_down.png")
            BtnCancel.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnCancle_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.MouseHover, BtnCancel.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\cancel_over.png")
            BtnCancel.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnCancle_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.MouseLeave, BtnCancel.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\cancel_out.png")
            BtnCancel.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnSave_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnSave.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile("Btn\ins_down.png")
            BtnSave.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnSave_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.MouseHover, BtnSave.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\ins_over.png")
            BtnSave.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnSave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.MouseLeave, BtnSave.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\ins_out.png")
            BtnSave.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnAdd_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnAdd.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile("Btn\add_down.png")
            BtnAdd.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnAdd_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAdd.MouseHover, BtnAdd.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\add_over.png")
            BtnAdd.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnAdd_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAdd.MouseLeave, BtnAdd.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\add_out.png")
            BtnAdd.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnSearch_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnSearch.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile("Btn\search_down.png")
            BtnSearch.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnSearch_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.MouseHover, BtnSearch.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\search_over.png")
            BtnSearch.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnSearch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.MouseLeave, BtnSearch.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\search_out.png")
            BtnSearch.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub

End Class