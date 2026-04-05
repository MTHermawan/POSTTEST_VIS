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
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        InputToolStripMenuItem = New ToolStripMenuItem()
        SimpanToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        rbCewe = New RadioButton()
        cbKomunitas = New ComboBox()
        rbCowo = New RadioButton()
        dtpLahir = New DateTimePicker()
        txtIdAnggota = New TextBox()
        txtNama = New TextBox()
        TabPage2 = New TabPage()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtbTelepon = New MaskedTextBox()
        TabPage3 = New TabPage()
        GroupBox2 = New GroupBox()
        cbBermainMusik = New CheckBox()
        cbMenggambar = New CheckBox()
        cbMemancing = New CheckBox()
        cbMenontonFilm = New CheckBox()
        cbBerkebun = New CheckBox()
        cbBermainGame = New CheckBox()
        cbPemrograman = New CheckBox()
        cbMembaca = New CheckBox()
        GroupBox1 = New GroupBox()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {InputToolStripMenuItem, SimpanToolStripMenuItem})
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(93, 24)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' InputToolStripMenuItem
        ' 
        InputToolStripMenuItem.Name = "InputToolStripMenuItem"
        InputToolStripMenuItem.Size = New Size(142, 26)
        InputToolStripMenuItem.Text = "Input"
        ' 
        ' SimpanToolStripMenuItem
        ' 
        SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        SimpanToolStripMenuItem.Size = New Size(142, 26)
        SimpanToolStripMenuItem.Text = "Simpan"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(94, 24)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(65, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(227, 31)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(561, 407)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(rbCewe)
        TabPage1.Controls.Add(cbKomunitas)
        TabPage1.Controls.Add(rbCowo)
        TabPage1.Controls.Add(dtpLahir)
        TabPage1.Controls.Add(txtIdAnggota)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(553, 374)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 154)
        Label5.Name = "Label5"
        Label5.Size = New Size(164, 20)
        Label5.TabIndex = 10
        Label5.Text = "Jenis Komunitas / Divisi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 20)
        Label4.TabIndex = 9
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 8
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 7
        Label2.Text = "ID Anggota"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 20)
        Label1.TabIndex = 6
        Label1.Text = "Nama Lengkap"
        ' 
        ' rbCewe
        ' 
        rbCewe.AutoSize = True
        rbCewe.Location = New Point(344, 115)
        rbCewe.Name = "rbCewe"
        rbCewe.Size = New Size(104, 24)
        rbCewe.TabIndex = 5
        rbCewe.TabStop = True
        rbCewe.Text = "Perempuan"
        rbCewe.UseVisualStyleBackColor = True
        ' 
        ' cbKomunitas
        ' 
        cbKomunitas.FormattingEnabled = True
        cbKomunitas.Items.AddRange(New Object() {"Komunitas Teknologi", "Komunitas Seni", "Komunitas Olahraga", "Komunitas Literasi", "Komunitas Musik"})
        cbKomunitas.Location = New Point(240, 151)
        cbKomunitas.Name = "cbKomunitas"
        cbKomunitas.Size = New Size(300, 28)
        cbKomunitas.TabIndex = 4
        ' 
        ' rbCowo
        ' 
        rbCowo.AutoSize = True
        rbCowo.Location = New Point(240, 115)
        rbCowo.Name = "rbCowo"
        rbCowo.Size = New Size(85, 24)
        rbCowo.TabIndex = 3
        rbCowo.TabStop = True
        rbCowo.Text = "Laki-laki"
        rbCowo.UseVisualStyleBackColor = True
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(240, 75)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(300, 27)
        dtpLahir.TabIndex = 2
        ' 
        ' txtIdAnggota
        ' 
        txtIdAnggota.Location = New Point(240, 42)
        txtIdAnggota.Name = "txtIdAnggota"
        txtIdAnggota.PlaceholderText = "ID Anggota"
        txtIdAnggota.Size = New Size(300, 27)
        txtIdAnggota.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(240, 9)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama Lengkap"
        txtNama.Size = New Size(300, 27)
        txtNama.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(mtbTelepon)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(553, 374)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 78)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 20)
        Label8.TabIndex = 9
        Label8.Text = "Alamat"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 45)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 20)
        Label7.TabIndex = 8
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 20)
        Label6.TabIndex = 7
        Label6.Text = "Nomor Telepon"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(240, 75)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(300, 54)
        txtAlamat.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(240, 42)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(300, 27)
        txtEmail.TabIndex = 1
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(240, 9)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(111, 27)
        mtbTelepon.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(GroupBox2)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(Button2)
        TabPage3.Controls.Add(Button1)
        TabPage3.Controls.Add(PictureBox2)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(553, 374)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbBermainMusik)
        GroupBox2.Controls.Add(cbMenggambar)
        GroupBox2.Controls.Add(cbMemancing)
        GroupBox2.Controls.Add(cbMenontonFilm)
        GroupBox2.Controls.Add(cbBerkebun)
        GroupBox2.Controls.Add(cbBermainGame)
        GroupBox2.Controls.Add(cbPemrograman)
        GroupBox2.Controls.Add(cbMembaca)
        GroupBox2.Location = New Point(198, 117)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(341, 203)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Minat / Hobi"
        ' 
        ' cbBermainMusik
        ' 
        cbBermainMusik.AutoSize = True
        cbBermainMusik.Location = New Point(179, 141)
        cbBermainMusik.Name = "cbBermainMusik"
        cbBermainMusik.Size = New Size(128, 24)
        cbBermainMusik.TabIndex = 8
        cbBermainMusik.Text = "Bermain Musik"
        cbBermainMusik.UseVisualStyleBackColor = True
        ' 
        ' cbMenggambar
        ' 
        cbMenggambar.AutoSize = True
        cbMenggambar.Location = New Point(15, 141)
        cbMenggambar.Name = "cbMenggambar"
        cbMenggambar.Size = New Size(121, 24)
        cbMenggambar.TabIndex = 7
        cbMenggambar.Text = "Menggambar"
        cbMenggambar.UseVisualStyleBackColor = True
        ' 
        ' cbMemancing
        ' 
        cbMemancing.AutoSize = True
        cbMemancing.Location = New Point(179, 106)
        cbMemancing.Name = "cbMemancing"
        cbMemancing.Size = New Size(109, 24)
        cbMemancing.TabIndex = 6
        cbMemancing.Text = "Memancing"
        cbMemancing.UseVisualStyleBackColor = True
        ' 
        ' cbMenontonFilm
        ' 
        cbMenontonFilm.AutoSize = True
        cbMenontonFilm.Location = New Point(15, 106)
        cbMenontonFilm.Name = "cbMenontonFilm"
        cbMenontonFilm.Size = New Size(131, 24)
        cbMenontonFilm.TabIndex = 5
        cbMenontonFilm.Text = "Menonton Film"
        cbMenontonFilm.UseVisualStyleBackColor = True
        ' 
        ' cbBerkebun
        ' 
        cbBerkebun.AutoSize = True
        cbBerkebun.Location = New Point(179, 70)
        cbBerkebun.Name = "cbBerkebun"
        cbBerkebun.Size = New Size(93, 24)
        cbBerkebun.TabIndex = 4
        cbBerkebun.Text = "Berkebun"
        cbBerkebun.UseVisualStyleBackColor = True
        ' 
        ' cbBermainGame
        ' 
        cbBermainGame.AutoSize = True
        cbBermainGame.Location = New Point(15, 70)
        cbBermainGame.Name = "cbBermainGame"
        cbBermainGame.Size = New Size(129, 24)
        cbBermainGame.TabIndex = 3
        cbBermainGame.Text = "Bermain Game"
        cbBermainGame.UseVisualStyleBackColor = True
        ' 
        ' cbPemrograman
        ' 
        cbPemrograman.AutoSize = True
        cbPemrograman.Location = New Point(179, 35)
        cbPemrograman.Name = "cbPemrograman"
        cbPemrograman.Size = New Size(124, 24)
        cbPemrograman.TabIndex = 2
        cbPemrograman.Text = "Pemrograman"
        cbPemrograman.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(15, 35)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(97, 24)
        cbMembaca.TabIndex = 0
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbAdmin)
        GroupBox1.Controls.Add(rbAnggota)
        GroupBox1.Controls.Add(rbKetua)
        GroupBox1.Location = New Point(198, 15)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(342, 96)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peran Komunitas"
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(204, 26)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(121, 24)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Administrator"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(99, 26)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(88, 24)
        rbAnggota.TabIndex = 1
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(15, 26)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(68, 24)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(368, 332)
        Button2.Name = "Button2"
        Button2.Size = New Size(171, 29)
        Button2.TabIndex = 2
        Button2.Text = "Simpan dan Cetak"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(18, 238)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 29)
        Button1.TabIndex = 1
        Button1.Text = "Browse"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(18, 15)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(163, 217)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(39, 60)
        Label9.Name = "Label9"
        Label9.Size = New Size(143, 20)
        Label9.TabIndex = 2
        Label9.Text = "ULTRA COMMUNITY"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 111)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(209, 327)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label9)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "FormUtama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents InputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rbCewe As RadioButton
    Friend WithEvents cbKomunitas As ComboBox
    Friend WithEvents rbCowo As RadioButton
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents txtIdAnggota As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents cbBerkebun As CheckBox
    Friend WithEvents cbBermainGame As CheckBox
    Friend WithEvents cbPemrograman As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbBermainMusik As CheckBox
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents cbMemancing As CheckBox
    Friend WithEvents cbMenontonFilm As CheckBox

End Class
