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
        Me.TXT_PREGUNTA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.NUD_USERS_ALLOWED = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_RESPUESTA_A = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_RESPUESTA_B = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_RESPUESTA_C = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_RESPUESTA_D = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.Label3.Text = "Creación de preguntas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_PREGUNTA
        '
        Me.TXT_PREGUNTA.BackColor = System.Drawing.Color.Transparent
        Me.TXT_PREGUNTA.BorderRadius = 20
        Me.TXT_PREGUNTA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PREGUNTA.DefaultText = ""
        Me.TXT_PREGUNTA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_PREGUNTA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_PREGUNTA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PREGUNTA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PREGUNTA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PREGUNTA.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PREGUNTA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PREGUNTA.Location = New System.Drawing.Point(211, 91)
        Me.TXT_PREGUNTA.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_PREGUNTA.MaxLength = 151
        Me.TXT_PREGUNTA.Name = "TXT_PREGUNTA"
        Me.TXT_PREGUNTA.PlaceholderText = "Ingrese la pregunta"
        Me.TXT_PREGUNTA.SelectedText = ""
        Me.TXT_PREGUNTA.Size = New System.Drawing.Size(646, 170)
        Me.TXT_PREGUNTA.TabIndex = 10
        '
        'NUD_USERS_ALLOWED
        '
        Me.NUD_USERS_ALLOWED.BackColor = System.Drawing.Color.Transparent
        Me.NUD_USERS_ALLOWED.BorderRadius = 15
        Me.NUD_USERS_ALLOWED.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_USERS_ALLOWED.Font = New System.Drawing.Font("MADE TOMMY", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUD_USERS_ALLOWED.Location = New System.Drawing.Point(886, 173)
        Me.NUD_USERS_ALLOWED.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NUD_USERS_ALLOWED.Name = "NUD_USERS_ALLOWED"
        Me.NUD_USERS_ALLOWED.Size = New System.Drawing.Size(100, 36)
        Me.NUD_USERS_ALLOWED.TabIndex = 11
        Me.NUD_USERS_ALLOWED.UpDownButtonFillColor = System.Drawing.Color.MediumSlateBlue
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(112, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Respuesta A"
        '
        'TXT_RESPUESTA_A
        '
        Me.TXT_RESPUESTA_A.BackColor = System.Drawing.Color.Transparent
        Me.TXT_RESPUESTA_A.BorderRadius = 20
        Me.TXT_RESPUESTA_A.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_RESPUESTA_A.DefaultText = ""
        Me.TXT_RESPUESTA_A.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_RESPUESTA_A.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_RESPUESTA_A.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_RESPUESTA_A.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_RESPUESTA_A.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_RESPUESTA_A.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_RESPUESTA_A.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_RESPUESTA_A.Location = New System.Drawing.Point(51, 305)
        Me.TXT_RESPUESTA_A.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_RESPUESTA_A.MaxLength = 100
        Me.TXT_RESPUESTA_A.Name = "TXT_RESPUESTA_A"
        Me.TXT_RESPUESTA_A.PlaceholderText = "Ingrese la respuesta A"
        Me.TXT_RESPUESTA_A.SelectedText = ""
        Me.TXT_RESPUESTA_A.Size = New System.Drawing.Size(299, 90)
        Me.TXT_RESPUESTA_A.TabIndex = 31
        '
        'TXT_RESPUESTA_B
        '
        Me.TXT_RESPUESTA_B.BackColor = System.Drawing.Color.Transparent
        Me.TXT_RESPUESTA_B.BorderRadius = 20
        Me.TXT_RESPUESTA_B.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_RESPUESTA_B.DefaultText = ""
        Me.TXT_RESPUESTA_B.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_RESPUESTA_B.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_RESPUESTA_B.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_RESPUESTA_B.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_RESPUESTA_B.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_RESPUESTA_B.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_RESPUESTA_B.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_RESPUESTA_B.Location = New System.Drawing.Point(379, 305)
        Me.TXT_RESPUESTA_B.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_RESPUESTA_B.MaxLength = 100
        Me.TXT_RESPUESTA_B.Name = "TXT_RESPUESTA_B"
        Me.TXT_RESPUESTA_B.PlaceholderText = "Ingrese la respuesta B"
        Me.TXT_RESPUESTA_B.SelectedText = ""
        Me.TXT_RESPUESTA_B.Size = New System.Drawing.Size(299, 90)
        Me.TXT_RESPUESTA_B.TabIndex = 32
        '
        'TXT_RESPUESTA_C
        '
        Me.TXT_RESPUESTA_C.BackColor = System.Drawing.Color.Transparent
        Me.TXT_RESPUESTA_C.BorderRadius = 20
        Me.TXT_RESPUESTA_C.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_RESPUESTA_C.DefaultText = ""
        Me.TXT_RESPUESTA_C.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_RESPUESTA_C.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_RESPUESTA_C.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_RESPUESTA_C.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_RESPUESTA_C.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_RESPUESTA_C.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_RESPUESTA_C.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_RESPUESTA_C.Location = New System.Drawing.Point(713, 305)
        Me.TXT_RESPUESTA_C.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_RESPUESTA_C.MaxLength = 100
        Me.TXT_RESPUESTA_C.Name = "TXT_RESPUESTA_C"
        Me.TXT_RESPUESTA_C.PlaceholderText = "Ingrese la respuesta C"
        Me.TXT_RESPUESTA_C.SelectedText = ""
        Me.TXT_RESPUESTA_C.Size = New System.Drawing.Size(299, 90)
        Me.TXT_RESPUESTA_C.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(450, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 23)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Respuesta B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(777, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 23)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Respuesta C"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(450, 401)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Respuesta D"
        '
        'TXT_RESPUESTA_D
        '
        Me.TXT_RESPUESTA_D.BackColor = System.Drawing.Color.Transparent
        Me.TXT_RESPUESTA_D.BorderRadius = 20
        Me.TXT_RESPUESTA_D.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_RESPUESTA_D.DefaultText = ""
        Me.TXT_RESPUESTA_D.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_RESPUESTA_D.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_RESPUESTA_D.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_RESPUESTA_D.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_RESPUESTA_D.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_RESPUESTA_D.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_RESPUESTA_D.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_RESPUESTA_D.Location = New System.Drawing.Point(379, 430)
        Me.TXT_RESPUESTA_D.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_RESPUESTA_D.MaxLength = 100
        Me.TXT_RESPUESTA_D.Name = "TXT_RESPUESTA_D"
        Me.TXT_RESPUESTA_D.PlaceholderText = "Ingrese la respuesta D"
        Me.TXT_RESPUESTA_D.SelectedText = ""
        Me.TXT_RESPUESTA_D.Size = New System.Drawing.Size(299, 90)
        Me.TXT_RESPUESTA_D.TabIndex = 37
        '
        'FRM_CREAR_SALA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1074, 633)
        Me.Controls.Add(Me.TXT_RESPUESTA_D)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_RESPUESTA_C)
        Me.Controls.Add(Me.TXT_RESPUESTA_B)
        Me.Controls.Add(Me.TXT_RESPUESTA_A)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NUD_USERS_ALLOWED)
        Me.Controls.Add(Me.TXT_PREGUNTA)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_CREAR_SALA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_CREAR_SALA"
        CType(Me.NUD_USERS_ALLOWED, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_PREGUNTA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NUD_USERS_ALLOWED As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_RESPUESTA_A As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_RESPUESTA_B As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_RESPUESTA_C As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_RESPUESTA_D As Guna.UI2.WinForms.Guna2TextBox
End Class
