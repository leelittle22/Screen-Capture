Public Class Form2
    Private Sub VisceralTheme1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Opacity = 0


        Dim area As Rectangle
        Dim capture As System.Drawing.Bitmap
        Dim graph As Graphics

        area = Me.Bounds
        capture = New System.Drawing.Bitmap(Me.Bounds.Width, Me.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(capture)
        graph.CopyFromScreen(area.X, area.Y, 0, 0, area.Size, CopyPixelOperation.SourceCopy)
        Form1.PictureBox2.Image = capture

        Form1.Show()





    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VisceralTheme1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub VisceralControlBox1_Click(sender As Object, e As EventArgs) Handles VisceralControlBox1.Click

    End Sub
End Class