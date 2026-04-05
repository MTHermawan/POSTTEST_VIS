Imports System.IO

Public Class Form1

    Private ep As New ErrorProvider()
    Private fotoPath As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub InputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputToolStripMenuItem.Click
        ResetForm()
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        SimpanData()
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If DataModule.nama = "" Then
            MessageBox.Show("Belum ada data yang disimpan. Silakan isi dan simpan data terlebih dahulu.",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fh As New FormHasil()
        fh.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Yakin ingin keluar?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        ValidationModule.HanyaHuruf(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        ofd.Title = "Pilih Foto"
        If ofd.ShowDialog() = DialogResult.OK Then
            fotoPath = ofd.FileName
            PictureBox2.Image = Image.FromFile(fotoPath)
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If SimpanData() Then
            Dim fh As New FormHasil()
            fh.Show()
        End If
    End Sub

    Private Function SimpanData() As Boolean
        Dim valid As Boolean = ValidationModule.ValidasiSemuaInput(
            ep, txtNama, mtbTelepon, txtAlamat)

        If Not valid Then
            TabControl1.SelectedIndex = 0
            MessageBox.Show("Mohon lengkapi data yang wajib diisi.",
                            "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        DataModule.nama = txtNama.Text.Trim()
        DataModule.idAnggota = txtIdAnggota.Text.Trim()
        DataModule.tglLahir = dtpLahir.Value
        DataModule.jenisKelamin = DataModule.GetSelectedRadioButton(
            New RadioButton() {rbCowo, rbCewe})
        DataModule.komunitas = cbKomunitas.Text
        DataModule.telepon = mtbTelepon.Text
        DataModule.email = txtEmail.Text.Trim()
        DataModule.alamat = txtAlamat.Text.Trim()
        DataModule.hobi = DataModule.GetSelectedCheckBox(
    New CheckBox() {cbMembaca, cbPemrograman, cbBermainGame,
                    cbBerkebun, cbMenontonFilm, cbMemancing,
                    cbMenggambar, cbBermainMusik})

        DataModule.peran = DataModule.GetSelectedRadioButton(
            New RadioButton() {rbKetua, rbAnggota, rbAdmin})
        DataModule.foto = fotoPath

        Dim isi As String = DataModule.BuatIsiFile(
            DataModule.nama, DataModule.telepon, DataModule.alamat)

        Dim sfd As New SaveFileDialog()
        Dim berhasilSimpan As Boolean = DataModule.SimpanDataKeFile(
            sfd, isi, DataModule.nama & "_anggota")

        If berhasilSimpan Then
            MessageBox.Show("Data berhasil disimpan!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return True
    End Function

    Private Sub ResetForm()
        txtNama.Clear()
        txtIdAnggota.Clear()
        dtpLahir.Value = DateTime.Today
        rbCowo.Checked = False
        rbCewe.Checked = False
        cbKomunitas.SelectedIndex = 0
        mtbTelepon.Clear()
        txtEmail.Clear()
        txtAlamat.Clear()
        rbKetua.Checked = False
        rbAnggota.Checked = False
        rbAdmin.Checked = False

        For Each cb As CheckBox In GroupBox2.Controls.OfType(Of CheckBox)()
            cb.Checked = False
        Next

        fotoPath = ""
        PictureBox2.Image = Nothing
        PictureBox1.Image = Nothing

        ep.Clear()
        TabControl1.SelectedIndex = 0
    End Sub

    Public Sub BukaData()
        Dim ofd As New OpenFileDialog()
        Dim data As Dictionary(Of String, String) = DataModule.BukaDataDariFile(ofd)
        If data Is Nothing Then Return

        txtNama.Text = DataModule.AmbilNilai(data, "Nama")
        mtbTelepon.Text = DataModule.AmbilNilai(data, "Telepon")
        txtAlamat.Text = DataModule.AmbilNilai(data, "Alamat")
    End Sub

End Class