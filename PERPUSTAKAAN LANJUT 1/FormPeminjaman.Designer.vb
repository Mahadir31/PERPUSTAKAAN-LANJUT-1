<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPeminjaman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPeminjaman))
        Me.txtKode = New System.Windows.Forms.ComboBox()
        Me.Cari = New System.Windows.Forms.Button()
        Me.LblNamaPetugas = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Lbltelahpinjam = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dgtelahpinjam = New System.Windows.Forms.DataGridView()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.LblPenerbit = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblTotalBuku = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LblPengarang = New System.Windows.Forms.Label()
        Me.hdkghu = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblKelamin = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgPinjam = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Tambah = New System.Windows.Forms.Button()
        Me.Keluar = New System.Windows.Forms.Button()
        Me.input = New System.Windows.Forms.Button()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.kodeanggota = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbljam = New System.Windows.Forms.Label()
        Me.lbltanggal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblBuku = New System.Windows.Forms.Label()
        Me.judul = New System.Windows.Forms.Label()
        Me.LblTelpon = New System.Windows.Forms.Label()
        Me.LblAlamat = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblNoPinjam = New System.Windows.Forms.Label()
        Me.kodebuku = New System.Windows.Forms.Label()
        Me.telpon = New System.Windows.Forms.Label()
        Me.alamat = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.Label()
        Me.kode = New System.Windows.Forms.Label()
        Me.nopinjam = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgtelahpinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKode
        '
        Me.txtKode.BackColor = System.Drawing.Color.SlateGray
        Me.txtKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKode.FormattingEnabled = True
        Me.txtKode.Location = New System.Drawing.Point(126, 206)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(103, 21)
        Me.txtKode.TabIndex = 179
        '
        'Cari
        '
        Me.Cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cari.Location = New System.Drawing.Point(444, 412)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(75, 23)
        Me.Cari.TabIndex = 178
        Me.Cari.Text = "CARI"
        Me.Cari.UseVisualStyleBackColor = True
        '
        'LblNamaPetugas
        '
        Me.LblNamaPetugas.AutoSize = True
        Me.LblNamaPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaPetugas.Location = New System.Drawing.Point(491, 119)
        Me.LblNamaPetugas.Name = "LblNamaPetugas"
        Me.LblNamaPetugas.Size = New System.Drawing.Size(102, 13)
        Me.LblNamaPetugas.TabIndex = 177
        Me.LblNamaPetugas.Text = "LblNamaPetugas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(106, 545)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 176
        Me.Label12.Text = ":"
        '
        'Lbltelahpinjam
        '
        Me.Lbltelahpinjam.AutoSize = True
        Me.Lbltelahpinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltelahpinjam.Location = New System.Drawing.Point(123, 545)
        Me.Lbltelahpinjam.Name = "Lbltelahpinjam"
        Me.Lbltelahpinjam.Size = New System.Drawing.Size(88, 13)
        Me.Lbltelahpinjam.TabIndex = 175
        Me.Lbltelahpinjam.Text = "Lbltelahpinjam"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(13, 545)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 13)
        Me.Label28.TabIndex = 174
        Me.Label28.Text = "Telah Pinjam"
        '
        'dgtelahpinjam
        '
        Me.dgtelahpinjam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtelahpinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtelahpinjam.Location = New System.Drawing.Point(15, 441)
        Me.dgtelahpinjam.Name = "dgtelahpinjam"
        Me.dgtelahpinjam.Size = New System.Drawing.Size(587, 101)
        Me.dgtelahpinjam.TabIndex = 173
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(474, 119)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(11, 13)
        Me.Label26.TabIndex = 172
        Me.Label26.Text = ":"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(379, 119)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(53, 13)
        Me.Label31.TabIndex = 171
        Me.Label31.Text = "Petugas"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(452, 230)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(11, 13)
        Me.Label25.TabIndex = 170
        Me.Label25.Text = ":"
        '
        'LblPenerbit
        '
        Me.LblPenerbit.AutoSize = True
        Me.LblPenerbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPenerbit.Location = New System.Drawing.Point(469, 230)
        Me.LblPenerbit.Name = "LblPenerbit"
        Me.LblPenerbit.Size = New System.Drawing.Size(71, 13)
        Me.LblPenerbit.TabIndex = 169
        Me.LblPenerbit.Text = "LblPenerbit"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(377, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 168
        Me.Label10.Text = "Penerbit"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(294, 417)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 167
        Me.Label11.Text = ":"
        '
        'LblTotalBuku
        '
        Me.LblTotalBuku.AutoSize = True
        Me.LblTotalBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalBuku.Location = New System.Drawing.Point(311, 417)
        Me.LblTotalBuku.Name = "LblTotalBuku"
        Me.LblTotalBuku.Size = New System.Drawing.Size(82, 13)
        Me.LblTotalBuku.TabIndex = 166
        Me.LblTotalBuku.Text = "LblTotalBuku"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(219, 417)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 165
        Me.Label8.Text = "Total Buku"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(106, 251)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 164
        Me.Label16.Text = ":"
        '
        'LblPengarang
        '
        Me.LblPengarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPengarang.Location = New System.Drawing.Point(123, 251)
        Me.LblPengarang.Name = "LblPengarang"
        Me.LblPengarang.Size = New System.Drawing.Size(222, 13)
        Me.LblPengarang.TabIndex = 163
        Me.LblPengarang.Text = "LblPengarang"
        '
        'hdkghu
        '
        Me.hdkghu.AutoSize = True
        Me.hdkghu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdkghu.Location = New System.Drawing.Point(13, 251)
        Me.hdkghu.Name = "hdkghu"
        Me.hdkghu.Size = New System.Drawing.Size(68, 13)
        Me.hdkghu.TabIndex = 162
        Me.hdkghu.Text = "Pengarang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(106, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 161
        Me.Label7.Text = ":"
        '
        'LblKelamin
        '
        Me.LblKelamin.AutoSize = True
        Me.LblKelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKelamin.Location = New System.Drawing.Point(123, 142)
        Me.LblKelamin.Name = "LblKelamin"
        Me.LblKelamin.Size = New System.Drawing.Size(68, 13)
        Me.LblKelamin.TabIndex = 160
        Me.LblKelamin.Text = "LblKelamin"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 159
        Me.Label9.Text = "Jenis Kelamin"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(106, 229)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(11, 13)
        Me.Label24.TabIndex = 158
        Me.Label24.Text = ":"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(106, 160)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(11, 13)
        Me.Label22.TabIndex = 156
        Me.Label22.Text = ":"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(106, 123)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(11, 13)
        Me.Label21.TabIndex = 155
        Me.Label21.Text = ":"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(106, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 13)
        Me.Label20.TabIndex = 154
        Me.Label20.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(474, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 13)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(452, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(474, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(106, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = ":"
        '
        'dgPinjam
        '
        Me.dgPinjam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPinjam.Location = New System.Drawing.Point(14, 278)
        Me.dgPinjam.Name = "dgPinjam"
        Me.dgPinjam.Size = New System.Drawing.Size(587, 128)
        Me.dgPinjam.TabIndex = 148
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(106, 183)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(11, 13)
        Me.Label23.TabIndex = 157
        Me.Label23.Text = ":"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Tambah
        '
        Me.Tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tambah.Location = New System.Drawing.Point(15, 412)
        Me.Tambah.Name = "Tambah"
        Me.Tambah.Size = New System.Drawing.Size(75, 23)
        Me.Tambah.TabIndex = 147
        Me.Tambah.Text = "TAMBAH"
        Me.Tambah.UseVisualStyleBackColor = True
        '
        'Keluar
        '
        Me.Keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keluar.Location = New System.Drawing.Point(525, 412)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(75, 23)
        Me.Keluar.TabIndex = 146
        Me.Keluar.Text = "KELUAR"
        Me.Keluar.UseVisualStyleBackColor = True
        '
        'input
        '
        Me.input.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input.Location = New System.Drawing.Point(526, 246)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(75, 23)
        Me.input.TabIndex = 145
        Me.input.Text = "INPUT"
        Me.input.UseVisualStyleBackColor = True
        '
        'txtJumlah
        '
        Me.txtJumlah.BackColor = System.Drawing.Color.SlateGray
        Me.txtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlah.Location = New System.Drawing.Point(472, 248)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(48, 20)
        Me.txtJumlah.TabIndex = 144
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'kodeanggota
        '
        Me.kodeanggota.BackColor = System.Drawing.Color.SlateGray
        Me.kodeanggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kodeanggota.FormattingEnabled = True
        Me.kodeanggota.Location = New System.Drawing.Point(126, 88)
        Me.kodeanggota.Name = "kodeanggota"
        Me.kodeanggota.Size = New System.Drawing.Size(103, 21)
        Me.kodeanggota.TabIndex = 143
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(377, 255)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 142
        Me.Label19.Text = "Jumlah"
        '
        'lbljam
        '
        Me.lbljam.AutoSize = True
        Me.lbljam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljam.Location = New System.Drawing.Point(491, 92)
        Me.lbljam.Name = "lbljam"
        Me.lbljam.Size = New System.Drawing.Size(50, 13)
        Me.lbljam.TabIndex = 141
        Me.lbljam.Text = "Lbl Jam"
        '
        'lbltanggal
        '
        Me.lbltanggal.AutoSize = True
        Me.lbltanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltanggal.Location = New System.Drawing.Point(491, 65)
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(74, 13)
        Me.lbltanggal.TabIndex = 140
        Me.lbltanggal.Text = "Lbl Tanggal"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(381, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 13)
        Me.Label14.TabIndex = 139
        Me.Label14.Text = "Jam"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(379, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "Tanggal"
        '
        'LblBuku
        '
        Me.LblBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuku.Location = New System.Drawing.Point(121, 229)
        Me.LblBuku.Name = "LblBuku"
        Me.LblBuku.Size = New System.Drawing.Size(224, 13)
        Me.LblBuku.TabIndex = 137
        Me.LblBuku.Text = "LblBuku"
        '
        'judul
        '
        Me.judul.AutoSize = True
        Me.judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judul.Location = New System.Drawing.Point(13, 229)
        Me.judul.Name = "judul"
        Me.judul.Size = New System.Drawing.Size(37, 13)
        Me.judul.TabIndex = 136
        Me.judul.Text = "Judul"
        '
        'LblTelpon
        '
        Me.LblTelpon.AutoSize = True
        Me.LblTelpon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelpon.Location = New System.Drawing.Point(123, 183)
        Me.LblTelpon.Name = "LblTelpon"
        Me.LblTelpon.Size = New System.Drawing.Size(63, 13)
        Me.LblTelpon.TabIndex = 135
        Me.LblTelpon.Text = "LblTelpon"
        '
        'LblAlamat
        '
        Me.LblAlamat.AutoSize = True
        Me.LblAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAlamat.Location = New System.Drawing.Point(123, 160)
        Me.LblAlamat.Name = "LblAlamat"
        Me.LblAlamat.Size = New System.Drawing.Size(62, 13)
        Me.LblAlamat.TabIndex = 134
        Me.LblAlamat.Text = "LblAlamat"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNama.Location = New System.Drawing.Point(123, 123)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(56, 13)
        Me.LblNama.TabIndex = 133
        Me.LblNama.Text = "LblNama"
        '
        'LblNoPinjam
        '
        Me.LblNoPinjam.AutoSize = True
        Me.LblNoPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNoPinjam.Location = New System.Drawing.Point(123, 64)
        Me.LblNoPinjam.Name = "LblNoPinjam"
        Me.LblNoPinjam.Size = New System.Drawing.Size(77, 13)
        Me.LblNoPinjam.TabIndex = 132
        Me.LblNoPinjam.Text = "LblNoPinjam"
        '
        'kodebuku
        '
        Me.kodebuku.AutoSize = True
        Me.kodebuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kodebuku.Location = New System.Drawing.Point(13, 209)
        Me.kodebuku.Name = "kodebuku"
        Me.kodebuku.Size = New System.Drawing.Size(69, 13)
        Me.kodebuku.TabIndex = 131
        Me.kodebuku.Text = "Kode Buku"
        '
        'telpon
        '
        Me.telpon.AutoSize = True
        Me.telpon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telpon.Location = New System.Drawing.Point(13, 183)
        Me.telpon.Name = "telpon"
        Me.telpon.Size = New System.Drawing.Size(46, 13)
        Me.telpon.TabIndex = 130
        Me.telpon.Text = "Telpon"
        '
        'alamat
        '
        Me.alamat.AutoSize = True
        Me.alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alamat.Location = New System.Drawing.Point(13, 160)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(45, 13)
        Me.alamat.TabIndex = 129
        Me.alamat.Text = "Alamat"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(13, 123)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(39, 13)
        Me.nama.TabIndex = 128
        Me.nama.Text = "Nama"
        '
        'kode
        '
        Me.kode.AutoSize = True
        Me.kode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode.Location = New System.Drawing.Point(13, 91)
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(87, 13)
        Me.kode.TabIndex = 127
        Me.kode.Text = "Kode Anggota"
        '
        'nopinjam
        '
        Me.nopinjam.AutoSize = True
        Me.nopinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nopinjam.Location = New System.Drawing.Point(13, 64)
        Me.nopinjam.Name = "nopinjam"
        Me.nopinjam.Size = New System.Drawing.Size(64, 13)
        Me.nopinjam.TabIndex = 126
        Me.nopinjam.Text = "No Pinjam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SlateGray
        Me.Label1.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(175, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 32)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "PEMINJAMAN BUKU"
        '
        'FormPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(614, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.Cari)
        Me.Controls.Add(Me.LblNamaPetugas)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Lbltelahpinjam)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.dgtelahpinjam)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.LblPenerbit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LblTotalBuku)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LblPengarang)
        Me.Controls.Add(Me.hdkghu)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblKelamin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgPinjam)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Tambah)
        Me.Controls.Add(Me.Keluar)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.kodeanggota)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lbljam)
        Me.Controls.Add(Me.lbltanggal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LblBuku)
        Me.Controls.Add(Me.judul)
        Me.Controls.Add(Me.LblTelpon)
        Me.Controls.Add(Me.LblAlamat)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.LblNoPinjam)
        Me.Controls.Add(Me.kodebuku)
        Me.Controls.Add(Me.telpon)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.kode)
        Me.Controls.Add(Me.nopinjam)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPeminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPeminjaman"
        CType(Me.dgtelahpinjam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPinjam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKode As ComboBox
    Friend WithEvents Cari As Button
    Friend WithEvents LblNamaPetugas As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Lbltelahpinjam As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents dgtelahpinjam As DataGridView
    Friend WithEvents Label26 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents LblPenerbit As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblTotalBuku As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LblPengarang As Label
    Friend WithEvents hdkghu As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblKelamin As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgPinjam As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label23 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Tambah As Button
    Friend WithEvents Keluar As Button
    Friend WithEvents input As Button
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents kodeanggota As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents lbljam As Label
    Friend WithEvents lbltanggal As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LblBuku As Label
    Friend WithEvents judul As Label
    Friend WithEvents LblTelpon As Label
    Friend WithEvents LblAlamat As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents LblNoPinjam As Label
    Friend WithEvents kodebuku As Label
    Friend WithEvents telpon As Label
    Friend WithEvents alamat As Label
    Friend WithEvents nama As Label
    Friend WithEvents kode As Label
    Friend WithEvents nopinjam As Label
    Friend WithEvents Label1 As Label
End Class
