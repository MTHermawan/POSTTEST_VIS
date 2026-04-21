Imports Guna.UI2.WinForms

Public Class Form1
    Private _dtLevels As New DataTable
    Private _levelCards As New List(Of LevelCard)
    Private _curPage As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadCards()
        ReloadData()
    End Sub

    Public Sub ReloadData()
        If String.IsNullOrWhiteSpace(txtSearchLevel.Text) Then
            _dtLevels = GetAllLevels()
        Else
            _dtLevels = SearchLevel(txtSearchLevel.Text)
        End If

        Dim _itemPerPage = _levelCards.Count
        For i = 0 To _itemPerPage - 1
            Dim _pageIndex = (_itemPerPage * _curPage) + i

            If (_pageIndex < _dtLevels.Rows.Count) Then
                Dim _row As DataRow = _dtLevels.Rows(_pageIndex)

                _levelCards(i).SetActive(True)
                _levelCards(i).idLevel = _row("id_level").ToString()
                _levelCards(i).SetRank(_row("rank").ToString())
                _levelCards(i).SetLevel(_row("nama_level").ToString())
                _levelCards(i).SetPublisher(_row("publisher").ToString() & " | " & _row("verifier").ToString())
            Else
                _levelCards(i).SetActive(False)
            End If
        Next i

        btnPrevPage.Enabled = _curPage > 0
        btnNextPage.Enabled = _levelCards.Count * (_curPage + 1) < _dtLevels.Rows.Count

        lblCurrentPage.Text = "Halaman " & _curPage + 1
    End Sub

    Private Sub ReloadCards()
        _levelCards.Clear()
        Dim i As Integer = 1
        While True
            Dim foundControls As Control() = Me.Controls.Find("pnlLevelCard" & i, True)
            If foundControls.Length > 0 Then
                Dim newCard As New LevelCard(
                    TryCast(foundControls(0), Guna2Panel),
                    GetLabel("lblRank" & i),
                    GetLabel("lblLevel" & i),
                    GetLabel("lblPublisher" & i),
                    GetGuna2Button("btnEditLevel" & i),
                    GetGuna2Button("btnHapusLevel" & i)
                )

                _levelCards.Add(newCard)
                i += 1
            Else
                Exit While
            End If
        End While
    End Sub

    Private Function GetLabel(labelName As String) As Label
        Return DirectCast(Me.Controls.Find(labelName, True)(0), Label)
    End Function

    Private Function GetGuna2Button(labelName As String) As Guna2Button
        Return DirectCast(Me.Controls.Find(labelName, True)(0), Guna2Button)
    End Function

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        _curPage += 1
        ReloadData()
    End Sub

    Private Sub btnPrevPage_Click(sender As Object, e As EventArgs) Handles btnPrevPage.Click
        If _curPage <= 0 Then Return

        _curPage -= 1
        ReloadData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim formTambah As New TambahLevel
        formTambah.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ReloadData()
    End Sub

    Private Sub txtSearchLevel_TextChanged(sender As Object, e As EventArgs) Handles txtSearchLevel.TextChanged
        ReloadData()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ManajemenTag.Show()
    End Sub

    Private Sub btnEditLevel1_Click(sender As Object, e As EventArgs) Handles btnEditLevel1.Click
        Dim formEdit As New EditLevel
        formEdit.LoadDataForEdit(GetLevelById(_levelCards(0).idLevel).Rows(0))
        formEdit.ShowDialog()
    End Sub

    Private Sub btnEditLevel2_Click(sender As Object, e As EventArgs) Handles btnEditLevel2.Click
        Dim formEdit As New EditLevel
        formEdit.LoadDataForEdit(GetLevelById(_levelCards(1).idLevel).Rows(0))
        formEdit.ShowDialog()
    End Sub

    Private Sub btnEditLevel3_Click(sender As Object, e As EventArgs) Handles btnEditLevel3.Click
        Dim formEdit As New EditLevel
        formEdit.LoadDataForEdit(GetLevelById(_levelCards(2).idLevel).Rows(0))
        formEdit.ShowDialog()
    End Sub

    Private Sub btnEditLevel4_Click(sender As Object, e As EventArgs) Handles btnEditLevel4.Click
        Dim formEdit As New EditLevel
        formEdit.LoadDataForEdit(GetLevelById(_levelCards(3).idLevel).Rows(0))
        formEdit.ShowDialog()
    End Sub

    Private Sub btnEditLevel5_Click(sender As Object, e As EventArgs) Handles btnEditLevel5.Click
        Dim formEdit As New EditLevel
        formEdit.LoadDataForEdit(GetLevelById(_levelCards(4).idLevel).Rows(0))
        formEdit.ShowDialog()
    End Sub

    Private Sub btnHapusLevel1_Click(sender As Object, e As EventArgs) Handles btnHapusLevel1.Click
        Dim konfirmasi As DialogResult = MessageBox.Show(
                                       "Apakah kamu yakin ingin menghapus level ini?",
                                       "Konfirmasi Hapus",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Warning)
        If konfirmasi = DialogResult.Yes Then
            If HapusLevel(_levelCards(0).idLevel) Then
                MessageBox.Show("Level berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Level gagal dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        ReloadData()
    End Sub

    Private Sub btnHapusLevel2_Click(sender As Object, e As EventArgs) Handles btnHapusLevel2.Click
        Dim konfirmasi As DialogResult = MessageBox.Show(
                                       "Apakah kamu yakin ingin menghapus level ini?",
                                       "Konfirmasi Hapus",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Warning)
        If konfirmasi = DialogResult.Yes Then
            If HapusLevel(_levelCards(1).idLevel) Then
                MessageBox.Show("Level berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Level gagal dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        ReloadData()
    End Sub

    Private Sub btnHapusLevel3_Click(sender As Object, e As EventArgs) Handles btnHapusLevel3.Click
        Dim konfirmasi As DialogResult = MessageBox.Show(
                                       "Apakah kamu yakin ingin menghapus level ini?",
                                       "Konfirmasi Hapus",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Warning)
        If konfirmasi = DialogResult.Yes Then
            If HapusLevel(_levelCards(2).idLevel) Then
                MessageBox.Show("Level berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Level gagal dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        ReloadData()
    End Sub

    Private Sub btnHapusLevel4_Click(sender As Object, e As EventArgs) Handles btnHapusLevel4.Click
        Dim konfirmasi As DialogResult = MessageBox.Show(
                                       "Apakah kamu yakin ingin menghapus level ini?",
                                       "Konfirmasi Hapus",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Warning)
        If konfirmasi = DialogResult.Yes Then
            If HapusLevel(_levelCards(3).idLevel) Then
                MessageBox.Show("Level berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Level gagal dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        ReloadData()
    End Sub

    Private Sub btnHapusLevel5_Click(sender As Object, e As EventArgs) Handles btnHapusLevel5.Click
        Dim konfirmasi As DialogResult = MessageBox.Show(
                                       "Apakah kamu yakin ingin menghapus level ini?",
                                       "Konfirmasi Hapus",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Warning)
        If konfirmasi = DialogResult.Yes Then
            If HapusLevel(_levelCards(4).idLevel) Then
                MessageBox.Show("Level berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Level gagal dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        ReloadData()
    End Sub
End Class