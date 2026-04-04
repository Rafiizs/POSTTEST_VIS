Public Class FormInput

    Public fotoPath As String
    Public hobby As String = ""

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        OpenFileDialog1.Filter = "Image File|*.jpg;*.png;*.jpeg"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then

            picFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            fotoPath = OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub


    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub



    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtID.Text = "" Or txtEmail.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        Dim hobby As String = ""

        If cbGaming.Checked Then hobby &= "Gaming "
        If cbCoding.Checked Then hobby &= "Coding "
        If cbTravel.Checked Then hobby &= "Travel "
        If cbMembaca.Checked Then hobby &= "Membaca "
        If cbOlahraga.Checked Then hobby &= "Olahraga "
        If cbMemancing.Checked Then hobby &= "Memancing "
        If cbMenggambar.Checked Then hobby &= "Menggambar "
        If cbMusik.Checked Then hobby &= "Musik "

        Dim kartu As New FormKartu(
            txtNama.Text,
            txtID.Text,
            cbKomunitas.Text,
            mtbTelepon.Text,
            hobby,
            picFoto.Image)

        kartu.Show()


    End Sub

End Class