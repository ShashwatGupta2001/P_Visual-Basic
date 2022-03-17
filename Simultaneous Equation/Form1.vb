Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal s As System.EventArgs) Handles Button1.Click
        Dim v1, v2 As Char
        v1 = TextBox1.Text
        Label4.Text = v1
        Label6.Text = v1
        Label8.Text = v1
        v2 = TextBox2.Text
        Label5.Text = v2
        Label7.Text = v2
        Label9.Text = v2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal s As System.EventArgs) Handles Button2.Click
        Dim a, b, c, d, e, f, r1, r2 As Double
        a = TextBox3.Text
        b = TextBox4.Text
        c = TextBox5.Text
        d = TextBox6.Text
        e = TextBox7.Text
        f = TextBox8.Text
        r1 = ((c * e) - (f * b)) / ((a * e) - (d * b))
        r2 = ((c * d) - (f * a)) / ((b * d) - (e * a))
        Label10.Text = r1
        Label11.Text = r2
    End Sub
End Class
