Module Module1
    Public judulBuku(100) As String
    Public genreBuku(100) As String
    Public jumlahBuku As Integer = 0

    Public Sub TambahBuku(judul As String, genre As String)
        If jumlahBuku < 100 Then
            judulBuku(jumlahBuku) = judul
            genreBuku(jumlahBuku) = genre
            jumlahBuku += 1
        End If
    End Sub

    Public Function CariBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If judulBuku(i).ToLower = judul.ToLower Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module
