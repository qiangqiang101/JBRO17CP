﻿Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmReborn

    Dim xConn As sqlConn

    Private ChaIntel As Integer = 0
    Private ChaLevel As Integer = 0
    Private ChaMoney As Integer = 0
    Private ChaStRemain As Integer = 0
    Private ChaRBDate As Date
    Private ChaSchool As Integer = 0
    Private ChaBright As Integer = 0
    Private ChaCNDate As Date
    Private UserLoginState As Integer = 0
    Dim nl As String = Environment.NewLine

    'Settings
    Public Reborn As Integer '= 30 '最高转生
    Public PrimaryLevel As Integer '= 191 '初级转生所需等级
    Public SecondaryLevel As Integer '= 201 '中级转生所需等级
    Public AdvanceLevel As Integer '= 210 '高级转生所需等级
    Public PrimaryReborn As Integer '= 30 '初级转生所需转生
    Public SecondaryReborn As Integer '= 60 '中级转生所需转生
    Public AdvanceReborn As Integer '= 100 '高级转生所需转生
    Public PrimaryStat As Integer '= 50 '初级转生转生后属性
    Public SecondaryStat As Integer '= 100 '中级转生转生后属性
    Public AdvanceStat As Integer '= 100 '高级转生转生后属性
    Public PrimaryGold As Integer '= 0 '初级转生所需游戏币
    Public PrimaryJifen As Integer
    Public SecondaryGold As Integer '= 1000000 '中级转生所需游戏币
    Public SecondaryJifen As Integer
    Public AdvanceGold As Integer '= 10000000 '高级转生所需游戏币
    Public AdvanceJifen As Integer
    Public RebornWait As Integer '= 1 '转生时间相隔(小时)

    Public Sub LoadReborn()
        lbl_RBNote1.Text = String.Format("1. 最多可以转生 {1} 次。{0}2. 目前提供高级转生、中级转生、初级转生。{0}3. 转生前请先确认帐号内的角色已经下线。{0}4. 转生费用将会从你身上扣除, 请带足够的游戏币和积分再来哦！", nl, Reborn)
        lbl_RBNote2.Text = String.Format("转生级数需求：{0}    初级转生 {1} 等级，{2} 转生，每转一次增加 {3} 属性点。{0}    中级转生 {4} 等级，{5} 转生，每转一次增加 {6} 属性点。{0}    高级转生 {7} 等级，{8} 转生，每转一次增加 {9} 属性点。", nl, PrimaryLevel, PrimaryReborn, PrimaryStat, SecondaryLevel, SecondaryReborn, SecondaryStat, AdvanceLevel, AdvanceReborn, AdvanceStat)
        lbl_RBNote3.Text = String.Format("手续费详情：{0}    初级转生消耗 {1} 游戏币，{2} 积分。{0}    中级转生消耗 {3} 游戏币，{4} 积分。{0}    高级转生消耗 {5} 游戏币，{6} 积分。", nl, PrimaryGold, primaryJifen, SecondaryGold, SecondaryJifen, AdvanceGold, AdvanceJifen)

        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where UserNum = '" & frmCP.userNum & "' And ChaDeleted=0;")

            xConn.GameSQLComm.Connection = xConn.GameSQLConn

            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                cmb_RBChar.Items.Add(d("ChaName".ToString))
            Loop

            xConn.GameSQLConn.Close()

            Try
                cmb_RBChar.SelectedIndex = 0
            Catch ex As Exception
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub btnReborn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReborn.Click
        Try
            If String.IsNullOrEmpty(cmb_RBChar.SelectedItem) Then
                MsgBox("请选择要转生的角色！", MsgBoxStyle.Critical, "错误")
            Else
                Try
                    xConn = New sqlConn()
                    xConn.connectGame("Select * From ChaInfo Where ChaName = '" & cmb_RBChar.SelectedItem & "';")
                    xConn.GameSQLComm.Connection = xConn.GameSQLConn

                    Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
                    Do While d.Read
                        ChaIntel = d("ChaIntel")
                        ChaLevel = d("ChaLevel")
                        ChaMoney = d("ChaMoney")
                        ChaRBDate = d("ChaRBDate")
                    Loop
                    xConn.GameSQLConn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
                End Try

                Dim PSA As String
                If ChaIntel <= PrimaryReborn Then
                    PSA = "P"
                ElseIf ChaIntel <= SecondaryReborn Then
                    PSA = "S"
                ElseIf ChaIntel <= AdvanceReborn Then
                    PSA = "A"
                ElseIf ChaIntel >= Reborn Then
                    PSA = "M"
                    MsgBox("您已经达到最高转生，请等待GM开转！", MsgBoxStyle.Critical, "错误")
                End If

                Dim D1 As Date = ChaRBDate
                Dim D2 As Date = Date.Now
                Dim Interval As Integer = DateDiff(DateInterval.Hour, D1, D2)

                Select Case PSA
                    Case "P"
                        If ChaLevel < PrimaryLevel Then
                            MsgBox("您还未达到初级转生的等级，练练再来吧！", MsgBoxStyle.Critical, "错误")
                        Else
                            If (ChaMoney < PrimaryGold) Or (frmCP.myPoint < primaryJifen) Then
                                MsgBox("您的游戏币或积分不足，初级转生需要 " & PrimaryGold & " 游戏币，" & primaryJifen & " 哦！", MsgBoxStyle.Critical, "错误")
                            Else
                                If frmCP.OnlineCheck(cmb_RBChar.SelectedItem) = True Then
                                    MsgBox("转生失败，角色还在线上，请下线后再试。", MsgBoxStyle.Critical, "错误")
                                Else
                                    If frmCP.userType = 2 Then
                                        UpdateChaIntel(CInt(ChaIntel + 1), PrimaryStat, PrimaryGold, primaryJifen)
                                    Else
                                        If Interval >= RebornWait Then
                                            UpdateChaIntel(CInt(ChaIntel + 1), PrimaryStat, PrimaryGold, primaryJifen)
                                        Else
                                            Dim NextRB As String = ChaRBDate.Month & "/" & ChaRBDate.Day & "/" & ChaRBDate.Year & " " & ChaRBDate.Hour + RebornWait & ":" & ChaRBDate.Minute & ":" & ChaRBDate.Second & " " & ChaRBDate.ToString("tt")
                                            MsgBox("您已经转生了，下次转生的时间为 " & NextRB & "。", MsgBoxStyle.Critical, "错误")
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    Case "S"
                        If ChaLevel < SecondaryLevel Then
                            MsgBox("您还未达到中级转生的等级，练练再来吧！", MsgBoxStyle.Critical, "错误")
                        Else
                            If (ChaMoney < SecondaryGold) Or (frmCP.myPoint < SecondaryJifen) Then
                                MsgBox("您的游戏币或积分不足，初级转生需要 " & SecondaryGold & " 游戏币，" & SecondaryJifen & " 哦！", MsgBoxStyle.Critical, "错误")
                            Else
                                If frmCP.OnlineCheck(cmb_RBChar.SelectedItem) = True Then
                                    MsgBox("转生失败，角色还在线上，请下线后再试。", MsgBoxStyle.Critical, "错误")
                                Else
                                    If frmCP.userType = 2 Then
                                        UpdateChaIntel(CInt(ChaIntel + 1), SecondaryStat, SecondaryGold, SecondaryJifen)
                                    Else
                                        If Interval >= RebornWait Then
                                            UpdateChaIntel(CInt(ChaIntel + 1), SecondaryStat, SecondaryGold, SecondaryJifen)
                                        Else
                                            Dim NextRB As String = ChaRBDate.Month & "/" & ChaRBDate.Day & "/" & ChaRBDate.Year & " " & ChaRBDate.Hour + RebornWait & ":" & ChaRBDate.Minute & ":" & ChaRBDate.Second & " " & ChaRBDate.Ticks
                                            MsgBox("您已经转生了，下次转生的时间为 " & NextRB & "。", MsgBoxStyle.Critical, "错误")
                                        End If
                                    End If

                                End If
                            End If
                        End If
                    Case "A"
                        If ChaLevel < AdvanceLevel Then
                            MsgBox("您还未达到高级转生的等级，练练再来吧！", MsgBoxStyle.Critical, "错误")
                        Else
                            If (ChaMoney < AdvanceGold) Or (frmCP.myPoint < AdvanceJifen) Then
                                MsgBox("您的游戏币或积分不足，初级转生需要 " & AdvanceGold & " 游戏币，" & AdvanceJifen & " 哦！", MsgBoxStyle.Critical, "错误")
                            Else
                                If frmCP.OnlineCheck(cmb_RBChar.SelectedItem) = True Then
                                    MsgBox("转生失败，角色还在线上，请下线后再试。", MsgBoxStyle.Critical, "错误")
                                Else
                                    If frmCP.userType = 2 Then
                                        UpdateChaIntel(CInt(ChaIntel + 1), AdvanceStat, AdvanceGold, AdvanceJifen)
                                    Else
                                        If Interval >= RebornWait Then
                                            UpdateChaIntel(CInt(ChaIntel + 1), AdvanceStat, AdvanceGold, AdvanceJifen)
                                        Else
                                            Dim NextRB As String = ChaRBDate.Month & "/" & ChaRBDate.Day & "/" & ChaRBDate.Year & " " & ChaRBDate.Hour + RebornWait & ":" & ChaRBDate.Minute & ":" & ChaRBDate.Second & " " & ChaRBDate.Ticks
                                            MsgBox("您已经转生了，下次转生的时间为 " & NextRB & "。", MsgBoxStyle.Critical, "错误")
                                        End If
                                    End If

                                End If
                            End If
                        End If
                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub UpdateChaIntel(ByVal Reborns As Integer, ByVal StRemain As Integer, ByVal CostMoney As Integer, CostJifen As Integer)
        Try
            xConn = New sqlConn()
            xConn.connectGame("Update ChaInfo Set [ChaIntel] = '" & Reborns & "', " &
                              "[ChaStRemain] = '" & (ChaIntel * StRemain) & "', " &
                              "[ChaLevel] = '1', " &
                              "[ChaMoney] = '" & ChaMoney - CostMoney & "', " &
                              "[ChaRBDate] = '" & Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt") & "', " &
                              "[ChaPower] = '0', [ChaStrong] = '0', [ChaStrength] = '0', [ChaSpirit] = '0', [ChaDex] = '0' " &
                              "Where ChaName = '" & cmb_RBChar.SelectedItem & "';")

            xConn.GameSQLComm.Connection = xConn.GameSQLConn
            xConn.GameSQLComm.ExecuteNonQuery()
            xConn.GameSQLConn.Close()

            If frmCP.AdjustPoints(CostJifen) Then
                MsgBox("您当前第 " & Reborns & " 转，转生成功，得属性 " & (ChaIntel * StRemain) & " 点，消耗 " & CostMoney & " 游戏币，" & CostJifen & " 积分！", MsgBoxStyle.Information, "转生")
                ChaIntel = 0
                ChaLevel = 0
                ChaMoney = 0
                cmb_RBChar.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub frmReborn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        LoadReborn()
    End Sub

    Private Sub RefreshData()
        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From CPSetting;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                Reborn = d("MaxReborn")
                PrimaryLevel = d("RBPrimaryLvl")
                SecondaryLevel = d("RBSecondaryLvl")
                AdvanceLevel = d("RBAdvanceLvl")
                PrimaryReborn = d("RBPrimary")
                SecondaryReborn = d("RBSecondary")
                AdvanceReborn = d("RBAdvance")
                PrimaryStat = d("RBPrimaryStat")
                SecondaryStat = d("RBSecondaryStat")
                AdvanceStat = d("RBAdvanceStat")
                PrimaryGold = d("RBPrimaryGold")
                primaryJifen = d("RBPrimaryJifen")
                SecondaryGold = d("RBSecondaryGold")
                SecondaryJifen = d("RBSecondaryJifen")
                AdvanceGold = d("RBAdvanceGold")
                AdvanceJifen = d("RBAdvanceJifen")
                RebornWait = d("RebornWait")
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub
End Class