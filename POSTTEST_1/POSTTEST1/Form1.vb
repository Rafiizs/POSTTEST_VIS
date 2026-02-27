Public Class Form1
    Dim total As Double
    Dim jumlah As Integer
    Dim ipk As Double

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipSemester As Double

        If Double.TryParse(txtIP.Text, ipSemester) Then

            total = total + ipSemester
            jumlah = jumlah + 1
            ipk = total / jumlah
            txtIPK.Text = ipk

            If ipk >= 2 And ipk <= 2.75 Then
                lblPredikat.Text = "cukup"
            ElseIf ipk >= 2.76 And ipk <= 3 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            End If

            txtIP.Text = ""

        Else
            MessageBox.Show("Input Harus Angka")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        total = 0
        jumlah = 0
        ipk = 0

        txtIP.Text = ""
        txtIPK.Text = ""
        lblPredikat.Text = ""

    End Sub

    Private Sub txtIPK_TextChanged(sender As Object, e As EventArgs) Handles txtIPK.TextChanged

    End Sub
End Class
