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
        btnTambah = New Button()
        txtIPS = New Label()
        txtInputIPS = New TextBox()
        txtIPK = New Label()
        btnReset = New Button()
        txtInputIPK = New TextBox()
        txtKeterangan = New Label()
        SuspendLayout()
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(344, 158)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtIPS
        ' 
        txtIPS.AutoSize = True
        txtIPS.Location = New Point(219, 125)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(86, 20)
        txtIPS.TabIndex = 1
        txtIPS.Text = "IP Semester"
        ' 
        ' txtInputIPS
        ' 
        txtInputIPS.Location = New Point(344, 125)
        txtInputIPS.Name = "txtInputIPS"
        txtInputIPS.Size = New Size(194, 27)
        txtInputIPS.TabIndex = 2
        ' 
        ' txtIPK
        ' 
        txtIPK.AutoSize = True
        txtIPK.Location = New Point(219, 224)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(89, 20)
        txtIPK.TabIndex = 3
        txtIPK.Text = "IP Kumulatif"
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(444, 158)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 4
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' txtInputIPK
        ' 
        txtInputIPK.Location = New Point(344, 221)
        txtInputIPK.Name = "txtInputIPK"
        txtInputIPK.ReadOnly = True
        txtInputIPK.Size = New Size(194, 27)
        txtInputIPK.TabIndex = 5
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.AutoSize = True
        txtKeterangan.Location = New Point(344, 267)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(0, 20)
        txtKeterangan.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtKeterangan)
        Controls.Add(txtInputIPK)
        Controls.Add(btnReset)
        Controls.Add(txtIPK)
        Controls.Add(txtInputIPS)
        Controls.Add(txtIPS)
        Controls.Add(btnTambah)
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTambah As Button
    Friend WithEvents txtIPS As Label
    Friend WithEvents txtInputIPS As TextBox
    Friend WithEvents txtIPK As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents txtInputIPK As TextBox
    Friend WithEvents txtKeterangan As Label

End Class
