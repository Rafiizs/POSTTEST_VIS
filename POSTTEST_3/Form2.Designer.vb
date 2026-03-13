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
        picFoto2 = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTanggal = New Label()
        lblTelp = New Label()
        lblAlamat = New Label()
        lblJK = New Label()
        lblHobby = New Label()
        CType(picFoto2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picFoto2
        ' 
        picFoto2.BorderStyle = BorderStyle.FixedSingle
        picFoto2.Location = New Point(12, 12)
        picFoto2.Name = "picFoto2"
        picFoto2.Size = New Size(248, 397)
        picFoto2.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto2.TabIndex = 0
        picFoto2.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(276, 31)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(53, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "Label1"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(276, 87)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(53, 20)
        lblUmur.TabIndex = 1
        lblUmur.Text = "Label1"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(276, 144)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(53, 20)
        lblTanggal.TabIndex = 1
        lblTanggal.Text = "Label1"
        ' 
        ' lblTelp
        ' 
        lblTelp.AutoSize = True
        lblTelp.Location = New Point(276, 205)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(53, 20)
        lblTelp.TabIndex = 1
        lblTelp.Text = "Label1"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(276, 268)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(53, 20)
        lblAlamat.TabIndex = 1
        lblAlamat.Text = "Label1"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Location = New Point(276, 334)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(53, 20)
        lblJK.TabIndex = 1
        lblJK.Text = "Label1"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Location = New Point(276, 389)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(53, 20)
        lblHobby.TabIndex = 1
        lblHobby.Text = "Label1"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.doge_memes_face_dog_wallpaper_thumb
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(676, 436)
        Controls.Add(lblHobby)
        Controls.Add(lblJK)
        Controls.Add(lblAlamat)
        Controls.Add(lblTelp)
        Controls.Add(lblTanggal)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(picFoto2)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kartu Data"
        CType(picFoto2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto2 As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblTelp As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblHobby As Label
End Class
