Imports MySql.Data.MySqlClient
Module Koneksi_DataBase
    Public Conn As MySqlConnection
    Public Da As MySqlDataAdapter
    Public Ds As DataSet
    Public Rd As MySqlDataReader
    Public Cmd As MySqlCommand
    Public MyDB As String
    Sub OpenConn()
        MyDB = ("server=localhost;port=3307;user id=root;password=;database=perpustakaan")
        Conn = New MySqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
