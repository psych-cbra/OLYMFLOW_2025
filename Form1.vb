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
        PROFILE_PICTURE.Image = My.Resources.Cardboard_Man__1_
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
        Me.Close()
    End Sub

    Private Sub TXT_NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOMBRE.TextChanged
        ACTIVAR()
    End Sub

    Private Sub TXT_CORREO_TextChanged(sender As Object, e As EventArgs) Handles TXT_CORREO.TextChanged
        ACTIVAR()
    End Sub

    Private Sub TXT_CLAVE_TextChanged(sender As Object, e As EventArgs) Handles TXT_CLAVE.TextChanged
        ACTIVAR()
    End Sub


    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        Try

            If NUEVO_USER = True Then
                SQL = "INSERT INTO USUARIO (ID, NOMBRE, CLAVE, FOTO, CORREO, ROL) VALUES(" & PK("USUARIO", "ID") & ", '" & TXT_NOMBRE.Text & "', '" & TXT_CLAVE.Text & "','" & PROFILE_PICTURE.Tag & "','" & TXT_CORREO.Text & "','" & ROLES.Text & "')"
            Else
                SQL = "UPDATE USUARIO SET NOMBRE = '" & TXT_NOMBRE.Text & "', CLAVE = '" & TXT_CLAVE.Text & "', CORREO = '" & TXT_CORREO.Text & "', ROL = '" & ROLES.Text & "', FOTO = '" & PROFILE_PICTURE.Tag & ""
            End If

            EJECUTAR(SQL)
            REINICIAR()
            MsgBox("La información ha sido almacenada satisfactoriamente.", vbInformation + vbOKOnly, "Transacción exitosa")
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
                PROFILE_PICTURE.Image = My.Resources.Cardboard_Man__1_
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub ROLES_SelectedIndexChanged(sender As Object, e As EventArgs)
        ACTIVAR()
    End Sub
End Class
