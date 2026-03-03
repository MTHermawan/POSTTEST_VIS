Public Class Form1
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahBuku(inputTambahJudul.Text, inputGenre.Text)
        TampilkanData()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        HapusBuku(inputHapusJudul.Text)
        TampilkanData()
    End Sub

    Private Sub TampilkanData()
        dgvBuku.Rows.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            dgvBuku.Rows.Add(daftarBuku(i, 0), daftarBuku(i, 1))
        Next
    End Sub
End Class
