<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class New_Book
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
        BookIDtxt = New TextBox()
        Titletxt = New TextBox()
        Authortxt = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        ISBNtxt = New TextBox()
        Genretxt = New TextBox()
        PubDate = New DateTimePicker()
        Label6 = New Label()
        Label7 = New Label()
        Copiestxt = New TextBox()
        Newrad = New RadioButton()
        Existingrad = New RadioButton()
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
        Confirm.Location = New Point(243, 379)
        Confirm.Name = "Confirm"
        Confirm.Size = New Size(154, 59)
        Confirm.TabIndex = 3
        Confirm.Text = "Confirm"
        Confirm.UseVisualStyleBackColor = True
        ' 
        ' Closebtn
        ' 
        Closebtn.Location = New Point(403, 379)
        Closebtn.Name = "Closebtn"
        Closebtn.Size = New Size(154, 59)
        Closebtn.TabIndex = 4
        Closebtn.Text = "Close"
        Closebtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 230)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 15)
        Label1.TabIndex = 5
        Label1.Text = "BookID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 259)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 15)
        Label2.TabIndex = 6
        Label2.Text = "Title:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(59, 288)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 7
        Label3.Text = "Author:"
        ' 
        ' BookIDtxt
        ' 
        BookIDtxt.Location = New Point(161, 227)
        BookIDtxt.Name = "BookIDtxt"
        BookIDtxt.Size = New Size(300, 23)
        BookIDtxt.TabIndex = 8
        ' 
        ' Titletxt
        ' 
        Titletxt.Location = New Point(161, 256)
        Titletxt.Name = "Titletxt"
        Titletxt.Size = New Size(300, 23)
        Titletxt.TabIndex = 9
        ' 
        ' Authortxt
        ' 
        Authortxt.Location = New Point(161, 285)
        Authortxt.Name = "Authortxt"
        Authortxt.Size = New Size(300, 23)
        Authortxt.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 317)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 11
        Label4.Text = "ISBN:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(59, 346)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 12
        Label5.Text = "Genre:"
        ' 
        ' ISBNtxt
        ' 
        ISBNtxt.Location = New Point(161, 314)
        ISBNtxt.Name = "ISBNtxt"
        ISBNtxt.Size = New Size(300, 23)
        ISBNtxt.TabIndex = 13
        ' 
        ' Genretxt
        ' 
        Genretxt.Location = New Point(161, 343)
        Genretxt.Name = "Genretxt"
        Genretxt.Size = New Size(300, 23)
        Genretxt.TabIndex = 14
        ' 
        ' PubDate
        ' 
        PubDate.CustomFormat = "yyyy-MM-dd"
        PubDate.Format = DateTimePickerFormat.Custom
        PubDate.Location = New Point(532, 251)
        PubDate.Name = "PubDate"
        PubDate.Size = New Size(200, 23)
        PubDate.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(583, 233)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 15)
        Label6.TabIndex = 16
        Label6.Text = "Publishing Date:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(557, 285)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 15)
        Label7.TabIndex = 17
        Label7.Text = "Number of Copies:"
        ' 
        ' Copiestxt
        ' 
        Copiestxt.Location = New Point(670, 282)
        Copiestxt.Name = "Copiestxt"
        Copiestxt.Size = New Size(39, 23)
        Copiestxt.TabIndex = 18
        ' 
        ' Newrad
        ' 
        Newrad.AutoSize = True
        Newrad.Checked = True
        Newrad.Location = New Point(532, 314)
        Newrad.Name = "Newrad"
        Newrad.Size = New Size(79, 19)
        Newrad.TabIndex = 19
        Newrad.TabStop = True
        Newrad.Text = "New Book"
        Newrad.UseVisualStyleBackColor = True
        ' 
        ' Existingrad
        ' 
        Existingrad.AutoSize = True
        Existingrad.Location = New Point(636, 314)
        Existingrad.Name = "Existingrad"
        Existingrad.Size = New Size(96, 19)
        Existingrad.TabIndex = 20
        Existingrad.Text = "Existing Book"
        Existingrad.UseVisualStyleBackColor = True
        ' 
        ' New_Book
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Existingrad)
        Controls.Add(Newrad)
        Controls.Add(Copiestxt)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(PubDate)
        Controls.Add(Genretxt)
        Controls.Add(ISBNtxt)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Authortxt)
        Controls.Add(Titletxt)
        Controls.Add(BookIDtxt)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Closebtn)
        Controls.Add(Confirm)
        Controls.Add(DataGridView1)
        Name = "New_Book"
        Text = "New Book"
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
    Friend WithEvents BookIDtxt As TextBox
    Friend WithEvents Titletxt As TextBox
    Friend WithEvents Authortxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ISBNtxt As TextBox
    Friend WithEvents Genretxt As TextBox
    Friend WithEvents PubDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Copiestxt As TextBox
    Friend WithEvents Newrad As RadioButton
    Friend WithEvents Existingrad As RadioButton
End Class
