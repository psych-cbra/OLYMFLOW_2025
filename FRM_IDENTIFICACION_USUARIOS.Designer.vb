<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_IDENTIFICACION_USUARIOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_IDENTIFICACION_USUARIOS))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_NOMBRE_SEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BT_SALIR = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(-1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1015, 70)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Identificador de Usuarios"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_NOMBRE_SEARCH
        '
        Me.TXT_NOMBRE_SEARCH.BorderRadius = 20
        Me.TXT_NOMBRE_SEARCH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_NOMBRE_SEARCH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOMBRE_SEARCH.DefaultText = ""
        Me.TXT_NOMBRE_SEARCH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NOMBRE_SEARCH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NOMBRE_SEARCH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NOMBRE_SEARCH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NOMBRE_SEARCH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NOMBRE_SEARCH.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMBRE_SEARCH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NOMBRE_SEARCH.IconRight = CType(resources.GetObject("TXT_NOMBRE_SEARCH.IconRight"), System.Drawing.Image)
        Me.TXT_NOMBRE_SEARCH.Location = New System.Drawing.Point(105, 143)
        Me.TXT_NOMBRE_SEARCH.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TXT_NOMBRE_SEARCH.MaxLength = 20
        Me.TXT_NOMBRE_SEARCH.Name = "TXT_NOMBRE_SEARCH"
        Me.TXT_NOMBRE_SEARCH.PlaceholderText = "Digite el nombre de usuario a buscar"
        Me.TXT_NOMBRE_SEARCH.SelectedText = ""
        Me.TXT_NOMBRE_SEARCH.Size = New System.Drawing.Size(799, 42)
        Me.TXT_NOMBRE_SEARCH.TabIndex = 15
        '
        'L
        '
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HideSelection = False
        Me.L.Location = New System.Drawing.Point(12, 214)
        Me.L.MultiSelect = False
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(990, 295)
        Me.L.TabIndex = 16
        Me.L.UseCompatibleStateImageBehavior = False
        Me.L.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Usuario"
        Me.ColumnHeader2.Width = 402
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Correo Electrónico"
        Me.ColumnHeader3.Width = 396
        '
        'BT_SALIR
        '
        Me.BT_SALIR.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BT_SALIR.BorderRadius = 15
        Me.BT_SALIR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_SALIR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_SALIR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_SALIR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_SALIR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_SALIR.ForeColor = System.Drawing.Color.White
        Me.BT_SALIR.Image = CType(resources.GetObject("BT_SALIR.Image"), System.Drawing.Image)
        Me.BT_SALIR.Location = New System.Drawing.Point(727, 12)
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.Size = New System.Drawing.Size(275, 52)
        Me.BT_SALIR.TabIndex = 17
        Me.BT_SALIR.Text = "Salir"
        '
        'FRM_IDENTIFICACION_USUARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 633)
        Me.Controls.Add(Me.BT_SALIR)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.TXT_NOMBRE_SEARCH)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_IDENTIFICACION_USUARIOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_IDENTIFICACION_USUARIOS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_NOMBRE_SEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents BT_SALIR As Guna.UI2.WinForms.Guna2Button
End Class
