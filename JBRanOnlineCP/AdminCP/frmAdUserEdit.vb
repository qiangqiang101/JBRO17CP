Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class frmAdUserEdit

    Dim xConn As sqlConn
    Public UserNum As New Label

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            xConn = New sqlConn()
            xConn.connectUser("Update UserInfo Set " &
                              "[UserID] = '" & txt_UserID.Text & "', " &
                              "[UserPass] = '" & txt_UserPass.Text & "', " &
                               "[UserPass2] = '" & txt_UserPass2.Text & "', " &
                               "[ChaName] = '" & txt_ChaName.Text & "', " &
                               "[ChaRemain] = '" & txt_ChaRemain.Text & "', " &
                               "[UserEmail] = '" & txt_UserEmail.Text & "', " &
                                "[UserPoint] = '" & txt_UserPoint.Text & "', " &
                                "[UserBlock] = '" & Convert.ToInt32(cbBanned.Checked) & "', " &
                                "[UserType] = '" & txt_UserType.Text & "' " &
                                "Where UserNum = " & UserNum.Text & ";")
            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            xConn.UserSQLComm.ExecuteNonQuery()
            xConn.UserSQLConn.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub btnMD5_Click(sender As Object, e As EventArgs) Handles btnMD5.Click
        txt_UserPass.Text = Md5FromString(txt_UserPass.Text)
    End Sub

    Private Sub btnMD5_2_Click(sender As Object, e As EventArgs) Handles btnMD5_2.Click
        txt_UserPass2.Text = Md5FromString(txt_UserPass2.Text)
    End Sub
End Class