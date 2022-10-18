Imports MySql.Data.MySqlClient

Public Class Buku

    Public KodeBuku As String
    Public JudulBuku As String
    Public PengarangBuku As String
    Public Penerbit As String
    Public TahunBuku As Integer
    Public StokBuku As Integer

    Public Shared Function Cari(keyword As String)
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblbuku where KodeBuku='" & keyword & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            Return Nothing
        Else
            Dim buku = New Buku With {
                .JudulBuku = Rd.Item("JudulBuku"),
                .PengarangBuku = Rd.Item("PengarangBuku"),
                .Penerbit = Rd.Item("Penerbit"),
                .TahunBuku = Rd.Item("TahunBuku"),
                .StokBuku = Rd.Item("StokBuku"),
                .KodeBuku = Rd.Item("KodeBuku")
            }
            Return buku
        End If
    End Function
    Public Shared Function Search(keyword As String)
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblbuku where JudulBuku='" & keyword & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            Return Nothing
        Else
            Dim buku = New Buku With {
                .JudulBuku = Rd.Item("JudulBuku"),
                .PengarangBuku = Rd.Item("PengarangBuku"),
                .Penerbit = Rd.Item("Penerbit"),
                .TahunBuku = Rd.Item("TahunBuku"),
                .StokBuku = Rd.Item("StokBuku"),
                .KodeBuku = Rd.Item("KodeBuku")
            }
            Return buku
        End If
    End Function


    Public Function Save()
        Try
            Call OpenConn()
            Dim InputData As String = "Insert into tblbuku values ('" & KodeBuku & "','" & JudulBuku & "','" & PengarangBuku & "','" &
                                                                        Penerbit & "', '" & TahunBuku & "','" & StokBuku & "')"
            Cmd = New MySqlCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        End Try


    End Function
    Public Function Update()
        Try
            Call OpenConn()
            Dim UpdateData As String = "update tblbuku set JudulBuku='" & JudulBuku & "', PengarangBuku='" & PengarangBuku & "', Penerbit='" &
                                       Penerbit & "', TahunBuku='" & TahunBuku & "', StokBuku='" & StokBuku & "' where KodeBuku='" & KodeBuku & "'"
            Cmd = New MySqlCommand(UpdateData, Conn)
            Cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Delete()
        Try
            Call OpenConn()
            Dim DeleteData As String = "Delete from tblbuku where KodeBuku ='" & KodeBuku & "'"
            Cmd = New MySqlCommand(DeleteData, Conn)
            Cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
