Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text

Public Class frmRanking

    Dim xConn As sqlConn
    Dim items As New ListViewItem()
    Dim RankingDisplay As Integer

    Private Sub PopulatedCmbRank()
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

    Private Sub frmRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        PopulatedCmbRank()
        cmb_Rank.SelectedIndex = 0
    End Sub

    Private Sub cmb_Rank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Rank.SelectedIndexChanged
        Dim selectedItem As String
        Select Case cmb_Rank.SelectedItem
            Case "总排行"
                selectedItem = "Select Top 30 * From ChaInfo Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "圣门学院"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaSchool='0' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "玄岩学院"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaSchool='1' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "凤凰学院"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaSchool='2' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "格斗部", "男格斗"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='1' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "剑道部"， “男剑道”
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='2' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "弓箭部", "女弓箭"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='4' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "气功部", "女气功"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='8' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "龙鳞部", "男终极"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='16' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "龙凤部", "女终极"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='32' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "女格斗"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='64' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "女剑道"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='128' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "男弓箭"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='256' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "男气功"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='512' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "男超能"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='1024' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "女超能"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='2048' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "男忍术"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='4096' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "女忍术"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='8192' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "男魔术"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='16384' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "女魔术"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='32768' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "男变身"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='65536' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "女变身"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='131072' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "大富翁"
                selectedItem = "Select Top 30 * From ChaInfo Order By ChaMoney Desc;"
        End Select

        Try
            lvRank.Items.Clear()
            xConn = New sqlConn()
            xConn.connectGame(selectedItem)

            xConn.GameSQLComm.Connection = xConn.GameSQLConn
            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                items = lvRank.Items.Add(d("ChaName"))
                With items
                    .SubItems.Add(items.Index + 1)
                    .SubItems.Add(d("ChaIntel"))
                    .SubItems.Add(d("ChaLevel"))
                    Dim _ChaClass As Integer = d("ChaClass")
                    Select Case _ChaClass
                        Case 1, 64
                            .SubItems.Add("格斗部")
                        Case 2, 128
                            .SubItems.Add("剑道部")
                        Case 4, 256
                            .SubItems.Add("弓箭部")
                        Case 8, 512
                            .SubItems.Add("气功部")
                        Case 16, 32
                            .SubItems.Add("终极部")
                        Case 1024, 2048
                            .SubItems.Add("超能部")
                        Case 4096, 8192
                            .SubItems.Add("忍术部")
                        Case 16384, 32768
                            .SubItems.Add("魔术部")
                        Case 65536, 131027
                            .SubItems.Add("变身部")
                        Case Else
                            .SubItems.Add("未知")
                    End Select
                    Dim _ChaSchool As Integer = d("ChaSchool")
                    Select Case _ChaSchool
                        Case 0
                            .SubItems.Add("圣门学院")
                        Case 1
                            .SubItems.Add("玄岩学院")
                        Case 2
                            .SubItems.Add("凤凰学院")
                    End Select
                    Dim _ChaMoney As String = d("ChaMoney".ToString)
                    Dim _ChaMoney2 As Decimal = _ChaMoney.Substring(0, _ChaMoney.Length - 5)
                    .SubItems.Add(_ChaMoney2.ToString("N"))
                End With
            Loop

            xConn.GameSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub tsmi_Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmi_Copy.Click
        If lvRank.SelectedItems.Count = 0 Then Exit Sub
        Clipboard.Clear()
        Clipboard.SetText(lvRank.SelectedItems(0).Text)
    End Sub

    Private Sub RefreshData()
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
End Class