Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmAdUserSetting

    Dim xConn As sqlConn
    Dim items As New ListViewItem()

    Private Sub btn_SearchUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SearchUser.Click
        Try
            lvUser.Items.Clear()
            xConn = New sqlConn()
            xConn.connectUser("Select * From UserInfo Where UserName Like '%" & txt_SearchUser.Text & "%';")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                items = lvUser.Items.Add(d("UserName".ToString))
                With items
                    .SubItems.Add(d("UserNum".ToString))
                    Dim _UserType As Integer = d("UserType")
                    Select Case _UserType
                        Case 32
                            .SubItems.Add("管理员")
                        Case 2
                            .SubItems.Add("黄金会员")
                        Case Else
                            .SubItems.Add("普通会员")
                    End Select
                    Dim _UserLoginState As Integer = d("UserLoginState")
                    Select Case _UserLoginState
                        Case 1
                            .SubItems.Add("在线")
                        Case 0
                            .SubItems.Add("离线")
                    End Select
                    .SubItems.Add(d("UserPoint"))
                End With
            Loop
            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub lvUser_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvUser.DoubleClick
        Try
            Dim newForm As frmAdUserEdit = New frmAdUserEdit
            frmAdCPMain.cpTab.TabPages.Add(newForm)


            xConn = New sqlConn()
            xConn.connectUser("Select * From UserInfo Where UserID = '" & lvUser.SelectedItems.Item(0).Text & "';")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                newForm.UserNum.Text = d("UserNum")
                newForm.txt_UserID.Text = d("UserID")
                newForm.Text = String.Format("{0} - 用户设置", d("UserID"))
                newForm.txt_UserPass.Text = d("UserPass")
                newForm.txt_UserPass2.Text = d("UserPass2")
                newForm.txt_ChaName.Text = d("ChaName")
                newForm.txt_ChaRemain.Text = d("ChaRemain")
                newForm.txt_UserEmail.Text = d("UserEmail")
                newForm.txt_UserPoint.Text = d("UserPoint")
                newForm.txt_UserType.Text = d("UserType")
            Loop
            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

End Class