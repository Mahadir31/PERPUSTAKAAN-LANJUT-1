<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuku
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tahunbuku = New System.Windows.Forms.ComboBox()
        Me.pengarangbuku = New System.Windows.Forms.TextBox()
        Me.stokbuku = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.penerbit = New System.Windows.Forms.TextBox()
        Me.kodebuku = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.judulbuku = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Keluar = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.Input = New System.Windows.Forms.Button()
        Me.dgBuku = New System.Windows.Forms.DataGridView()
        CType(Me.dgBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(224, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 18)
        Me.Label10.TabIndex = 210
        Me.Label10.Text = ":"
        '
        'txtcari
        '
        Me.txtcari.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.Location = New System.Drawing.Point(245, 242)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(202, 21)
        Me.txtcari.TabIndex = 209
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(145, 244)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 17)
        Me.Label11.TabIndex = 208
        Me.Label11.Text = "Cari Buku"
        '
        'tahunbuku
        '
        Me.tahunbuku.FormattingEnabled = True
        Me.tahunbuku.Location = New System.Drawing.Point(152, 171)
        Me.tahunbuku.Name = "tahunbuku"
        Me.tahunbuku.Size = New System.Drawing.Size(102, 21)
        Me.tahunbuku.TabIndex = 207
        '
        'pengarangbuku
        '
        Me.pengarangbuku.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pengarangbuku.Location = New System.Drawing.Point(152, 116)
        Me.pengarangbuku.Name = "pengarangbuku"
        Me.pengarangbuku.Size = New System.Drawing.Size(236, 21)
        Me.pengarangbuku.TabIndex = 206
        '
        'stokbuku
        '
        Me.stokbuku.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stokbuku.Location = New System.Drawing.Point(152, 198)
        Me.stokbuku.Name = "stokbuku"
        Me.stokbuku.Size = New System.Drawing.Size(102, 21)
        Me.stokbuku.TabIndex = 205
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(131, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 18)
        Me.Label9.TabIndex = 204
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 203
        Me.Label8.Text = "Stok Buku"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(131, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 18)
        Me.Label6.TabIndex = 202
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 17)
        Me.Label7.TabIndex = 201
        Me.Label7.Text = "Tahun Buku"
        '
        'penerbit
        '
        Me.penerbit.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.penerbit.Location = New System.Drawing.Point(152, 144)
        Me.penerbit.Name = "penerbit"
        Me.penerbit.Size = New System.Drawing.Size(236, 21)
        Me.penerbit.TabIndex = 200
        '
        'kodebuku
        '
        Me.kodebuku.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kodebuku.Location = New System.Drawing.Point(152, 62)
        Me.kodebuku.Name = "kodebuku"
        Me.kodebuku.Size = New System.Drawing.Size(102, 21)
        Me.kodebuku.TabIndex = 199
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(131, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 18)
        Me.Label16.TabIndex = 198
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(131, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 18)
        Me.Label17.TabIndex = 197
        Me.Label17.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(131, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 18)
        Me.Label18.TabIndex = 196
        Me.Label18.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(131, 145)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(15, 18)
        Me.Label19.TabIndex = 195
        Me.Label19.Text = ":"
        '
        'judulbuku
        '
        Me.judulbuku.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judulbuku.Location = New System.Drawing.Point(152, 89)
        Me.judulbuku.Name = "judulbuku"
        Me.judulbuku.Size = New System.Drawing.Size(236, 21)
        Me.judulbuku.TabIndex = 194
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "Penerbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 17)
        Me.Label4.TabIndex = 192
        Me.Label4.Text = "Pengarang Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Judul Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "Kode Buku"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(79, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 29)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "Input Buku Perpustakaan"
        '
        'Keluar
        '
        Me.Keluar.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keluar.Location = New System.Drawing.Point(372, 269)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(75, 23)
        Me.Keluar.TabIndex = 188
        Me.Keluar.Text = "KELUAR"
        Me.Keluar.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(245, 269)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 187
        Me.Delete.Text = "DELETE"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update.Location = New System.Drawing.Point(128, 269)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(75, 23)
        Me.Update.TabIndex = 186
        Me.Update.Text = "UPDATE"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Input
        '
        Me.Input.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input.Location = New System.Drawing.Point(15, 269)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(75, 23)
        Me.Input.TabIndex = 185
        Me.Input.Text = "INPUT"
        Me.Input.UseVisualStyleBackColor = True
        '
        'dgBuku
        '
        Me.dgBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBuku.Location = New System.Drawing.Point(16, 298)
        Me.dgBuku.Name = "dgBuku"
        Me.dgBuku.Size = New System.Drawing.Size(431, 127)
        Me.dgBuku.TabIndex = 184
        '
        'FormBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(460, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tahunbuku)
        Me.Controls.Add(Me.pengarangbuku)
        Me.Controls.Add(Me.stokbuku)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.penerbit)
        Me.Controls.Add(Me.kodebuku)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.judulbuku)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Keluar)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Input)
        Me.Controls.Add(Me.dgBuku)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.dgBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents txtcari As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tahunbuku As ComboBox
    Friend WithEvents pengarangbuku As TextBox
    Friend WithEvents stokbuku As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents penerbit As TextBox
    Friend WithEvents kodebuku As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents judulbuku As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Keluar As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Update As Button
    Friend WithEvents Input As Button
    Friend WithEvents dgBuku As DataGridView
End Class
