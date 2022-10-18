<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLpMasterData
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TblpetugasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New PERPUSTAKAAN_LANJUT_1.DataSet1()
        Me.TblanggotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblbukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.TblpetugasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblanggotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblpetugasBindingSource
        '
        Me.TblpetugasBindingSource.DataMember = "tblpetugas"
        Me.TblpetugasBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblanggotaBindingSource
        '
        Me.TblanggotaBindingSource.DataMember = "tblanggota"
        Me.TblanggotaBindingSource.DataSource = Me.DataSet1
        '
        'TblbukuBindingSource
        '
        Me.TblbukuBindingSource.DataMember = "tblbuku"
        Me.TblbukuBindingSource.DataSource = Me.DataSet1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TblPetugas"
        ReportDataSource1.Value = Me.TblpetugasBindingSource
        ReportDataSource2.Name = "TblAnggota"
        ReportDataSource2.Value = Me.TblanggotaBindingSource
        ReportDataSource3.Name = "TblBuku"
        ReportDataSource3.Value = Me.TblbukuBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PERPUSTAKAAN_LANJUT_1.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(299, 301)
        Me.ReportViewer1.TabIndex = 0
        '
        'FormLpMasterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 301)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormLpMasterData"
        Me.Text = "FormLpMasterData"
        CType(Me.TblpetugasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblanggotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TblpetugasBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TblanggotaBindingSource As BindingSource
    Friend WithEvents TblbukuBindingSource As BindingSource
End Class
