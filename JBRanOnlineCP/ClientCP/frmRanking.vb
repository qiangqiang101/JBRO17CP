Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmRanking

    Dim xConn As sqlConn
    Dim items As New ListViewItem()

    Private Sub frmRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Case "格斗部"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='1' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "剑道部"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='2' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "弓箭部"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='4' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
            Case "气功部"
                selectedItem = "Select Top 30 * From ChaInfo Where ChaClass='8' Order By ChaIntel Desc, ChaLevel Desc, ChaMoney Desc;"
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
                        Case 1
                            .SubItems.Add("格斗部")
                        Case 2
                            .SubItems.Add("剑道部")
                        Case 4
                            .SubItems.Add("弓箭部")
                        Case 8
                            .SubItems.Add("气功部")
                        Case Else
                            .SubItems.Add("终极部")
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
End Class