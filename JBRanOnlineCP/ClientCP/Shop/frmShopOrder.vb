Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmShopOrder

    Dim xConn As sqlConn
    Dim items As New ListViewItem()

    Private Sub frmShopOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderHistory()
    End Sub

    Private Sub LoadOrderHistory()
        Try
            lvHistory.Items.Clear()
            xConn = New sqlConn()
            xConn.connectUser(String.Format("Select Top 30 * From CPOrder Where UserName='{0}' Order By OrderID Desc;", frmCP.myUserName))

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                items = lvHistory.Items.Add(d("ItemName"))
                With items
                    Dim id As Integer = d("OrderID")
                    .SubItems.Add(id.ToString("00000"))
                    .SubItems.Add(d("CharName"))
                    Dim type As Integer = d("ItemType")
                    Select Case type
                        Case 0
                            .SubItems.Add("武器")
                        Case 1
                            .SubItems.Add("服装")
                        Case 2
                            .SubItems.Add("首饰")
                        Case 3
                            .SubItems.Add("发型")
                        Case 4
                            .SubItems.Add("技能书")
                        Case 5
                            .SubItems.Add("载具")
                        Case 6
                            .SubItems.Add("宠物")
                        Case 7
                            .SubItems.Add("套餐")
                        Case 8
                            .SubItems.Add("其它")
                    End Select
                    .SubItems.Add(d("ItemQty"))
                    Dim amount As Integer = d("ItemPrice")
                    .SubItems.Add(amount)
                    Dim currency As Integer = d("ItemCurrency")
                    Select Case currency
                        Case 0
                            .SubItems.Add("游戏币")
                        Case 1
                            .SubItems.Add("积分")
                    End Select
                    .SubItems.Add(C2Date(d("OrderDate")))
                    Dim Status As String = d("OrderStatus")
                    Select Case Status
                        Case "New"
                            .SubItems.Add("新建", Color.Blue, Color.White, Me.Font)
                            .SubItems.Add("取消", Color.Blue, Color.White, Me.Font)
                        Case "Processing"
                            .SubItems.Add("处理中", Color.Yellow, Color.White, Me.Font)
                        Case "Approve"
                            .SubItems.Add("批准", Color.Green, Color.White, Me.Font)
                        Case "Reject"
                            .SubItems.Add("拒绝", Color.Red, Color.White, Me.Font)
                        Case "Cancel"
                            .SubItems.Add("取消", Color.Purple, Color.White, Me.Font)
                    End Select
                End With

                For i As Integer = 0 To lvHistory.Items.Count - 1
                    lvHistory.Items(i).UseItemStyleForSubItems = False
                Next
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Function C2Date(Tarikh As String) As String
        Tarikh = CDate(Tarikh).ToShortDateString
        Return Tarikh
    End Function

    Private Sub lvHistory_MouseClick(sender As Object, e As MouseEventArgs) Handles lvHistory.MouseClick
        Try
            If lvHistory.SelectedItems.Count = 0 Then Exit Sub

            Dim mousePos As Point = lvHistory.PointToClient(Control.MousePosition)
            Dim hitTest As ListViewHitTestInfo = lvHistory.HitTest(mousePos)
            Dim info As ListViewHitTestInfo = lvHistory.HitTest(e.Y, e.Y)
            Dim columnIndex As Integer = hitTest.Item.SubItems.IndexOf(hitTest.SubItem)
            Dim rowIndex As String = info.SubItem.Text

            If Not IsNothing(info.SubItem) Then
                Dim cancelString As String = lvHistory.SelectedItems(0).SubItems(9).Text
                If ((columnIndex = 9 AndAlso String.Equals(lvHistory.SelectedItems(0).SubItems(1).Text, rowIndex)) AndAlso cancelString = "取消") Then
                    Dim result As Integer = MessageBox.Show("你确定要取消？", "取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        CancelPurchase(rowIndex)
                        LoadOrderHistory()
                    End If
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub CancelPurchase(id As Integer)
        Try
            xConn = New sqlConn()
            xConn.connectUser("Update CPOrder Set [OrderStatus]='Cancel' Where OrderID = " & id & ";")
            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            xConn.UserSQLComm.ExecuteNonQuery()
            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub
End Class