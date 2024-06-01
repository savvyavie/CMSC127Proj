<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class New_User
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
        DataGridView1 = New DataGridView()
        Confirm = New Button()
        Closebtn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        UIDtxt = New TextBox()
        FNametxt = New TextBox()
        LNametxt = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Emailtxt = New TextBox()
        Phonetxt = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(28, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(742, 199)
        DataGridView1.TabIndex = 2
        ' 
        ' Confirm
        ' 
        Confirm.Location = New Point(244, 379)
        Confirm.Name = "Confirm"
        Confirm.Size = New Size(154, 59)
        Confirm.TabIndex = 3
        Confirm.Text = "Confirm"
        Confirm.UseVisualStyleBackColor = True
        ' 
        ' Closebtn
        ' 
        Closebtn.Location = New Point(404, 379)
        Closebtn.Name = "Closebtn"
        Closebtn.Size = New Size(154, 59)
        Closebtn.TabIndex = 4
        Closebtn.Text = "Close"
        Closebtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(202, 227)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 5
        Label1.Text = "UserID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(202, 256)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 6
        Label2.Text = "First Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(202, 285)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 7
        Label3.Text = "Last Name:"
        ' 
        ' UIDtxt
        ' 
        UIDtxt.Location = New Point(304, 224)
        UIDtxt.Name = "UIDtxt"
        UIDtxt.Size = New Size(300, 23)
        UIDtxt.TabIndex = 8
        ' 
        ' FNametxt
        ' 
        FNametxt.Location = New Point(304, 253)
        FNametxt.Name = "FNametxt"
        FNametxt.Size = New Size(300, 23)
        FNametxt.TabIndex = 9
        ' 
        ' LNametxt
        ' 
        LNametxt.Location = New Point(304, 282)
        LNametxt.Name = "LNametxt"
        LNametxt.Size = New Size(300, 23)
        LNametxt.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(202, 314)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 11
        Label4.Text = "Email:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(202, 343)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 15)
        Label5.TabIndex = 12
        Label5.Text = "Phone Number:"
        ' 
        ' Emailtxt
        ' 
        Emailtxt.Location = New Point(304, 311)
        Emailtxt.Name = "Emailtxt"
        Emailtxt.Size = New Size(300, 23)
        Emailtxt.TabIndex = 13
        ' 
        ' Phonetxt
        ' 
        Phonetxt.Location = New Point(304, 340)
        Phonetxt.Name = "Phonetxt"
        Phonetxt.Size = New Size(300, 23)
        Phonetxt.TabIndex = 14
        ' 
        ' New_User
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Phonetxt)
        Controls.Add(Emailtxt)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(LNametxt)
        Controls.Add(FNametxt)
        Controls.Add(UIDtxt)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Closebtn)
        Controls.Add(Confirm)
        Controls.Add(DataGridView1)
        Name = "New_User"
        Text = "New User"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Confirm As Button
    Friend WithEvents Closebtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UIDtxt As TextBox
    Friend WithEvents FNametxt As TextBox
    Friend WithEvents LNametxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Emailtxt As TextBox
    Friend WithEvents Phonetxt As TextBox
End Class
