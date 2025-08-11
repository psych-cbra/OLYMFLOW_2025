Public Class FRM_CREAR_SALA
    Private Sub FRM_CREAR_SALA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = FRM_MAIN
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub NUD_USERS_ALLOWED_ValueChanged(sender As Object, e As EventArgs) Handles NUD_USERS_ALLOWED.ValueChanged
        NUD_USERS_ALLOWED.Value = CInt(Math.Round(NUD_USERS_ALLOWED.Value))
    End Sub
End Class