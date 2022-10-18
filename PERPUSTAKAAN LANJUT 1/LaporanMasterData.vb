Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class LaporanMasterData
    Dim cmd As MySqlCommand
    Dim Da As New MySqlDataAdapter
    Dim strSQL As String

    Private Sub BtPetugas_Click(sender As Object, e As EventArgs) Handles BtPetugas.Click
        Call OpenConn()
        Rd.Read()
        strSQL = "Select * From tblpetugas"
        Try
            FormLpMasterData.DataSet1.Clear()
            Call OpenConn()
            cmd = New MySqlCommand(strSQL, Conn)
            Da.SelectCommand = cmd
            Da.Fill(FormLpMasterData.DataSet1.tblpetugas)
            cmd.Dispose()
            Da.Dispose()
            Conn.Close()
        Catch ex As Exception
            Conn.Close()
            MessageBox.Show(ex.Message)
        End Try
        FormLpMasterData.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        FormLpMasterData.ReportViewer1.ZoomMode = ZoomMode.Percent
        FormLpMasterData.ReportViewer1.ZoomPercent = 100
        FormLpMasterData.ReportViewer1.RefreshReport()
        FormLpMasterData.ShowDialog()
    End Sub

    Private Sub BtAnggota_Click(sender As Object, e As EventArgs) Handles BtAnggota.Click
        Call OpenConn()
        Rd.Read()
        strSQL = "Select * From tblanggota"
        Try
            FormLpMasterData.DataSet1.Clear()
            Call OpenConn()
            cmd = New MySqlCommand(strSQL, Conn)
            Da.SelectCommand = cmd
            Da.Fill(FormLpMasterData.DataSet1.tblanggota)
            cmd.Dispose()
            Da.Dispose()
            Conn.Close()
        Catch ex As Exception
            Conn.Close()
            MessageBox.Show(ex.Message)
        End Try
        FormLpMasterData.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        FormLpMasterData.ReportViewer1.ZoomMode = ZoomMode.Percent
        FormLpMasterData.ReportViewer1.ZoomPercent = 100
        FormLpMasterData.ReportViewer1.RefreshReport()
        FormLpMasterData.ShowDialog()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub BtBuku_Click(sender As Object, e As EventArgs) Handles BtBuku.Click
        Call OpenConn()
        Rd.Read()
        strSQL = "Select * From tblbuku"

        Try
            FormLpMasterData.DataSet1.Clear()
            Call OpenConn()
            cmd = New MySqlCommand(strSQL, Conn)
            Da.SelectCommand = cmd
            Da.Fill(FormLpMasterData.DataSet1.tblbuku)
            cmd.Dispose()
            Da.Dispose()
            Conn.Close()
        Catch ex As Exception
            Conn.Close()
            MessageBox.Show(ex.Message)
        End Try
        FormLpMasterData.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        FormLpMasterData.ReportViewer1.ZoomMode = ZoomMode.Percent
        FormLpMasterData.ReportViewer1.ZoomPercent = 100
        FormLpMasterData.ReportViewer1.RefreshReport()
        FormLpMasterData.ShowDialog()
    End Sub

    Private Sub BtAll_Click(sender As Object, e As EventArgs) Handles BtAll.Click
        Call OpenConn()
        Rd.Read()
        FormAllReport.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        FormAllReport.ReportViewer1.ZoomMode = ZoomMode.Percent
        FormAllReport.ReportViewer1.ZoomPercent = 100
        FormAllReport.ShowDialog()
        FormAllReport.Dispose()
    End Sub
End Class