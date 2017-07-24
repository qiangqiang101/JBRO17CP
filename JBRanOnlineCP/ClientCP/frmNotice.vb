Public Class frmNotice
    Private Sub frmNotice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(ReadCfgValue("cpNews", My.Application.Info.DirectoryPath & "\param.cfg"))
    End Sub
End Class