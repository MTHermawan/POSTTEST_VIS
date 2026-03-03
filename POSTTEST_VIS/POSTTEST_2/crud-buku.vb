Module crud_buku
    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer

    Public Sub TambahBuku(ByVal nama As String, ByVal genre As String)
        If (nama = Nothing Or nama.Trim() = "") Then
            MessageBox.Show("Masukkan nama buku!")
            Return
        ElseIf (genre = Nothing Or genre.Trim() = "") Then
            MessageBox.Show("Masukkan genre buku!")
            Return
        ElseIf (jumlahBuku > daftarBuku.Length) Then
            MessageBox.Show("Jumlah buku sudah penuh!")
            Return
        ElseIf GetIndexBuku(nama) >= 0 Then
            MessageBox.Show("Buku sudah ada!")
            Return
        End If

        daftarBuku(jumlahBuku, 0) = nama
        daftarBuku(jumlahBuku, 1) = genre
        jumlahBuku += 1
    End Sub

    Public Sub HapusBuku(ByVal nama As String)
        If (nama = Nothing Or nama.Trim() = "") Then
            MessageBox.Show("Masukkan nama buku!")
            Return
        End If

        Dim delIndex As Integer = GetIndexBuku(nama)

        If (delIndex < 0 And delIndex > jumlahBuku) Then
            MessageBox.Show("Buku tidak ditemukan!")
        End If

        For i As Integer = delIndex To jumlahBuku - 1
            daftarBuku(i, 0) = daftarBuku(i + 1, 0)
            daftarBuku(i, 1) = daftarBuku(i + 1, 1)
        Next

        daftarBuku(jumlahBuku, 0) = Nothing
        daftarBuku(jumlahBuku, 1) = Nothing
        jumlahBuku -= 1
    End Sub

    Public Function GetIndexBuku(ByVal nama As String) As Integer
        For i As Integer = 0 To jumlahBuku
            If (daftarBuku(i, 0) = nama) Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module
