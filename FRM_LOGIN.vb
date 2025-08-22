Public Class FRM_LOGIN
    Private Sub FRM_LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = FRM_MAIN
            If USER_FOTO <> "" Then
                FOTO.Image = Image.FromFile(USER_FOTO)
            Else
                FOTO.Image = My.Resources.CATBOX
            End If

            If USER_NAME <> "" And USER_CORREO <> "" Then
                BT_LOG_OUT.Enabled = True
            Else
                BT_LOG_OUT.Enabled = False
            End If
            If Application.OpenForms().OfType(Of Form1)().Any() Then
                MsgBox("No puede abrir más de un menú a la vez.", vbInformation + vbOKOnly, "Más de un menú abierto")
                Me.Close()
            ElseIf Application.OpenForms().OfType(Of FRM_ESTUDIANTE_MENU)().Any() Then
                MsgBox("No puede abrir más de un menú a la vez.", vbInformation + vbOKOnly, "Más de un menú abierto")
                Me.Close()
            ElseIf Application.OpenForms().OfType(Of FRM_INVITADO_MENU)().Any() Then
                MsgBox("No puede abrir más de un menú a la vez.", vbInformation + vbOKOnly, "Más de un menú abierto")
                Me.Close()
            ElseIf Application.OpenForms().OfType(Of FRM_PROFESOR_MENU)().Any() Then
                MsgBox("No puede abrir más de un menú a la vez.", vbInformation + vbOKOnly, "Más de un menú abierto")
                Me.Close()
            ElseIf Application.OpenForms().OfType(Of FRM_CREAR_SALA)().Any() Then
                MsgBox("No puede abrir más de un menú a la vez.", vbInformation + vbOKOnly, "Más de un menú abierto")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub GBT_CERRAR_Click(sender As Object, e As EventArgs) Handles GBT_CERRAR.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try

    End Sub

    Private Sub GBT_INI_SESION_Click(sender As Object, e As EventArgs) Handles GBT_INI_SESION.Click
        Try
            If TXT_CLAVE.Text <> "" And TXT_CORREO.Text <> "" And USER_SESION = False Then
                Dim ID As Integer
                T.Tables.Clear()
                SQL = "SELECT ID, NOMBRE, CLAVE, CORREO, ROL, FOTO FROM USUARIO WHERE CORREO = '" & TXT_CORREO.Text & "' AND CLAVE = '" & TXT_CLAVE.Text & "'"
                CARGAR_TABLA(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    If TXT_CORREO.Text = T.Tables(0).Rows(0).ItemArray(3) And TXT_CLAVE.Text = T.Tables(0).Rows(0).ItemArray(2) Then
                        USER_ID = T.Tables(0).Rows(0).ItemArray(0) ' id del usuario
                        USER_ROLE = T.Tables(0).Rows(0).ItemArray(4) ' rol del usuario
                        USER_NAME = T.Tables(0).Rows(0).ItemArray(1) ' nombre del usuario
                        USER_CORREO = T.Tables(0).Rows(0).ItemArray(3) ' correo del usuario :3
                        If T.Tables(0).Rows(0).ItemArray(5) <> "" Then
                            FOTO.Image = Image.FromFile(T.Tables(0).Rows(0).ItemArray(5)) ' foto del usuario
                            USER_FOTO = T.Tables(0).Rows(0).ItemArray(5)
                        End If
                        'FOTO.Image = Image.FromFile(T.Tables(0).Rows(0).ItemArray(4)) ' foto del usuario
                        'USER_FOTO = T.Tables(0).Rows(0).ItemArray(4)
                        USER_SESION = True
                        NUEVO_USER = False
                        BT_LOG_OUT.Enabled = True
                        MsgBox("Se inició la sesión exitosamente.", vbInformation + vbOKOnly, "Sesión Iniciada")
                        If USER_ROLE = 1 Then
                            FRM_PROFESOR_MENU.Show()
                            Me.Close()
                        ElseIf USER_ROLE = 2 Then
                            FRM_ESTUDIANTE_MENU.Show()
                            Me.Close()
                        ElseIf USER_ROLE = 3 Then
                            FRM_INVITADO_MENU.Show()
                            Me.Close()
                        End If
                    Else
                        MsgBox("El correo y/o la contraseña ingresados son incorrectos. Favor de ingresar el correo y contraseña correspondiente a su cuenta.", vbExclamation + vbOKOnly, "Valores incorrectos")
                    End If
                Else
                    MsgBox("No se encontró ninguna cuenta con ese correo y/o contraseña.", vbExclamation + vbOKOnly, "Datos no encontrados")
                End If
            ElseIf USER_SESION = True Then
                MsgBox("Ya se ha iniciado sesión anteriormente.", vbInformation + vbOKOnly, "Sesión ya iniciada")
            Else
                MsgBox("Es necesario ingresar un correo y una contraseña para ingresar.", vbExclamation + vbOKOnly, "Espacios vacíos")

            End If

            'SQL = "Select CORREO FROM USUARIO WHERE CORREO = '" & TXT_CORREO.Text & ""
            'CARGAR_TABLA(T, SQL)
            'If T.Tables(0).Rows.Count > 0 Then
            'For FILA = 0 To T.Tables(0).Rows.Count - 1
            'ROLES.Items.Add(T.Tables(0).Rows(FILA).ItemArray(0))
            'USER_CORREO = (T.Tables(0).Rows(FILA).ItemArray(0))
            'If TXT_CORREO.Text = SQL Then
            'USER_CORREO = (T.Tables(0).Rows(SQL).ItemArray(0))
            'End If
            'Next
            'Else
            'MsgBox("No se encontró ninguna cuenta con ese correo.", vbInformation + vbOKOnly, "Datos no encontrados")
            'End If

            'If USER_CORREO <> "" Then
            'SQL = "SELECT CLAVE FROM USUARIO WHERE CLAVE = '" & TXT_CLAVE.Text & ""
            'CARGAR_TABLA(T, SQL)
            'If T.Tables(0).Rows.Count > 0 Then
            'For FILA = 0 To T.Tables(0).Rows.Count - 1
            'ROLES.Items.Add(T.Tables(0).Rows(FILA).ItemArray(0))
            'USER_CLAVE = (T.Tables(0).Rows(SQL).ItemArray(0))
            'If TXT_CLAVE.Text = SQL Then
            'USER_CLAVE = (T.Tables(0).Rows(SQL).ItemArray(0))
            'End If
            'Next
            'Else
            'MsgBox("No se encontró ninguna cuenta con esa contraseña.", vbInformation + vbOKOnly, "Datos no encontrados")
            'End If
            'End If

            'If USER_CORREO <> "" And USER_CLAVE <> "" Then
            'SQL = "SELECT ROL FROM USUARIO WHERE CORREO = '" & TXT_CORREO.Text & "' AND CLAVE = '" & TXT_CLAVE.Text & ""
            'CARGAR_TABLA(T, SQL)
            'If T.Tables(0).Rows.Count > 0 Then
            'ROLES.Items.Add(T.Tables(0).Rows(FILA).ItemArray(0))
            'USER_ROLE = (T.Tables(0).Rows(SQL).ItemArray(0))
            'Else
            'MsgBox("El correo es incorrecto. Intente nuevamente.", vbInformation + vbOKOnly, "Datos incorrectos")
            'End If
            'End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub TXT_CLAVE_TextChanged(sender As Object, e As EventArgs) Handles TXT_CLAVE.TextChanged

    End Sub

    Private Sub TXT_CORREO_TextChanged(sender As Object, e As EventArgs) Handles TXT_CORREO.TextChanged

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
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub
End Class