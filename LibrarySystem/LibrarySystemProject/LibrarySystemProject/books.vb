Imports System.Data.OleDb
Imports System.IO
Public Class books
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\CRUD.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            lbl_Connection.Text = "Connected"
            lbl_Connection.ForeColor = Color.Lime
        Catch ex As Exception
            lbl_Connection.Text = "Disconnected"
            lbl_Connection.ForeColor = Color.Red
        End Try
        conn.Close()

        txt_ID.Text = "[AUTO]"
        txt_ID.Enabled = False

        loadingDatadridView()
    End Sub

    Sub loadingDatadridView()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from crud", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("BookName"), dr.Item("Author"), dr.Item("PublishedDate"), dr.Item("Publisher"), dr.Item("ISBN"), dr.Item("Category"), dr.Item("Price"))

            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub Clear()
        txt_ID.Text = "[AUTO]"
        txt_BookName.Clear()
        txt_Author.Clear()
        txt_PublishedDate.Clear()
        txt_Publisher.Clear()
        txt_ISBN.Clear()
        txt_Category.Clear()
        txt_Price.Clear()
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        Clear()
    End Sub


    Sub Save()
        Try
            conn.Open()
            If MsgBox("Are you sure you want to save this record?", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDbCommand("INSERT INTO crud(`BookName`,`Author`,`PublishedDate`,`Publisher`,`ISBN`,`Category`,`Price`) values(@BookName,@Author,@PublishedDate,@Publisher,@ISBN,@Category,@Price)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@BookName", txt_BookName.Text)
                cmd.Parameters.AddWithValue("@Author", txt_Author.Text)
                cmd.Parameters.AddWithValue("@PublishedDate", txt_PublishedDate.Text)
                cmd.Parameters.AddWithValue("@Publisher", txt_Publisher.Text)
                cmd.Parameters.AddWithValue("@ISBN", txt_ISBN.Text)
                cmd.Parameters.AddWithValue("@Category", txt_Category.Text)
                cmd.Parameters.AddWithValue("@Price", txt_Price.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record Save Successfully!", vbInformation)
                Else
                    MsgBox("Failed", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingDatadridView()
        Clear()
    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click

        Save()
    End Sub

    Sub Delete()
        Try
            conn.Open()
            If MsgBox("Are you sure you want to delete this record?", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDbCommand("Delete from crud Where ID=@ID", conn)
                cmd.Parameters.Clear()
                
                cmd.Parameters.AddWithValue("@ID", txt_ID.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record Deleted Successfully!", vbInformation)
                Else
                    MsgBox("Failed", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingDatadridView()
        Clear()
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Delete()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txt_ID.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_BookName.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_Author.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_PublishedDate.Text = DataGridView1.CurrentRow.Cells(3).Value
        txt_Publisher.Text = DataGridView1.CurrentRow.Cells(4).Value
        txt_ISBN.Text = DataGridView1.CurrentRow.Cells(5).Value
        txt_Category.Text = DataGridView1.CurrentRow.Cells(6).Value
        txt_Price.Text = DataGridView1.CurrentRow.Cells(7).Value

    End Sub

    Sub edit()
        Try
            conn.Open()
            If MsgBox("Are you sure you want to update this record?", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDbCommand("UPDATE crud SET `BookName`=@BookName,`Author`=@Author,`PublishedDate`=PublsihedDate,`Publisher`=@Publisher,`ISBN`=@ISBN,`Category`=@Category,`Price`=@Price Where ID=@ID ", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@BookName", txt_BookName.Text)
                cmd.Parameters.AddWithValue("@Author", txt_Author.Text)
                cmd.Parameters.AddWithValue("@PublishedDate", txt_PublishedDate.Text)
                cmd.Parameters.AddWithValue("@Publisher", txt_Publisher.Text)
                cmd.Parameters.AddWithValue("@ISBN", txt_ISBN.Text)
                cmd.Parameters.AddWithValue("@Category", txt_Category.Text)
                cmd.Parameters.AddWithValue("@Price", txt_Price.Text)
                cmd.Parameters.AddWithValue("@ID", txt_ID.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record Updated Successfully!", vbInformation)
                Else
                    MsgBox("Failed", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingDatadridView()
        Clear()
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        edit()
    End Sub

    Sub Search()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from crud WHERE `BookName` like '%" & txt_Search.Text & "%' or `Author` like '%" & txt_Search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("BookName"), dr.Item("Author"), dr.Item("PublishedDate"), dr.Item("Publisher"), dr.Item("ISBN"), dr.Item("Category"), dr.Item("Price"))

            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        Search()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Menu1.Show()
        Me.Hide()
    End Sub

    Private Sub txt_BookName_TextChanged(sender As Object, e As EventArgs) Handles txt_BookName.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub lbl_Connection_Click(sender As Object, e As EventArgs) Handles lbl_Connection.Click

    End Sub


End Class