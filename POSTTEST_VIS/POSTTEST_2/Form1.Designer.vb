<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        inputTambahJudul = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        inputGenre = New TextBox()
        btnTambah = New Button()
        Label4 = New Label()
        inputHapusJudul = New TextBox()
        btnHapus = New Button()
        dgvBuku = New DataGridView()
        colJudulBuku = New DataGridViewTextBoxColumn()
        colGenreBuku = New DataGridViewTextBoxColumn()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 37)
        Label1.TabIndex = 0
        Label1.Text = "DAFTAR BUKU"
        ' 
        ' inputTambahJudul
        ' 
        inputTambahJudul.Location = New Point(131, 75)
        inputTambahJudul.Name = "inputTambahJudul"
        inputTambahJudul.Size = New Size(125, 27)
        inputTambahJudul.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 2
        Label2.Text = "Judul Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 4
        Label3.Text = "Genre"
        ' 
        ' inputGenre
        ' 
        inputGenre.Location = New Point(131, 108)
        inputGenre.Name = "inputGenre"
        inputGenre.Size = New Size(125, 27)
        inputGenre.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(20, 147)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 6
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(425, 75)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 8
        Label4.Text = "Judul Buku"
        ' 
        ' inputHapusJudul
        ' 
        inputHapusJudul.Location = New Point(536, 75)
        inputHapusJudul.Name = "inputHapusJudul"
        inputHapusJudul.Size = New Size(125, 27)
        inputHapusJudul.TabIndex = 7
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(425, 147)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 10
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' dgvBuku
        ' 
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Columns.AddRange(New DataGridViewColumn() {colJudulBuku, colGenreBuku})
        dgvBuku.Location = New Point(180, 224)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.RowHeadersWidth = 51
        dgvBuku.Size = New Size(418, 191)
        dgvBuku.TabIndex = 11
        ' 
        ' colJudulBuku
        ' 
        colJudulBuku.HeaderText = "Judul"
        colJudulBuku.MinimumWidth = 6
        colJudulBuku.Name = "colJudulBuku"
        colJudulBuku.Width = 125
        ' 
        ' colGenreBuku
        ' 
        colGenreBuku.HeaderText = "Genre"
        colGenreBuku.MinimumWidth = 6
        colGenreBuku.Name = "colGenreBuku"
        colGenreBuku.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvBuku)
        Controls.Add(btnHapus)
        Controls.Add(Label4)
        Controls.Add(inputHapusJudul)
        Controls.Add(btnTambah)
        Controls.Add(Label3)
        Controls.Add(inputGenre)
        Controls.Add(Label2)
        Controls.Add(inputTambahJudul)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inputTambahJudul As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents inputGenre As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents inputHapusJudul As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents colJudulBuku As DataGridViewTextBoxColumn
    Friend WithEvents colGenreBuku As DataGridViewTextBoxColumn

End Class
