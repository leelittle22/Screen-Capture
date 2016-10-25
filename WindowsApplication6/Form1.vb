
Imports System.Net
Imports System.Text
Imports System.IO

Public Class Form1
    Private Sub VisceralTheme1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VisceralTheme1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub VisceralGroupBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VisceralTheme1_Click_2(sender As Object, e As EventArgs) Handles VisceralTheme1.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub VisceralTextBox2_Click(sender As Object, e As EventArgs) Handles VisceralTextBox2.Click

    End Sub

    Private Sub VisceralButton2_Click(sender As Object, e As EventArgs) Handles VisceralButton2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim save As New SaveFileDialog
        save.Title = "Save Capture"
        save.FileName = "Screen Shot"
        save.Filter = "png | *.png"



        If save.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            PictureBox2.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Png)
        End If
    End Sub

    Private Sub VisceralButton1_Click(sender As Object, e As EventArgs) Handles VisceralButton1.Click
        Me.Opacity = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        PictureBox2.Image = screenshot
        Timer1.Enabled = False
        Me.Opacity = 100
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        PictureBox2.Image = Nothing
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub VisceralButton3_Click(sender As Object, e As EventArgs) Handles VisceralButton3.Click

        Dim filepath As New OpenFileDialog

        filepath.Title = "Open capture"
        filepath.FileName = "Screenshot"
        filepath.Filter = "png | *.png"

        If filepath.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            VisceralTextBox2.Text = (Path.GetDirectoryName(filepath.FileName))
        End If

        VisceralTextBox2.Text = (filepath.FileName)
        Dim url As String = UploadImage(VisceralTextBox2.Text) 'path to the image
        VisceralTextBox1.Text = (url)
        Process.Start(VisceralTextBox1.Text)

    End Sub

    Dim ClientId As String = "8aafb39dd9cf0fd"

    Public Function UploadImage(ByVal image As String)
        Dim w As New WebClient()
        w.Headers.Add("Authorization", "Client-ID " & ClientId)
        Dim Keys As New System.Collections.Specialized.NameValueCollection
        Try
            Keys.Add("image", Convert.ToBase64String(File.ReadAllBytes(image)))
            Dim responseArray As Byte() = w.UploadValues("https://api.imgur.com/3/image", Keys)
            Dim result = Encoding.ASCII.GetString(responseArray)
            Dim reg As New System.Text.RegularExpressions.Regex("link"":""(.*?)""")
            Dim match As RegularExpressions.Match = reg.Match(result)
            Dim url As String = match.ToString.Replace("link"":""", "").Replace("""", "").Replace("\/", "/")
            Return url
        Catch s As Exception
            MessageBox.Show("Something went wrong. " & s.Message)
            Return "Failed!"
        End Try
    End Function



    Private Sub VisceralTextBox1_Click(sender As Object, e As EventArgs) Handles VisceralTextBox1.Click

    End Sub
End Class