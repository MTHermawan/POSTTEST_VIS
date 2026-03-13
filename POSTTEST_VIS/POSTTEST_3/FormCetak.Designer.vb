<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
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
        picPasFoto = New PictureBox()
        btnFoto = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelp = New TextBox()
        txtAlamat = New TextBox()
        dtpLahir = New DateTimePicker()
        GroupBox1 = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        GroupBox2 = New GroupBox()
        cbMenari = New CheckBox()
        cbMenulis = New CheckBox()
        cbMenyanyi = New CheckBox()
        cbMenggambar = New CheckBox()
        cbOlahraga = New CheckBox()
        cbTraveling = New CheckBox()
        cbMemancing = New CheckBox()
        cbMembaca = New CheckBox()
        cbCoding = New CheckBox()
        cbGaming = New CheckBox()
        btnCetak = New Button()
        CType(picPasFoto, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' picPasFoto
        ' 
        picPasFoto.BackColor = Color.Transparent
        picPasFoto.Location = New Point(39, 160)
        picPasFoto.Name = "picPasFoto"
        picPasFoto.Size = New Size(131, 201)
        picPasFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picPasFoto.TabIndex = 0
        picPasFoto.TabStop = False
        ' 
        ' btnFoto
        ' 
        btnFoto.ImageAlign = ContentAlignment.TopLeft
        btnFoto.Location = New Point(41, 431)
        btnFoto.Name = "btnFoto"
        btnFoto.Size = New Size(128, 37)
        btnFoto.TabIndex = 1
        btnFoto.Text = "Pilih Gambar"
        btnFoto.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(231, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 18)
        Label1.TabIndex = 2
        Label1.Text = "Nama:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(231, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 18)
        Label2.TabIndex = 3
        Label2.Text = "Umur:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(231, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 18)
        Label3.TabIndex = 4
        Label3.Text = "No. Telp:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(231, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 18)
        Label5.TabIndex = 6
        Label5.Text = "Tgl Lahir:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(231, 276)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 18)
        Label6.TabIndex = 7
        Label6.Text = "Alamat:"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Microsoft Sans Serif", 9F)
        txtNama.Location = New Point(320, 136)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(249, 24)
        txtNama.TabIndex = 8
        ' 
        ' txtUmur
        ' 
        txtUmur.Font = New Font("Microsoft Sans Serif", 9F)
        txtUmur.Location = New Point(320, 170)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(249, 24)
        txtUmur.TabIndex = 9
        ' 
        ' txtTelp
        ' 
        txtTelp.Font = New Font("Microsoft Sans Serif", 9F)
        txtTelp.Location = New Point(320, 204)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(249, 24)
        txtTelp.TabIndex = 10
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Microsoft Sans Serif", 9F)
        txtAlamat.Location = New Point(320, 272)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(430, 24)
        txtAlamat.TabIndex = 11
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Font = New Font("Microsoft Sans Serif", 9F)
        dtpLahir.Location = New Point(320, 238)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(249, 24)
        dtpLahir.TabIndex = 12
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(rbPerempuan)
        GroupBox1.Controls.Add(rbLaki)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(588, 126)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(162, 136)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Font = New Font("Segoe UI", 9F)
        rbPerempuan.Location = New Point(12, 62)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Font = New Font("Segoe UI", 9F)
        rbLaki.Location = New Point(12, 29)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(85, 24)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(cbMenari)
        GroupBox2.Controls.Add(cbMenulis)
        GroupBox2.Controls.Add(cbMenyanyi)
        GroupBox2.Controls.Add(cbMenggambar)
        GroupBox2.Controls.Add(cbOlahraga)
        GroupBox2.Controls.Add(cbTraveling)
        GroupBox2.Controls.Add(cbMemancing)
        GroupBox2.Controls.Add(cbMembaca)
        GroupBox2.Controls.Add(cbCoding)
        GroupBox2.Controls.Add(cbGaming)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(231, 301)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(519, 92)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hobi"
        ' 
        ' cbMenari
        ' 
        cbMenari.AutoSize = True
        cbMenari.Font = New Font("Segoe UI", 8F)
        cbMenari.ForeColor = Color.White
        cbMenari.Location = New Point(424, 57)
        cbMenari.Name = "cbMenari"
        cbMenari.Size = New Size(74, 23)
        cbMenari.TabIndex = 9
        cbMenari.Text = "Menari"
        cbMenari.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Font = New Font("Segoe UI", 8F)
        cbMenulis.ForeColor = Color.White
        cbMenulis.Location = New Point(424, 26)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(79, 23)
        cbMenulis.TabIndex = 8
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbMenyanyi
        ' 
        cbMenyanyi.AutoSize = True
        cbMenyanyi.Font = New Font("Segoe UI", 8F)
        cbMenyanyi.ForeColor = Color.White
        cbMenyanyi.Location = New Point(300, 57)
        cbMenyanyi.Name = "cbMenyanyi"
        cbMenyanyi.Size = New Size(91, 23)
        cbMenyanyi.TabIndex = 7
        cbMenyanyi.Text = "Menyanyi"
        cbMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' cbMenggambar
        ' 
        cbMenggambar.AutoSize = True
        cbMenggambar.Font = New Font("Segoe UI", 8F)
        cbMenggambar.ForeColor = Color.White
        cbMenggambar.Location = New Point(300, 26)
        cbMenggambar.Name = "cbMenggambar"
        cbMenggambar.Size = New Size(114, 23)
        cbMenggambar.TabIndex = 6
        cbMenggambar.Text = "Menggambar"
        cbMenggambar.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Font = New Font("Segoe UI", 8F)
        cbOlahraga.ForeColor = Color.White
        cbOlahraga.Location = New Point(205, 57)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(87, 23)
        cbOlahraga.TabIndex = 5
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Font = New Font("Segoe UI", 8F)
        cbTraveling.ForeColor = Color.White
        cbTraveling.Location = New Point(205, 26)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(85, 23)
        cbTraveling.TabIndex = 4
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbMemancing
        ' 
        cbMemancing.AutoSize = True
        cbMemancing.Font = New Font("Segoe UI", 8F)
        cbMemancing.ForeColor = Color.White
        cbMemancing.Location = New Point(96, 57)
        cbMemancing.Name = "cbMemancing"
        cbMemancing.Size = New Size(103, 23)
        cbMemancing.TabIndex = 3
        cbMemancing.Text = "Memancing"
        cbMemancing.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Font = New Font("Segoe UI", 8F)
        cbMembaca.ForeColor = Color.White
        cbMembaca.Location = New Point(96, 26)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(91, 23)
        cbMembaca.TabIndex = 2
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Font = New Font("Segoe UI", 8F)
        cbCoding.ForeColor = Color.White
        cbCoding.Location = New Point(10, 57)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(75, 23)
        cbCoding.TabIndex = 1
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Font = New Font("Segoe UI", 8F)
        cbGaming.ForeColor = Color.White
        cbGaming.Location = New Point(10, 26)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(79, 23)
        cbGaming.TabIndex = 0
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.ImageAlign = ContentAlignment.TopLeft
        btnCetak.Location = New Point(231, 428)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(509, 42)
        btnCetak.TabIndex = 15
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' FormCetak
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.pemvis_dr_card_form1
        ClientSize = New Size(772, 481)
        Controls.Add(btnCetak)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(dtpLahir)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelp)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnFoto)
        Controls.Add(picPasFoto)
        Name = "FormCetak"
        Text = "FormCetak"
        CType(picPasFoto, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picPasFoto As PictureBox
    Friend WithEvents btnFoto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbMenari As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbMemancing As CheckBox
    Friend WithEvents cbMembaca As CheckBox

End Class
