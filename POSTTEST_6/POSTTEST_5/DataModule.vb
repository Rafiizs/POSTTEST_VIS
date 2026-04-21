Imports MySqlConnector

Module DataModule

    ' READ
    Public Function GetAllManga() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT kodeManga, judul, genre FROM tbmanga ORDER BY kodeManga ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal tampil: " & ex.Message)
        End Try

        Return dt
    End Function

    ' SEARCH
    Public Function SearchManga(keyword As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String =
                "SELECT kodeManga, judul, genre FROM tbmanga " &
                "WHERE kodeManga LIKE @key OR judul LIKE @key OR genre LIKE @key"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal search")
        End Try

        Return dt
    End Function

    ' CEK KODE
    Public Function KodeAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbmanga WHERE kodeManga=@kode"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using

        Catch ex As Exception
            Return True
        End Try
    End Function

    ' CREATE
    Public Function SimpanManga(kode As String, judul As String, genre As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbmanga VALUES (@kode,@judul,@genre)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal simpan")
            Return False
        End Try
    End Function

    ' UPDATE
    Public Function UbahManga(kode As String, judul As String, genre As String) As Boolean
        Try
            Dim query As String = "UPDATE tbmanga SET judul=@judul, genre=@genre WHERE kodeManga=@kode"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal ubah")
            Return False
        End Try
    End Function

    ' DELETE
    Public Function HapusManga(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbmanga WHERE kodeManga=@kode"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal hapus")
            Return False
        End Try
    End Function

    Public Function GetAllChapter() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String =
                "SELECT tbchapter.kodeChapter, tbmanga.judul AS Manga, " &
                "tbchapter.judulChapter, tbchapter.jumlahHalaman, tbchapter.tanggalRilis " &
                "FROM tbchapter " &
                "INNER JOIN tbmanga ON tbchapter.kodeManga = tbmanga.kodeManga"

            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal tampil data")
        End Try

        Return dt
    End Function

    Public Function SearchChapter(keyword As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String =
                "SELECT tbchapter.kodeChapter, tbmanga.judul AS Manga, " &
                "tbchapter.judulChapter, tbchapter.jumlahHalaman, tbchapter.tanggalRilis " &
                "FROM tbchapter " &
                "INNER JOIN tbmanga ON tbchapter.kodeManga = tbmanga.kodeManga " &
                "WHERE tbchapter.judulChapter LIKE @key"

            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal search")
        End Try

        Return dt
    End Function

    Public Function SimpanChapter(kode As String, kodeManga As String, judul As String, halaman As Integer, tanggal As Date) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbchapter VALUES (@kode,@kodeManga,@judul,@halaman,@tanggal)"

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@kodeManga", kodeManga)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@halaman", halaman)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan")
            Return False
        End Try
    End Function

    Public Function UbahChapter(kode As String, kodeManga As String, judul As String, halaman As Integer, tanggal As Date) As Boolean
        Try
            Dim query As String =
                "UPDATE tbchapter SET kodeManga=@kodeManga, judulChapter=@judul, jumlahHalaman=@halaman, tanggalRilis=@tanggal WHERE kodeChapter=@kode"

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@kodeManga", kodeManga)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@halaman", halaman)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal ubah")
            Return False
        End Try
    End Function

    Public Function HapusChapter(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbchapter WHERE kodeChapter=@kode"

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal hapus")
            Return False
        End Try
    End Function

End Module