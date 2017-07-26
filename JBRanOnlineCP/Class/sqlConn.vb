Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class sqlConn

#Region "Class Members"
    Friend WithEvents UserSQLConn As New SqlConnection()
    Friend WithEvents UserSQLComm As New SqlCommand()

    Friend WithEvents GameSQLConn As New SqlConnection()
    Friend WithEvents GameSQLComm As New SqlCommand()

    Private userSqlString As String
    Private gameSqlString As String
    Private err As System.Exception

    Private Server_Enc As String = ReadCfgValue("cpServer", My.Application.Info.DirectoryPath & "\param.cfg") '192.168.0.188
    Private User_Enc As String = ReadCfgValue("cpUser", My.Application.Info.DirectoryPath & "\param.cfg") 'sa
    Private Password_Enc As String = ReadCfgValue("cpPassword", My.Application.Info.DirectoryPath & "\param.cfg") 'cnran1234

    'Settings
    Private Server As String = Decrypt(Server_Enc)
    Private UserDB As String = "RanUser"
    Private GameDB As String = "RanGame1"
    Private User As String = Decrypt(User_Enc)
    Private Password As String = Decrypt(Password_Enc)

    Public Shared dataReturned As New ArrayList()
#End Region

#Region "class methods"

    Sub New()
    End Sub

    Function connectUser(ByVal userSqlString) As Boolean
        Try
            'RANSERVE-596C66\SQLEXPRESS 'Server=192.168.0.188;Database=RanUser;User=sa;Pwd=cnran1234;
            UserSQLConn = New SqlConnection With {.ConnectionString = "Server=" & Server & ";Database=" & UserDB & ";User=" & User & ";Pwd=" & Password & ";"}
            UserSQLConn.Open()
            UserSQLComm.CommandText = userSqlString
            Return True
        Catch err As System.Exception
            MsgBox(err.Message)
            Return False
        End Try
    End Function

    Function connectGame(ByVal gameSqlString) As Boolean
        Try
            'RANSERVE-596C66\SQLEXPRESS
            GameSQLConn = New SqlConnection With {.ConnectionString = "Server=" & Server & ";Database=" & GameDB & ";User=" & User & ";Pwd=" & Password & ";"}
            GameSQLConn.Open()
            GameSQLComm.CommandText = gameSqlString
            Return True
        Catch err As System.Exception
            MsgBox(err.Message)
            Return False
        End Try
    End Function

    Function getUser() As ArrayList
        Try

            UserSQLComm.Connection = UserSQLConn

            getUser = New ArrayList()

            Dim d As SqlDataReader = UserSQLComm.ExecuteReader()
            Do While d.Read
                getUser.Add(d("UsrName".ToString))
            Loop

            'Returns array collection
            dataReturned = getUser

            Try
                UserSQLConn.Close()
            Catch err As System.Exception
                MsgBox(err.Message)
            End Try
        Catch err As System.Exception
            MsgBox(err.Message)
        End Try
    End Function
#End Region
End Class
