Imports System.Data.SqlClient
Imports System.IO

Public Class DataConnection

    Public sqlcon As SqlConnection
    Dim sqladp As SqlDataAdapter
    Dim ds As New DataSet

    Public Sub OpenConnection()
        Try
            Dim di = Directory.GetCurrentDirectory
            If InStr(di, "\bin\Debug") Then
                di = di.Substring(0, di.IndexOf("\bin\Debug"))
            End If

            Dim str = "Data Source=.\SQLEXPRESS;AttachDbFilename=" & di & "\App_Data\InventoryData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"

            sqlcon = New SqlConnection(str)
            sqlcon.Open()
        Catch ex As Exception
            MessageBox.Show("Invalid Table Name", "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function FillDataTable(ByVal TableName As String) As DataSet
        Try
            sqladp = New SqlDataAdapter("select * from " + TableName, sqlcon)
            ds.Clear()
            sqladp.Fill(ds)
        Catch ex As Exception
            MessageBox.Show("Invalid Table Name", "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(Err.Description)
            MsgBox(ex.ToString)
        End Try
        Return (ds)
    End Function

    Public Function FillDataTableCustom(ByVal strcmd As String) As DataSet
        Try
            sqladp = New SqlDataAdapter(strcmd, sqlcon)
            ds.Clear()
            sqladp.Fill(ds)
        Catch ex As Exception
            MessageBox.Show("Invalid Table Name", "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(Err.Description)
        End Try
        Return (ds)
    End Function

    Public Sub CloseConnection()
        Try
            sqlcon.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class
