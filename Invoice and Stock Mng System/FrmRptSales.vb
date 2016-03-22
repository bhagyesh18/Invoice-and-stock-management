Imports System.Data.SqlClient
Public Class FrmRptSales

    Private Sub FrmRptSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain
        Dim rpt As New SalesItem    'The report you created.
        Dim con As New DataConnection
        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()

        Dim myDS As New DataSet() 'The DataSet you created.
        Try
            con.OpenConnection()
            MyCommand.Connection = con.sqlcon

            MyCommand.CommandText = "SELECT * FROM sales;"
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "sales")

            MyCommand.CommandText = "SELECT * FROM sales_detail;"
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "sales_detail")

            rpt.SetDataSource(myDS)
            CrystalReportViewer1.ReportSource = rpt

        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class