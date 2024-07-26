Imports System.Data.OleDb
Imports System.IO

Public Class overdue
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Borrow.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        loadingDatadridView()
    End Sub

    Sub loadingDatadridView()
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
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txt_fullname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_booksname.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_overduepri.Text = DataGridView1.CurrentRow.Cells(5).Value
    End Sub

    Private Sub txt_totalamount_TextChanged(sender As Object, e As EventArgs) Handles txt_totalamount.TextChanged

        txt_change.Text = Val(txt_totalamount.Text) - Val(txt_overduepri.Text)
    End Sub

    Sub delete()
        Try
            conn.Open()
            If MsgBox("Are You Sure You Want To Return the Book ?", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDb.OleDbCommand("Delete from borrow Where ID=@ID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ID", btm_New.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record Have Been Deleted ! ", vbInformation)
                Else
                    MsgBox("Failed", vbCritical)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        conn.Close()

    End Sub

    Private Sub btm_New_Click(sender As Object, e As EventArgs) Handles btm_New.Click
        RECEIPT.Label10.Text = txt_fullname.Text
        RECEIPT.Label11.Text = txt_booksname.Text
        RECEIPT.Label12.Text = txt_overduepri.Text
        RECEIPT.Label13.Text = txt_totalamount.Text
        RECEIPT.Label14.Text = txt_change.Text
        delete()
        RECEIPT.Show()
    End Sub

    Private Sub btm_clear_Click(sender As Object, e As EventArgs) Handles btm_clear.Click
        txt_fullname.Clear()
        txt_booksname.Clear()
        txt_overduepri.Clear()
        txt_totalamount.Clear()
        txt_change.Clear()
    End Sub

    Private Sub btm_Close_Click(sender As Object, e As EventArgs) Handles btm_Close.Click
        Dim frm As New overdue
        frm.Show()

        Me.Close()

    End Sub

    Private Sub btm_delete_Click(sender As Object, e As EventArgs) Handles btm_delete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim temp As Integer = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            For j As Integer = 0 To DataGridView1.ColumnCount - 1
                If DataGridView1.Rows(i).Cells(j).Value.ToString = txt_borrowid.Text Then
                    MsgBox("ID found")
                    temp = 1
                End If
            Next
        Next
        If temp = 0 Then
            MsgBox("ID not found")
        End If
    End Sub


    Private Sub frm_details_Enter(sender As Object, e As EventArgs) Handles frm_details.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class
