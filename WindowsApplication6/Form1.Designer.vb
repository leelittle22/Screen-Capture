<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.VisceralTheme1 = New WindowsApplication6.VisceralTheme()
        Me.VisceralTextBox1 = New WindowsApplication6.VisceralTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.VisceralButton3 = New WindowsApplication6.VisceralButton()
        Me.VisceralTextBox2 = New WindowsApplication6.VisceralTextBox()
        Me.VisceralButton2 = New WindowsApplication6.VisceralButton()
        Me.VisceralButton1 = New WindowsApplication6.VisceralButton()
        Me.VisceralControlBox1 = New WindowsApplication6.VisceralControlBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisceralTheme1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'VisceralTheme1
        '
        Me.VisceralTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.VisceralTheme1.Controls.Add(Me.VisceralTextBox1)
        Me.VisceralTheme1.Controls.Add(Me.PictureBox2)
        Me.VisceralTheme1.Controls.Add(Me.VisceralButton3)
        Me.VisceralTheme1.Controls.Add(Me.VisceralTextBox2)
        Me.VisceralTheme1.Controls.Add(Me.VisceralButton2)
        Me.VisceralTheme1.Controls.Add(Me.VisceralButton1)
        Me.VisceralTheme1.Controls.Add(Me.VisceralControlBox1)
        Me.VisceralTheme1.Controls.Add(Me.MenuStrip1)
        Me.VisceralTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisceralTheme1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VisceralTheme1.Location = New System.Drawing.Point(0, 0)
        Me.VisceralTheme1.Name = "VisceralTheme1"
        Me.VisceralTheme1.Size = New System.Drawing.Size(342, 381)
        Me.VisceralTheme1.TabIndex = 0
        Me.VisceralTheme1.Text = "TheGamingDuck ScreenCapture V1.4"
        '
        'VisceralTextBox1
        '
        Me.VisceralTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.VisceralTextBox1.ForeColor = System.Drawing.Color.White
        Me.VisceralTextBox1.Location = New System.Drawing.Point(12, 340)
        Me.VisceralTextBox1.MaxLength = 32767
        Me.VisceralTextBox1.Name = "VisceralTextBox1"
        Me.VisceralTextBox1.Size = New System.Drawing.Size(180, 24)
        Me.VisceralTextBox1.TabIndex = 11
        Me.VisceralTextBox1.Text = "Imgur Link"
        Me.VisceralTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.VisceralTextBox1.UseSystemPasswordChar = False
        '
        'PictureBox2
        '
        Me.PictureBox2.AccessibleName = "PictureBox2"
        Me.PictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(12, 67)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(309, 228)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'VisceralButton3
        '
        Me.VisceralButton3.AccessibleName = "UploadImage"
        Me.VisceralButton3.BackColor = System.Drawing.Color.Transparent
        Me.VisceralButton3.Location = New System.Drawing.Point(199, 340)
        Me.VisceralButton3.Name = "VisceralButton3"
        Me.VisceralButton3.Size = New System.Drawing.Size(123, 25)
        Me.VisceralButton3.TabIndex = 8
        Me.VisceralButton3.Text = "Upload"
        '
        'VisceralTextBox2
        '
        Me.VisceralTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.VisceralTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisceralTextBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VisceralTextBox2.Location = New System.Drawing.Point(139, 301)
        Me.VisceralTextBox2.MaxLength = 32767
        Me.VisceralTextBox2.Name = "VisceralTextBox2"
        Me.VisceralTextBox2.Size = New System.Drawing.Size(53, 25)
        Me.VisceralTextBox2.TabIndex = 7
        Me.VisceralTextBox2.Text = "File Path"
        Me.VisceralTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.VisceralTextBox2.UseSystemPasswordChar = False
        Me.VisceralTextBox2.Visible = False
        '
        'VisceralButton2
        '
        Me.VisceralButton2.BackColor = System.Drawing.Color.Transparent
        Me.VisceralButton2.Location = New System.Drawing.Point(198, 301)
        Me.VisceralButton2.Name = "VisceralButton2"
        Me.VisceralButton2.Size = New System.Drawing.Size(124, 33)
        Me.VisceralButton2.TabIndex = 4
        Me.VisceralButton2.Text = "Select Region"
        '
        'VisceralButton1
        '
        Me.VisceralButton1.BackColor = System.Drawing.Color.Transparent
        Me.VisceralButton1.Location = New System.Drawing.Point(13, 301)
        Me.VisceralButton1.Name = "VisceralButton1"
        Me.VisceralButton1.Size = New System.Drawing.Size(124, 33)
        Me.VisceralButton1.TabIndex = 2
        Me.VisceralButton1.Text = "Capture Full Screen"
        '
        'VisceralControlBox1
        '
        Me.VisceralControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisceralControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.VisceralControlBox1.Location = New System.Drawing.Point(264, 3)
        Me.VisceralControlBox1.Name = "VisceralControlBox1"
        Me.VisceralControlBox1.Size = New System.Drawing.Size(75, 25)
        Me.VisceralControlBox1.TabIndex = 0
        Me.VisceralControlBox1.Text = "VisceralControlBox1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(13, 40)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(94, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PrintToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.PrintToolStripMenuItem.Text = "print"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.AboutToolStripMenuItem.Text = "Other"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AboutToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 381)
        Me.Controls.Add(Me.VisceralTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.VisceralTheme1.ResumeLayout(False)
        Me.VisceralTheme1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VisceralTheme1 As VisceralTheme
    Friend WithEvents VisceralControlBox1 As VisceralControlBox
    Friend WithEvents VisceralButton1 As VisceralButton
    Friend WithEvents VisceralButton2 As VisceralButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents VisceralButton3 As VisceralButton
    Friend WithEvents VisceralTextBox2 As VisceralTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Public WithEvents PictureBox2 As PictureBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents VisceralTextBox1 As VisceralTextBox
End Class
