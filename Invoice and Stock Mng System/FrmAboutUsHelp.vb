Public Class FrmAboutUsHelp

    Private Sub FrmAboutUsHelp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain
    End Sub

    Private Sub FrmAboutUsHelp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Close()
    End Sub
End Class