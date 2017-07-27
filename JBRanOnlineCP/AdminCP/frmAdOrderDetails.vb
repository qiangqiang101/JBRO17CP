Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmAdOrderDetails

    Public amount As Integer
    Public curency As Integer

    Dim xConn As sqlConn
    Dim items As New ListViewItem()

    Private Sub frmAdOrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Processing()

        Select Case lblStatus.Text
            Case "批准", "拒绝"
                btnApprove.Enabled = False
                btnReject.Enabled = False
            Case "取消"
                btnApprove.Enabled = False
                btnReject.Enabled = True
        End Select
    End Sub

    Private Sub Processing()
        Try
            If lblStatus.Text = "新建" Then
                xConn = New sqlConn()
                xConn.connectUser("Update CPOrder Set [OrderStatus]='Processing' Where OrderID = " & lblID.Text & ";")
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
                xConn.connectUser("Update CPOrder Set [OrderStatus]='Approve' Where OrderID = " & lblID.Text & ";")
                xConn.UserSQLComm.Connection = xConn.UserSQLConn
                xConn.UserSQLComm.ExecuteNonQuery()
                xConn.UserSQLConn.Close()

                lblStatus.Text = "批准"

                btnApprove.Enabled = False
                btnReject.Enabled = False
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Try
            Select Case lblStatus.Text
                Case "处理中", "取消"
                    xConn = New sqlConn()
                    xConn.connectUser("Update CPOrder Set [OrderStatus]='Reject' Where OrderID = " & lblID.Text & ";")
                    xConn.UserSQLComm.Connection = xConn.UserSQLConn
                    xConn.UserSQLComm.ExecuteNonQuery()
                    xConn.UserSQLConn.Close()

                    Select Case curency
                        Case 0
                            UpdateUserMoney()
                        Case 1
                            UpdateUserPoint()
                    End Select

                    lblStatus.Text = "拒绝"

                    btnApprove.Enabled = False
                    btnReject.Enabled = False
                    Me.Close()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message + ex.StackTrace, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Function GetUserPoint() As Integer
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
        Dim newPoint As Integer = currentPoint + amount

        xConn = New sqlConn()

        Select Case frmCP.userType
            Case 32
                xConn.connectUser("Update UserInfo Set [UserPoint]='" & newPoint & "' Where UserName='" & lblUserName.Text & "';")
            Case Else
                xConn.connectUser("Update UserInfo Set [UserType]='2', [UserPoint]='" & newPoint & "' Where UserName='" & lblUserName.Text & "';")
        End Select

        xConn.UserSQLComm.Connection = xConn.UserSQLConn
        xConn.UserSQLComm.ExecuteNonQuery()
        xConn.UserSQLConn.Close()
    End Sub

    Private Function GetUserMoney() As Integer
        Dim result As Integer = 0

        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where ChaName='" & lblCharName.Text & "';")

            xConn.GameSQLComm.Connection = xConn.GameSQLConn
            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                result = d("ChaMoney")
            Loop

            xConn.GameSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try

        Return result
    End Function

    Private Sub UpdateUserMoney()
        Dim currentMoney As Integer = GetUserMoney()
        Dim newMoney As Integer = currentMoney + amount

        xConn = New sqlConn()
        xConn.connectGame("Update ChaInfo Set [ChaMoney]='" & newMoney & "' Where ChaName='" & lblCharName.Text & "';")
        xConn.GameSQLComm.Connection = xConn.GameSQLConn
        xConn.GameSQLComm.ExecuteNonQuery()
        xConn.GameSQLConn.Close()
    End Sub
End Class