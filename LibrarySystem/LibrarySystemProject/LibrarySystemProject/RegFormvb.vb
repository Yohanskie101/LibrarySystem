Imports System.Data.OleDb



Public Class RegFormvb
    Dim con As OleDbConnection = New OleDbConnection()
    Dim dbprovider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbsource As String = "Data Source=|DataDirectory|\DatabaseLoginNew.accdb"

    Private Sub RegFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbprovider & dbsource
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If NameReg.Text = Nothing Or Usertype.Text = Nothing Or UsernameReg.Text = Nothing Or PasswordReg.Text = Nothing Then
            MessageBox.Show("Please complete the needed details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con.Open()
                Using cmd As New OleDbCommand("SELECT * FROM login WHERE [Username] = @Username AND [Password] = @Password AND [Usertype] = @Usertype AND [Full_Name] = @Full_Name", con)

                    cmd.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = UsernameReg.Text.Trim
                    cmd.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = PasswordReg.Text.Trim
                    cmd.Parameters.AddWithValue("@Usertype", OleDbType.VarChar).Value = Usertype.Text.Trim
                    cmd.Parameters.AddWithValue("@Full_Name", OleDbType.VarChar).Value = NameReg.Text.Trim

                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Oops, Username and Password has already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using


                Using create As New OleDbCommand("INSERT INTO login([Username],[Password],[Usertype],[Full_Name])VALUES(@Username,@Password,@Usertype,@Full_Name)", con)

                    create.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = UsernameReg.Text.Trim
                    create.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = PasswordReg.Text.Trim
                    create.Parameters.AddWithValue("@Usertype", OleDbType.VarChar).Value = Usertype.Text.Trim
                    create.Parameters.AddWithValue("@Full_Name", OleDbType.VarChar).Value = NameReg.Text.Trim

                    If create.ExecuteNonQuery Then
                        MessageBox.Show("Account Successfully Created !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        NameReg.Clear()
                        UsernameReg.Clear()
                        PasswordReg.Clear()

                    End If
                End Using
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If PasswordReg.UseSystemPasswordChar = True Then
            ' Show Password
            PasswordReg.UseSystemPasswordChar = False
        Else
            ' Hide Password
            PasswordReg.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NameReg.Clear()
        UsernameReg.Clear()
        PasswordReg.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Thank You For Using Our System!", "Have a Great Day!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub
End Class