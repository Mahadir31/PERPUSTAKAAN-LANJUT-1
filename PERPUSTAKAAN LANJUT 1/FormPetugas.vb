Imports MySql.Data.MySqlClient
Public Class FormPetugas
    Sub Isi()
        kodepetugas.Enabled = True
        namapetugas.Enabled = True
        passpetugas.Enabled = True
        statuspetugas.Enabled = True
    End Sub
    Sub tampilkan()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from tblpetugas", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblpetugas")
        dgPetugas.DataSource = Ds.Tables("tblpetugas")
        dgPetugas.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver

        kodepetugas.Text = ""
        namapetugas.Text = ""
        passpetugas.Text = ""
        statuspetugas.Text = ""

        kodepetugas.Enabled = False
        namapetugas.Enabled = False
        passpetugas.Enabled = False
        statuspetugas.Enabled = False

        Input.Enabled = True
        Input.Text = "INPUT"
        Update.Enabled = True
        Update.Text = "UPDATE"
        Delete.Enabled = True
        Delete.Text = "DELETE"
        Keluar.Text = "KELUAR"
    End Sub
    Private Sub FormPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilkan()
    End Sub

    Private Sub Input_Click(sender As Object, e As EventArgs) Handles Input.Click
        If Input.Text = "INPUT" Then
            Input.Text = "SIMPAN"
            Update.Enabled = False
            Delete.Enabled = False
            Keluar.Text = "&CANCEL"
            Call Isi()
            kodepetugas.Focus()
        Else
            If kodepetugas.Text = "" Or namapetugas.Text = "" Or passpetugas.Text = "" Or statuspetugas.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                kodepetugas.Focus()
            Else
                Dim petugas = New Petugas With {
                    .KodePetugas = kodepetugas.Text,
                    .NamaPetugas = namapetugas.Text,
                    .PasswordPetugas = passpetugas.Text,
                    .StatusPetugas = statuspetugas.Text
                }
                Dim save = petugas.Save()
                If (save) Then
                    MsgBox("Data Berhasil dI Simpan !!!")
                    Call tampilkan()
                Else
                    MsgBox("Data Gagal di Simpan......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")

                End If

            End If
        End If
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        If Update.Text = "UPDATE" Then
            Update.Text = "UBAH"
            Input.Enabled = False
            Delete.Enabled = False
            Keluar.Text = "&CANCEL"
            Call Isi()
            kodepetugas.Focus()
        Else
            If kodepetugas.Text = "" Or namapetugas.Text = "" Or passpetugas.Text = "" Or statuspetugas.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                kodepetugas.Focus()
            Else
                Dim petugas = New Petugas With {
                    .KodePetugas = kodepetugas.Text,
                    .NamaPetugas = namapetugas.Text,
                    .PasswordPetugas = passpetugas.Text,
                    .StatusPetugas = statuspetugas.Text
                }
                Dim update = petugas.Update()
                If (update) Then
                    MsgBox("Data Berhasil di Ubah", MsgBoxStyle.MsgBoxRight, "Message")
                    Call tampilkan()
                Else
                    MsgBox("Data Gagal di Ubah......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")

                End If

            End If
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If Delete.Text = "DELETE" Then
            Delete.Text = "HAPUS"
            Input.Enabled = False
            Update.Enabled = False
            Keluar.Text = "&CANCEL"
            Call Isi()
            kodepetugas.Focus()
        Else
            If kodepetugas.Text = "" Or namapetugas.Text = "" Or passpetugas.Text = "" Or statuspetugas.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                kodepetugas.Focus()
            Else
                Dim petugas = New Petugas With {
                    .KodePetugas = kodepetugas.Text
                }
                Dim delete = petugas.Delete()
                If (delete) Then
                    MsgBox("Data Berhasil di Hapus", MsgBoxStyle.MsgBoxRight, "Message")
                    Call tampilkan()
                Else
                    MsgBox("Data Gagal di Hapus......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")

                End If

            End If
        End If
    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        If Keluar.Text = "KELUAR" Then
            Me.Close()
        Else
            Call tampilkan()
        End If
    End Sub
    Private Sub kodepetugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodepetugas.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim hasil = Petugas.Carikode(kodepetugas.Text)
            If IsNothing(hasil) Then
                MsgBox("Data tidak ada")
            Else
                namapetugas.Text = hasil.NamaPetugas
                passpetugas.Text = hasil.PasswordPetugas
                statuspetugas.Text = hasil.StatusPetugas
            End If
        End If
    End Sub

    Private Sub kodepetugas_KeyDown(sender As Object, e As KeyEventArgs) Handles kodepetugas.KeyDown
        If e.KeyCode = Keys.Enter Then
            namapetugas.Focus()
        End If
    End Sub
    Private Sub namapetugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namapetugas.KeyPress
        If e.KeyChar = Chr(13) Then
            passpetugas.Focus()
        End If
    End Sub
    Private Sub passpetugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles passpetugas.KeyPress
        If e.KeyChar = Chr(13) Then
            statuspetugas.Focus()
        End If
    End Sub
    Private Sub statuspetugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles statuspetugas.KeyPress
        If e.KeyChar = Chr(13) Then
            Input.Focus()
            Update.Focus()
            Delete.Focus()
        End If
    End Sub
End Class