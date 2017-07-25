Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmAdTransaction

    Dim xConn As sqlConn
    Dim items As New ListViewItem()

    Private Sub btn_SearchUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SearchUser.Click
        RefreshTransaction()
    End Sub

    Private Sub RefreshTransaction()
        Try
            lvUser.Items.Clear()
            xConn = New sqlConn()
            xConn.connectUser("Select * From CPTransaction Where UserName Like '%" & txt_SearchUser.Text & "%' Order By ID Desc;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                items = lvUser.Items.Add(d("UserName".ToString))
                With items
                    Dim id As Integer = d("ID")
                    .SubItems.Add(id.ToString("00000"))
                    .SubItems.Add(d("Bank"))
                    Dim amount As Integer = d("Amount")
                    .SubItems.Add(amount.ToString("N"))
                    .SubItems.Add(d("Currency"))
                    .SubItems.Add(d("Channel"))
                    .SubItems.Add(d("Date"))
                    Dim Status As String = d("Status")
                    Select Case Status
                        Case "New"
                            .SubItems.Add("新建")
                        Case "Processing"
                            .SubItems.Add("处理中")
                        Case "Approve"
                            .SubItems.Add("批准")
                        Case "Reject"
                            .SubItems.Add("拒绝")
                    End Select
                    .SubItems.Add(d("Reason"))
                End With
            Loop
            xConn.UserSQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub frmAdTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshTransaction()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RefreshTransaction()
    End Sub

    Private Sub lvUser_DoubleClick(sender As Object, e As EventArgs) Handles lvUser.DoubleClick
        Try
            Dim newForm As frmAdTransDetails = New frmAdTransDetails

            xConn = New sqlConn()
            xConn.connectUser("Select * From CPTransaction Where ID = '" & lvUser.SelectedItems.Item(0).SubItems(1).Text & "';")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                newForm.lblID.Text = d("ID")
                newForm.lblUserName.Text = d("UserName")
                newForm.Text = String.Format("汇款ID：{0}", d("ID"))
                newForm.lblBank.Text = d("Bank")
                newForm.lblAmount.Text = String.Format("{0} {1}", d("Amount"), d("Currency"))
                newForm.amount = d("Amount")
                newForm.curency = d("Currency")
                newForm.lblChannel.Text = d("Channel")
                newForm.lblDate.Text = C2Date(d("Date"))
                Dim Status As String = d("Status")
                Select Case Status
                    Case "New"
                        newForm.lblStatus.Text = "新建"
                    Case "Processing"
                        newForm.lblStatus.Text = "处理中"
                    Case "Approve"
                        newForm.lblStatus.Text = "批准"
                    Case "Reject"
                        newForm.lblStatus.Text = "拒绝"
                End Select
                newForm.cmbRejectReason.SelectedText = d("Reason")
                newForm.lblRef.Text = d("RefSEQNo")
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

    Private Function C2Time(Time As String) As String
        Time = Time.Replace(".0000000", "")
        Return CDate(Time).ToLongTimeString
    End Function
End Class