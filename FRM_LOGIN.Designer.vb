﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_LOGIN))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_CORREO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_CLAVE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBT_INI_SESION = New Guna.UI2.WinForms.Guna2Button()
        Me.GBT_CERRAR = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(-1, -2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1022, 76)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Inicio de Sesión"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXT_CORREO
        '
        Me.TXT_CORREO.BorderRadius = 20
        Me.TXT_CORREO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CORREO.DefaultText = ""
        Me.TXT_CORREO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CORREO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CORREO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CORREO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CORREO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CORREO.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CORREO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CORREO.Location = New System.Drawing.Point(248, 233)
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
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(388, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Correo de Usuario"
        '
        'TXT_CLAVE
        '
        Me.TXT_CLAVE.BorderRadius = 20
        Me.TXT_CLAVE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CLAVE.DefaultText = ""
        Me.TXT_CLAVE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CLAVE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CLAVE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CLAVE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CLAVE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CLAVE.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CLAVE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CLAVE.Location = New System.Drawing.Point(248, 336)
        Me.TXT_CLAVE.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_CLAVE.MaxLength = 16
        Me.TXT_CLAVE.Name = "TXT_CLAVE"
        Me.TXT_CLAVE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_CLAVE.PlaceholderText = "Digite su clave"
        Me.TXT_CLAVE.SelectedText = ""
        Me.TXT_CLAVE.Size = New System.Drawing.Size(466, 42)
        Me.TXT_CLAVE.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(388, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Clave de Usuario"
        '
        'GBT_INI_SESION
        '
        Me.GBT_INI_SESION.BorderRadius = 15
        Me.GBT_INI_SESION.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBT_INI_SESION.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBT_INI_SESION.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBT_INI_SESION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBT_INI_SESION.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GBT_INI_SESION.ForeColor = System.Drawing.Color.White
        Me.GBT_INI_SESION.Location = New System.Drawing.Point(248, 462)
        Me.GBT_INI_SESION.Name = "GBT_INI_SESION"
        Me.GBT_INI_SESION.Size = New System.Drawing.Size(235, 68)
        Me.GBT_INI_SESION.TabIndex = 16
        Me.GBT_INI_SESION.Text = "Iniciar Sesión"
        '
        'GBT_CERRAR
        '
        Me.GBT_CERRAR.BorderRadius = 15
        Me.GBT_CERRAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBT_CERRAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBT_CERRAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBT_CERRAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBT_CERRAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GBT_CERRAR.ForeColor = System.Drawing.Color.White
        Me.GBT_CERRAR.Location = New System.Drawing.Point(511, 462)
        Me.GBT_CERRAR.Name = "GBT_CERRAR"
        Me.GBT_CERRAR.Size = New System.Drawing.Size(235, 68)
        Me.GBT_CERRAR.TabIndex = 17
        Me.GBT_CERRAR.Text = "Cerrar"
        '
        'FRM_LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 610)
        Me.Controls.Add(Me.GBT_CERRAR)
        Me.Controls.Add(Me.GBT_INI_SESION)
        Me.Controls.Add(Me.TXT_CLAVE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_CORREO)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_LOGIN"
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
End Class
