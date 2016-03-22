Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmRptPurchaseRet

    Private Sub FrmRptPurchaseRet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain
        Dim rpt As New PurchaseReturn    'The report you created.
        Dim con As New DataConnection
        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()

        Dim myDS As New DataSet() 'The DataSet you created.
        Try
            con.OpenConnection()
            MyCommand.Connection = con.sqlcon
            MyCommand.CommandText = "SELECT * FROM purchase_ret"
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "purchase_ret")
            MyCommand.CommandText = "SELECT * FROM purchase_ret_detail"
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "purchase_ret_detail")
            rpt.SetDataSource(myDS)
            CrystalReportViewer1.ReportSource = rpt
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class