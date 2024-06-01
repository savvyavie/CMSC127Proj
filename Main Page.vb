Imports MySql.Data.MySqlClient

Public Class Main_Page

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Users")
        ComboBox1.Items.Add("Books")
        ComboBox1.Items.Add("Transactions")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim COMMAND As MySqlCommand
        Dim MySQLConn As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=library_database"
        }

        Try
            MySQLConn.Open()
            Dim Query As String
            Query = ""

            If ComboBox1.Text = "Users" Then
                Query = "select * from users;"
            ElseIf ComboBox1.Text = "Books" Then
                Query = "select * from books;"
            ElseIf ComboBox1.Text = "Transactions" Then
                Query = "select transaction_id, book_id, user_id, name, title, author, ISBN, genre, borrow_date, return_date
                         from (transactions natural join users) natural join books order by transaction_id;"
            End If

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

    Private Sub NewUserBtn_Click(sender As Object, e As EventArgs) Handles newUserBtn.Click
        New_User.Show()
    End Sub

    Private Sub NewBookBtn_Click(sender As Object, e As EventArgs) Handles newBookBtn.Click
        New_Book.Show()
    End Sub

    Private Sub DeleteUserBtn_Click(sender As Object, e As EventArgs) Handles deleteUserBtn.Click
        Delete_User.Show()
    End Sub

    Private Sub DeleteBookBtn_Click(sender As Object, e As EventArgs) Handles deleteBookBtn.Click
        Delete_Book.Show()
    End Sub

    Private Sub NewTransactionBtn_Click(sender As Object, e As EventArgs) Handles newTransactionBtn.Click
        New_Transaction.Show()
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        Dim COMMAND As MySqlCommand
        Dim MySQLConn As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=library_database"
        }

        Try
            MySQLConn.Open()
            Dim Query As String
            Query = ""

            If ComboBox1.Text = "Users" Then
                Query = "select * from users;"
            ElseIf ComboBox1.Text = "Books" Then
                Query = "select * from books;"
            ElseIf ComboBox1.Text = "Transactions" Then
                Query = "select transaction_id, user_id, name, title, author, ISBN, genre, borrow_date, return_date
                         from (transactions natural join users) natural join books;"
            End If

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

End Class
