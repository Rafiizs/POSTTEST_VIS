Public Class Form2

    Sub Kosong()
        txtKodeChapter.Clear()
        cbManga.SelectedIndex = -1
        txtJudulChapter.Clear()
        txtHalaman.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKodeChapter.Focus()
    End Sub

    Sub Tampil()
        dgvChapter.DataSource = GetAllChapter()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbManga.DataSource = GetAllManga()
        cbManga.DisplayMember = "judul"
        cbManga.ValueMember = "kodeManga"

        Tampil()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim kode = txtKodeChapter.Text
        Dim kodeManga = cbManga.SelectedValue.ToString()
        Dim judul = txtJudulChapter.Text
        Dim halaman = Convert.ToInt32(txtHalaman.Text)
        Dim tanggal = dtRilis.Value

        If SimpanChapter(kode, kodeManga, judul, halaman, tanggal) Then
            MessageBox.Show("Berhasil simpan")
            Tampil()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If UbahChapter(txtKodeChapter.Text,
                       cbManga.SelectedValue.ToString(),
                       txtJudulChapter.Text,
                       Convert.ToInt32(txtHalaman.Text),
                       dtRilis.Value) Then

            MessageBox.Show("Berhasil ubah")
            Tampil()
            Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If HapusChapter(txtKodeChapter.Text) Then
            MessageBox.Show("Berhasil hapus")
            Tampil()
            Kosong()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        Tampil()
    End Sub

    Private Sub dgvChapter_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChapter.CellClick
        If e.RowIndex >= 0 Then
            txtKodeChapter.Text = dgvChapter.Rows(e.RowIndex).Cells(0).Value.ToString()
            cbManga.Text = dgvChapter.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtJudulChapter.Text = dgvChapter.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtHalaman.Text = dgvChapter.Rows(e.RowIndex).Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            Tampil()
        Else
            dgvChapter.DataSource = SearchChapter(txtSearch.Text)
        End If
    End Sub

End Class