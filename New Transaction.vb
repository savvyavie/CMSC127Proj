Imports MySql.Data.MySqlClient

Public Class New_Transaction
    Private Sub New_Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim COMMAND As MySqlCommand
        Dim MySQLConn As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=library_database"
        }

        Try
            MySQLConn.Open()
            Dim Query As String
            Query = "select transaction_id, user_id, name, title, author, ISBN, genre, borrow_date, return_date
                         from (transactions natural join users) natural join books;"

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

        If BorrowOp.Checked = True Then
            MessageBox.Show("Hi!")
        ElseIf ReturnOp.Checked = True Then
            MessageBox.Show("There!")
        Else

        End If

        Try
            MySQLConn.Open()
            Dim Query As String
            Query = ""

            If BorrowOp.Checked = True Then
                MessageBox.Show("Hi!")
            ElseIf ReturnOp.Checked = True Then
                MessageBox.Show("There!")
            Else

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

    Private Sub BorrowOp_CheckedChanged(sender As Object, e As EventArgs) Handles BorrowOp.CheckedChanged

    End Sub

    Private Sub ReturnOp_CheckedChanged(sender As Object, e As EventArgs) Handles ReturnOp.CheckedChanged

    End Sub
End Class