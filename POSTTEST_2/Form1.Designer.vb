Public Class Form1
    Sub TampilBuku()

        lstBuku.Items.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            lstBuku.Items.Add(judulBuku(i) & " (" & genreBuku(i) & ")")
        Next

    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim judul As String = txtJudul.Text
        Dim genre As String = txtGenre.Text

        If judul = "" Or genre = "" Then
            MessageBox.Show("Data belum lengkap")
            Exit Sub
        End If

        TambahBuku(judul, genre)

        TampilBuku()

        txtJudul.Clear()
        txtGenre.Clear()

    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim judul As String = txtHapus.Text

        Dim index As Integer = CariBuku(judul)

        If index = -1 Then
            MessageBox.Show("Buku tidak ditemukan")
        Else

            For i As Integer = index To jumlahBuku - 2
                judulBuku(i) = judulBuku(i + 1)
                genreBuku(i) = genreBuku(i + 1)
            Next

            jumlahBuku -= 1

            MessageBox.Show("Buku berhasil dihapus")

        End If

        TampilBuku()

        txtHapus.Clear()

    End Sub

End Class