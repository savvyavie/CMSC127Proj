Imports MySql.Data.MySqlClient
Imports Mysqlx.Expect.Open.Types

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
                         from (transactions natural join users) natural join books order by transaction_id;"
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

            If TransactionIDtxt.Text = Nothing Or UIDtxt.Text = Nothing Or BookIDtxt.Text = Nothing Then
                MessageBox.Show("Incomplete information!")
            ElseIf BorrowOp.Checked = True Then
                Using MySQLConn
                    Query = "insert into transactions values('" &
                             TransactionIDtxt.Text & "', '" &
                             UIDtxt.Text & "', '" &
                             BookIDtxt.Text & "', '" &
                             dateTimeString & "', NULL);

                             update users set currently_borrowed_counter = currently_borrowed_counter + 1
                             where user_id = '" & UIDtxt.Text & "';"

                    COMMAND = New MySqlCommand(Query, MySQLConn)
                    Dim adapter As New MySqlDataAdapter(COMMAND)
                    adapter.Fill(dataTable)

                    Query = "select transaction_id, user_id, book_id, name, title, author, ISBN, genre, borrow_date, return_date
                         from (transactions natural join users) natural join books order by transaction_id;"

                    COMMAND = New MySqlCommand(Query, MySQLConn)
                    adapter = New MySqlDataAdapter(COMMAND)
                    adapter.Fill(dataTable)
                End Using

                DataGridView1.DataSource = Nothing
                DataGridView1.Columns.Clear()

                DataGridView1.DataSource = dataTable

                MessageBox.Show("Borrow Successful!")

                TransactionIDtxt.Text = Nothing
                BookIDtxt.Text = Nothing
                UIDtxt.Text = Nothing

            ElseIf ReturnOp.Checked = True Then
                Using MySQLConn
                    Query = "update transactions
                             set return_date = '" & dateTimeString &
                             "' where transaction_id = '" &
                             TransactionIDtxt.Text & "' and user_id = '" &
                             UIDtxt.Text & "' and book_id = '" &
                             BookIDtxt.Text & "' and return_date is NULL;

                             update users set currently_borrowed_counter = currently_borrowed_counter - 1
                             where user_id = '" & UIDtxt.Text & "' and currently_borrowed_counter > 0;"


                    COMMAND = New MySqlCommand(Query, MySQLConn)
                    Dim adapter As New MySqlDataAdapter(COMMAND)
                    adapter.Fill(dataTable)

                    Query = "select transaction_id, user_id, book_id, name, title, author, ISBN, genre, borrow_date, return_date
                         from (transactions natural join users) natural join books order by transaction_id;"

                    COMMAND = New MySqlCommand(Query, MySQLConn)
                    adapter = New MySqlDataAdapter(COMMAND)
                    adapter.Fill(dataTable)
                End Using

                DataGridView1.DataSource = Nothing
                DataGridView1.Columns.Clear()

                DataGridView1.DataSource = dataTable

                MessageBox.Show("Return Successful!")

                TransactionIDtxt.Text = Nothing
                BookIDtxt.Text = Nothing
                UIDtxt.Text = Nothing

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