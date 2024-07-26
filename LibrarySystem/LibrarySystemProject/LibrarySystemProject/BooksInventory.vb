Imports System.Data.OleDb
Imports System.IO
Public Class BooksInventory
    Dim dr As OleDbDataReader
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\crud.accdb")

    Private Sub BooksInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        txt_Search.Enabled = True
        conn.Close()
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
    Sub Search()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from crud WHERE `BookName` like '%" & txt_Search.Text & "%' or `Author` like '%" & txt_Search.Text & "%' or `Publisher` like '%" & txt_Search.Text & "%' or `Category` like '%" & txt_Search.Text & "%'", conn)
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
End Class