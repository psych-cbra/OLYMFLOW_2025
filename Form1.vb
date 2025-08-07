Public Class Form1

    Friend Sub REFRESCAR_ROL()
        ROLES.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT DESCRIPCION FROM ROLES"

        CARGAR_TABLA(T, Sql)
        If T.Tables(0).Rows.Count > 0 Then
            For FILA = 0 To T.Tables(0).Rows.Count - 1
                ROLES.Items.Add(T.Tables(0).Rows(FILA).ItemArray(0))
            Next
        End If
    End Sub

    Friend Sub REINICIAR()
        TXT_NOMBRE.Clear()
        TXT_CORREO.Clear()
        TXT_CLAVE.Clear()
        REFRESCAR_ROL()
        PROFILE_PICTURE.Tag = ""
        PROFILE_PICTURE.Image = My.Resources.CATBOX
        NUEVO_USER = True
    End Sub

    Friend Sub ACTIVAR()
        If TXT_NOMBRE.Text <> "" And ROLES.Text <> "" And TXT_CORREO.Text <> "" AndAlso TXT_CLAVE.Text <> "" Then
            BT_GUARDAR.Enabled = True
        Else
            BT_GUARDAR.Enabled = False
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = FRM_MAIN
            REFRESCAR_ROL()
            NUEVO_USER = True
            If Application.OpenForms().OfType(Of FRM_LOGIN)().Any() Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        Try
            Me.Close()
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

    Private Sub TXT_CLAVE_TextChanged(sender As Object, e As EventArgs) Handles TXT_CLAVE.TextChanged
        Try
            ACTIVAR()
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub


    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        Try
            If TXT_NOMBRE.Text <> "" And TXT_CORREO.Text <> "" And TXT_CLAVE.Text <> "" Then
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
                    If NUEVO_USER = True Then
                        SQL = "INSERT INTO USUARIO (ID, NOMBRE, CLAVE, CORREO, ROL, FOTO) VALUES(" & PK("USUARIO", "ID") & ", '" & TXT_NOMBRE.Text & "', '" & TXT_CLAVE.Text & "','" & TXT_CORREO.Text & "','" & rol_nombre & "', '" & PROFILE_PICTURE.Tag & "')"
                    Else
                        SQL = "UPDATE USUARIO SET NOMBRE = '" & TXT_NOMBRE.Text & "', CLAVE = '" & TXT_CLAVE.Text & "', CORREO = '" & TXT_CORREO.Text & "', ROL = '" & rol_nombre & "', FOTO = '" & PROFILE_PICTURE.Tag & ""
                    End If

                    EJECUTAR(SQL)
                    REINICIAR()
                    MsgBox("La información ha sido almacenada satisfactoriamente.", vbInformation + vbOKOnly, "Transacción exitosa")
                Else
                    MsgBox("No ha ingresado un correo válido. Favor de verificar que este sea correcto", vbOKOnly, "Correo no válido")
                End If
            Else
                MsgBox("Favor de asegurarse de rellenar todos los espacios correspondientes.", vbOKOnly, "Espacios no rellenados")
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub PROFILE_PICTURE_Click(sender As Object, e As EventArgs) Handles PROFILE_PICTURE.Click
        Try
            If ABRIR.ShowDialog = DialogResult.OK Then
                'Se eligió un archivo
                PROFILE_PICTURE.Image = Image.FromFile(ABRIR.FileName)
                PROFILE_PICTURE.Tag = ABRIR.FileName
            Else
                PROFILE_PICTURE.Tag = ""
                PROFILE_PICTURE.Image = My.Resources.CATBOX
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub ROLES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ROLES.SelectedIndexChanged
        Try
            ACTIVAR()
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try

    End Sub
End Class
