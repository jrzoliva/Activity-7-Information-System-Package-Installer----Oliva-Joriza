Imports MySql.Data.MySqlClient
Imports System.IO

Public Class dashboard


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form6.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Advisers.Show()
    End Sub

    Private Sub backup_Click(sender As Object, e As EventArgs) Handles backup.Click

        Try
            ' Show a SaveFileDialog to allow the user to choose the location to save the backup file
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Backup Files (*.bak)|*.bak"
            saveFileDialog.FileName = "backup_" & DateTime.Now.ToString("yyyyMMddHHmmss") & ".bak"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim backupFilePath As String = saveFileDialog.FileName

                ' Build the mysqldump command with appropriate arguments
                Dim mysqldumpCmd As New Process()
                mysqldumpCmd.StartInfo.FileName = "mysqldump"
                mysqldumpCmd.StartInfo.UseShellExecute = False
                mysqldumpCmd.StartInfo.RedirectStandardInput = False
                mysqldumpCmd.StartInfo.RedirectStandardOutput = True
                mysqldumpCmd.StartInfo.CreateNoWindow = True
                mysqldumpCmd.StartInfo.Arguments = $"--user=root --password=jorizaoliva --host=localhost --databases ojt2 --result-file={backupFilePath}"

                ' Start the mysqldump process
                mysqldumpCmd.Start()
                mysqldumpCmd.WaitForExit()

                MessageBox.Show("Database backup created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to create database backup: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class