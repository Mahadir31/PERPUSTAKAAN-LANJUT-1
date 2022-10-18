<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLpTransaksiPerpustakaan
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TblpinjamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New PERPUSTAKAAN_LANJUT_1.DataSet1()
        Me.TblkembaliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.TblpinjamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblkembaliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblpinjamBindingSource
        '
        Me.TblpinjamBindingSource.DataMember = "tblpinjam"
        Me.TblpinjamBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblkembaliBindingSource
        '
        Me.TblkembaliBindingSource.DataMember = "tblkembali"
        Me.TblkembaliBindingSource.DataSource = Me.DataSet1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "tblpinjam"
        ReportDataSource1.Value = Me.TblpinjamBindingSource
        ReportDataSource2.Name = "tblkembali"
        ReportDataSource2.Value = Me.TblkembaliBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PERPUSTAKAAN_LANJUT_1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(300, 300)
        Me.ReportViewer1.TabIndex = 0
        '
        'FormLpTransaksiPerpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormLpTransaksiPerpustakaan"
        Me.ShowIcon = False
        Me.Text = "FormLpTransaksiPerpustakan"
        CType(Me.TblpinjamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblkembaliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TblpinjamBindingSource As BindingSource
    Friend WithEvents TblkembaliBindingSource As BindingSource
End Class
