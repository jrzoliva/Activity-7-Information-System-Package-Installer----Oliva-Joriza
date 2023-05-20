Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Advisers
    ' Connect to MySQL database
    Dim connection As MySqlConnection = DBConnection.GetConnection()
    Dim connectionString As String = "Data Source=localhost;Initial Catalog=ojt2;User ID=root;Password=jorizaoliva"

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New MySqlCommand("SELECT * FROM head", connection)
        Dim da As New MySqlDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds, "head")
        DataGridView1.DataSource = ds.Tables("head")
    End Sub

    Private Sub Advisers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Open a File Dialog to allow the user to select a CSV file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv"
        openFileDialog.Title = "Select CSV File"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName

            ' Read the CSV file and update the database
            Try
                ' Read all lines from the CSV file
                Dim lines As String() = File.ReadAllLines(filePath)

                ' Get the column names from the first row
                Dim columnNames As String() = lines(0).Split(","c)

                ' Loop through the remaining rows to get the data
                For i As Integer = 1 To lines.Length - 1
                    Dim fields As String() = lines(i).Split(","c)

                    ' Assume the number of columns based on the values separated by commas
                    Dim numColumns As Integer = fields.Length

                    ' Create parameter placeholders for the SQL query
                    Dim parameterPlaceholders As String = String.Join(", ", Enumerable.Range(0, numColumns).Select(Function(n) "@" & n))

                    ' Create the SQL query with dynamic column names and parameter placeholders
                    Dim sql As String = "INSERT INTO head (headID, Head, deptID, Advisee) VALUES (" & parameterPlaceholders & ")"

                    ' Create a new MySqlConnection and MySqlCommand
                    Using connection As New MySqlConnection(connectionString), command As New MySqlCommand(sql, connection)
                        ' Loop through the fields and add them as parameters to the MySqlCommand
                        For j As Integer = 0 To numColumns - 1
                            command.Parameters.AddWithValue("@" & j, fields(j))
                        Next

                        ' Open the database connection, execute the SQL query, and close the connection
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    End Using
                Next

                MessageBox.Show("CSV data has been successfully uploaded and updated in the database.")
            Catch ex As Exception
                MessageBox.Show("Error uploading CSV data: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call importToExcel(DataGridView1, "headsrecord.xlsx")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim headNumber As String = search.Text.Trim()
        Dim strSQL As String = "SELECT headID, Head FROM head WHERE headID = @headID"

        Using connection As MySqlConnection = DBConnection.GetConnection()
            Dim command As New MySqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@HeadID", headNumber)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        HeadID.Text = reader.GetString(0)
                        HeadName.Text = reader.GetString(1)
                    End While
                Else
                    MsgBox("Department Number does not exist!")
                End If

                reader.Close()
            Catch ex As Exception
                MsgBox("Error retrieving department information: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Retrieve the values from the text boxes
        Dim headIDValue As String = HeadID.Text.Trim()
        Dim head As String = HeadName.Text.Trim()

        ' Insert the record into the database
        Dim strSQL As String = "INSERT INTO head (headID, Head) VALUES (@HeadID, @HeadName)"

        Using connection As MySqlConnection = DBConnection.GetConnection()
            Dim command As New MySqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@HeadID", headIDValue)
            command.Parameters.AddWithValue("@HeadName", head)

            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Record added successfully.")
                Else
                    MsgBox("Failed to add the record.")
                End If
            Catch ex As Exception
                MsgBox("Error adding the record: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Retrieve the values from the text boxes
        Dim headIDValue As String = HeadID.Text.Trim()
        Dim head As String = HeadName.Text.Trim()

        ' Update the record in the database
        Dim strSQL As String = "UPDATE head SET head = @HeadName WHERE HeadID = @HeadID"

        Using connection As MySqlConnection = DBConnection.GetConnection()
            Dim command As New MySqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@HeadID", headIDValue)
            command.Parameters.AddWithValue("@HeadName", head)

            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Record updated successfully.")
                Else
                    MsgBox("No matching record found.")
                End If
            Catch ex As Exception
                MsgBox("Error updating the record: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Retrieve the ID number from the textbox
        Dim headIDValue As String = HeadID.Text.Trim()

        ' Delete the record from the database
        Dim strSQL As String = "DELETE FROM head WHERE HeadID = @HeadID"

        Using connection As MySqlConnection = DBConnection.GetConnection()
            Dim command As New MySqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@HeadID", headIDValue)

            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Record deleted successfully.")
                Else
                    MsgBox("No matching record found.")
                End If
            Catch ex As Exception
                MsgBox("Error deleting the record: " & ex.Message)
            End Try
        End Using
    End Sub
End Class