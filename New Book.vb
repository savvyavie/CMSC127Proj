﻿Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class New_Book

    Private Sub New_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim COMMAND As MySqlCommand
        Dim MySQLConn As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=library_database"
        }

        Try
            MySQLConn.Open()
            Dim Query As String
            Query = "select * from users;"

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
            Query = "insert into users(user_id, name, email, phone_number, currently_borrowed_counter) values ('" &
                UIDtxt.Text & "', '" &
                FNametxt.Text & " " &
                LNametxt.Text & "', '" &
                Emailtxt.Text & "', '" &
                Phonetxt.Text & "', 0);"

            Dim dataTable As New DataTable

            Using MySQLConn
                COMMAND = New MySqlCommand(Query, MySQLConn)
                Dim adapter As New MySqlDataAdapter(COMMAND)
                adapter.Fill(dataTable)

                Query = "select * from users;"

                COMMAND = New MySqlCommand(Query, MySQLConn)
                adapter = New MySqlDataAdapter(COMMAND)
                adapter.Fill(dataTable)
            End Using

            UIDtxt.Text = Nothing
            FNametxt.Text = Nothing
            LNametxt.Text = Nothing
            Emailtxt.Text = Nothing
            Phonetxt.Text = Nothing

            MessageBox.Show("Insert Successful!")

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
        Me.Hide()
        Main_Page.Show()
    End Sub
End Class