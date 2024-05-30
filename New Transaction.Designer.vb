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
        BorrowOp.Location = New Point(295, 217)
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
        ReturnOp.Location = New Point(432, 217)
        ReturnOp.Name = "ReturnOp"
        ReturnOp.Size = New Size(60, 19)
        ReturnOp.TabIndex = 4
        ReturnOp.TabStop = True
        ReturnOp.Text = "Return"
        ReturnOp.UseVisualStyleBackColor = True
        ' 
        ' Closebtn
        ' 
        Closebtn.Location = New Point(400, 379)
        Closebtn.Name = "Closebtn"
        Closebtn.Size = New Size(154, 59)
        Closebtn.TabIndex = 6
        Closebtn.Text = "Close"
        Closebtn.UseVisualStyleBackColor = True
        ' 
        ' Confirm
        ' 
        Confirm.Location = New Point(240, 379)
        Confirm.Name = "Confirm"
        Confirm.Size = New Size(154, 59)
        Confirm.TabIndex = 5
        Confirm.Text = "Confirm"
        Confirm.UseVisualStyleBackColor = True
        ' 
        ' New_Transaction
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
End Class
