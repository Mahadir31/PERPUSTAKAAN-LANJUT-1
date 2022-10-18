<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnggota
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.kodeanggota = New System.Windows.Forms.TextBox()
        Me.jeniskelamin = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.telponanggota = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.alamatanggota = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.namaanggota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Keluar = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.Input = New System.Windows.Forms.Button()
        Me.dgAnggota = New System.Windows.Forms.DataGridView()
        CType(Me.dgAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(273, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 18)
        Me.Label8.TabIndex = 180
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(192, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 17)
        Me.Label9.TabIndex = 179
        Me.Label9.Text = "Cari Nama"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(294, 198)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(150, 20)
        Me.txtcari.TabIndex = 178
        '
        'kodeanggota
        '
        Me.kodeanggota.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kodeanggota.Location = New System.Drawing.Point(161, 59)
        Me.kodeanggota.Name = "kodeanggota"
        Me.kodeanggota.Size = New System.Drawing.Size(89, 21)
        Me.kodeanggota.TabIndex = 177
        '
        'jeniskelamin
        '
        Me.jeniskelamin.FormattingEnabled = True
        Me.jeniskelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.jeniskelamin.Location = New System.Drawing.Point(161, 116)
        Me.jeniskelamin.Name = "jeniskelamin"
        Me.jeniskelamin.Size = New System.Drawing.Size(89, 21)
        Me.jeniskelamin.TabIndex = 176
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(140, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 18)
        Me.Label6.TabIndex = 175
        Me.Label6.Text = ":"
        '
        'telponanggota
        '
        Me.telponanggota.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telponanggota.Location = New System.Drawing.Point(161, 173)
        Me.telponanggota.Name = "telponanggota"
        Me.telponanggota.Size = New System.Drawing.Size(163, 21)
        Me.telponanggota.TabIndex = 174
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 17)
        Me.Label7.TabIndex = 173
        Me.Label7.Text = "Telpon Anggota"
        '
        'alamatanggota
        '
        Me.alamatanggota.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alamatanggota.Location = New System.Drawing.Point(161, 146)
        Me.alamatanggota.Name = "alamatanggota"
        Me.alamatanggota.Size = New System.Drawing.Size(189, 21)
        Me.alamatanggota.TabIndex = 172
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(140, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 18)
        Me.Label16.TabIndex = 171
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(140, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 18)
        Me.Label17.TabIndex = 170
        Me.Label17.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(140, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 18)
        Me.Label18.TabIndex = 169
        Me.Label18.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(140, 146)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(15, 18)
        Me.Label19.TabIndex = 168
        Me.Label19.Text = ":"
        '
        'namaanggota
        '
        Me.namaanggota.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaanggota.Location = New System.Drawing.Point(161, 88)
        Me.namaanggota.Name = "namaanggota"
        Me.namaanggota.Size = New System.Drawing.Size(176, 21)
        Me.namaanggota.TabIndex = 167
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "Alamat Anggota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Jenis kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "Nama Anggota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 163
        Me.Label2.Text = "Kode Anggota"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(62, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 29)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "Input Anggota Perpustakaan"
        '
        'Keluar
        '
        Me.Keluar.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keluar.Location = New System.Drawing.Point(369, 224)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(75, 23)
        Me.Keluar.TabIndex = 161
        Me.Keluar.Text = "KELUAR"
        Me.Keluar.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(242, 224)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 160
        Me.Delete.Text = "DELETE"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update.Location = New System.Drawing.Point(125, 224)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(75, 23)
        Me.Update.TabIndex = 159
        Me.Update.Text = "UPDATE"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Input
        '
        Me.Input.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input.Location = New System.Drawing.Point(12, 224)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(75, 23)
        Me.Input.TabIndex = 158
        Me.Input.Text = "INPUT"
        Me.Input.UseVisualStyleBackColor = True
        '
        'dgAnggota
        '
        Me.dgAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAnggota.Location = New System.Drawing.Point(13, 253)
        Me.dgAnggota.Name = "dgAnggota"
        Me.dgAnggota.Size = New System.Drawing.Size(431, 127)
        Me.dgAnggota.TabIndex = 157
        '
        'FormAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(457, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.kodeanggota)
        Me.Controls.Add(Me.jeniskelamin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.telponanggota)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.alamatanggota)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.namaanggota)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Keluar)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Input)
        Me.Controls.Add(Me.dgAnggota)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAnggota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAnggota"
        CType(Me.dgAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcari As TextBox
    Friend WithEvents kodeanggota As TextBox
    Friend WithEvents jeniskelamin As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents telponanggota As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents alamatanggota As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents namaanggota As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Keluar As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Update As Button
    Friend WithEvents Input As Button
    Friend WithEvents dgAnggota As DataGridView
End Class
