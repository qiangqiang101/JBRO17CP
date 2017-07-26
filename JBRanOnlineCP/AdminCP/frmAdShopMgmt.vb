Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmAdShopMgmt

    Dim xConn As sqlConn
    Dim items As New ListViewItem()

    Private Sub RefreshProducts()
        Try
            lvProducts.Items.Clear()
            xConn = New sqlConn()
            xConn.connectUser("Select * From CPProduct Where ItemName Like '%" & txtSearchProduct.Text & "%';")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                items = lvProducts.Items.Add(d("ItemName".ToString))
                With items
                    .SubItems.Add(d("ItemID"))
                    Dim Type As Integer = d("ItemType")
                    Select Case Type
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
                    .SubItems.Add(d("ItemPrice"))
                    Dim Currency As Integer = d("ItemCurrency")
                    Select Case Currency
                        Case 0
                            .SubItems.Add("游戏币")
                        Case 1
                            .SubItems.Add("积分")
                    End Select
                    .SubItems.Add(d("ItemRemain"))
                    Dim Enable As Integer = d("ItemEnable")
                    Select Case Enable
                        Case 0
                            .SubItems.Add("是")
                        Case 1
                            .SubItems.Add("否")
                    End Select
                End With
            Loop
            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub frmShopMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshProducts()
    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        RefreshProducts()
    End Sub

    Private Sub lvProducts_DoubleClick(sender As Object, e As EventArgs) Handles lvProducts.DoubleClick
        Try
            Dim newForm As frmAdProductDetails = New frmAdProductDetails

            xConn = New sqlConn()
            xConn.connectUser("Select * From CPProduct Where ItemID = '" & lvProducts.SelectedItems.Item(0).SubItems(1).Text & "';")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                newForm.id = d("ItemID")
                newForm.txtName.Text = d("ItemName")
                newForm.Text = String.Format("产品ID：{0}", d("ItemID"))
                newForm.txtDesc.Text = d("ItemDesc")
                newForm.txtImage.Text = d("ItemImage")
                newForm.txtPrice.Text = d("ItemPrice")
                newForm.txtRemain.Text = d("ItemRemain")
                newForm.cmbCurrency.SelectedIndex = d("ItemCurrency")
                newForm.cmbType.SelectedIndex = d("ItemType")
                Dim enable As Integer = d("ItemEnable")
                newForm.cbEnable.Checked = Convert.ToBoolean(enable)
                newForm.editMode = True
            Loop
            xConn.UserSQLConn.Close()

            frmAdCPMain.cpTab.TabPages.Add(newForm)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub
End Class