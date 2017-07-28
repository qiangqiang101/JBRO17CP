Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmAdShopOrder

    Dim xConn As sqlConn
    Dim items As New ListViewItem()

    Private Sub RefreshTransaction()
        Try
            lvUser.Items.Clear()
            xConn = New sqlConn()
            xConn.connectUser("Select * From CPOrder Where UserName Like '%" & txt_SearchUser.Text & "%' Order By OrderID Desc;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                items = lvUser.Items.Add(d("UserName".ToString))
                With items
                    Dim id As Integer = d("OrderID")
                    .SubItems.Add(id.ToString("00000"))
                    .SubItems.Add(d("CharName"))
                    .SubItems.Add(d("ItemName"))
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
                    .SubItems.Add(amount.ToString("N"))
                    Dim currency As Integer = d("ItemCurrency")
                    Select Case currency
                        Case 0
                            .SubItems.Add("游戏币")
                        Case 1
                            .SubItems.Add("积分")
                    End Select
                    .SubItems.Add(d("OrderDate"))
                    Dim Status As String = d("OrderStatus")
                    Select Case Status
                        Case "New"
                            .SubItems.Add("新建", Color.Blue, Color.White, Me.Font)
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

                For i As Integer = 0 To lvUser.Items.Count - 1
                    lvUser.Items(i).UseItemStyleForSubItems = False
                Next
            Loop
            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub frmAdShopOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshTransaction()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RefreshTransaction()
    End Sub

    Private Sub lvUser_DoubleClick(sender As Object, e As EventArgs) Handles lvUser.DoubleClick
        Try
            Dim newForm As frmAdOrderDetails = New frmAdOrderDetails

            xConn = New sqlConn()
            xConn.connectUser("Select * From CPOrder Where OrderID = '" & lvUser.SelectedItems.Item(0).SubItems(1).Text & "';")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                newForm.lblID.Text = d("OrderID")
                newForm.lblUserName.Text = d("UserName")
                newForm.Text = String.Format("购物ID：{0}", d("OrderID"))
                newForm.lblCharName.Text = d("CharName")
                Dim currency As Integer = d("ItemCurrency")
                Select Case currency
                    Case 0
                        newForm.lblPrice.Text = String.Format("{0} 游戏币", d("ItemPrice"))
                    Case 1
                        newForm.lblPrice.Text = String.Format("{0} 积分", d("ItemPrice"))
                End Select
                newForm.amount = d("ItemPrice")
                newForm.curency = d("ItemCurrency")
                newForm.lblQty.Text = d("ItemQty")
                newForm.lblDate.Text = C2Date(d("OrderDate"))
                Dim Status As String = d("OrderStatus")
                Select Case Status
                    Case "New"
                        newForm.lblStatus.Text = "新建"
                    Case "Processing"
                        newForm.lblStatus.Text = "处理中"
                    Case "Approve"
                        newForm.lblStatus.Text = "批准"
                    Case "Reject"
                        newForm.lblStatus.Text = "拒绝"
                    Case "Cancel"
                        newForm.lblStatus.Text = "取消"
                End Select
                newForm.lblItemName.Text = d("ItemName")
                Dim type As Integer = d("ItemType")
                Select Case type
                    Case 0
                        newForm.lblType.Text = "武器"
                    Case 1
                        newForm.lblType.Text = "服装"
                    Case 2
                        newForm.lblType.Text = "首饰"
                    Case 3
                        newForm.lblType.Text = "发型"
                    Case 4
                        newForm.lblType.Text = "技能书"
                    Case 5
                        newForm.lblType.Text = "载具"
                    Case 6
                        newForm.lblType.Text = "宠物"
                    Case 7
                        newForm.lblType.Text = "套餐"
                    Case 8
                        newForm.lblType.Text = "其它"
                End Select
            Loop
            xConn.UserSQLConn.Close()

            frmAdCPMain.cpTab.TabPages.Add(newForm)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Function C2Date(Tarikh As String) As String
        Tarikh = CDate(Tarikh).ToShortDateString
        Return Tarikh
    End Function

    Private Sub btn_SearchUser_Click(sender As Object, e As EventArgs) Handles btn_SearchUser.Click
        RefreshTransaction()
    End Sub
End Class