Imports System.Data.SqlClient

Public Class FrmPurchase
    Dim insertFlag As Boolean = False
    Dim searchFlag As Boolean = False
    Dim upqty, qty As Integer
    Dim rat, disc, amu As Double

    Sub fillsupp()
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

    Sub fillitem()
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

    Sub FillVat()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("tax")
            LblVat.Text = ds.Tables(0).Rows(1).Item(1).ToString
            LblAddVat.Text = ds.Tables(0).Rows(0).Item(1).ToString
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Sub FillNullGrid()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("sales_detail where sale_inv_no=''")
            DgridPurInv.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Sub setInitial()
        TxtQty.Text = 0
        TxtDisc.Text = 0.0
        TxtVat.Text = 0.0
        TxtAddVAT.Text = 0.0
        TxtRate.Text = 0.0
        TxtAm.Text = 0.0
        TxtTotQty.Text = 0
        TxtTotAmu.Text = 0.0
    End Sub

    Sub clear_all()
        TxtPurInvoNo.Text = ""
        CmbSuppId.Text = ""
        TxtPurDate.Text = ""
        TxtTotQty.Text = ""
        TxtVat.Text = ""
        TxtAddVAT.Text = ""
        TxtTotAmu.Text = ""
        CmbItemName.Text = ""
        CmbCompId.Text = ""
        TxtQty.Text = ""
        TxtRate.Text = ""
        TxtDisc.Text = ""
        TxtAm.Text = ""
    End Sub

    Sub clearitemdetail()
        TxtQty.Text = ""
        TxtDisc.Text = ""
        TxtRate.Text = ""
        TxtAm.Text = ""
    End Sub

    Sub fillcomp()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTableCustom("select distinct(comp_id) from item where item_name='" & CmbItemName.Text & "';")
            CmbCompId.DataSource = ds.Tables(0)
            CmbCompId.DisplayMember = "comp_id"
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.CloseConnection()
        End Try

    End Sub

    Sub FillGrid()
        Dim con As New DataConnection
        Dim dspur As New DataSet
        Try
            con.OpenConnection()
            dspur.Clear()
            dspur = con.FillDataTable("purchase_detail where pur_inv_no='" & TxtPurInvoNo.Text & "';")
            DgridPurInv.DataSource = dspur.Tables(0)
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Sub fill_purchasemaster()

        Dim dspurchase As New DataSet
        Dim con As New DataConnection

        Try
            con.OpenConnection()
            dspurchase.Clear()
            dspurchase = con.FillDataTable("purchase where pur_inv_no='" & TxtPurInvoNo.Text & "';")
            If dspurchase.Tables(0).Rows.Count = 0 Then
                MsgBox(" Invalid purchase invoice number")
            Else
                TxtPurDate.Text = dspurchase.Tables(0).Rows(0).Item(2).ToString
                CmbSuppId.Text = dspurchase.Tables(0).Rows(0).Item(1).ToString
                TxtTotQty.Text = dspurchase.Tables(0).Rows(0).Item(4).ToString
                TxtVat.Text = dspurchase.Tables(0).Rows(0).Item(5).ToString
                TxtAddVAT.Text = dspurchase.Tables(0).Rows(0).Item(6).ToString
                TxtTotAmu.Text = dspurchase.Tables(0).Rows(0).Item(7).ToString
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Sub fill_purchasedetail()

        Dim con As New DataConnection
        Dim dspurdetail As New DataSet

        Try
            con.OpenConnection()
            dspurdetail.Clear()
            dspurdetail = con.FillDataTable("purchase_detail where pur_inv_no='" & TxtPurInvoNo.Text & "';")
            If dspurdetail.Tables(0).Rows.Count = 0 Then
                MsgBox(" there is no record in the table")
            Else
                CmbItemName.DataSource = dspurdetail.Tables(0)
                CmbItemName.DisplayMember = "item_name"
                DgridPurInv.DataSource = dspurdetail.Tables(0)
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Sub validateuptrans()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("purchase_detail where pur_inv_no='" & TxtPurInvoNo.Text & "' AND item_name='" & CmbItemName.Text & "' AND comp_id='" & CmbCompId.Text & "'")
            qty = CDbl(ds.Tables(0).Rows(0).Item(3))
            rat = CDbl(ds.Tables(0).Rows(0).Item(5))
            amu = CDbl(ds.Tables(0).Rows(0).Item(6))
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub FrmPurchase_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ToolTip1.Active = False
    End Sub

    Private Sub FrmPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = FrmMain
            Me.Size = New Size(710, 600)
            Me.PnlNewItem.Hide()
            Me.PnlNewSpp.Hide()
            fillsupp()
            fillitem()
            FillVat()
            setInitial()
            FillNullGrid()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub FrmPurchase_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        ToolTip1.Active = False
    End Sub

    Private Sub FrmPurchase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ToolTip1.Active = False
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        searchFlag = True
        fill_purchasemaster()
        fill_purchasedetail()

        TxtTotQty.ReadOnly = False
        TxtVat.ReadOnly = False
        TxtAddVAT.ReadOnly = False
        TxtTotAmu.ReadOnly = False
    End Sub

    Private Sub CmbSuppId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSuppId.SelectedIndexChanged
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("supplier_master")
            Dim i = CmbSuppId.SelectedIndex
            TxtSupName.Text = ds.Tables(0).Rows(i).Item(1).ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnNewSupp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewSupp.Click
        PnlNewSpp.Location = New Point(212, 87)
        PnlNewSpp.Show()
        Me.GRBMaster.Enabled = False
        Me.GRBDetail.Enabled = False
        Me.PnlMisc.Enabled = False
        ToolTip1.Active = False

        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("supplier_master")
            TxtSuppId.Text = ds.Tables(0).Rows.Count + 101
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnSuppIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSuppIns.Click

        Dim con As New DataConnection
        Dim str As String
        Dim cmd As New SqlCommand

        If TxtSuppName.Text = "" Or TxtSuppAdd.Text = "" Or TxtSuppPhone.Text = "" Then
            MsgBox(" Fill up the whole supplier information")
            TxtSuppName.Focus()
        Else
            Try
                con.OpenConnection()
                str = "insert into supplier_master values('" & TxtSuppId.Text & "','" & TxtSuppName.Text & "','" & TxtSuppAdd.Text & "'," & TxtSuppPhone.Text & ");"
                cmd.Connection = con.sqlcon
                cmd.CommandText = str
                cmd.ExecuteNonQuery()
                fillsupp()
                TxtSuppId.Text = ""
                TxtSuppName.Text = ""
                TxtSuppAdd.Text = ""
                TxtSuppPhone.Text = ""
            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                con.CloseConnection()
            End Try
        End If
    End Sub

    Private Sub BtnSuppCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSuppCancle.Click
        PnlNewSpp.Hide()
        Me.GRBMaster.Enabled = True
        Me.GRBDetail.Enabled = True
        Me.PnlMisc.Enabled = True
    End Sub

    Private Sub CmbItemName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbItemName.SelectedIndexChanged
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            If searchFlag = True Then
                ds.Clear()
                ds = con.FillDataTable("purchase_detail where pur_inv_no='" & TxtPurInvoNo.Text & "';")
                Dim i = CmbItemName.SelectedIndex
                CmbCompId.Text = ds.Tables(0).Rows(i).Item(2).ToString
                TxtQty.Text = ds.Tables(0).Rows(i).Item(3).ToString
                TxtDisc.Text = ds.Tables(0).Rows(i).Item(4).ToString
                TxtRate.Text = ds.Tables(0).Rows(i).Item(5).ToString
                TxtAm.Text = ds.Tables(0).Rows(i).Item(6).ToString
            Else
                fillcomp()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewItem.Click
        PnlNewItem.Location = New Point(212, 87)
        PnlNewItem.Show()
        Me.GRBMaster.Enabled = False
        Me.GRBDetail.Enabled = False
        Me.PnlMisc.Enabled = False
        ToolTip1.Active = False
    End Sub

    Private Sub BtnItemIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItemIns.Click

        Dim con As New DataConnection
        Dim cmd As New SqlCommand
        Dim str As String
        Dim ds As New DataSet
        Dim flag = 0

        If TxtItemName.Text = "" Or TxtComID.Text = "" Or TxtMinQty.Text = "" Or TxtDisc.Text = "" Or TxtRate.Text = "" Then
            MsgBox("please enter item details ", MsgBoxStyle.OkOnly)
        Else
            Try
                con.OpenConnection()
                ds.Clear()
                ds = con.FillDataTable("company_master")
                Dim i As Integer = ds.Tables(0).Rows.Count - 1
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    If TxtComID.Text = ds.Tables(0).Rows(i).Item(0).ToString Then
                        flag = 1
                        Exit For
                    End If
                Next
                If flag = 0 Then
                    str = "insert into company_master values('" & TxtComID.Text & "');"
                    cmd.Connection = con.sqlcon
                    cmd.CommandText = str
                    cmd.ExecuteNonQuery()
                End If
                str = "insert into item values('" & TxtItemName.Text & "','" & TxtComID.Text & "',0," & TxtMinQty.Text & "," & TxtDisc.Text & "," & TxtRate.Text & ")"
                cmd.Connection = con.sqlcon
                cmd.CommandText = str
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                con.CloseConnection()
            End Try

            fillitem()
            fillcomp()

            TxtItemName.Text = ""
            TxtComID.Text = ""
            TxtMinQty.Text = ""
            TxtItemDisc.Text = ""
            TxtItemRate.Text = ""
        End If
    End Sub

    Private Sub BtnItemCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItemCancle.Click
        PnlNewItem.Hide()
        Me.GRBMaster.Enabled = True
        Me.GRBDetail.Enabled = True
        Me.PnlMisc.Enabled = True
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Try
            clear_all()
            setInitial()
            FillNullGrid()
            searchFlag = False
            fillitem()
            fillcomp()
            fillsupp()
            insertFlag = False
            TxtVat.Enabled = True
            TxtAddVAT.Enabled = True
            TxtPurInvoNo.Focus()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub BtnIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIns.Click
        Dim con As New DataConnection
        Dim str As String
        Dim cmd As New SqlCommand
        Dim dsitem As New DataSet

        If TxtPurInvoNo.Text = "" Or TxtSupName.Text = "" Or TxtPurDate.Text = "" Or TxtQty.Text = "" Or TxtRate.Text = "" Or TxtDisc.Text = "" Or TxtAm.Text = "" Then
            MsgBox("please fill up supplier information", MsgBoxStyle.Information, "Require")
            TxtPurInvoNo.Focus()
        Else
            TxtTotQty.Text = Val(TxtTotQty.Text) + Val(TxtQty.Text)
            TxtVat.Text += (Val(TxtAm.Text) * (Val(LblVat.Text) / 100))
            TxtAddVAT.Text += (Val(TxtAm.Text) * (Val(LblAddVat.Text) / 100))
            TxtTotAmu.Text = Val(TxtTotAmu.Text) + Val(TxtAm.Text) + TxtVat.Text + TxtAddVAT.Text

            Try
                con.OpenConnection()
                dsitem.Clear()
                dsitem = con.FillDataTable("item where(((item_name='" & CmbItemName.Text & "') and (comp_id='" & CmbCompId.Text & "')));")

                If insertFlag = False Then
                    str = "insert into purchase values('" & TxtPurInvoNo.Text & "','" & CmbSuppId.Text & "','" & TxtPurDate.Text & "','" & FrmLogin.uname & "'," & TxtTotQty.Text & "," & TxtVat.Text & "," & TxtAddVAT.Text & "," & TxtTotAmu.Text & ");"
                    cmd.CommandText = str
                    cmd.Connection = con.sqlcon
                    cmd.ExecuteNonQuery()

                    str = "insert into purchase_detail values('" & TxtPurInvoNo.Text & "','" & CmbItemName.Text & "','" & CmbCompId.Text & "'," & TxtQty.Text & "," & TxtDisc.Text & "," & TxtRate.Text & "," & TxtAm.Text & ");"
                    cmd.CommandText = str
                    cmd.Connection = con.sqlcon
                    cmd.ExecuteNonQuery()

                    str = "Update item set qty=" & Val(dsitem.Tables(0).Rows(0).Item(2).ToString) + TxtQty.Text & " where (((item_name='" & CmbItemName.Text & "') and (comp_id='" & CmbCompId.Text & "')));"
                    cmd.CommandText = str
                    cmd.Connection = con.sqlcon
                    cmd.ExecuteNonQuery()

                    clearitemdetail()
                    insertFlag = True
                Else

                    str = "update purchase set total_qty='" & TxtTotQty.Text & "',total_amu=" & TxtTotAmu.Text & ",output_vat=" & TxtVat.Text & ",add_vat=" & TxtAddVAT.Text & " Where pur_inv_no='" & TxtPurInvoNo.Text & "';"
                    cmd.CommandText = str
                    cmd.Connection = con.sqlcon
                    cmd.ExecuteNonQuery()

                    str = "insert into purchase_detail values('" & TxtPurInvoNo.Text & "','" & CmbItemName.Text & "','" & CmbCompId.Text & "'," & TxtQty.Text & "," & TxtDisc.Text & "," & TxtRate.Text & "," & TxtAm.Text & ");"
                    cmd.CommandText = str
                    cmd.Connection = con.sqlcon
                    cmd.ExecuteNonQuery()

                    str = "Update item set qty=" & Val(dsitem.Tables(0).Rows(0).Item(2).ToString) + TxtQty.Text & " where (((item_name='" & CmbItemName.Text & "') and (comp_id='" & CmbCompId.Text & "')));"
                    cmd.CommandText = str
                    cmd.Connection = con.sqlcon
                    cmd.ExecuteNonQuery()

                    clearitemdetail()
                End If
                FillGrid()
                TxtQty.Text = 0
                TxtDisc.Text = 0.0
                TxtRate.Text = 0.0
                TxtAm.Text = 0.0
                CmbItemName.Focus()
            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                con.CloseConnection()
            End Try

        End If

    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        Dim con As New DataConnection
        Dim str As String
        Dim ds As New DataSet
        Dim itemds As New DataSet
        Dim cmd As New SqlCommand

        validateuptrans()
        'for quantity
        If qty > Val(TxtQty.Text) Then
            Dim diff = qty - Val(TxtQty.Text)
            TxtTotQty.Text = Val(TxtTotQty.Text) - diff
        ElseIf qty < Val(TxtQty.Text) Then
            Dim diff = Val(TxtQty.Text) - qty
            TxtTotQty.Text = Val(TxtTotQty.Text) + diff
        End If
        'for rate
        If rat > Val(TxtRate.Text) Then
            Dim diff = rat - Val(TxtRate.Text)
            TxtAm.Text = Val(TxtAm.Text) - (diff)
            TxtTotAmu.Text = Val(TxtTotAmu.Text) - (diff)
        ElseIf rat < Val(TxtRate.Text) Then
            Dim diff = Val(TxtRate.Text) - rat
            TxtAm.Text = Val(TxtAm.Text) + (diff)
            TxtTotAmu.Text = Val(TxtTotAmu.Text) + (diff)
        End If
        'for amount
        If amu > Val(TxtAm.Text) Then
            Dim diff = amu - Val(TxtAm.Text)
            TxtVat.Text = (Val(TxtAm.Text) * (Val(LblVat.Text) / 100))
            TxtAddVAT.Text = (Val(TxtAm.Text) * (Val(LblAddVat.Text) / 100))
            TxtTotAmu.Text = Val(TxtTotAmu.Text) - (diff) - ((amu * (Val(LblVat.Text) / 100)) + (amu * (Val(LblAddVat.Text) / 100))) + Val(TxtVat.Text) + Val(TxtAddVAT.Text)
        ElseIf amu < Val(TxtAm.Text) Then
            Dim diff = Val(TxtAm.Text) - amu
            TxtVat.Text = (Val(TxtAm.Text) * (Val(LblVat.Text) / 100))
            TxtAddVAT.Text = (Val(TxtAm.Text) * (Val(LblAddVat.Text) / 100))
            TxtTotAmu.Text = Val(TxtTotAmu.Text) + (diff) - ((amu * (Val(LblVat.Text) / 100)) + (amu * (Val(LblAddVat.Text) / 100))) + Val(TxtVat.Text) + Val(TxtAddVAT.Text)
        End If
        Try
            con.OpenConnection()
            str = "update purchase set supp_id='" & CmbSuppId.Text & "',total_qty='" & TxtTotQty.Text & "',pur_date='" & TxtPurDate.Text & "',output_vat=" & TxtVat.Text & ",add_vat=" & TxtAddVAT.Text & ",total_amu=" & TxtTotAmu.Text & " where pur_inv_no='" & TxtPurInvoNo.Text & "';"
            cmd.Connection = con.sqlcon
            cmd.CommandText = str
            cmd.ExecuteNonQuery()

            str = "update purchase_detail set qty=" & TxtQty.Text & ",Disc=" & TxtDisc.Text & ",rate=" & TxtRate.Text & ",amount=" & TxtAm.Text & " where((pur_inv_no='" & TxtPurInvoNo.Text & "')AND(item_name='" & CmbItemName.Text & "')AND(comp_id='" & CmbCompId.Text & "'));"
            cmd.Connection = con.sqlcon
            cmd.CommandText = str
            cmd.ExecuteNonQuery()

            itemds.Clear()
            itemds = con.FillDataTable("purchase_detail where((pur_inv_no='" & TxtPurInvoNo.Text & "')AND(item_name='" & CmbItemName.Text & "')AND(comp_id='" & CmbCompId.Text & "'));")
            upqty = Val(itemds.Tables(0).Rows(0).Item(2).ToString)
            If upqty > Val(TxtQty.Text) Then
                Dim diff = upqty - Val(TxtQty.Text)
                upqty = upqty - diff
            ElseIf upqty < Val(TxtQty.Text) Then
                Dim diff = Val(TxtQty.Text) - upqty
                upqty = upqty + diff
            End If

            str = "update item set qty=" & upqty & " where(item_name='" & CmbItemName.Text & "')AND(comp_id='" & CmbCompId.Text & "')"
            cmd.CommandText = str
            cmd.Connection = con.sqlcon
            cmd.ExecuteNonQuery()
            ds.Clear()
            ds = con.FillDataTable("purchase_detail where pur_inv_no='" & TxtPurInvoNo.Text & "'")
            DgridPurInv.DataSource = ds.Tables(0)

            TxtTotQty.ReadOnly = True
            TxtVat.ReadOnly = True
            TxtAddVAT.ReadOnly = True
            TxtTotAmu.ReadOnly = True
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub ButCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancle.Click
        Me.Close()
    End Sub

    Private Sub TxtPurInvoNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPurInvoNo.KeyDown
        If TxtPurInvoNo.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Invoice No First", TxtPurInvoNo)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Invoice No First", TxtPurInvoNo)
            TxtPurInvoNo.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtPurInvoNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPurInvoNo.Leave
        Try
            If TxtPurInvoNo.Text = "" Then
                ToolTip1.Active = True
                ToolTip1.Show("Enter Invoice No First", TxtPurInvoNo)
                ToolTip1.Active = False
                ToolTip1.Active = True
                ToolTip1.Show("Enter Invoice No First", TxtPurInvoNo)
                TxtPurInvoNo.Focus()
            Else
                ToolTip1.Active = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtPurDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPurDate.KeyDown
        If TxtPurDate.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Invoice Date First", TxtPurDate)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Invoice Date First", TxtPurDate)
            TxtPurDate.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtPurDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPurDate.Leave
        If TxtPurDate.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Invoice Date First", TxtPurDate)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Invoice Date First", TxtPurDate)
            TxtPurDate.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQty.KeyDown
        If TxtQty.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Quantity First", TxtQty)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Quantity First", TxtQty)
            TxtQty.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtQty_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtQty.Leave
        If TxtQty.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Quantity First", TxtQty)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Quantity First", TxtQty)
            TxtQty.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtDisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDisc.KeyDown
        If TxtDisc.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Discount First", TxtDisc)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Discount First", TxtDisc)
            TxtDisc.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtDisc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDisc.Leave
        If TxtDisc.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Discount First", TxtDisc)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Discount First", TxtDisc)
            TxtDisc.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtRate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtRate.KeyDown
        If TxtRate.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Rate First", TxtRate)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Rate First", TxtRate)
            TxtRate.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtRate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtRate.Leave
        If TxtRate.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Rate First", TxtRate)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Rate First", TxtRate)
            TxtRate.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtVat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVat.KeyDown
        If TxtVat.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Output VAT First", TxtVat)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Output VAT First", TxtVat)
            TxtVat.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtVat_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtVat.Leave
        If TxtVat.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Output VAT First", TxtVat)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Output VAT First", TxtVat)
            TxtVat.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtAddVAT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAddVAT.KeyDown
        If TxtAddVAT.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Additional VAT First", TxtAddVAT)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Additional VAT First", TxtAddVAT)
            TxtAddVAT.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtAddVAT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAddVAT.Leave
        If TxtAddVAT.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Additional VAT First", TxtAddVAT)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Additional VAT First", TxtAddVAT)
            TxtAddVAT.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtItemName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtItemName.KeyDown
        If TxtItemName.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Name First", TxtItemName)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Name First", TxtItemName)
            TxtItemName.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtItemName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtItemName.Leave
        If TxtItemName.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Name First", TxtItemName)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Name First", TxtItemName)
            TxtItemName.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtComID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtComID.KeyDown
        If TxtComID.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Company First", TxtComID)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Company First", TxtComID)
            TxtComID.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtComID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtComID.Leave
        If TxtComID.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Company First", TxtComID)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item Company First", TxtComID)
            TxtComID.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtMinQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMinQty.KeyDown
        If TxtMinQty.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item's Minimum Quantity First", TxtMinQty)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item's Minimum Quantity First", TxtMinQty)
            TxtMinQty.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtMinQty_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtMinQty.Leave
        If TxtMinQty.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item's Minimum Quantity First", TxtMinQty)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item's Minimum Quantity First", TxtMinQty)
            TxtMinQty.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtItemDisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtItemDisc.KeyDown
        If TxtItemDisc.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item's Discount(%) First", TxtItemDisc)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item's Discount(%) First", TxtItemDisc)
            TxtItemDisc.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtItemDisc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtItemDisc.Leave
        If TxtItemDisc.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item's Discount(%) First", TxtItemDisc)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item's Discount(%) First", TxtItemDisc)
            TxtItemDisc.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtItemRate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtItemRate.KeyDown
        If TxtItemRate.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item's Rate First", TxtItemRate)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item's Rate First", TxtItemRate)
            TxtItemRate.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtItemRate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtItemRate.Leave
        If TxtItemRate.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item's Rate First", TxtItemRate)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Item's Rate First", TxtItemRate)
            TxtItemRate.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtSupName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSupName.KeyDown
        If TxtSupName.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Supplier Name First", TxtSupName)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Supplier Name First", TxtSupName)
            TxtSupName.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtSupName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSupName.Leave
        If TxtSupName.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Supplier Name First", TxtSupName)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Supplier Name First", TxtSupName)
            TxtSupName.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtSuppAdd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSuppAdd.KeyDown
        If TxtSuppAdd.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Supplier Address First", TxtSuppAdd)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Supplier Address First", TxtSuppAdd)
            TxtSuppAdd.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtSuppAdd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSuppAdd.Leave
        If TxtSuppAdd.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Supplier Address First", TxtSuppAdd)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Supplier Address First", TxtSuppAdd)
            TxtSuppAdd.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtSuppPhone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSuppPhone.KeyDown
        If TxtSuppPhone.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Supplier's Phone No. First", TxtSuppPhone)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Supplier's Phone No. First", TxtSuppPhone)
            TxtSuppPhone.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtSuppPhone_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSuppPhone.Leave
        If TxtSuppPhone.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Supplier's Phone No. First", TxtSuppPhone)
            ToolTip1.Active = False
            ToolTip1.Active = True
            ToolTip1.Show("Enter Supplier's Phone No. First", TxtSuppPhone)
            TxtSuppPhone.Focus()
        Else
            ToolTip1.Active = False
        End If
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




