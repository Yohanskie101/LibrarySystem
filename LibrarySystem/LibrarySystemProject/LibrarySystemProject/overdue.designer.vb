<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class overdue
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
        Me.frm_payment = New System.Windows.Forms.GroupBox()
        Me.btm_clear = New System.Windows.Forms.Button()
        Me.txt_overduepri = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_booksname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btm_Close = New System.Windows.Forms.Button()
        Me.btm_New = New System.Windows.Forms.Button()
        Me.txt_change = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_totalamount = New System.Windows.Forms.TextBox()
        Me.txt_fullname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.frm_details = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_borrowid = New System.Windows.Forms.TextBox()
        Me.btm_delete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frm_payment.SuspendLayout()
        Me.frm_details.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frm_payment
        '
        Me.frm_payment.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.frm_payment.Controls.Add(Me.btm_clear)
        Me.frm_payment.Controls.Add(Me.txt_overduepri)
        Me.frm_payment.Controls.Add(Me.Label3)
        Me.frm_payment.Controls.Add(Me.txt_booksname)
        Me.frm_payment.Controls.Add(Me.Label8)
        Me.frm_payment.Controls.Add(Me.btm_Close)
        Me.frm_payment.Controls.Add(Me.btm_New)
        Me.frm_payment.Controls.Add(Me.txt_change)
        Me.frm_payment.Controls.Add(Me.Label7)
        Me.frm_payment.Controls.Add(Me.Label6)
        Me.frm_payment.Controls.Add(Me.txt_totalamount)
        Me.frm_payment.Controls.Add(Me.txt_fullname)
        Me.frm_payment.Controls.Add(Me.Label2)
        Me.frm_payment.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.frm_payment.Location = New System.Drawing.Point(32, 26)
        Me.frm_payment.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.frm_payment.Name = "frm_payment"
        Me.frm_payment.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.frm_payment.Size = New System.Drawing.Size(1220, 172)
        Me.frm_payment.TabIndex = 1
        Me.frm_payment.TabStop = False
        Me.frm_payment.Text = "PAYMENTS"
        '
        'btm_clear
        '
        Me.btm_clear.BackColor = System.Drawing.Color.LightGray
        Me.btm_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btm_clear.Location = New System.Drawing.Point(814, 127)
        Me.btm_clear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btm_clear.Name = "btm_clear"
        Me.btm_clear.Size = New System.Drawing.Size(86, 29)
        Me.btm_clear.TabIndex = 18
        Me.btm_clear.Text = "CLEAR"
        Me.btm_clear.UseVisualStyleBackColor = False
        '
        'txt_overduepri
        '
        Me.txt_overduepri.Enabled = False
        Me.txt_overduepri.ForeColor = System.Drawing.Color.Black
        Me.txt_overduepri.Location = New System.Drawing.Point(230, 124)
        Me.txt_overduepri.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_overduepri.Name = "txt_overduepri"
        Me.txt_overduepri.Size = New System.Drawing.Size(234, 20)
        Me.txt_overduepri.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(104, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Overdue Price:"
        '
        'txt_booksname
        '
        Me.txt_booksname.Enabled = False
        Me.txt_booksname.ForeColor = System.Drawing.Color.Black
        Me.txt_booksname.Location = New System.Drawing.Point(230, 77)
        Me.txt_booksname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_booksname.Name = "txt_booksname"
        Me.txt_booksname.Size = New System.Drawing.Size(234, 20)
        Me.txt_booksname.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(78, 77)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "BookID / BookName"
        '
        'btm_Close
        '
        Me.btm_Close.BackColor = System.Drawing.Color.LightGray
        Me.btm_Close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btm_Close.Location = New System.Drawing.Point(908, 127)
        Me.btm_Close.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btm_Close.Name = "btm_Close"
        Me.btm_Close.Size = New System.Drawing.Size(86, 29)
        Me.btm_Close.TabIndex = 13
        Me.btm_Close.Text = "CLOSE"
        Me.btm_Close.UseVisualStyleBackColor = False
        '
        'btm_New
        '
        Me.btm_New.BackColor = System.Drawing.Color.LightGray
        Me.btm_New.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btm_New.Location = New System.Drawing.Point(722, 127)
        Me.btm_New.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btm_New.Name = "btm_New"
        Me.btm_New.Size = New System.Drawing.Size(86, 29)
        Me.btm_New.TabIndex = 12
        Me.btm_New.Text = "PAYMENT"
        Me.btm_New.UseVisualStyleBackColor = False
        '
        'txt_change
        '
        Me.txt_change.ForeColor = System.Drawing.Color.Black
        Me.txt_change.Location = New System.Drawing.Point(824, 58)
        Me.txt_change.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_change.Name = "txt_change"
        Me.txt_change.Size = New System.Drawing.Size(234, 20)
        Me.txt_change.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(748, 58)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Change:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(740, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Payment:"
        '
        'txt_totalamount
        '
        Me.txt_totalamount.ForeColor = System.Drawing.Color.Black
        Me.txt_totalamount.Location = New System.Drawing.Point(824, 25)
        Me.txt_totalamount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_totalamount.Name = "txt_totalamount"
        Me.txt_totalamount.Size = New System.Drawing.Size(234, 20)
        Me.txt_totalamount.TabIndex = 8
        '
        'txt_fullname
        '
        Me.txt_fullname.Enabled = False
        Me.txt_fullname.ForeColor = System.Drawing.Color.Black
        Me.txt_fullname.Location = New System.Drawing.Point(230, 31)
        Me.txt_fullname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(234, 20)
        Me.txt_fullname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(86, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "UserID/UserName"
        '
        'frm_details
        '
        Me.frm_details.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.frm_details.Controls.Add(Me.Button1)
        Me.frm_details.Controls.Add(Me.DataGridView1)
        Me.frm_details.Controls.Add(Me.txt_borrowid)
        Me.frm_details.Controls.Add(Me.btm_delete)
        Me.frm_details.Controls.Add(Me.Label1)
        Me.frm_details.ForeColor = System.Drawing.Color.Black
        Me.frm_details.Location = New System.Drawing.Point(32, 233)
        Me.frm_details.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.frm_details.Name = "frm_details"
        Me.frm_details.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.frm_details.Size = New System.Drawing.Size(1220, 240)
        Me.frm_details.TabIndex = 2
        Me.frm_details.TabStop = False
        Me.frm_details.Text = "VIEW DETAIL OF  UNRETURNED BOOK WITH PENALTIES"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(346, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 29)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.GridColor = System.Drawing.Color.Maroon
        Me.DataGridView1.Location = New System.Drawing.Point(36, 67)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1176, 156)
        Me.DataGridView1.TabIndex = 2
        '
        'txt_borrowid
        '
        Me.txt_borrowid.ForeColor = System.Drawing.Color.Black
        Me.txt_borrowid.Location = New System.Drawing.Point(124, 35)
        Me.txt_borrowid.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_borrowid.Name = "txt_borrowid"
        Me.txt_borrowid.Size = New System.Drawing.Size(200, 20)
        Me.txt_borrowid.TabIndex = 1
        '
        'btm_delete
        '
        Me.btm_delete.BackColor = System.Drawing.Color.LightGray
        Me.btm_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btm_delete.Location = New System.Drawing.Point(440, 19)
        Me.btm_delete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btm_delete.Name = "btm_delete"
        Me.btm_delete.Size = New System.Drawing.Size(86, 29)
        Me.btm_delete.TabIndex = 11
        Me.btm_delete.Text = "DELETE"
        Me.btm_delete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(32, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BORROW ID:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGray
        Me.Button2.Location = New System.Drawing.Point(1178, 479)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 29)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "BorrowID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 76
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "UserID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "BookID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
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
        Me.Column6.HeaderText = "OverDueFeee"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'overdue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1274, 511)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.frm_details)
        Me.Controls.Add(Me.frm_payment)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "overdue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OverDue"
        Me.frm_payment.ResumeLayout(False)
        Me.frm_payment.PerformLayout()
        Me.frm_details.ResumeLayout(False)
        Me.frm_details.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frm_payment As System.Windows.Forms.GroupBox
    Friend WithEvents btm_clear As System.Windows.Forms.Button
    Friend WithEvents txt_overduepri As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_booksname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btm_Close As System.Windows.Forms.Button
    Friend WithEvents btm_New As System.Windows.Forms.Button
    Friend WithEvents txt_change As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_totalamount As System.Windows.Forms.TextBox
    Friend WithEvents txt_fullname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents frm_details As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_borrowid As System.Windows.Forms.TextBox
    Friend WithEvents btm_delete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
