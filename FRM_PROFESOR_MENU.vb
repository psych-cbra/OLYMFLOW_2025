Public Class FRM_PROFESOR_MENU
    Private Sub FRM_PROFESOR_MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = FRM_MAIN
            NOMBRE_USUARIO.Text = USER_NAME
            FOTO.Image = Image.FromFile(USER_FOTO)
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub BT_BORRAR_CUENTA_Click(sender As Object, e As EventArgs) Handles BT_BORRAR_CUENTA.Click
        Try
            If MsgBox("¿Está seguro de querer eliminar su cuenta? Una vez eliminada, no se podrá recuperar.", vbQuestion + vbYesNo, "Confirme") = vbYes Then
                SQL = "DELETE FROM USUARIO WHERE NOMBRE = '" & USER_NAME & "' AND CORREO = '" & USER_CORREO & "'"
                EJECUTAR(SQL)
                MsgBox("Su cuenta ha sido eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Cuenta eliminada")
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub
End Class