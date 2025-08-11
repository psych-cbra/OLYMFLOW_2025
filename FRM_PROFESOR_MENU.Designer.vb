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
        'FRM_PROFESOR_MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1119, 608)
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

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents NOMBRE_USUARIO As Label
    Friend WithEvents FOTO As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents BT_BORRAR_CUENTA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_MODIFICAR_USUARIO As Guna.UI2.WinForms.Guna2Button
End Class
