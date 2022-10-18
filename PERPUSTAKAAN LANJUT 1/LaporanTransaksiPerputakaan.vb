Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class LaporanTransaksiPerputakaan
    Dim cmd As MySqlCommand
    Dim Da As New MySqlDataAdapter
    Dim strSQL As String
    Sub RbRefresh()
        RbTanggal.Checked = False
        RbMinggu.Checked = False
        RbBulan.Checked = False
        RbTahun.Checked = False
        RbPrintAll.Checked = False
        Rbtblkembali.Checked = False
        BtnKeluar.Text = "EXIT"
    End Sub
    Private Sub CetakLaporan_Click(sender As Object, e As EventArgs) Handles CetakLaporan.Click
        Call OpenConn()
        Rd.Read()
        If RbTanggal.Checked = True Then
            strSQL = "Select * From tblpinjam Where TglPinjam = '" & Format(dtPerTanggal.Value, "yyyy/MM/dd") & "'"
        ElseIf RbMinggu.Checked = True Then
            strSQL = "Select * From tblpinjam Where (TglPinjam Between '" & Format(dtPerMinggu1.Value, "yyyy/MM/dd") & "' AND '" & Format(dtPerMinggu2.Value, "yyyy/MM/dd") & "')"
        ElseIf RbBulan.Checked = True Then
            strSQL = "Select * From tblpinjam Where Month(TglPinjam) = '" & cbPerBulan.SelectedIndex & "' AND Year(TglPinjam) = '" & Format(dtTahun.Value, "yyyy") & "'"
        ElseIf RbTahun.Checked = True Then
            strSQL = "Select * From tblpinjam Where Year(TglPinjam) = '" & Format(dtPerTahun.Value, "yyyy") & "'"
        ElseIf RbPrintAll.Checked = True Then
            strSQL = "Select * From tblpinjam"
        End If

        Try
            FormLpTransaksiPerpustakaan.DataSet1.Clear()
            Call OpenConn()
            cmd = New MySqlCommand(strSQL, Conn)
            Da.SelectCommand = cmd
            Da.Fill(FormLpTransaksiPerpustakaan.DataSet1.tblpinjam)
            cmd.Dispose()
            Da.Dispose()
            Conn.Close()
        Catch ex As Exception
            Conn.Close()
            MessageBox.Show(ex.Message)
        End Try
        FormLpTransaksiPerpustakaan.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        FormLpTransaksiPerpustakaan.ReportViewer1.ZoomMode = ZoomMode.Percent
        FormLpTransaksiPerpustakaan.ReportViewer1.ZoomPercent = 100
        FormLpTransaksiPerpustakaan.ReportViewer1.RefreshReport()
        FormLpTransaksiPerpustakaan.ShowDialog()
    End Sub
    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        If BtnKeluar.Text = "EXIT" Then
            Me.Close()
        Else
            Call RbRefresh()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call OpenConn()
        Rd.Read()
        If RbTanggal.Checked = True Then
            strSQL = "Select * From tblkembali Where TglKembali = '" & Format(dtPerTanggal.Value, "yyyy/MM/dd") & "'"
        ElseIf RbMinggu.Checked = True Then
            strSQL = "Select * From tblkembali Where (TglKembali Between '" & Format(dtPerMinggu1.Value, "yyyy/MM/dd") & "' AND '" & Format(dtPerMinggu2.Value, "yyyy/MM/dd") & "')"
        ElseIf RbBulan.Checked = True Then
            strSQL = "Select * From tblkembali Where Month(TglKembali) = '" & cbPerBulan.SelectedIndex & "' AND Year(TglKembali) = '" & Format(dtTahun.Value, "yyyy") & "'"
        ElseIf RbTahun.Checked = True Then
            strSQL = "Select * From tblkembali Where Year(TglKembali) = '" & Format(dtPerTahun.Value, "yyyy") & "'"
        ElseIf Rbtblkembali.Checked = True Then
            strSQL = "Select * From tblkembali"
        End If
        Try
            FormLpTransaksiPerpustakaan.DataSet1.Clear()
            Call OpenConn()
            cmd = New MySqlCommand(strSQL, Conn)
            Da.SelectCommand = cmd
            Da.Fill(FormLpTransaksiPerpustakaan.DataSet1.tblkembali)
            cmd.Dispose()
            Da.Dispose()
            Conn.Close()
        Catch ex As Exception
            Conn.Close()
            MessageBox.Show(ex.Message)
        End Try
        FormLpTransaksiPerpustakaan.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        FormLpTransaksiPerpustakaan.ReportViewer1.ZoomMode = ZoomMode.Percent
        FormLpTransaksiPerpustakaan.ReportViewer1.ZoomPercent = 100
        FormLpTransaksiPerpustakaan.ReportViewer1.RefreshReport()
        FormLpTransaksiPerpustakaan.ShowDialog()
    End Sub
    Private Sub RbTanggal_CheckedChanged(sender As Object, e As EventArgs) Handles RbTanggal.CheckedChanged
        If RbTanggal.Checked = True Then
            BtnKeluar.Text = "&CANCEL"
        End If
    End Sub

    Private Sub RbMinggu_CheckedChanged(sender As Object, e As EventArgs) Handles RbMinggu.CheckedChanged
        If RbMinggu.Checked = True Then
            BtnKeluar.Text = "&CANCEL"
        End If
    End Sub

    Private Sub RbBulan_CheckedChanged(sender As Object, e As EventArgs) Handles RbBulan.CheckedChanged
        If RbBulan.Checked = True Then
            BtnKeluar.Text = "&CANCEL"
        End If
    End Sub

    Private Sub RbTahun_CheckedChanged(sender As Object, e As EventArgs) Handles RbTahun.CheckedChanged
        If RbTahun.Checked = True Then
            BtnKeluar.Text = "&CANCEL"
        End If
    End Sub

    Private Sub RbPrintAll_CheckedChanged(sender As Object, e As EventArgs) Handles RbPrintAll.CheckedChanged
        If RbPrintAll.Checked = True Then
            BtnKeluar.Text = "&CANCEL"
        End If
    End Sub

    Private Sub Rbtblpinjam_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtblkembali.CheckedChanged
        If Rbtblkembali.Checked = True Then
            BtnKeluar.Text = "&CANCEL"
        End If
    End Sub

    Private Sub LaporanTransaksiPerputakaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class