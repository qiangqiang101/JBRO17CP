Public Class frmAdCPMain
    Private Sub tsmSetting_Click(sender As Object, e As EventArgs) Handles tsmSetting.Click
        Try
            Dim newForm As frmAdSetting = New frmAdSetting
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsmUser_Click(sender As Object, e As EventArgs) Handles tsmUser.Click
        Try
            Dim newForm As frmAdUserSetting = New frmAdUserSetting
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmAdCPMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub tsmTransaction_Click(sender As Object, e As EventArgs) Handles tsmTransaction.Click
        Try
            Dim newForm As frmAdTransaction = New frmAdTransaction
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub
End Class