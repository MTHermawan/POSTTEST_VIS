Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    'Public Function ValidasiComboBox(ep As ErrorProvider, cbo As ComboBox, pesan As String) As Boolean
    '    If cbo.SelectedIndex = -1 OrElse cbo.Text.Trim() = "" Then
    '        ep.SetError(cbo, pesan)
    '        Return False
    '    Else
    '        ep.SetError(cbo, "")
    '        Return True
    '    End If
    'End Function

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function

    Public Function ValidasiSemuaInput(
        ep As ErrorProvider,
        txtNama As TextBox,
        mtbNoHP As MaskedTextBox,
        txtAlamat As TextBox
    ) As Boolean

        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama tidak boleh kosong")
        'Dim nimValid As Boolean = ValidasiTextBox(ep, txtNIM, "NIM tidak boleh kosong")
        'Dim jkValid As Boolean = ValidasiComboBox(ep, cboJenisKelamin, "Jenis kelamin harus dipilih")
        'Dim prodiValid As Boolean = ValidasiComboBox(ep, cboProdi, "Prodi harus dipilih")
        Dim noHpValid As Boolean = ValidasiMaskedTextBox(ep, mtbNoHP, "Nomor HP belum lengkap")
        Dim alamatValid As Boolean = ValidasiTextBox(ep, txtAlamat, "Alamat tidak boleh kosong")

        Return namaValid And noHpValid And alamatValid
    End Function

End Module