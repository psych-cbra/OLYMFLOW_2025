Public Class FRM_CREAR_SALA

    Friend Sub REFRESCAR_ANSWER()
        RESPUESTAS.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT RESPUESTA FROM CORRECT_ANSWER"

        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For FILA = 0 To T.Tables(0).Rows.Count - 1
                RESPUESTAS.Items.Add(T.Tables(0).Rows(FILA).ItemArray(0))
            Next
        End If
    End Sub

    Friend Sub REINICIAR()
        TXT_PREGUNTA.Clear()
        TXT_RESPUESTA_A.Clear()
        TXT_RESPUESTA_B.Clear()
        TXT_RESPUESTA_C.Clear()
        TXT_RESPUESTA_D.Clear()
        REFRESCAR_ANSWER()
    End Sub

    Friend Sub ACTIVAR()
        If TXT_PREGUNTA.Text <> "" And RESPUESTAS.Text <> "" And TXT_RESPUESTA_A.Text <> "" AndAlso TXT_RESPUESTA_B.Text <> "" And TXT_RESPUESTA_C.Text <> "" And TXT_RESPUESTA_D.Text <> "" Then
            BT_SUBIR_PREGUNTA.Enabled = True
        Else
            BT_SUBIR_PREGUNTA.Enabled = False
        End If
    End Sub

    Private Sub FRM_CREAR_SALA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = FRM_MAIN
            REFRESCAR_ANSWER()
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub NUD_USERS_ALLOWED_ValueChanged(sender As Object, e As EventArgs) Handles NUD_USERS_ALLOWED.ValueChanged
        NUD_USERS_ALLOWED.Value = CInt(Math.Round(NUD_USERS_ALLOWED.Value))
    End Sub

    Private Sub TXT_PREGUNTA_TextChanged(sender As Object, e As EventArgs) Handles TXT_PREGUNTA.TextChanged
        Try
            ACTIVAR()
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub TXT_RESPUESTA_A_TextChanged(sender As Object, e As EventArgs) Handles TXT_RESPUESTA_A.TextChanged
        Try
            ACTIVAR()
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub TXT_RESPUESTA_B_TextChanged(sender As Object, e As EventArgs) Handles TXT_RESPUESTA_B.TextChanged
        Try
            ACTIVAR()
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub TXT_RESPUESTA_C_TextChanged(sender As Object, e As EventArgs) Handles TXT_RESPUESTA_C.TextChanged
        Try
            ACTIVAR()
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub TXT_RESPUESTA_D_TextChanged(sender As Object, e As EventArgs) Handles TXT_RESPUESTA_D.TextChanged
        Try
            ACTIVAR()
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub RESPUESTAS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RESPUESTAS.SelectedIndexChanged
        Try
            ACTIVAR()
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub
End Class