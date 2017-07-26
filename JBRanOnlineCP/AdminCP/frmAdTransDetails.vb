Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmAdTransDetails

    Public amount As Integer
    Public curency As String

    Dim xConn As sqlConn
    Dim items As New ListViewItem()

    Private Sub frmAdTransDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Processing()

        Select Case lblStatus.Text
            Case "批准", "拒绝"
                btnApprove.Enabled = False
                btnReject.Enabled = False
                cmbRejectReason.Enabled = False
        End Select
    End Sub

    Private Sub Processing()
        Try
            If lblStatus.Text = "新建" Then
                xConn = New sqlConn()
                xConn.connectUser("Update CPTransaction Set [Status]='Processing' Where ID = " & lblID.Text & ";")
                xConn.UserSQLComm.Connection = xConn.UserSQLConn
                xConn.UserSQLComm.ExecuteNonQuery()
                xConn.UserSQLConn.Close()
                lblStatus.Text = "处理中"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Try
            If lblStatus.Text = "处理中" Then
                xConn = New sqlConn()
                xConn.connectUser("Update CPTransaction Set [Status]='Approve' Where ID = " & lblID.Text & ";")
                xConn.UserSQLComm.Connection = xConn.UserSQLConn
                xConn.UserSQLComm.ExecuteNonQuery()
                xConn.UserSQLConn.Close()

                UpdateUserPoint()
                lblStatus.Text = "批准"

                btnApprove.Enabled = False
                btnReject.Enabled = False
                cmbRejectReason.Enabled = False
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If String.IsNullOrEmpty(cmbRejectReason.Text) Then
            MsgBox("请选择一个拒绝理由。", MsgBoxStyle.Critical, "错误")
        Else
            Try
                If lblStatus.Text = "处理中" Then
                    xConn = New sqlConn()
                    xConn.connectUser("Update CPTransaction Set [Status]='Reject', [Reason]='" & cmbRejectReason.Text & "' Where ID = " & lblID.Text & ";")
                    xConn.UserSQLComm.Connection = xConn.UserSQLConn
                    xConn.UserSQLComm.ExecuteNonQuery()
                    xConn.UserSQLConn.Close()

                    lblStatus.Text = "拒绝"

                    btnApprove.Enabled = False
                    btnReject.Enabled = False
                    cmbRejectReason.Enabled = False
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            End Try
        End If
    End Sub

    Private Function GetUserPoint()
        Dim result As Integer = 0

        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From UserInfo Where UserName='" & lblUserName.Text & "';")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                result = d("UserPoint")
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try

        Return result
    End Function

    Private Sub UpdateUserPoint()
        Dim currentPoint As Integer = GetUserPoint()
        Dim newPoint As Integer = currentPoint + ConvertMoney2Point(amount)

        xConn = New sqlConn()
        xConn.connectUser("Update UserInfo Set [UserType]='2', [UserPoint]='" & newPoint & "' Where UserName='" & lblUserName.Text & "';")
        xConn.UserSQLComm.Connection = xConn.UserSQLConn
        xConn.UserSQLComm.ExecuteNonQuery()
        xConn.UserSQLConn.Close()
    End Sub

    Private Function ConvertMoney2Point(amount As Integer)
        Dim result As Integer = 0
        Select Case curency
            Case "马币"
                result = amount * 10
            Case "新币"
                result = amount * 31
        End Select

        Return result
    End Function
End Class