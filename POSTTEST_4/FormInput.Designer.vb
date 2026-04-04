<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
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
        tabInput = New TabControl()
        tabData = New TabPage()
        lblKomunitas = New Label()
        lblTanggal = New Label()
        lblID = New Label()
        lblNama = New Label()
        txtID = New TextBox()
        gbGender = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        cbKomunitas = New ComboBox()
        dtpLahir = New DateTimePicker()
        txtNama = New TextBox()
        tabKontak = New TabPage()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtbTelepon = New MaskedTextBox()
        lblAlamat = New Label()
        lblEmail = New Label()
        lblTelepon = New Label()
        tabProfil = New TabPage()
        btnCetak = New Button()
        cbMusik = New CheckBox()
        cbMenggambar = New CheckBox()
        cbMemancing = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMembaca = New CheckBox()
        cbTravel = New CheckBox()
        cbCoding = New CheckBox()
        cbGaming = New CheckBox()
        gbPeran = New GroupBox()
        rbKetua = New RadioButton()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        btnBrowse = New Button()
        picFoto = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        tabInput.SuspendLayout()
        tabData.SuspendLayout()
        gbGender.SuspendLayout()
        tabKontak.SuspendLayout()
        tabProfil.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tabInput
        ' 
        tabInput.Controls.Add(tabData)
        tabInput.Controls.Add(tabKontak)
        tabInput.Controls.Add(tabProfil)
        tabInput.Dock = DockStyle.Fill
        tabInput.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tabInput.Location = New Point(0, 0)
        tabInput.Name = "tabInput"
        tabInput.SelectedIndex = 0
        tabInput.Size = New Size(807, 565)
        tabInput.TabIndex = 0
        ' 
        ' tabData
        ' 
        tabData.Controls.Add(lblKomunitas)
        tabData.Controls.Add(lblTanggal)
        tabData.Controls.Add(lblID)
        tabData.Controls.Add(lblNama)
        tabData.Controls.Add(txtID)
        tabData.Controls.Add(gbGender)
        tabData.Controls.Add(cbKomunitas)
        tabData.Controls.Add(dtpLahir)
        tabData.Controls.Add(txtNama)
        tabData.Location = New Point(4, 25)
        tabData.Name = "tabData"
        tabData.Padding = New Padding(3)
        tabData.Size = New Size(799, 536)
        tabData.TabIndex = 0
        tabData.Text = "Data Utama"
        tabData.UseVisualStyleBackColor = True
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Location = New Point(6, 158)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(69, 16)
        lblKomunitas.TabIndex = 10
        lblKomunitas.Text = "Komunitas"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(6, 108)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(90, 16)
        lblTanggal.TabIndex = 9
        lblTanggal.Text = "Tanggal Lahir"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(6, 57)
        lblID.Name = "lblID"
        lblID.Size = New Size(74, 16)
        lblID.TabIndex = 8
        lblID.Text = "ID Anggota"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(8, 14)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(44, 16)
        lblNama.TabIndex = 7
        lblNama.Text = "Nama"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(105, 57)
        txtID.Name = "txtID"
        txtID.Size = New Size(200, 22)
        txtID.TabIndex = 6
        ' 
        ' gbGender
        ' 
        gbGender.Controls.Add(rbPerempuan)
        gbGender.Controls.Add(rbLaki)
        gbGender.Location = New Point(11, 208)
        gbGender.Name = "gbGender"
        gbGender.Size = New Size(194, 116)
        gbGender.TabIndex = 5
        gbGender.TabStop = False
        gbGender.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(16, 75)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(95, 20)
        rbPerempuan.TabIndex = 11
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(16, 33)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(79, 20)
        rbLaki.TabIndex = 3
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' cbKomunitas
        ' 
        cbKomunitas.FormattingEnabled = True
        cbKomunitas.Items.AddRange(New Object() {"Anime", "Game", "Musik", "Fotografi", "Olahraga", "Teknologi"})
        cbKomunitas.Location = New Point(105, 158)
        cbKomunitas.Name = "cbKomunitas"
        cbKomunitas.Size = New Size(200, 24)
        cbKomunitas.TabIndex = 4
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(105, 102)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(200, 22)
        dtpLahir.TabIndex = 2
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(105, 11)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(200, 22)
        txtNama.TabIndex = 0
        ' 
        ' tabKontak
        ' 
        tabKontak.Controls.Add(txtAlamat)
        tabKontak.Controls.Add(txtEmail)
        tabKontak.Controls.Add(mtbTelepon)
        tabKontak.Controls.Add(lblAlamat)
        tabKontak.Controls.Add(lblEmail)
        tabKontak.Controls.Add(lblTelepon)
        tabKontak.Location = New Point(4, 25)
        tabKontak.Name = "tabKontak"
        tabKontak.Padding = New Padding(3)
        tabKontak.Size = New Size(799, 536)
        tabKontak.TabIndex = 1
        tabKontak.Text = "Kontak & Info"
        tabKontak.UseVisualStyleBackColor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(34, 207)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(195, 136)
        txtAlamat.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(170, 100)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(159, 22)
        txtEmail.TabIndex = 4
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(170, 30)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(100, 22)
        mtbTelepon.TabIndex = 3
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(34, 172)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(49, 16)
        lblAlamat.TabIndex = 2
        lblAlamat.Text = "Alamat"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(34, 103)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(41, 16)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.Location = New Point(34, 33)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(102, 16)
        lblTelepon.TabIndex = 0
        lblTelepon.Text = "Nomor Telepon"
        ' 
        ' tabProfil
        ' 
        tabProfil.Controls.Add(btnCetak)
        tabProfil.Controls.Add(cbMusik)
        tabProfil.Controls.Add(cbMenggambar)
        tabProfil.Controls.Add(cbMemancing)
        tabProfil.Controls.Add(cbOlahraga)
        tabProfil.Controls.Add(cbMembaca)
        tabProfil.Controls.Add(cbTravel)
        tabProfil.Controls.Add(cbCoding)
        tabProfil.Controls.Add(cbGaming)
        tabProfil.Controls.Add(gbPeran)
        tabProfil.Controls.Add(btnBrowse)
        tabProfil.Controls.Add(picFoto)
        tabProfil.Location = New Point(4, 25)
        tabProfil.Name = "tabProfil"
        tabProfil.Padding = New Padding(3)
        tabProfil.Size = New Size(799, 536)
        tabProfil.TabIndex = 2
        tabProfil.Text = "Profil & Aktivitas"
        tabProfil.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.AutoSize = True
        btnCetak.Location = New Point(292, 488)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(147, 26)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Simpan & Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Location = New Point(457, 427)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(61, 20)
        cbMusik.TabIndex = 13
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbMenggambar
        ' 
        cbMenggambar.AutoSize = True
        cbMenggambar.Location = New Point(457, 388)
        cbMenggambar.Name = "cbMenggambar"
        cbMenggambar.Size = New Size(107, 20)
        cbMenggambar.TabIndex = 12
        cbMenggambar.Text = "Menggambar"
        cbMenggambar.UseVisualStyleBackColor = True
        ' 
        ' cbMemancing
        ' 
        cbMemancing.AutoSize = True
        cbMemancing.Location = New Point(457, 349)
        cbMemancing.Name = "cbMemancing"
        cbMemancing.Size = New Size(96, 20)
        cbMemancing.TabIndex = 11
        cbMemancing.Text = "Memancing"
        cbMemancing.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(457, 313)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(82, 20)
        cbOlahraga.TabIndex = 10
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(457, 277)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(87, 20)
        cbMembaca.TabIndex = 9
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbTravel
        ' 
        cbTravel.AutoSize = True
        cbTravel.Location = New Point(457, 238)
        cbTravel.Name = "cbTravel"
        cbTravel.Size = New Size(65, 20)
        cbTravel.TabIndex = 8
        cbTravel.Text = "Travel"
        cbTravel.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(457, 201)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(69, 20)
        cbCoding.TabIndex = 7
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(457, 165)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(73, 20)
        cbGaming.TabIndex = 6
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(rbKetua)
        gbPeran.Controls.Add(rbAdmin)
        gbPeran.Controls.Add(rbAnggota)
        gbPeran.Location = New Point(18, 206)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(238, 171)
        gbPeran.TabIndex = 2
        gbPeran.TabStop = False
        gbPeran.Text = "Peran"
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(34, 39)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(59, 20)
        rbKetua.TabIndex = 3
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(34, 87)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(63, 20)
        rbAdmin.TabIndex = 4
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(34, 137)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(76, 20)
        rbAnggota.TabIndex = 5
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(87, 162)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 23)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picFoto
        ' 
        picFoto.Location = New Point(38, 16)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(173, 128)
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FormInput
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(807, 565)
        Controls.Add(tabInput)
        Name = "FormInput"
        Text = "FormInput"
        tabInput.ResumeLayout(False)
        tabData.ResumeLayout(False)
        tabData.PerformLayout()
        gbGender.ResumeLayout(False)
        gbGender.PerformLayout()
        tabKontak.ResumeLayout(False)
        tabKontak.PerformLayout()
        tabProfil.ResumeLayout(False)
        tabProfil.PerformLayout()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tabInput As TabControl
    Friend WithEvents tabData As TabPage
    Friend WithEvents tabKontak As TabPage
    Friend WithEvents gbGender As GroupBox
    Friend WithEvents cbKomunitas As ComboBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents tabProfil As TabPage
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents cbMemancing As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbTravel As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
