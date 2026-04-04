Public Class FormKartu

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblJudul.Text = "KARTU KOMUNITAS"

    End Sub


    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click

        Me.Close()

    End Sub


    Public Sub New(nama As String, id As String, komunitas As String, kontak As String, hobby As String, foto As Image)

        InitializeComponent()

        lblNama.Text = "Nama : " & nama
        lblID.Text = "ID : " & id
        lblKomunitas.Text = "Komunitas : " & komunitas
        lblKontak.Text = "Kontak : " & kontak
        lblHobby.Text = "Hobby : " & hobby

        picFoto.Image = foto

    End Sub

End Class