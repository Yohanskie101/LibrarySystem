Imports System.Data.OleDb
Imports System.IO

Public Class Borrow
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
        txt_ID.Text = "[ AUTO ]"
        txt_ID.Enabled = False
        txt_Usertype.Enabled = False


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu1.Show()
        Me.Hide()
    End Sub

    Sub clear()
        txt_ID.Text = "[ AUTO ]"
        txt_Username.Clear()
        txt_Password.Clear()
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        clear()
    End Sub
    Sub save()
        Try
            conn.Open()
            If MsgBox("Are You Sure You Want To Borrow This Book ?", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDb.OleDbCommand("Insert into borrow (`UserID`,`BookID`,`DateBorrowed`,`ReturnDate`,`OverDueFee`) values(@UserID,@BookID,@DateBorrowed,@ReturnDate,@OverDueFee)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@UserID", txt_Username.Text)
                cmd.Parameters.AddWithValue("@BookID", txt_Password.Text)
                cmd.Parameters.AddWithValue("@DateBorrowed", txt_Usertype.Text)
                cmd.Parameters.AddWithValue("@ReturnDate", txt_FullName.Text)
                cmd.Parameters.AddWithValue("@OverDueFee", txt_Fee.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Book Has Been Borrowed ! ", vbInformation)
                Else
                    MsgBox("Failed", vbCritical)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        conn.Close()
        loadingDatagridView()
        clear()

    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        save()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txt_ID.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_Username.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_Password.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_Usertype.Text = DataGridView1.CurrentRow.Cells(3).Value
        txt_FullName.Text = DataGridView1.CurrentRow.Cells(4).Value
        txt_Fee.Text = DataGridView1.CurrentRow.Cells(5).Value

    End Sub
    Sub edit()
        Try
            conn.Open()
            If MsgBox("Are you sure you want to update this record?", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDbCommand("UPDATE borrow SET `UserID`=@UserID,`BookID`=@BookID,`DateBorrowed`=DateBorrowed,`ReturnDate`=@ReturnDate,`OverDueFee`=@OverDueFee Where BorrowID=@BorrowID ", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@UserID", txt_Username.Text)
                cmd.Parameters.AddWithValue("@BookID", txt_Password.Text)
                cmd.Parameters.AddWithValue("@DateBorrowed", txt_Usertype.Text)
                cmd.Parameters.AddWithValue("@ReturnDate", txt_FullName.Text)
                cmd.Parameters.AddWithValue("@OverDueFee", txt_Fee.Text)
                cmd.Parameters.AddWithValue("@BorrowID", txt_ID.Text)
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
        loadingDatagridView()
        clear()
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        edit()
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
        txt_ID.Text = "[ AUTO ]"
        txt_ID.Enabled = False
    End Sub


    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        search()
    End Sub
End Class