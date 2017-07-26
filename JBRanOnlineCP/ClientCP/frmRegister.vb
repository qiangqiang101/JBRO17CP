Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmRegister

    Dim xConn As sqlConn
    Dim r As Random = New Random
    Public from As String = Nothing

    'Settings
    Public CharRemain As Integer = 2
    Public CharTestRemain As Integer = 2
    Public PasswordEncrypt As Integer = 0

    Private Sub frmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshData()
        lbl_CODE.Text = r.Next(1, 9999)
        txt_UserName.Focus()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txt_UserName.Text = "" Then
            MsgBox("请输入帐号。", MsgBoxStyle.Critical, "错误")
            txt_UserName.Focus()
        ElseIf txt_Pass1.Text = "" Or txt_Pass2.Text = "" Then
            MsgBox("请输入密码。", MsgBoxStyle.Critical, "错误")
            txt_Pass1.Focus()
        ElseIf txt_Pass1.Text <> txt_Pass2.Text Then
            MsgBox("两次输入的密码不同，请重新输入！", MsgBoxStyle.Critical, "错误")
            txt_Pass1.Clear()
            txt_Pass2.Clear()
            txt_Pass1.Focus()
        ElseIf txt_Email.Text = "" Then
            MsgBox("请输入有效的电子邮件。", MsgBoxStyle.Critical, "错误")
            txt_Email.Focus()
        ElseIf txt_2ndPass1.Text = "" Or txt_2ndPass2.Text = "" Then
            MsgBox("请输入删除角色密码。", MsgBoxStyle.Critical, "错误")
            txt_2ndPass1.Focus()
        ElseIf txt_2ndPass1.Text <> txt_2ndPass2.Text Then
            MsgBox("两次输入的删除角色密码不同，请重新输入！", MsgBoxStyle.Critical, "错误")
            txt_2ndPass1.Clear()
            txt_2ndPass2.Clear()
            txt_2ndPass1.Focus()
        ElseIf txt_Verification.Text = "" Then
            MsgBox("请输入验证码。", MsgBoxStyle.Critical, "错误")
            txt_Verification.Focus()
        ElseIf txt_Verification.Text <> lbl_CODE.Text Then
            MsgBox("输入的验证码不正确，请重新输入。", MsgBoxStyle.Critical, "错误")
            txt_Verification.Clear()
            txt_Verification.Focus()
        ElseIf check() = True Then
            MsgBox("您输入的帐号已存在！", MsgBoxStyle.Critical, "错误")
            txt_UserName.Clear()
            txt_UserName.Focus()
        Else
            Try
                xConn = New sqlConn()
                Select Case PasswordEncrypt
                    Case 1
                        xConn.connectUser("Insert Into UserInfo (UserName, UserID, UserPass, UserPass2, UserType, UserAvailable, ChaRemain, ChaTestRemain, UserEmail) Values (" _
                                  & "'" & txt_UserName.Text & "', " _
                                  & "'" & txt_UserName.Text & "', " _
                                  & "'" & Md5FromString(txt_Pass1.Text) & "', " _
                                  & "'" & Md5FromString(txt_2ndPass1.Text) & "', " _
                                  & "'1', '1', '" & CharRemain & "', '" & CharTestRemain & "', " _
                                  & "'" & txt_Email.Text & "');")
                    Case 0
                        xConn.connectUser("Insert Into UserInfo (UserName, UserID, UserPass, UserPass2, UserType, UserAvailable, ChaRemain, ChaTestRemain, UserEmail) Values (" _
                                  & "'" & txt_UserName.Text & "', " _
                                  & "'" & txt_UserName.Text & "', " _
                                  & "'" & txt_Pass1.Text & "', " _
                                  & "'" & txt_2ndPass1.Text & "', " _
                                  & "'1', '1', '" & CharRemain & "', '" & CharTestRemain & "', " _
                                  & "'" & txt_Email.Text & "');")
                End Select


                xConn.UserSQLComm.Connection = xConn.UserSQLConn
                xConn.UserSQLComm.ExecuteNonQuery()
                xConn.UserSQLConn.Close()

                MsgBox("帐号注册成功，您的帐号是 " & txt_UserName.Text & ".", MsgBoxStyle.Information, "成功")
                lbl_CODE.Text = r.Next(1, 9999)
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            End Try
        End If
    End Sub

    Private Sub btn_Check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Check.Click
        Try
            If check() = True Then
                MsgBox("您输入的帐号已存在！", MsgBoxStyle.Exclamation, "错误")
                txt_UserName.Clear()
                txt_UserName.Focus()
            Else
                MsgBox("您输入的帐号可使用。", MsgBoxStyle.Information, "帐号注册")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Public Function check()
        xConn = New sqlConn()
        xConn.connectUser("Select * From UserInfo Where UserID = '" & txt_UserName.Text & "';")

        xConn.UserSQLComm.Connection = xConn.UserSQLConn

        Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
        Do While d.Read
            If d("UserID") = txt_UserName.Text Then
                Return True
            Else
                Return False
            End If
        Loop
        xConn.UserSQLConn.Close()
        Return False
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub RefreshData()
        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From CPSetting;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                CharRemain = d("CharRemain")
                CharTestRemain = d("CharTestRemain")
                PasswordEncrypt = d("PasswordEncrypt")
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub frmRegister_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        frmLoad.Hide()
    End Sub

    Private Sub frmRegister_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Select Case from
            Case "Load"
                End
            Case "Login"
                frmLogin.Show()
        End Select
    End Sub
End Class