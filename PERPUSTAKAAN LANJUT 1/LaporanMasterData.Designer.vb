<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanMasterData
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
        Me.Label37 = New System.Windows.Forms.Label()
        Me.BtPetugas = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtAnggota = New System.Windows.Forms.Button()
        Me.BtBuku = New System.Windows.Forms.Button()
        Me.BtAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.SlateGray
        Me.Label37.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(16, 9)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(319, 32)
        Me.Label37.TabIndex = 110
        Me.Label37.Text = "LAPORAN MASTER DATA"
        '
        'BtPetugas
        '
        Me.BtPetugas.Font = New System.Drawing.Font("News706 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtPetugas.Location = New System.Drawing.Point(22, 62)
        Me.BtPetugas.Name = "BtPetugas"
        Me.BtPetugas.Size = New System.Drawing.Size(86, 59)
        Me.BtPetugas.TabIndex = 116
        Me.BtPetugas.Text = "PRINT TBL &PETUGAS"
        Me.BtPetugas.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("News706 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Location = New System.Drawing.Point(22, 127)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(86, 59)
        Me.BtnKeluar.TabIndex = 115
        Me.BtnKeluar.Text = "&EXIT"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtAnggota
        '
        Me.BtAnggota.Font = New System.Drawing.Font("News706 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAnggota.Location = New System.Drawing.Point(132, 62)
        Me.BtAnggota.Name = "BtAnggota"
        Me.BtAnggota.Size = New System.Drawing.Size(86, 59)
        Me.BtAnggota.TabIndex = 114
        Me.BtAnggota.Text = "PRINT TBL &ANGGOTA"
        Me.BtAnggota.UseVisualStyleBackColor = True
        '
        'BtBuku
        '
        Me.BtBuku.Font = New System.Drawing.Font("News706 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtBuku.Location = New System.Drawing.Point(247, 62)
        Me.BtBuku.Name = "BtBuku"
        Me.BtBuku.Size = New System.Drawing.Size(86, 59)
        Me.BtBuku.TabIndex = 117
        Me.BtBuku.Text = "PRINT TBL &BUKU"
        Me.BtBuku.UseVisualStyleBackColor = True
        '
        'BtAll
        '
        Me.BtAll.Font = New System.Drawing.Font("News706 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAll.Location = New System.Drawing.Point(247, 127)
        Me.BtAll.Name = "BtAll"
        Me.BtAll.Size = New System.Drawing.Size(86, 59)
        Me.BtAll.TabIndex = 118
        Me.BtAll.Text = "PRINT &ALL"
        Me.BtAll.UseVisualStyleBackColor = True
        '
        'LaporanMasterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(350, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtAll)
        Me.Controls.Add(Me.BtBuku)
        Me.Controls.Add(Me.BtPetugas)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtAnggota)
        Me.Controls.Add(Me.Label37)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LaporanMasterData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LaporanMasterData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label37 As Label
    Friend WithEvents BtPetugas As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtAnggota As Button
    Friend WithEvents BtBuku As Button
    Friend WithEvents BtAll As Button
End Class
