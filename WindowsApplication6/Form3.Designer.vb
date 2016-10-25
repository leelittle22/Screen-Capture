<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.VisceralTheme1 = New WindowsApplication6.VisceralTheme()
        Me.VisceralGroupBox1 = New WindowsApplication6.VisceralGroupBox()
        Me.VisceralTextBox1 = New WindowsApplication6.VisceralTextBox()
        Me.VisceralControlBox1 = New WindowsApplication6.VisceralControlBox()
        Me.VisceralTextBox2 = New WindowsApplication6.VisceralTextBox()
        Me.VisceralTheme1.SuspendLayout()
        Me.VisceralGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VisceralTheme1
        '
        Me.VisceralTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.VisceralTheme1.Controls.Add(Me.VisceralGroupBox1)
        Me.VisceralTheme1.Controls.Add(Me.VisceralControlBox1)
        Me.VisceralTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisceralTheme1.Location = New System.Drawing.Point(0, 0)
        Me.VisceralTheme1.Name = "VisceralTheme1"
        Me.VisceralTheme1.Size = New System.Drawing.Size(284, 261)
        Me.VisceralTheme1.TabIndex = 0
        Me.VisceralTheme1.Text = "About"
        '
        'VisceralGroupBox1
        '
        Me.VisceralGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.VisceralGroupBox1.Controls.Add(Me.VisceralTextBox2)
        Me.VisceralGroupBox1.Controls.Add(Me.VisceralTextBox1)
        Me.VisceralGroupBox1.Image = Nothing
        Me.VisceralGroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.VisceralGroupBox1.Name = "VisceralGroupBox1"
        Me.VisceralGroupBox1.Size = New System.Drawing.Size(260, 207)
        Me.VisceralGroupBox1.TabIndex = 1
        Me.VisceralGroupBox1.Text = "The Gaming Duck Screen Capture v1.4 "
        '
        'VisceralTextBox1
        '
        Me.VisceralTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.VisceralTextBox1.ForeColor = System.Drawing.Color.White
        Me.VisceralTextBox1.Location = New System.Drawing.Point(3, 34)
        Me.VisceralTextBox1.MaxLength = 32767
        Me.VisceralTextBox1.Name = "VisceralTextBox1"
        Me.VisceralTextBox1.Size = New System.Drawing.Size(206, 24)
        Me.VisceralTextBox1.TabIndex = 0
        Me.VisceralTextBox1.Text = "Copyright TheGamingDuck "
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
        'VisceralTextBox2
        '
        Me.VisceralTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.VisceralTextBox2.ForeColor = System.Drawing.Color.White
        Me.VisceralTextBox2.Location = New System.Drawing.Point(4, 65)
        Me.VisceralTextBox2.MaxLength = 32767
        Me.VisceralTextBox2.Name = "VisceralTextBox2"
        Me.VisceralTextBox2.Size = New System.Drawing.Size(205, 24)
        Me.VisceralTextBox2.TabIndex = 1
        Me.VisceralTextBox2.Text = "www.thegamingduck.com"
        Me.VisceralTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.VisceralTextBox2.UseSystemPasswordChar = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.VisceralTheme1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.VisceralTheme1.ResumeLayout(False)
        Me.VisceralGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VisceralTheme1 As VisceralTheme
    Friend WithEvents VisceralControlBox1 As VisceralControlBox
    Friend WithEvents VisceralGroupBox1 As VisceralGroupBox
    Friend WithEvents VisceralTextBox1 As VisceralTextBox
    Friend WithEvents VisceralTextBox2 As VisceralTextBox
End Class
