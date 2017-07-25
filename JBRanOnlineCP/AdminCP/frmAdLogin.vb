Public Class frmAdLogin

    Public AdminPass As String

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        If txt_Password.Text = "" Then
            MsgBox("请输入密码。", MsgBoxStyle.Exclamation, "错误")
            txt_Password.Focus()
        ElseIf txt_Password.Text <> AdminPass Then
            MsgBox("密码错误，请重新输入。", MsgBoxStyle.Exclamation, "错误")
            txt_Password.Clear()
            txt_Password.Focus()
        Else
            frmAdCPMain.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub frmAdminLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub frmAdLogin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        frmLoad.Hide()
    End Sub

End Class