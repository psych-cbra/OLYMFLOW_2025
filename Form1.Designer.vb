<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_NOMBRE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_CLAVE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_CORREO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PROFILE_PICTURE = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.ABRIR = New System.Windows.Forms.OpenFileDialog()
        Me.BT_GUARDAR = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_SALIR = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ROLES = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.PROFILE_PICTURE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(-2, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(915, 76)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Creación de Usuario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(35, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre de Usuario"
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.BackColor = System.Drawing.Color.Transparent
        Me.TXT_NOMBRE.BorderRadius = 20
        Me.TXT_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_NOMBRE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOMBRE.DefaultText = ""
        Me.TXT_NOMBRE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NOMBRE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NOMBRE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NOMBRE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NOMBRE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NOMBRE.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMBRE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(40, 158)
        Me.TXT_NOMBRE.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_NOMBRE.MaxLength = 100
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.PlaceholderText = "Digite su nombre"
        Me.TXT_NOMBRE.SelectedText = ""
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(299, 42)
        Me.TXT_NOMBRE.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(35, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Clave de Usuario"
        '
        'TXT_CLAVE
        '
        Me.TXT_CLAVE.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CLAVE.BorderRadius = 20
        Me.TXT_CLAVE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CLAVE.DefaultText = ""
        Me.TXT_CLAVE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CLAVE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CLAVE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CLAVE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CLAVE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CLAVE.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CLAVE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CLAVE.Location = New System.Drawing.Point(40, 405)
        Me.TXT_CLAVE.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_CLAVE.MaxLength = 16
        Me.TXT_CLAVE.Name = "TXT_CLAVE"
        Me.TXT_CLAVE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_CLAVE.PlaceholderText = "Digite su clave"
        Me.TXT_CLAVE.SelectedText = ""
        Me.TXT_CLAVE.Size = New System.Drawing.Size(299, 42)
        Me.TXT_CLAVE.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(35, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Correo de Usuario"
        '
        'TXT_CORREO
        '
        Me.TXT_CORREO.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CORREO.BorderRadius = 20
        Me.TXT_CORREO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CORREO.DefaultText = ""
        Me.TXT_CORREO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CORREO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CORREO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CORREO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CORREO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CORREO.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CORREO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CORREO.Location = New System.Drawing.Point(40, 291)
        Me.TXT_CORREO.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_CORREO.MaxLength = 80
        Me.TXT_CORREO.Name = "TXT_CORREO"
        Me.TXT_CORREO.PlaceholderText = "Digite su Correo"
        Me.TXT_CORREO.SelectedText = ""
        Me.TXT_CORREO.Size = New System.Drawing.Size(299, 42)
        Me.TXT_CORREO.TabIndex = 11
        '
        'PROFILE_PICTURE
        '
        Me.PROFILE_PICTURE.BackColor = System.Drawing.Color.Transparent
        Me.PROFILE_PICTURE.FillColor = System.Drawing.Color.Transparent
        Me.PROFILE_PICTURE.Image = Global.OLYMFLOW_2025.My.Resources.Resources.CATBOX
        Me.PROFILE_PICTURE.ImageRotate = 0!
        Me.PROFILE_PICTURE.Location = New System.Drawing.Point(428, 110)
        Me.PROFILE_PICTURE.Name = "PROFILE_PICTURE"
        Me.PROFILE_PICTURE.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PROFILE_PICTURE.Size = New System.Drawing.Size(385, 272)
        Me.PROFILE_PICTURE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PROFILE_PICTURE.TabIndex = 12
        Me.PROFILE_PICTURE.TabStop = False
        '
        'ABRIR
        '
        Me.ABRIR.FileName = "OpenFileDialog1"
        Me.ABRIR.Filter = "Imágenes |*.jpg; *.bmp; *.jpeg"
        Me.ABRIR.Title = "Seleccione una foto"
        '
        'BT_GUARDAR
        '
        Me.BT_GUARDAR.BackColor = System.Drawing.Color.Transparent
        Me.BT_GUARDAR.BorderRadius = 15
        Me.BT_GUARDAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_GUARDAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_GUARDAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_GUARDAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_GUARDAR.FillColor = System.Drawing.Color.Transparent
        Me.BT_GUARDAR.Font = New System.Drawing.Font("OCR A Extended", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_GUARDAR.ForeColor = System.Drawing.Color.White
        Me.BT_GUARDAR.Image = CType(resources.GetObject("BT_GUARDAR.Image"), System.Drawing.Image)
        Me.BT_GUARDAR.ImageSize = New System.Drawing.Size(50, 50)
        Me.BT_GUARDAR.Location = New System.Drawing.Point(40, 519)
        Me.BT_GUARDAR.Name = "BT_GUARDAR"
        Me.BT_GUARDAR.PressedColor = System.Drawing.Color.Goldenrod
        Me.BT_GUARDAR.Size = New System.Drawing.Size(299, 64)
        Me.BT_GUARDAR.TabIndex = 13
        Me.BT_GUARDAR.Text = "Guardar"
        '
        'BT_SALIR
        '
        Me.BT_SALIR.BackColor = System.Drawing.Color.Transparent
        Me.BT_SALIR.BorderRadius = 15
        Me.BT_SALIR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_SALIR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_SALIR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_SALIR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_SALIR.FillColor = System.Drawing.Color.Transparent
        Me.BT_SALIR.Font = New System.Drawing.Font("OCR A Extended", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SALIR.ForeColor = System.Drawing.Color.White
        Me.BT_SALIR.Image = CType(resources.GetObject("BT_SALIR.Image"), System.Drawing.Image)
        Me.BT_SALIR.ImageSize = New System.Drawing.Size(50, 50)
        Me.BT_SALIR.Location = New System.Drawing.Point(549, 519)
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.PressedColor = System.Drawing.Color.Goldenrod
        Me.BT_SALIR.Size = New System.Drawing.Size(275, 64)
        Me.BT_SALIR.TabIndex = 14
        Me.BT_SALIR.Text = "Salir"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(353, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tipo de Usuario"
        '
        'ROLES
        '
        Me.ROLES.BackColor = System.Drawing.Color.Transparent
        Me.ROLES.BorderRadius = 20
        Me.ROLES.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ROLES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ROLES.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ROLES.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ROLES.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ROLES.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ROLES.ItemHeight = 30
        Me.ROLES.Items.AddRange(New Object() {"ALAJUELA", "HEREDIA", "CARTAGO", "SAN JOSE", "GUANACASTE", "PUNTARENAS", "LIMON"})
        Me.ROLES.Location = New System.Drawing.Point(357, 411)
        Me.ROLES.Margin = New System.Windows.Forms.Padding(2)
        Me.ROLES.Name = "ROLES"
        Me.ROLES.Size = New System.Drawing.Size(216, 36)
        Me.ROLES.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(914, 632)
        Me.Controls.Add(Me.ROLES)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BT_SALIR)
        Me.Controls.Add(Me.BT_GUARDAR)
        Me.Controls.Add(Me.PROFILE_PICTURE)
        Me.Controls.Add(Me.TXT_CORREO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_CLAVE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PROFILE_PICTURE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_NOMBRE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_CLAVE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_CORREO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PROFILE_PICTURE As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents ABRIR As OpenFileDialog
    Friend WithEvents BT_GUARDAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_SALIR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ROLES As Guna.UI2.WinForms.Guna2ComboBox
End Class
