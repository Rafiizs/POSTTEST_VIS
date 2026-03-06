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
        grpTambah = New GroupBox()
        txtGenre = New TextBox()
        txtJudul = New TextBox()
        btnTambah = New Button()
        lblJudul = New Label()
        lblGenre = New Label()
        grpHapus = New GroupBox()
        txtHapus = New TextBox()
        btnHapus = New Button()
        lblJudulHapus = New Label()
        lstBuku = New ListBox()
        grpTambah.SuspendLayout()
        grpHapus.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpTambah
        ' 
        grpTambah.Controls.Add(txtGenre)
        grpTambah.Controls.Add(txtJudul)
        grpTambah.Controls.Add(btnTambah)
        grpTambah.Controls.Add(lblJudul)
        grpTambah.Controls.Add(lblGenre)
        grpTambah.Location = New Point(42, 68)
        grpTambah.Name = "grpTambah"
        grpTambah.Size = New Size(362, 201)
        grpTambah.TabIndex = 0
        grpTambah.TabStop = False
        grpTambah.Text = "Tambah Buku"
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(151, 107)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(157, 27)
        txtGenre.TabIndex = 5
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(151, 38)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(157, 27)
        txtJudul.TabIndex = 4
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(262, 166)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(18, 38)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(79, 20)
        lblJudul.TabIndex = 2
        lblJudul.Text = "Judul Buku"
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(18, 110)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(48, 20)
        lblGenre.TabIndex = 0
        lblGenre.Text = "Genre"
        ' 
        ' grpHapus
        ' 
        grpHapus.Controls.Add(txtHapus)
        grpHapus.Controls.Add(btnHapus)
        grpHapus.Controls.Add(lblJudulHapus)
        grpHapus.Location = New Point(542, 68)
        grpHapus.Name = "grpHapus"
        grpHapus.Size = New Size(361, 201)
        grpHapus.TabIndex = 1
        grpHapus.TabStop = False
        grpHapus.Text = "Hapus Buku"
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(161, 47)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(157, 27)
        txtHapus.TabIndex = 3
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(261, 166)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' lblJudulHapus
        ' 
        lblJudulHapus.AutoSize = True
        lblJudulHapus.Location = New Point(23, 47)
        lblJudulHapus.Name = "lblJudulHapus"
        lblJudulHapus.Size = New Size(79, 20)
        lblJudulHapus.TabIndex = 1
        lblJudulHapus.Text = "Judul Buku"
        ' 
        ' lstBuku
        ' 
        lstBuku.FormattingEnabled = True
        lstBuku.Location = New Point(289, 287)
        lstBuku.Name = "lstBuku"
        lstBuku.Size = New Size(369, 244)
        lstBuku.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(939, 543)
        Controls.Add(lstBuku)
        Controls.Add(grpHapus)
        Controls.Add(grpTambah)
        Name = "Form1"
        Text = "Posttest 2"
        grpTambah.ResumeLayout(False)
        grpTambah.PerformLayout()
        grpHapus.ResumeLayout(False)
        grpHapus.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpTambah As GroupBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents grpHapus As GroupBox
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents lblJudulHapus As Label
    Friend WithEvents lstBuku As ListBox

End Class