Module DataModule
	Public nama, umur, jenisKelamin, noTelp, hobi, alamat, foto As String
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
End Module