Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmClearRed

    Dim nl As String = Environment.NewLine
    Dim xConn As sqlConn

    Private ChaBright As Integer = 0
    Private ChaMoney As Integer = 0

    Public ClearPKGold As Integer '= 5000000 '漂白所需游戏币

    Private Sub frmClearRed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        LoadClearPK()
    End Sub

    Public Sub LoadClearPK()
        lbl_PKNote.Text = "1. 请确认你的人物帐号已下线。" & nl &
        "2. 每花费 " & ClearPKGold & " 游戏币可以漂白 1 点PK值，钱将从你身上扣除，清代足够的钱哦！"

        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where UserNum = '" & frmCP.userNum & "' And ChaDeleted=0;")

            xConn.GameSQLComm.Connection = xConn.GameSQLConn

            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                cmb_PKCha.Items.Add(d("ChaName".ToString))
            Loop

            xConn.GameSQLConn.Close()

            Try
                cmb_PKCha.SelectedIndex = 0
            Catch ex As Exception
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub btn_ClearPK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ClearPK.Click
        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where ChaName = '" & cmb_PKCha.SelectedItem & "';")
            xConn.GameSQLComm.Connection = xConn.GameSQLConn

            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                ChaBright = d("ChaBright")
                ChaMoney = d("ChaMoney")
            Loop
            xConn.GameSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try

        If String.IsNullOrEmpty(cmb_PKCha.SelectedItem) Then
            MsgBox("请选择要漂白的角色！", MsgBoxStyle.Critical, "错误")
        ElseIf frmcp.OnlineCheck(cmb_PKCha.SelectedItem) = True Then
            MsgBox("漂白失败，角色还在线上，请下线后再试。", MsgBoxStyle.Critical, "错误")
        ElseIf ChaMoney < ClearPKGold * Val(txt_PKValue.Text) Then
            MsgBox("您的游戏币不足，漂白需要 " & ClearPKGold * Val(txt_PKValue.Text) & " 游戏币哦！", MsgBoxStyle.Critical, "错误")
        ElseIf txt_PKValue.Text = "" Then
            MsgBox("漂白失败，请输入清洗PK数量。", MsgBoxStyle.Critical, "错误")
        ElseIf ChaBright > 1 Then
            MsgBox("漂白失败，您已经很白了。", MsgBoxStyle.Critical, "错误")
        Else
            Dim ClearCost As Integer = ClearPKGold * Val(txt_PKValue.Text)
            Try
                xConn = New sqlConn()
                xConn.connectGame("Update ChaInfo Set " &
                                  "[ChaBright] = '" & Val(txt_PKValue.Text) + ChaBright & "', " &
                                  "[ChaMoney] = '" & ChaMoney - ClearCost &
                                  "' Where ChaName = '" & cmb_PKCha.SelectedItem & "';")

                xConn.GameSQLComm.Connection = xConn.GameSQLConn
                xConn.GameSQLComm.ExecuteNonQuery()

                MsgBox("漂白成功，消耗 " & ClearCost & " 游戏币！", MsgBoxStyle.Information, "转学")
                ChaMoney = 0
                ChaBright = 0
                cmb_PKCha.SelectedIndex = 0
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            End Try
        End If
    End Sub

    Private Sub NumbericKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PKValue.KeyPress
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
                ClearPKGold = d("ClearPKGold")
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub
End Class