Public Class HelpWindow
    Private Sub LinkLabelGoogle_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelGoogle.LinkClicked
        LinkLabelGoogle.LinkVisited = True
        System.Diagnostics.Process.Start("http://www.google.es")
    End Sub
End Class