Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading

Public Class frmLoad

    Dim xConn As sqlConn
    Private thread As Thread
    Dim connected As Boolean = False

    Private Sub frmLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        For Each arg As String In My.Application.CommandLineArgs
            Select Case (LCase(arg))
                Case "/reg"
                    'thread = New Thread(AddressOf ReadRegister)
                    'thread.Start()
                    ReadRegister()
                    Exit Sub
                Case "/admincp"
                    'thread = New Thread(AddressOf ReadAdmin)
                    'thread.Start()
                    ReadAdmin()
                    Exit Sub
            End Select
        Next
        'thread = New Thread(AddressOf ReadServer)
        'thread.Start()
        ReadServer()
    End Sub
    Private Sub ReadServer()
        Try
            Dim tcb As TimerCallback = AddressOf Timeout
            Dim t As Timer = New Timer(tcb, Nothing, 30000, -1)

            xConn = New sqlConn()
            xConn.connectUser("Select * From CPSetting;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                frmRegister.CharRemain = d("CharRemain")
                frmRegister.CharTestRemain = d("CharTestRemain")
                frmReborn.Reborn = d("MaxReborn")
                frmReborn.PrimaryLevel = d("RBPrimaryLvl")
                frmReborn.SecondaryLevel = d("RBSecondaryLvl")
                frmReborn.AdvanceLevel = d("RBAdvanceLvl")
                frmReborn.PrimaryReborn = d("RBPrimary")
                frmReborn.SecondaryReborn = d("RBSecondary")
                frmReborn.AdvanceReborn = d("RBAdvance")
                frmReborn.PrimaryStat = d("RBPrimaryStat")
                frmReborn.SecondaryStat = d("RBSecondaryStat")
                frmReborn.AdvanceStat = d("RBAdvanceStat")
                frmReborn.PrimaryGold = d("RBPrimaryGold")
                frmReborn.SecondaryGold = d("RBSecondaryGold")
                frmReborn.AdvanceGold = d("RBAdvanceGold")
                frmReborn.RebornWait = d("RebornWait")
                frmAddPoint.AddStatGold = d("AddStatGold")
                frmChgSchool.ChangeSchoolGold = d("ChgSchoolGold")
                frmClearRed.ClearPKGold = d("ClearPKGold")
                frmRename.ChangeNameGold = d("ChgNameGold")
                frmRename.ChangeNameWait = d("ChgNameWait")
                frmCP.FormName = d("FormName")
                frmFgtPwd.EmailAddr = d("EmailAddr")
                frmFgtPwd.Password = d("EmailPwd")
                frmFgtPwd.Port = d("EmailPort")
                frmFgtPwd.Host = d("EmailHost")
                frmFgtPwd.Subject = d("EmailSubject")
            Loop

            xConn.UserSQLConn.Close()
            connected = True

            Me.Hide()
            Threading.Thread.Sleep(1)
            frmLogin.Show()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub ReadRegister()
        Try
            Dim tcb As TimerCallback = AddressOf Timeout
            Dim t As Timer = New Timer(tcb, Nothing, 10000, -1)

            xConn = New sqlConn()
            xConn.connectUser("Select * From CPSetting;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                frmRegister.CharRemain = d("CharRemain")
                frmRegister.CharTestRemain = d("CharTestRemain")
            Loop

            xConn.UserSQLConn.Close()
            frmRegister.Show()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub ReadAdmin()
        Try
            Dim tcb As TimerCallback = AddressOf Timeout
            Dim t As Timer = New Timer(tcb, Nothing, 10000, -1)

            xConn = New sqlConn()
            xConn.connectUser("Select * From CPSetting;")

            xConn.UserSQLComm.Connection = xConn.UserSQLConn
            Dim d As SqlDataReader = xConn.UserSQLComm.ExecuteReader()
            Do While d.Read
                frmAdLogin.AdminPass = d("AdminPass")
            Loop

            xConn.UserSQLConn.Close()
            frmAdLogin.Show()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub Timeout()
        Timer1.Stop()
        If Not connected Then
            MsgBox("连接超时.", MsgBoxStyle.Exclamation, "错误")
            End
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pbLoading.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        pbLoading.Refresh()
    End Sub
End Class
