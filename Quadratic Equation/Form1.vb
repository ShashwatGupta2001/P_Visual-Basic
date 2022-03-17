Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, D, r1, r2 As Double
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)
        D = Math.Sqrt((b ^ 2) - (4 * a * c))
        r1 = ((0 - b) + D) / (2 * a)
        r2 = ((0 - b) - D) / (2 * a)
        Label8.Text = r1
        Label9.Text = r2
        Label10.Text = D
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LinkLabel1.Text = "Back...."
        LinkLabel1.Links.Add(0, 8, "file://C:/Documents and Settings/Shashwat Gupta/My Documents/Shashwat/Projects/HTML/Internet/Internet.html")
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub
End Class
