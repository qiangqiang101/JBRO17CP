Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmTransaction

    Dim xConn As sqlConn
    Dim items As New ListViewItem()

    Private Sub frmTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactionHistory()
    End Sub

    Private Sub LoadTransactionHistory()
        Try
            lvHistory.Items.Clear()
            xConn = New sqlConn()
            xConn.connectUser(String.Format("Select Top 20 * From CPTransaction Where UserName='{0}' Order By ID Desc;", frmCP.myUserName))

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                items = lvHistory.Items.Add(d("Bank"))
                With items
                    Dim id As Integer = d("ID")
                    .SubItems.Add(id.ToString("00000"))
                    Dim amount As Integer = d("Amount")
                    .SubItems.Add(amount.ToString("N"))
                    .SubItems.Add(d("Currency"))
                    .SubItems.Add(d("Channel"))
                    .SubItems.Add(C2Date(d("Date")))
                    Dim Status As String = d("Status")
                    Select Case Status
                        Case "New"
                            .SubItems.Add("新建", Color.Blue, Color.White, Me.Font)
                        Case "Processing"
                            .SubItems.Add("处理中", Color.Yellow, Color.White, Me.Font)
                        Case "Approve"
                            .SubItems.Add("批准", Color.Green, Color.White, Me.Font)
                        Case "Reject"
                            .SubItems.Add("拒绝", Color.Red, Color.White, Me.Font)
                    End Select
                    .SubItems.Add(d("Reason"))
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

    Private Function C2Time(Time As String) As String
        Time = Time.Replace(".0000000", "")
        Return CDate(Time).ToLongTimeString
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim newForm As frmTopup = New frmTopup
            newForm.txt_TUUserName.Text = frmCP.myUserName
            frmCP.cpTab.TabPages.Add(newForm)
        Catch ex As Exception
        End Try
    End Sub
End Class