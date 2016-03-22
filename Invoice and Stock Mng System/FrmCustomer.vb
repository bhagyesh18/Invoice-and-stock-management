Imports System.Data.SqlClient
Public Class FrmCustomer

    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain
        FillCustomerDetail()
        BtnSave.Enabled = False
    End Sub

    Private Sub FrmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ToolTip.Active = False
    End Sub

    Private Sub FrmCustomer_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        ToolTip.Active = False
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        clear_all()
        BtnSave.Enabled = True
        BtnUpdate.Enabled = False
        TxtCustNo.Enabled = False
        TxtCustName.Focus()

        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("customer")

            TxtCustNo.Text = ds.Tables(0).Rows.Count + 101
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try

    End Sub
    Sub FillCustomerDetail()
        Dim con As New DataConnection
        Dim ds As New DataSet
        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("customer")
            DGridCustomer.DataSource = ds.Tables(0)
            TxtCustNo.Text = ds.Tables(0).Rows(0).Item(0).ToString
            TxtCustName.Text = ds.Tables(0).Rows(0).Item(1).ToString
            TxtCustAdd.Text = ds.Tables(0).Rows(0).Item(2).ToString
            TxtCustPhNo.Text = ds.Tables(0).Rows(0).Item(3).ToString
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub
    Sub clear_all()
        TxtCustNo.Text = ""
        TxtCustName.Text = ""
        TxtCustAdd.Text = ""
        TxtCustPhNo.Text = ""
    End Sub

    Function check() As Boolean
        Try
            If TxtCustNo.Text = "" Then
                ToolTip.Active = True
                ToolTip.Show(" Enter Customer ID ", TxtCustNo)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Enter Customer ID ", TxtCustNo)
                TxtCustNo.Focus()
                Return True
            End If
            '---------------------  
            If TxtCustName.Text = "" Then
                ToolTip.Active = True
                ToolTip.Show(" Enter Customer Name ", TxtCustName)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Enter Customer Name ", TxtCustName)
                TxtCustName.Focus()
                Return True
            End If
            '---------------------  
            If TxtCustAdd.Text = "" Then
                ToolTip.Active = True
                ToolTip.Show(" Enter Customer Address ", TxtCustAdd)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Enter Customer Address ", TxtCustAdd)
                TxtCustAdd.Focus()
                Return True
            End If
            '---------------------
            If TxtCustPhNo.Text.Length > 8 Or TxtCustPhNo.Text.Length < 12 Then
                Dim i As Char
                For Each i In TxtCustPhNo.Text
                    If Char.IsDigit(i) = False Then
                        ToolTip.Active = True
                        ToolTip.Show(" Enter Valid Phone Number of User ", TxtCustPhNo)
                        ToolTip.Active = False
                        ToolTip.Active = True
                        ToolTip.Show(" Enter Valid Phone Number of User ", TxtCustPhNo)
                        TxtCustPhNo.Focus()
                        Return True
                        Exit For
                    End If
                Next
            Else
                ToolTip.Active = True
                ToolTip.Show(" Enter Valid Phone Number of User ", TxtCustPhNo)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" Enter Valid Phone Number of User ", TxtCustPhNo)
                TxtCustPhNo.Focus()
                Return True
            End If
        Catch ex As Exception
        End Try
    End Function

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If check() = True Then
            Exit Sub
        Else
            ToolTip.Active = False
        End If

        Dim con As New DataConnection
        Dim str As String
        Dim cmd As New SqlCommand
        If TxtCustName.Text = "" Or TxtCustAdd.Text = "" Or TxtCustPhNo.Text = "" Then
            MsgBox(" Fill up the whole Customer information", MsgBoxStyle.Information)
            TxtCustName.Focus()
        Else
            Try
                con.OpenConnection()
                str = "insert into customer values('" & TxtCustNo.Text & "','" & TxtCustName.Text & "','" & TxtCustAdd.Text & "'," & TxtCustPhNo.Text & ");"
                cmd.Connection = con.sqlcon
                cmd.CommandText = str
                cmd.ExecuteNonQuery()
                FillCustomerDetail()

                BtnSave.Enabled = False
                BtnUpdate.Enabled = True
                TxtCustNo.Focus()
            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                con.CloseConnection()
            End Try
        End If
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        If TxtCustNo.Text = "" Then
            Exit Sub
        End If

        Dim con As New DataConnection
        Dim ds As New DataSet

        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("customer where cus_id=" & TxtCustNo.Text)

            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox(" Customer " & TxtCustNo.Text & " Not Found ", MsgBoxStyle.OkOnly, "Not Found")
                TxtCustNo.Focus()
            Else
                TxtCustNo.Text = ds.Tables(0).Rows(0).Item(0).ToString
                TxtCustName.Text = ds.Tables(0).Rows(0).Item(1).ToString
                TxtCustAdd.Text = ds.Tables(0).Rows(0).Item(2).ToString
                TxtCustPhNo.Text = ds.Tables(0).Rows(0).Item(3).ToString
            End If
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

        Dim con As New DataConnection
        Dim str As String
        Dim cmd As New SqlCommand
        If TxtCustName.Text = "" Or TxtCustAdd.Text = "" Or TxtCustPhNo.Text = "" Then
            MsgBox(" Fill up the whole supplier information", MsgBoxStyle.Information)
            TxtCustName.Focus()
        Else
            Try
                con.OpenConnection()
                str = "update customer set cus_name='" & TxtCustName.Text & "',cus_add='" & TxtCustAdd.Text & "',cus_phone=" & TxtCustPhNo.Text & " where cus_id='" & TxtCustNo.Text & "';"
                cmd.Connection = con.sqlcon
                cmd.CommandText = str
                cmd.ExecuteNonQuery()
                FillCustomerDetail()
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

    Private Sub TxtCustName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCustName.Leave
        Dim str = TxtCustName.Text
        Dim i As Char

        If str = "" Then
            MsgBox("     Fill Customer Name First          ", MsgBoxStyle.OkOnly, "Fill")
            TxtCustName.Focus()
        Else
            For Each i In str
                If Char.IsLetter(i) = True Or i = " " Then
                Else
                    MsgBox("Insert only Character [A-Z] [a-z] ", MsgBoxStyle.OkOnly, "Stop")
                    TxtCustName.Text = ""
                    TxtCustName.Focus()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub TxtCustPhNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCustPhNo.Leave
        Dim str = TxtCustPhNo.Text
        Dim i As Char

        If str = "" Then
            MsgBox(" Fill Customer Phone No. First ", MsgBoxStyle.OkOnly, "Fill")
            TxtCustPhNo.Focus()
        Else
            For Each i In str
                If Char.IsDigit(i) = False Then
                    MsgBox("Insert only Digit  ", MsgBoxStyle.OkOnly, "Stop")
                    TxtCustPhNo.Text = ""
                    TxtCustPhNo.Focus()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub DGridCustomer_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGridCustomer.SelectionChanged
        Dim i = DGridCustomer.CurrentCell.RowIndex

        Dim con As New DataConnection
        Dim ds As New DataSet

        Try
            con.OpenConnection()
            ds.Clear()
            ds = con.FillDataTable("customer")

            TxtCustNo.Text = ds.Tables(0).Rows(i).Item(0).ToString
            TxtCustName.Text = ds.Tables(0).Rows(i).Item(1).ToString
            TxtCustAdd.Text = ds.Tables(0).Rows(i).Item(2).ToString
            TxtCustPhNo.Text = ds.Tables(0).Rows(i).Item(3).ToString
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub TxtCustAdd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCustAdd.Leave
        If TxtCustAdd.Text = "" Then
            MsgBox(" Fill Customer Address First ", MsgBoxStyle.OkOnly, "Fill")
            TxtCustAdd.Focus()
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
    Private Sub BtnCancel_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnCancel.MouseUp
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
    Private Sub BtnSave_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnSave.MouseUp
        Try
            Dim img As Image
            img = Image.FromFile("Btn\ins_down.png")
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
    Private Sub BtnAdd_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnAdd.MouseUp
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
    Private Sub BtnSearch_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnSearch.MouseUp
        Try
            Dim img As Image
            img = Image.FromFile("Btn\search_down.png")
            BtnSearch.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub

End Class