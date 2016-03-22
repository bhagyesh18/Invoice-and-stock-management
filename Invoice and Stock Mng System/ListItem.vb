Module ListItem

    Public str As String

    Sub List()
        Dim dsitem As New DataSet
        Dim con As New DataConnection
        Dim row As Integer

        Try
            con.OpenConnection()
            dsitem.Clear()
            dsitem = con.FillDataTable("item")

            str = ""
            For row = 0 To dsitem.Tables(0).Rows.Count - 1
                str &= "  >> " & dsitem.Tables(0).Rows(row).Item(1).ToString & " "
                str &= dsitem.Tables(0).Rows(row).Item(0).ToString & " "
                str &= "(" & dsitem.Tables(0).Rows(row).Item(2).ToString & ") "
                str &= "(" & dsitem.Tables(0).Rows(row).Item(3).ToString & ") "

                'If Val(dsitem.Tables(0).Rows(row).Item(2).ToString) < Val(dsitem.Tables(0).Rows(row).Item(3).ToString) Then
                '    txtbox.ForeColor = Color.Red
                'Else
                '    txtbox.ForeColor = Color.Green
                'End If
            Next

            'str &= " ~ ~ ~ ~ ~ "
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            con.CloseConnection()
        End Try
    End Sub
End Module
