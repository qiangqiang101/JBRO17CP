Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmClearPoint

    Dim nl As String = Environment.NewLine
    Dim xConn As sqlConn

    Private Sub frmClearPoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClearStat()
    End Sub

    Public Sub LoadClearStat()
        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where UserNum = '" & frmCP.userNum & "' And ChaDeleted=0;")

            xConn.GameSQLComm.Connection = xConn.GameSQLConn

            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                cmb_CSCha.Items.Add(d("ChaName".ToString))
            Loop

            xConn.GameSQLConn.Close()

            Try
                cmb_CSCha.SelectedIndex = 0
            Catch ex As Exception
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub btn_ClearStat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ClearStat.Click
        Dim pw, dx, sr, hp, sp, rm As Integer
        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where ChaName ='" & cmb_CSCha.SelectedItem & "';")

            xConn.GameSQLComm.Connection = xConn.GameSQLConn

            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                rm = d("ChaStRemain")
                pw = d("ChaPower")
                dx = d("ChaDex")
                sr = d("ChaSpirit")
                hp = d("ChaStrong")
                sp = d("ChaStrength")
            Loop
            xConn.GameSQLConn.Close()
        Catch ex As Exception
        End Try

        If String.IsNullOrEmpty(cmb_CSCha.SelectedItem) Then
            MsgBox("请选择要洗点的角色！", MsgBoxStyle.Critical, "错误")
        ElseIf frmcp.OnlineCheck(cmb_CSCha.SelectedItem) = True Then
            MsgBox("洗点失败，角色还在线上，请下线后再试。", MsgBoxStyle.Critical, "错误")
        ElseIf frmcp.userType = 1 Then
            Dim VIP As String
            Select Case frmCP.userType
                Case 32
                    VIP = "游戏管理员"
                Case 2
                    VIP = "黄金会员"
                Case Else
                    VIP = "普通会员"
            End Select
            MsgBox("您当前是：" & VIP & "，洗点失败。", MsgBoxStyle.Critical, "错误")
        Else
            Try
                xConn = New sqlConn()
                xConn.connectGame("Update ChaInfo Set " &
                                  "[ChaPower] = '0', [ChaDex] = '0', [ChaSpirit] = '0', [ChaStrong] = '0', [ChaStrength] = '0', " &
                                  "[ChaStRemain] = '" & pw + dx + sr + hp + sp + rm &
                                  "' Where ChaName = '" & cmb_CSCha.SelectedItem & "';")

                xConn.GameSQLComm.Connection = xConn.GameSQLConn
                xConn.GameSQLComm.ExecuteNonQuery()

                MsgBox("洗点成功！", MsgBoxStyle.Information, "洗点")
                pw = 0
                dx = 0
                sr = 0
                hp = 0
                sp = 0
                rm = 0
                cmb_CSCha.SelectedIndex = 0
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            End Try
        End If
    End Sub
End Class