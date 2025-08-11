<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CREAR_SALA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CREAR_SALA))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_NOMBRE_SALA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.NUD_USERS_ALLOWED = New Guna.UI2.WinForms.Guna2NumericUpDown()
        CType(Me.NUD_USERS_ALLOWED, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1050, 76)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Creación de sala"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_NOMBRE_SALA
        '
        Me.TXT_NOMBRE_SALA.BackColor = System.Drawing.Color.Transparent
        Me.TXT_NOMBRE_SALA.BorderRadius = 20
        Me.TXT_NOMBRE_SALA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOMBRE_SALA.DefaultText = ""
        Me.TXT_NOMBRE_SALA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NOMBRE_SALA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NOMBRE_SALA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NOMBRE_SALA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NOMBRE_SALA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NOMBRE_SALA.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMBRE_SALA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NOMBRE_SALA.Location = New System.Drawing.Point(119, 256)
        Me.TXT_NOMBRE_SALA.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_NOMBRE_SALA.MaxLength = 100
        Me.TXT_NOMBRE_SALA.Name = "TXT_NOMBRE_SALA"
        Me.TXT_NOMBRE_SALA.PlaceholderText = "Ingrese el nombre de la sala"
        Me.TXT_NOMBRE_SALA.SelectedText = ""
        Me.TXT_NOMBRE_SALA.Size = New System.Drawing.Size(390, 42)
        Me.TXT_NOMBRE_SALA.TabIndex = 10
        '
        'NUD_USERS_ALLOWED
        '
        Me.NUD_USERS_ALLOWED.BackColor = System.Drawing.Color.Transparent
        Me.NUD_USERS_ALLOWED.BorderRadius = 15
        Me.NUD_USERS_ALLOWED.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_USERS_ALLOWED.Font = New System.Drawing.Font("MADE TOMMY", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUD_USERS_ALLOWED.Location = New System.Drawing.Point(143, 398)
        Me.NUD_USERS_ALLOWED.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NUD_USERS_ALLOWED.Name = "NUD_USERS_ALLOWED"
        Me.NUD_USERS_ALLOWED.Size = New System.Drawing.Size(100, 36)
        Me.NUD_USERS_ALLOWED.TabIndex = 11
        Me.NUD_USERS_ALLOWED.UpDownButtonFillColor = System.Drawing.Color.MediumSlateBlue
        '
        'FRM_CREAR_SALA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1074, 633)
        Me.Controls.Add(Me.NUD_USERS_ALLOWED)
        Me.Controls.Add(Me.TXT_NOMBRE_SALA)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_CREAR_SALA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_CREAR_SALA"
        CType(Me.NUD_USERS_ALLOWED, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_NOMBRE_SALA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NUD_USERS_ALLOWED As Guna.UI2.WinForms.Guna2NumericUpDown
End Class
