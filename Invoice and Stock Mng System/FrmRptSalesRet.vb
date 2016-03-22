Imports System.Data.SqlClient
Public Class FrmRptSalesRet

    Private Sub FrmRptSalesRet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain
        Dim rpt As New SalesReturn     'The report you created.
        Dim con As New DataConnection
        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()

        Dim myDS As New DataSet() 'The DataSet you created.
        Try
            con.OpenConnection()
            MyCommand.Connection = con.sqlcon
            MyCommand.CommandText = "SELECT * FROM sales_ret;"
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "sales_ret")
            MyCommand.CommandText = "SELECT * FROM sales_ret_detail;"
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "sales_ret_detail")
            rpt.SetDataSource(myDS)
            CrystalReportViewer1.ReportSource = rpt
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class