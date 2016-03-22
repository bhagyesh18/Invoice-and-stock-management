Imports System.Data.SqlClient

Public Class FrmRptPurchaseRetPara

    Dim sel As Integer

    Private Sub FrmRptPurchaseRetPara_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cal.Hide()
        Me.MdiParent = FrmMain
        sel = 0
    End Sub

    Private Sub BtnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreate.Click
        Cal.Hide()
        If TxtstDate.Text = "" And TxtEndDate.Text = "" Then
            MsgBox("Please Insert Date for Generate Report ", MsgBoxStyle.OkOnly)
        Else

            Dim rpt As New PurchaseReturn   'The report you created.
            Dim con As New DataConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()

            Dim myDS As New DataSet()        'The DataSet you created. 
            Try
                con.OpenConnection()
                MyCommand.Connection = con.sqlcon

                MyCommand.CommandText = "SELECT * FROM purchase_ret where pur_ret_date > '" & CDate(TxtstDate.Text) & "' and pur_ret_date < '" & CDate(TxtEndDate.Text) & "';"
                myDA.SelectCommand = MyCommand
                myDA.Fill(myDS, "purchase_ret")
                MyCommand.CommandText = "SELECT * FROM purchase_ret_detail ;"
                myDA.SelectCommand = MyCommand
                myDA.Fill(myDS, "purchase_ret_detail")

                rpt.SetDataSource(myDS)
                CrystalReportViewer1.ReportSource = rpt
            Catch Excep As Exception
                MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Cal_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Cal.DateSelected
        If sel = 1 Then
            TxtstDate.Text = Cal.SelectionStart
        ElseIf sel = 2 Then
            TxtEndDate.Text = Cal.SelectionStart
        End If

        Cal.Hide()
    End Sub

    Private Sub Cal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, CrystalReportViewer1.Click, Label1.Click, Label2.Click, TxtEndDate.Click, TxtstDate.Click
        If sel = 1 Then
            TxtstDate.Text = Cal.TodayDate
        ElseIf sel = 2 Then
            TxtEndDate.Text = Cal.TodayDate
        End If
        Cal.Hide()
    End Sub

    Private Sub BtnShow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow1.Click
        Cal.Location = New Point(245, 40)
        Cal.Show()
        sel = 1
    End Sub

    Private Sub BtnShow2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow2.Click
        Cal.Location = New Point(425, 40)
        Cal.Show()
        sel = 2
    End Sub

    Private Sub BtnCreate_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnCreate.MouseDown
        Try
            Dim img As Image
            img = Image.FromFile("Btn\printpreview_down.png")
            BtnCreate.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnCreate_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCreate.MouseHover, BtnCreate.GotFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\printpreview_over.png")
            BtnCreate.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnCreate_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCreate.MouseLeave, BtnCreate.LostFocus
        Try
            Dim img As Image
            img = Image.FromFile("Btn\printpreview_out.png")
            BtnCreate.BackgroundImage = img
        Catch ex As Exception
        End Try
    End Sub
End Class
