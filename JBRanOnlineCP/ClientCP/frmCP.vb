Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmCP

    Dim xConn As sqlConn

    Public userType As Integer
    Public userNum As Integer
    Public myPoint As Integer
    Public myUserName As String
    Dim nl As String = Environment.NewLine

    Private ChaIntel As Integer = 0
    Private ChaLevel As Integer = 0
    Private ChaMoney As Integer = 0
    Private ChaStRemain As Integer = 0
    Private ChaRBDate As Date
    Private ChaSchool As Integer = 0
    Private ChaBright As Integer = 0
    Private ChaCNDate As Date

    'Settings
    Public FormName As String '= "新劲爆乱Online - 控制面板"

    Private Sub frmCP_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim result As Integer = MessageBox.Show("你确定要离开？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            'If xConn.GameSQLConn.State = ConnectionState.Open Then xConn.GameSQLConn.Close()
            'If xConn.UserSQLConn.State = ConnectionState.Open Then xConn.UserSQLConn.Close()
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmCP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = FormName & " - 控制面板"

        If userType = 2 Then
            lbl_Member.Text = "会员: 黄金会员"
        ElseIf userType = 32 Then
            lbl_Member.Text = "会员: 游戏管理员"
        Else
            lbl_Member.Text = "会员: 普通会员"
        End If

        Try
            Dim newForm As frmNotice = New frmNotice
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Public Function OnlineCheck(ByVal _ChaName As String)
        xConn = New sqlConn()
        xConn.connectGame("Select * From ChaInfo Where ChaName = '" & _ChaName & "';")

        xConn.GameSQLComm.Connection = xConn.GameSQLConn

        Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
        Do While d.Read
            If d("ChaOnline") = 1 Then
                Return True
            Else
                Return False
            End If
        Loop
        xConn.GameSQLConn.Close()
        Return False
    End Function

    Private Sub fbNotice_Click(sender As Object, e As EventArgs) Handles fbNotice.Click
        Try
            Dim newForm As frmNotice = New frmNotice
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fbReborn_Click(sender As Object, e As EventArgs) Handles fbReborn.Click
        Try
            Dim newForm As frmReborn = New frmReborn
            newForm.txt_RBUserName.Text = myUserName
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fbAddPoint_Click(sender As Object, e As EventArgs) Handles fbAddPoint.Click
        Try
            Dim newForm As frmAddPoint = New frmAddPoint
            newForm.txt_JDUserName.Text = myUserName
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fbResetPoint_Click(sender As Object, e As EventArgs) Handles fbResetPoint.Click
        Try
            Dim newForm As frmClearPoint = New frmClearPoint
            newForm.txt_XDUserName.Text = myUserName
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fbChgSchool_Click(sender As Object, e As EventArgs) Handles fbChgSchool.Click
        Try
            Dim newForm As frmChgSchool = New frmChgSchool
            newForm.txt_ZXUserName.Text = myUserName
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fbClearRed_Click(sender As Object, e As EventArgs) Handles fbClearRed.Click
        Try
            Dim newForm As frmClearRed = New frmClearRed
            newForm.txt_PKUserName.Text = myUserName
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fbRename_Click(sender As Object, e As EventArgs) Handles fbRename.Click
        Try
            Dim newForm As frmRename = New frmRename
            newForm.txt_CNUserName.Text = myUserName
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fbKick_Click(sender As Object, e As EventArgs) Handles fbKick.Click
        Try
            Dim newForm As frmSelfHelp = New frmSelfHelp
            newForm.txt_SHUserName.Text = myUserName
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fbRanking_Click(sender As Object, e As EventArgs) Handles fbRanking.Click
        Try
            Dim newForm As frmRanking = New frmRanking
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub llblChgPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblChgPass.LinkClicked
        Try
            Dim newForm As frmChgPass = New frmChgPass
            newForm.txt_CPUserName.Text = myUserName
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim result As Integer = MessageBox.Show("你确定要登出？", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                'If xConn.GameSQLConn.State = ConnectionState.Open Then xConn.GameSQLConn.Close()
                'If xConn.UserSQLConn.State = ConnectionState.Open Then xConn.UserSQLConn.Close()
                frmLogin.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub
End Class