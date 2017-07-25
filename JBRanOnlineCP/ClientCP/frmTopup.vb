Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmTopup

    Dim xConn As sqlConn

    Private Sub NumbericKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Amount.KeyPress
        Dim ValidChars As String = "0123456789."
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub frmTopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_Bank.SelectedIndex = 0
        cmb_Channel.SelectedIndex = 0
        cmb_Dollar.SelectedIndex = 0
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrEmpty(txt_Amount.Text) Then
            MsgBox("当前操作有误！", MsgBoxStyle.Critical, "错误")
        Else
            If txt_RefNo.Text = "" Then txt_RefNo.Text = "-"
            Try
                xConn = New sqlConn()
                xConn.connectUser("Insert Into CPTransaction (UserName, Bank, Amount, Currency, Channel, Status, RefSEQNo) " _
                    & "VALUES (" _
                                & "'" & txt_TUUserName.Text & "', " _
                                & "'" & cmb_Bank.SelectedItem & "', " _
                                & "'" & txt_Amount.Text & "', " _
                                & "'" & cmb_Dollar.SelectedItem & "', " _
                                & "'" & cmb_Channel.SelectedItem & "', " _
                                & "'" & "New" & "', " _
                                & "'" & txt_RefNo.Text & "');")
                xConn.UserSQLComm.Connection = xConn.UserSQLConn
                xConn.UserSQLComm.ExecuteNonQuery()
                xConn.UserSQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            Finally
                Try
                    Dim newForm As frmTransaction = New frmTransaction
                    frmCP.cpTab.TabPages.Add(newForm)
                Catch ex As Exception
                End Try
                Me.Close()
            End Try
        End If
    End Sub
End Class