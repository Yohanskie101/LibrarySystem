<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserReturnBooks
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Connection = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatabaseLoginNewDataSet1 = New LibrarySystemProject.DatabaseLoginNewDataSet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Fee = New System.Windows.Forms.ComboBox()
        Me.txt_Usertype = New System.Windows.Forms.DateTimePicker()
        Me.txt_FullName = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseLoginNewDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(865, 518)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 62)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(48, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Return Books"
        '
        'txt_ID
        '
        Me.txt_ID.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ID.Location = New System.Drawing.Point(138, 142)
        Me.txt_ID.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txt_ID.Multiline = True
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(204, 22)
        Me.txt_ID.TabIndex = 3
        '
        'txt_Username
        '
        Me.txt_Username.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Username.Location = New System.Drawing.Point(138, 177)
        Me.txt_Username.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txt_Username.Multiline = True
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(204, 22)
        Me.txt_Username.TabIndex = 4
        '
        'txt_Password
        '
        Me.txt_Password.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Password.Location = New System.Drawing.Point(138, 212)
        Me.txt_Password.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txt_Password.Multiline = True
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(204, 22)
        Me.txt_Password.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(636, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Connection State:"
        '
        'lbl_Connection
        '
        Me.lbl_Connection.AutoSize = True
        Me.lbl_Connection.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_Connection.Location = New System.Drawing.Point(734, 78)
        Me.lbl_Connection.Name = "lbl_Connection"
        Me.lbl_Connection.Size = New System.Drawing.Size(92, 13)
        Me.lbl_Connection.TabIndex = 9
        Me.lbl_Connection.Text = "Connection State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(96, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(69, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "UserID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(69, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "BookID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(440, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "DateBorrowed"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(459, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "ReturnDate"
        '
        'Btn_Save
        '
        Me.Btn_Save.BackColor = System.Drawing.Color.LightGray
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Save.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save.Location = New System.Drawing.Point(358, 257)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(89, 28)
        Me.Btn_Save.TabIndex = 15
        Me.Btn_Save.Text = "Return"
        Me.Btn_Save.UseVisualStyleBackColor = False
        '
        'Btn_Clear
        '
        Me.Btn_Clear.BackColor = System.Drawing.Color.LightGray
        Me.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Clear.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Clear.Location = New System.Drawing.Point(453, 257)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(89, 28)
        Me.Btn_Clear.TabIndex = 18
        Me.Btn_Clear.Text = "Clear"
        Me.Btn_Clear.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(51, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Search :"
        '
        'txt_Search
        '
        Me.txt_Search.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Search.Location = New System.Drawing.Point(132, 297)
        Me.txt_Search.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txt_Search.Multiline = True
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(330, 22)
        Me.txt_Search.TabIndex = 20
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(56, 337)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(870, 145)
        Me.DataGridView1.TabIndex = 21
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 43
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "UserID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 65
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "BookID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 68
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "DateBorrowed"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "ReturnDate"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "OverDueFee"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 93
        '
        'DatabaseLoginNewDataSet1
        '
        Me.DatabaseLoginNewDataSet1.DataSetName = "DatabaseLoginNewDataSet"
        Me.DatabaseLoginNewDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(453, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 25)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "OverDue Fee"
        '
        'txt_Fee
        '
        Me.txt_Fee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_Fee.FormattingEnabled = True
        Me.txt_Fee.Items.AddRange(New Object() {"50"})
        Me.txt_Fee.Location = New System.Drawing.Point(562, 212)
        Me.txt_Fee.Name = "txt_Fee"
        Me.txt_Fee.Size = New System.Drawing.Size(204, 21)
        Me.txt_Fee.TabIndex = 24
        '
        'txt_Usertype
        '
        Me.txt_Usertype.Enabled = False
        Me.txt_Usertype.Location = New System.Drawing.Point(562, 144)
        Me.txt_Usertype.Name = "txt_Usertype"
        Me.txt_Usertype.Size = New System.Drawing.Size(204, 20)
        Me.txt_Usertype.TabIndex = 28
        '
        'txt_FullName
        '
        Me.txt_FullName.Enabled = False
        Me.txt_FullName.Location = New System.Drawing.Point(562, 178)
        Me.txt_FullName.Name = "txt_FullName"
        Me.txt_FullName.Size = New System.Drawing.Size(204, 20)
        Me.txt_FullName.TabIndex = 29
        '
        'UserReturnBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_FullName)
        Me.Controls.Add(Me.txt_Usertype)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_Fee)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_Connection)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserReturnBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageUsers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseLoginNewDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents txt_Username As System.Windows.Forms.TextBox
    Friend WithEvents txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Connection As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Btn_Save As System.Windows.Forms.Button
    Friend WithEvents Btn_Clear As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DatabaseLoginNewDataSet1 As LibrarySystemProject.DatabaseLoginNewDataSet
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Fee As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Usertype As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_FullName As System.Windows.Forms.DateTimePicker
End Class
