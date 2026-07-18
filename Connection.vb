Imports MySql.Data
Imports MySql.Data.MySqlClient

Module Connection

    Private connectionString As String = "Server=127.0.0.1;Port=3306;Database=event_management_db;Uid=root;Pwd=;"

    Public conn As MySqlConnection = New MySqlConnection(connectionString)

    Public Function OpenConnection() As MySqlConnection

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()

            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("OpenConnection error: " & ex.ToString())
            MessageBox.Show("Failed to open database connection. Please check your network and try again.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return conn

    End Function

    Public Sub CloseConnection()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()

            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("CloseConnection error: " & ex.ToString())
            MessageBox.Show("Failed to close database connection.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Module
