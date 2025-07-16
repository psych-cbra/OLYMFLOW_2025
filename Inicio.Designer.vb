<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cerrar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.IngreseUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.estasRegistrado = New System.Windows.Forms.Label()
        Me.Registrarse = New System.Windows.Forms.LinkLabel()
        Me.CHECKBOX = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Guna2Panel1.Controls.Add(Me.cerrar)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-20, -2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(463, 45)
        Me.Guna2Panel1.TabIndex = 0
        '
        'cerrar
        '
        Me.cerrar.BackColor = System.Drawing.SystemColors.Highlight
        Me.cerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cerrar.FillColor = System.Drawing.SystemColors.Highlight
        Me.cerrar.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.cerrar.ForeColor = System.Drawing.Color.White
        Me.cerrar.Location = New System.Drawing.Point(412, 3)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cerrar.Size = New System.Drawing.Size(48, 42)
        Me.cerrar.TabIndex = 0
        Me.cerrar.Text = "X"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(134, 95)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(163, 161)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 1
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'IngreseUsuario
        '
        Me.IngreseUsuario.AutoSize = True
        Me.IngreseUsuario.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.IngreseUsuario.Location = New System.Drawing.Point(130, 280)
        Me.IngreseUsuario.Name = "IngreseUsuario"
        Me.IngreseUsuario.Size = New System.Drawing.Size(167, 24)
        Me.IngreseUsuario.TabIndex = 2
        Me.IngreseUsuario.Text = "Ingrese su usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrese la contraseña"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.SystemColors.MenuHighlight
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(130, 499)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 4
        Me.Guna2Button1.Text = "Entrar"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(119, 396)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(200, 36)
        Me.Guna2TextBox1.TabIndex = 5
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(119, 307)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(200, 36)
        Me.Guna2TextBox2.TabIndex = 6
        '
        'estasRegistrado
        '
        Me.estasRegistrado.AutoSize = True
        Me.estasRegistrado.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.estasRegistrado.Location = New System.Drawing.Point(122, 559)
        Me.estasRegistrado.Name = "estasRegistrado"
        Me.estasRegistrado.Size = New System.Drawing.Size(197, 24)
        Me.estasRegistrado.TabIndex = 7
        Me.estasRegistrado.Text = "¿No estas registrado?"
        '
        'Registrarse
        '
        Me.Registrarse.AutoSize = True
        Me.Registrarse.LinkColor = System.Drawing.Color.Red
        Me.Registrarse.Location = New System.Drawing.Point(183, 598)
        Me.Registrarse.Name = "Registrarse"
        Me.Registrarse.Size = New System.Drawing.Size(60, 13)
        Me.Registrarse.TabIndex = 8
        Me.Registrarse.TabStop = True
        Me.Registrarse.Text = "Registrarse"
        '
        'CHECKBOX
        '
        Me.CHECKBOX.AutoSize = True
        Me.CHECKBOX.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CHECKBOX.CheckedState.BorderRadius = 0
        Me.CHECKBOX.CheckedState.BorderThickness = 0
        Me.CHECKBOX.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CHECKBOX.Location = New System.Drawing.Point(258, 451)
        Me.CHECKBOX.Name = "CHECKBOX"
        Me.CHECKBOX.Size = New System.Drawing.Size(61, 17)
        Me.CHECKBOX.TabIndex = 10
        Me.CHECKBOX.Text = "Mostrar"
        Me.CHECKBOX.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CHECKBOX.UncheckedState.BorderRadius = 0
        Me.CHECKBOX.UncheckedState.BorderThickness = 0
        Me.CHECKBOX.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(439, 629)
        Me.Controls.Add(Me.CHECKBOX)
        Me.Controls.Add(Me.Registrarse)
        Me.Controls.Add(Me.estasRegistrado)
        Me.Controls.Add(Me.Guna2TextBox2)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IngreseUsuario)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents IngreseUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents estasRegistrado As Label
    Friend WithEvents Registrarse As LinkLabel
    Friend WithEvents CHECKBOX As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents cerrar As Guna.UI2.WinForms.Guna2CircleButton
End Class
