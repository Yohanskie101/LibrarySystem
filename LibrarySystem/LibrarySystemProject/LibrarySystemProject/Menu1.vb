﻿Imports System.Data.OleDb

Public Class Menu1
    Public Shared AdminMenu


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result = MessageBox.Show("Are you sure you want to logout? ", "Hello!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub Menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("MM-dd-yy")
        Label2.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        books.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ManageUsers.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UsersInventory.Show()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Borrow.Show()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BooksInventory.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TransactionHistory.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ReturnBooks.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        overdue.Show()
    End Sub
End Class