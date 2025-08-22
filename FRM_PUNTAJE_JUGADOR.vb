Public Class FRM_PUNTAJE_JUGADOR
    Private Sub FRM_PUNTAJE_JUGADOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = FRM_MAIN
            NOMBRE_USUARIO.Text = USER_NAME
            FOTO.Image = Image.FromFile(USER_FOTO)
            PUNTAJE.Text = USER_SCORE
            'T.Tables.Clear()
            'SQL = "SELECT PUNTOS FROM SCORES WHERE  = " & USER_ID & ""
            'CARGAR_TABLA(T, SQL)

            'PUNTAJE.Text = T.Tables(0).Rows(0).ItemArray(0) ' puntos del jugador
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
                USER_SCORE = 0
                USER_ID = 0
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