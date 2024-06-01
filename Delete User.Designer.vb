<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Delete_User
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
        UIDtxt = New TextBox()
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
        Label1.Location = New Point(206, 283)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 5
        Label1.Text = "UserID:"
        ' 
        ' UIDtxt
        ' 
        UIDtxt.Location = New Point(308, 280)
        UIDtxt.Name = "UIDtxt"
        UIDtxt.Size = New Size(300, 23)
        UIDtxt.TabIndex = 8
        ' 
        ' Delete_User
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(UIDtxt)
        Controls.Add(Label1)
        Controls.Add(Closebtn)
        Controls.Add(Confirm)
        Controls.Add(DataGridView1)
        Name = "Delete_User"
        Text = "Delete User"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Confirm As Button
    Friend WithEvents Closebtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents UIDtxt As TextBox
End Class
