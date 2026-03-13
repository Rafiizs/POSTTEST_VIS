Public Class Form1

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim buka As New OpenFileDialog

        If buka.ShowDialog = DialogResult.OK Then
            picFoto.ImageLocation = buka.FileName
        End If

    End Sub


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        'cek input kosong
        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTelp.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        'kirim data ke form2
        Form2.lblNama.Text = "Nama : " & txtNama.Text
        Form2.lblUmur.Text = "Umur : " & txtUmur.Text
        Form2.lblTanggal.Text = "Tanggal Lahir : " & dtTanggal.Text
        Form2.lblTelp.Text = "No Telepon : " & txtTelp.Text
        Form2.lblAlamat.Text = "Alamat : " & txtAlamat.Text

        'jenis kelamin
        If rbLaki.Checked = True Then
            Form2.lblJK.Text = "Jenis Kelamin : Laki - laki"
        End If

        If rbPerempuan.Checked = True Then
            Form2.lblJK.Text = "Jenis Kelamin : Perempuan"
        End If


        'hobby
        Dim hobby As String = ""

        If cbGaming.Checked Then
            hobby = hobby & "Gaming "
        End If

        If cbCoding.Checked Then
            hobby = hobby & "Coding "
        End If

        If cbTravel.Checked Then
            hobby = hobby & "Travel "
        End If

        If cbMembaca.Checked Then
            hobby = hobby & "Membaca "
        End If

        If cbMenulis.Checked Then
            hobby = hobby & "Menulis "
        End If

        If cbOlahraga.Checked Then
            hobby = hobby & "Olahraga "
        End If

        If cbMemancing.Checked Then
            hobby = hobby & "Memancing "
        End If

        If cbMenggambar.Checked Then
            hobby = hobby & "Menggambar "
        End If

        If cbMenyanyi.Checked Then
            hobby = hobby & "Menyanyi "
        End If

        If cbMenari.Checked Then
            hobby = hobby & "Menari "
        End If

        Form2.lblHobby.Text = "Hobby : " & hobby

        'kirim foto
        Form2.picFoto2.ImageLocation = picFoto.ImageLocation

        'tampilkan form2
        Form2.Show()

    End Sub

End Class