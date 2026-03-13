Imports System.IO

Public Class FormCetak
    Dim grupHobi() As CheckBox
    Dim grupJenisKelamin() As RadioButton
    Private Function CekData() As Boolean
        grupHobi = {cbGaming, cbCoding, cbMemancing, cbMembaca, cbMenari, cbMenggambar, cbMenulis, cbMenyanyi, cbTraveling, cbOlahraga}
        grupJenisKelamin = {rbLaki, rbPerempuan}
        If Not ValidasiTextBox(txtNama, "Nama Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtUmur, "Umur Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtAlamat, "Alamat Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtTelp, "Nomor Telepon Tidak Boleh Kosong") Then Return False
        If Not ValidasiRadioButton(grupJenisKelamin, "Pilih Jenis Kelamin Anda") Then Return False
        If Not ValidasiCheckBox(grupHobi, "Pilih Minimal 1 Hobi") Then Return False
        If Not ValidasiPictureBox(picPasFoto, "Gambar Tidak Boleh Kosong") Then Return False
        Return True
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If CekData() Then
            grupHobi = {cbGaming, cbCoding, cbMemancing, cbMembaca, cbMenari, cbMenggambar, cbMenulis, cbMenyanyi, cbTraveling, cbOlahraga}
            grupJenisKelamin = {rbLaki, rbPerempuan}
            Dim hobi_Selected As String = GetSelectedCheckBox(grupHobi)
            Dim jenisKelamin_Selected As String = GetSelectedRadioButton(grupJenisKelamin)
            DataModule.nama = txtNama.Text
            DataModule.umur = txtUmur.Text
            DataModule.noTelp = txtTelp.Text
            DataModule.jenisKelamin = jenisKelamin_Selected
            DataModule.tglLahir = dtpLahir.Value.ToShortDateString()
            DataModule.hobi = hobi_Selected
            DataModule.alamat = txtAlamat.Text
            FormHasil.Show()
        End If
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        If ValidasiTextBox(txtNama, "Nama Tidak Boleh Kosong") Then
            Dim NamaFile As String = txtNama.Text.Trim()
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, fileName)
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If
                File.Copy(openFileDialog.FileName, destinationPath, True)
                DataModule.foto = destinationPath
                picPasFoto.Image = Image.FromFile(destinationPath)
                MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        ValidationModule.HanyaHuruf(sender, e)
    End Sub
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        ValidationModule.HanyaAngka(sender, e)
    End Sub
    Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress
        ValidationModule.HanyaAngka(sender, e)
    End Sub
End Class