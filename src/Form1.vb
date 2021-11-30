Public Class Form1

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Process.GetProcessesByName("Firefox")(0).Kill()
        Process.GetProcessesByName("Chrome")(0).Kill()
        Process.GetProcessesByName("Opera")(0).Kill()
        Process.GetProcessesByName("Tor")(0).Kill()
        Process.GetProcessesByName("Internet Explorer")(0).Kill()
        Process.GetProcessesByName("Edge")(0).Kill()

    End Sub
End Class
