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
                cpTab.TabPages.Clear()
                'If xConn.GameSQLConn.State = ConnectionState.Open Then xConn.GameSQLConn.Close()
                'If xConn.UserSQLConn.State = ConnectionState.Open Then xConn.UserSQLConn.Close()
                frmLogin.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RefreshData()
        UpdateData()
    End Sub

    Public Sub RefreshData()
        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From UserInfo Where UserName = '" & myUserName & "';")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                myPoint = d("UserPoint")
                userType = d("UserType")
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Public Sub UpdateData()
        Try
            Select Case userType
                Case 1
                    lbl_Member.Text = "会员: 普通会员"
                    If llblAdmin.Visible Then llblAdmin.Visible = False
                    If Label3.Visible Then Label3.Visible = False
                Case 2
                    lbl_Member.Text = "会员: 黄金会员"
                    If llblAdmin.Visible Then llblAdmin.Visible = False
                    If Label3.Visible Then Label3.Visible = False
                Case 32
                    lbl_Member.Text = "会员: 游戏管理员"
                    If Not llblAdmin.Visible Then llblAdmin.Visible = True
                    If Not Label3.Visible Then Label3.Visible = True
            End Select

            lbl_Point.Text = String.Format("积分：{0}", myPoint.ToString("N0"))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub fbTopup_Click(sender As Object, e As EventArgs) Handles fbTopup.Click
        Try
            Dim newForm As frmTransaction = New frmTransaction
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmCP_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If frmLogin.PasswordisMd5 Then
            Try
                Dim newForm As frmChgPass = New frmChgPass
                newForm.txt_CPUserName.Text = myUserName
                newForm.txt_CPPassword.Text = frmLogin.txt_Password.Text
                cpTab.TabPages.Add(newForm)
            Catch ex As Exception
            End Try
            Threading.Thread.Sleep(1)
            MsgBox("旧密码已经失效了，请换新密码。", MsgBoxStyle.Information, "温馨提示")
        End If
    End Sub

    Public Function AdjustPoints(howMany As Integer) As Boolean
        Dim goterror As Boolean = False

        Try
            xConn = New sqlConn()
            xConn.connectUser(String.Format("Update UserInfo Set [UserPoint] = '{0}' Where UserName = '{1}';", myPoint - howMany, myUserName))
            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            xConn.UserSQLComm.ExecuteNonQuery()
        Catch ex As Exception
            goterror = True
        End Try

        Return goterror
    End Function

    Private Sub llblAdmin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblAdmin.LinkClicked
        Try
            Dim newForm As frmAdCPMain = New frmAdCPMain
            newForm.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fbStore_Click(sender As Object, e As EventArgs) Handles fbStore.Click
        Try
            Dim newForm As frmShop = New frmShop
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub
End Class