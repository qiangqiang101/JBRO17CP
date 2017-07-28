Imports System.Data.SqlClient

Public Class frmAdChaEdit

    Dim xConn As sqlConn
    Public ChaNum As New Label
    Dim chaOnline As Integer

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            If Not OnlineCheck(ChaNum.Text) Then
                xConn = New sqlConn()
                xConn.connectGame("Update ChaInfo Set " &
                                  "[ChaName] = '" & txtChaName.Text & "', " &
                                  "[ChaGuName] = '" & txtChaGuName.Text & "', " &
                                   "[ChaSchool] = '" & cmbSchool.SelectedIndex & "', " &
                                   "[ChaClass] = '" & GetChaClassIDfromName(cmbClass.SelectedItem) & "', " &
                                   "[ChaHair] = '" & txtHair.Text & "', " &
                                   "[ChaFace] = '" & txtFace.Text & "', " &
                                    "[ChaLiving] = '" & txtLife.Text & "', " &
                                    "[ChaLevel] = '" & txtLevel.Text & "', " &
                                    "[ChaMoney] = '" & txtChaMoney.Text & "', " &
                                    "[ChaPower] = '" & txtPow.Text & "', " &
                                    "[ChaStrong] = '" & txtStrong.Text & "', " &
                                    "[ChaStrength] = '" & txtStrength.Text & "', " &
                                    "[ChaSpirit] = '" & txtInt.Text & "', " &
                                    "[ChaDex] = '" & txtDex.Text & "', " &
                                    "[ChaIntel] = '" & txtChaIntel.Text & "', " &
                                    "[ChaStRemain] = '" & txtStrRemain.Text & "', " &
                                    "[ChaExp] = '" & txtEXP.Text & "', " &
                                    "[ChaHP] = '" & txtHP.Text & "', " &
                                    "[ChaMP] = '" & txtMP.Text & "', " &
                                    "[ChaSP] = '" & txtSP.Text & "', " &
                                    "[ChaPosX] = '" & txtX.Text & "', " &
                                    "[ChaPosY] = '" & txtY.Text & "', " &
                                    "[ChaPosZ] = '" & txtZ.Text & "', " &
                                    "[ChaBright] = '" & txtBright.Text & "', " &
                                    "[ChaFightA] = '" & txtFightA.Text & "', " &
                                    "[ChaShootA] = '" & txtShootA.Text & "', " &
                                    "[ChaPK] = '" & txtPK.Text & "', " &
                                    "[ChaSkillPoint] = '" & txtSkillPoint.Text & "', " &
                                    "[ChaDeleted] = '" & Convert.ToInt32(cbDeleted.Checked) & "', " &
                                    "[ChaInvenLine] = '" & txtInvenLine.Text & "' " &
                                    "Where ChaNum = " & ChaNum.Text & ";")
                xConn.GameSQLComm.Connection = xConn.GameSQLConn
                xConn.GameSQLComm.ExecuteNonQuery()
                xConn.GameSQLConn.Close()
                Me.Close()
            Else
                MsgBox("角色还在线上，请下线后再试。", MsgBoxStyle.Critical, "错误")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Function GetChaClassIDfromName(name As String) As Integer
        Dim result As Integer = 0
        Select Case name
            Case "格斗部", "男格斗"
                result = 1
            Case "剑道部"， “男剑道”
                result = 2
            Case "弓箭部", "女弓箭"
                result = 4
            Case "气功部", "女气功"
                result = 8
            Case "龙鳞部", "男终极"
                result = 16
            Case "龙凤部", "女终极"
                result = 32
            Case "女格斗"
                result = 64
            Case "女剑道"
                result = 128
            Case "男弓箭"
                result = 256
            Case "男气功"
                result = 512
            Case "男超能"
                result = 1024
            Case "女超能"
                result = 2048
            Case "男忍术"
                result = 4096
            Case "女忍术"
                result = 8192
            Case "男魔术"
                result = 16384
            Case "女魔术"
                result = 32768
            Case "男变身"
                result = 65536
            Case "女变身"
                result = 131072
        End Select
        Return result
    End Function

    Public Function OnlineCheck(ByVal _ChaNum As String)
        xConn = New sqlConn()
        xConn.connectGame("Select * From ChaInfo Where ChaNum = '" & _ChaNum & "';")

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

End Class