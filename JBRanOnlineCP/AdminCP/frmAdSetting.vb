Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmAdSetting

    Dim xConn As sqlConn

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            xConn = New sqlConn()
            xConn.connectUser("Update CPSetting Set " &
                              "[CharRemain] = '" & txt_CharRemain.Text & "', " &
                              "[CharTestRemain] = '" & txt_CharTestRemain.Text & "', " &
                              "[MaxReborn] = '" & txt_MaxReborn.Text & "', " &
                              "[RBPrimaryLvl] = '" & txt_RBPrimaryLvl.Text & "', " &
                              "[RBSecondaryLvl] = '" & txt_RBSecondaryLvl.Text & "', " &
                              "[RBAdvanceLvl] = '" & txt_RBAdvanceLvl.Text & "', " &
                              "[RBPrimary] = '" & txt_RBPrimary.Text & "', " &
                              "[RBSecondary] = '" & txt_RBSecondary.Text & "', " &
                              "[RBAdvance] = '" & txt_RBAdvance.Text & "', " &
                              "[RBPrimaryStat] = '" & txt_RBPrimaryStat.Text & "', " &
                              "[RBSecondaryStat] = '" & txt_RBSecondayStat.Text & "', " &
                              "[RBAdvanceStat] = '" & txt_RBAdvanceStat.Text & "', " &
                              "[RBPrimaryGold] = '" & txt_RBPrimaryGold.Text & "', " &
                              "[RBSecondaryGold] = '" & txt_RBSecondaryGold.Text & "', " &
                              "[RBAdvanceGold] = '" & txt_RBAdvanceGold.Text & "', " &
                              "[AddStatGold] = '" & txt_AddStatGold.Text & "', " &
                              "[ChgSchoolGold] = '" & txt_ChgSchoolGold.Text & "', " &
                              "[ClearPKGold] = '" & txt_ClearPKGold.Text & "', " &
                              "[ChgNameGold] = '" & txt_ChgNameGold.Text & "', " &
                              "[ChgNameWait] = '" & txt_ChgNameWait.Text & "', " &
                              "[FormName] = '" & txt_SvrName.Text & "', " &
                              "[EmailAddr] = '" & txt_Email.Text & "', " &
                              "[EmailPwd] = '" & txt_EmailPass.Text & "', " &
                              "[EmailPort] = '" & txt_EmailPort.Text & "', " &
                              "[EmailHost] = '" & txt_EmailHost.Text & "', " &
                              "[EmailSubject] = '" & txt_EmailSubject.Text & "', " &
                              "[AdminPass] = '" & txt_AdminPass.Text & "', " &
                              "[PasswordEncrypt] = '" & Convert.ToInt32(cbMd5Pwd.Checked) & "', " &
                              "[RankingDisplay] = '" & cmbRankingDisplay.SelectedIndex & "' " &
                              "Where [ID] = '1';")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            xConn.UserSQLComm.ExecuteNonQuery()

            MsgBox("设定保存完成。", MsgBoxStyle.Information, "后台")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub frmAdminSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From CPSetting;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                txt_CharRemain.Text = d("CharRemain")
                txt_CharTestRemain.Text = d("CharTestRemain")
                txt_MaxReborn.Text = d("MaxReborn")
                txt_RBPrimaryLvl.Text = d("RBPrimaryLvl")
                txt_RBSecondaryLvl.Text = d("RBSecondaryLvl")
                txt_RBAdvanceLvl.Text = d("RBAdvanceLvl")
                txt_RBPrimary.Text = d("RBPrimary")
                txt_RBSecondary.Text = d("RBSecondary")
                txt_RBAdvance.Text = d("RBAdvance")
                txt_RBPrimaryStat.Text = d("RBPrimaryStat")
                txt_RBSecondayStat.Text = d("RBSecondaryStat")
                txt_RBAdvanceStat.Text = d("RBAdvanceStat")
                txt_RBPrimaryGold.Text = d("RBPrimaryGold")
                txt_RBSecondaryGold.Text = d("RBSecondaryGold")
                txt_RBAdvanceGold.Text = d("RBAdvanceGold")
                txt_RebornWait.Text = d("RebornWait")
                txt_AddStatGold.Text = d("AddStatGold")
                txt_ChgSchoolGold.Text = d("ChgSchoolGold")
                txt_ClearPKGold.Text = d("ClearPKGold")
                txt_ChgNameGold.Text = d("ChgNameGold")
                txt_ChgNameWait.Text = d("ChgNameWait")
                txt_SvrName.Text = d("FormName")
                txt_Email.Text = d("EmailAddr")
                txt_EmailPass.Text = d("EmailPwd")
                txt_EmailPort.Text = d("EmailPort")
                txt_EmailHost.Text = d("EmailHost")
                txt_EmailSubject.Text = d("EmailSubject")
                txt_AdminPass.Text = d("AdminPass")
                Dim md5 As Integer = d("PasswordEncrypt")
                cbMd5Pwd.Checked = Convert.ToBoolean(md5)
                cmbRankingDisplay.SelectedIndex = d("RankingDisplay")
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub
End Class