Imports System.Data.SqlClient
Public Class FrmItem

    Private Sub FrmItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain
        BtnInsert.Enabled = False
        item_detail()
        comp_detail()
    End Sub

    Private Sub FrmItem_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        ToolTip.Active = False
    End Sub

    Private Sub FrmItem_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ToolTip.Active = False
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        clear_all()
        BtnInsert.Enabled = True
        BtnUpdate.Enabled = False
        TxtQty.Text = 0
    End Sub

    Sub clear_all()
        TxtItemName.Text = ""
        TxtQty.Text = ""
        TxtMinQty.Text = ""
        TxtRate.Text = ""
    End Sub

    Sub item_detail()
        Dim con As New DataConnection
        Dim dsitem As New DataSet
        Try
            con.OpenConnection()
            dsitem.Clear()
            dsitem = con.FillDataTable("item")
            DGridItemList.DataSource = dsitem.Tables(0)
            TxtItemName.Text = dsitem.Tables(0).Rows(0).Item(0).ToString
            CmbCompId.Text = dsitem.Tables(0).Rows(0).Item(1).ToString
            TxtQty.Text = dsitem.Tables(0).Rows(0).Item(2).ToString
            TxtMinQty.Text = dsitem.Tables(0).Rows(0).Item(3).ToString
            Txtdisc.Text = dsitem.Tables(0).Rows(0).Item(4).ToString
            TxtRate.Text = dsitem.Tables(0).Rows(0).Item(5).ToString
            LblTotalItem.Text = dsitem.Tables(0).Rows.Count
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub
    Sub comp_detail()
        Dim con As New DataConnection
        Dim dscomp As New DataSet
        Try
            con.OpenConnection()
            dscomp = con.FillDataTable("company_master")
            CmbCompId.DataSource = dscomp.Tables(0)
            CmbCompId.DisplayMember = "comp_id"
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Function check() As Boolean
        Try
            If TxtItemName.Text = "" Then
                ToolTip.Active = True
                ToolTip.Show(" Enter Item Name ", TxtItemName)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Enter Item Name ", TxtItemName)
                TxtItemName.Focus()
                Return True
            End If
            '---------------------
            If CmbCompId.Text = "" Then
                ToolTip.Active = True
                ToolTip.Show(" Select Company ID ", CmbCompId)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Select Company ID ", CmbCompId)
                CmbCompId.Focus()
                Return True
            End If
            '---------------------
            If Val(TxtQty.Text) < 0 Or Val(TxtQty.Text) > 99999 Then
                ToolTip.Active = True
                ToolTip.Show(" Quntity must be between 0-99999 ", TxtQty)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Quntity must be between 0-99999 ", TxtQty)
                TxtQty.Focus()
                Return True
            End If
            '---------------------
            If Val(TxtMinQty.Text) < 0 Or Val(TxtMinQty.Text) > 99 Then
                ToolTip.Active = True
                ToolTip.Show(" Minimum Quntity must be between 0-99 ", TxtMinQty)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Minimum Quntity must be between 0-99 ", TxtMinQty)
                TxtMinQty.Focus()
                Return True
            End If
            '---------------------
            If Val(Txtdisc.Text) < 0.0 Or Val(Txtdisc.Text) > 100.0 Then
                ToolTip.Active = True
                ToolTip.Show(" Discount must be between 1%-100% ", Txtdisc)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Discount must be between 1%-100% ", Txtdisc)
                Txtdisc.Focus()
                Return True
            End If
            '---------------------
            If Val(TxtRate.Text) < 0.0 Or Val(TxtRate.Text) > 999999.0 Then
                MsgBox(" ", MsgBoxStyle.OkOnly)
                ToolTip.Active = True
                ToolTip.Show(" Rate must be between 1.0-999999.0 ", TxtRate)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Rate must be between 1.0-999999.0 ", TxtRate)
                TxtRate.Focus()
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

        Dim con As New DataConnection
        Dim cmd As New SqlCommand
        Dim str As String
        Dim ds As New DataSet
        Dim flag = 0
        If TxtItemName.Text = "" Or CmbCompId.Text = "" Or TxtMinQty.Text = "" Or TxtRate.Text = "" Or Txtdisc.Text = "" Then
            MsgBox("please enter item details ", MsgBoxStyle.OkOnly)
        Else
            Try
                con.OpenConnection()
                ds.Clear()
                ds = con.FillDataTable("company_master")
                Dim i As Integer
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    If CmbCompId.Text = ds.Tables(0).Rows(i).Item(0).ToString Then
                        flag = 1
                        Exit For
                    End If
                Next
                If flag = 0 Then
                    str = "insert into company_master values('" & CmbCompId.Text & "');"
                    cmd.Connection = con.sqlcon
                    cmd.CommandText = str
                    cmd.ExecuteNonQuery()
                End If
                str = "insert into item values('" & TxtItemName.Text & "','" & CmbCompId.Text & "'," & TxtQty.Text & "," & TxtMinQty.Text & "," & Txtdisc.Text & "," & TxtRate.Text & ")"
                cmd.Connection = con.sqlcon
                cmd.CommandText = str
                cmd.ExecuteNonQuery()

                BtnInsert.Enabled = False
                BtnUpdate.Enabled = True
            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                con.CloseConnection()
            End Try
            item_detail()
            comp_detail()
        End If
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If check() = True Then
            Exit Sub
        Else
            ToolTip.Active = False
        End If

        Dim con As New DataConnection
        Dim str As String
        Dim cmd As New SqlCommand
        If TxtItemName.Text = "" Or CmbCompId.Text = "" Or TxtMinQty.Text = "" Or TxtRate.Text = "" Or Txtdisc.Text = "" Then
            MsgBox("please enter item details ", MsgBoxStyle.OkOnly)
        Else

            Try
                con.OpenConnection()
                str = "update item set comp_id='" & CmbCompId.Text & "',qty=" & TxtQty.Text & ",min_qty=" & TxtMinQty.Text & ",disc=" & Txtdisc.Text & ",rate=" & TxtRate.Text & " where item_name='" & TxtItemName.Text & "';"
                cmd.Connection = con.sqlcon
                cmd.CommandText = str
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                con.CloseConnection()
            End Try
            item_detail()
            comp_detail()
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        If TxtItemName.Text = "" Then
            ToolTip.Active = True
            ToolTip.Show(" Enter Item Name to Search ", TxtItemName)
            ToolTip.Active = False
            ToolTip.Active = True
            ToolTip.Show(" Enter Item Name to Search ", TxtItemName)
            TxtItemName.Focus()
            Exit Sub
        Else
            ToolTip.Active = False
        End If

        Dim con As New DataConnection
        Dim ds As New DataSet
        Dim i As Integer
        Try
            con.OpenConnection()
            ds = con.FillDataTable("Item")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                If TxtItemName.Text = ds.Tables(0).Rows(i).Item(0).ToString Then
                    DGridItemList.DataSource = ds.Tables(0)
                    TxtItemName.Text = ds.Tables(0).Rows(i).Item(0).ToString
                    CmbCompId.Text = ds.Tables(0).Rows(i).Item(1).ToString
                    TxtQty.Text = ds.Tables(0).Rows(i).Item(2).ToString
                    TxtMinQty.Text = ds.Tables(0).Rows(i).Item(3).ToString
                    TxtRate.Text = ds.Tables(0).Rows(i).Item(4).ToString
                    LblTotalItem.Text = ds.Tables(0).Rows.Count
                End If
            Next
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim con As New DataConnection
        Dim str As String
        Dim cmd As New SqlCommand
        Try
            con.OpenConnection()
            str = "delete from item where item_name='" & TxtItemName.Text & "';"
            cmd.Connection = con.sqlcon
            cmd.CommandText = str
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
        item_detail()
        comp_detail()
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

    Private Sub BtnSave_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnInsert.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile("Btn\ins_down.png")
            BtnInsert.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnSave_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInsert.MouseHover, BtnInsert.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\ins_over.png")
            BtnInsert.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnSave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInsert.MouseLeave, BtnInsert.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\ins_out.png")
            BtnInsert.BackgroundImage = img
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
