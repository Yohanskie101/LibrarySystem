Imports System.Data.OleDb
Imports System.IO

Public Class ManageUsers
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\DatabaseLoginNew.accdb")
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
            Dim cmd As New OleDb.OleDbCommand("Select * from login", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("Username"), dr.Item("Password"), dr.Item("Usertype"), dr.Item("Full_Name"))

            End While

            dr.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        conn.Close()
        txt_ID.Text = "[ AUTO ]"
        txt_ID.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu1.Show()
        Me.Hide()
    End Sub

    Sub clear()
        txt_ID.Text = "[ AUTO ]"
        txt_Username.Clear()
        txt_Password.Clear()
        txt_FullName.Clear()
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        clear()
    End Sub
    Sub save()
        Try
            conn.Open()
            If MsgBox("Are You Sure You Want To Insert This Record ?", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDb.OleDbCommand("Insert into login (`Username`,`Password`,`Usertype`,`Full_Name`) values(@Username,@Password,@Usertype,@Full_Name)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Username", txt_Username.Text)
                cmd.Parameters.AddWithValue("@Passwod", txt_Password.Text)
                cmd.Parameters.AddWithValue("@Usertype", txt_Usertype.Text)
                cmd.Parameters.AddWithValue("@Full_Name", txt_FullName.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record Have Been Saved ! ", vbInformation)
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

    Sub delete()
        Try
            conn.Open()
            If MsgBox("Are You Sure You Want To Delete This Record ?", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDb.OleDbCommand("Delete from login Where ID=@ID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ID", txt_ID.Text)

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
        loadingDatagridView()
        clear()

    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        delete()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txt_ID.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_Username.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_Password.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_Usertype.Text = DataGridView1.CurrentRow.Cells(3).Value
        txt_FullName.Text = DataGridView1.CurrentRow.Cells(4).Value

    End Sub
    Sub edit()
        Try
            conn.Open()
            If MsgBox("Are you sure you want to update this record?", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDbCommand("UPDATE login SET `Username`=@Username,`Password`=@Password,`Usertype`=@Usertype,`Full_Name`=@Full_Name Where ID=@ID ", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Username", txt_Username.Text)
                cmd.Parameters.AddWithValue("@Password", txt_Password.Text)
                cmd.Parameters.AddWithValue("@Usertype", txt_Usertype.Text)
                cmd.Parameters.AddWithValue("@Full_Name", txt_FullName.Text)
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
            Dim cmd As New OleDb.OleDbCommand("Select * from login Where `Username` like '%" & txt_Search.Text & "%' or `Password` like '%" & txt_Search.Text & "%' or `Usertype` like '%" & txt_Search.Text & "%' or `Full_Name` like '%" & txt_Search.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("Username"), dr.Item("Password"), dr.Item("Usertype"), dr.Item("Full_Name"))

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