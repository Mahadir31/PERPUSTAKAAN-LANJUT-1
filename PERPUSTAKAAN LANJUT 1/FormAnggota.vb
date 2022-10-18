Imports MySql.Data.MySqlClient
Public Class FormAnggota
    Sub tampilkan()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from tblanggota", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblanggota")
        dgAnggota.DataSource = Ds.Tables("tblanggota")
        dgAnggota.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver

        Input.Enabled = True
        Input.Text = "INPUT"
        Update.Enabled = True
        Update.Text = "UPDATE"
        Delete.Enabled = True
        Delete.Text = "DELETE"
        Keluar.Text = "KELUAR"

        kodeanggota.Text = ""
        namaanggota.Text = ""
        jeniskelamin.Text = ""
        alamatanggota.Text = ""
        telponanggota.Text = ""
        txtcari.Text = ""

        kodeanggota.Enabled = False
        namaanggota.Enabled = False
        jeniskelamin.Enabled = False
        alamatanggota.Enabled = False
        telponanggota.Enabled = False
    End Sub
    Sub Isi()
        kodeanggota.Enabled = True
        namaanggota.Enabled = True
        jeniskelamin.Enabled = True
        alamatanggota.Enabled = True
        telponanggota.Enabled = True
    End Sub
    Private Sub FormAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilkan()
    End Sub

    Private Sub Input_Click(sender As Object, e As EventArgs) Handles Input.Click
        If Input.Text = "INPUT" Then
            Input.Text = "SIMPAN"
            Update.Enabled = False
            Delete.Enabled = False
            Keluar.Text = "&CANCEL"
            Call Isi()
            kodeanggota.Focus()
        Else
            If kodeanggota.Text = "" Or namaanggota.Text = "" Or jeniskelamin.Text = "" Or alamatanggota.Text = "" Or telponanggota.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi", MsgBoxStyle.Critical, "WARNING!!!")
                kodeanggota.Focus()
            Else
                Dim anggota = New Anggota With {
                        .KodeAnggota = kodeanggota.Text,
                        .NamaAnggota = namaanggota.Text,
                        .JenisKelamin = jeniskelamin.Text,
                        .AlamatAnggota = alamatanggota.Text,
                        .TelponAnggota = telponanggota.Text
                    }
                    Dim Simpan = anggota.Save()
                If (Simpan) Then
                    MsgBox("Data Berhasil di Simpan !!!", MsgBoxStyle.MsgBoxRight, "Message")
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
            kodeanggota.Focus()
        Else
            If kodeanggota.Text = "" Or namaanggota.Text = "" Or jeniskelamin.Text = "" Or alamatanggota.Text = "" Or telponanggota.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi", MsgBoxStyle.Critical, "WARNING!!!")
                kodeanggota.Focus()
            Else

                Dim anggota = New Anggota With {
                        .KodeAnggota = kodeanggota.Text,
                        .NamaAnggota = namaanggota.Text,
                        .JenisKelamin = jeniskelamin.Text,
                        .AlamatAnggota = alamatanggota.Text,
                        .TelponAnggota = telponanggota.Text
                    }
                Dim Update = anggota.Update()
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
            kodeanggota.Focus()
        Else
            If kodeanggota.Text = "" Or namaanggota.Text = "" Or jeniskelamin.Text = "" Or alamatanggota.Text = "" Or telponanggota.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi", MsgBoxStyle.Critical, "WARNING!!!")
                kodeanggota.Focus()
            Else
                Dim anggota = New Anggota With {
                    .KodeAnggota = kodeanggota.Text
                    }
                Dim Delete = anggota.Delete()
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
    Private Sub kodeanggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodeanggota.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim hasil = Anggota.Carikode(kodeanggota.Text)
            If IsNothing(hasil) Then
                MsgBox("Data tidak ada", MsgBoxStyle.Critical, "WARNING!!!")
            Else
                namaanggota.Text = hasil.NamaAnggota
                jeniskelamin.Text = hasil.JenisKelamin
                alamatanggota.Text = hasil.AlamatAnggota
                telponanggota.Text = hasil.TelponAnggota
            End If
        End If
    End Sub
    Private Sub kodeanggota_KeyDown(sender As Object, e As KeyEventArgs) Handles kodeanggota.KeyDown
        If e.KeyCode = Keys.Enter Then
            namaanggota.Focus()
        End If
    End Sub
    Private Sub namaanggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namaanggota.KeyPress
        If e.KeyChar = Chr(13) Then
            jeniskelamin.Focus()
        End If
    End Sub
    Private Sub jeniskelamin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jeniskelamin.KeyPress
        If e.KeyChar = Chr(13) Then
            alamatanggota.Focus()
        End If
    End Sub
    Private Sub alamatanggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles alamatanggota.KeyPress
        If e.KeyChar = Chr(13) Then
            telponanggota.Focus()
        End If
    End Sub
    Private Sub telponanggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telponanggota.KeyPress
        If e.KeyChar = Chr(13) Then
            Input.Focus()
            Update.Focus()
            Delete.Focus()
        End If
    End Sub

    Private Sub FormAnggota_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        jeniskelamin.Text = ""
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from tblanggota where NamaAnggota like '%" & txtcari.Text & "%'", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblanggota")
        dgAnggota.DataSource = Ds.Tables("tblanggota")
        dgAnggota.AllowUserToAddRows = False
        dgAnggota.ReadOnly = True
    End Sub
    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim hasil = Anggota.Carinama(txtcari.Text)
            If IsNothing(hasil) Then
                MsgBox("Data tidak ada", MsgBoxStyle.Critical, "WARNING!!!")
            Else
                kodeanggota.Text = hasil.KodeAnggota
                namaanggota.Text = hasil.NamaAnggota
                jeniskelamin.Text = hasil.JenisKelamin
                alamatanggota.Text = hasil.AlamatAnggota
                telponanggota.Text = hasil.TelponAnggota
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