Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Demonlist - Ranking Level"
        LoadLevels()
    End Sub

    Private Sub LoadLevels(Optional keyword As String = "")
        Dim dt As DataTable
        If keyword = "" Then
            dt = DataModule.GetAllLevels()
        Else
            dt = DataModule.SearchLevel(keyword)
        End If
        RenderLevelCards(dt)
    End Sub

    Private Sub RenderLevelCards(dt As DataTable)
        FlowLayoutPanel1.Controls.Clear()

        If dt.Rows.Count = 0 Then
            Dim lblKosong As New Label()
            lblKosong.Text = "Tidak ada data level."
            lblKosong.AutoSize = True
            lblKosong.Font = New Font("Segoe UI", 11)
            lblKosong.ForeColor = Color.Gray
            lblKosong.Margin = New Padding(10)
            FlowLayoutPanel1.Controls.Add(lblKosong)
            Return
        End If

        For Each row As DataRow In dt.Rows
            Dim card As Guna.UI2.WinForms.Guna2Panel = LevelCard(row)
            FlowLayoutPanel1.Controls.Add(card)
        Next
    End Sub

    Private Function LevelCard(row As DataRow) As Guna.UI2.WinForms.Guna2Panel
        Dim idLevel As String = row("id_level").ToString()
        Dim namaLevel As String = row("nama_level").ToString()
        Dim publisher As String = row("publisher").ToString()
        Dim verifier As String = row("verifier").ToString()
        Dim rank As String = row("rank").ToString()
        Dim thumbnailPath As String = row("thumbnail_url").ToString()

        ' Buat panel utama
        Dim panel As New Guna.UI2.WinForms.Guna2Panel()
        panel.Size = New Size(768, 110)
        panel.BorderColor = Color.Black
        panel.BorderRadius = 8
        panel.BorderThickness = 1
        panel.Padding = New Padding(12, 6, 12, 6)
        panel.Margin = New Padding(3)
        panel.Tag = idLevel

        ' Cek apakah thumbnail ada
        Dim hasThumbnail As Boolean = False
        If thumbnailPath <> "" AndAlso IO.File.Exists(thumbnailPath) Then
            Try
                ' Load gambar asli
                Dim originalImage As Image = Image.FromFile(thumbnailPath)

                ' Buat bitmap baru dengan ukuran panel (768x110)
                Dim croppedBitmap As New Bitmap(768, 110)

                Using g As Graphics = Graphics.FromImage(croppedBitmap)
                    ' Hitung area crop dari gambar asli agar sesuai rasio 768:110
                    Dim targetRatio As Double = 768.0 / 110.0  ' Rasio target = 6.98
                    Dim sourceRatio As Double = CDbl(originalImage.Width) / CDbl(originalImage.Height)

                    Dim sourceRect As Rectangle

                    If sourceRatio > targetRatio Then
                        ' Gambar lebih lebar - crop dari tengah secara horizontal
                        Dim cropWidth As Integer = CInt(originalImage.Height * targetRatio)
                        Dim cropX As Integer = (originalImage.Width - cropWidth) \ 2
                        sourceRect = New Rectangle(cropX, 0, cropWidth, originalImage.Height)
                    Else
                        ' Gambar lebih tinggi - crop dari tengah secara vertikal
                        Dim cropHeight As Integer = CInt(originalImage.Width / targetRatio)
                        Dim cropY As Integer = (originalImage.Height - cropHeight) \ 2
                        sourceRect = New Rectangle(0, cropY, originalImage.Width, cropHeight)
                    End If

                    ' Gambar hasil crop ke bitmap (resize otomatis ke 768x110)
                    g.DrawImage(originalImage, New Rectangle(0, 0, 768, 110), sourceRect, GraphicsUnit.Pixel)

                    ' Tambahkan overlay gelap
                    Using brush As New SolidBrush(Color.FromArgb(150, 0, 0, 0))
                        g.FillRectangle(brush, New Rectangle(0, 0, 768, 110))
                    End Using
                End Using

                ' Set background image
                panel.BackgroundImage = croppedBitmap
                panel.BackgroundImageLayout = ImageLayout.None ' Tidak perlu stretch karena sudah pas
                hasThumbnail = True

                ' Dispose gambar asli untuk hemat memory
                originalImage.Dispose()
            Catch ex As Exception
                ' Jika gagal, biarkan tanpa background
            End Try
        End If

        ' Buat TableLayoutPanel utama
        Dim tbl As New TableLayoutPanel()
        tbl.Dock = DockStyle.Fill
        tbl.ColumnCount = 3
        tbl.RowCount = 1
        tbl.BackColor = Color.Transparent
        tbl.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 101))
        tbl.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))
        tbl.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 130))
        tbl.RowStyles.Add(New RowStyle(SizeType.Percent, 100))

        ' Label Rank (seperti Label1 di desain)
        Dim lblRank As New Label()
        lblRank.Text = "#" & rank
        lblRank.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        lblRank.Dock = DockStyle.Fill
        lblRank.TextAlign = ContentAlignment.MiddleLeft
        lblRank.BackColor = Color.Transparent
        lblRank.ForeColor = If(hasThumbnail, Color.White, Color.Black)

        ' TableLayout untuk info (seperti TableLayoutPanel3 di desain)
        Dim tblInfo As New TableLayoutPanel()
        tblInfo.Dock = DockStyle.Fill
        tblInfo.ColumnCount = 1
        tblInfo.RowCount = 2
        tblInfo.BackColor = Color.Transparent
        tblInfo.RowStyles.Add(New RowStyle(SizeType.Percent, 60))
        tblInfo.RowStyles.Add(New RowStyle(SizeType.Percent, 40))
        tblInfo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))

        ' Label Nama Level (seperti Label2 di desain)
        Dim lblNama As New Label()
        lblNama.Text = namaLevel
        lblNama.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblNama.Dock = DockStyle.Fill
        lblNama.TextAlign = ContentAlignment.MiddleLeft
        lblNama.AutoSize = False
        lblNama.BackColor = Color.Transparent
        lblNama.ForeColor = If(hasThumbnail, Color.White, Color.Black)

        ' Label Publisher & Verifier (seperti Label3 di desain)
        Dim lblPublisher As New Label()
        lblPublisher.Text = "oleh " & publisher & "  |  Verifier: " & verifier
        lblPublisher.Dock = DockStyle.Fill
        lblPublisher.TextAlign = ContentAlignment.MiddleLeft
        lblPublisher.AutoSize = False
        lblPublisher.BackColor = Color.Transparent
        lblPublisher.ForeColor = If(hasThumbnail, Color.LightGray, Color.DimGray)

        tblInfo.Controls.Add(lblNama, 0, 0)
        tblInfo.Controls.Add(lblPublisher, 0, 1)

        ' TableLayout untuk tombol (seperti TableLayoutPanel2 di desain)
        Dim tblBtn As New TableLayoutPanel()
        tblBtn.Dock = DockStyle.Fill
        tblBtn.ColumnCount = 1
        tblBtn.RowCount = 2
        tblBtn.BackColor = Color.Transparent
        tblBtn.RowStyles.Add(New RowStyle(SizeType.Percent, 50))
        tblBtn.RowStyles.Add(New RowStyle(SizeType.Percent, 50))
        tblBtn.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))

        ' Tombol Edit (seperti Guna2Button2 di desain)
        Dim btnEdit As New Guna.UI2.WinForms.Guna2Button()
        btnEdit.Text = "Edit"
        btnEdit.ForeColor = Color.White
        btnEdit.Font = New Font("Segoe UI", 9.0F)
        btnEdit.Size = New Size(118, 32)
        btnEdit.Anchor = AnchorStyles.Right
        btnEdit.Tag = idLevel

        ' Tombol Hapus (seperti Guna2Button3 di desain)
        Dim btnHapus As New Guna.UI2.WinForms.Guna2Button()
        btnHapus.Text = "Hapus"
        btnHapus.ForeColor = Color.White
        btnHapus.Font = New Font("Segoe UI", 9.0F)
        btnHapus.Size = New Size(118, 32)
        btnHapus.Anchor = AnchorStyles.Right
        btnHapus.FillColor = Color.FromArgb(220, 53, 69)
        btnHapus.Tag = idLevel

        ' Event handler Edit
        AddHandler btnEdit.Click, Sub(s, ev)
                                      Dim id As String = CType(s, Guna.UI2.WinForms.Guna2Button).Tag.ToString()
                                      Dim dt2 As DataTable = DataModule.GetLevelById(id)
                                      If dt2.Rows.Count > 0 Then
                                          Dim editForm As New EditLevel()
                                          editForm.LoadDataForEdit(dt2.Rows(0))
                                          If editForm.ShowDialog(Me) = DialogResult.OK Then
                                              LoadLevels(Guna2TextBox1.Text.Trim())
                                          End If
                                      End If
                                  End Sub

        ' Event handler Hapus
        AddHandler btnHapus.Click, Sub(s, ev)
                                       Dim id As String = CType(s, Guna.UI2.WinForms.Guna2Button).Tag.ToString()
                                       Dim konfirmasi As DialogResult = MessageBox.Show(
                                       "Apakah kamu yakin ingin menghapus level ini?",
                                       "Konfirmasi Hapus",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Warning)
                                       If konfirmasi = DialogResult.Yes Then
                                           If DataModule.HapusLevel(id) Then
                                               MessageBox.Show("Level berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                               LoadLevels(Guna2TextBox1.Text.Trim())
                                           End If
                                       End If
                                   End Sub

        tblBtn.Controls.Add(btnEdit, 0, 0)
        tblBtn.Controls.Add(btnHapus, 0, 1)

        ' Susun semua ke dalam TableLayout utama
        tbl.Controls.Add(lblRank, 0, 0)
        tbl.Controls.Add(tblInfo, 1, 0)
        tbl.Controls.Add(tblBtn, 2, 0)

        ' Tambahkan TableLayout ke Panel
        panel.Controls.Add(tbl)

        Return panel
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim modalTambahLevel As New TambahLevel()
        If modalTambahLevel.ShowDialog(Me) = DialogResult.OK Then
            LoadLevels(Guna2TextBox1.Text.Trim())
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        LoadLevels(Guna2TextBox1.Text.Trim())
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim konfirmasi = MessageBox.Show(
            "Apakah kamu yakin ingin keluar?",
            "Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub RankListToolStripMenuItem_Click(sender As Object, e As EventArgs)
        LoadLevels()
        Guna2TextBox1.Text = ""
    End Sub
End Class