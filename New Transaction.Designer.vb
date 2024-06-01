<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Transaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        BorrowOp = New RadioButton()
        ReturnOp = New RadioButton()
        Closebtn = New Button()
        Confirm = New Button()
        BookIDtxt = New TextBox()
        UIDtxt = New TextBox()
        TransactionIDtxt = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(29, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(742, 199)
        DataGridView1.TabIndex = 2
        ' 
        ' BorrowOp
        ' 
        BorrowOp.AutoSize = True
        BorrowOp.Checked = True
        BorrowOp.Location = New Point(299, 217)
        BorrowOp.Name = "BorrowOp"
        BorrowOp.Size = New Size(63, 19)
        BorrowOp.TabIndex = 3
        BorrowOp.TabStop = True
        BorrowOp.Text = "Borrow"
        BorrowOp.UseVisualStyleBackColor = True
        ' 
        ' ReturnOp
        ' 
        ReturnOp.AutoSize = True
        ReturnOp.Location = New Point(436, 217)
        ReturnOp.Name = "ReturnOp"
        ReturnOp.Size = New Size(60, 19)
        ReturnOp.TabIndex = 4
        ReturnOp.Text = "Return"
        ReturnOp.UseVisualStyleBackColor = True
        ' 
        ' Closebtn
        ' 
        Closebtn.Location = New Point(404, 379)
        Closebtn.Name = "Closebtn"
        Closebtn.Size = New Size(154, 59)
        Closebtn.TabIndex = 6
        Closebtn.Text = "Close"
        Closebtn.UseVisualStyleBackColor = True
        ' 
        ' Confirm
        ' 
        Confirm.Location = New Point(244, 379)
        Confirm.Name = "Confirm"
        Confirm.Size = New Size(154, 59)
        Confirm.TabIndex = 5
        Confirm.Text = "Confirm"
        Confirm.UseVisualStyleBackColor = True
        ' 
        ' BookIDtxt
        ' 
        BookIDtxt.Location = New Point(304, 317)
        BookIDtxt.Name = "BookIDtxt"
        BookIDtxt.Size = New Size(300, 23)
        BookIDtxt.TabIndex = 16
        ' 
        ' UIDtxt
        ' 
        UIDtxt.Location = New Point(304, 288)
        UIDtxt.Name = "UIDtxt"
        UIDtxt.Size = New Size(300, 23)
        UIDtxt.TabIndex = 15
        ' 
        ' TransactionIDtxt
        ' 
        TransactionIDtxt.Location = New Point(304, 259)
        TransactionIDtxt.Name = "TransactionIDtxt"
        TransactionIDtxt.Size = New Size(300, 23)
        TransactionIDtxt.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(202, 320)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 15)
        Label3.TabIndex = 13
        Label3.Text = "BookID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(202, 291)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 12
        Label2.Text = "UserID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(202, 262)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 11
        Label1.Text = "TransactionID:"
        ' 
        ' New_Transaction
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BookIDtxt)
        Controls.Add(UIDtxt)
        Controls.Add(TransactionIDtxt)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Closebtn)
        Controls.Add(Confirm)
        Controls.Add(ReturnOp)
        Controls.Add(BorrowOp)
        Controls.Add(DataGridView1)
        Name = "New_Transaction"
        Text = "New Transaction"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BorrowOp As RadioButton
    Friend WithEvents ReturnOp As RadioButton
    Friend WithEvents Closebtn As Button
    Friend WithEvents Confirm As Button
    Friend WithEvents BookIDtxt As TextBox
    Friend WithEvents UIDtxt As TextBox
    Friend WithEvents TransactionIDtxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
