Public Class FrmEmail

    Private Sub FrmEmail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain
    End Sub

    Private Sub FrmEmail_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ToolTip.Active = False
    End Sub

    Private Sub FrmEmail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        ToolTip.Active = False
    End Sub

    Private Sub BtnSent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSent.Click
        Dim sm As New SendMail

        Try
            If TxtSendTo.Text = "" Then
                ToolTip.Active = True
                ToolTip.Show(" First Fill Send To Email Address ", TxtSendTo)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" First Fill Send To Email Address ", TxtSendTo)
                TxtSendTo.Focus()

                Exit Sub
            ElseIf TxtSub.Text = "" Then
                ToolTip.Active = True
                ToolTip.Show(" First Fill Subject of Email ", TxtSub)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" First Fill Subject of Email ", TxtSub)
                TxtSub.Focus()

                Exit Sub
            ElseIf RTxtBody.Text = "" Then
                ToolTip.Active = True
                ToolTip.Show(" First Write Email Body ", RTxtBody)
                ToolTip.Active = False
                ToolTip.Active = True
                ToolTip.Show(" First Write Email Body ", RTxtBody)
                RTxtBody.Focus()

                Exit Sub
            Else
                Dim i As Boolean = emailvalidator()

                If i = True Then
                    ToolTip.Active = True
                    ToolTip.Show(" Send To Email Address is Invalid" & vbCrLf & "or not in Valid Format ", TxtSendTo)
                    ToolTip.Active = False
                    ToolTip.Active = True
                    ToolTip.Show(" Send To Email Address is Invalid" & vbCrLf & "or not in Valid Format ", TxtSendTo)
                    TxtSendTo.Focus()
                Else
                    ToolTip.Active = False
                    sm.send(TxtSendTo.Text, TxtSub.Text, RTxtBody.Text)
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Function emailvalidator() As Boolean
        Dim s = TxtSendTo.Text
        Dim at As Integer = TxtSendTo.Text.IndexOf("@")
        Dim dot As Integer = TxtSendTo.Text.LastIndexOf(".")

        Dim dotstr() As String = TxtSendTo.Text.Split(".")
        Dim cou As Integer = dotstr.Length

        If (at > dot) Or (at < 0) Or (dot < 0) Or cou > 4 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class