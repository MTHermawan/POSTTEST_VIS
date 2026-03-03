Public Class Form1
    Dim jumlahIPS As Double = 0
    Dim penjumlahanIPS As Double = 0
    Dim nilaiIPK As Double = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim nilaiIPS As Double = 0
        If (Not Double.TryParse(txtInputIPS.Text, nilaiIPS)) Then
            MessageBox.Show("Input harus angka!")
            Return
        ElseIf (nilaiIPS < 0) Then
            MessageBox.Show("Input tidak boleh kurang dari 0!")
            Return
        ElseIf (nilaiIPS > 4) Then
            MessageBox.Show("Input tidak boleh lebih dari 4!")
            Return
        End If

        jumlahIPS += 1
        penjumlahanIPS += nilaiIPS
        nilaiIPK = penjumlahanIPS / jumlahIPS

        txtInputIPS.Text = ""
        txtInputIPK.Text = nilaiIPK
        txtKeterangan.Text = ""
        If (nilaiIPK >= 2 And nilaiIPK <= 2.75) Then
            txtKeterangan.Text = "Cukup"
        ElseIf (nilaiIPK >= 2.76 And nilaiIPK <= 3) Then
            txtKeterangan.Text = "Memuaskan"
        ElseIf (nilaiIPK > 3.01) Then
            txtKeterangan.Text = "Sangat Memuaskan"
        Else
            txtKeterangan.Text = "Well, well, well..."
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        jumlahIPS = 0
        penjumlahanIPS = 0
        nilaiIPK = 0

        txtInputIPS.Text = ""
        txtInputIPK.Text = ""
        txtKeterangan.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
