Imports System.IO

Public Class FormHasil

    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiDataKartu()
    End Sub

    Private Sub IsiDataKartu()
        Label6.Text = DataModule.nama
        Label7.Text = DataModule.idAnggota
        Label8.Text = DataModule.tglLahir.ToString("dd MMMM yyyy")
        Label20.Text = DataModule.jenisKelamin
        Label22.Text = DataModule.komunitas

        Label15.Text = DataModule.telepon
        Label14.Text = DataModule.email
        Label13.Text = DataModule.alamat

        Label10.Text = DataModule.peran
        Label17.Text = DataModule.hobi

        ' ── Foto ───────────────────────────────────────────────────
        If DataModule.foto <> "" AndAlso File.Exists(DataModule.foto) Then
            PictureBox1.Image = Image.FromFile(DataModule.foto)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Else
            PictureBox1.Image = Nothing
        End If
    End Sub

End Class