Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmLogin
    Dim xConn As sqlConn
    Dim userID, userType, userNum As New Label

    Private Sub frmLogin_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From UserInfo;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try

        txt_UserName.Focus()
        If My.Settings.check_box = True Then
            txt_UserName.Text = My.Settings.user_id
            chk_Remember.Checked = True
        Else
            txt_UserName.Text = ""
            chk_Remember.Checked = False
        End If
    End Sub

    Public Function ask()
        Dim dt As New DataTable
        Dim ds As New DataSet

        ds.Tables.Add(dt)
        xConn.UserSQLComm.Connection = xConn.UserSQLConn
        Dim da As New SqlDataAdapter("Select * From UserInfo", xConn.UserSQLConn)
        da.Fill(dt)

        For Each _DataRow In dt.Rows
            If txt_UserName.Text = _DataRow.item(2) And txt_Password.Text = _DataRow(3) Then
                xConn.UserSQLConn.Close()
                Return True
            End If
        Next
        xConn.UserSQLConn.Close()
        Return False
    End Function

    Private Sub userDetails()
        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From UserInfo Where UserID like '%" & txt_UserName.Text & "%';")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                userNum.Text = d("UserNum".ToString)
                userID.Text = d("UserID".ToString)
                userType.Text = d("UserType".ToString)
            Loop
            Try
                xConn.UserSQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            End Try
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        If txt_UserName.Text = "" Then
            MsgBox("请输入帐号。", MsgBoxStyle.Exclamation, "错误")
        ElseIf txt_Password.Text = "" Then
            MsgBox("请输入密码。", MsgBoxStyle.Exclamation, "错误")
        Else
            Try
                xConn = New sqlConn()
                xConn.connectUser("Select * From UserInfo Where UserID = '" & txt_UserName.Text & "';")

                xConn.UserSQLComm.Connection = xConn.UserSQLConn
                Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
                Do While d.Read
                    userNum.Text = d("UserNum".ToString)
                    userID.Text = d("UserID".ToString)
                    userType.Text = d("UserType".ToString)
                Loop
                Try
                    xConn.UserSQLConn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
                End Try
            Catch ex As Exception
                'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

            If ask() = True Then
                frmCP.lbl_Welcome.Text = "热烈欢迎 " & txt_UserName.Text & " 光临"
                frmCP.myUserName = txt_UserName.Text
                frmCP.userNum = userNum.Text
                frmCP.userType = userType.Text

                xConn.UserSQLConn.Close()
                Me.Hide()
                frmCP.Show()

                If chk_Remember.Checked = True Then
                    My.Settings.user_id = txt_UserName.Text
                    My.Settings.check_box = True
                    My.Settings.Save()
                Else
                    My.Settings.user_id = ""
                    My.Settings.check_box = False
                    My.Settings.Save()
                End If
            Else
                MsgBox("您输入的帐号或密码不正确。", MsgBoxStyle.Exclamation, "错误")
                txt_UserName.Clear()
                txt_Password.Clear()
                txt_UserName.Focus()
            End If
        End If
    End Sub

    Private Sub txt_UserName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_UserName.TextChanged
        userDetails()
    End Sub

    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        frmLoad.Hide()
    End Sub

    Private Sub btn_Register_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Register.Click
        frmRegister.Show()
        frmRegister.from = "Login"
    End Sub

    Private Sub lbl_ForgotPwd_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbl_ForgotPwd.LinkClicked
        frmFgtPwd.Show()
    End Sub
End Class