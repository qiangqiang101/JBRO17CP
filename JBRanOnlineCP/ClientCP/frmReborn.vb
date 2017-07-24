Imports System.Data.Sql
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
    Public SecondaryGold As Integer '= 1000000 '中级转生所需游戏币
    Public AdvanceGold As Integer '= 10000000 '高级转生所需游戏币
    Public RebornWait As Integer '= 1 '转生时间相隔(小时)

    Public Sub LoadReborn()
        lbl_RBNote1.Text = "1. 最多可以转生 " & Reborn & " 次。" & nl &
            "2. 目前提供高级转生、中级转生、初级转生。" & nl &
            "3. 转生前请先确认帐号内的角色已经下线。" & nl &
            "4 : .转生费用将会从你身上扣除, 请带足够的游戏币和积分再来哦!"
        lbl_RBNote2.Text = "转生级数需求：" & nl &
            "    初级转生 " & PrimaryLevel & " 等级，" & PrimaryReborn & " 转生，每转一次增加 " & PrimaryStat & " 属性点。" & nl &
            "    中级转生 " & SecondaryLevel & " 等级，" & SecondaryReborn & " 转生，每转一次增加 " & SecondaryStat & " 属性点。" & nl &
            "    高级转生 " & AdvanceLevel & " 等级，" & AdvanceReborn & " 转生，每转一次增加 " & AdvanceStat & " 属性点。"
        lbl_RBNote3.Text = "手续费详情：" & nl &
            "    初级转生 " & PrimaryGold & " 游戏币。" & nl &
            "    中级转生 " & SecondaryGold & " 游戏币。" & nl &
            "    高级转生 " & AdvanceGold & " 游戏币。"

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
                            If ChaMoney < PrimaryGold Then
                                MsgBox("您的游戏币不足，初级转生需要 " & PrimaryGold & " 游戏币哦！", MsgBoxStyle.Critical, "错误")
                            Else
                                If frmCP.OnlineCheck(cmb_RBChar.SelectedItem) = True Then
                                    MsgBox("转生失败，角色还在线上，请下线后再试。", MsgBoxStyle.Critical, "错误")
                                Else
                                    If frmCP.userType = 2 Then
                                        UpdateChaIntel(CInt(ChaIntel + 1), PrimaryStat, PrimaryGold)
                                    Else
                                        If Interval >= RebornWait Then
                                            UpdateChaIntel(CInt(ChaIntel + 1), PrimaryStat, PrimaryGold)
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
                            If ChaMoney < SecondaryGold Then
                                MsgBox("您的游戏币不足，中级转生需要 " & SecondaryGold & " 游戏币哦！", MsgBoxStyle.Critical, "错误")
                            Else
                                If frmCP.OnlineCheck(cmb_RBChar.SelectedItem) = True Then
                                    MsgBox("转生失败，角色还在线上，请下线后再试。", MsgBoxStyle.Critical, "错误")
                                Else
                                    If frmCP.userType = 2 Then
                                        UpdateChaIntel(CInt(ChaIntel + 1), SecondaryStat, SecondaryGold)
                                    Else
                                        If Interval >= RebornWait Then
                                            UpdateChaIntel(CInt(ChaIntel + 1), SecondaryStat, SecondaryGold)
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
                            If ChaMoney < AdvanceGold Then
                                MsgBox("您的游戏币不足，高级转生需要 " & AdvanceGold & " 游戏币哦！", MsgBoxStyle.Critical, "错误")
                            Else
                                If frmCP.OnlineCheck(cmb_RBChar.SelectedItem) = True Then
                                    MsgBox("转生失败，角色还在线上，请下线后再试。", MsgBoxStyle.Critical, "错误")
                                Else
                                    If frmCP.userType = 2 Then
                                        UpdateChaIntel(CInt(ChaIntel + 1), AdvanceStat, AdvanceGold)
                                    Else
                                        If Interval >= RebornWait Then
                                            UpdateChaIntel(CInt(ChaIntel + 1), AdvanceStat, AdvanceGold)
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

    Private Sub UpdateChaIntel(ByVal Reborns As Integer, ByVal StRemain As Integer, ByVal CostMoney As Integer)
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

            MsgBox("您当前第 " & Reborns & " 转，转生成功，得属性 " & (ChaIntel * StRemain) & " 点，消耗 " & CostMoney & " 游戏币！", MsgBoxStyle.Information, "转生")
            ChaIntel = 0
            ChaLevel = 0
            ChaMoney = 0
            cmb_RBChar.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub frmReborn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReborn()
    End Sub
End Class