Public Class FRM_PROFESOR_MENU

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

    Private Sub FRM_PROFESOR_MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = FRM_MAIN
            NOMBRE_USUARIO.Text = USER_NAME
            REFRESCAR_ROL()
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

    Private Sub TXT_NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOMBRE.TextChanged
        Try
            ACTIVAR()
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TXT_CORREO_TextChanged(sender As Object, e As EventArgs) Handles TXT_CORREO.TextChanged
        Try
            If TXT_CORREO.Text <> "" Then
                'If TXT_CORREO.Text.Contains("@") And TXT_CORREO.Text.Contains(".") Then
                ACTIVAR()
            End If
            'Else
            'MsgBox("No ha ingresado un correo válido. Favor de verificar que este sea correcto", vbOKOnly, "Correo no válido")
            'End If
            'End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TXT_CLAVE_TextChanged(sender As Object, e As EventArgs) Handles TXT_CLAVE.TextChanged
        Try
            ACTIVAR()
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ROLES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ROLES.SelectedIndexChanged
        Try
            ACTIVAR()
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub BT_MODIFICAR_USUARIO_Click(sender As Object, e As EventArgs) Handles BT_MODIFICAR_USUARIO.Click
        Try
            If TXT_CORREO.Text.Contains("@") And TXT_CORREO.Text.Contains(".") Then
                Dim rol_nombre As Integer
                If ROLES.Text = "PROFESOR" Then
                    rol_nombre = 1
                ElseIf ROLES.Text = "ESTUDIANTE" Then
                    rol_nombre = 2
                ElseIf ROLES.Text = "INVITADO" Then
                    rol_nombre = 3
                ElseIf ROLES.Text = "TEST" Then
                    rol_nombre = 616
                    If MsgBox("You should delete this column NOW!!!!!!", vbCritical + vbOKOnly, "THE SUN SMILES AT YOU WITH ETERNAL MALICE Ü") = vbOK Then
                        End
                    End If

                End If
                Dim FOTOFU As String = FOTO.Tag
                SQL = "UPDATE USUARIO SET NOMBRE = '" & TXT_NOMBRE.Text & "', CLAVE = '" & TXT_CLAVE.Text & "', CORREO = '" & TXT_CORREO.Text & "', ROL = '" & rol_nombre & "', FOTO = '" & FOTO.Tag & "' WHERE ID = " & USER_ID & ""
                'SQL = "UPDATE USUARIO SET NOMBRE = '" & TXT_NOMBRE.Text & "', CLAVE = '" & TXT_CLAVE.Text & "', CORREO = '" & TXT_CORREO.Text & "', ROL = '" & rol_nombre & "', FOTO = '" & PROFILE_PICTURE.Tag & "' WHERE ID = " & IDA_OBJ & ""

                EJECUTAR(SQL)
                REINICIAR()
                'Debug.Print(PROFILE_PICTURE.Tag)
                MsgBox("La información ha sido actualizada satisfactoriamente.", vbInformation + vbOKOnly, "Actualización exitosa")
            Else
                MsgBox("No ha ingresado un correo válido. Favor de verificar que este sea correcto", vbOKOnly, "Correo no válido")
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub GBT_ENCUESTA_Click(sender As Object, e As EventArgs) Handles GBT_ENCUESTA.Click
        FRM_CREAR_SALA.Show()
        Me.Close()
    End Sub

    Private Sub GBT_PUNTAJES_Click(sender As Object, e As EventArgs) Handles GBT_PUNTAJES.Click
        FRM_PUNTAJES_GENERAL.Show()
        Me.Close()
    End Sub
End Class