Imports System.Net.Mail

Public Class SendMail
    Public Sub send(ByVal receiverId As String, ByVal subject As String, ByVal content As String)
        Try
            Dim smtp As New SmtpClient("smtp.gmail.com", 587)
            Dim sendTo As New MailAddress(Trim(receiverId))
            Dim sentFrom As New MailAddress("newwaytechsolution@gmail.com")
            Dim message As New MailMessage(sentFrom, sendTo)
            message.Subject = subject
            message.Body = content
            message.IsBodyHtml = True
            Dim auth As New Net.NetworkCredential("newwaytechsolution@gmail.com", "Newinfocom123")
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network
            smtp.UseDefaultCredentials = False
            smtp.EnableSsl = True
            smtp.Credentials = auth
            smtp.Send(message)
            MsgBox("Message sent")
        Catch ex As Exception
            MsgBox("Your Internet Connection is Unpluged " & vbCrLf & Err.Description, MsgBoxStyle.Exclamation, "Fail")
        End Try
    End Sub
End Class
