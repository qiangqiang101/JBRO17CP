Public Class frmAdCPMain
    Private Sub tsmSetting_Click(sender As Object, e As EventArgs) Handles tsmSetting.Click
        Try
            Dim newForm As frmAdSetting = New frmAdSetting
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsmUser_Click(sender As Object, e As EventArgs) Handles tsmUser.Click
        Try
            Dim newForm As frmAdUserSetting = New frmAdUserSetting
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmAdCPMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If Not frmCP.Visible Then
            End
        End If
    End Sub

    Private Sub tsmTransaction_Click(sender As Object, e As EventArgs) Handles tsmTransaction.Click
        Try
            Dim newForm As frmAdTransaction = New frmAdTransaction
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsmProducts_Click(sender As Object, e As EventArgs) Handles tsmProducts.Click
        Try
            Dim newForm As frmAdShopMgmt = New frmAdShopMgmt
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsmAddProduct_Click(sender As Object, e As EventArgs) Handles tsmAddProduct.Click
        Try
            Dim newForm As frmAdProductDetails = New frmAdProductDetails
            newForm.Text = "添加产品"
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsmShopTransaction_Click(sender As Object, e As EventArgs) Handles tsmShopTransaction.Click
        Try
            Dim newForm As frmAdShopOrder = New frmAdShopOrder
            cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub
End Class