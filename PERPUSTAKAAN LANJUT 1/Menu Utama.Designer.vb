<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Utama))
        Me.tmtgl_jam = New System.Windows.Forms.Timer(Me.components)
        Me.NamaPetugas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.KodePetugas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tgl_jam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusPetugas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LAPORAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapporanPeminjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaoranMaasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pengembalian = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSI = New System.Windows.Forms.ToolStripMenuItem()
        Me.Peminjaman = New System.Windows.Forms.ToolStripMenuItem()
        Me.Buku = New System.Windows.Forms.ToolStripMenuItem()
        Me.Anggota = New System.Windows.Forms.ToolStripMenuItem()
        Me.Petugas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MASTER = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.Login = New System.Windows.Forms.ToolStripMenuItem()
        Me.FILE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PBUNU = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PBUNU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmtgl_jam
        '
        Me.tmtgl_jam.Enabled = True
        '
        'NamaPetugas
        '
        Me.NamaPetugas.BackColor = System.Drawing.Color.Transparent
        Me.NamaPetugas.ForeColor = System.Drawing.Color.White
        Me.NamaPetugas.Name = "NamaPetugas"
        resources.ApplyResources(Me.NamaPetugas, "NamaPetugas")
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        resources.ApplyResources(Me.ToolStripStatusLabel4, "ToolStripStatusLabel4")
        '
        'KodePetugas
        '
        Me.KodePetugas.BackColor = System.Drawing.Color.Transparent
        Me.KodePetugas.ForeColor = System.Drawing.Color.White
        Me.KodePetugas.Name = "KodePetugas"
        resources.ApplyResources(Me.KodePetugas, "KodePetugas")
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        resources.ApplyResources(Me.ToolStripStatusLabel3, "ToolStripStatusLabel3")
        '
        'tgl_jam
        '
        Me.tgl_jam.BackColor = System.Drawing.Color.Transparent
        Me.tgl_jam.ForeColor = System.Drawing.Color.White
        Me.tgl_jam.Name = "tgl_jam"
        resources.ApplyResources(Me.tgl_jam, "tgl_jam")
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        resources.ApplyResources(Me.ToolStripStatusLabel2, "ToolStripStatusLabel2")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.BackgroundImage = Global.PERPUSTAKAAN_LANJUT_1.My.Resources.Resources.Splash1
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.tgl_jam, Me.ToolStripStatusLabel3, Me.KodePetugas, Me.ToolStripStatusLabel4, Me.NamaPetugas, Me.ToolStripStatusLabel5, Me.StatusPetugas})
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        resources.ApplyResources(Me.ToolStripStatusLabel5, "ToolStripStatusLabel5")
        '
        'StatusPetugas
        '
        Me.StatusPetugas.BackColor = System.Drawing.Color.Transparent
        Me.StatusPetugas.ForeColor = System.Drawing.Color.White
        Me.StatusPetugas.Name = "StatusPetugas"
        resources.ApplyResources(Me.StatusPetugas, "StatusPetugas")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.PERPUSTAKAAN_LANJUT_1.My.Resources.Resources.Splash1
        Me.Label1.Name = "Label1"
        '
        'LAPORAN
        '
        Me.LAPORAN.BackColor = System.Drawing.Color.Transparent
        Me.LAPORAN.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LapporanPeminjamanToolStripMenuItem, Me.LaoranMaasterDataToolStripMenuItem})
        resources.ApplyResources(Me.LAPORAN, "LAPORAN")
        Me.LAPORAN.ForeColor = System.Drawing.Color.White
        Me.LAPORAN.Name = "LAPORAN"
        '
        'LapporanPeminjamanToolStripMenuItem
        '
        Me.LapporanPeminjamanToolStripMenuItem.Name = "LapporanPeminjamanToolStripMenuItem"
        resources.ApplyResources(Me.LapporanPeminjamanToolStripMenuItem, "LapporanPeminjamanToolStripMenuItem")
        '
        'LaoranMaasterDataToolStripMenuItem
        '
        Me.LaoranMaasterDataToolStripMenuItem.Name = "LaoranMaasterDataToolStripMenuItem"
        resources.ApplyResources(Me.LaoranMaasterDataToolStripMenuItem, "LaoranMaasterDataToolStripMenuItem")
        '
        'Pengembalian
        '
        Me.Pengembalian.Name = "Pengembalian"
        resources.ApplyResources(Me.Pengembalian, "Pengembalian")
        '
        'TRANSAKSI
        '
        Me.TRANSAKSI.BackColor = System.Drawing.Color.Transparent
        Me.TRANSAKSI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Peminjaman, Me.Pengembalian})
        resources.ApplyResources(Me.TRANSAKSI, "TRANSAKSI")
        Me.TRANSAKSI.ForeColor = System.Drawing.Color.White
        Me.TRANSAKSI.Name = "TRANSAKSI"
        '
        'Peminjaman
        '
        Me.Peminjaman.Name = "Peminjaman"
        resources.ApplyResources(Me.Peminjaman, "Peminjaman")
        '
        'Buku
        '
        Me.Buku.Name = "Buku"
        resources.ApplyResources(Me.Buku, "Buku")
        '
        'Anggota
        '
        Me.Anggota.Name = "Anggota"
        resources.ApplyResources(Me.Anggota, "Anggota")
        '
        'Petugas
        '
        Me.Petugas.Name = "Petugas"
        resources.ApplyResources(Me.Petugas, "Petugas")
        '
        'MASTER
        '
        Me.MASTER.BackColor = System.Drawing.Color.Transparent
        Me.MASTER.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Petugas, Me.Anggota, Me.Buku})
        resources.ApplyResources(Me.MASTER, "MASTER")
        Me.MASTER.ForeColor = System.Drawing.Color.White
        Me.MASTER.Name = "MASTER"
        '
        'ExitTool
        '
        Me.ExitTool.Name = "ExitTool"
        resources.ApplyResources(Me.ExitTool, "ExitTool")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'LogOut
        '
        Me.LogOut.Name = "LogOut"
        resources.ApplyResources(Me.LogOut, "LogOut")
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.Color.Transparent
        Me.Login.Name = "Login"
        resources.ApplyResources(Me.Login, "Login")
        '
        'FILE
        '
        Me.FILE.BackColor = System.Drawing.Color.Transparent
        Me.FILE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Login, Me.LogOut, Me.ToolStripMenuItem1, Me.ExitTool})
        resources.ApplyResources(Me.FILE, "FILE")
        Me.FILE.ForeColor = System.Drawing.Color.White
        Me.FILE.Name = "FILE"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImage = Global.PERPUSTAKAAN_LANJUT_1.My.Resources.Resources.Splash1
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILE, Me.MASTER, Me.TRANSAKSI, Me.LAPORAN})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'PBUNU
        '
        Me.PBUNU.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PBUNU, "PBUNU")
        Me.PBUNU.Name = "PBUNU"
        Me.PBUNU.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Menu_Utama
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PERPUSTAKAAN_LANJUT_1.My.Resources.Resources.pengembangan_perpustakaan_sekolah_dan_digital
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PBUNU)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Menu_Utama"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PBUNU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmtgl_jam As Timer
    Friend WithEvents NamaPetugas As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents KodePetugas As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents tgl_jam As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents StatusPetugas As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents LAPORAN As ToolStripMenuItem
    Friend WithEvents Pengembalian As ToolStripMenuItem
    Friend WithEvents TRANSAKSI As ToolStripMenuItem
    Friend WithEvents Peminjaman As ToolStripMenuItem
    Friend WithEvents Buku As ToolStripMenuItem
    Friend WithEvents Anggota As ToolStripMenuItem
    Friend WithEvents Petugas As ToolStripMenuItem
    Friend WithEvents MASTER As ToolStripMenuItem
    Friend WithEvents ExitTool As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents LogOut As ToolStripMenuItem
    Friend WithEvents Login As ToolStripMenuItem
    Friend WithEvents FILE As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PBUNU As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LapporanPeminjamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaoranMaasterDataToolStripMenuItem As ToolStripMenuItem
End Class
