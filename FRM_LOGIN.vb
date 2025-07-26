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
        Try
            SQL = "SELECT CORREO FROM USUARIO WHERE CORREO = '" & TXT_CORREO.Text & ""
            CARGAR_TABLA(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                'For FILA = 0 To T.Tables(0).Rows.Count - 1
                'ROLES.Items.Add(T.Tables(0).Rows(FILA).ItemArray(0))
                'USER_CORREO = (T.Tables(0).Rows(FILA).ItemArray(0))
                If TXT_CORREO.Text = SQL Then
                    USER_CORREO = (T.Tables(0).Rows(SQL).ItemArray(0))
                End If
                'Next
            Else
                MsgBox("No se encontró ninguna cuenta con ese correo.", vbInformation + vbOKOnly, "Datos no encontrados")
            End If

            If USER_CORREO <> "" Then
                SQL = "SELECT CLAVE FROM USUARIO WHERE CLAVE = '" & TXT_CLAVE.Text & ""
                CARGAR_TABLA(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    'For FILA = 0 To T.Tables(0).Rows.Count - 1
                    'ROLES.Items.Add(T.Tables(0).Rows(FILA).ItemArray(0))
                    USER_CLAVE = (T.Tables(0).Rows(SQL).ItemArray(0))
                    If TXT_CLAVE.Text = SQL Then
                        USER_CLAVE = (T.Tables(0).Rows(SQL).ItemArray(0))
                    End If
                    'Next
                Else
                    MsgBox("No se encontró ninguna cuenta con esa contraseña.", vbInformation + vbOKOnly, "Datos no encontrados")
                End If
            End If

            If USER_CORREO <> "" And USER_CLAVE <> "" Then
                SQL = "SELECT ROL FROM USUARIO WHERE CORREO = '" & TXT_CORREO.Text & "' AND CLAVE = '" & TXT_CLAVE.Text & ""
                CARGAR_TABLA(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    'ROLES.Items.Add(T.Tables(0).Rows(FILA).ItemArray(0))
                    USER_ROLE = (T.Tables(0).Rows(SQL).ItemArray(0))
                Else
                    MsgBox("El correo es incorrecto. Intente nuevamente.", vbInformation + vbOKOnly, "Datos incorrectos")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub
End Class