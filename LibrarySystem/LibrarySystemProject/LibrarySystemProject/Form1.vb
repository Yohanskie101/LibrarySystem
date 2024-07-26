Imports System.Data.OleDb

Public Class Form1
    Dim con As OleDbConnection = New OleDbConnection()
    Dim dbprovider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbsource As String = "Data Source=|DataDirectory|\DatabaseLoginNew.accdb"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LoginBtn.Text = "" Or PasswordBtn.Text = "" Then
            MessageBox.Show("Please fullfill the needed requirements!")
        Else
            Try
                con.Open()
                Using login As New OleDbCommand("SELECT * FROM login WHERE [Username] = @Username AND [Password] = @Password", con)
                    login.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = LoginBtn.Text.Trim
                    login.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = PasswordBtn.Text.Trim

                    Dim ds As New OleDbDataAdapter(login)
                    Dim mytable As New DataTable
                    ds.Fill(mytable)

                    If mytable.Rows(0)("Usertype") = "admin" Then
                        Dim message As String = "You have successfully login , Welcome Admin!"
                        Dim caption As String = "Success"
                        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim AdminMenu As New Menu1
                        Me.Hide()
                        LoginBtn.Clear()
                        PasswordBtn.Clear()
                        Menu1.AdminMenu = LoginBtn.Text
                        Menu1.Show()

                    ElseIf mytable.Rows(0)("Usertype") = "user" Then
                        Dim message As String = "You have successfully login , Welcome User!"
                        Dim caption As String = "Success"
                        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim UserMenu As New User
                        Me.Hide()
                        LoginBtn.Clear()
                        PasswordBtn.Clear()
                        User.UserMenu = LoginBtn.Text
                        User.Show()

                    Else

                        MessageBox.Show("Wrong Username Or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        LoginBtn.Text = ""
                        PasswordBtn.Text = ""
                    End If

                End Using
            Catch ex As Exception
                MessageBox.Show("Wrong Username Or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbprovider & dbsource

    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If PasswordBtn.UseSystemPasswordChar = True Then
            ' Show Password
            PasswordBtn.UseSystemPasswordChar = False
        Else
            ' Hide Password
            PasswordBtn.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginBtn.Clear()
        PasswordBtn.Clear()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        RegFormvb.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Thank You For Using Our System!", "Have a Great Day!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class