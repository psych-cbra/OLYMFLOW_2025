Public Class FRM_ESTUDIANTE_MENU

    Friend Sub REFRESCAR_ROL()
        ROLES.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT DESCRIPCION FROM ROLES"

        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For FILA = 0 To T.Tables(0).Rows.Count - 1
                ROLES.Items.Add(T.Tables(0).Rows(FILA).ItemArray(0))
            Next
        End If
    End Sub

    Friend Sub REINICIAR()
        TXT_NOMBRE.Text = USER_NAME
        TXT_CORREO.Text = USER_CORREO
        TXT_CLAVE.Clear()
        REFRESCAR_ROL()
    End Sub

    Friend Sub ACTIVAR()
        If TXT_NOMBRE.Text <> "" And ROLES.Text <> "" And TXT_CORREO.Text <> "" AndAlso TXT_CLAVE.Text <> "" Then
            BT_MODIFICAR_USUARIO.Enabled = True
        Else
            BT_MODIFICAR_USUARIO.Enabled = False
        End If
    End Sub

    Private Sub FRM_ESTUDIANTE_MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BT_LOG_OUT_Click(sender As Object, e As EventArgs) Handles BT_LOG_OUT.Click
        Try
            If MsgBox("¿Desea cerrar la sesión de esta cuenta?", vbQuestion + vbYesNo, "Cierre de sesión") = vbYes Then
                USER_ROLE = 0
                USER_SESION = False
                USER_NAME = ""
                USER_CORREO = ""
                USER_FOTO = ""
                FOTO.Image = My.Resources.CATBOX
                MsgBox("Se ha cerrado la sesión exitosamente.", vbInformation + vbOKOnly, "Sesión cerrada")
                BT_LOG_OUT.Enabled = False
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub
End Class