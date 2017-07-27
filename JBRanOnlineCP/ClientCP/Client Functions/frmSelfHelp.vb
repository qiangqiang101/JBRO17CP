Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmSelfHelp

    Dim xConn As sqlConn
    Private UserLoginState As Integer = 0

    Private Sub btn_SelfHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelfHelp.Click
        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From UserInfo Where UserID = '" & txt_SHUserName.Text & "';")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                UserLoginState = d("UserLoginState".ToString)
            Loop
            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try

        If UserLoginState = 0 Then
            MsgBox("帐号并没有在线！", MsgBoxStyle.Information, "错误")
        Else
            Try
                xConn = New sqlConn()
                xConn.connectUser("Update UserInfo Set " &
                                  "[UserLoginState] = '0' Where UserID = '" & txt_SHUserName.Text & "';")

                xConn.UserSQLComm.Connection = xConn.UserSQLConn
                xConn.UserSQLComm.ExecuteNonQuery()

                MsgBox("正好已经下线赶快进游戏看看吧！", MsgBoxStyle.Information, "自救")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            End Try
        End If
    End Sub
End Class