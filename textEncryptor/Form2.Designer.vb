<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.txtInput = New Guna.UI.WinForms.GunaTextBox()
        Me.lblOutput = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaTextBox3 = New Guna.UI.WinForms.GunaTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnEncrypt = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaTextBox4 = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.Transparent
        Me.txtInput.BaseColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.txtInput.BorderColor = System.Drawing.Color.White
        Me.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInput.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.txtInput.FocusedBorderColor = System.Drawing.Color.White
        Me.txtInput.FocusedForeColor = System.Drawing.Color.White
        Me.txtInput.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtInput.ForeColor = System.Drawing.Color.White
        Me.txtInput.Location = New System.Drawing.Point(102, 106)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInput.Radius = 4
        Me.txtInput.SelectedText = ""
        Me.txtInput.Size = New System.Drawing.Size(181, 28)
        Me.txtInput.TabIndex = 3
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.Transparent
        Me.lblOutput.BaseColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.lblOutput.BorderColor = System.Drawing.Color.White
        Me.lblOutput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblOutput.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.lblOutput.FocusedBorderColor = System.Drawing.Color.White
        Me.lblOutput.FocusedForeColor = System.Drawing.Color.White
        Me.lblOutput.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblOutput.ForeColor = System.Drawing.Color.White
        Me.lblOutput.Location = New System.Drawing.Point(12, 197)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblOutput.Radius = 9
        Me.lblOutput.SelectedText = ""
        Me.lblOutput.Size = New System.Drawing.Size(550, 184)
        Me.lblOutput.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(99, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Encrypted Output (Hashed):"
        '
        'GunaTextBox3
        '
        Me.GunaTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GunaTextBox3.BorderColor = System.Drawing.Color.White
        Me.GunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox3.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GunaTextBox3.FocusedBorderColor = System.Drawing.Color.White
        Me.GunaTextBox3.FocusedForeColor = System.Drawing.Color.White
        Me.GunaTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaTextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaTextBox3.Location = New System.Drawing.Point(84, 79)
        Me.GunaTextBox3.Name = "GunaTextBox3"
        Me.GunaTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox3.Radius = 9
        Me.GunaTextBox3.SelectedText = ""
        Me.GunaTextBox3.Size = New System.Drawing.Size(402, 65)
        Me.GunaTextBox3.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.textEncryptor.My.Resources.Resources.TextEncryptorLogo
        Me.PictureBox3.Location = New System.Drawing.Point(0, -5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(83, 62)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.BorderSize = 2
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = CType(resources.GetObject("GunaAdvenceButton2.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = Nothing
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(386, 108)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GunaAdvenceButton2.Radius = 4
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(91, 26)
        Me.GunaAdvenceButton2.TabIndex = 9
        Me.GunaAdvenceButton2.Text = "Clear"
        Me.GunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEncrypt
        '
        Me.btnEncrypt.AnimationHoverSpeed = 0.07!
        Me.btnEncrypt.AnimationSpeed = 0.03!
        Me.btnEncrypt.BackColor = System.Drawing.Color.Transparent
        Me.btnEncrypt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnEncrypt.BorderColor = System.Drawing.Color.White
        Me.btnEncrypt.BorderSize = 2
        Me.btnEncrypt.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnEncrypt.CheckedBorderColor = System.Drawing.Color.White
        Me.btnEncrypt.CheckedForeColor = System.Drawing.Color.White
        Me.btnEncrypt.CheckedImage = CType(resources.GetObject("btnEncrypt.CheckedImage"), System.Drawing.Image)
        Me.btnEncrypt.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnEncrypt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEncrypt.FocusedColor = System.Drawing.Color.Empty
        Me.btnEncrypt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEncrypt.ForeColor = System.Drawing.Color.White
        Me.btnEncrypt.Image = Nothing
        Me.btnEncrypt.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEncrypt.LineColor = System.Drawing.Color.White
        Me.btnEncrypt.Location = New System.Drawing.Point(289, 106)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnEncrypt.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnEncrypt.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEncrypt.OnHoverImage = Nothing
        Me.btnEncrypt.OnHoverLineColor = System.Drawing.Color.White
        Me.btnEncrypt.OnPressedColor = System.Drawing.Color.Black
        Me.btnEncrypt.Radius = 4
        Me.btnEncrypt.Size = New System.Drawing.Size(91, 26)
        Me.btnEncrypt.TabIndex = 7
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.textEncryptor.My.Resources.Resources.LogoNew1
        Me.PictureBox1.Location = New System.Drawing.Point(437, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.textEncryptor.My.Resources.Resources.LogoNew1
        Me.PictureBox2.Location = New System.Drawing.Point(-35, 161)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(152, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(99, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter Plain Text"
        '
        'GunaTextBox4
        '
        Me.GunaTextBox4.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GunaTextBox4.BorderColor = System.Drawing.Color.White
        Me.GunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox4.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GunaTextBox4.FocusedBorderColor = System.Drawing.Color.White
        Me.GunaTextBox4.FocusedForeColor = System.Drawing.Color.White
        Me.GunaTextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaTextBox4.ForeColor = System.Drawing.Color.White
        Me.GunaTextBox4.Location = New System.Drawing.Point(84, 150)
        Me.GunaTextBox4.Name = "GunaTextBox4"
        Me.GunaTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox4.Radius = 9
        Me.GunaTextBox4.SelectedText = ""
        Me.GunaTextBox4.Size = New System.Drawing.Size(181, 41)
        Me.GunaTextBox4.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(526, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 29)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "X"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(568, 411)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GunaAdvenceButton2)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.GunaTextBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaTextBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblOutput As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnEncrypt As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaTextBox3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GunaTextBox4 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
