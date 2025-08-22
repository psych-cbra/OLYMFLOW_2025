<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_QUESTION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_QUESTION))
        Me.PREGUNTA = New System.Windows.Forms.Label()
        Me.RES_A_TEXT = New System.Windows.Forms.Label()
        Me.GBT_RESPUESTA_A = New Guna.UI2.WinForms.Guna2Button()
        Me.GBT_RESPUESTA_B = New Guna.UI2.WinForms.Guna2Button()
        Me.RES_B_TEXT = New System.Windows.Forms.Label()
        Me.GBT_RESPUESTA_C = New Guna.UI2.WinForms.Guna2Button()
        Me.RES_C_TEXT = New System.Windows.Forms.Label()
        Me.GBT_RESPUESTA_D = New Guna.UI2.WinForms.Guna2Button()
        Me.RES_D_TEXT = New System.Windows.Forms.Label()
        Me.TIEMPO = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.SuspendLayout()
        '
        'PREGUNTA
        '
        Me.PREGUNTA.BackColor = System.Drawing.Color.Transparent
        Me.PREGUNTA.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PREGUNTA.ForeColor = System.Drawing.Color.White
        Me.PREGUNTA.Location = New System.Drawing.Point(98, 98)
        Me.PREGUNTA.Name = "PREGUNTA"
        Me.PREGUNTA.Size = New System.Drawing.Size(1267, 260)
        Me.PREGUNTA.TabIndex = 6
        Me.PREGUNTA.Text = "Pregunta nula"
        Me.PREGUNTA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RES_A_TEXT
        '
        Me.RES_A_TEXT.BackColor = System.Drawing.Color.Transparent
        Me.RES_A_TEXT.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RES_A_TEXT.ForeColor = System.Drawing.Color.White
        Me.RES_A_TEXT.Location = New System.Drawing.Point(214, 362)
        Me.RES_A_TEXT.Name = "RES_A_TEXT"
        Me.RES_A_TEXT.Size = New System.Drawing.Size(1151, 80)
        Me.RES_A_TEXT.TabIndex = 7
        Me.RES_A_TEXT.Text = "Respuesta A"
        Me.RES_A_TEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GBT_RESPUESTA_A
        '
        Me.GBT_RESPUESTA_A.BackgroundImage = CType(resources.GetObject("GBT_RESPUESTA_A.BackgroundImage"), System.Drawing.Image)
        Me.GBT_RESPUESTA_A.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GBT_RESPUESTA_A.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBT_RESPUESTA_A.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBT_RESPUESTA_A.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBT_RESPUESTA_A.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBT_RESPUESTA_A.FillColor = System.Drawing.Color.Transparent
        Me.GBT_RESPUESTA_A.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Bold)
        Me.GBT_RESPUESTA_A.ForeColor = System.Drawing.Color.White
        Me.GBT_RESPUESTA_A.Location = New System.Drawing.Point(103, 362)
        Me.GBT_RESPUESTA_A.Name = "GBT_RESPUESTA_A"
        Me.GBT_RESPUESTA_A.Size = New System.Drawing.Size(105, 76)
        Me.GBT_RESPUESTA_A.TabIndex = 8
        Me.GBT_RESPUESTA_A.Text = "A"
        '
        'GBT_RESPUESTA_B
        '
        Me.GBT_RESPUESTA_B.BackgroundImage = CType(resources.GetObject("GBT_RESPUESTA_B.BackgroundImage"), System.Drawing.Image)
        Me.GBT_RESPUESTA_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GBT_RESPUESTA_B.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBT_RESPUESTA_B.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBT_RESPUESTA_B.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBT_RESPUESTA_B.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBT_RESPUESTA_B.FillColor = System.Drawing.Color.Transparent
        Me.GBT_RESPUESTA_B.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Bold)
        Me.GBT_RESPUESTA_B.ForeColor = System.Drawing.Color.White
        Me.GBT_RESPUESTA_B.Location = New System.Drawing.Point(103, 477)
        Me.GBT_RESPUESTA_B.Name = "GBT_RESPUESTA_B"
        Me.GBT_RESPUESTA_B.Size = New System.Drawing.Size(105, 76)
        Me.GBT_RESPUESTA_B.TabIndex = 10
        Me.GBT_RESPUESTA_B.Text = "B"
        '
        'RES_B_TEXT
        '
        Me.RES_B_TEXT.BackColor = System.Drawing.Color.Transparent
        Me.RES_B_TEXT.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RES_B_TEXT.ForeColor = System.Drawing.Color.White
        Me.RES_B_TEXT.Location = New System.Drawing.Point(214, 473)
        Me.RES_B_TEXT.Name = "RES_B_TEXT"
        Me.RES_B_TEXT.Size = New System.Drawing.Size(1151, 80)
        Me.RES_B_TEXT.TabIndex = 9
        Me.RES_B_TEXT.Text = "Respuesta B"
        Me.RES_B_TEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GBT_RESPUESTA_C
        '
        Me.GBT_RESPUESTA_C.BackgroundImage = CType(resources.GetObject("GBT_RESPUESTA_C.BackgroundImage"), System.Drawing.Image)
        Me.GBT_RESPUESTA_C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GBT_RESPUESTA_C.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBT_RESPUESTA_C.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBT_RESPUESTA_C.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBT_RESPUESTA_C.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBT_RESPUESTA_C.FillColor = System.Drawing.Color.Transparent
        Me.GBT_RESPUESTA_C.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Bold)
        Me.GBT_RESPUESTA_C.ForeColor = System.Drawing.Color.White
        Me.GBT_RESPUESTA_C.Location = New System.Drawing.Point(103, 585)
        Me.GBT_RESPUESTA_C.Name = "GBT_RESPUESTA_C"
        Me.GBT_RESPUESTA_C.Size = New System.Drawing.Size(105, 76)
        Me.GBT_RESPUESTA_C.TabIndex = 12
        Me.GBT_RESPUESTA_C.Text = "C"
        '
        'RES_C_TEXT
        '
        Me.RES_C_TEXT.BackColor = System.Drawing.Color.Transparent
        Me.RES_C_TEXT.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RES_C_TEXT.ForeColor = System.Drawing.Color.White
        Me.RES_C_TEXT.Location = New System.Drawing.Point(214, 581)
        Me.RES_C_TEXT.Name = "RES_C_TEXT"
        Me.RES_C_TEXT.Size = New System.Drawing.Size(1151, 80)
        Me.RES_C_TEXT.TabIndex = 11
        Me.RES_C_TEXT.Text = "Respuesta C"
        Me.RES_C_TEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GBT_RESPUESTA_D
        '
        Me.GBT_RESPUESTA_D.BackgroundImage = CType(resources.GetObject("GBT_RESPUESTA_D.BackgroundImage"), System.Drawing.Image)
        Me.GBT_RESPUESTA_D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GBT_RESPUESTA_D.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBT_RESPUESTA_D.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBT_RESPUESTA_D.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBT_RESPUESTA_D.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBT_RESPUESTA_D.FillColor = System.Drawing.Color.Transparent
        Me.GBT_RESPUESTA_D.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBT_RESPUESTA_D.ForeColor = System.Drawing.Color.White
        Me.GBT_RESPUESTA_D.Location = New System.Drawing.Point(103, 691)
        Me.GBT_RESPUESTA_D.Name = "GBT_RESPUESTA_D"
        Me.GBT_RESPUESTA_D.Size = New System.Drawing.Size(105, 76)
        Me.GBT_RESPUESTA_D.TabIndex = 14
        Me.GBT_RESPUESTA_D.Text = "D"
        '
        'RES_D_TEXT
        '
        Me.RES_D_TEXT.BackColor = System.Drawing.Color.Transparent
        Me.RES_D_TEXT.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RES_D_TEXT.ForeColor = System.Drawing.Color.White
        Me.RES_D_TEXT.Location = New System.Drawing.Point(214, 687)
        Me.RES_D_TEXT.Name = "RES_D_TEXT"
        Me.RES_D_TEXT.Size = New System.Drawing.Size(1151, 80)
        Me.RES_D_TEXT.TabIndex = 13
        Me.RES_D_TEXT.Text = "Respuesta D"
        Me.RES_D_TEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TIEMPO
        '
        Me.TIEMPO.BackColor = System.Drawing.Color.Transparent
        Me.TIEMPO.BorderRadius = 10
        Me.TIEMPO.Location = New System.Drawing.Point(115, 32)
        Me.TIEMPO.Margin = New System.Windows.Forms.Padding(2)
        Me.TIEMPO.Maximum = 20
        Me.TIEMPO.Name = "TIEMPO"
        Me.TIEMPO.ProgressColor2 = System.Drawing.Color.Lime
        Me.TIEMPO.ShowText = True
        Me.TIEMPO.Size = New System.Drawing.Size(1250, 27)
        Me.TIEMPO.TabIndex = 17
        Me.TIEMPO.Text = "Guna2ProgressBar1"
        Me.TIEMPO.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.TIEMPO.Visible = False
        '
        'FRM_QUESTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1438, 796)
        Me.Controls.Add(Me.TIEMPO)
        Me.Controls.Add(Me.GBT_RESPUESTA_D)
        Me.Controls.Add(Me.RES_D_TEXT)
        Me.Controls.Add(Me.GBT_RESPUESTA_C)
        Me.Controls.Add(Me.RES_C_TEXT)
        Me.Controls.Add(Me.GBT_RESPUESTA_B)
        Me.Controls.Add(Me.RES_B_TEXT)
        Me.Controls.Add(Me.GBT_RESPUESTA_A)
        Me.Controls.Add(Me.RES_A_TEXT)
        Me.Controls.Add(Me.PREGUNTA)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_QUESTION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_QUESTION"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PREGUNTA As Label
    Friend WithEvents RES_A_TEXT As Label
    Friend WithEvents GBT_RESPUESTA_A As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBT_RESPUESTA_B As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RES_B_TEXT As Label
    Friend WithEvents GBT_RESPUESTA_C As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RES_C_TEXT As Label
    Friend WithEvents GBT_RESPUESTA_D As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RES_D_TEXT As Label
    Friend WithEvents TIEMPO As Guna.UI2.WinForms.Guna2ProgressBar
End Class
