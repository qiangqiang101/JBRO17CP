Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmRename

    Dim nl As String = Environment.NewLine
    Dim xConn As sqlConn

    Private ChaBright As Integer = 0
    Private ChaMoney As Integer = 0
    Private ChaCNDate As Date

    Public ChangeNameGold As Integer '= 100000000 '改名所需游戏币
    Public ChangeNameJifen As Integer
    Public ChangeNameWait As Integer '= 3 '改名时间相隔(天)

    Private Sub frmRename_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        LoadChangeName()
    End Sub

    Private Sub LoadChangeName()
        lbl_CNNote.Text = String.Format("1. 请确认你的人物帐号已下线。{0}2. 改名需要 {1} 游戏币，{2} 积分，游戏币将从你身上扣除，请带足够的游戏币哦！{0}3. 角色名不可以含有 - & ; / \ = : # $ """" { } [ ] 的这些字符。{0}4. 改角色名后下次改角色名需等 {3} 天。", nl, ChangeNameGold, ChangeNameJifen, ChangeNameWait)

        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where UserNum = '" & frmCP.userNum & "' And ChaDeleted=0;")

            xConn.GameSQLComm.Connection = xConn.GameSQLConn

            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                cmb_CNCha.Items.Add(d("ChaName".ToString))
            Loop

            xConn.GameSQLConn.Close()

            Try
                cmb_CNCha.SelectedIndex = 0
            Catch ex As Exception
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub btn_ChangeName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ChangeName.Click
        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where ChaName = '" & cmb_CNCha.SelectedItem & "';")
            xConn.GameSQLComm.Connection = xConn.GameSQLConn

            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                ChaMoney = d("ChaMoney")
                ChaCNDate = d("ChaCNDate")
            Loop
            xConn.GameSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try

        Dim InvalidName() As String = {"GM", "Admin", "管理员", "管理員", "客服", "-", "&", ";", "\", "/", "=", ":", "#", "$", """", "{", "}", "[", "]"}

        If String.IsNullOrEmpty(cmb_CNCha.SelectedItem) Then
            MsgBox("请选择要改名的角色！", MsgBoxStyle.Critical, "错误")
        ElseIf frmcp.OnlineCheck(cmb_CNCha.SelectedItem) = True Then
            MsgBox("改名失败，角色还在线上，请下线后再试。", MsgBoxStyle.Critical, "错误")
        ElseIf ChaMoney < ChangeNameGold Then
            MsgBox("您的游戏币不足，改名需要 " & ChangeNameGold & " 游戏币哦！", MsgBoxStyle.Critical, "错误")
        ElseIf txt_CNNewName.Text = "" Then
            MsgBox("改名失败，新角色名不能为空！", MsgBoxStyle.Critical, "错误")
        ElseIf InvalidName.Any(Function(b) txt_CNNewName.Text.Contains(b)) Then
            MsgBox("角色名称内有不适当文字！", MsgBoxStyle.Critical, "错误")
        ElseIf checkName() = True Then
            MsgBox("角色名称已存在！", MsgBoxStyle.Critical, "错误")
        Else
            Dim D1 As Date = ChaCNDate
            Dim D2 As Date = Date.Now
            Dim Interval As Integer = DateDiff(DateInterval.Day, D1, D2)

            If Interval >= ChangeNameWait Then
                Try
                    xConn = New sqlConn()
                    xConn.connectGame("Update ChaInfo Set " &
                                      "[ChaCNDate] = '" & Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt") & "', " &
                                      "[ChaName] = '" & txt_CNNewName.Text & "', " &
                                      "[ChaMoney] = '" & ChaMoney - ChangeNameGold &
                                      "' Where ChaName = '" & cmb_CNCha.SelectedItem & "';")

                    xConn.GameSQLComm.Connection = xConn.GameSQLConn
                    xConn.GameSQLComm.ExecuteNonQuery()

                    If frmCP.AdjustPoints(ChangeNameJifen) Then
                        MsgBox("改名成功，消耗 " & ChangeNameGold & " 游戏币，" & ChangeNameJifen & " 积分！", MsgBoxStyle.Information, "转学")
                        ChaMoney = 0
                        cmb_CNCha.Items.Clear()
                        LoadChangeName()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
                End Try
            Else
                Dim NextCN As String = ChaCNDate.Month & "/" & ChaCNDate.Day + ChangeNameWait & "/" & ChaCNDate.Year & " " & ChaCNDate.Hour & ":" & ChaCNDate.Minute & ":" & ChaCNDate.Second & " " & ChaCNDate.ToString("tt")
                MsgBox("您已经改名了，下次改名的时间为 " & NextCN & "。", MsgBoxStyle.Critical, "错误")
            End If
        End If
    End Sub

    Public Function checkName()
        xConn = New sqlConn()
        xConn.connectGame("Select * From ChaInfo Where ChaName = '" & txt_CNNewName.Text & "';")

        xConn.GameSQLComm.Connection = xConn.GameSQLConn

        Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
        Do While d.Read
            If d("ChaName") = txt_CNNewName.Text Then
                Return True
            Else
                Return False
            End If
        Loop
        xConn.GameSQLConn.Close()
        Return False
    End Function

    Private Sub RefreshData()
        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From CPSetting;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                ChangeNameGold = d("ChgNameGold")
                ChangeNameJifen = d("ChgNameJifen")
                ChangeNameWait = d("ChgNameWait")
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub
End Class