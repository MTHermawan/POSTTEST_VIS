<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManajemenTag
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        dgvManajemenTag = New Guna.UI2.WinForms.Guna2DataGridView()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtNamaTag = New Guna.UI2.WinForms.Guna2TextBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnTambah = New Guna.UI2.WinForms.Guna2Button()
        btnHapus = New Guna.UI2.WinForms.Guna2Button()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        CType(dgvManajemenTag, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvManajemenTag
        ' 
        dgvManajemenTag.AllowUserToAddRows = False
        dgvManajemenTag.AllowUserToDeleteRows = False
        dgvManajemenTag.AllowUserToResizeColumns = False
        dgvManajemenTag.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvManajemenTag.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvManajemenTag.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvManajemenTag.ColumnHeadersHeight = 30
        dgvManajemenTag.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvManajemenTag.DefaultCellStyle = DataGridViewCellStyle3
        dgvManajemenTag.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvManajemenTag.Location = New Point(3, 3)
        dgvManajemenTag.Name = "dgvManajemenTag"
        dgvManajemenTag.ReadOnly = True
        dgvManajemenTag.RowHeadersVisible = False
        dgvManajemenTag.RowHeadersWidth = 51
        dgvManajemenTag.Size = New Size(385, 420)
        dgvManajemenTag.TabIndex = 0
        dgvManajemenTag.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvManajemenTag.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvManajemenTag.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvManajemenTag.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvManajemenTag.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvManajemenTag.ThemeStyle.BackColor = Color.White
        dgvManajemenTag.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvManajemenTag.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvManajemenTag.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvManajemenTag.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9.0F)
        dgvManajemenTag.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvManajemenTag.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvManajemenTag.ThemeStyle.HeaderStyle.Height = 30
        dgvManajemenTag.ThemeStyle.ReadOnly = True
        dgvManajemenTag.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvManajemenTag.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvManajemenTag.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9.0F)
        dgvManajemenTag.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvManajemenTag.ThemeStyle.RowsStyle.Height = 29
        dgvManajemenTag.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvManajemenTag.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 385.0F))
        TableLayoutPanel1.Controls.Add(dgvManajemenTag, 0, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 0)
        TableLayoutPanel1.Location = New Point(12, 12)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Size = New Size(776, 426)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel2.Controls.Add(FlowLayoutPanel1, 0, 1)
        TableLayoutPanel2.Controls.Add(FlowLayoutPanel2, 0, 2)
        TableLayoutPanel2.Dock = DockStyle.Top
        TableLayoutPanel2.Location = New Point(394, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 280.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 50.0F))
        TableLayoutPanel2.Size = New Size(379, 420)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Controls.Add(Guna2HtmlLabel1, 0, 0)
        TableLayoutPanel3.Controls.Add(txtNamaTag, 0, 1)
        TableLayoutPanel3.Dock = DockStyle.Top
        TableLayoutPanel3.Location = New Point(3, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 43.5483856F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 56.4516144F))
        TableLayoutPanel3.Size = New Size(373, 80)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Dock = DockStyle.Fill
        Guna2HtmlLabel1.ForeColor = SystemColors.ControlText
        Guna2HtmlLabel1.Location = New Point(3, 3)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(72, 22)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "Nama Tag"
        ' 
        ' txtNamaTag
        ' 
        txtNamaTag.CustomizableEdges = CustomizableEdges1
        txtNamaTag.DefaultText = ""
        txtNamaTag.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtNamaTag.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtNamaTag.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtNamaTag.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtNamaTag.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtNamaTag.Font = New Font("Segoe UI", 9.0F)
        txtNamaTag.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtNamaTag.Location = New Point(3, 38)
        txtNamaTag.Margin = New Padding(3, 4, 3, 4)
        txtNamaTag.Name = "txtNamaTag"
        txtNamaTag.PlaceholderText = ""
        txtNamaTag.SelectedText = ""
        txtNamaTag.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtNamaTag.Size = New Size(262, 38)
        txtNamaTag.TabIndex = 1
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(btnTambah)
        FlowLayoutPanel1.Controls.Add(btnHapus)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(3, 93)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(373, 274)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.CustomizableEdges = CustomizableEdges3
        btnTambah.DisabledState.BorderColor = Color.DarkGray
        btnTambah.DisabledState.CustomBorderColor = Color.DarkGray
        btnTambah.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnTambah.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnTambah.Font = New Font("Segoe UI", 9.0F)
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(3, 3)
        btnTambah.Name = "btnTambah"
        btnTambah.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnTambah.Size = New Size(128, 36)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        ' 
        ' btnHapus
        ' 
        btnHapus.CustomizableEdges = CustomizableEdges5
        btnHapus.DisabledState.BorderColor = Color.DarkGray
        btnHapus.DisabledState.CustomBorderColor = Color.DarkGray
        btnHapus.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnHapus.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnHapus.FillColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnHapus.Font = New Font("Segoe UI", 9F)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(137, 3)
        btnHapus.Name = "btnHapus"
        btnHapus.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnHapus.Size = New Size(128, 36)
        btnHapus.TabIndex = 1
        btnHapus.Text = "Hapus"
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Dock = DockStyle.Fill
        FlowLayoutPanel2.Location = New Point(3, 373)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(373, 44)
        FlowLayoutPanel2.TabIndex = 2
        ' 
        ' ManajemenTag
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "ManajemenTag"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manajemen Tag"
        CType(dgvManajemenTag, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvManajemenTag As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtNamaTag As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnTambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
End Class
