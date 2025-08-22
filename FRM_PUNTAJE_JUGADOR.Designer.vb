<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PUNTAJE_JUGADOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_PUNTAJE_JUGADOR))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NOMBRE_USUARIO = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PUNTAJE = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BT_LOG_OUT = New Guna.UI2.WinForms.Guna2Button()
        Me.FOTO = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1154, 76)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Tu Puntaje"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NOMBRE_USUARIO
        '
        Me.NOMBRE_USUARIO.BackColor = System.Drawing.Color.Transparent
        Me.NOMBRE_USUARIO.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRE_USUARIO.ForeColor = System.Drawing.Color.Gold
        Me.NOMBRE_USUARIO.Location = New System.Drawing.Point(17, 97)
        Me.NOMBRE_USUARIO.Name = "NOMBRE_USUARIO"
        Me.NOMBRE_USUARIO.Size = New System.Drawing.Size(1149, 76)
        Me.NOMBRE_USUARIO.TabIndex = 19
        Me.NOMBRE_USUARIO.Text = "USUARIO"
        Me.NOMBRE_USUARIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 76)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Puntaje Total:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PUNTAJE
        '
        Me.PUNTAJE.BackColor = System.Drawing.Color.Transparent
        Me.PUNTAJE.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PUNTAJE.ForeColor = System.Drawing.Color.Gold
        Me.PUNTAJE.Location = New System.Drawing.Point(457, 205)
        Me.PUNTAJE.Name = "PUNTAJE"
        Me.PUNTAJE.Size = New System.Drawing.Size(413, 161)
        Me.PUNTAJE.TabIndex = 21
        Me.PUNTAJE.Text = "PUNTOS"
        Me.PUNTAJE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1154, 60)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "¡Gracias por Jugar!"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BT_LOG_OUT.Location = New System.Drawing.Point(411, 558)
        Me.BT_LOG_OUT.Name = "BT_LOG_OUT"
        Me.BT_LOG_OUT.Size = New System.Drawing.Size(362, 48)
        Me.BT_LOG_OUT.TabIndex = 23
        Me.BT_LOG_OUT.Text = "Cerrar Sesión"
        '
        'FOTO
        '
        Me.FOTO.BackColor = System.Drawing.Color.Transparent
        Me.FOTO.FillColor = System.Drawing.Color.Transparent
        Me.FOTO.ImageRotate = 0!
        Me.FOTO.Location = New System.Drawing.Point(741, 97)
        Me.FOTO.Name = "FOTO"
        Me.FOTO.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.FOTO.Size = New System.Drawing.Size(387, 269)
        Me.FOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FOTO.TabIndex = 24
        Me.FOTO.TabStop = False
        '
        'FRM_PUNTAJE_JUGADOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1178, 633)
        Me.Controls.Add(Me.FOTO)
        Me.Controls.Add(Me.BT_LOG_OUT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PUNTAJE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NOMBRE_USUARIO)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_PUNTAJE_JUGADOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_PUNTAJE_JUGADOR"
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents NOMBRE_USUARIO As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PUNTAJE As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BT_LOG_OUT As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FOTO As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
