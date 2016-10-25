<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.VisceralTheme1 = New WindowsApplication6.VisceralTheme()
        Me.VisceralTextBox4 = New WindowsApplication6.VisceralTextBox()
        Me.VisceralTextBox3 = New WindowsApplication6.VisceralTextBox()
        Me.VisceralTextBox2 = New WindowsApplication6.VisceralTextBox()
        Me.VisceralTextBox1 = New WindowsApplication6.VisceralTextBox()
        Me.VisceralControlBox1 = New WindowsApplication6.VisceralControlBox()
        Me.VisceralTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VisceralTheme1
        '
        Me.VisceralTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.VisceralTheme1.Controls.Add(Me.VisceralTextBox4)
        Me.VisceralTheme1.Controls.Add(Me.VisceralTextBox3)
        Me.VisceralTheme1.Controls.Add(Me.VisceralTextBox2)
        Me.VisceralTheme1.Controls.Add(Me.VisceralTextBox1)
        Me.VisceralTheme1.Controls.Add(Me.VisceralControlBox1)
        Me.VisceralTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisceralTheme1.Location = New System.Drawing.Point(0, 0)
        Me.VisceralTheme1.Name = "VisceralTheme1"
        Me.VisceralTheme1.Size = New System.Drawing.Size(284, 261)
        Me.VisceralTheme1.TabIndex = 0
        Me.VisceralTheme1.Text = "Help"
        '
        'VisceralTextBox4
        '
        Me.VisceralTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.VisceralTextBox4.ForeColor = System.Drawing.Color.Silver
        Me.VisceralTextBox4.Location = New System.Drawing.Point(13, 139)
        Me.VisceralTextBox4.MaxLength = 32767
        Me.VisceralTextBox4.Name = "VisceralTextBox4"
        Me.VisceralTextBox4.Size = New System.Drawing.Size(171, 24)
        Me.VisceralTextBox4.TabIndex = 4
        Me.VisceralTextBox4.Text = "The image will be uploaded "
        Me.VisceralTextBox4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.VisceralTextBox4.UseSystemPasswordChar = False
        '
        'VisceralTextBox3
        '
        Me.VisceralTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.VisceralTextBox3.ForeColor = System.Drawing.Color.Silver
        Me.VisceralTextBox3.Location = New System.Drawing.Point(13, 109)
        Me.VisceralTextBox3.MaxLength = 32767
        Me.VisceralTextBox3.Name = "VisceralTextBox3"
        Me.VisceralTextBox3.Size = New System.Drawing.Size(171, 24)
        Me.VisceralTextBox3.TabIndex = 3
        Me.VisceralTextBox3.Text = "You will be given a link "
        Me.VisceralTextBox3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.VisceralTextBox3.UseSystemPasswordChar = False
        '
        'VisceralTextBox2
        '
        Me.VisceralTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.VisceralTextBox2.ForeColor = System.Drawing.Color.Silver
        Me.VisceralTextBox2.Location = New System.Drawing.Point(13, 78)
        Me.VisceralTextBox2.MaxLength = 32767
        Me.VisceralTextBox2.Name = "VisceralTextBox2"
        Me.VisceralTextBox2.Size = New System.Drawing.Size(171, 24)
        Me.VisceralTextBox2.TabIndex = 2
        Me.VisceralTextBox2.Text = "Click upload and select file"
        Me.VisceralTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.VisceralTextBox2.UseSystemPasswordChar = False
        '
        'VisceralTextBox1
        '
        Me.VisceralTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.VisceralTextBox1.ForeColor = System.Drawing.Color.Silver
        Me.VisceralTextBox1.Location = New System.Drawing.Point(13, 48)
        Me.VisceralTextBox1.MaxLength = 32767
        Me.VisceralTextBox1.Name = "VisceralTextBox1"
        Me.VisceralTextBox1.Size = New System.Drawing.Size(135, 24)
        Me.VisceralTextBox1.TabIndex = 1
        Me.VisceralTextBox1.Text = "Imgur "
        Me.VisceralTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.VisceralTextBox1.UseSystemPasswordChar = False
        '
        'VisceralControlBox1
        '
        Me.VisceralControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisceralControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.VisceralControlBox1.Location = New System.Drawing.Point(197, 3)
        Me.VisceralControlBox1.Name = "VisceralControlBox1"
        Me.VisceralControlBox1.Size = New System.Drawing.Size(75, 23)
        Me.VisceralControlBox1.TabIndex = 0
        Me.VisceralControlBox1.Text = "VisceralControlBox1"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.VisceralTheme1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.VisceralTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VisceralTheme1 As VisceralTheme
    Friend WithEvents VisceralControlBox1 As VisceralControlBox
    Friend WithEvents VisceralTextBox4 As VisceralTextBox
    Friend WithEvents VisceralTextBox3 As VisceralTextBox
    Friend WithEvents VisceralTextBox2 As VisceralTextBox
    Friend WithEvents VisceralTextBox1 As VisceralTextBox
End Class
