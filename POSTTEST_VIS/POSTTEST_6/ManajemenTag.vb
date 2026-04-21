Public Class ManajemenTag
    Private Sub ManajemenTag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshForm()
    End Sub

    Private Sub TampilDataTag()
        dgvManajemenTag.DataSource = GetAllTags()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If (SimpanTag(txtNamaTag.Text)) Then
            MessageBox.Show("Tag berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshForm()
        Else
            MessageBox.Show("Nama tag sudah ada!", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim konfirmasi As DialogResult = MessageBox.Show(
                                       "Apakah kamu yakin ingin menghapus tag '" & txtNamaTag.Text & "'?",
                                       "Konfirmasi Hapus",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Warning)
        If konfirmasi <> DialogResult.Yes Then Return

        If HapusTag(txtNamaTag.Text) Then
            MessageBox.Show("Tag berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshForm()
        Else
            MessageBox.Show("Tag gagal dihapus!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtNamaTag_TextChanged(sender As Object, e As EventArgs) Handles txtNamaTag.TextChanged
        RefreshForm()
    End Sub

    Private Sub RefreshForm()
        TampilDataTag()
        btnHapus.Enabled = TagSudahAda(txtNamaTag.Text)
    End Sub

    Private Sub dgvManajemenTag_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvManajemenTag.CellClick
        If e.RowIndex >= 0 Then
            txtNamaTag.Text = dgvManajemenTag.Rows(e.RowIndex).Cells("Nama Tag").Value.ToString()
        End If
    End Sub
End Class