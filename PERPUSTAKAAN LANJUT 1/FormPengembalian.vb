Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class FormPengembalian
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim T_Buku As Long
    Dim T_Kembali As Long
    Dim bil1 As Double
    Dim bil2 As Double
    Dim bil3 As Double
    Sub Tampil()
        kodebuku.Text = ""
        JumlahPinjam.Text = ""
        LblNamaAnggota.Text = ""
        LblJudulBuku.Text = ""
        LblNoPinjam.Text = ""
        LblTglPinjam.Text = ""
        LblLamaPinjam.Text = ""
        LblDenda.Text = ""
        kodeanggota.Text = ""
        LblTelahPinjam.Text = ""
        LblTotalKembali.Text = ""
        Keluar.Text = "KELUAR"
    End Sub
    Sub TampilGrid1()
        dgpengembalian.Columns.Add("Kode", "Kode Buku")
        dgpengembalian.Columns.Add("Nomor", "Nomor Pinjam")
        dgpengembalian.Columns.Add("Judul", "Judul Buku")
        dgpengembalian.Columns.Add("Jumlah", "Jumlah Kembali")
        dgpengembalian.Columns.Add("Tanggal", "Tanggal Pinjam")
        dgpengembalian.Columns.Add("Lama", "Lama Pinjam")
        dgpengembalian.Columns.Add("Denda", "Denda")
        dgpengembalian.Columns(2).Width = 175
        dgpengembalian.Columns(4).Width = 75
        dgpengembalian.Columns(6).Width = 75
    End Sub
    Sub TampilGrid2()
        dgKembali.Columns.Clear()
        dgKembali.Columns.Add("Kode", "Kode Buku")
        dgKembali.Columns.Add("judul", "Judul Buku")
        dgKembali.Columns.Add("Jumlah", "Jumlah Buku")
    End Sub

    Sub NoOtomatis()
        Call OpenConn()
        Cmd = New MySqlCommand("select NoKembali from tblkembali order by NoKembali desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            LblNomorKembali.Text = "NK" + Format(Today, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(Rd.Item("NoKembali"), 3, 6) = Format(Today, "yyMMdd") Then
                LblNomorKembali.Text = "NK" + Format(Microsoft.VisualBasic.Right(Rd.Item("NoKembali"), 8) + 1, "00")
            Else
                LblNomorKembali.Text = "NK" + Format(Today, "yyMMdd") + "01"
            End If
        End If
    End Sub
    Sub Pinjaman()
        Call OpenConn()
        Da = New MySqlDataAdapter("select tblbuku.KodeBuku,JudulBuku,JumlahBuku,TglPinjam from tblanggota,tblpinjam,tblbuku,tbldetailpinjam where tblbuku.KodeBuku = tbldetailpinjam.KodeBuku And tblpinjam.NoPinjam = tbldetailpinjam.NoPinjam And tblanggota.KodeAnggota = tblpinjam.KodeAnggota And tblanggota.KodeAnggota = '" & kodeanggota.Text & "' AND tbldetailpinjam.JumlahBuku>0", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        dgKembali.DataSource = Ds.Tables("Detail")
        dgKembali.AllowUserToAddRows = False
        LblTotalKembali.Text = dgKembali.RowCount & String.Format(" Buku")
        dgKembali.Columns(0).Width = 80
        dgKembali.Columns(1).Width = 300
        dgKembali.Columns(2).Width = 100
    End Sub
    Sub CariData()
        Call OpenConn()
        Cmd = New MySqlCommand("select * from tblanggota where KodeAnggota = '" & kodeanggota.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LblNamaAnggota.Text = Rd.Item("NamaAnggota")
            Call OpenConn()
            Cmd = New MySqlCommand("select KodeAnggota from tblpinjam where KodeAnggota = '" & kodeanggota.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Call OpenConn()
                Cmd = New MySqlCommand("Select SUM(TotalPinjam) As meet from tblpinjam where KodeAnggota = '" & kodeanggota.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                LblTelahPinjam.Text = Rd.Item(0)
                Call Pinjaman()
            End If
            kodebuku.Focus()
        End If
    End Sub
    Sub Hapus()
        kodebuku.Text = ""
        LblJudulBuku.Text = ""
        LblNoPinjam.Text = ""
        LblTglPinjam.Text = ""
        LblLamaPinjam.Text = ""
        LblDenda.Text = ""
        LblJumlahKembali.Text = ""
    End Sub
    Sub TotalDenda()
        Dim subtot As Integer = 0
        For I As Integer = 0 To dgpengembalian.Rows.Count - 1
            subtot += Val(dgpengembalian.Rows(I).Cells(6).Value)
            LblTotalDenda.Text = subtot
        Next
    End Sub
    Sub TotalKembali()
        Dim subtot As Integer = 0
        For I As Integer = 0 To dgpengembalian.Rows.Count - 1
            subtot += Val(dgpengembalian.Rows(I).Cells(3).Value)
            LblJumlahKembali.Text = subtot & String.Format(" Buku")
        Next
    End Sub
    Sub HitungTotalBuku()
        Dim Hitung As Long = 0
        For Baris As Long = 0 To dgKembali.Rows.Count - 1
            Hitung = Hitung + dgKembali.Rows(Baris).Cells(2).Value
        Next
        T_Buku = Hitung
    End Sub
    Sub MunculKodeBuku()
        Call OpenConn()
        kodebuku.Items.Clear()
        Cmd = New MySqlCommand("select * from tblbuku", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            kodebuku.Items.Add(Rd.Item(0))
        Loop
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
    Private Sub FormPengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MunculKodeAnggota()
        Call MunculKodeBuku()
        Call TampilGrid1()
        dgKembali.Columns.Clear()
        LblJumlahKembali.Text = ""
        LblTotalDenda.Text = ""
        txtBayar.Text = ""
        lblKembalian.Text = ""
        Call Tampil()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblJam.Text = TimeOfDay
    End Sub

    Private Sub FormPengembalian_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call NoOtomatis()
        kodeanggota.Focus()
        dgKembali.Columns.Clear()
        LblTglKembali.Text = Today
        LblPetugas.Text = Menu_Utama.NamaPetugas.Text
    End Sub

    Private Sub Input_Click(sender As Object, e As EventArgs) Handles Input.Click
        Keluar.Text = "&CANCEL"
        If kodeanggota.Text = "" Or kodebuku.Text = "" Or JumlahPinjam.Text = "" Then
            MsgBox("Pastikan Buku Yang Mau di Kembalikan !!!")
        Else
            dgpengembalian.Rows.Add(New String() {kodebuku.Text, LblNoPinjam.Text, LblJudulBuku.Text, JumlahPinjam.Text, LblTglPinjam.Text, LblLamaPinjam.Text, LblDenda.Text})
            Call Hapus()
            Call TotalDenda()
            Call TotalKembali()
            kodebuku.Focus()
        End If
    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        If kodeanggota.Text = "" Or LblTotalDenda.Text = "" Or lblKembalian.Text = "" Then
            MsgBox("Transaksi Tidak Ada, Silahkan lakukan Transaksi Terlebih Dahulu !!!")
        Else
            Call OpenConn()
            Dim tglmysql = Format(Today, "yyyy-MM-dd")
            Dim BukuKembali As String = "Insert into tblkembali (NoKembali,TglKembali,TotalKembali,Denda,DiBayar,Kembali,KodeAnggota,NamaPetugas) values ('" & LblNomorKembali.Text & "', '" & tglmysql & "', '" & LblTotalKembali.Text & "', '" & LblTotalDenda.Text & "', '" & txtBayar.Text & "', '" & lblKembalian.Text & "','" & kodeanggota.Text & "', '" & Menu_Utama.NamaPetugas.Text & "')"
            Cmd = New MySqlCommand(BukuKembali, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To dgpengembalian.Rows.Count - 2
                Call OpenConn()
                Dim SimpanDetailPinjam As String = "Insert into tbldetailkembali(NoKembali,KodeBuku,JumlahBuku) values ('" & LblNomorKembali.Text & "', '" & dgpengembalian.Rows(Baris).Cells(0).Value & "', '" & dgpengembalian.Rows(Baris).Cells(3).Value & "')"
                Cmd = New MySqlCommand(SimpanDetailPinjam, Conn)
                Cmd.ExecuteNonQuery()
                Call OpenConn()
                Cmd = New MySqlCommand("select * from tblbuku where KodeBuku = '" & dgpengembalian.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Call OpenConn()
                Dim KurangiStok As String = "update tblbuku set StokBuku = '" & Rd.Item("StokBuku") + dgpengembalian.Rows(Baris).Cells(3).Value & "' where KodeBuku = '" & dgpengembalian.Rows(Baris).Cells(0).Value & "'"
                Cmd = New MySqlCommand(KurangiStok, Conn)
                Cmd.ExecuteNonQuery()
                Call OpenConn()
                Cmd = New MySqlCommand("select JumlahBuku from tbldetailpinjam where KodeBuku= '" & dgpengembalian.Rows(Baris).Cells(0).Value & "' and NoPinjam= '" & dgpengembalian.Rows(Baris).Cells(1).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    Call OpenConn()
                    Dim UpdateDetailPinjam As String = "update tbldetailpinjam set JumlahBuku= '" & Rd.Item(0) - dgpengembalian.Rows(Baris).Cells(3).Value & "' Where KodeBuku= '" & dgpengembalian.Rows(Baris).Cells(0).Value & "' and NoPinjam= '" & dgpengembalian.Rows(Baris).Cells(1).Value & "'"
                    Cmd = New MySqlCommand(UpdateDetailPinjam, Conn)
                    Cmd.ExecuteNonQuery()
                End If
                Call OpenConn()
                Cmd = New MySqlCommand("select totalPinjam from tblpinjam where NoPinjam= '" & dgpengembalian.Rows(Baris).Cells(1).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    Call OpenConn()
                    Dim UpdatePinjam As String = "update tblpinjam set totalPinjam= '" & Rd.Item(0) - dgpengembalian.Rows(Baris).Cells(3).Value & "' where NoPinjam= '" & dgpengembalian.Rows(Baris).Cells(1).Value & "'"
                    Cmd = New MySqlCommand(UpdatePinjam, Conn)
                    Cmd.ExecuteNonQuery()
                End If
            Next
            Call Tampil()
            Call NoOtomatis()
            dgKembali.Columns.Clear()
            MsgBox("Transaksi Telah Berhasil Disimpan")
        End If
    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        If Keluar.Text = "KELUAR" Then
            Me.Close()
            dgpengembalian.Columns.Clear()
        Else
            Call Tampil()
            dgKembali.Columns.Clear()
            dgpengembalian.Rows.Clear()
            LblJumlahKembali.Text = ""
            LblTotalDenda.Text = ""
            txtBayar.Text = ""
            lblKembalian.Text = ""
            kodeanggota.Focus()
        End If
    End Sub

    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtBayar.Text) < Val(LblDenda.Text) Then
                MsgBox("Pembayaran Kurang")
                txtBayar.Focus()
            ElseIf Val(txtBayar.Text) = Val(LblDenda.Text) Then
                lblKembalian.Text = 0
                Simpan.Focus()
            Else
                lblKembalian.Text = Val(txtBayar.Text) - Val(LblTotalDenda.Text)
                lblKembalian.Text = lblKembalian.Text
                Simpan.Focus()
            End If
        End If
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim Tinggi As Integer
        Dim pagesetup As New PageSettings
        Tinggi += 50
        pagesetup.PaperSize = New PaperSize("Custom", 340, 500 + Tinggi)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub kodeanggota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kodeanggota.SelectedIndexChanged
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblanggota where KodeAnggota='" & kodeanggota.Text & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            MsgBox("Data tidak ada")
        Else
            Keluar.Text = "&CANCEL"
            dgKembali.Columns.Clear()
            Call CariData()
        End If
    End Sub

    Private Sub kodebuku_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kodebuku.SelectedIndexChanged
        Call OpenConn()
        Cmd = New MySqlCommand("select distinct tblbuku.KodeBuku,tbldetailpinjam.NoPinjam,JudulBuku,JumlahBuku,TglPinjam from tblanggota,tblpinjam,tblbuku,tbldetailpinjam where tblbuku.KodeBuku = tbldetailpinjam.KodeBuku And tblpinjam.NoPinjam = tbldetailpinjam.NoPinjam And tblanggota.KodeAnggota = tblpinjam.KodeAnggota And tblanggota.KodeAnggota = '" & kodeanggota.Text & "' AND tbldetailpinjam.KodeBuku = '" & kodebuku.Text & "' and tbldetailpinjam.JumlahBuku>0", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            MsgBox("Kode Buku Bukan Yang Di Pinjam !!!")
            Call Hapus()
            Call CariData()
        Else
            LblNoPinjam.Text = Rd.Item(1)
            LblJudulBuku.Text = Rd.Item(2)
            JumlahPinjam.Text = Rd.Item(3)
            LblTglPinjam.Text = Rd.Item(4)
            LblLamaPinjam.Text = DateDiff(DateInterval.Day, Rd.Item(4), Today())
            If LblLamaPinjam.Text > 5 Then
                LblDenda.Text = Val((LblLamaPinjam.Text) - 5) * 1000
            Else
                LblDenda.Text = 0
            End If
            Input.Focus()
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
        Garis = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ "

        e.Graphics.DrawString("UNIVERSITAS NAHDLATUL ULAMA NTB", f10, Brushes.Black, centermargint, 10, Tengah)
        e.Graphics.DrawString("Alamat : Jalan Pendidikan No 06 Mataram - 83125", f9, Brushes.Black, centermargint, 30, Tengah)
        e.Graphics.DrawString("Telp.(0370)6170869", f9, Brushes.Black, centermargint, 45, Tengah)
        e.Graphics.DrawString("Website : www.unu.ntb.ac.id, Email : unu.ntb@gmail.com", f9, Brushes.Black, centermargint, 60, Tengah)
        e.Graphics.DrawString(Garis, f9, Brushes.Black, 0, 65)
        e.Graphics.DrawString("NOTA PENGEMBALIAN", f14, Brushes.Black, centermargint, 83, Tengah)
        e.Graphics.DrawString(Garis, f9, Brushes.Black, 0, 95)

        e.Graphics.DrawString("Kode Petugas", f9, Brushes.Black, 5, 115)
        e.Graphics.DrawString(":", f9, Brushes.Black, 85, 115)
        e.Graphics.DrawString(Menu_Utama.KodePetugas.Text, f9b, Brushes.Black, 95, 115)
        e.Graphics.DrawString("Nama Petugas", f9, Brushes.Black, 5, 130)
        e.Graphics.DrawString(":", f9, Brushes.Black, 85, 130)
        e.Graphics.DrawString(LblPetugas.Text, f9b, Brushes.Black, 95, 130)
        e.Graphics.DrawString(Garis, f9, Brushes.Black, 0, 140)

        e.Graphics.DrawString("Sisa Buku Yang Dipinjam", f10, Brushes.Black, centermargint, 160, Tengah)
        e.Graphics.DrawString(Garis, f9, Brushes.Black, 0, 165)

        Dim Tinggi As Integer
        Dim i As Long
        For baris As Integer = 0 To dgKembali.Rows.Count - 1
            dgKembali.ReadOnly = True
            Tinggi += 15
            e.Graphics.DrawString(dgKembali.Rows(baris).Cells(0).Value.ToString, f9b, Brushes.Black, 5, 167 + Tinggi)
            e.Graphics.DrawString(dgKembali.Rows(baris).Cells(1).Value.ToString, f9b, Brushes.Black, 60, 167 + Tinggi)
            e.Graphics.DrawString(dgKembali.Rows(baris).Cells(3).Value.ToString, f9b, Brushes.Black, 180, 167 + Tinggi)

            i = dgKembali.Rows(baris).Cells(2).Value
            dgKembali.Rows(baris).Cells(2).Value = Format(i, "##")
            e.Graphics.DrawString(dgKembali.Rows(baris).Cells(2).Value.ToString & " Buku", f9b, Brushes.Black, rightmargint, 167 + Tinggi, Kanan)
        Next
        Tinggi = 175 + Tinggi
        HitungTotalBuku()
        e.Graphics.DrawString(Garis, f9, Brushes.Black, 0, Tinggi)
        e.Graphics.DrawString("Sisa Pinjam : " & LblTotalKembali.Text, f9b, Brushes.Black, 5, 17 + Tinggi)
        e.Graphics.DrawString("Jumlah : " & Format(T_Buku, "##") & " Buku", f9b, Brushes.Black, rightmargint, 17 + Tinggi, Kanan)
        e.Graphics.DrawString(Garis, f9b, Brushes.Black, 0, 25 + Tinggi)

        e.Graphics.DrawString("Buku Yang Dikembalikan", f10, Brushes.Black, centermargint, 45 + Tinggi, Tengah)
        e.Graphics.DrawString(Garis, f9b, Brushes.Black, 0, 50 + Tinggi)

        For Baris As Integer = 0 To dgpengembalian.Rows.Count - 2
            dgpengembalian.ReadOnly = True
            Tinggi += 30
            e.Graphics.DrawString(dgpengembalian.Rows(Baris).Cells(0).Value.ToString, f9b, Brushes.Black, 5, 40 + Tinggi)
            e.Graphics.DrawString(dgpengembalian.Rows(Baris).Cells(1).Value.ToString, f9b, Brushes.Black, 60, 40 + Tinggi)
            e.Graphics.DrawString(dgpengembalian.Rows(Baris).Cells(2).Value.ToString, f9b, Brushes.Black, 140, 40 + Tinggi)
            e.Graphics.DrawString(LblTglKembali.Text, f9b, Brushes.Black, rightmargint, 40 + Tinggi, Kanan)
            e.Graphics.DrawString(dgpengembalian.Rows(Baris).Cells(4).Value.ToString, f9b, Brushes.Black, 5, 53 + Tinggi)
            e.Graphics.DrawString(dgpengembalian.Rows(Baris).Cells(5).Value.ToString & (" Hari"), f9b, Brushes.Black, 70, 53 + Tinggi)
            e.Graphics.DrawString(dgpengembalian.Rows(Baris).Cells(3).Value.ToString & (" Buku"), f9b, Brushes.Black, 120, 53 + Tinggi)
            e.Graphics.DrawString("Denda = Rp." & dgpengembalian.Rows(Baris).Cells(6).Value.ToString, f9b, Brushes.Black, 170, 53 + Tinggi)
        Next
        Tinggi = 63 + Tinggi
        e.Graphics.DrawString(Garis, f9, Brushes.Black, 0, Tinggi)
        e.Graphics.DrawString("Total Buku yang Kembali : " & LblJumlahKembali.Text, f9b, Brushes.Black, 5, 17 + Tinggi)
        e.Graphics.DrawString("Bayar = Rp." & txtBayar.Text, f9b, Brushes.Black, rightmargint, 17 + Tinggi, Kanan)
        e.Graphics.DrawString("Kembalian = Rp." & lblKembalian.Text, f9b, Brushes.Black, rightmargint, 34 + Tinggi, Kanan)
        e.Graphics.DrawString(Garis, f9b, Brushes.Black, 0, 40 + Tinggi)

        e.Graphics.DrawString("Kode Anggota : " & kodeanggota.Text, f9b, Brushes.Black, 5, 55 + Tinggi)
        e.Graphics.DrawString("Nama Anggota : " & LblNamaAnggota.Text, f9b, Brushes.Black, 5, 70 + Tinggi)
        e.Graphics.DrawString(Garis, f9b, Brushes.Black, 0, 75 + Tinggi)

        e.Graphics.DrawString("TERIMAKAIH ATAS KERJA SAMANYA", f10, Brushes.Black, centermargint, 115 + Tinggi, Tengah)
        e.Graphics.DrawString("And", f10, Brushes.Black, centermargint, 130 + Tinggi, Tengah)
        e.Graphics.DrawString("____See You Nex Time____", f10, Brushes.Black, centermargint, 145 + Tinggi, Tengah)

        e.Graphics.DrawString("PERPUSTAKAAN ", f14, Brushes.Black, centermargint, 180 + Tinggi, Tengah)

    End Sub
End Class