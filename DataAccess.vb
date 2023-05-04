Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data

Public Class DataAccess

    Private connectionString As String

    'Public Sub New(connectionStr As String)
    '    connectionString = connectionStr
    'End Sub

    Public Sub New()
        ' Retrieve the connection string from the configuration file
        connectionString = ConfigurationManager.ConnectionStrings("DBName").ConnectionString
    End Sub

    Public Function GetDataAsDataTable(query As String) As DataTable
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                Using adapter As New SqlDataAdapter(command)
                    ' Fill the DataTable with the data from the SQL query
                    adapter.Fill(dataTable)
                End Using
            End Using

            connection.Close()
        End Using

        Return dataTable
    End Function

    Public Function ExecuteNonQuery(query As String)
        Dim strError As String = ""
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    ' Execute the SQL query that does not return any data
                    command.ExecuteNonQuery()
                End Using

                connection.Close()
            End Using
        Catch ex As Exception
            strError = ex.Message
        End Try

        Return strError
    End Function

End Class
