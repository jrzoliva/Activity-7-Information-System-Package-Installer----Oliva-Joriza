Imports MySql.Data.MySqlClient

Module DBConnection
    Public Function GetDBName() As String
        Return "ojt2"
    End Function
    Public Function GetConnection() As MySqlConnection
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=ojt2;User ID=root;Password=jorizaoliva"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)
        Return connection
    End Function

End Module