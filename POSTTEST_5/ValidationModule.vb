Module ValidationModule

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiManga(ep As ErrorProvider, txtKode As TextBox, txtJudul As TextBox, txtGenre As TextBox) As Boolean
        Dim a = ValidasiTextBox(ep, txtKode, "Kode kosong")
        Dim b = ValidasiTextBox(ep, txtJudul, "Judul kosong")
        Dim c = ValidasiTextBox(ep, txtGenre, "Genre kosong")

        Return a And b And c
    End Function

End Module