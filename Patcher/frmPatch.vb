Imports System.ComponentModel
Imports System.Net
Imports System.Threading

Public Class frmPatch

    Dim thread As Thread
    Dim WithEvents wc As New WebClient

    Private Sub frmPatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        For Each arg As String In My.Application.CommandLineArgs
            Select Case (LCase(arg))
                Case "/updatecp"
                    thread = New Thread(AddressOf DownloadUpdate)
                    thread.Start()
                    Exit Sub
            End Select
        Next

        MsgBox("This Exe don't execute independent.", MsgBoxStyle.OkOnly, "error")
        End
    End Sub

    Private Sub KillControlPanel()
        Dim myProcesses As Process()
        Dim myProcess As Process

        myProcesses = Process.GetProcessesByName("controlpanel.exe")
        For Each myProcess In myProcesses
            myProcess.Kill()
        Next

        myProcesses = Nothing
        myProcess = Nothing
    End Sub

    Private Sub DownloadUpdate()
        Try
            KillControlPanel()
            Threading.Thread.Sleep(2000)
            wc.DownloadFileAsync(New Uri("https://github.com/qiangqiang101/JBRO17CP/blob/master/JBRanOnlineCP/bin/Release/Secured/controlpanel.exe?raw=true"), "controlpanel.exe")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub WC_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles wc.DownloadProgressChanged
        Try
            ProgressBar1.Value = e.ProgressPercentage
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub WC_DownloadProgressCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs) Handles wc.DownloadFileCompleted
        Try
            If Not thread.IsAlive Then
                Process.Start(".\controlpanel.exe")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
        End Try
    End Sub
End Class
