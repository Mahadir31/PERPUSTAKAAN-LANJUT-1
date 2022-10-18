<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengembalian
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
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.LblJumlahKembali = New System.Windows.Forms.Label()
        Me.kkkkk = New System.Windows.Forms.Label()
        Me.kodebuku = New System.Windows.Forms.ComboBox()
        Me.kodeanggota = New System.Windows.Forms.ComboBox()
        Me.LblTotalDenda = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LblTotalKembali = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Print = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.LblJam = New System.Windows.Forms.Label()
        Me.LblPetugas = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Keluar = New System.Windows.Forms.Button()
        Me.Simpan = New System.Windows.Forms.Button()
        Me.dgKembali = New System.Windows.Forms.DataGridView()
        Me.dgpengembalian = New System.Windows.Forms.DataGridView()
        Me.LblDenda = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LblTglPinjam = New System.Windows.Forms.Label()
        Me.LblLamaPinjam = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LblNoPinjam = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Input = New System.Windows.Forms.Button()
        Me.JumlahPinjam = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LblJudulBuku = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblTglKembali = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblTelahPinjam = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblNomorKembali = New System.Windows.Forms.Label()
        Me.LblNamaAnggota = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpengembalian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(336, 373)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(11, 13)
        Me.Label40.TabIndex = 191
        Me.Label40.Text = ":"
        '
        'lblKembalian
        '
        Me.lblKembalian.AutoSize = True
        Me.lblKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKembalian.Location = New System.Drawing.Point(574, 333)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(78, 13)
        Me.lblKembalian.TabIndex = 188
        Me.lblKembalian.Text = "lblKembalian"
        '
        'LblJumlahKembali
        '
        Me.LblJumlahKembali.AutoSize = True
        Me.LblJumlahKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJumlahKembali.Location = New System.Drawing.Point(353, 373)
        Me.LblJumlahKembali.Name = "LblJumlahKembali"
        Me.LblJumlahKembali.Size = New System.Drawing.Size(107, 13)
        Me.LblJumlahKembali.TabIndex = 193
        Me.LblJumlahKembali.Text = "LblJumlahKembali"
        '
        'kkkkk
        '
        Me.kkkkk.AutoSize = True
        Me.kkkkk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kkkkk.Location = New System.Drawing.Point(204, 373)
        Me.kkkkk.Name = "kkkkk"
        Me.kkkkk.Size = New System.Drawing.Size(126, 13)
        Me.kkkkk.TabIndex = 192
        Me.kkkkk.Text = "Jumlah Yang kembali"
        '
        'kodebuku
        '
        Me.kodebuku.BackColor = System.Drawing.Color.SlateGray
        Me.kodebuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kodebuku.FormattingEnabled = True
        Me.kodebuku.Location = New System.Drawing.Point(129, 98)
        Me.kodebuku.Name = "kodebuku"
        Me.kodebuku.Size = New System.Drawing.Size(100, 21)
        Me.kodebuku.TabIndex = 190
        '
        'kodeanggota
        '
        Me.kodeanggota.BackColor = System.Drawing.Color.SlateGray
        Me.kodeanggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kodeanggota.FormattingEnabled = True
        Me.kodeanggota.Location = New System.Drawing.Point(129, 71)
        Me.kodeanggota.Name = "kodeanggota"
        Me.kodeanggota.Size = New System.Drawing.Size(100, 21)
        Me.kodeanggota.TabIndex = 189
        '
        'LblTotalDenda
        '
        Me.LblTotalDenda.AutoSize = True
        Me.LblTotalDenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalDenda.Location = New System.Drawing.Point(313, 333)
        Me.LblTotalDenda.Name = "LblTotalDenda"
        Me.LblTotalDenda.Size = New System.Drawing.Size(90, 13)
        Me.LblTotalDenda.TabIndex = 187
        Me.LblTotalDenda.Text = "LblTotalDenda"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(305, 333)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(11, 13)
        Me.Label31.TabIndex = 186
        Me.Label31.Text = ":"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(440, 333)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(11, 13)
        Me.Label30.TabIndex = 185
        Me.Label30.Text = ":"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(566, 333)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(11, 13)
        Me.Label29.TabIndex = 184
        Me.Label29.Text = ":"
        '
        'txtBayar
        '
        Me.txtBayar.BackColor = System.Drawing.Color.SlateGray
        Me.txtBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar.Location = New System.Drawing.Point(450, 330)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(70, 20)
        Me.txtBayar.TabIndex = 183
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(519, 333)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(51, 13)
        Me.Label28.TabIndex = 182
        Me.Label28.Text = "Kembali"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(405, 333)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(39, 13)
        Me.Label27.TabIndex = 181
        Me.Label27.Text = "Bayar"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(265, 333)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(44, 13)
        Me.Label26.TabIndex = 180
        Me.Label26.Text = "Denda"
        '
        'LblTotalKembali
        '
        Me.LblTotalKembali.AutoSize = True
        Me.LblTotalKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalKembali.Location = New System.Drawing.Point(113, 333)
        Me.LblTotalKembali.Name = "LblTotalKembali"
        Me.LblTotalKembali.Size = New System.Drawing.Size(97, 13)
        Me.LblTotalKembali.TabIndex = 179
        Me.LblTotalKembali.Text = "LblTotalKembali"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(13, 333)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 13)
        Me.Label24.TabIndex = 178
        Me.Label24.Text = "Total Pinjam"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(96, 333)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(11, 13)
        Me.Label25.TabIndex = 177
        Me.Label25.Text = ":"
        '
        'Print
        '
        Me.Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print.Location = New System.Drawing.Point(87, 349)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(64, 34)
        Me.Print.TabIndex = 176
        Me.Print.Text = "PRINT"
        Me.Print.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.SlateGray
        Me.Label37.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label37.Location = New System.Drawing.Point(185, 14)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(295, 32)
        Me.Label37.TabIndex = 175
        Me.Label37.Text = "PENGEMBALIAN BUKU"
        '
        'LblJam
        '
        Me.LblJam.AutoSize = True
        Me.LblJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJam.Location = New System.Drawing.Point(562, 69)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(46, 13)
        Me.LblJam.TabIndex = 174
        Me.LblJam.Text = "LblJam"
        '
        'LblPetugas
        '
        Me.LblPetugas.AutoSize = True
        Me.LblPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPetugas.Location = New System.Drawing.Point(562, 82)
        Me.LblPetugas.Name = "LblPetugas"
        Me.LblPetugas.Size = New System.Drawing.Size(70, 13)
        Me.LblPetugas.TabIndex = 173
        Me.LblPetugas.Text = "LblPetugas"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(545, 82)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(11, 13)
        Me.Label36.TabIndex = 172
        Me.Label36.Text = ":"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(545, 69)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(11, 13)
        Me.Label35.TabIndex = 171
        Me.Label35.Text = ":"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(486, 82)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 13)
        Me.Label34.TabIndex = 170
        Me.Label34.Text = "Petugas"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(510, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 13)
        Me.Label16.TabIndex = 169
        Me.Label16.Text = "Jam"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(354, 121)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(78, 13)
        Me.Label33.TabIndex = 168
        Me.Label33.Text = "Lama Pinjam"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(521, 101)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(11, 13)
        Me.Label32.TabIndex = 167
        Me.Label32.Text = ":"
        '
        'Keluar
        '
        Me.Keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keluar.Location = New System.Drawing.Point(587, 349)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(64, 34)
        Me.Keluar.TabIndex = 165
        Me.Keluar.Text = "KELUAR"
        Me.Keluar.UseVisualStyleBackColor = True
        '
        'Simpan
        '
        Me.Simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Simpan.Location = New System.Drawing.Point(17, 349)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(64, 34)
        Me.Simpan.TabIndex = 166
        Me.Simpan.Text = "SIMPAN"
        Me.Simpan.UseVisualStyleBackColor = True
        '
        'dgKembali
        '
        Me.dgKembali.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgKembali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKembali.Location = New System.Drawing.Point(15, 227)
        Me.dgKembali.Name = "dgKembali"
        Me.dgKembali.Size = New System.Drawing.Size(637, 97)
        Me.dgKembali.TabIndex = 164
        '
        'dgpengembalian
        '
        Me.dgpengembalian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgpengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpengembalian.Location = New System.Drawing.Point(15, 137)
        Me.dgpengembalian.Name = "dgpengembalian"
        Me.dgpengembalian.Size = New System.Drawing.Size(637, 84)
        Me.dgpengembalian.TabIndex = 163
        '
        'LblDenda
        '
        Me.LblDenda.AutoSize = True
        Me.LblDenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDenda.Location = New System.Drawing.Point(591, 121)
        Me.LblDenda.Name = "LblDenda"
        Me.LblDenda.Size = New System.Drawing.Size(61, 13)
        Me.LblDenda.TabIndex = 162
        Me.LblDenda.Text = "LblDenda"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(536, 121)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 13)
        Me.Label23.TabIndex = 161
        Me.Label23.Text = "Denda"
        '
        'LblTglPinjam
        '
        Me.LblTglPinjam.AutoSize = True
        Me.LblTglPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTglPinjam.Location = New System.Drawing.Point(262, 121)
        Me.LblTglPinjam.Name = "LblTglPinjam"
        Me.LblTglPinjam.Size = New System.Drawing.Size(79, 13)
        Me.LblTglPinjam.TabIndex = 160
        Me.LblTglPinjam.Text = "LblTglPinjam"
        '
        'LblLamaPinjam
        '
        Me.LblLamaPinjam.AutoSize = True
        Me.LblLamaPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLamaPinjam.Location = New System.Drawing.Point(443, 121)
        Me.LblLamaPinjam.Name = "LblLamaPinjam"
        Me.LblLamaPinjam.Size = New System.Drawing.Size(91, 13)
        Me.LblLamaPinjam.TabIndex = 159
        Me.LblLamaPinjam.Text = "LblLamaPinjam"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(247, 121)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(11, 13)
        Me.Label21.TabIndex = 158
        Me.Label21.Text = ":"
        '
        'LblNoPinjam
        '
        Me.LblNoPinjam.AutoSize = True
        Me.LblNoPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNoPinjam.Location = New System.Drawing.Point(92, 121)
        Me.LblNoPinjam.Name = "LblNoPinjam"
        Me.LblNoPinjam.Size = New System.Drawing.Size(77, 13)
        Me.LblNoPinjam.TabIndex = 157
        Me.LblNoPinjam.Text = "LblNoPinjam"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(77, 121)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 13)
        Me.Label20.TabIndex = 156
        Me.Label20.Text = ":"
        '
        'Input
        '
        Me.Input.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input.Location = New System.Drawing.Point(588, 95)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(64, 23)
        Me.Input.TabIndex = 155
        Me.Input.Text = "INPUT"
        Me.Input.UseVisualStyleBackColor = True
        '
        'JumlahPinjam
        '
        Me.JumlahPinjam.BackColor = System.Drawing.Color.SlateGray
        Me.JumlahPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JumlahPinjam.Location = New System.Drawing.Point(538, 98)
        Me.JumlahPinjam.Name = "JumlahPinjam"
        Me.JumlahPinjam.Size = New System.Drawing.Size(48, 20)
        Me.JumlahPinjam.TabIndex = 154
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(581, 121)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(11, 13)
        Me.Label22.TabIndex = 153
        Me.Label22.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(431, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 152
        Me.Label14.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(278, 101)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 13)
        Me.Label19.TabIndex = 151
        Me.Label19.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(109, 101)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(11, 13)
        Me.Label18.TabIndex = 150
        Me.Label18.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(181, 121)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 13)
        Me.Label17.TabIndex = 149
        Me.Label17.Text = "Tgl Pinjam"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 148
        Me.Label15.Text = "No Pinjam"
        '
        'LblJudulBuku
        '
        Me.LblJudulBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJudulBuku.Location = New System.Drawing.Point(295, 101)
        Me.LblJudulBuku.Name = "LblJudulBuku"
        Me.LblJudulBuku.Size = New System.Drawing.Size(192, 13)
        Me.LblJudulBuku.TabIndex = 147
        Me.LblJudulBuku.Text = "LblJudulBuku"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(493, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 146
        Me.Label13.Text = "Jml"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(235, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = "Judul"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Kode Buku"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(331, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 13)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(545, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 141
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(322, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 140
        Me.Label11.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(235, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 139
        Me.Label10.Text = "Nama Anggota"
        '
        'LblTglKembali
        '
        Me.LblTglKembali.AutoSize = True
        Me.LblTglKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTglKembali.Location = New System.Drawing.Point(562, 56)
        Me.LblTglKembali.Name = "LblTglKembali"
        Me.LblTglKembali.Size = New System.Drawing.Size(86, 13)
        Me.LblTglKembali.TabIndex = 138
        Me.LblTglKembali.Text = "LblTglKembali"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(438, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 137
        Me.Label8.Text = "Tanggal Kembali"
        '
        'LblTelahPinjam
        '
        Me.LblTelahPinjam.AutoSize = True
        Me.LblTelahPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelahPinjam.Location = New System.Drawing.Point(339, 56)
        Me.LblTelahPinjam.Name = "LblTelahPinjam"
        Me.LblTelahPinjam.Size = New System.Drawing.Size(93, 13)
        Me.LblTelahPinjam.TabIndex = 136
        Me.LblTelahPinjam.Text = "LblTelahPinjam"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(236, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Telah Pinjam"
        '
        'LblNomorKembali
        '
        Me.LblNomorKembali.AutoSize = True
        Me.LblNomorKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomorKembali.Location = New System.Drawing.Point(126, 56)
        Me.LblNomorKembali.Name = "LblNomorKembali"
        Me.LblNomorKembali.Size = New System.Drawing.Size(104, 13)
        Me.LblNomorKembali.TabIndex = 134
        Me.LblNomorKembali.Text = "LblNomorKembali"
        '
        'LblNamaAnggota
        '
        Me.LblNamaAnggota.AutoSize = True
        Me.LblNamaAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaAnggota.Location = New System.Drawing.Point(348, 75)
        Me.LblNamaAnggota.Name = "LblNamaAnggota"
        Me.LblNamaAnggota.Size = New System.Drawing.Size(103, 13)
        Me.LblNamaAnggota.TabIndex = 133
        Me.LblNamaAnggota.Text = "LblNamaAnggota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Kode Anggota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Nomor Kembali"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FormPengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(665, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.lblKembalian)
        Me.Controls.Add(Me.LblJumlahKembali)
        Me.Controls.Add(Me.kkkkk)
        Me.Controls.Add(Me.kodebuku)
        Me.Controls.Add(Me.kodeanggota)
        Me.Controls.Add(Me.LblTotalDenda)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.LblTotalKembali)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Print)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.LblJam)
        Me.Controls.Add(Me.LblPetugas)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Keluar)
        Me.Controls.Add(Me.Simpan)
        Me.Controls.Add(Me.dgKembali)
        Me.Controls.Add(Me.dgpengembalian)
        Me.Controls.Add(Me.LblDenda)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.LblTglPinjam)
        Me.Controls.Add(Me.LblLamaPinjam)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.LblNoPinjam)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Input)
        Me.Controls.Add(Me.JumlahPinjam)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LblJudulBuku)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblTglKembali)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LblTelahPinjam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblNomorKembali)
        Me.Controls.Add(Me.LblNamaAnggota)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPengembalian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPengembalian"
        CType(Me.dgKembali, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpengembalian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label40 As Label
    Friend WithEvents lblKembalian As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents LblJumlahKembali As Label
    Friend WithEvents kkkkk As Label
    Friend WithEvents kodebuku As ComboBox
    Friend WithEvents kodeanggota As ComboBox
    Friend WithEvents LblTotalDenda As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents LblTotalKembali As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Print As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents LblJam As Label
    Friend WithEvents LblPetugas As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Keluar As Button
    Friend WithEvents Simpan As Button
    Friend WithEvents dgKembali As DataGridView
    Friend WithEvents dgpengembalian As DataGridView
    Friend WithEvents LblDenda As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents LblTglPinjam As Label
    Friend WithEvents LblLamaPinjam As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents LblNoPinjam As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Input As Button
    Friend WithEvents JumlahPinjam As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LblJudulBuku As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LblTglKembali As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LblTelahPinjam As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblNomorKembali As Label
    Friend WithEvents LblNamaAnggota As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
