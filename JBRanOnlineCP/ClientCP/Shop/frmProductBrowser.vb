Imports System.Data.SqlClient

Public Class frmProductBrowser

    Dim xConn As sqlConn
    Public pID As Integer
    Public currencyMethod As Integer
    Public price, totalPrice As Integer
    Private ChaMoney As Integer = 0
    Private type As Integer = 0

    Private Sub NumbericKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Dim ValidChars As String = "0123456789"
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        Dim cm As String = Nothing
        Select Case currencyMethod
            Case 0
                cm = "游戏币"
            Case 1
                cm = "积分"
        End Select

        lblPrice.Text = String.Format("{0} {1}", price * CInt(txtQty.Text), cm)
        totalPrice = price * CInt(txtQty.Text)
    End Sub

    Public Sub GetData()
        Try
            xConn = New sqlConn()
            xConn.connectUser(String.Format("Select * From CPProduct Where ItemID='{0}' And ItemEnable='1';", pID))

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                type = d("ItemType")
                Select Case type
                    Case 0
                        lblType.Text = "武器"
                    Case 1
                        lblType.Text = "服装"
                    Case 2
                        lblType.Text = "首饰"
                    Case 3
                        lblType.Text = "发型"
                    Case 4
                        lblType.Text = "技能书"
                    Case 5
                        lblType.Text = "载具"
                    Case 6
                        lblType.Text = "宠物"
                    Case 7
                        lblType.Text = "套餐"
                    Case 8
                        lblType.Text = "其它"
                End Select
                lblRemain.Text = d("ItemRemain")
                lblName.Text = d("ItemName")
                currencyMethod = CInt(d("ItemCurrency"))
                price = CInt(d("ItemPrice"))
                totalPrice = price
                Select Case currencyMethod
                    Case 0
                        lblPrice.Text = String.Format("{0} 游戏币", price)
                    Case 1
                        lblPrice.Text = String.Format("{0} 积分", price)
                End Select
                lblDesc.Text = d("ItemDesc")
            Loop

            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try

        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where UserNum = '" & frmCP.userNum & "' And ChaDeleted=0;")

            xConn.GameSQLComm.Connection = xConn.GameSQLConn

            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                cmb_Char.Items.Add(d("ChaName".ToString))
            Loop

            xConn.GameSQLConn.Close()

            Try
                cmb_Char.SelectedIndex = 0
            Catch ex As Exception
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub frmProductBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrEmpty(txtQty.Text) Then
            MsgBox("当前操作有误！", MsgBoxStyle.Critical, "错误")
            txtQty.Focus()
        ElseIf txtQty.Text = "0" Then
            MsgBox("当前操作有误！", MsgBoxStyle.Critical, "错误")
            txtQty.Focus()
        ElseIf frmCP.OnlineCheck(cmb_Char.SelectedItem) Then
            MsgBox("购买失败，角色还在线上，请下线后再试。", MsgBoxStyle.Critical, "错误")
        ElseIf String.IsNullOrEmpty(cmb_Char.SelectedItem) Then
            MsgBox("请选择要购买的角色！", MsgBoxStyle.Critical, "错误")
        ElseIf String.Equals(currencyMethod.ToString, "0") Then
            If GetCharMoney() < price Then
                MsgBox("购买失败，角色游戏币不足。", MsgBoxStyle.Critical, "错误")
            Else
                GoTo Buy
            End If
        ElseIf String.Equals(currencyMethod.ToString, "1") Then
            If frmCP.myPoint < price Then
                MsgBox("购买失败，积分不足。", MsgBoxStyle.Critical, "错误")
            Else
                GoTo Buy
            End If
        Else
Buy:
            Try
                If InsertOrderRecord() = False Then
                    If UpdateProduct() = False Then
                        If UpdateCharMoneyOrJifen() = False Then
                            Try
                                Dim newForm As frmShopOrder = New frmShopOrder
                                frmCP.cpTab.TabPages.Add(newForm)
                            Catch ex As Exception
                            End Try
                            frmCP.RefreshData()
                            frmCP.UpdateData()
                            Me.Close()
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            End Try
        End If
    End Sub

    Private Function InsertOrderRecord() As Boolean
        Dim goterror As Boolean = False

        Try
            xConn = New sqlConn()
            xConn.connectUser("Insert Into CPOrder (ItemName, ItemType, ItemCurrency, ItemPrice, ItemQty, UserName, CharName, OrderStatus) " _
                & "VALUES (" _
                            & "'" & lblName.Text & "', " _
                            & "'" & type & "', " _
                            & "'" & currencyMethod & "', " _
                            & "'" & totalPrice & "', " _
                            & "'" & txtQty.Text & "', " _
                            & "'" & frmCP.myUserName & "', " _
                            & "'" & cmb_Char.SelectedItem & "', " _
                            & "'New');")
            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            xConn.UserSQLComm.ExecuteNonQuery()
            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            goterror = True
            Exit Try
        End Try

        Return goterror
    End Function

    Private Function UpdateProduct() As Boolean
        Dim goterror As Boolean = False
        Dim remain As Integer = lblRemain.Text
        Dim newRemain As Integer = remain - txtQty.Text

        Try
            xConn = New sqlConn()
            xConn.connectUser("Update CPProduct Set [ItemRemain] = '" & newRemain & "' Where ItemID = " & pID & ";")
            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            xConn.UserSQLComm.ExecuteNonQuery()
            xConn.UserSQLConn.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            goterror = True
            Exit Try
        End Try

        Return goterror
    End Function

    Private Function GetCharMoney() As Integer
        Dim money As Integer = 0

        Try
            xConn = New sqlConn()
            xConn.connectGame("Select * From ChaInfo Where ChaName = '" & cmb_Char.SelectedItem & "';")
            xConn.GameSQLComm.Connection = xConn.GameSQLConn

            Dim d As SqlDataReader = xConn.GameSQLComm.ExecuteReader()
            Do While d.Read
                money = d("ChaMoney")
            Loop
            xConn.GameSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try

        Return money
    End Function

    Private Sub AdjustPoints(howMany As Integer)
        Try
            xConn = New sqlConn()
            xConn.connectUser(String.Format("Update UserInfo Set [UserPoint] = '{0}' Where UserName = '{1}';", frmCP.myPoint - howMany, frmCP.myUserName))
            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            xConn.UserSQLComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub AdjustMoney(howMany As Integer)
        Try
            xConn = New sqlConn()
            xConn.connectGame(String.Format("Update ChaInfo Set [ChaMoney] = '{0}' Where ChaName = '{1}';", ChaMoney - howMany, frmCP.myUserName))
            xConn.GameSQLComm.Connection = xConn.GameSQLConn
            xConn.GameSQLComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Function UpdateCharMoneyOrJifen() As Boolean
        Dim goterror As Boolean = False

        Try
            Select Case currencyMethod
                Case 0
                    AdjustMoney(totalPrice)
                Case 1
                    AdjustPoints(totalPrice)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            goterror = True
            Exit Try
        End Try

        Return goterror
    End Function

End Class