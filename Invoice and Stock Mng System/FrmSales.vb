Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class FrmSales

    Dim insertFlag As Boolean = False
    Dim searchFlag As Boolean = False
    Dim printFlag As Boolean = False

    Dim totqty, qty As Integer
    Dim vat, addvat, totamu, am As Double

    Private Sub FrmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(695, 645)
        Me.MdiParent = FrmMain
        Me.PnlNewCus.Hide()
        setInitial()
        FillCust()
        FillItem()
        fillcomp()
        FillValue()
        FillItemDetail()
        FillVat()
        FillNullGrid()
        TxtSalesDate.Text = Date.Now.Date
    End Sub

    Private Sub FrmSales_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ToolTip1.Active = False
    End Sub

    Private Sub FrmSales_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        ToolTip1.Active = False
    End Sub

    Sub FillNullGrid()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("sales_detail where sale_inv_no=''")
            DGSales.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub
    Sub setInitial()
        TxtRate.Text = 0.0
        TxtDisc.Text = 0.0
        TxtQty.Text = 0
        TxtSrNo.Text = ""
        TxtVat.Text = 0.0
        TxtAddVat.Text = 0.0
        TxtAmu.Text = 0.0
        TxtTotAm.Text = 0.0
        TxtTotQty.Text = 0
    End Sub
    Sub FillCust()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("customer")
            CmbCustId.DataSource = ds.Tables(0)
            CmbCustId.DisplayMember = "cus_id"
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub
    Sub FillItem()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTableCustom("select distinct(item_name) from item")
            CmbItemName.DataSource = ds.Tables(0)
            CmbItemName.DisplayMember = "item_name"
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
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
    Sub FillValue()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTableCustom("select * from item where item_name='" & CmbItemName.Text & "';")
            If ds.Tables(0).Rows.Count = 0 Then
            Else
                TxtRate.Text = ds.Tables(0).Rows(0).Item(5).ToString
                TxtDisc.Text = ds.Tables(0).Rows(0).Item(4).ToString
            End If
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
    Sub FillItemDetail()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Dim i As Integer = CmbItemName.SelectedIndex
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("item")
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        If printFlag = True Then
            PrintInvoice.Print()
        Else
            MsgBox(" No Item in Invoice")
        End If

    End Sub

    Private Sub PrintInvoice_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintInvoice.PrintPage
        'e.Graphics.DrawImageUnscaledAndClipped(Image.FromFile("image\Bill_BG.jpg"), New Rectangle(10, 10, 832, 1090))
        Dim con As New DataConnection
        Dim dssale As New DataSet
        Dim ptvat, ptaddvat As Double
        Try
            con = New DataConnection
            Dim str As String
            con.OpenConnection()
            dssale.Clear()
            dssale = con.FillDataTable("sales where sale_inv_no='" & TxtSalesInvNo.Text & "';")
            ' for sales master only
            'static image
            e.Graphics.DrawImageUnscaledAndClipped(Image.FromFile("image\Bill_Plain_BG.jpg"), New Rectangle(10, 10, 832, 1090))
            'static image
            e.Graphics.DrawImageUnscaledAndClipped(Image.FromFile("image\Bill_Text_BG.png"), New Rectangle(10, 10, 832, 1090))
            'dynamic invoice no
            e.Graphics.DrawString(dssale.Tables(0).Rows(0).Item(0).ToString, New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, 500, 230)
            'dynamic date
            str = dssale.Tables(0).Rows(0).Item(1).ToString
            e.Graphics.DrawString(str.Substring(0, InStr(str, "12:00:00") - 1), New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, 650, 230)
            'dynamic total quantity
            e.Graphics.DrawString(dssale.Tables(0).Rows(0).Item(3).ToString, New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, 420, 880)
            'dynamic VAT
            ptvat = dssale.Tables(0).Rows(0).Item(4)
            'dynamic ADDVAT
            ptaddvat = dssale.Tables(0).Rows(0).Item(5)
            'dynamic total amount
            e.Graphics.DrawString(dssale.Tables(0).Rows(0).Item(6).ToString, New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, 700, 880)
            'for customer only
            e.Graphics.DrawString(RTBCustDetail.Text, New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, 60, 305)

        Catch ex As Exception
            MsgBox(Err.Description)
            printFlag = False
        Finally
            con.CloseConnection()
        End Try

        Try
            con = New DataConnection

            Dim x As Integer = 60
            Dim y As Integer = 400
            Dim item As Integer

            con.OpenConnection()
            dssale.Clear()
            dssale = con.FillDataTable("sales_detail where sale_inv_no='" & TxtSalesInvNo.Text & "';")

            For item = 0 To dssale.Tables(0).Rows.Count - 1
                'for item name
                e.Graphics.DrawString(dssale.Tables(0).Rows(item).Item(1).ToString + " (" + dssale.Tables(0).Rows(item).Item(2).ToString + ")", New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, x, y)
                'for serial no
                e.Graphics.DrawString(dssale.Tables(0).Rows(item).Item(3).ToString, New Font("verdana", 35, FontStyle.Regular, GraphicsUnit.Document), Brushes.Blue, x, y + 18)
                'for quantity
                e.Graphics.DrawString(dssale.Tables(0).Rows(item).Item(4).ToString, New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, x + 360, y)
                'for rate
                e.Graphics.DrawString(dssale.Tables(0).Rows(item).Item(5).ToString, New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, x + 425, y)
                'for per pcs
                e.Graphics.DrawString("pcs", New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, x + 520, y)
                'for discount
                e.Graphics.DrawString(dssale.Tables(0).Rows(item).Item(6).ToString, New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, x + 560, y)
                'for amount
                e.Graphics.DrawString(dssale.Tables(0).Rows(item).Item(7).ToString, New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, x + 650, y)
                y = y + 35
            Next
            y = y + 35
            e.Graphics.DrawString("Output VAT " + LblVat.Text + "%", New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, 200, y)
            e.Graphics.DrawString(ptvat, New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, 700, y)
            y = y + 35
            e.Graphics.DrawString("Additional VAT " + LblAddVat.Text + "%", New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, 200, y)
            e.Graphics.DrawString(ptaddvat, New Font("verdana", 50, FontStyle.Italic, GraphicsUnit.Document), Brushes.Blue, 700, y)
        Catch ex As Exception
            MsgBox(Err.Description)
            printFlag = False
        Finally
            con.CloseConnection()
        End Try

    End Sub

    Private Sub prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        PrintPreviewDialog1.Document = PrintInvoice
        PrintPreviewDialog1.MdiParent = FrmMain
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub CmbCustId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCustId.SelectedIndexChanged
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("customer")
            Dim i = CmbCustId.SelectedIndex
            RTBCustDetail.Clear()
            Dim str As String = ds.Tables(0).Rows(i).Item(1).ToString
            RTBCustDetail.Text = str.ToUpper
            RTBCustDetail.AppendText(vbCrLf & ds.Tables(0).Rows(i).Item(2).ToString)

            RTBCustDetail.SelectionStart = 0
            RTBCustDetail.SelectionLength = str.Length
            RTBCustDetail.SelectionFont = New Font(RTBCustDetail.Font, FontStyle.Bold)
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
            If searchFlag = True Then
                ds.Clear()
                ds = con.FillDataTable("sales_detail where sale_inv_no='" & TxtSalesInvNo.Text & "';")
                Dim i = CmbItemName.SelectedIndex
                CmbCompId.Text = ds.Tables(0).Rows(i).Item(2).ToString
                TxtSrNo.Text = ds.Tables(0).Rows(i).Item(3).ToString
                TxtQty.Text = ds.Tables(0).Rows(i).Item(4).ToString
                TxtDisc.Text = ds.Tables(0).Rows(i).Item(6).ToString
                TxtRate.Text = ds.Tables(0).Rows(i).Item(5).ToString
                TxtAmu.Text = ds.Tables(0).Rows(i).Item(7).ToString
            Else
                fillcomp()
                FillValue()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub ButCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsert.Click
        Dim con As New DataConnection
        Dim str As String
        Dim cmd As New SqlCommand
        Dim dsitem As New DataSet
        Dim dssaledetail As New DataSet
        Try
            con.OpenConnection()
            dsitem = con.FillDataTable("item where(((item_name='" & CmbItemName.Text & "') and (comp_id='" & CmbCompId.Text & "')));")

            TxtTotQty.Text = Val(TxtTotQty.Text) + Val(TxtQty.Text)
            TxtAmu.Text = (Val(TxtRate.Text) * Val(TxtQty.Text)) - (Val(TxtRate.Text) * Val(TxtQty.Text)) * (Val(TxtDisc.Text) / 100)
            TxtVat.Text = Val(TxtVat.Text) + (Val(TxtAmu.Text) * (Val(LblVat.Text) / 100))
            TxtAddVat.Text = Val(TxtAddVat.Text) + (Val(TxtAmu.Text) * (Val(LblAddVat.Text) / 100))
            TxtTotAm.Text = Val(TxtTotAm.Text) + Val(TxtAmu.Text) + (Val(TxtAmu.Text) * (Val(LblVat.Text) / 100)) + (Val(TxtAmu.Text) * (Val(LblAddVat.Text) / 100))
            If insertFlag = False Then
                str = "insert into sales values('" & TxtSalesInvNo.Text & "','" & TxtSalesDate.Text & "','" & CmbCustId.Text & "'," & TxtTotQty.Text & "," & TxtVat.Text & "," & TxtAddVat.Text & "," & TxtTotAm.Text & ",'" & FrmLogin.uname & "');"
                cmd.CommandText = str
                cmd.Connection = con.sqlcon
                cmd.ExecuteNonQuery()

                str = "insert into sales_detail values('" & TxtSalesInvNo.Text & "','" & CmbItemName.Text & "','" & CmbCompId.Text & "','" & TxtSrNo.Text & "'," & TxtQty.Text & "," & TxtRate.Text & "," & TxtDisc.Text & "," & TxtAmu.Text & ");"
                cmd.CommandText = str
                cmd.Connection = con.sqlcon
                cmd.ExecuteNonQuery()

                str = "Update item set qty=" & Val(dsitem.Tables(0).Rows(0).Item(2).ToString) - TxtQty.Text & " where (((item_name='" & CmbItemName.Text & "') and (comp_id='" & CmbCompId.Text & "')));"
                cmd.CommandText = str
                cmd.Connection = con.sqlcon
                cmd.ExecuteNonQuery()

                insertFlag = True
            Else

                str = "update sales set output_vat=" & TxtVat.Text & ",add_vat=" & TxtAddVat.Text & ",total_qty=" & TxtTotQty.Text & ",total_amu=" & TxtTotAm.Text & " Where sale_inv_no='" & TxtSalesInvNo.Text & "';"
                cmd.CommandText = str
                cmd.Connection = con.sqlcon
                cmd.ExecuteNonQuery()

                str = "insert into sales_detail values('" & TxtSalesInvNo.Text & "','" & CmbItemName.Text & "','" & CmbCompId.Text & "','" & TxtSrNo.Text & "'," & TxtQty.Text & "," & TxtRate.Text & "," & TxtDisc.Text & "," & TxtAmu.Text & ");"
                cmd.CommandText = str
                cmd.Connection = con.sqlcon
                cmd.ExecuteNonQuery()

                str = "Update item set qty=" & Val(dsitem.Tables(0).Rows(0).Item(2).ToString) - TxtQty.Text & " where (((item_name='" & CmbItemName.Text & "') and (comp_id='" & CmbCompId.Text & "')));"
                cmd.CommandText = str
                cmd.Connection = con.sqlcon
                cmd.ExecuteNonQuery()
            End If
            FillGrid()
            TxtSrNo.Text = 0
            TxtQty.Text = 0
            TxtAmu.Text = 0
            printFlag = True
            CmbItemName.Focus()
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub
    Sub FillGrid()
        Dim con As New DataConnection
        Dim dssaledetail As New DataSet
        Try
            con.OpenConnection()
            dssaledetail = con.FillDataTable("sales_detail where sale_inv_no='" & TxtSalesInvNo.Text & "';")
            DGSales.DataSource = dssaledetail.Tables(0)
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try

    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        insertFlag = False
        searchFlag = False
        printFlag = False
        setInitial()
        FillCust()
        FillItem()
        fillcomp()
        FillItemDetail()
        FillVat()
        FillNullGrid()
        TxtSalesInvNo.Text = ""
        TxtSalesInvNo.Focus()
        TxtSalesDate.Text = Date.Now.Date
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        searchFlag = True
        fill_salesmaster()
        fill_salesdetail()
        printFlag = True
    End Sub

    Sub fill_salesmaster()

        Dim dssales As New DataSet
        Dim con As New DataConnection

        Try
            con.OpenConnection()
            dssales.Clear()
            dssales = con.FillDataTable("sales where sale_inv_no='" & TxtSalesInvNo.Text & "';")
            If dssales.Tables(0).Rows.Count = 0 Then
                MsgBox(" Invalid sales invoice number")
            Else
                TxtSalesDate.Text = dssales.Tables(0).Rows(0).Item(1).ToString
                CmbCustId.Text = dssales.Tables(0).Rows(0).Item(2).ToString
                TxtTotQty.Text = dssales.Tables(0).Rows(0).Item(3).ToString
                TxtVat.Text = dssales.Tables(0).Rows(0).Item(4).ToString
                TxtAddVat.Text = dssales.Tables(0).Rows(0).Item(5).ToString
                TxtTotAm.Text = dssales.Tables(0).Rows(0).Item(6).ToString
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub
    Sub fill_salesdetail()

        Dim con As New DataConnection
        Dim dssalesdetail As New DataSet

        Try
            con.OpenConnection()
            dssalesdetail.Clear()
            dssalesdetail = con.FillDataTable("sales_detail where sale_inv_no='" & TxtSalesInvNo.Text & "';")
            If dssalesdetail.Tables(0).Rows.Count = 0 Then
                MsgBox(" there is no record in the table")
            Else
                CmbItemName.DataSource = dssalesdetail.Tables(0)
                CmbItemName.DisplayMember = "item_name"
                DGSales.DataSource = dssalesdetail.Tables(0)
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub
    Sub ReturnSalesMaster()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("sales where sale_inv_no='" & TxtSalesInvNo.Text & "'")
            totqty = CDbl(ds.Tables(0).Rows(0).Item(3))
            vat = CDbl(ds.Tables(0).Rows(0).Item(4))
            addvat = CDbl(ds.Tables(0).Rows(0).Item(5))
            totamu = CDbl(ds.Tables(0).Rows(0).Item(6))
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub
    Sub ReturnSalesDetail()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("sales_detail where sale_inv_no='" & TxtSalesInvNo.Text & "' AND item_name='" & CmbItemName.Text & "' AND comp_id='" & CmbCompId.Text & "'")
            qty = CDbl(ds.Tables(0).Rows(0).Item(4))
            am = CDbl(ds.Tables(0).Rows(0).Item(7))
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim con As New DataConnection
        Dim str As String
        Dim cmd As New SqlCommand
        Dim itemds As DataSet
        Dim upqty As Integer = 0

        ReturnSalesMaster()
        ReturnSalesDetail()

        Dim updamu, updvat, updaddvat As Double
        If qty > Val(TxtQty.Text) Then
            Dim diff = qty - Val(TxtQty.Text)
            TxtTotQty.Text = Val(TxtTotQty.Text) - diff

            updamu = (diff * Val(TxtRate.Text)) - (diff * Val(TxtRate.Text)) * (Val(TxtDisc.Text) / 100)
            TxtAmu.Text = Val(TxtAmu.Text) - updamu

            updvat = updamu * (Val(LblVat.Text) / 100)
            TxtVat.Text = Val(TxtVat.Text) - updvat

            updaddvat = updamu * (Val(LblAddVat.Text) / 100)
            TxtAddVat.Text = Val(TxtAddVat.Text) - updaddvat

            TxtTotAm.Text = Val(TxtTotAm.Text) - (updamu + updvat + updaddvat)

        ElseIf qty < Val(TxtQty.Text) Then
            Dim diff = Val(TxtQty.Text) - qty
            TxtTotQty.Text = Val(TxtTotQty.Text) + diff

            updamu = (diff * Val(TxtRate.Text)) - (Val(TxtRate.Text) * diff) * (Val(TxtDisc.Text) / 100)
            TxtAmu.Text = Val(TxtAmu.Text) + updamu

            updvat = updamu * (Val(LblVat.Text) / 100)
            TxtVat.Text = Val(TxtVat.Text) + updvat

            updaddvat = updamu * (Val(LblAddVat.Text) / 100)
            TxtAddVat.Text = Val(TxtAddVat.Text) + updaddvat

            TxtTotAm.Text = Val(TxtTotAm.Text) + updamu + updvat + updaddvat
        End If

        Try
            con.OpenConnection()
            str = "update sales set cus_id='" & CmbCustId.Text & "',total_qty=" & TxtTotQty.Text & ",output_vat=" & TxtVat.Text & ",add_vat=" & TxtAddVat.Text & ",total_amu=" & TxtTotAm.Text & " where sale_inv_no='" & TxtSalesInvNo.Text & "';"
            cmd.Connection = con.sqlcon
            cmd.CommandText = str
            cmd.ExecuteNonQuery()

            str = "update sales_detail set serial_no='" & TxtSrNo.Text & "',qty=" & TxtQty.Text & ",amount=" & TxtAmu.Text & " where((sale_inv_no='" & TxtSalesInvNo.Text & "')AND(item_name='" & CmbItemName.Text & "')AND(comp_id='" & CmbCompId.Text & "'));"
            cmd.Connection = con.sqlcon
            cmd.CommandText = str
            cmd.ExecuteNonQuery()

            itemds = New DataSet
            itemds.Clear()
            itemds = con.FillDataTable("sales_detail where((sale_inv_no='" & TxtSalesInvNo.Text & "')AND(item_name='" & CmbItemName.Text & "')AND(comp_id='" & CmbCompId.Text & "'));")
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
            itemds = New DataSet
            itemds.Clear()
            itemds = con.FillDataTable("sales_detail where sale_inv_no='" & TxtSalesInvNo.Text & "'")
            DGSales.DataSource = itemds.Tables(0)
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnNewCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCust.Click
        PnlNewCus.Location = New Point(155, 175)
        PnlNewCus.Show()
        Me.GroupBox1.Enabled = False
        Me.GroupBox2.Enabled = False
        Me.GroupBox3.Enabled = False
        Me.DGSales.Enabled = False

        TxtCusId.Text = ""
        TxtCusName.Text = ""
        TxtCusAdd.Text = ""
        TxtCusPhone.Text = ""

        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("customer")
            TxtCusId.Text = ds.Tables(0).Rows.Count + 101
            TxtCusId.ReadOnly = True
            TxtCusName.Focus()
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnCusIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCusIns.Click
        Dim con As New DataConnection
        Dim str As String
        Dim cmd As New SqlCommand

        If TxtCusName.Text = "" Or TxtCusAdd.Text = "" Or TxtCusPhone.Text = "" Then
            ' MsgBox(" Fill up the whole Customer information")
            TxtCusName.Focus()
        Else
            Try
                con.OpenConnection()
                str = "insert into customer values('" & TxtCusId.Text & "','" & TxtCusName.Text & "','" & TxtCusAdd.Text & "'," & TxtCusPhone.Text & ");"
                cmd.Connection = con.sqlcon
                cmd.CommandText = str
                cmd.ExecuteNonQuery()
                FillCust()

                BtnCusCancle_Click(sender, e)
            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                con.CloseConnection()
            End Try
        End If
    End Sub

    Private Sub BtnCusCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCusCancle.Click
        PnlNewCus.Hide()
        Me.GroupBox1.Enabled = True
        Me.GroupBox2.Enabled = True
        Me.GroupBox3.Enabled = True
        Me.DGSales.Enabled = True
    End Sub

    Private Sub TxtCusName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCusName.KeyDown
        If TxtCusName.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Customer Name First", TxtCusName)
            TxtCusName.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub
    Private Sub TxtCusName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCusName.Leave
        If TxtCusName.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Customer Name First", TxtCusName)
            TxtCusName.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtCusAdd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCusAdd.KeyDown
        If TxtCusAdd.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Customer Address First", TxtCusAdd)
            TxtCusAdd.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub
    Private Sub TxtCusAdd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCusAdd.Leave
        If TxtCusAdd.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Customer Address First", TxtCusAdd)
            TxtCusAdd.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub TxtCusPhone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCusPhone.KeyDown
        If TxtCusPhone.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Customer's Phone No. First", TxtCusPhone)
            TxtCusPhone.Focus()
        Else
            ToolTip1.Active = False
        End If
    End Sub
    Private Sub TxtCusPhone_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCusPhone.Leave
        If TxtCusPhone.Text = "" Then
            ToolTip1.Active = True
            ToolTip1.Show("Enter Customer's Phone No. First", TxtCusPhone)
            TxtCusPhone.Focus()
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

    Private Sub BtnPrint_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnPrint.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile("Btn\print_down.png")
            BtnPrint.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnPrint_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint.MouseHover, BtnPrint.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\print_over.png")
            BtnPrint.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnPrint_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint.MouseLeave, BtnPrint.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\print_out.png")
            BtnPrint.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub

    Private Sub prev_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnPrev.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile("Btn\printpreview_down.png")
            BtnPrev.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub prev_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrev.MouseHover, BtnPrev.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\printpreview_over.png")
            BtnPrev.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub prev_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrev.MouseLeave, BtnPrev.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\printpreview_out.png")
            BtnPrev.BackgroundImage = img
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

    Private Sub TxtQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtQty.LostFocus
        Dim con As New DataConnection
        Dim ds As New DataSet

        Try
            con.OpenConnection()
            ds = con.FillDataTableCustom("select * from item where item_name='" & CmbItemName.Text & "' and comp_id='" & CmbCompId.Text & "';")
            If TxtQty.Text > ds.Tables(0).Rows(0).Item(2).ToString Then
                ToolTip1.Active = True
                ToolTip1.Show("Available Quantity for Selected Item " + ds.Tables(0).Rows(0).Item(2).ToString, TxtQty)
                TxtQty.Clear()
                TxtQty.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub
End Class