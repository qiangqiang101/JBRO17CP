Public Class frmAdProductDetails

    Public editMode As Boolean = False
    Public id As Integer = 0
    Dim xConn As sqlConn

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If editMode Then
            Try
                xConn = New sqlConn()
                xConn.connectUser("Update CPProduct Set " &
                                  "[ItemName] = '" & txtName.Text & "', " &
                                  "[ItemDesc] = '" & txtDesc.Text & "', " &
                                   "[ItemImage] = '" & txtImage.Text & "', " &
                                   "[ItemType] = '" & cmbType.SelectedIndex & "', " &
                                   "[ItemCurrency] = '" & cmbCurrency.SelectedIndex & "', " &
                                   "[ItemPrice] = '" & txtPrice.Text & "', " &
                                    "[ItemRemain] = '" & txtRemain.Text & "', " &
                                    "[ItemEnable] = '" & Convert.ToInt32(cbEnable.Checked) & "' " &
                                    "Where ItemID = " & id & ";")
                xConn.UserSQLComm.Connection = xConn.UserSQLConn
                xConn.UserSQLComm.ExecuteNonQuery()
                xConn.UserSQLConn.Close()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            End Try
        Else
            Try
                xConn = New sqlConn()
                xConn.connectUser("Insert Into CPProduct (ItemName, ItemDesc, ItemImage, ItemType, ItemCurrency, ItemPrice, ItemRemain, ItemEnable) " _
                    & "VALUES (" _
                                & "'" & txtName.Text & "', " _
                                & "'" & txtDesc.Text & "', " _
                                & "'" & txtImage.Text & "', " _
                                & "'" & cmbType.SelectedIndex & "', " _
                                & "'" & cmbCurrency.SelectedIndex & "', " _
                                & "'" & txtPrice.Text & "', " _
                                & "'" & txtRemain.Text & "', " _
                                & "'" & Convert.ToInt32(cbEnable.Checked) & "');")
                xConn.UserSQLComm.Connection = xConn.UserSQLConn
                xConn.UserSQLComm.ExecuteNonQuery()
                xConn.UserSQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            Finally
                Me.Close()
            End Try
        End If
    End Sub
End Class