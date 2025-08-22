Public Class FRM_QUESTION
    Dim num_pregunta As Integer = 10
    Dim total_preguntas As Integer
    Dim respuesta_correcta As Integer
    Dim respuesta_tema As Integer
    Friend Sub REINICIAR(ByVal CANTIDAD As Integer)
        Dim ID As Integer = Int((CANTIDAD * Rnd()) + 1)
        'IDA_OBJ = ID
        T.Tables.Clear()
        SQL = "SELECT TESTO_Q, RESPUESTA_A, RESPUESTA_B, RESPUESTA_C, RESPUESTA_D, TEMAS_ID, RES_CORRECTA FROM QUESTIONS_REAL WHERE ID = " & ID & ""
        CARGAR_TABLA(T, SQL)

        PREGUNTA.Text = T.Tables(0).Rows(0).ItemArray(0) ' texto de la pregunta
        RES_A_TEXT.Text = T.Tables(0).Rows(0).ItemArray(1) ' respuesta A de la pregunta
        RES_B_TEXT.Text = T.Tables(0).Rows(0).ItemArray(2) ' respuesta B de la pregunta
        RES_C_TEXT.Text = T.Tables(0).Rows(0).ItemArray(3) ' respuesta C de la pregunta
        RES_D_TEXT.Text = T.Tables(0).Rows(0).ItemArray(4) ' respuesta C de la pregunta
        respuesta_tema = T.Tables(0).Rows(0).ItemArray(5) ' tema de la pregunta
        respuesta_correcta = T.Tables(0).Rows(0).ItemArray(6) ' respuesta correcta de la pregunta

        TIEMPO.Value = 20
        If num_pregunta > 0 And num_pregunta <> 10 Then
            num_pregunta -= 1
        End If
    End Sub
    Private Sub FRM_QUESTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = FRM_MAIN

            T.Tables.Clear()
            SQL = "SELECT COUNT(*) FROM QUESTIONS_REAL"
            CARGAR_TABLA(T, SQL)
            total_preguntas = T.Tables(0).Rows(0).ItemArray(0) ' cantidad total de preguntas :3
            REINICIAR(total_preguntas)
            For i = 20 To 0
                If TIEMPO.Value > 0 Then
                    TIEMPO.Value = TIEMPO.Value - 1
                End If
            Next
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub GBT_RESPUESTA_A_Click(sender As Object, e As EventArgs) Handles GBT_RESPUESTA_A.Click
        Try
            If respuesta_correcta <> 1 And num_pregunta < 10 Then
                num_pregunta += 1
                REINICIAR(total_preguntas)
            ElseIf num_pregunta <> 0 Then
                num_pregunta -= 1
                REINICIAR(total_preguntas)
            Else
                FRM_PUNTAJE_JUGADOR.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub GBT_RESPUESTA_B_Click(sender As Object, e As EventArgs) Handles GBT_RESPUESTA_B.Click
        Try
            If respuesta_correcta <> 2 And num_pregunta < 10 Then
                num_pregunta += 1
                REINICIAR(total_preguntas)
            ElseIf num_pregunta <> 0 Then
                num_pregunta -= 1
                REINICIAR(total_preguntas)
            Else
                FRM_PUNTAJE_JUGADOR.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub GBT_RESPUESTA_C_Click(sender As Object, e As EventArgs) Handles GBT_RESPUESTA_C.Click
        Try
            If respuesta_correcta <> 3 And num_pregunta < 10 Then
                num_pregunta += 1
                REINICIAR(total_preguntas)
            ElseIf num_pregunta <> 0 Then
                num_pregunta -= 1
                REINICIAR(total_preguntas)
            Else
                FRM_PUNTAJE_JUGADOR.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub GBT_RESPUESTA_D_Click(sender As Object, e As EventArgs) Handles GBT_RESPUESTA_D.Click
        Try
            If respuesta_correcta <> 1 And num_pregunta < 10 Then
                num_pregunta += 1
                REINICIAR(total_preguntas)
            ElseIf num_pregunta <> 0 Then
                num_pregunta -= 1
                REINICIAR(total_preguntas)
            Else
                FRM_PUNTAJE_JUGADOR.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub
End Class