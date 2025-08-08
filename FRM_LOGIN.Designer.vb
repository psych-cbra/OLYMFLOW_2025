<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_LOGIN))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_CORREO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_CLAVE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBT_INI_SESION = New Guna.UI2.WinForms.Guna2Button()
        Me.GBT_CERRAR = New Guna.UI2.WinForms.Guna2Button()
        Me.FOTO = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.BT_LOG_OUT = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(275, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(471, 76)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Inicio de Sesión"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TXT_CORREO.Location = New System.Drawing.Point(280, 323)
        Me.TXT_CORREO.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_CORREO.MaxLength = 80
        Me.TXT_CORREO.Name = "TXT_CORREO"
        Me.TXT_CORREO.PlaceholderText = "Digite su Correo"
        Me.TXT_CORREO.SelectedText = ""
        Me.TXT_CORREO.Size = New System.Drawing.Size(466, 42)
        Me.TXT_CORREO.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(402, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 23)
        Me.Label4.TabIndex = 13
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
        Me.TXT_CLAVE.Location = New System.Drawing.Point(280, 400)
        Me.TXT_CLAVE.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_CLAVE.MaxLength = 16
        Me.TXT_CLAVE.Name = "TXT_CLAVE"
        Me.TXT_CLAVE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_CLAVE.PlaceholderText = "Digite su contraseña"
        Me.TXT_CLAVE.SelectedText = ""
        Me.TXT_CLAVE.Size = New System.Drawing.Size(466, 42)
        Me.TXT_CLAVE.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(402, 371)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Clave de Usuario"
        '
        'GBT_INI_SESION
        '
        Me.GBT_INI_SESION.BackColor = System.Drawing.Color.Transparent
        Me.GBT_INI_SESION.BorderRadius = 15
        Me.GBT_INI_SESION.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBT_INI_SESION.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBT_INI_SESION.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBT_INI_SESION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBT_INI_SESION.FillColor = System.Drawing.Color.Transparent
        Me.GBT_INI_SESION.Font = New System.Drawing.Font("OCR A Extended", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBT_INI_SESION.ForeColor = System.Drawing.Color.White
        Me.GBT_INI_SESION.Location = New System.Drawing.Point(280, 476)
        Me.GBT_INI_SESION.Name = "GBT_INI_SESION"
        Me.GBT_INI_SESION.Size = New System.Drawing.Size(223, 54)
        Me.GBT_INI_SESION.TabIndex = 16
        Me.GBT_INI_SESION.Text = "Iniciar Sesión"
        '
        'GBT_CERRAR
        '
        Me.GBT_CERRAR.BackColor = System.Drawing.Color.Transparent
        Me.GBT_CERRAR.BorderRadius = 15
        Me.GBT_CERRAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBT_CERRAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBT_CERRAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBT_CERRAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBT_CERRAR.FillColor = System.Drawing.Color.Transparent
        Me.GBT_CERRAR.Font = New System.Drawing.Font("OCR A Extended", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBT_CERRAR.ForeColor = System.Drawing.Color.White
        Me.GBT_CERRAR.Location = New System.Drawing.Point(573, 462)
        Me.GBT_CERRAR.Name = "GBT_CERRAR"
        Me.GBT_CERRAR.Size = New System.Drawing.Size(173, 68)
        Me.GBT_CERRAR.TabIndex = 17
        Me.GBT_CERRAR.Text = "Cerrar"
        '
        'FOTO
        '
        Me.FOTO.BackColor = System.Drawing.Color.Transparent
        Me.FOTO.Image = Global.OLYMFLOW_2025.My.Resources.Resources.CATBOX
        Me.FOTO.ImageRotate = 0!
        Me.FOTO.Location = New System.Drawing.Point(280, 110)
        Me.FOTO.Name = "FOTO"
        Me.FOTO.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.FOTO.Size = New System.Drawing.Size(466, 181)
        Me.FOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FOTO.TabIndex = 18
        Me.FOTO.TabStop = False
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
        Me.BT_LOG_OUT.Location = New System.Drawing.Point(743, 536)
        Me.BT_LOG_OUT.Name = "BT_LOG_OUT"
        Me.BT_LOG_OUT.Size = New System.Drawing.Size(239, 48)
        Me.BT_LOG_OUT.TabIndex = 19
        Me.BT_LOG_OUT.Text = "Cerrar Sesión"
        '
        'FRM_LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1020, 610)
        Me.Controls.Add(Me.BT_LOG_OUT)
        Me.Controls.Add(Me.FOTO)
        Me.Controls.Add(Me.GBT_CERRAR)
        Me.Controls.Add(Me.GBT_INI_SESION)
        Me.Controls.Add(Me.TXT_CLAVE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_CORREO)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_LOGIN"
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_CORREO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_CLAVE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GBT_INI_SESION As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBT_CERRAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FOTO As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents BT_LOG_OUT As Guna.UI2.WinForms.Guna2Button
End Class
