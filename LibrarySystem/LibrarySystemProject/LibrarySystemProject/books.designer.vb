<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class books
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_BookName = New System.Windows.Forms.TextBox()
        Me.txt_Author = New System.Windows.Forms.TextBox()
        Me.txt_PublishedDate = New System.Windows.Forms.TextBox()
        Me.txt_Publisher = New System.Windows.Forms.TextBox()
        Me.txt_ISBN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Connection = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Category = New System.Windows.Forms.TextBox()
        Me.txt_Price = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 54)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome To Online Library System!"
        '
        'txt_ID
        '
        Me.txt_ID.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ID.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.ForeColor = System.Drawing.Color.Black
        Me.txt_ID.Location = New System.Drawing.Point(189, 110)
        Me.txt_ID.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txt_ID.Multiline = True
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(240, 22)
        Me.txt_ID.TabIndex = 1
        '
        'txt_BookName
        '
        Me.txt_BookName.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_BookName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_BookName.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BookName.ForeColor = System.Drawing.Color.Black
        Me.txt_BookName.Location = New System.Drawing.Point(189, 147)
        Me.txt_BookName.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txt_BookName.Multiline = True
        Me.txt_BookName.Name = "txt_BookName"
        Me.txt_BookName.Size = New System.Drawing.Size(240, 22)
        Me.txt_BookName.TabIndex = 2
        '
        'txt_Author
        '
        Me.txt_Author.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_Author.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Author.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Author.ForeColor = System.Drawing.Color.Black
        Me.txt_Author.Location = New System.Drawing.Point(189, 182)
        Me.txt_Author.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txt_Author.Multiline = True
        Me.txt_Author.Name = "txt_Author"
        Me.txt_Author.Size = New System.Drawing.Size(240, 22)
        Me.txt_Author.TabIndex = 3
        '
        'txt_PublishedDate
        '
        Me.txt_PublishedDate.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_PublishedDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_PublishedDate.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PublishedDate.ForeColor = System.Drawing.Color.Black
        Me.txt_PublishedDate.Location = New System.Drawing.Point(189, 216)
        Me.txt_PublishedDate.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txt_PublishedDate.Multiline = True
        Me.txt_PublishedDate.Name = "txt_PublishedDate"
        Me.txt_PublishedDate.Size = New System.Drawing.Size(240, 22)
        Me.txt_PublishedDate.TabIndex = 4
        '
        'txt_Publisher
        '
        Me.txt_Publisher.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_Publisher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Publisher.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Publisher.ForeColor = System.Drawing.Color.Black
        Me.txt_Publisher.Location = New System.Drawing.Point(614, 108)
        Me.txt_Publisher.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txt_Publisher.Multiline = True
        Me.txt_Publisher.Name = "txt_Publisher"
        Me.txt_Publisher.Size = New System.Drawing.Size(234, 22)
        Me.txt_Publisher.TabIndex = 5
        '
        'txt_ISBN
        '
        Me.txt_ISBN.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_ISBN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ISBN.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ISBN.ForeColor = System.Drawing.Color.Black
        Me.txt_ISBN.Location = New System.Drawing.Point(615, 147)
        Me.txt_ISBN.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txt_ISBN.Multiline = True
        Me.txt_ISBN.Name = "txt_ISBN"
        Me.txt_ISBN.Size = New System.Drawing.Size(233, 22)
        Me.txt_ISBN.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(754, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 14)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Connection State:"
        '
        'lbl_Connection
        '
        Me.lbl_Connection.AutoSize = True
        Me.lbl_Connection.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Connection.Location = New System.Drawing.Point(865, 68)
        Me.lbl_Connection.Name = "lbl_Connection"
        Me.lbl_Connection.Size = New System.Drawing.Size(105, 14)
        Me.lbl_Connection.TabIndex = 8
        Me.lbl_Connection.Text = "Connection State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(146, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(83, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Book Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(111, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Author"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(58, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Published Date"
        '
        'txt_Category
        '
        Me.txt_Category.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_Category.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Category.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Category.ForeColor = System.Drawing.Color.Black
        Me.txt_Category.Location = New System.Drawing.Point(615, 184)
        Me.txt_Category.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txt_Category.Multiline = True
        Me.txt_Category.Name = "txt_Category"
        Me.txt_Category.Size = New System.Drawing.Size(233, 22)
        Me.txt_Category.TabIndex = 14
        '
        'txt_Price
        '
        Me.txt_Price.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Price.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Price.ForeColor = System.Drawing.Color.Black
        Me.txt_Price.Location = New System.Drawing.Point(615, 222)
        Me.txt_Price.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txt_Price.Multiline = True
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(233, 22)
        Me.txt_Price.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(525, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Publisher"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(554, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "ISBN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(522, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 25)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Category"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(550, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 25)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Price"
        '
        'Btn_Save
        '
        Me.Btn_Save.BackColor = System.Drawing.Color.LightGray
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Save.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_Save.Location = New System.Drawing.Point(274, 270)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(85, 29)
        Me.Btn_Save.TabIndex = 20
        Me.Btn_Save.Text = "Save"
        Me.Btn_Save.UseVisualStyleBackColor = False
        '
        'Btn_Delete
        '
        Me.Btn_Delete.BackColor = System.Drawing.Color.Silver
        Me.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Delete.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delete.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_Delete.Location = New System.Drawing.Point(379, 270)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(88, 29)
        Me.Btn_Delete.TabIndex = 21
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = False
        '
        'Btn_Update
        '
        Me.Btn_Update.BackColor = System.Drawing.Color.Silver
        Me.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Update.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_Update.Location = New System.Drawing.Point(484, 270)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(88, 29)
        Me.Btn_Update.TabIndex = 22
        Me.Btn_Update.Text = "Update"
        Me.Btn_Update.UseVisualStyleBackColor = False
        '
        'Btn_Clear
        '
        Me.Btn_Clear.BackColor = System.Drawing.Color.Silver
        Me.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Clear.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Clear.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_Clear.Location = New System.Drawing.Point(591, 270)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(87, 29)
        Me.Btn_Clear.TabIndex = 23
        Me.Btn_Clear.Text = "Clear"
        Me.Btn_Clear.UseVisualStyleBackColor = False
        '
        'txt_Search
        '
        Me.txt_Search.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Search.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.ForeColor = System.Drawing.Color.Black
        Me.txt_Search.Location = New System.Drawing.Point(119, 321)
        Me.txt_Search.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txt_Search.Multiline = True
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(484, 27)
        Me.txt_Search.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(43, 327)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 25)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Search"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DataGridView1.Location = New System.Drawing.Point(46, 363)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(903, 188)
        Me.DataGridView1.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(881, 560)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 26)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 45
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "Book Name"
        Me.Column2.MinimumWidth = 378
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "Author"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 70
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column4.HeaderText = "Published Date"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 114
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column5.HeaderText = "Publisher"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 83
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column6.HeaderText = "ISBN"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 61
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column7.HeaderText = "Categories"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 90
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column8.HeaderText = "Price"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 59
        '
        'books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_Price)
        Me.Controls.Add(Me.txt_Category)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_Connection)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_ISBN)
        Me.Controls.Add(Me.txt_Publisher)
        Me.Controls.Add(Me.txt_PublishedDate)
        Me.Controls.Add(Me.txt_Author)
        Me.Controls.Add(Me.txt_BookName)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "books"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents txt_BookName As System.Windows.Forms.TextBox
    Friend WithEvents txt_Author As System.Windows.Forms.TextBox
    Friend WithEvents txt_PublishedDate As System.Windows.Forms.TextBox
    Friend WithEvents txt_Publisher As System.Windows.Forms.TextBox
    Friend WithEvents txt_ISBN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Connection As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Category As System.Windows.Forms.TextBox
    Friend WithEvents txt_Price As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Btn_Save As System.Windows.Forms.Button
    Friend WithEvents Btn_Delete As System.Windows.Forms.Button
    Friend WithEvents Btn_Update As System.Windows.Forms.Button
    Friend WithEvents Btn_Clear As System.Windows.Forms.Button
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
