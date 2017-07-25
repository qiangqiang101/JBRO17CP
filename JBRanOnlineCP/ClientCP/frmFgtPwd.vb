Imports System.Net.Mail
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmFgtPwd

    Dim xConn As sqlConn
    Dim userID, userEmail, userPass As New Label
    Dim nl As String = Environment.NewLine

    'Settings
    Public EmailAddr As String '= "no-reply@zettabytetek.com"
    Public Password As String '= "5zpRFE0Q"
    Public Port As Integer '= 587
    Public Host As String '= "mail.zettabytetek.com"
    Public Subject As String '= "新劲爆乱Online - 找回密码"

    Dim failed As Boolean = False

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        If txt_UserName.Text = "" Then
            MsgBox("请输入帐号。", MsgBoxStyle.Exclamation, "错误")
        Else
            Try
                xConn = New sqlConn()
                xConn.connectUser("Select * From UserInfo Where UserID = '" & txt_UserName.Text & "';")

                xConn.UserSQLComm.Connection = xConn.UserSQLConn
                Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
                Do While d.Read
                    userEmail.Text = d("UserEmail".ToString)
                    userID.Text = d("UserID".ToString)
                    userPass.Text = d("UserPass".ToString)
                Loop
                Try
                    xConn.UserSQLConn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
                End Try
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            End Try

            If askUser() = True Then
                SendEmail(userID.Text, userPass.Text, userEmail.Text)
            Else
                MsgBox("您输入的帐号不正确。", MsgBoxStyle.Exclamation, "错误")
            End If
        End If
    End Sub

    Public Function askUser()
        Dim dt As New DataTable
        Dim ds As New DataSet

        ds.Tables.Add(dt)
        xConn.UserSQLComm.Connection = xConn.UserSQLConn
        Dim da As New SqlDataAdapter("Select * From UserInfo", xConn.UserSQLConn)
        da.Fill(dt)

        For Each _DataRow In dt.Rows
            If txt_UserName.Text = _DataRow.item(2) Then
                xConn.UserSQLConn.Close()
                Return True
            End If
        Next
        xConn.UserSQLConn.Close()
        Return False
    End Function

    Private Sub frmFgtPwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub frmFgtPwd_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Show()
    End Sub

    Private Sub SendEmail(ByVal _UserId As String, ByVal _UserPass As String, ByVal _UserEmail As String)
        Try
            Dim smtpServer As New SmtpClient
            Dim email As New MailMessage()
            smtpServer.UseDefaultCredentials = False
            smtpServer.Credentials = New Net.NetworkCredential(EmailAddr, Password)
            smtpServer.Port = Port
            smtpServer.EnableSsl = False
            smtpServer.Host = Host

            email = New MailMessage()
            email.From = New MailAddress(EmailAddr)
            email.To.Add(_UserEmail)
            email.Subject = Subject
            email.IsBodyHtml = False
            email.Body = "尊敬的 " & _UserId & nl & nl & "您收到这封电子邮件是因为您最近找回密码，如果非本人操作，请尽快修改密码！" & nl & nl & "密码：" & _UserPass
            smtpServer.Send(email)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            failed = True
        Finally
            If Not failed = True Then MsgBox("您的密码已经发送到 " & _UserEmail, MsgBoxStyle.Exclamation, "错误")
            Me.Close()
        End Try
    End Sub

    Private Sub RefreshData()
        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From CPSetting;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                EmailAddr = d("EmailAddr")
                Password = d("EmailPwd")
                Port = d("EmailPort")
                Host = d("EmailHost")
                Subject = d("EmailSubject")
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub
End Class