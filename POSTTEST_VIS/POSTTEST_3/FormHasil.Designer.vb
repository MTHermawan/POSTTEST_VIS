<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        picPasFoto = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        lblAlamat = New Label()
        lblHobi = New Label()
        lblTelp = New Label()
        lblJenisKelamin = New Label()
        lblLahir = New Label()
        lblUmur = New Label()
        lblNama = New Label()
        CType(picPasFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picPasFoto
        ' 
        picPasFoto.BackColor = Color.Transparent
        picPasFoto.Location = New Point(39, 160)
        picPasFoto.Name = "picPasFoto"
        picPasFoto.Size = New Size(132, 201)
        picPasFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picPasFoto.TabIndex = 0
        picPasFoto.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(230, 160)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nama:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(230, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 2
        Label2.Text = "Umur:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(230, 228)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 3
        Label3.Text = "Tanggal Lahir:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(230, 262)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 20)
        Label4.TabIndex = 4
        Label4.Text = "Jenis Kelamin:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(230, 297)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 20)
        Label5.TabIndex = 5
        Label5.Text = "No Telepon:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(230, 333)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 20)
        Label6.TabIndex = 6
        Label6.Text = "Hobi:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(230, 366)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 20)
        Label7.TabIndex = 7
        Label7.Text = "Alamat:"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblAlamat.ForeColor = Color.White
        lblAlamat.Location = New Point(378, 366)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(72, 20)
        lblAlamat.TabIndex = 14
        lblAlamat.Text = "(Alamat)"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.BackColor = Color.Transparent
        lblHobi.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblHobi.ForeColor = Color.White
        lblHobi.Location = New Point(378, 333)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(54, 20)
        lblHobi.TabIndex = 13
        lblHobi.Text = "(Hobi)"
        ' 
        ' lblTelp
        ' 
        lblTelp.AutoSize = True
        lblTelp.BackColor = Color.Transparent
        lblTelp.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTelp.ForeColor = Color.White
        lblTelp.Location = New Point(378, 297)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(101, 20)
        lblTelp.TabIndex = 12
        lblTelp.Text = "(No Telepon)"
        ' 
        ' lblJenisKelamin
        ' 
        lblJenisKelamin.AutoSize = True
        lblJenisKelamin.BackColor = Color.Transparent
        lblJenisKelamin.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblJenisKelamin.ForeColor = Color.White
        lblJenisKelamin.Location = New Point(378, 262)
        lblJenisKelamin.Name = "lblJenisKelamin"
        lblJenisKelamin.Size = New Size(117, 20)
        lblJenisKelamin.TabIndex = 11
        lblJenisKelamin.Text = "(Jenis Kelamin)"
        ' 
        ' lblLahir
        ' 
        lblLahir.AutoSize = True
        lblLahir.BackColor = Color.Transparent
        lblLahir.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblLahir.ForeColor = Color.White
        lblLahir.Location = New Point(378, 228)
        lblLahir.Name = "lblLahir"
        lblLahir.Size = New Size(115, 20)
        lblLahir.TabIndex = 10
        lblLahir.Text = "(Tanggal Lahir)"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Transparent
        lblUmur.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblUmur.ForeColor = Color.White
        lblUmur.Location = New Point(378, 194)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(61, 20)
        lblUmur.TabIndex = 9
        lblUmur.Text = "(Umur)"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(378, 160)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(63, 20)
        lblNama.TabIndex = 8
        lblNama.Text = "(Nama)"
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.pemvis_dr_card_form21
        ClientSize = New Size(770, 500)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobi)
        Controls.Add(lblTelp)
        Controls.Add(lblJenisKelamin)
        Controls.Add(lblLahir)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(picPasFoto)
        Name = "FormHasil"
        Text = "FormHasil"
        CType(picPasFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picPasFoto As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblTelp As Label
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents lblLahir As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNama As Label
End Class
