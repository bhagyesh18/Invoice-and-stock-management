Public Class FrmSysHelp
    Dim ind As Integer
    Private Sub FrmSysHelp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain
        LBHelp.SelectedIndex = 0
        LBHelp.Focus()
    End Sub

    Private Sub LBHelp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBHelp.SelectedIndexChanged
        ind = LBHelp.SelectedIndex
        RTBHelp.LoadFile("Help\" & ind & ".rtf")
    End Sub

    Private Sub RTBHelp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RTBHelp.GotFocus
        LBHelp.Focus()
    End Sub
End Class