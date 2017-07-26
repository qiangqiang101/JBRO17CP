Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmChgPass
    Dim xConn As sqlConn

    Dim r As Random = New Random
    Public PasswordEncrypt As Integer = 0

    Private Sub frmChgPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_CODE.Text = r.Next(1, 9999)

        RefreshData()
        RefreshData2()
    End Sub

    Private Sub btn_ChgPwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ChgPwd.Click
        Dim OldPwd As String = Nothing

        Select Case PasswordEncrypt
            Case 1
                Try
                    xConn = New sqlConn()
                    xConn.connectUser("Select * From UserInfo Where UserID = '" & txt_CPUserName.Text & "';")

                    xConn.UserSQLComm.Connection = xConn.UserSQLConn
                    Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
                    Do While d.Read
                        OldPwd = d("UserPass".ToString)
                    Loop
                    xConn.UserSQLConn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
                End Try

                If txt_CPPassword.Text = "" Then
                    MsgBox("请输入密码。", MsgBoxStyle.Critical, "错误")
                    txt_CPPassword.Focus()
                ElseIf txt_CPNewPwd.Text = "" Or txt_CPNewPwd2.Text = "" Then
                    MsgBox("请输入新密码。", MsgBoxStyle.Critical, "错误")
                    txt_CPNewPwd.Focus()
                ElseIf Md5FromString(txt_CPPassword.Text) <> OldPwd Then
                    MsgBox("密码错误，请重新输入！", MsgBoxStyle.Critical, "错误")
                    txt_CPPassword.Clear()
                    txt_CPPassword.Focus()
                ElseIf txt_CPNewPwd.Text <> txt_CPNewPwd2.Text Then
                    MsgBox("两次输入的密码不同，请重新输入！", MsgBoxStyle.Critical, "错误")
                    txt_CPNewPwd.Clear()
                    txt_CPNewPwd2.Clear()
                    txt_CPNewPwd.Focus()
                ElseIf txt_CPVerification.Text = "" Then
                    MsgBox("请输入验证码。", MsgBoxStyle.Critical, "错误")
                    txt_CPVerification.Focus()
                ElseIf txt_CPVerification.Text <> lbl_CODE.Text Then
                    MsgBox("输入的验证码不正确，请重新输入。", MsgBoxStyle.Critical, "错误")
                    txt_CPVerification.Clear()
                    txt_CPVerification.Focus()
                Else
                    Try
                        xConn = New sqlConn()
                        xConn.connectUser("Update UserInfo Set " &
                                          "[UserPass] = '" & Md5FromString(txt_CPNewPwd.Text) & "' Where UserID = '" & txt_CPUserName.Text & "';")

                        xConn.UserSQLComm.Connection = xConn.UserSQLConn
                        xConn.UserSQLComm.ExecuteNonQuery()

                        MsgBox("密码修改成功！请记住新密码 " & txt_CPNewPwd.Text, MsgBoxStyle.Information, "密码")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
                    End Try
                End If
            Case 0
                Try
                    xConn = New sqlConn()
                    xConn.connectUser("Select * From UserInfo Where UserID = '" & txt_CPUserName.Text & "';")

                    xConn.UserSQLComm.Connection = xConn.UserSQLConn
                    Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
                    Do While d.Read
                        OldPwd = d("UserPass".ToString)
                    Loop
                    xConn.UserSQLConn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
                End Try

                If txt_CPPassword.Text = "" Then
                    MsgBox("请输入密码。", MsgBoxStyle.Critical, "错误")
                    txt_CPPassword.Focus()
                ElseIf txt_CPNewPwd.Text = "" Or txt_CPNewPwd2.Text = "" Then
                    MsgBox("请输入新密码。", MsgBoxStyle.Critical, "错误")
                    txt_CPNewPwd.Focus()
                ElseIf txt_CPPassword.Text <> OldPwd Then
                    MsgBox("密码错误，请重新输入！", MsgBoxStyle.Critical, "错误")
                    txt_CPPassword.Clear()
                    txt_CPPassword.Focus()
                ElseIf txt_CPNewPwd.Text <> txt_CPNewPwd2.Text Then
                    MsgBox("两次输入的密码不同，请重新输入！", MsgBoxStyle.Critical, "错误")
                    txt_CPNewPwd.Clear()
                    txt_CPNewPwd2.Clear()
                    txt_CPNewPwd.Focus()
                ElseIf txt_CPVerification.Text = "" Then
                    MsgBox("请输入验证码。", MsgBoxStyle.Critical, "错误")
                    txt_CPVerification.Focus()
                ElseIf txt_CPVerification.Text <> lbl_CODE.Text Then
                    MsgBox("输入的验证码不正确，请重新输入。", MsgBoxStyle.Critical, "错误")
                    txt_CPVerification.Clear()
                    txt_CPVerification.Focus()
                Else
                    Try
                        xConn = New sqlConn()
                        xConn.connectUser("Update UserInfo Set " &
                                          "[UserPass] = '" & txt_CPNewPwd.Text & "' Where UserID = '" & txt_CPUserName.Text & "';")

                        xConn.UserSQLComm.Connection = xConn.UserSQLConn
                        xConn.UserSQLComm.ExecuteNonQuery()

                        MsgBox("密码修改成功！请记住新密码 " & txt_CPNewPwd.Text, MsgBoxStyle.Information, "密码")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
                    End Try
                End If
        End Select

        lbl_CODE.Text = r.Next(1, 9999)
    End Sub

    Private Sub RefreshData()
        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From CPSetting;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                PasswordEncrypt = d("PasswordEncrypt")
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub RefreshData2()
        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From UserInfo Where UserID = '" & txt_CPUserName.Text & "';")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                txtEmail.Text = d("UserEmail")
                txtName.Text = Nothing
                txtTel.Text = Nothing
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub btnUpdateInfo_Click(sender As Object, e As EventArgs) Handles btnUpdateInfo.Click
        If txtEmail.Text = "" Then
            MsgBox("输入电邮。。", MsgBoxStyle.Critical, "错误")
            txt_CPPassword.Focus()
        Else
            Try
                xConn = New sqlConn()
                xConn.connectUser("Update UserInfo Set " &
                                  "[UserEmail] = '" & txtEmail.Text & "' Where UserID = '" & txt_CPUserName.Text & "';")

                xConn.UserSQLComm.Connection = xConn.UserSQLConn
                xConn.UserSQLComm.ExecuteNonQuery()

                MsgBox("资料更新成功！", MsgBoxStyle.Information, "密码")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            End Try
        End If
    End Sub
End Class