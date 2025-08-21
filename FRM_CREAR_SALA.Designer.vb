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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RESPUESTAS = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BT_SUBIR_PREGUNTA = New Guna.UI2.WinForms.Guna2Button()
        Me.TEMAS = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GBT_BACK = New Guna.UI2.WinForms.Guna2Button()
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
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(113, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 43)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Respuesta Correcta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RESPUESTAS
        '
        Me.RESPUESTAS.BackColor = System.Drawing.Color.Transparent
        Me.RESPUESTAS.BorderRadius = 20
        Me.RESPUESTAS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.RESPUESTAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RESPUESTAS.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RESPUESTAS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RESPUESTAS.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESPUESTAS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RESPUESTAS.ItemHeight = 30
        Me.RESPUESTAS.Items.AddRange(New Object() {"ALAJUELA", "HEREDIA", "CARTAGO", "SAN JOSE", "GUANACASTE", "PUNTARENAS", "LIMON"})
        Me.RESPUESTAS.Location = New System.Drawing.Point(155, 451)
        Me.RESPUESTAS.Margin = New System.Windows.Forms.Padding(2)
        Me.RESPUESTAS.Name = "RESPUESTAS"
        Me.RESPUESTAS.Size = New System.Drawing.Size(96, 36)
        Me.RESPUESTAS.TabIndex = 39
        '
        'BT_SUBIR_PREGUNTA
        '
        Me.BT_SUBIR_PREGUNTA.BackColor = System.Drawing.Color.Transparent
        Me.BT_SUBIR_PREGUNTA.BorderRadius = 15
        Me.BT_SUBIR_PREGUNTA.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_SUBIR_PREGUNTA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_SUBIR_PREGUNTA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_SUBIR_PREGUNTA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_SUBIR_PREGUNTA.FillColor = System.Drawing.Color.Transparent
        Me.BT_SUBIR_PREGUNTA.Font = New System.Drawing.Font("OCR A Extended", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SUBIR_PREGUNTA.ForeColor = System.Drawing.Color.White
        Me.BT_SUBIR_PREGUNTA.Image = CType(resources.GetObject("BT_SUBIR_PREGUNTA.Image"), System.Drawing.Image)
        Me.BT_SUBIR_PREGUNTA.ImageSize = New System.Drawing.Size(50, 50)
        Me.BT_SUBIR_PREGUNTA.Location = New System.Drawing.Point(299, 529)
        Me.BT_SUBIR_PREGUNTA.Name = "BT_SUBIR_PREGUNTA"
        Me.BT_SUBIR_PREGUNTA.PressedColor = System.Drawing.Color.Goldenrod
        Me.BT_SUBIR_PREGUNTA.Size = New System.Drawing.Size(457, 64)
        Me.BT_SUBIR_PREGUNTA.TabIndex = 40
        Me.BT_SUBIR_PREGUNTA.Text = "Subir Pregunta"
        '
        'TEMAS
        '
        Me.TEMAS.BackColor = System.Drawing.Color.Transparent
        Me.TEMAS.BorderRadius = 20
        Me.TEMAS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TEMAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TEMAS.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TEMAS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TEMAS.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEMAS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TEMAS.ItemHeight = 30
        Me.TEMAS.Items.AddRange(New Object() {"ALAJUELA", "HEREDIA", "CARTAGO", "SAN JOSE", "GUANACASTE", "PUNTARENAS", "LIMON"})
        Me.TEMAS.Location = New System.Drawing.Point(781, 451)
        Me.TEMAS.Margin = New System.Windows.Forms.Padding(2)
        Me.TEMAS.Name = "TEMAS"
        Me.TEMAS.Size = New System.Drawing.Size(174, 36)
        Me.TEMAS.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(781, 406)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 43)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Tema de la Pregunta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GBT_BACK
        '
        Me.GBT_BACK.BackColor = System.Drawing.Color.Transparent
        Me.GBT_BACK.BorderRadius = 15
        Me.GBT_BACK.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBT_BACK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBT_BACK.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBT_BACK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBT_BACK.FillColor = System.Drawing.Color.Transparent
        Me.GBT_BACK.Font = New System.Drawing.Font("OCR A Extended", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBT_BACK.ForeColor = System.Drawing.Color.White
        Me.GBT_BACK.Location = New System.Drawing.Point(53, 539)
        Me.GBT_BACK.Name = "GBT_BACK"
        Me.GBT_BACK.Size = New System.Drawing.Size(223, 54)
        Me.GBT_BACK.TabIndex = 43
        Me.GBT_BACK.Text = "Atrás"
        '
        'FRM_CREAR_SALA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1074, 633)
        Me.Controls.Add(Me.GBT_BACK)
        Me.Controls.Add(Me.TEMAS)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BT_SUBIR_PREGUNTA)
        Me.Controls.Add(Me.RESPUESTAS)
        Me.Controls.Add(Me.Label6)
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
    Friend WithEvents Label6 As Label
    Friend WithEvents RESPUESTAS As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BT_SUBIR_PREGUNTA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TEMAS As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GBT_BACK As Guna.UI2.WinForms.Guna2Button
End Class
