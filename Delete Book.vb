Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Delete_Book

    Private Sub Delete_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim COMMAND As MySqlCommand
        Dim MySQLConn As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=library_database"
        }

        Try
            MySQLConn.Open()
            Dim Query As String
            Query = "select * from books;"

            Dim dataTable As New DataTable()

            Using MySQLConn
                COMMAND = New MySqlCommand(Query, MySQLConn)
                Dim adapter As New MySqlDataAdapter(COMMAND)
                adapter.Fill(dataTable)
            End Using

            DataGridView1.DataSource = Nothing
            DataGridView1.Columns.Clear()

            DataGridView1.DataSource = dataTable

            MySQLConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        Dim COMMAND As MySqlCommand
        Dim MySQLConn As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=library_database"
        }

        Try
            MySQLConn.Open()
            Dim Query As String
            Query = "delete from books where book_id = '" & BookIDtxt.Text & "';"

            Dim dataTable As New DataTable

            Using MySQLConn
                COMMAND = New MySqlCommand(Query, MySQLConn)
                Dim adapter As New MySqlDataAdapter(COMMAND)
                adapter.Fill(dataTable)

                Query = "select * from books;"

                COMMAND = New MySqlCommand(Query, MySQLConn)
                adapter = New MySqlDataAdapter(COMMAND)
                adapter.Fill(dataTable)

                MessageBox.Show("Deletion Successful!")
            End Using

            BookIDtxt.Text = Nothing

            DataGridView1.DataSource = Nothing
            DataGridView1.Columns.Clear()

            DataGridView1.DataSource = dataTable

            MySQLConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        Me.Close()
    End Sub

End Class