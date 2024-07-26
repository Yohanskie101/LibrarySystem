Imports System.Data.OleDb
Imports System.IO

Public Class UsersInventory
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
       

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu1.Show()
        Me.Hide()
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
       
    End Sub


    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        search()
    End Sub
End Class