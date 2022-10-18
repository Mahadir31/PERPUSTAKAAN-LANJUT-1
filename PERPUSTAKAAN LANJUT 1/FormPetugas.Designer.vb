<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPetugas
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
        Me.kodepetugas = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.statuspetugas = New System.Windows.Forms.ComboBox()
        Me.Keluar = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.Input = New System.Windows.Forms.Button()
        Me.dgPetugas = New System.Windows.Forms.DataGridView()
        Me.passpetugas = New System.Windows.Forms.TextBox()
        Me.namapetugas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgPetugas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kodepetugas
        '
        Me.kodepetugas.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kodepetugas.Location = New System.Drawing.Point(161, 73)
        Me.kodepetugas.Name = "kodepetugas"
        Me.kodepetugas.Size = New System.Drawing.Size(83, 21)
        Me.kodepetugas.TabIndex = 149
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(140, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 18)
        Me.Label16.TabIndex = 148
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(140, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 18)
        Me.Label17.TabIndex = 147
        Me.Label17.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(140, 129)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 18)
        Me.Label18.TabIndex = 146
        Me.Label18.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(140, 158)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(15, 18)
        Me.Label19.TabIndex = 145
        Me.Label19.Text = ":"
        '
        'statuspetugas
        '
        Me.statuspetugas.FormattingEnabled = True
        Me.statuspetugas.Items.AddRange(New Object() {"ADMIN ", "KEPALA"})
        Me.statuspetugas.Location = New System.Drawing.Point(161, 157)
        Me.statuspetugas.Name = "statuspetugas"
        Me.statuspetugas.Size = New System.Drawing.Size(63, 21)
        Me.statuspetugas.TabIndex = 144
        '
        'Keluar
        '
        Me.Keluar.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keluar.Location = New System.Drawing.Point(369, 203)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(75, 23)
        Me.Keluar.TabIndex = 143
        Me.Keluar.Text = "KELUAR"
        Me.Keluar.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(242, 203)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 142
        Me.Delete.Text = "DELETE"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update.Location = New System.Drawing.Point(125, 203)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(75, 23)
        Me.Update.TabIndex = 141
        Me.Update.Text = "UPDATE"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Input
        '
        Me.Input.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input.Location = New System.Drawing.Point(12, 203)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(75, 23)
        Me.Input.TabIndex = 140
        Me.Input.Text = "INPUT"
        Me.Input.UseVisualStyleBackColor = True
        '
        'dgPetugas
        '
        Me.dgPetugas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPetugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPetugas.Location = New System.Drawing.Point(13, 232)
        Me.dgPetugas.Name = "dgPetugas"
        Me.dgPetugas.Size = New System.Drawing.Size(431, 127)
        Me.dgPetugas.TabIndex = 139
        '
        'passpetugas
        '
        Me.passpetugas.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passpetugas.Location = New System.Drawing.Point(161, 130)
        Me.passpetugas.Name = "passpetugas"
        Me.passpetugas.Size = New System.Drawing.Size(230, 21)
        Me.passpetugas.TabIndex = 138
        '
        'namapetugas
        '
        Me.namapetugas.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namapetugas.Location = New System.Drawing.Point(161, 100)
        Me.namapetugas.Name = "namapetugas"
        Me.namapetugas.Size = New System.Drawing.Size(189, 21)
        Me.namapetugas.TabIndex = 137
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "Status Petugas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Password Petugas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Nama Petugas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Kode Petugas"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(62, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 29)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Input Petugas Perpustakaan"
        '
        'FormPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(457, 370)
        Me.ControlBox = False
        Me.Controls.Add(Me.kodepetugas)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.statuspetugas)
        Me.Controls.Add(Me.Keluar)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Input)
        Me.Controls.Add(Me.dgPetugas)
        Me.Controls.Add(Me.passpetugas)
        Me.Controls.Add(Me.namapetugas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPetugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPetugas"
        CType(Me.dgPetugas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents kodepetugas As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents statuspetugas As ComboBox
    Friend WithEvents Keluar As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Update As Button
    Friend WithEvents Input As Button
    Friend WithEvents dgPetugas As DataGridView
    Friend WithEvents passpetugas As TextBox
    Friend WithEvents namapetugas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
