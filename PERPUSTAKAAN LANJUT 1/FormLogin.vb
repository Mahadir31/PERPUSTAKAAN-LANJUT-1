Imports MySql.Data.MySqlClient
Public Class FormLogin
    Sub Terbuka()
        Menu_Utama.Login.Enabled = False
        Menu_Utama.LogOut.Enabled = True
        Menu_Utama.MASTER.Enabled = True
        Menu_Utama.TRANSAKSI.Enabled = True
        Menu_Utama.LAPORAN.Enabled = True
    End Sub
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kodepetugas.Clear()
        Password.Clear()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If kodepetugas.Text = "" Or Password.Text = "" Then
            MsgBox("Kode Petugas Atau Password Tidak Boleh Kosong !!!")
            kodepetugas.Focus()
        Else
            Call OpenConn()
            Cmd = New MySqlCommand("select * from tblpetugas where KodePetugas = '" & kodepetugas.Text & "' and PasswordPetugas ='" & Password.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Close()
                Call Terbuka()
                Menu_Utama.KodePetugas.Text = Rd!KodePetugas
                Menu_Utama.NamaPetugas.Text = Rd!NamaPetugas
                Menu_Utama.StatusPetugas.Text = Rd!StatusPetugas
                If Menu_Utama.StatusPetugas.Text = "KEPALA" Then
                    Menu_Utama.Petugas.Visible = True
                Else
                    Menu_Utama.Petugas.Visible = False
                End If

            Else
                MsgBox("Kode Petugas Atau password SALAH !!!")
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Password.PasswordChar = ""
        Else
            Password.PasswordChar = "x"
        End If
    End Sub
    Private Sub kodepetugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodepetugas.KeyPress
        If e.KeyChar = Chr(13) Then
            Password.Focus()
        End If
    End Sub
    Private Sub Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Password.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin.Focus()
        End If
    End Sub

    Private Sub FormLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        kodepetugas.Focus()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
    End Sub
End Class