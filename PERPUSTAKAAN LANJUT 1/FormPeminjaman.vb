Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class FormPeminjaman
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim T_Buku As Long
    Sub Tampilkan()
        Call MunculKodeAnggota()
        Call MunculKodeBuku()
        LblNama.Text = ""
        LblKelamin.Text = ""
        LblAlamat.Text = ""
        LblTelpon.Text = ""
        LblBuku.Text = ""
        kodeanggota.Text = ""
        LblPengarang.Text = ""
        LblTotalBuku.Text = "0"
        txtKode.Text = ""
        txtJumlah.Text = ""
        LblPenerbit.Text = ""
        Lbltelahpinjam.Text = "0"
        txtKode.Enabled = True
        kodeanggota.Enabled = True
        input.Enabled = True
        txtJumlah.Enabled = True
    End Sub
    Sub Mati()
        Call NoOtomatis()
        Call BuatKolom()
        LblNama.Enabled = False
        LblKelamin.Enabled = False
        LblAlamat.Enabled = False
        LblTelpon.Enabled = False
        LblBuku.Enabled = False
        kodeanggota.Enabled = False
        LblPengarang.Enabled = False
        LblTotalBuku.Enabled = False
        txtKode.Enabled = False
        txtJumlah.Enabled = False
        LblPenerbit.Enabled = False
        input.Enabled = False

        LblNamaPetugas.Text = Menu_Utama.NamaPetugas.Text

        Tambah.Text = "TAMBAH"
        Keluar.Text = "KELUAR"
        Cari.Text = "CARI"

        kodeanggota.Text = ""
        LblNama.Text = ""
        LblKelamin.Text = ""
        LblAlamat.Text = ""
        LblTelpon.Text = ""
        LblBuku.Text = ""
        kodeanggota.Text = ""
        LblPengarang.Text = ""
        LblTotalBuku.Text = ""
        txtKode.Text = ""
        txtJumlah.Text = ""
        LblPenerbit.Text = ""
        Lbltelahpinjam.Text = ""
        dgtelahpinjam.Columns.Clear()
    End Sub
    Sub NoOtomatis()
        Call OpenConn()
        Cmd = New MySqlCommand("select NoPinjam from tblpinjam order by NoPinjam desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            LblNoPinjam.Text = "PJ" + Format(Today, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(Rd.Item("NoPinjam"), 3, 6) = Format(Today, "yyMMdd") Then
                LblNoPinjam.Text = "PJ" + Format(Microsoft.VisualBasic.Right(Rd.Item("NoPinjam"), 8) + 1, "00")
            Else
                LblNoPinjam.Text = "PJ" + Format(Today, "yyMMdd") + "01"
            End If
        End If
    End Sub
    Sub MunculKodeAnggota()
        Call OpenConn()
        kodeanggota.Items.Clear()
        Cmd = New MySqlCommand("select * from tblanggota", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            kodeanggota.Items.Add(Rd.Item(0))
        Loop
    End Sub
    Sub MunculKodeBuku()
        Call OpenConn()
        txtKode.Items.Clear()
        Cmd = New MySqlCommand("select * from tblbuku", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            txtKode.Items.Add(Rd.Item(0))
        Loop
    End Sub
    Sub CekPinjaman()
        Call OpenConn()
        Da = New MySqlDataAdapter("select tblbuku.KodeBuku,JudulBuku,JumlahBuku,TglPinjam from tblanggota,tblpinjam,tblbuku,tbldetailpinjam where tblbuku.KodeBuku = tbldetailpinjam.KodeBuku And tblpinjam.NoPinjam = 
                                   tbldetailpinjam.NoPinjam And tblanggota.KodeAnggota = tblpinjam.KodeAnggota And tblanggota.KodeAnggota = '" & kodeanggota.Text & "' AND tbldetailpinjam.JumlahBuku>0", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        dgtelahpinjam.DataSource = Ds.Tables("Detail")
        dgtelahpinjam.AllowUserToAddRows = False
        Lbltelahpinjam.Text = dgtelahpinjam.RowCount
        dgtelahpinjam.ReadOnly = True
    End Sub
    Sub BuatKolom()
        dgPinjam.Columns.Clear()
        dgPinjam.Columns.Add("Kode", "Kode Buku")
        dgPinjam.Columns.Add("Judul", "Judul Buku")
        dgPinjam.Columns.Add("Pengarang", "Pengarang Buku")
        dgPinjam.Columns.Add("Penerbit", "Penerbit")
        dgPinjam.Columns.Add("Jumlah", "Jumlah Buku")
    End Sub
    Private Sub FormPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltanggal.Text = Today
    End Sub
    Private Sub kodeanggota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kodeanggota.SelectedIndexChanged
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblanggota where KodeAnggota='" & kodeanggota.Text & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            MsgBox("Data tidak ada")
        Else
            LblNama.Text = Rd.Item("NamaAnggota")
            LblKelamin.Text = Rd.Item("JenisKelamin")
            LblAlamat.Text = Rd.Item("AlamatAnggota")
            LblTelpon.Text = Rd.Item("TelponAnggota")
            Call CekPinjaman()
        End If
    End Sub
    Private Sub input_Click(sender As Object, e As EventArgs) Handles input.Click
        If Val(Lbltelahpinjam.Text) + (LblTotalBuku.Text) >= 5 Or Val(LblTotalBuku.Text) + Val(txtJumlah.Text) > 5 Then
            MsgBox("Buku Yang Dipinjam Melebihi Maksimal !!!")
            Call Tampilkan()
            Keluar.Text = "&CANCEL"
            txtKode.Focus()
            txtKode.Text = ""
        Else
            If txtKode.Text = "" Or txtJumlah.Text = "" Then
                MsgBox("Silahkan masukkan Kode Buku Dan Tekan ENTER !!!")
                Call Tampilkan()
                Tambah.Text = "&SIMPAN"
                Keluar.Text = "&CANCEL"
                txtKode.Focus()
                txtKode.Text = ""
            Else
                dgPinjam.Rows.Add(New String() {txtKode.Text, LblBuku.Text, LblPengarang.Text, LblPenerbit.Text, txtJumlah.Text})
                txtKode.Text = ""
                LblBuku.Text = ""
                LblPengarang.Text = ""
                LblPenerbit.Text = ""
                txtJumlah.Text = ""
                Dim sum As Decimal = 0
                For i = 0 To dgPinjam.Rows.Count - 1
                    sum += dgPinjam.Rows(i).Cells(4).Value
                Next
                LblTotalBuku.Text = sum
            End If
        End If
    End Sub
    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        If Tambah.Text = "TAMBAH" Then
            Tambah.Text = "SIMPAN"
            Keluar.Text = "&CANCEL"
            Call Tampilkan()
        Else
            If kodeanggota.Text = "" Or LblTotalBuku.Text = "0" Then
                MsgBox("Transaksi Tidak Ada, silahkan lakukan transaksi terlebih dhulu")
            Else
                Call OpenConn()
                Dim tglmysql As String = Format(Today, "yyyy-MM-dd")
                Dim PinjamBuku As String = "Insert into tblpinjam values ('" & LblNoPinjam.Text & "', '" & tglmysql & "', '" & lbljam.Text & "', '" & kodeanggota.Text & "', '" &
                                                                               LblTotalBuku.Text & "', '" & LblTotalBuku.Text & "', '" & Menu_Utama.NamaPetugas.Text & "')"
                Cmd = New MySqlCommand(PinjamBuku, Conn)
                Cmd.ExecuteNonQuery()

                For Baris As Integer = 0 To dgPinjam.Rows.Count - 1
                    Call OpenConn()
                    Dim SimpanDetailPinjam As String = "Insert into tbldetailpinjam values ('" & LblNoPinjam.Text & "', '" & dgPinjam.Rows(Baris).Cells(0).Value & "', '" & dgPinjam.Rows(Baris).Cells(4).Value & "')"
                    Cmd = New MySqlCommand(SimpanDetailPinjam, Conn)
                    Cmd.ExecuteNonQuery()
                    Call OpenConn()
                    Cmd = New MySqlCommand("select * from tblbuku where KodeBuku = '" & dgPinjam.Rows(Baris).Cells(0).Value & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    Rd.Read()
                    Call OpenConn()
                    Dim KurangiStok As String = "update tblbuku set StokBuku = '" & Rd.Item("StokBuku") - dgPinjam.Rows(Baris).Cells(4).Value & "' where KodeBuku = '" & dgPinjam.Rows(Baris).Cells(0).Value & "'"
                    Cmd = New MySqlCommand(KurangiStok, Conn)
                    Cmd.ExecuteNonQuery()
                Next
                MsgBox("Transaksi Telah Berhasil Disimpan")
                Call Mati()
            End If
        End If
    End Sub
    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        If Keluar.Text = "KELUAR" Then
            Me.Close()
        Else
            Call Mati()
            Tambah.Enabled = True
        End If
    End Sub
    Private Sub FormPeminjaman_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call Mati()
        kodeanggota.Text = ""
    End Sub

    Private Sub Cari_Click(sender As Object, e As EventArgs) Handles Cari.Click
        If Cari.Text = "CARI" Then
            Cari.Text = "&PRINT"
            Keluar.Text = "&CANCEL"
            Call MunculKodeAnggota()
            Call CekPinjaman()
            kodeanggota.Enabled = True
            Tambah.Enabled = False
        Else
            PPD.Document = PD
            PPD.ShowDialog()
            Tambah.Enabled = True
        End If
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f9 As New Font("Times New Roman", 9, FontStyle.Regular)
        Dim f9b As New Font("Times New Roman", 9, FontStyle.Bold)
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargint As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargint As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim Kanan As New StringFormat
        Dim Tengah As New StringFormat
        Kanan.Alignment = StringAlignment.Far
        Tengah.Alignment = StringAlignment.Center


        Dim Garis As String
        Garis = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ "

        e.Graphics.DrawString("UNIVERSITAS NAHDLATUL ULAMA NTB", f10, Brushes.Black, centermargint, 10, Tengah)
        e.Graphics.DrawString("Alamat : Jalan Pendidikan No 06 Mataram - 83125", f9, Brushes.Black, centermargint, 30, Tengah)
        e.Graphics.DrawString("Telp.(0370)6170869", f9, Brushes.Black, centermargint, 45, Tengah)
        e.Graphics.DrawString("Website : www.unu.ntb.ac.id, Email : unu.ntb@gmail.com", f9, Brushes.Black, centermargint, 60, Tengah)
        e.Graphics.DrawString(Garis, f9, Brushes.Black, 0, 65)
        e.Graphics.DrawString("NOTA PEMINJAMAN", f14, Brushes.Black, centermargint, 83, Tengah)
        e.Graphics.DrawString(Garis, f9, Brushes.Black, 0, 95)

        e.Graphics.DrawString("Kode Petugas", f9, Brushes.Black, 5, 115)
        e.Graphics.DrawString(":", f9, Brushes.Black, 85, 115)
        e.Graphics.DrawString(Menu_Utama.KodePetugas.Text, f9b, Brushes.Black, 95, 115)
        e.Graphics.DrawString("Nama Petugas", f9, Brushes.Black, 5, 130)
        e.Graphics.DrawString(":", f9, Brushes.Black, 85, 130)
        e.Graphics.DrawString(LblNamaPetugas.Text, f9b, Brushes.Black, 95, 130)
        e.Graphics.DrawString(Garis, f9, Brushes.Black, 0, 140)
        e.Graphics.DrawString(Garis, f9, Brushes.Black, 0, 155)


        Dim Tinggi As Integer
        Dim i As Long
        For baris As Integer = 0 To dgtelahpinjam.Rows.Count - 1
            dgtelahpinjam.ReadOnly = True
            Tinggi += 15
            e.Graphics.DrawString(dgtelahpinjam.Rows(baris).Cells(0).Value.ToString, f9b, Brushes.Black, 5, 165 + Tinggi)
            e.Graphics.DrawString(dgtelahpinjam.Rows(baris).Cells(1).Value.ToString, f9b, Brushes.Black, 60, 165 + Tinggi)
            e.Graphics.DrawString(dgtelahpinjam.Rows(baris).Cells(3).Value.ToString, f9b, Brushes.Black, 180, 165 + Tinggi)

            i = dgtelahpinjam.Rows(baris).Cells(2).Value
            dgtelahpinjam.Rows(baris).Cells(2).Value = Format(i, "##")
            e.Graphics.DrawString(dgtelahpinjam.Rows(baris).Cells(2).Value.ToString & " Buku", f9b, Brushes.Black, rightmargint, 165 + Tinggi, Kanan)
        Next
        Tinggi = 175 + Tinggi
        HitungTotalBuku()
        e.Graphics.DrawString(Garis, f9, Brushes.Black, 0, Tinggi)

        e.Graphics.DrawString("Jumlah Pinjam", f9b, Brushes.Black, 5, 17 + Tinggi)
        e.Graphics.DrawString(":", f9b, Brushes.Black, 85, 17 + Tinggi)
        e.Graphics.DrawString(Lbltelahpinjam.Text & " Buku", f9b, Brushes.Black, 95, 17 + Tinggi)
        e.Graphics.DrawString("Jumlah Buku : " & Format(T_Buku, "##") & " Buku", f9b, Brushes.Black, rightmargint, 17 + Tinggi, Kanan)
        e.Graphics.DrawString(Garis, f9b, Brushes.Black, 0, 25 + Tinggi)

        e.Graphics.DrawString("Kode Anggota", f9, Brushes.Black, 5, 45 + Tinggi)
        e.Graphics.DrawString(":", f9, Brushes.Black, 85, 45 + Tinggi)
        e.Graphics.DrawString(kodeanggota.Text, f9b, Brushes.Black, 95, 45 + Tinggi)
        e.Graphics.DrawString("Nama Anggota", f9, Brushes.Black, 5, 58 + Tinggi)
        e.Graphics.DrawString(":", f9, Brushes.Black, 85, 58 + Tinggi)
        e.Graphics.DrawString(LblNama.Text, f9b, Brushes.Black, 95, 58 + Tinggi)
        e.Graphics.DrawString("Telpon", f9, Brushes.Black, 5, 71 + Tinggi)
        e.Graphics.DrawString(":", f9, Brushes.Black, 85, 71 + Tinggi)
        e.Graphics.DrawString(LblTelpon.Text, f9b, Brushes.Black, 95, 71 + Tinggi)
        e.Graphics.DrawString(Garis, f9b, Brushes.Black, 0, 76 + Tinggi)

        e.Graphics.DrawString("WARNING !!!", f9b, Brushes.Black, 5, 95 + Tinggi)
        e.Graphics.DrawString("*Maksimal Peminjaman Buku 5 Hari", f9, Brushes.Black, 10, 110 + Tinggi)
        e.Graphics.DrawString("*Kembali Setelah 5 Hari Maka Akan DiKenaan Denda", f9, Brushes.Black, 10, 125 + Tinggi)
        e.Graphics.DrawString("*Denda Lewat 1 Hari * 1.000", f9, Brushes.Black, 10, 140 + Tinggi)

        e.Graphics.DrawString("TERIMAKAIH", f10, Brushes.Black, centermargint, 180 + Tinggi, Tengah)
        e.Graphics.DrawString("&", f10, Brushes.Black, centermargint, 195 + Tinggi, Tengah)
        e.Graphics.DrawString("____Selamat Membaca____", f10, Brushes.Black, centermargint, 210 + Tinggi, Tengah)

        e.Graphics.DrawString("PERPUSTAKAAN", f14, Brushes.Black, centermargint, 240 + Tinggi, Tengah)
    End Sub
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim Tinggi As Integer
        Dim pagesetup As New PageSettings
        Tinggi += 50
        pagesetup.PaperSize = New PaperSize("Custom", 340, 500 + Tinggi)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Sub HitungTotalBuku()
        Dim Hitung As Long = 0
        For Baris As Long = 0 To dgtelahpinjam.Rows.Count - 1
            Hitung += dgtelahpinjam.Rows(Baris).Cells(2).Value
        Next
        T_Buku = Hitung
    End Sub

    Private Sub txtKode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtKode.SelectedIndexChanged
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblbuku where KodeBuku='" & txtKode.Text & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            MsgBox("Kode Buku tidak ada")
            Call Tampilkan()
            Keluar.Text = "&CANCEL"
            txtKode.Focus()
            txtKode.Text = ""
        Else
            txtKode.Text = Rd.Item("KodeBuku")
            LblBuku.Text = Rd.Item("JudulBuku")
            LblPengarang.Text = Rd.Item("PengarangBuku")
            LblPenerbit.Text = Rd.Item("Penerbit")
            txtJumlah.Text = True
            txtJumlah.Text = "1"
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbljam.Text = TimeOfDay
    End Sub
End Class