Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class New_Book

    Private Sub New_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim COMMAND As MySqlCommand
        Dim MySQLConn As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=library_database; Convert Zero Datetime=True"
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
            .ConnectionString = "server=localhost;userid=root;database=library_database;Convert Zero Datetime=True"
        }

        Try
            MySQLConn.Open()
            Dim Query As String
            Query = ""
            Dim dataTable As New DataTable

            If BookIDtxt.Text = Nothing Or Titletxt.Text = Nothing Or Authortxt.Text = Nothing Or ISBNtxt.Text = Nothing Or Genretxt.Text = Nothing Then
                MessageBox.Show("Incomplete information!")
            Else
                Using MySQLConn
                    Query = "insert into books(book_id, title, author, ISBN, genre, publication_date) values ('" &
                    BookIDtxt.Text & "', '" &
                    Titletxt.Text & "', '" &
                    Authortxt.Text & "', '" &
                    ISBNtxt.Text & "', '" &
                    Genretxt.Text & "', '" &
                    PubDate.Text & "');"

                    COMMAND = New MySqlCommand(Query, MySQLConn)
                    Dim adapter As New MySqlDataAdapter(COMMAND)
                    adapter.Fill(dataTable)

                    Query = "select * from books;"

                    COMMAND = New MySqlCommand(Query, MySQLConn)
                    adapter = New MySqlDataAdapter(COMMAND)
                    adapter.Fill(dataTable)
                End Using

                BookIDtxt.Text = Nothing
                Titletxt.Text = Nothing
                Authortxt.Text = Nothing
                ISBNtxt.Text = Nothing
                Genretxt.Text = Nothing

                DataGridView1.DataSource = Nothing
                DataGridView1.Columns.Clear()

                DataGridView1.DataSource = dataTable

            End If


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