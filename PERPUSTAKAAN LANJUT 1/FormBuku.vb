Imports MySql.Data.MySqlClient
Public Class FormBuku
    Sub tampilkan()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from tblbuku", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblbuku")
        dgBuku.DataSource = Ds.Tables("tblbuku")
        dgBuku.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver

        Input.Enabled = True
        Input.Text = "INPUT"
        Update.Enabled = True
        Update.Text = "UPDATE"
        Delete.Enabled = True
        Delete.Text = "DELETE"
        Keluar.Text = "KELUAR"

        kodebuku.Text = ""
        judulbuku.Text = ""
        pengarangbuku.Text = ""
        penerbit.Text = ""
        tahunbuku.Text = ""
        stokbuku.Text = ""
        txtcari.Text = ""

        kodebuku.Enabled = False
        judulbuku.Enabled = False
        pengarangbuku.Enabled = False
        penerbit.Enabled = False
        tahunbuku.Enabled = False
        stokbuku.Enabled = False

        Dim Tahun As String
        Tahun = Date.Now().Year
        tahunbuku.Items.Clear()
        With tahunbuku
            While Tahun >= 2010
                .Items.Add(Tahun)
                Tahun = Tahun - 1
            End While
        End With
    End Sub
    Sub Isi()
        kodebuku.Enabled = True
        judulbuku.Enabled = True
        pengarangbuku.Enabled = True
        penerbit.Enabled = True
        tahunbuku.Enabled = True
        stokbuku.Enabled = True
    End Sub
    Private Sub FormBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilkan()
    End Sub

    Private Sub Input_Click(sender As Object, e As EventArgs) Handles Input.Click
        If Input.Text = "INPUT" Then
            Input.Text = "SIMPAN"
            Update.Enabled = False
            Delete.Enabled = False
            Keluar.Text = "&CANCEL"
            Call Isi()
            kodebuku.Focus()
        Else
            If kodebuku.Text = "" Or judulbuku.Text = "" Or pengarangbuku.Text = "" Or penerbit.Text = "" Or tahunbuku.Text = "" Or stokbuku.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                kodebuku.Focus()
            Else
                Dim buku = New Buku With {
                       .JudulBuku = judulbuku.Text,
                       .KodeBuku = kodebuku.Text,
                       .Penerbit = penerbit.Text,
                       .PengarangBuku = pengarangbuku.Text,
                       .TahunBuku = tahunbuku.Text,
                       .StokBuku = stokbuku.Text
                   }
                Dim tersimpan = buku.Save()
                If (tersimpan) Then
                    MsgBox("Data Berhasil di Simpan !!!")
                    Call tampilkan()
                Else
                    MsgBox("Data Gagal di Simpan......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If

            End If
        End If
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        If Update.Text = "UPDATE" Then
            Update.Text = "UBAH"
            Input.Enabled = False
            Delete.Enabled = False
            Keluar.Text = "&CANCEL"
            Call Isi()
            kodebuku.Focus()
        Else
            If kodebuku.Text = "" Or judulbuku.Text = "" Or pengarangbuku.Text = "" Or penerbit.Text = "" Or tahunbuku.Text = "" Or stokbuku.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                kodebuku.Focus()
            Else
                Dim buku = New Buku With {
                        .JudulBuku = judulbuku.Text,
                        .KodeBuku = kodebuku.Text,
                        .Penerbit = penerbit.Text,
                        .PengarangBuku = pengarangbuku.Text,
                        .TahunBuku = tahunbuku.Text,
                        .StokBuku = stokbuku.Text
                    }
                Dim Update = buku.Update()
                If (Update) Then
                    MsgBox("Data Berhasil di Ubah", MsgBoxStyle.MsgBoxRight, "Message")
                    Call tampilkan()
                Else
                    MsgBox("Data Gagal di Ubah......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If

            End If
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If Delete.Text = "DELETE" Then
            Delete.Text = "HAPUS"
            Input.Enabled = False
            Update.Enabled = False
            Keluar.Text = "&CANCEL"
            Call Isi()
            kodebuku.Focus()
        Else
            If kodebuku.Text = "" Or judulbuku.Text = "" Or pengarangbuku.Text = "" Or penerbit.Text = "" Or tahunbuku.Text = "" Or stokbuku.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                kodebuku.Focus()
            Else

                Dim buku = New Buku With {
                        .KodeBuku = kodebuku.Text
                    }
                Dim Delete = buku.Delete()
                If (Delete) Then
                    MsgBox("Data Berhasil di Hapus", MsgBoxStyle.MsgBoxRight, "Message")
                    Call tampilkan()
                Else
                    MsgBox("Data Gagal di Hapus......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If

            End If
        End If
    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        If Keluar.Text = "KELUAR" Then
            Me.Close()
        Else
            Call tampilkan()
        End If
    End Sub
    Private Sub kodebuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodebuku.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim hasil = Buku.Cari(kodebuku.Text)
            If IsNothing(hasil) Then
                MsgBox("Data tidak ada")
            Else
                judulbuku.Text = hasil.JudulBuku
                pengarangbuku.Text = hasil.PengarangBuku
                penerbit.Text = hasil.TahunBuku
                tahunbuku.Text = hasil.TahunBuku
                stokbuku.Text = hasil.StokBuku
            End If
        End If
    End Sub
    Private Sub kodebuku_KeyDown(sender As Object, e As KeyEventArgs) Handles kodebuku.KeyDown
        If e.KeyCode = Keys.Enter Then
            judulbuku.Focus()
        End If
    End Sub
    Private Sub judulbuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles judulbuku.KeyPress
        If e.KeyChar = Chr(13) Then
            pengarangbuku.Focus()
        End If
    End Sub
    Private Sub pengarangbuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pengarangbuku.KeyPress
        If e.KeyChar = Chr(13) Then
            penerbit.Focus()
        End If
    End Sub
    Private Sub penerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles penerbit.KeyPress
        If e.KeyChar = Chr(13) Then
            tahunbuku.Focus()
        End If
    End Sub
    Private Sub tahunbuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tahunbuku.KeyPress
        If e.KeyChar = Chr(13) Then
            stokbuku.Focus()
        End If
    End Sub
    Private Sub stokbuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stokbuku.KeyPress
        If e.KeyChar = Chr(13) Then
            Input.Focus()
            Update.Focus()
            Delete.Focus()
        End If
    End Sub
    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from tblbuku where judulbuku like '%" & txtcari.Text & "%'", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblbuku")
        dgBuku.DataSource = Ds.Tables("tblbuku")
        dgBuku.AllowUserToAddRows = False
        dgBuku.ReadOnly = True
    End Sub
    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim hasil = Buku.Search(txtcari.Text)
            If IsNothing(hasil) Then
                MsgBox("Data tidak ada")
            Else
                kodebuku.Text = hasil.KodeBuku
                judulbuku.Text = hasil.JudulBuku
                pengarangbuku.Text = hasil.PengarangBuku
                penerbit.Text = hasil.TahunBuku
                tahunbuku.Text = hasil.TahunBuku
                stokbuku.Text = hasil.StokBuku
            End If
        End If
    End Sub

    Private Sub txtcari_Click(sender As Object, e As EventArgs) Handles txtcari.Click
        If Keluar.Text = "KELUAR" Then
            Keluar.Text = "&CANCEL"
            Input.Enabled = False
            Update.Enabled = False
            Delete.Enabled = False
        End If
    End Sub
End Class