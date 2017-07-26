Imports System.Data.SqlClient
Imports System.Threading

Public Class frmShop

    Dim xConn As sqlConn
    Dim thread As Thread
    Dim item As shopItem

    Private Sub frmShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        'CreateDemo()

        thread = New Thread(Sub() PopulatePanel())
        thread.Start()
    End Sub

    Private Sub CreateDemo()
        Dim d1 As shopItem = New shopItem With {.Value = "火爆浪子套裝(30D)", .CurrencyMethod = shopItem.CurrencyType.Gold, .Price = 1000000}
        d1.SetWebImage("https://www.9buddy.com/yong/stored/shop/ShopImage/Icon/231030.gif")
        Dim d2 As shopItem = New shopItem With {.Value = "烈焰紅摩托車服裝禮盒(15D)", .CurrencyMethod = shopItem.CurrencyType.ePoint, .Price = 150}
        d2.SetWebImage("https://www.9buddy.com/yong/stored/shop/ShopImage/Icon/231185.gif")
        Dim d3 As shopItem = New shopItem With {.Value = "Signal 摩托車", .CurrencyMethod = shopItem.CurrencyType.ePoint, .Price = 150}
        d3.SetWebImage("https://www.9buddy.com/yong/stored/shop/ShopImage/Icon/161071.gif")
        Dim d4 As shopItem = New shopItem With {.Value = "歸魂修煉念珠(1D)", .CurrencyMethod = shopItem.CurrencyType.ePoint, .Price = 99}
        d4.SetWebImage("https://www.9buddy.com/yong/stored/shop/ShopImage/Icon/115047.gif")
        Dim d5 As shopItem = New shopItem With {.Value = "封印之塔快速通行證(20T) 禮盒", .CurrencyMethod = shopItem.CurrencyType.ePoint, .Price = 400}
        d5.SetWebImage("https://www.9buddy.com/yong/stored/shop/ShopImage/Icon/413475.jpg")
        Dim d6 As shopItem = New shopItem With {.Value = "擴音器(30T)", .CurrencyMethod = shopItem.CurrencyType.ePoint, .Price = 30}
        d6.SetWebImage("https://www.9buddy.com/yong/stored/shop/ShopImage/Icon/117008.gif")

        flpShop.Controls.Add(d1)
        flpShop.Controls.Add(d2)
        flpShop.Controls.Add(d3)
        flpShop.Controls.Add(d4)
        flpShop.Controls.Add(d5)
        flpShop.Controls.Add(d6)
    End Sub

    Private Sub PopulatePanel()
        Try
            If InvokeRequired Then
                BeginInvoke(DirectCast(Sub()
                                           flpShop.Controls.Clear()
                                           xConn = New sqlConn()
                                           xConn.connectUser("Select * From CPProduct Where ItemEnable='1';")

                                           xConn.UserSQLComm.Connection = xConn.UserSQLConn
                                           Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
                                           Do While d.Read
                                               item = New shopItem With {.Value = d("ItemName"), .CurrencyMethod = CInt(d("ItemCurrency")), .Price = d("ItemPrice"), .Remaining = d("ItemRemain"), .Desciption = d("ItemDesc")}
                                               item.SetWebImage(d("ItemImage"))
                                               flpShop.Controls.Add(item)
                                           Loop

                                           xConn.UserSQLConn.Close()
                                       End Sub, MethodInvoker))
            Else
                flpShop.Controls.Clear()
                xConn = New sqlConn()
                xConn.connectUser("Select * From CPProduct Where ItemEnable='1';")

                xConn.UserSQLComm.Connection = xConn.UserSQLConn
                Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
                Do While d.Read
                    item = New shopItem With {.Value = d("ItemName"), .CurrencyMethod = CInt(d("ItemCurrency")), .Price = d("ItemPrice"), .Remaining = d("ItemRemain"), .Desciption = d("ItemDesc")}
                    item.SetWebImage(d("ItemImage"))
                    flpShop.Controls.Add(item)
                Loop

                xConn.UserSQLConn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub PopulatePanel(ItemType As Integer)
        Try
            If InvokeRequired Then
                BeginInvoke(DirectCast(Sub()
                                           flpShop.Controls.Clear()
                                           xConn = New sqlConn()
                                           xConn.connectUser(String.Format("Select * From CPProduct Where ItemType='{0}' And ItemEnable='1';", ItemType))

                                           xConn.UserSQLComm.Connection = xConn.UserSQLConn
                                           Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
                                           Do While d.Read
                                               item = New shopItem With {.Value = d("ItemName"), .CurrencyMethod = CInt(d("ItemCurrency")), .Price = d("ItemPrice"), .Remaining = d("ItemRemain"), .Desciption = d("ItemDesc")}
                                               item.SetWebImage(d("ItemImage"))
                                               flpShop.Controls.Add(item)
                                           Loop

                                           xConn.UserSQLConn.Close()
                                       End Sub, MethodInvoker))
            Else
                flpShop.Controls.Clear()
                xConn = New sqlConn()
                xConn.connectUser(String.Format("Select * From CPProduct Where ItemType='{0}' And ItemEnable='1';", ItemType))

                xConn.UserSQLComm.Connection = xConn.UserSQLConn
                Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
                Do While d.Read
                    item = New shopItem With {.Value = d("ItemName"), .CurrencyMethod = CInt(d("ItemCurrency")), .Price = d("ItemPrice"), .Remaining = d("ItemRemain"), .Desciption = d("ItemDesc")}
                    item.SetWebImage(d("ItemImage"))
                    flpShop.Controls.Add(item)
                Loop

                xConn.UserSQLConn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub fbWeapon_Click(sender As Object, e As EventArgs) Handles fbWeapon.Click
        If Not thread.IsAlive Then
            thread = New Thread(Sub() PopulatePanel(0))
            thread.Start()
        End If
    End Sub

    Private Sub fbArmour_Click(sender As Object, e As EventArgs) Handles fbArmour.Click
        If Not thread.IsAlive Then
            thread = New Thread(Sub() PopulatePanel(1))
            thread.Start()
        End If
    End Sub

    Private Sub fbAccessory_Click(sender As Object, e As EventArgs) Handles fbAccessory.Click
        If Not thread.IsAlive Then
            thread = New Thread(Sub() PopulatePanel(2))
            thread.Start()
        End If
    End Sub

    Private Sub fbHair_Click(sender As Object, e As EventArgs) Handles fbHair.Click
        If Not thread.IsAlive Then
            thread = New Thread(Sub() PopulatePanel(3))
            thread.Start()
        End If
    End Sub

    Private Sub fbSkill_Load(sender As Object, e As EventArgs) Handles fbSkill.Click
        If Not thread.IsAlive Then
            thread = New Thread(Sub() PopulatePanel(4))
            thread.Start()
        End If
    End Sub

    Private Sub fbVehicle_Click(sender As Object, e As EventArgs) Handles fbVehicle.Click
        If Not thread.IsAlive Then
            thread = New Thread(Sub() PopulatePanel(5))
            thread.Start()
        End If
    End Sub

    Private Sub fbPets_Click(sender As Object, e As EventArgs) Handles fbPets.Click
        If Not thread.IsAlive Then
            thread = New Thread(Sub() PopulatePanel(6))
            thread.Start()
        End If
    End Sub

    Private Sub fbSet_Click(sender As Object, e As EventArgs) Handles fbSet.Click
        If Not thread.IsAlive Then
            thread = New Thread(Sub() PopulatePanel(7))
            thread.Start()
        End If
    End Sub

    Private Sub fbMisc_Click(sender As Object, e As EventArgs) Handles fbMisc.Click
        If Not thread.IsAlive Then
            thread = New Thread(Sub() PopulatePanel(8))
            thread.Start()
        End If
    End Sub
End Class