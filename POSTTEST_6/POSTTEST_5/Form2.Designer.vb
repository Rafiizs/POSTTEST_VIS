<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        txtKodeChapter = New TextBox()
        txtJudulChapter = New TextBox()
        txtHalaman = New TextBox()
        txtSearch = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lblTitle = New Label()
        cbManga = New ComboBox()
        dtRilis = New DateTimePicker()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvChapter = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvChapter, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtKodeChapter
        ' 
        txtKodeChapter.Location = New Point(172, 75)
        txtKodeChapter.Name = "txtKodeChapter"
        txtKodeChapter.Size = New Size(359, 23)
        txtKodeChapter.TabIndex = 0
        ' 
        ' txtJudulChapter
        ' 
        txtJudulChapter.Location = New Point(172, 143)
        txtJudulChapter.Name = "txtJudulChapter"
        txtJudulChapter.Size = New Size(359, 23)
        txtJudulChapter.TabIndex = 1
        ' 
        ' txtHalaman
        ' 
        txtHalaman.Location = New Point(172, 181)
        txtHalaman.Name = "txtHalaman"
        txtHalaman.Size = New Size(359, 23)
        txtHalaman.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(113, 323)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(418, 23)
        txtSearch.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 4
        Label1.Text = "Kode Chapter"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 5
        Label2.Text = "Manga"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(35, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 15)
        Label3.TabIndex = 6
        Label3.Text = "Judul Chapter"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 15)
        Label4.TabIndex = 7
        Label4.Text = "Jumlah Halaman"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 229)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 15)
        Label5.TabIndex = 8
        Label5.Text = "Tanggal Rilis"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(35, 326)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 9
        Label6.Text = "Cari Data"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(35, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(229, 25)
        lblTitle.TabIndex = 10
        lblTitle.Text = "DATA CHAPTER MANGA"
        ' 
        ' cbManga
        ' 
        cbManga.DropDownStyle = ComboBoxStyle.DropDownList
        cbManga.FormattingEnabled = True
        cbManga.Location = New Point(172, 111)
        cbManga.Name = "cbManga"
        cbManga.Size = New Size(359, 23)
        cbManga.TabIndex = 11
        ' 
        ' dtRilis
        ' 
        dtRilis.Format = DateTimePickerFormat.Short
        dtRilis.Location = New Point(172, 223)
        dtRilis.Name = "dtRilis"
        dtRilis.Size = New Size(359, 23)
        dtRilis.TabIndex = 12
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(35, 274)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 13
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(172, 274)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 14
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(311, 274)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 15
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(456, 274)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 16
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvChapter
        ' 
        dgvChapter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvChapter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvChapter.Location = New Point(30, 379)
        dgvChapter.Name = "dgvChapter"
        dgvChapter.ReadOnly = True
        dgvChapter.Size = New Size(501, 193)
        dgvChapter.TabIndex = 17
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(580, 584)
        Controls.Add(dgvChapter)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(dtRilis)
        Controls.Add(cbManga)
        Controls.Add(lblTitle)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSearch)
        Controls.Add(txtHalaman)
        Controls.Add(txtJudulChapter)
        Controls.Add(txtKodeChapter)
        Name = "Form2"
        Text = "Form2"
        CType(dgvChapter, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtKodeChapter As TextBox
    Friend WithEvents txtJudulChapter As TextBox
    Friend WithEvents txtHalaman As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents cbManga As ComboBox
    Friend WithEvents dtRilis As DateTimePicker
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvChapter As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
