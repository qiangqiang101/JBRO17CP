Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmAddPoint

    Dim nl As String = Environment.NewLine
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

    Public AddStatGold As Integer '= 1000000 '加点所需游戏币
    Public AddStatJifen As Integer '家电所需积分

    Private Sub frmAddPoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        LoadAddStat()
    End Sub

    Public Sub LoadAddStat()
        lbl_JBNote2.Text = String.Format("手续费详情： {0}    加点花费需要{1}游戏币，{2}积分。", nl, AddStatGold, AddStatJifen)

        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where UserNum = '" & frmCP.userNum & "' And ChaDeleted=0;")

            xConn.GameSQLComm.Connection = xConn.GameSQLConn

            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                cmb_JDChar.Items.Add(d("ChaName".ToString))
            Loop

            xConn.GameSQLConn.Close()

            Try
                cmb_JDChar.SelectedIndex = 0
            Catch ex As Exception
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub btn_AddStat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddStat.Click
        If txt_Power.Text = "" Or txt_Dex.Text = "" Or txt_Spirit.Text = "" Or txt_HP.Text = "" Or txt_SP.Text = "" Then
            MsgBox("当前操作有误！", MsgBoxStyle.Critical, "错误")
        ElseIf String.IsNullOrEmpty(cmb_JDChar.SelectedItem) Then
            MsgBox("请选择要加点的角色！", MsgBoxStyle.Critical, "错误")
        ElseIf txt_Power.Text = "0" AndAlso txt_Dex.Text = "0" AndAlso txt_Spirit.Text = "0" AndAlso txt_HP.Text = "0" AndAlso txt_SP.Text = "0" Then
            MsgBox("当前操作有误！", MsgBoxStyle.Critical, "错误")
        ElseIf txt_ChaStRemain.Text < 100 Then
            MsgBox("剩余属性点少于 100 无法加点！", MsgBoxStyle.Critical, "错误")
        ElseIf frmcp.OnlineCheck(cmb_JDChar.SelectedItem) = True Then
            MsgBox("加点失败，角色还在线上，请下线后再试。", MsgBoxStyle.Critical, "错误")
        Else
            Try
                xConn = New sqlConn()
                xConn.connectGame("Select * From ChaInfo Where ChaName = '" & cmb_JDChar.SelectedItem & "';")
                xConn.GameSQLComm.Connection = xConn.GameSQLConn

                Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
                Do While d.Read
                    ChaStRemain = d("ChaStRemain")
                    ChaMoney = d("ChaMoney")
                Loop
                xConn.GameSQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            End Try

            If Val(txt_Power.Text) + Val(txt_Dex.Text) + Val(txt_Spirit.Text) + Val(txt_HP.Text) + Val(txt_SP.Text) > ChaStRemain Then
                MsgBox("分点有误，请重新分配！", MsgBoxStyle.Critical, "错误")
            ElseIf ChaMoney < AddStatGold Then
                MsgBox("您的游戏币不足，加点需要 " & AddStatGold & " 游戏币哦！", MsgBoxStyle.Critical, "错误")
            ElseIf frmCP.myPoint < AddStatJifen Then
                MsgBox("您的积分不足，加点需要 " & AddStatJifen & " 积分哦！", MsgBoxStyle.Critical, "错误")
            Else
                Try
                    xConn = New sqlConn()
                    xConn.connectGame("Update ChaInfo Set " &
                                      "[ChaMoney] = '" & ChaMoney - AddStatGold & "', " &
                                      "[ChaPower] = '" & txt_Power.Text & "', " &
                                      "[ChaDex] = '" & txt_Dex.Text & "', " &
                                      "[ChaSpirit] = '" & txt_Spirit.Text & "', " &
                                      "[ChaStrong] = '" & txt_HP.Text & "', " &
                                      "[ChaStrength] = '" & txt_SP.Text & "', " &
                                      "[ChaStRemain] = '" & ChaStRemain - (Val(txt_Power.Text) + Val(txt_Dex.Text) + Val(txt_Spirit.Text) + Val(txt_HP.Text) + Val(txt_SP.Text)) &
                                      "' Where ChaName = '" & cmb_JDChar.SelectedItem & "';")

                    xConn.GameSQLComm.Connection = xConn.GameSQLConn
                    xConn.GameSQLComm.ExecuteNonQuery()

                    If frmCP.AdjustPoints(AddStatJifen) Then
                        MsgBox("加点成功，消耗 " & AddStatGold & " 游戏币，" & AddStatJifen & " 积分！", MsgBoxStyle.Information, "加点")
                        ChaStRemain = 0
                        ChaMoney = 0
                        cmb_JDChar.SelectedIndex = 0
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
                End Try
            End If
        End If
    End Sub

    Private Sub cmb_JDChar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_JDChar.SelectedIndexChanged
        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where ChaName ='" & cmb_JDChar.SelectedItem & "';")

            xConn.GameSQLComm.Connection = xConn.GameSQLConn

            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                txt_ChaStRemain.Text = d("ChaStRemain")
                txt_Power.Text = 0
                txt_Dex.Text = 0
                txt_Spirit.Text = 0
                txt_HP.Text = 0
                txt_SP.Text = 0
            Loop
            xConn.GameSQLConn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NumbericKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Power.KeyPress, txt_Dex.KeyPress, txt_Spirit.KeyPress, txt_HP.KeyPress, txt_SP.KeyPress
        Dim ValidChars As String = "0123456789"
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub RefreshData()
        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From CPSetting;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                AddStatGold = d("AddStatGold")
                AddStatJifen = d("AddStatJifen")
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub
End Class