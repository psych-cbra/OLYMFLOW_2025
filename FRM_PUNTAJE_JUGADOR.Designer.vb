<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PUNTAJE_JUGADOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_PUNTAJE_JUGADOR))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LISTA = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        'LISTA
        '
        Me.LISTA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.LISTA.Font = New System.Drawing.Font("MADE TOMMY", 8.25!)
        Me.LISTA.FullRowSelect = True
        Me.LISTA.GridLines = True
        Me.LISTA.HideSelection = False
        Me.LISTA.Location = New System.Drawing.Point(57, 381)
        Me.LISTA.Margin = New System.Windows.Forms.Padding(2)
        Me.LISTA.MultiSelect = False
        Me.LISTA.Name = "LISTA"
        Me.LISTA.Size = New System.Drawing.Size(1058, 219)
        Me.LISTA.TabIndex = 19
        Me.LISTA.UseCompatibleStateImageBehavior = False
        Me.LISTA.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Código del Alumno"
        Me.ColumnHeader2.Width = 172
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre del Alumno"
        Me.ColumnHeader3.Width = 139
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nota"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Fecha de Ingreso"
        Me.ColumnHeader5.Width = 176
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Evidencia Fotográfica"
        Me.ColumnHeader6.Width = 553
        '
        'FRM_PUNTAJE_JUGADOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1178, 633)
        Me.Controls.Add(Me.LISTA)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_PUNTAJE_JUGADOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_PUNTAJE_JUGADOR"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents LISTA As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class
