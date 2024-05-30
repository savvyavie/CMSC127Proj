<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        newUserBtn = New Button()
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        newBookBtn = New Button()
        deleteUserBtn = New Button()
        deleteBookBtn = New Button()
        Label1 = New Label()
        newTransactionBtn = New Button()
        Refreshbtn = New Button()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' newUserBtn
        ' 
        newUserBtn.Location = New Point(207, 337)
        newUserBtn.Name = "newUserBtn"
        newUserBtn.Size = New Size(129, 50)
        newUserBtn.TabIndex = 0
        newUserBtn.Text = "New User"
        newUserBtn.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(27, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(747, 253)
        DataGridView1.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(395, 271)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 2
        ' 
        ' newBookBtn
        ' 
        newBookBtn.Location = New Point(207, 388)
        newBookBtn.Name = "newBookBtn"
        newBookBtn.Size = New Size(129, 50)
        newBookBtn.TabIndex = 3
        newBookBtn.Text = "New Book"
        newBookBtn.UseVisualStyleBackColor = True
        ' 
        ' deleteUserBtn
        ' 
        deleteUserBtn.Location = New Point(342, 337)
        deleteUserBtn.Name = "deleteUserBtn"
        deleteUserBtn.Size = New Size(129, 50)
        deleteUserBtn.TabIndex = 4
        deleteUserBtn.Text = "Delete User"
        deleteUserBtn.UseVisualStyleBackColor = True
        ' 
        ' deleteBookBtn
        ' 
        deleteBookBtn.Location = New Point(342, 388)
        deleteBookBtn.Name = "deleteBookBtn"
        deleteBookBtn.Size = New Size(129, 50)
        deleteBookBtn.TabIndex = 5
        deleteBookBtn.Text = "Delete Book"
        deleteBookBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(307, 274)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 6
        Label1.Text = "Select a table:"
        ' 
        ' newTransactionBtn
        ' 
        newTransactionBtn.Location = New Point(477, 337)
        newTransactionBtn.Name = "newTransactionBtn"
        newTransactionBtn.Size = New Size(129, 101)
        newTransactionBtn.TabIndex = 7
        newTransactionBtn.Text = "New Transaction"
        newTransactionBtn.UseVisualStyleBackColor = True
        ' 
        ' Refreshbtn
        ' 
        Refreshbtn.Location = New Point(307, 300)
        Refreshbtn.Name = "Refreshbtn"
        Refreshbtn.Size = New Size(209, 29)
        Refreshbtn.TabIndex = 8
        Refreshbtn.Text = "Refresh"
        Refreshbtn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 337)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 90)
        Label2.TabIndex = 9
        Label2.Text = "NOTE: " & vbCrLf & "No search function available" & vbCrLf & "in this version. Update funtions" & vbCrLf & "are limited to number of book" & vbCrLf & "copies and number of books" & vbCrLf & "borrowed per user."
        ' 
        ' Main_Page
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Refreshbtn)
        Controls.Add(newTransactionBtn)
        Controls.Add(Label1)
        Controls.Add(deleteBookBtn)
        Controls.Add(deleteUserBtn)
        Controls.Add(newBookBtn)
        Controls.Add(ComboBox1)
        Controls.Add(DataGridView1)
        Controls.Add(newUserBtn)
        Name = "Main_Page"
        Text = "Welcome - Library System"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents newUserBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents newBookBtn As Button
    Friend WithEvents deleteUserBtn As Button
    Friend WithEvents deleteBookBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents newTransactionBtn As Button
    Friend WithEvents Refreshbtn As Button
    Friend WithEvents Label2 As Label

End Class
