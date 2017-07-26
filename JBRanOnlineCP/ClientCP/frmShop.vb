Public Class frmShop
    Private Sub frmShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class