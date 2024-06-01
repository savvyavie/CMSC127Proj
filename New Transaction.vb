Imports MySql.Data.MySqlClient

Public Class New_Transaction
    Private Sub New_Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim COMMAND As MySqlCommand
        Dim MySQLConn As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=library_database;Convert Zero Datetime=True"
        }

        Try
            MySQLConn.Open()
            Dim Query As String

            Dim dataTable As New DataTable()

            Using MySQLConn
                Query = "select transaction_id, user_id, book_id, name, title, borrow_date, return_date
                         from (transactions natural join users) natural join books;"
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
            Dim currentTime As DateTime = DateTime.Now
            Dim dateTimeString As String = currentTime.ToString("yyyy-MM-dd hh:mm:ss")
            Dim Query As String

            Dim dataTable As New DataTable()

            If BorrowOp.Checked = True Then

                Using MySQLConn
                    Query = "insert into transactions"

                    COMMAND = New MySqlCommand(Query, MySQLConn)
                    Dim adapter As New MySqlDataAdapter(COMMAND)
                    adapter.Fill(dataTable)
                End Using

                DataGridView1.DataSource = Nothing
                DataGridView1.Columns.Clear()

                DataGridView1.DataSource = dataTable

            ElseIf ReturnOp.Checked = True Then
                MessageBox.Show("There!")
            End If



            MySQLConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        Me.Close()
    End Sub
End Class