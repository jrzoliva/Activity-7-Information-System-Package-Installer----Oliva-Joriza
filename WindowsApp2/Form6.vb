Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form6
    ' Connect to MySQL database
    Dim connection As MySqlConnection = DBConnection.GetConnection()
    Dim connectionString As String = "Data Source=localhost;Initial Catalog=ojt2;User ID=root;Password=jorizaoliva"


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New MySqlCommand("SELECT * FROM university", connection)
        Dim da As New MySqlDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds, "university")
        DataGridView1.DataSource = ds.Tables("university")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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
                    Dim sql As String = "INSERT INTO university (univID, Institution, Address, NumofStudents) VALUES (" & parameterPlaceholders & ")"

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
        Call importToExcel(DataGridView1, "universityrecord.xlsx")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim univNumber As String = search.Text.Trim()
        Dim strSQL As String = "SELECT UnivID, Institution FROM university WHERE UnivID = @UnivID"

        Using connection As MySqlConnection = DBConnection.GetConnection()
            Dim command As New MySqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@UnivID", univNumber)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        UnivID.Text = reader.GetString(0)
                        UnivName.Text = reader.GetString(1)
                    End While
                Else
                    MsgBox("University Number does not exist!")
                End If

                reader.Close()
            Catch ex As Exception
                MsgBox("Error retrieving University information: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Retrieve the values from the text boxes
        Dim univIDValue As String = UnivID.Text.Trim()
        Dim univ As String = UnivName.Text.Trim()

        ' Insert the record into the database
        Dim strSQL As String = "INSERT INTO university (UnivID, Institution ) VALUES (@UnivID, @UnivName)"

        Using connection As MySqlConnection = DBConnection.GetConnection()
            Dim command As New MySqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@UnivID", univIDValue)
            command.Parameters.AddWithValue("@UnivName", univ)

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Retrieve the values from the text boxes
        Dim univIDValue As String = UnivID.Text.Trim()
        Dim univ As String = UnivName.Text.Trim()

        ' Update the record in the database
        Dim strSQL As String = "UPDATE university SET Institution = @UnivName WHERE UnivID = @UnivID"

        Using connection As MySqlConnection = DBConnection.GetConnection()
            Dim command As New MySqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@UnivID", univIDValue)
            command.Parameters.AddWithValue("@UnivName", univ)

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
        Dim univIDValue As String = UnivID.Text.Trim()

        ' Delete the record from the database
        Dim strSQL As String = "DELETE FROM university WHERE UnivID = @UnivID"

        Using connection As MySqlConnection = DBConnection.GetConnection()
            Dim command As New MySqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@UnivID", univIDValue)

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