Imports System.IO
Imports System.Text

Module DataModule
    Public nama, idAnggota, jenisKelamin, komunitas, telepon, email, alamat, peran, hobi, foto As String
    Public tglLahir As Date

    Public Function GetSelectedRadioButton(grupRadio() As RadioButton) As String
        For Each rb As RadioButton In grupRadio
            If rb.Checked Then
                Return rb.Text
            End If
        Next
        Return ""
    End Function
    Public Function GetSelectedCheckBox(grupCheck() As CheckBox) As String
        Dim selectedItems As New List(Of String)
        For Each cb As CheckBox In grupCheck
            If cb.Checked Then
                selectedItems.Add(cb.Text)
            End If
        Next
        Return String.Join(", ", selectedItems)
    End Function

    Public Function BuatIsiFile(
        nama As String,
        telepon As String,
        alamat As String
    ) As String

        Dim sb As New StringBuilder()

        sb.AppendLine("Nama=" & nama.Trim())
        sb.AppendLine("Telepon=" & telepon)
        sb.Append("Alamat=" & alamat.Trim())

        Return sb.ToString()
    End Function

    Public Function SimpanDataKeFile(
        sfd As SaveFileDialog,
        isi As String,
        namaFileDefault As String
    ) As Boolean

        sfd.Filter = "Text File|*.txt|CSV File|*.csv"
        sfd.Title = "Simpan Data"
        sfd.FileName = namaFileDefault

        If sfd.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(sfd.FileName, isi)
            Return True
        End If

        Return False
    End Function

    Public Function BukaDataDariFile(ofd As OpenFileDialog) As Dictionary(Of String, String)
        ofd.Filter = "Text File|*.txt|CSV File|*.csv"
        ofd.Title = "Buka Data"

        If ofd.ShowDialog() <> DialogResult.OK Then
            Return Nothing
        End If

        Dim hasil As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        Dim barisFile() As String = File.ReadAllLines(ofd.FileName)

        For Each baris As String In barisFile
            If String.IsNullOrWhiteSpace(baris) Then Continue For

            Dim bagian() As String = baris.Split(New Char() {"="c}, 2)

            If bagian.Length = 2 Then
                hasil(bagian(0).Trim()) = bagian(1).Trim()
            End If
        Next

        Return hasil
    End Function

    Public Function AmbilNilai(data As Dictionary(Of String, String), key As String) As String
        If data IsNot Nothing AndAlso data.ContainsKey(key) Then
            Return data(key)
        End If

        Return ""
    End Function

End Module