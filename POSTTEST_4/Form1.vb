Public Class FormMenu

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        FormInput.Show()
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        Dim hobby As String = ""

        If FormInput.cbGaming.Checked Then hobby &= "Gaming "
        If FormInput.cbCoding.Checked Then hobby &= "Coding "
        If FormInput.cbTravel.Checked Then hobby &= "Travel "
        If FormInput.cbMembaca.Checked Then hobby &= "Membaca "
        If FormInput.cbOlahraga.Checked Then hobby &= "Olahraga "
        If FormInput.cbMemancing.Checked Then hobby &= "Memancing "
        If FormInput.cbMenggambar.Checked Then hobby &= "Menggambar "
        If FormInput.cbMusik.Checked Then hobby &= "Musik "

        Dim kartu As New FormKartu(
        FormInput.txtNama.Text,
        FormInput.txtID.Text,
        FormInput.cbKomunitas.Text,
        FormInput.mtbTelepon.Text,
        hobby,
        FormInput.picFoto.Image)

        kartu.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim keluar As DialogResult
        keluar = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo)

        If keluar = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click

        SaveFileDialog1.Filter = "Text File|*.txt"

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then

            Dim sw As New IO.StreamWriter(SaveFileDialog1.FileName)

            sw.WriteLine(FormInput.txtNama.Text)
            sw.WriteLine(FormInput.txtID.Text)
            sw.WriteLine(FormInput.cbKomunitas.Text)
            sw.WriteLine(FormInput.mtbTelepon.Text)
            sw.WriteLine(FormInput.hobby)
            sw.WriteLine(FormInput.fotoPath)


            sw.Close()

            MessageBox.Show("Data berhasil disimpan")

        End If

    End Sub

    Private Sub KeluarDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarDataToolStripMenuItem.Click

        OpenFileDialog1.Filter = "Text File|*.txt"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then

            Dim sr As New IO.StreamReader(OpenFileDialog1.FileName)

            Dim nama As String = sr.ReadLine()
            Dim id As String = sr.ReadLine()
            Dim komunitas As String = sr.ReadLine()
            Dim kontak As String = sr.ReadLine()
            Dim hobby As String = sr.ReadLine()
            Dim foto As String = sr.ReadLine()

            sr.Close()

            Dim kartu As New FormKartu(nama, id, komunitas, kontak, hobby, FormInput.picFoto.Image)
            kartu.Show()

        End If

    End Sub
End Class
