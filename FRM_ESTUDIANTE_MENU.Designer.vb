<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ESTUDIANTE_MENU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ESTUDIANTE_MENU))
        Me.NOMBRE_USUARIO = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NOMBRE_USUARIO
        '
        Me.NOMBRE_USUARIO.BackColor = System.Drawing.Color.Transparent
        Me.NOMBRE_USUARIO.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRE_USUARIO.ForeColor = System.Drawing.Color.Gold
        Me.NOMBRE_USUARIO.Location = New System.Drawing.Point(302, 100)
        Me.NOMBRE_USUARIO.Name = "NOMBRE_USUARIO"
        Me.NOMBRE_USUARIO.Size = New System.Drawing.Size(471, 76)
        Me.NOMBRE_USUARIO.TabIndex = 10
        Me.NOMBRE_USUARIO.Text = "USUARIO"
        Me.NOMBRE_USUARIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(302, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(471, 76)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Bienvenido"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FRM_ESTUDIANTE_MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1089, 636)
        Me.Controls.Add(Me.NOMBRE_USUARIO)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_ESTUDIANTE_MENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_ESTUDIANTE_MENU"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NOMBRE_USUARIO As Label
    Friend WithEvents Label3 As Label
End Class
