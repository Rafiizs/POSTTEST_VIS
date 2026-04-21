Public Class Form1

    Sub Kosong()
        txtKode.Clear()
        txtJudul.Clear()
        txtGenre.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKode.Focus()
    End Sub

    Sub Tampil()
        dgvManga.DataSource = GetAllManga()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
        Kosong()
    End Sub

    ' SIMPAN
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiManga(ErrorProvider1, txtKode, txtJudul, txtGenre) Then Exit Sub

        If KodeAda(txtKode.Text) Then
            MessageBox.Show("Kode sudah ada")
            Exit Sub
        End If

        If SimpanManga(txtKode.Text, txtJudul.Text, txtGenre.Text) Then
            MessageBox.Show("Berhasil simpan")
            Tampil()
            Kosong()
        End If
    End Sub

    ' UBAH
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If UbahManga(txtKode.Text, txtJudul.Text, txtGenre.Text) Then
            MessageBox.Show("Berhasil ubah")
            Tampil()
            Kosong()
        End If
    End Sub

    ' HAPUS
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If HapusManga(txtKode.Text) Then
            MessageBox.Show("Berhasil hapus")
            Tampil()
            Kosong()
        End If
    End Sub

    ' BATAL
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        Tampil()
    End Sub

    ' KLIK DATA
    Private Sub dgvManga_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvManga.CellClick
        If e.RowIndex >= 0 Then
            txtKode.Text = dgvManga.Rows(e.RowIndex).Cells("kodeManga").Value.ToString()
            txtJudul.Text = dgvManga.Rows(e.RowIndex).Cells("judul").Value.ToString()
            txtGenre.Text = dgvManga.Rows(e.RowIndex).Cells("genre").Value.ToString()
        End If
    End Sub

    ' SEARCH
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            Tampil()
        Else
            dgvManga.DataSource = SearchManga(txtSearch.Text)
        End If
    End Sub

    Private Sub DataChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuChapter.Click
        Dim f As New Form2
        f.ShowDialog()
    End Sub

End Class