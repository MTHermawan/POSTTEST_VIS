Public Class EditLevel
    Private _thumbnailPath As String = ""
    Private _idLevel As String = ""

    Public Sub LoadDataForEdit(row As DataRow)
        _idLevel = row("id_level").ToString()
        txtIdLevel.Text = _idLevel
        txtNamaLevel.Text = row("nama_level").ToString()
        txtPublisher.Text = row("publisher").ToString()
        txtVerifier.Text = row("verifier").ToString()
        txtRank.Text = row("rank").ToString()
        txtURLVerifikasi.Text = row("verification_url").ToString()

        _thumbnailPath = row("thumbnail_url").ToString()
        If _thumbnailPath <> "" AndAlso IO.File.Exists(_thumbnailPath) Then
            pbThumbnail.Image = Image.FromFile(_thumbnailPath)
            pbThumbnail.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub btnBrowseThumbnail_Click(sender As Object, e As EventArgs) Handles btnBrowseThumbnail.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        OpenFileDialog1.Title = "Pilih Gambar Thumbnail"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            _thumbnailPath = OpenFileDialog1.FileName
            pbThumbnail.Image = Image.FromFile(_thumbnailPath)
            pbThumbnail.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub txtRank_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRank.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaLevel.Text.Trim() = "" Then
            MessageBox.Show("Nama Level tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaLevel.Focus()
            Return
        End If
        If txtPublisher.Text.Trim() = "" Then
            MessageBox.Show("Publisher tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPublisher.Focus()
            Return
        End If
        If txtVerifier.Text.Trim() = "" Then
            MessageBox.Show("Verifier tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtVerifier.Focus()
            Return
        End If
        If txtRank.Text.Trim() = "" Then
            MessageBox.Show("Posisi Rank tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRank.Focus()
            Return
        End If

        Dim rank As Integer
        If Not Integer.TryParse(txtRank.Text.Trim(), rank) OrElse rank <= 0 Then
            MessageBox.Show("Posisi Rank harus berupa angka positif.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRank.Focus()
            Return
        End If

        Dim berhasil As Boolean = DataModule.UbahLevel(
            _idLevel,
            txtNamaLevel.Text.Trim(),
            txtPublisher.Text.Trim(),
            txtVerifier.Text.Trim(),
            rank,
            txtURLVerifikasi.Text.Trim(),
            _thumbnailPath
        )

        If berhasil Then
            MessageBox.Show("Level berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class