Public Class FRM_INVITADO_MENU
    Private Sub FRM_INVITADO_MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = FRM_MAIN
            NOMBRE_USUARIO.Text = USER_NAME
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub
End Class