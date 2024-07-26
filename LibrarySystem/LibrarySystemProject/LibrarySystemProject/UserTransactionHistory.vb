Imports System.Data.OleDb
Imports System.IO

Public Class UserTransactionHistory
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Borrow.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer

    Private Sub ManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            lbl_Connection.Text = "Connected"
            lbl_Connection.ForeColor = Color.Lime
        Catch ex As Exception
            lbl_Connection.Text = "Disconnected"
            lbl_Connection.ForeColor = Color.Red

        End Try
        conn.Close()

        loadingDatagridView()
    End Sub
    Sub loadingDatagridView()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from borrow", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("BorrowID"), dr.Item("UserID"), dr.Item("BookID"), dr.Item("DateBorrowed"), dr.Item("ReturnDate"), dr.Item("OverDueFee"))

            End While

            dr.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        conn.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        User.Show()
        Me.Hide()
    End Sub


    Sub search()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from borrow Where `UserID` like '%" & txt_Search.Text & "%' or `BookID` like '%" & txt_Search.Text & "%' or `DateBorrowed` like '%" & txt_Search.Text & "%' or `ReturnDate` like '%" & txt_Search.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("BorrowID"), dr.Item("UserID"), dr.Item("BookID"), dr.Item("DateBorrowed"), dr.Item("ReturnDate"), dr.Item("OverDueFee"))

            End While

            dr.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        conn.Close()

    End Sub


    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        search()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class