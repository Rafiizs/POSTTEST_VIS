<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
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
        picFoto = New PictureBox()
        lblJudul = New Label()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblKontak = New Label()
        lblHobby = New Label()
        btnTutup = New Button()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(45, 141)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(186, 152)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(279, 12)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(191, 25)
        lblJudul.TabIndex = 1
        lblJudul.Text = "KARTU KOMUNITAS"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(425, 141)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(45, 15)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama :"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(425, 177)
        lblID.Name = "lblID"
        lblID.Size = New Size(24, 15)
        lblID.TabIndex = 3
        lblID.Text = "ID :"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Location = New Point(425, 210)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(70, 15)
        lblKomunitas.TabIndex = 4
        lblKomunitas.Text = "Komunitas :"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.Location = New Point(425, 244)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(50, 15)
        lblKontak.TabIndex = 5
        lblKontak.Text = "Kontak :"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Location = New Point(425, 278)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(49, 15)
        lblHobby.TabIndex = 6
        lblHobby.Text = "Hobby :"
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(325, 402)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(75, 23)
        btnTutup.TabIndex = 7
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnTutup)
        Controls.Add(lblHobby)
        Controls.Add(lblKontak)
        Controls.Add(lblKomunitas)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(lblJudul)
        Controls.Add(picFoto)
        Name = "FormKartu"
        Text = "FormKartu"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents btnTutup As Button
End Class
