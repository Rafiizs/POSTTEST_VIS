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
        components = New ComponentModel.Container()
        ErrorProvider1 = New ErrorProvider(components)
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtKode = New TextBox()
        txtJudul = New TextBox()
        txtGenre = New TextBox()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvManga = New DataGridView()
        MenuStrip1 = New MenuStrip()
        DataChapterToolStripMenuItem = New ToolStripMenuItem()
        menuChapter = New ToolStripMenuItem()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvManga, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 0
        Label1.Text = "Kode Manga"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 1
        Label2.Text = "Judul Manga"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(33, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 2
        Label3.Text = "Genre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(33, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 3
        Label4.Text = "Cari Data"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(111, 38)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(328, 23)
        txtKode.TabIndex = 4
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(111, 67)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(328, 23)
        txtJudul.TabIndex = 5
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(111, 97)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(328, 23)
        txtGenre.TabIndex = 6
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(111, 198)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(328, 23)
        txtSearch.TabIndex = 7
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(34, 149)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 8
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(144, 149)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 9
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(256, 149)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 10
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(365, 149)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 11
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvManga
        ' 
        dgvManga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvManga.Location = New Point(33, 237)
        dgvManga.Name = "dgvManga"
        dgvManga.ReadOnly = True
        dgvManga.Size = New Size(406, 158)
        dgvManga.TabIndex = 12
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {DataChapterToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(518, 24)
        MenuStrip1.TabIndex = 13
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DataChapterToolStripMenuItem
        ' 
        DataChapterToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {menuChapter})
        DataChapterToolStripMenuItem.Name = "DataChapterToolStripMenuItem"
        DataChapterToolStripMenuItem.Size = New Size(50, 20)
        DataChapterToolStripMenuItem.Text = "Menu"
        ' 
        ' menuChapter
        ' 
        menuChapter.Name = "menuChapter"
        menuChapter.Size = New Size(180, 22)
        menuChapter.Text = "Data Chapter"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(518, 441)
        Controls.Add(dgvManga)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(txtGenre)
        Controls.Add(txtJudul)
        Controls.Add(txtKode)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvManga, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtKode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvManga As DataGridView
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataChapterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuChapter As ToolStripMenuItem

End Class
