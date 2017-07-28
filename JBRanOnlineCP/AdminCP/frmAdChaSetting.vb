Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmAdChaSetting

    Dim xConn As sqlConn
    Dim items As New ListViewItem()
    Dim RankingDisplay As Integer

    Private Sub btn_SearchUser_Click(sender As Object, e As EventArgs) Handles btn_SearchUser.Click
        Try
            lvCha.Items.Clear()
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where ChaName Like '%" & txt_SearchUser.Text & "%';")

            xConn.GameSQLComm.Connection = xConn.GameSQLConn
            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                items = lvCha.Items.Add(d("ChaName".ToString))
                With items
                    .SubItems.Add(d("ChaNum".ToString))
                    .SubItems.Add(d("ChaGuName".ToString))
                    Dim _ChaOnline As Integer = d("ChaOnline")
                    Select Case _ChaOnline
                        Case 1
                            .SubItems.Add("在线")
                        Case 0
                            .SubItems.Add("离线")
                    End Select
                    Dim _ChaDeleted As Integer = d("ChaDeleted")
                    Select Case _ChaDeleted
                        Case 0
                            .SubItems.Add("存在")
                        Case 1
                            .SubItems.Add("删除")
                    End Select
                    .SubItems.Add(d("ChaMoney"))
                End With
            Loop
            xConn.GameSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub lvCha_DoubleClick(sender As Object, e As EventArgs) Handles lvCha.DoubleClick
        Try
            Dim newForm As frmAdChaEdit = New frmAdChaEdit
            frmAdCPMain.cpTab.TabPages.Add(newForm)

            PopulatedCmbRank(newForm.cmbClass)

            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where ChaName = '" & lvCha.SelectedItems.Item(0).Text & "';")

            xConn.GameSQLComm.Connection = xConn.GameSQLConn
            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                newForm.ChaNum.Text = d("ChaNum")
                newForm.txtChaName.Text = d("ChaName")
                newForm.Text = String.Format("{0} - 角色设置", d("ChaName"))
                newForm.txtChaGuName.Text = d("ChaGuName")
                newForm.cmbSchool.SelectedIndex = d("ChaSchool")
                Dim _ChaClass As Integer = d("ChaClass")
                Select Case _ChaClass
                    Case 1
                        If newForm.cmbClass.Items.Contains("男格斗") Then
                            newForm.cmbClass.SelectedItem = "男格斗"
                        Else
                            newForm.cmbClass.SelectedItem = "格斗部"
                        End If
                    Case 2
                        If newForm.cmbClass.Items.Contains("男剑道") Then
                            newForm.cmbClass.SelectedItem = "男剑道"
                        Else
                            newForm.cmbClass.SelectedItem = "剑道部"
                        End If
                    Case 4
                        If newForm.cmbClass.Items.Contains("女弓箭") Then
                            newForm.cmbClass.SelectedItem = "女弓箭"
                        Else
                            newForm.cmbClass.SelectedItem = "弓箭部"
                        End If
                    Case 8
                        If newForm.cmbClass.Items.Contains("女气功") Then
                            newForm.cmbClass.SelectedItem = "女气功"
                        Else
                            newForm.cmbClass.SelectedItem = "气功部"
                        End If
                    Case 16
                        If newForm.cmbClass.Items.Contains("男终极") Then
                            newForm.cmbClass.SelectedItem = "男终极"
                        Else
                            newForm.cmbClass.SelectedItem = "龙鳞部"
                        End If
                    Case 32
                        If newForm.cmbClass.Items.Contains("女终极") Then
                            newForm.cmbClass.SelectedItem = "女终极"
                        Else
                            newForm.cmbClass.SelectedItem = "龙凤部"
                        End If
                    Case 64
                        newForm.cmbClass.SelectedItem = "女格斗"
                    Case 128
                        newForm.cmbClass.SelectedItem = "女剑道"
                    Case 256
                        newForm.cmbClass.SelectedItem = "男弓箭"
                    Case 512
                        newForm.cmbClass.SelectedItem = "男气功"
                    Case 1024
                        newForm.cmbClass.SelectedItem = "男超能"
                    Case 2048
                        newForm.cmbClass.SelectedItem = "女超能"
                    Case 4096
                        newForm.cmbClass.SelectedItem = "男忍术"
                    Case 8192
                        newForm.cmbClass.SelectedItem = "女忍术"
                    Case 16384
                        newForm.cmbClass.SelectedItem = "男魔术"
                    Case 32768
                        newForm.cmbClass.SelectedItem = "女魔术"
                    Case 65536
                        newForm.cmbClass.SelectedItem = "男变身"
                    Case 131027
                        newForm.cmbClass.SelectedItem = "女变身"
                End Select
                newForm.txtHair.Text = d("ChaHair")
                newForm.txtFace.Text = d("ChaFace")
                newForm.txtLife.Text = d("ChaLiving")
                newForm.txtLevel.Text = d("ChaLevel")
                newForm.txtChaMoney.Text = d("ChaMoney")
                newForm.txtPow.Text = d("ChaPower")
                newForm.txtStrong.Text = d("ChaStrong")
                newForm.txtStrength.Text = d("ChaStrength")
                newForm.txtInt.Text = d("ChaSpirit")
                newForm.txtDex.Text = d("ChaDex")
                newForm.txtChaIntel.Text = d("ChaIntel")
                newForm.txtStrRemain.Text = d("ChaStRemain")
                newForm.txtEXP.Text = d("ChaExp")
                newForm.txtHP.Text = d("ChaHP")
                newForm.txtMP.Text = d("ChaMP")
                newForm.txtSP.Text = d("ChaSP")
                newForm.txtX.Text = d("ChaPosX")
                newForm.txtY.Text = d("ChaPosY")
                newForm.txtZ.Text = d("ChaPosZ")
                newForm.txtBright.Text = d("ChaBright")
                newForm.txtFightA.Text = d("ChaFightA")
                newForm.txtShootA.Text = d("ChaShootA")
                newForm.txtPK.Text = d("ChaPK")
                newForm.txtSkillPoint.Text = d("ChaSkillPoint")
                newForm.txtInvenLine.Text = d("ChaInvenLine")
                newForm.cbDeleted.Checked = Convert.ToBoolean(d("ChaDeleted"))
            Loop
            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message + ex.StackTrace, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub GetClassSettings()
        Try
            xConn = New sqlConn()
            xConn.connectUser("Select * From CPSetting;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                RankingDisplay = d("RankingDisplay")
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub PopulatedCmbRank(ByRef cmb_Rank As ComboBox)
        Select Case RankingDisplay
            Case 0 'EP3
                cmb_Rank.Items.Add("格斗部")
                cmb_Rank.Items.Add("剑道部")
                cmb_Rank.Items.Add("弓箭部")
                cmb_Rank.Items.Add("气功部")
            Case 1 'EP4
                cmb_Rank.Items.Add("格斗部")
                cmb_Rank.Items.Add("剑道部")
                cmb_Rank.Items.Add("弓箭部")
                cmb_Rank.Items.Add("气功部")
                cmb_Rank.Items.Add("龙鳞部")
                cmb_Rank.Items.Add("龙凤部")
            Case 2 'EP6 四职业
                cmb_Rank.Items.Add("男格斗")
                cmb_Rank.Items.Add("女格斗")
                cmb_Rank.Items.Add("男剑道")
                cmb_Rank.Items.Add("女剑道")
                cmb_Rank.Items.Add("男弓箭")
                cmb_Rank.Items.Add("女弓箭")
                cmb_Rank.Items.Add("男气功")
                cmb_Rank.Items.Add("女气功")
            Case 3 'EP6
                cmb_Rank.Items.Add("男格斗")
                cmb_Rank.Items.Add("女格斗")
                cmb_Rank.Items.Add("男剑道")
                cmb_Rank.Items.Add("女剑道")
                cmb_Rank.Items.Add("男弓箭")
                cmb_Rank.Items.Add("女弓箭")
                cmb_Rank.Items.Add("男气功")
                cmb_Rank.Items.Add("女气功")
                cmb_Rank.Items.Add("男终极")
                cmb_Rank.Items.Add("女终极")
            Case 4 'EP7
                cmb_Rank.Items.Add("男格斗")
                cmb_Rank.Items.Add("女格斗")
                cmb_Rank.Items.Add("男剑道")
                cmb_Rank.Items.Add("女剑道")
                cmb_Rank.Items.Add("男弓箭")
                cmb_Rank.Items.Add("女弓箭")
                cmb_Rank.Items.Add("男气功")
                cmb_Rank.Items.Add("女气功")
                cmb_Rank.Items.Add("男终极")
                cmb_Rank.Items.Add("女终极")
                cmb_Rank.Items.Add("男超能")
                cmb_Rank.Items.Add("女超能")
            Case 5 'EP8
                cmb_Rank.Items.Add("男格斗")
                cmb_Rank.Items.Add("女格斗")
                cmb_Rank.Items.Add("男剑道")
                cmb_Rank.Items.Add("女剑道")
                cmb_Rank.Items.Add("男弓箭")
                cmb_Rank.Items.Add("女弓箭")
                cmb_Rank.Items.Add("男气功")
                cmb_Rank.Items.Add("女气功")
                cmb_Rank.Items.Add("男终极")
                cmb_Rank.Items.Add("女终极")
                cmb_Rank.Items.Add("男超能")
                cmb_Rank.Items.Add("女超能")
                cmb_Rank.Items.Add("男忍术")
                cmb_Rank.Items.Add("女忍术")
            Case 6 'EP9
                cmb_Rank.Items.Add("男格斗")
                cmb_Rank.Items.Add("女格斗")
                cmb_Rank.Items.Add("男剑道")
                cmb_Rank.Items.Add("女剑道")
                cmb_Rank.Items.Add("男弓箭")
                cmb_Rank.Items.Add("女弓箭")
                cmb_Rank.Items.Add("男气功")
                cmb_Rank.Items.Add("女气功")
                cmb_Rank.Items.Add("男终极")
                cmb_Rank.Items.Add("女终极")
                cmb_Rank.Items.Add("男超能")
                cmb_Rank.Items.Add("女超能")
                cmb_Rank.Items.Add("男忍术")
                cmb_Rank.Items.Add("女忍术")
                cmb_Rank.Items.Add("男魔术")
                cmb_Rank.Items.Add("女魔术")
            Case 7 'EP10
                cmb_Rank.Items.Add("男格斗")
                cmb_Rank.Items.Add("女格斗")
                cmb_Rank.Items.Add("男剑道")
                cmb_Rank.Items.Add("女剑道")
                cmb_Rank.Items.Add("男弓箭")
                cmb_Rank.Items.Add("女弓箭")
                cmb_Rank.Items.Add("男气功")
                cmb_Rank.Items.Add("女气功")
                cmb_Rank.Items.Add("男终极")
                cmb_Rank.Items.Add("女终极")
                cmb_Rank.Items.Add("男超能")
                cmb_Rank.Items.Add("女超能")
                cmb_Rank.Items.Add("男忍术")
                cmb_Rank.Items.Add("女忍术")
                cmb_Rank.Items.Add("男魔术")
                cmb_Rank.Items.Add("女魔术")
                cmb_Rank.Items.Add("男变身")
                cmb_Rank.Items.Add("女变身")
        End Select
    End Sub

    Private Sub frmAdChaSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetClassSettings()
    End Sub
End Class