Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form3
    ' Connect to MySQL database
    ' Declare the connection string variable
    Dim connection As MySqlConnection = DBConnection.GetConnection()
    Dim connectionString As String = "Data Source=localhost;Initial Catalog=ojt2;User ID=root;Password=jorizaoliva"

    Dim ds As New DataSet()
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd As New MySqlCommand("SELECT * FROM studentsinfo", connection)
        Dim da As New MySqlDataAdapter(cmd)
        ds.Clear() ' Clear the previous data in the dataset before filling it again
        da.Fill(ds, "studentsinfo")
        DataGridView1.DataSource = ds.Tables("studentsinfo")

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
                    Dim sql As String = "INSERT INTO studentsinfo (StudentID, Lastname, FirstName, Age, UniversityID, AdviserID, DeptNum, CourseID, HoursPerDay, Mark) VALUES (" & parameterPlaceholders & ")"

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
        Call importToExcel(DataGridView1, "studentsrecord.xlsx")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles update.Click
        ' Retrieve the values from the text boxes
        Dim studentIDValue As String = StudentID.Text.Trim()
        Dim last As String = Lastname.Text.Trim()
        Dim first As String = Firstname.Text.Trim()
        Dim age1 As String = Age.Text.Trim()
        Dim univ As String = UniversityID.Text.Trim()
        Dim head As String = AdviserID.Text.Trim()
        Dim dept As String = DeptNum.Text.Trim()
        Dim course As String = CourseID.Text.Trim()
        Dim hours As String = HoursPerDay.Text.Trim()
        Dim marks As String = Mark.Text.Trim()

        ' Update the record in the database
        Dim strSQL As String = "UPDATE studentsinfo SET Lastname = @Lastname, Firstname = @Firstname, " &
                       "Age = @Age, UniversityID = @UniversityID, AdviserID = @AdviserID, " &
                       "DeptNum = @DeptNum, CourseID = @CourseID, HoursPerDay = @HoursPerDay, " &
                       "Mark = @Mark WHERE StudentID = @StudentID"

        Using connection As MySqlConnection = DBConnection.GetConnection()
            Dim command As New MySqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@StudentID", studentIDValue)
            command.Parameters.AddWithValue("@Lastname", last)
            command.Parameters.AddWithValue("@Firstname", first)
            command.Parameters.AddWithValue("@Age", age1)
            command.Parameters.AddWithValue("@UniversityID", univ)
            command.Parameters.AddWithValue("@AdviserID", head)
            command.Parameters.AddWithValue("@DeptNum", dept)
            command.Parameters.AddWithValue("@CourseID", course)
            command.Parameters.AddWithValue("@HoursPerDay", hours)
            command.Parameters.AddWithValue("@Mark", marks)

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

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim studentNumber As String = search.Text.Trim()
        Dim strSQL As String = "SELECT StudentID, Lastname, Firstname, Age, UniversityID, AdviserID, DeptNum, CourseID, HoursPerDay, Mark FROM studentsinfo WHERE StudentID = @StudentID"

        Using connection As MySqlConnection = DBConnection.GetConnection()
            Dim command As New MySqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@StudentID", studentNumber)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        StudentID.Text = reader.GetString(0)
                        Lastname.Text = reader.GetString(1)
                        Firstname.Text = reader.GetString(2)
                        Age.Text = reader.GetString(3)
                        UniversityID.Text = reader.GetString(4)
                        AdviserID.Text = reader.GetString(5)
                        DeptNum.Text = reader.GetString(6)
                        CourseID.Text = reader.GetString(7)
                        HoursPerDay.Text = reader.GetString(8)
                        Mark.Text = reader.GetString(9)
                    End While
                Else
                    MsgBox("Student Number does not exist!")
                End If

                reader.Close()
            Catch ex As Exception
                MsgBox("Error retrieving student information: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles add.Click
        ' Retrieve the values from the text boxes
        Dim studentIDValue As String = StudentID.Text.Trim()
        Dim last As String = Lastname.Text.Trim()
        Dim first As String = Firstname.Text.Trim()
        Dim age1 As String = Age.Text.Trim()
        Dim univ As String = UniversityID.Text.Trim()
        Dim head As String = AdviserID.Text.Trim()
        Dim dept As String = DeptNum.Text.Trim()
        Dim course As String = CourseID.Text.Trim()
        Dim hours As String = HoursPerDay.Text.Trim()
        Dim marks As String = Mark.Text.Trim()

        ' Insert the record into the database
        Dim strSQL As String = "INSERT INTO studentsinfo (StudentID, Lastname, Firstname, Age, UniversityID, AdviserID, DeptNum, CourseID, HoursPerDay, Mark ) VALUES (@StudentID, @Lastname, @Firstname, @Age, @UniversityID, @AdviserID, @DeptNum, @CourseID, @HoursPerDay, @Mark )"

        Using connection As MySqlConnection = DBConnection.GetConnection()
            Dim command As New MySqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@StudentID", studentIDValue)
            command.Parameters.AddWithValue("@Lastname", last)
            command.Parameters.AddWithValue("@Firstname", first)
            command.Parameters.AddWithValue("@Age", age1)
            command.Parameters.AddWithValue("@UniversityID", univ)
            command.Parameters.AddWithValue("@AdviserID", head)
            command.Parameters.AddWithValue("@DeptNum", dept)
            command.Parameters.AddWithValue("@CourseID", course)
            command.Parameters.AddWithValue("@HoursPerDay", hours)
            command.Parameters.AddWithValue("@Mark", marks)

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

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        ' Retrieve the ID number from the textbox
        Dim studentIDValue As String = StudentID.Text.Trim()

        ' Delete the record from the database
        Dim strSQL As String = "DELETE FROM studentsinfo WHERE StudentID = @StudentID"

        Using connection As MySqlConnection = DBConnection.GetConnection()
            Dim command As New MySqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@StudentID", studentIDValue)

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