Imports MySql.Data.MySqlClient


Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            password.UseSystemPasswordChar = True
        Else
            password.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub password_Click(sender As Object, e As EventArgs) Handles label.Click

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        ' Connect to MySQL database
        Dim connection As MySqlConnection = DBConnection.GetConnection()

        If username.TextLength = 0 OrElse password.TextLength = 0 Then
            MessageBox.Show("Username or Password empty. Please enter valid Inputs!")
        Else
            Try
                connection.Open()

                ' Check if username and password are correct
                Dim command As New MySqlCommand("SELECT COUNT(*) FROM users WHERE username=@username AND password=@password", connection)
                command.Parameters.AddWithValue("@username", username.Text)
                command.Parameters.AddWithValue("@password", password.Text)

                Dim count As Integer = CInt(command.ExecuteScalar())

                If count = 1 Then
                    dashboard.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid Username or Password!")
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fileName As String = "usermanual.pdf"

        ' Get the full path of the PDF file
        Dim fullPath As String = System.IO.Path.Combine(Application.StartupPath, fileName)

        ' Check if the file exists
        If System.IO.File.Exists(fullPath) Then
            ' Open the PDF file
            System.Diagnostics.Process.Start(fullPath)
        Else
            MessageBox.Show("User manual file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class
