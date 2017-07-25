Public Class frmEncDec
    Private Sub btnEnc_Click(sender As Object, e As EventArgs) Handles btnEnc.Click
        txtEncEnc.Text = Encrypt(txtEncOri.Text)
    End Sub

    Private Sub btnDec_Click(sender As Object, e As EventArgs) Handles btnDec.Click
        txtDecOri.Text = Decrypt(txtDecEnc.Text)
    End Sub

    Private Sub frmEncDec_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub frmEncDec_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        frmLoad.Hide()
    End Sub
End Class