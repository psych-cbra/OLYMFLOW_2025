Public Class FRM_LOGIN
    Private Sub FRM_LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FRM_MAIN
        If Application.OpenForms().OfType(Of Form1)().Any() Then
            Me.Close()
        End If
    End Sub

    Private Sub GBT_CERRAR_Click(sender As Object, e As EventArgs) Handles GBT_CERRAR.Click
        Me.Close()
    End Sub

    Private Sub GBT_INI_SESION_Click(sender As Object, e As EventArgs) Handles GBT_INI_SESION.Click

    End Sub
End Class