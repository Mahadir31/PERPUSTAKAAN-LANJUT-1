<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaporanTransaksiPerputakaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CetakLaporan = New System.Windows.Forms.Button()
        Me.dtPerTanggal = New System.Windows.Forms.DateTimePicker()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.dtPerMinggu1 = New System.Windows.Forms.DateTimePicker()
        Me.dtPerMinggu2 = New System.Windows.Forms.DateTimePicker()
        Me.dtPerTahun = New System.Windows.Forms.DateTimePicker()
        Me.dtTahun = New System.Windows.Forms.DateTimePicker()
        Me.cbPerBulan = New System.Windows.Forms.ComboBox()
        Me.RbTanggal = New System.Windows.Forms.RadioButton()
        Me.RbMinggu = New System.Windows.Forms.RadioButton()
        Me.RbBulan = New System.Windows.Forms.RadioButton()
        Me.RbTahun = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.RbPrintAll = New System.Windows.Forms.RadioButton()
        Me.Rbtblkembali = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CetakLaporan
        '
        Me.CetakLaporan.Font = New System.Drawing.Font("News706 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CetakLaporan.Location = New System.Drawing.Point(252, 179)
        Me.CetakLaporan.Name = "CetakLaporan"
        Me.CetakLaporan.Size = New System.Drawing.Size(86, 41)
        Me.CetakLaporan.TabIndex = 4
        Me.CetakLaporan.Text = "PRINT TBL &PINJAM"
        Me.CetakLaporan.UseVisualStyleBackColor = True
        '
        'dtPerTanggal
        '
        Me.dtPerTanggal.CalendarMonthBackground = System.Drawing.Color.SlateGray
        Me.dtPerTanggal.CustomFormat = "dd/MM/yyyy"
        Me.dtPerTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPerTanggal.Location = New System.Drawing.Point(104, 65)
        Me.dtPerTanggal.Name = "dtPerTanggal"
        Me.dtPerTanggal.Size = New System.Drawing.Size(97, 20)
        Me.dtPerTanggal.TabIndex = 8
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("News706 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Location = New System.Drawing.Point(12, 179)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(86, 41)
        Me.BtnKeluar.TabIndex = 9
        Me.BtnKeluar.Text = "&EXIT"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'dtPerMinggu1
        '
        Me.dtPerMinggu1.CalendarMonthBackground = System.Drawing.Color.SlateGray
        Me.dtPerMinggu1.CustomFormat = "dd/MM/yyyy"
        Me.dtPerMinggu1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPerMinggu1.Location = New System.Drawing.Point(104, 91)
        Me.dtPerMinggu1.Name = "dtPerMinggu1"
        Me.dtPerMinggu1.Size = New System.Drawing.Size(97, 20)
        Me.dtPerMinggu1.TabIndex = 10
        '
        'dtPerMinggu2
        '
        Me.dtPerMinggu2.CalendarMonthBackground = System.Drawing.Color.SlateGray
        Me.dtPerMinggu2.CustomFormat = "dd/MM/yyyy"
        Me.dtPerMinggu2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPerMinggu2.Location = New System.Drawing.Point(246, 91)
        Me.dtPerMinggu2.Name = "dtPerMinggu2"
        Me.dtPerMinggu2.Size = New System.Drawing.Size(97, 20)
        Me.dtPerMinggu2.TabIndex = 11
        '
        'dtPerTahun
        '
        Me.dtPerTahun.CalendarMonthBackground = System.Drawing.Color.SlateGray
        Me.dtPerTahun.CustomFormat = "yyyy"
        Me.dtPerTahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPerTahun.Location = New System.Drawing.Point(104, 144)
        Me.dtPerTahun.Name = "dtPerTahun"
        Me.dtPerTahun.ShowUpDown = True
        Me.dtPerTahun.Size = New System.Drawing.Size(97, 20)
        Me.dtPerTahun.TabIndex = 12
        '
        'dtTahun
        '
        Me.dtTahun.CalendarMonthBackground = System.Drawing.Color.SlateGray
        Me.dtTahun.CustomFormat = "yyyy"
        Me.dtTahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTahun.Location = New System.Drawing.Point(246, 118)
        Me.dtTahun.Name = "dtTahun"
        Me.dtTahun.ShowUpDown = True
        Me.dtTahun.Size = New System.Drawing.Size(97, 20)
        Me.dtTahun.TabIndex = 13
        '
        'cbPerBulan
        '
        Me.cbPerBulan.BackColor = System.Drawing.Color.SlateGray
        Me.cbPerBulan.FormattingEnabled = True
        Me.cbPerBulan.Items.AddRange(New Object() {"--Pilih Bulan--", "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cbPerBulan.Location = New System.Drawing.Point(104, 117)
        Me.cbPerBulan.Name = "cbPerBulan"
        Me.cbPerBulan.Size = New System.Drawing.Size(97, 21)
        Me.cbPerBulan.TabIndex = 14
        '
        'RbTanggal
        '
        Me.RbTanggal.AutoSize = True
        Me.RbTanggal.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTanggal.Location = New System.Drawing.Point(8, 68)
        Me.RbTanggal.Name = "RbTanggal"
        Me.RbTanggal.Size = New System.Drawing.Size(71, 19)
        Me.RbTanggal.TabIndex = 15
        Me.RbTanggal.TabStop = True
        Me.RbTanggal.Text = "Per &Tanggal"
        Me.RbTanggal.UseVisualStyleBackColor = True
        '
        'RbMinggu
        '
        Me.RbMinggu.AutoSize = True
        Me.RbMinggu.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbMinggu.Location = New System.Drawing.Point(8, 91)
        Me.RbMinggu.Name = "RbMinggu"
        Me.RbMinggu.Size = New System.Drawing.Size(70, 19)
        Me.RbMinggu.TabIndex = 16
        Me.RbMinggu.TabStop = True
        Me.RbMinggu.Text = "Per &Minggu"
        Me.RbMinggu.UseVisualStyleBackColor = True
        '
        'RbBulan
        '
        Me.RbBulan.AutoSize = True
        Me.RbBulan.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbBulan.Location = New System.Drawing.Point(8, 117)
        Me.RbBulan.Name = "RbBulan"
        Me.RbBulan.Size = New System.Drawing.Size(63, 19)
        Me.RbBulan.TabIndex = 17
        Me.RbBulan.TabStop = True
        Me.RbBulan.Text = "Per &Bulan"
        Me.RbBulan.UseVisualStyleBackColor = True
        '
        'RbTahun
        '
        Me.RbTahun.AutoSize = True
        Me.RbTahun.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTahun.Location = New System.Drawing.Point(8, 144)
        Me.RbTahun.Name = "RbTahun"
        Me.RbTahun.Size = New System.Drawing.Size(64, 19)
        Me.RbTahun.TabIndex = 18
        Me.RbTahun.TabStop = True
        Me.RbTahun.Text = "Per &Tahun"
        Me.RbTahun.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "s/d"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(207, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Tahun"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("News706 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(132, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 41)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "PRINT TBL &KEMBALI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.SlateGray
        Me.Label37.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label37.Location = New System.Drawing.Point(31, 3)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(288, 32)
        Me.Label37.TabIndex = 109
        Me.Label37.Text = "LAPORAN TRANSAKSI"
        '
        'RbPrintAll
        '
        Me.RbPrintAll.AutoSize = True
        Me.RbPrintAll.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPrintAll.Location = New System.Drawing.Point(246, 68)
        Me.RbPrintAll.Name = "RbPrintAll"
        Me.RbPrintAll.Size = New System.Drawing.Size(94, 19)
        Me.RbPrintAll.TabIndex = 110
        Me.RbPrintAll.TabStop = True
        Me.RbPrintAll.Text = "Print &All TblPinjam"
        Me.RbPrintAll.UseVisualStyleBackColor = True
        '
        'Rbtblkembali
        '
        Me.Rbtblkembali.AutoSize = True
        Me.Rbtblkembali.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtblkembali.Location = New System.Drawing.Point(246, 144)
        Me.Rbtblkembali.Name = "Rbtblkembali"
        Me.Rbtblkembali.Size = New System.Drawing.Size(100, 19)
        Me.Rbtblkembali.TabIndex = 111
        Me.Rbtblkembali.TabStop = True
        Me.Rbtblkembali.Text = "Print &All TblKembali"
        Me.Rbtblkembali.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SlateGray
        Me.Label3.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(65, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 32)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "PERPUSTAKAAN"
        '
        'LaporanTransaksiPerputakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(350, 225)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Rbtblkembali)
        Me.Controls.Add(Me.RbPrintAll)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RbTahun)
        Me.Controls.Add(Me.RbBulan)
        Me.Controls.Add(Me.RbMinggu)
        Me.Controls.Add(Me.RbTanggal)
        Me.Controls.Add(Me.cbPerBulan)
        Me.Controls.Add(Me.dtTahun)
        Me.Controls.Add(Me.dtPerTahun)
        Me.Controls.Add(Me.dtPerMinggu2)
        Me.Controls.Add(Me.dtPerMinggu1)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.dtPerTanggal)
        Me.Controls.Add(Me.CetakLaporan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LaporanTransaksiPerputakaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LaporanPeminjaman"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CetakLaporan As Button
    Friend WithEvents dtPerTanggal As DateTimePicker
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents dtPerMinggu1 As DateTimePicker
    Friend WithEvents dtPerMinggu2 As DateTimePicker
    Friend WithEvents dtPerTahun As DateTimePicker
    Friend WithEvents dtTahun As DateTimePicker
    Friend WithEvents cbPerBulan As ComboBox
    Friend WithEvents RbTanggal As RadioButton
    Friend WithEvents RbMinggu As RadioButton
    Friend WithEvents RbBulan As RadioButton
    Friend WithEvents RbTahun As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents RbPrintAll As RadioButton
    Friend WithEvents Rbtblkembali As RadioButton
    Friend WithEvents Label3 As Label
End Class
