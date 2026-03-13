Public Class FormHasil
	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblNama.Text = DataModule.nama
		lblUmur.Text = DataModule.umur
		lblTelp.Text = DataModule.noTelp
		lblLahir.Text = DataModule.tglLahir
		lblJenisKelamin.Text = DataModule.jenisKelamin
		lblHobi.Text = DataModule.hobi
		lblAlamat.Text = DataModule.alamat
		picPasFoto.Image = Image.FromFile(DataModule.foto)
	End Sub
End Class