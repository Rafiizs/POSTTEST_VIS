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
        picFoto = New PictureBox()
        btnBrowse = New Button()
        btnCetak = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelp = New TextBox()
        txtAlamat = New TextBox()
        grpJK = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        grpHobby = New GroupBox()
        cbMenari = New CheckBox()
        cbMenyanyi = New CheckBox()
        cbMenggambar = New CheckBox()
        cbMemancing = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMenulis = New CheckBox()
        cbMembaca = New CheckBox()
        cbTravel = New CheckBox()
        cbCoding = New CheckBox()
        cbGaming = New CheckBox()
        dtTanggal = New DateTimePicker()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        grpJK.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(12, 12)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(249, 380)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(87, 409)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(279, 409)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(509, 29)
        btnCetak.TabIndex = 2
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(279, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 3
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(279, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 4
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(279, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 5
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(279, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 6
        Label4.Text = "No Telepon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(279, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 7
        Label5.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(424, 12)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(220, 27)
        txtNama.TabIndex = 8
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(424, 47)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(220, 27)
        txtUmur.TabIndex = 9
        ' 
        ' txtTelp
        ' 
        txtTelp.Location = New Point(424, 117)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(220, 27)
        txtTelp.TabIndex = 10
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(424, 155)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(220, 34)
        txtAlamat.TabIndex = 11
        ' 
        ' grpJK
        ' 
        grpJK.Controls.Add(rbPerempuan)
        grpJK.Controls.Add(rbLaki)
        grpJK.Location = New Point(267, 214)
        grpJK.Name = "grpJK"
        grpJK.Size = New Size(264, 178)
        grpJK.TabIndex = 12
        grpJK.TabStop = False
        grpJK.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(22, 69)
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
        rbLaki.Location = New Point(21, 33)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(93, 24)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.Controls.Add(cbMenari)
        grpHobby.Controls.Add(cbMenyanyi)
        grpHobby.Controls.Add(cbMenggambar)
        grpHobby.Controls.Add(cbMemancing)
        grpHobby.Controls.Add(cbOlahraga)
        grpHobby.Controls.Add(cbMenulis)
        grpHobby.Controls.Add(cbMembaca)
        grpHobby.Controls.Add(cbTravel)
        grpHobby.Controls.Add(cbCoding)
        grpHobby.Controls.Add(cbGaming)
        grpHobby.Location = New Point(537, 214)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(251, 178)
        grpHobby.TabIndex = 13
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby"
        ' 
        ' cbMenari
        ' 
        cbMenari.AutoSize = True
        cbMenari.Location = New Point(131, 147)
        cbMenari.Name = "cbMenari"
        cbMenari.Size = New Size(77, 24)
        cbMenari.TabIndex = 9
        cbMenari.Text = "Menari"
        cbMenari.UseVisualStyleBackColor = True
        ' 
        ' cbMenyanyi
        ' 
        cbMenyanyi.AutoSize = True
        cbMenyanyi.Location = New Point(131, 116)
        cbMenyanyi.Name = "cbMenyanyi"
        cbMenyanyi.Size = New Size(94, 24)
        cbMenyanyi.TabIndex = 8
        cbMenyanyi.Text = "Menyanyi"
        cbMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' cbMenggambar
        ' 
        cbMenggambar.AutoSize = True
        cbMenggambar.Location = New Point(131, 86)
        cbMenggambar.Name = "cbMenggambar"
        cbMenggambar.Size = New Size(121, 24)
        cbMenggambar.TabIndex = 7
        cbMenggambar.Text = "Menggambar"
        cbMenggambar.UseVisualStyleBackColor = True
        ' 
        ' cbMemancing
        ' 
        cbMemancing.AutoSize = True
        cbMemancing.Location = New Point(131, 56)
        cbMemancing.Name = "cbMemancing"
        cbMemancing.Size = New Size(109, 24)
        cbMemancing.TabIndex = 6
        cbMemancing.Text = "Memancing"
        cbMemancing.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(131, 26)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(92, 24)
        cbOlahraga.TabIndex = 5
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Location = New Point(4, 147)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(82, 24)
        cbMenulis.TabIndex = 4
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(4, 117)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(97, 24)
        cbMembaca.TabIndex = 3
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbTravel
        ' 
        cbTravel.AutoSize = True
        cbTravel.Location = New Point(4, 86)
        cbTravel.Name = "cbTravel"
        cbTravel.Size = New Size(70, 24)
        cbTravel.TabIndex = 2
        cbTravel.Text = "Travel"
        cbTravel.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(4, 56)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(79, 24)
        cbCoding.TabIndex = 1
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(4, 26)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(83, 24)
        cbGaming.TabIndex = 0
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' dtTanggal
        ' 
        dtTanggal.Format = DateTimePickerFormat.Short
        dtTanggal.Location = New Point(424, 81)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(220, 27)
        dtTanggal.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.doge_memes_face_dog_wallpaper_thumb
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(dtTanggal)
        Controls.Add(grpHobby)
        Controls.Add(grpJK)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelp)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCetak)
        Controls.Add(btnBrowse)
        Controls.Add(picFoto)
        Name = "Form1"
        Text = "Form1"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        grpJK.ResumeLayout(False)
        grpJK.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents grpJK As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents cbMenari As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents cbMemancing As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbTravel As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbGaming As CheckBox

End Class
