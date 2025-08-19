<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PROFESOR_MENU
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_PROFESOR_MENU))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NOMBRE_USUARIO = New System.Windows.Forms.Label()
        Me.FOTO = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.BT_BORRAR_CUENTA = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_MODIFICAR_USUARIO = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_LOG_OUT = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_NOMBRE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CORREO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_CLAVE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ROLES = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(316, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(471, 76)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Bienvenido"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NOMBRE_USUARIO
        '
        Me.NOMBRE_USUARIO.BackColor = System.Drawing.Color.Transparent
        Me.NOMBRE_USUARIO.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRE_USUARIO.ForeColor = System.Drawing.Color.Gold
        Me.NOMBRE_USUARIO.Location = New System.Drawing.Point(316, 97)
        Me.NOMBRE_USUARIO.Name = "NOMBRE_USUARIO"
        Me.NOMBRE_USUARIO.Size = New System.Drawing.Size(471, 76)
        Me.NOMBRE_USUARIO.TabIndex = 8
        Me.NOMBRE_USUARIO.Text = "USUARIO"
        Me.NOMBRE_USUARIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FOTO
        '
        Me.FOTO.BackColor = System.Drawing.Color.Transparent
        Me.FOTO.FillColor = System.Drawing.Color.Transparent
        Me.FOTO.ImageRotate = 0!
        Me.FOTO.Location = New System.Drawing.Point(757, 40)
        Me.FOTO.Name = "FOTO"
        Me.FOTO.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.FOTO.Size = New System.Drawing.Size(314, 216)
        Me.FOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FOTO.TabIndex = 11
        Me.FOTO.TabStop = False
        '
        'BT_BORRAR_CUENTA
        '
        Me.BT_BORRAR_CUENTA.BackColor = System.Drawing.Color.Transparent
        Me.BT_BORRAR_CUENTA.BorderRadius = 15
        Me.BT_BORRAR_CUENTA.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_BORRAR_CUENTA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_BORRAR_CUENTA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_BORRAR_CUENTA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_BORRAR_CUENTA.FillColor = System.Drawing.Color.Transparent
        Me.BT_BORRAR_CUENTA.Font = New System.Drawing.Font("OCR A Extended", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_BORRAR_CUENTA.ForeColor = System.Drawing.Color.White
        Me.BT_BORRAR_CUENTA.Image = CType(resources.GetObject("BT_BORRAR_CUENTA.Image"), System.Drawing.Image)
        Me.BT_BORRAR_CUENTA.ImageSize = New System.Drawing.Size(50, 50)
        Me.BT_BORRAR_CUENTA.Location = New System.Drawing.Point(709, 520)
        Me.BT_BORRAR_CUENTA.Name = "BT_BORRAR_CUENTA"
        Me.BT_BORRAR_CUENTA.PressedColor = System.Drawing.Color.Goldenrod
        Me.BT_BORRAR_CUENTA.Size = New System.Drawing.Size(375, 64)
        Me.BT_BORRAR_CUENTA.TabIndex = 15
        Me.BT_BORRAR_CUENTA.Text = "Borrar cuenta"
        '
        'BT_MODIFICAR_USUARIO
        '
        Me.BT_MODIFICAR_USUARIO.BackColor = System.Drawing.Color.Transparent
        Me.BT_MODIFICAR_USUARIO.BorderRadius = 15
        Me.BT_MODIFICAR_USUARIO.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_MODIFICAR_USUARIO.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_MODIFICAR_USUARIO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_MODIFICAR_USUARIO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_MODIFICAR_USUARIO.FillColor = System.Drawing.Color.Transparent
        Me.BT_MODIFICAR_USUARIO.Font = New System.Drawing.Font("OCR A Extended", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_MODIFICAR_USUARIO.ForeColor = System.Drawing.Color.White
        Me.BT_MODIFICAR_USUARIO.Image = CType(resources.GetObject("BT_MODIFICAR_USUARIO.Image"), System.Drawing.Image)
        Me.BT_MODIFICAR_USUARIO.ImageSize = New System.Drawing.Size(50, 50)
        Me.BT_MODIFICAR_USUARIO.Location = New System.Drawing.Point(37, 520)
        Me.BT_MODIFICAR_USUARIO.Name = "BT_MODIFICAR_USUARIO"
        Me.BT_MODIFICAR_USUARIO.PressedColor = System.Drawing.Color.Goldenrod
        Me.BT_MODIFICAR_USUARIO.Size = New System.Drawing.Size(457, 64)
        Me.BT_MODIFICAR_USUARIO.TabIndex = 16
        Me.BT_MODIFICAR_USUARIO.Text = "Modificar Usuario"
        '
        'BT_LOG_OUT
        '
        Me.BT_LOG_OUT.BackColor = System.Drawing.Color.Transparent
        Me.BT_LOG_OUT.BorderRadius = 15
        Me.BT_LOG_OUT.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_LOG_OUT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_LOG_OUT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_LOG_OUT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_LOG_OUT.FillColor = System.Drawing.Color.Transparent
        Me.BT_LOG_OUT.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_LOG_OUT.ForeColor = System.Drawing.Color.White
        Me.BT_LOG_OUT.Image = CType(resources.GetObject("BT_LOG_OUT.Image"), System.Drawing.Image)
        Me.BT_LOG_OUT.ImageSize = New System.Drawing.Size(30, 30)
        Me.BT_LOG_OUT.Location = New System.Drawing.Point(709, 466)
        Me.BT_LOG_OUT.Name = "BT_LOG_OUT"
        Me.BT_LOG_OUT.Size = New System.Drawing.Size(362, 48)
        Me.BT_LOG_OUT.TabIndex = 20
        Me.BT_LOG_OUT.Text = "Cerrar Sesión"
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
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(37, 131)
        Me.TXT_NOMBRE.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_NOMBRE.MaxLength = 100
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.PlaceholderText = "Digite su nombre"
        Me.TXT_NOMBRE.SelectedText = ""
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(299, 42)
        Me.TXT_NOMBRE.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(32, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nombre de Usuario"
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
        Me.TXT_CORREO.Location = New System.Drawing.Point(37, 214)
        Me.TXT_CORREO.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_CORREO.MaxLength = 80
        Me.TXT_CORREO.Name = "TXT_CORREO"
        Me.TXT_CORREO.PlaceholderText = "Digite su Correo"
        Me.TXT_CORREO.SelectedText = ""
        Me.TXT_CORREO.Size = New System.Drawing.Size(299, 42)
        Me.TXT_CORREO.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(32, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 23)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Correo de Usuario"
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
        Me.TXT_CLAVE.Location = New System.Drawing.Point(37, 303)
        Me.TXT_CLAVE.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_CLAVE.MaxLength = 16
        Me.TXT_CLAVE.Name = "TXT_CLAVE"
        Me.TXT_CLAVE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_CLAVE.PlaceholderText = "Digite su clave"
        Me.TXT_CLAVE.SelectedText = ""
        Me.TXT_CLAVE.Size = New System.Drawing.Size(299, 42)
        Me.TXT_CLAVE.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(32, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Clave de Usuario"
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
        Me.ROLES.Location = New System.Drawing.Point(38, 394)
        Me.ROLES.Margin = New System.Windows.Forms.Padding(2)
        Me.ROLES.Name = "ROLES"
        Me.ROLES.Size = New System.Drawing.Size(216, 36)
        Me.ROLES.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(34, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 23)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Tipo de Usuario"
        '
        'FRM_PROFESOR_MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1119, 608)
        Me.Controls.Add(Me.ROLES)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_CLAVE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_CORREO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BT_LOG_OUT)
        Me.Controls.Add(Me.BT_MODIFICAR_USUARIO)
        Me.Controls.Add(Me.BT_BORRAR_CUENTA)
        Me.Controls.Add(Me.FOTO)
        Me.Controls.Add(Me.NOMBRE_USUARIO)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_PROFESOR_MENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_PROFESOR_MENU"
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents NOMBRE_USUARIO As Label
    Friend WithEvents FOTO As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents BT_BORRAR_CUENTA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_MODIFICAR_USUARIO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_LOG_OUT As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_NOMBRE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CORREO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_CLAVE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ROLES As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
End Class
