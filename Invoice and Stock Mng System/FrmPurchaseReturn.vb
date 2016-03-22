Imports System.Data.SqlClient

Public Class FrmPurchaseReturn

    Dim InsFlag As Boolean = False

    Private Sub FrmPurchaseReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click, CmbComID.Click, CmbItemName.Click, CmbPurRetNo.Click, CmbSuppId.Click, DgridPurRet.Click, GroupBox1.Click, GroupBox2.Click, GroupBox3.Click, Label1.Click, Label2.Click, Label25.Click, Label3.Click, Label4.Click, Label5.Click, Label7.Click, PictureBox1.Click, TxtQty.Click, TxtRetDate.Click, TxtSuppName.Click
        Me.Focus()
    End Sub

    Private Sub frmpurreturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain
        BtnUpdate.Enabled = False
        TxtRetDate.Text = Date.Now.Date

        FillInvNo()
        FillSupp()
        FillItem()
    End Sub

    Sub FillInvNo()
        Dim con As New DataConnection
        Dim ds As New DataSet

        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("purchase")
            CmbPurRetNo.DataSource = ds.Tables(0)
            CmbPurRetNo.DisplayMember = "pur_inv_no"
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Sub FillPurchaseReturn(ByVal no As String)
        Dim con As New DataConnection
        Dim ds As New DataSet

        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("purchase_ret_detail where pur_ret_inv_no='" & no & "'")
            DgridPurRet.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Sub FillSupp()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("supplier_master")
            CmbSuppId.DataSource = ds.Tables(0)
            CmbSuppId.DisplayMember = "supp_id"
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Sub FillItem()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Dim str As String
        Try
            con.OpenConnection()
            ds.Clear()
            str = "select distinct(item_name) from item"
            ds = con.FillDataTableCustom(str)
            CmbItemName.DataSource = ds.Tables(0)
            CmbItemName.DisplayMember = "item_name"
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub DgridPurRet_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgridPurRet.SelectionChanged
        Dim no As Integer
        no = DgridPurRet.CurrentCell.RowIndex
    End Sub

    Private Sub BtnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        TxtQty.Text = ""
        TxtRetDate.Text = Date.Now.Date

        BtnUpdate.Enabled = False
        CmbPurRetNo.Focus()
    End Sub

    Private Sub BtnIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIns.Click
        Dim con As New DataConnection
        Dim str As String
        Dim cmd As New SqlCommand

        If TxtQty.Text <> "" Then
            Try
                If InsFlag = False Then
                    con.OpenConnection()
                    cmd.Connection = con.sqlcon
                    str = "insert into purchase_ret values('" & CmbPurRetNo.Text & "','" & TxtRetDate.Text & "'," & CmbSuppId.Text & ",'" & FrmLogin.uname & "');"
                    cmd.CommandText = str
                    cmd.ExecuteNonQuery()

                    str = "insert into purchase_ret_detail values('" & CmbPurRetNo.Text & "','" & CmbItemName.Text & "','" & CmbComID.Text & "'," & TxtQty.Text & ");"
                    cmd.CommandText = str
                    cmd.ExecuteNonQuery()

                    str = "update item set qty= qty - " & Val(TxtQty.Text) & " where item_name='" & CmbItemName.Text & "' and comp_id='" & CmbComID.Text & "'"
                    cmd.CommandText = str
                    cmd.ExecuteNonQuery()

                    InsFlag = True
                ElseIf InsFlag = True Then
                    con.OpenConnection()
                    cmd.Connection = con.sqlcon
                    str = "insert into purchase_ret_detail values('" & CmbPurRetNo.Text & "','" & CmbItemName.Text & "','" & CmbComID.Text & "'," & TxtQty.Text & ");"
                    cmd.CommandText = str
                    cmd.ExecuteNonQuery()

                    str = "update item set qty= qty - " & Val(TxtQty.Text) & " where item_name='" & CmbItemName.Text & "' and comp_id='" & CmbComID.Text & "'"
                    cmd.CommandText = str
                    cmd.ExecuteNonQuery()
                End If

                FillPurchaseReturn(CmbPurRetNo.Text)
            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                con.CloseConnection()
            End Try
        Else
            MsgBox(" First Insert Item Quantity", MsgBoxStyle.Information, "Require")
        End If
    End Sub

    Private Sub BtnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim con As New DataConnection
        Dim str As String
        Dim itemds As New DataSet
        Dim cmd As New SqlCommand
        Dim upqty As Double

        Try
            con.OpenConnection()
            cmd.Connection = con.sqlcon
            str = "update purchase_ret set pur_ret_date='" & TxtRetDate.Text & "',supp_id=" & CmbSuppId.Text & " Where pur_ret_inv_no='" & CmbPurRetNo.Text & "';"
            cmd.CommandText = str
            cmd.ExecuteNonQuery()

            str = "update purchase_ret_detail set qty=" & TxtQty.Text & " Where pur_ret_inv_no='" & CmbPurRetNo.Text & "' and item_name='" & CmbItemName.Text & "' and comp_id='" & CmbComID.Text & "';"
            cmd.CommandText = str
            cmd.ExecuteNonQuery()

            itemds.Clear()
            itemds = con.FillDataTable("purchase_ret_detail where((pur_ret_inv_no='" & CmbPurRetNo.Text & "')AND(item_name='" & CmbItemName.Text & "')AND(comp_id='" & CmbComID.Text & "'));")
            upqty = Val(itemds.Tables(0).Rows(0).Item(3).ToString)
            If upqty > Val(TxtQty.Text) Then
                Dim diff = upqty - Val(TxtQty.Text)
                upqty = upqty - diff
            ElseIf upqty < Val(TxtQty.Text) Then
                Dim diff = Val(TxtQty.Text) - upqty
                upqty = upqty + diff
            End If

            str = "update item set qty=" & upqty & " where(item_name='" & CmbItemName.Text & "')AND(comp_id='" & CmbComID.Text & "')"
            cmd.CommandText = str
            cmd.Connection = con.sqlcon
            cmd.ExecuteNonQuery()

            FillPurchaseReturn(CmbPurRetNo.Text)
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub ButCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        BtnUpdate.Enabled = True

        Dim dsmast As New DataSet
        Dim con As New DataConnection

        Try
            con.OpenConnection()
            dsmast.Clear()
            dsmast = con.FillDataTable("purchase_ret p,purchase_ret_detail d where p.pur_ret_inv_no='" & CmbPurRetNo.Text & "';")

            If dsmast.Tables(0).Rows.Count = 0 Then
                MsgBox(" There is no such Records Found.. ")
                Exit Sub
            Else
                CmbPurRetNo.Text = dsmast.Tables(0).Rows(0).Item(0)
                TxtRetDate.Text = dsmast.Tables(0).Rows(0).Item(1)
                CmbSuppId.Text = dsmast.Tables(0).Rows(0).Item(2)

                'DgridPurRet.DataSource = dsmast.Tables(0)
                CmbItemName.Text = dsmast.Tables(0).Rows(0).Item(5)
                CmbComID.Text = dsmast.Tables(0).Rows(0).Item(6)
                TxtQty.Text = dsmast.Tables(0).Rows(0).Item(7)
            End If

            FillPurchaseReturn(CmbPurRetNo.Text)
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub txtqty_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtQty.Leave
        Dim str = TxtQty.Text
        Dim i As Char

        If str <> "" Then
            '    MsgBox("Fill the Supplier PhoneNo. First", MsgBoxStyle.OkOnly, "Fill Detail")
            '    TxtQty.Focus()
            'Else
            For Each i In str
                If Char.IsDigit(i) = False Then
                    MsgBox("Insert only Digit  ", MsgBoxStyle.OkOnly, "Stop")
                    TxtQty.Text = ""
                    TxtQty.Focus()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub CmbSuppId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSuppId.SelectedIndexChanged
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("supplier_master")
            Dim i = CmbSuppId.SelectedIndex
            TxtSuppName.Text = ds.Tables(0).Rows(i).Item(1)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub CmbItemName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbItemName.SelectedIndexChanged
        Dim con As New DataConnection
        Dim ds As New DataSet

        Try
            con.OpenConnection()
            ds.Clear()
            Dim str = "select distinct(comp_id) from item where item_name='" & CmbItemName.Text & "'"
            ds = con.FillDataTableCustom(str)
            CmbComID.DataSource = ds.Tables(0)
            CmbComID.DisplayMember = "comp_id"
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.CloseConnection()
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

    Private Sub BtnIns_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnIns.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile("Btn\ins_down.png")
            BtnIns.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnIns_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnIns.MouseHover, BtnIns.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\ins_over.png")
            BtnIns.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnIns_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnIns.MouseLeave, BtnIns.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\ins_out.png")
            BtnIns.BackgroundImage = img
        Catch ex As Exception
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
End Class