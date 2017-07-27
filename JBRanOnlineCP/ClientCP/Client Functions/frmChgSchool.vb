Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmChgSchool

    Dim nl As String = Environment.NewLine
    Dim xConn As sqlConn

    Private ChaSchool As Integer = 0
    Private ChaMoney As Integer = 0

    Public ChangeSchoolGold As Integer '= 10000000 '转学所需游戏币
    Public ChangeSchoolJifen As Integer '转学所需积分

    Private Sub frmChgSchool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        LoadChangeSchool()
    End Sub

    Public Sub LoadChangeSchool()
        lbl_ZXNote.Text = String.Format("1. 请确认你的人物帐号已下线。{0}2. 转学需要{1}游戏币，{2}积分，游戏币将从你身上扣除，请带足够的游戏币哦！", nl, ChangeSchoolGold, ChangeSchoolJifen)

        cmb_ZXSchool.Items.Add("圣门学院")
        cmb_ZXSchool.Items.Add("玄岩学院")
        cmb_ZXSchool.Items.Add("凤凰学院")

        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where UserNum = '" & frmCP.userNum & "' And ChaDeleted=0;")

            xConn.GameSQLComm.Connection = xConn.GameSQLConn

            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                cmb_ZXCha.Items.Add(d("ChaName".ToString))
            Loop

            xConn.GameSQLConn.Close()

            Try
                cmb_ZXCha.SelectedIndex = 0
            Catch ex As Exception
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub cmb_ZXCha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ZXCha.SelectedIndexChanged
        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where ChaName ='" & cmb_ZXCha.SelectedItem & "';")

            xConn.GameSQLComm.Connection = xConn.GameSQLConn

            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                ChaSchool = d("ChaSchool")
            Loop
            xConn.GameSQLConn.Close()
        Catch ex As Exception
        End Try

        Select Case ChaSchool
            Case 0
                cmb_ZXSchool.SelectedItem = "圣门学院"
            Case 1
                cmb_ZXSchool.SelectedItem = "玄岩学院"
            Case 2
                cmb_ZXSchool.SelectedItem = "凤凰学院"
        End Select
    End Sub

    Private Sub btn_ChangeSchool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ChangeSchool.Click
        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where ChaName = '" & cmb_ZXCha.SelectedItem & "';")
            xConn.GameSQLComm.Connection = xConn.GameSQLConn

            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                ChaMoney = d("ChaMoney")
            Loop
            xConn.GameSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try

        If String.IsNullOrEmpty(cmb_ZXCha.SelectedItem) Then
            MsgBox("请选择要转学的角色！", MsgBoxStyle.Critical, "错误")
        ElseIf frmcp.OnlineCheck(cmb_ZXCha.SelectedItem) = True Then
            MsgBox("转学失败，角色还在线上，请下线后再试。", MsgBoxStyle.Critical, "错误")
        ElseIf ChaMoney < ChangeSchoolGold Then
            MsgBox("您的游戏币不足，转学需要 " & ChangeSchoolGold & " 游戏币哦！", MsgBoxStyle.Critical, "错误")
        ElseIf frmCP.myPoint < ChangeSchoolJifen Then
            MsgBox("您的积分不足，转学需要 " & ChangeSchoolJifen & " 积分哦！", MsgBoxStyle.Critical, "错误")
        ElseIf ChaSchool = cmb_ZXSchool.SelectedIndex Then
            MsgBox("您目前已经是" & cmb_ZXSchool.SelectedItem & "的学生，转学失败。", MsgBoxStyle.Critical, "错误")
        Else
            Try
                xConn = New sqlConn()
                xConn.connectGame("Update ChaInfo Set " &
                                  "[ChaSchool] = '" & cmb_ZXSchool.SelectedIndex & "', " &
                                  "[ChaMoney] = '" & ChaMoney - ChangeSchoolGold &
                                  "' Where ChaName = '" & cmb_ZXCha.SelectedItem & "';")

                xConn.GameSQLComm.Connection = xConn.GameSQLConn
                xConn.GameSQLComm.ExecuteNonQuery()

                If frmCP.AdjustPoints(ChangeSchoolJifen) Then
                    MsgBox("转学成功，消耗 " & ChangeSchoolGold & " 游戏币，" & ChangeSchoolJifen & " 积分！", MsgBoxStyle.Information, "转学")
                    ChaMoney = 0
                    ChaSchool = 0
                    cmb_ZXCha.SelectedIndex = 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            End Try
        End If
    End Sub

    Private Sub RefreshData()
        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From CPSetting;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                ChangeSchoolGold = d("ChgSchoolGold")
                ChangeSchoolJifen = d("ChangeSchoolJifen")
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub
End Class