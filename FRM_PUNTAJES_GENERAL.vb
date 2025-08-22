Public Class FRM_PUNTAJES_GENERAL

    Friend Sub BUSCANDO(ByVal CONTENIDO As String)
        T.Tables.Clear()
        LISTA.Items.Clear()

        SQL = "SELECT ID, PUNTOS, JUGADOR_NOMBRE FROM SCORES WHERE JUGADOR_NOMBRE LIKE '%" & CONTENIDO & "%'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                LISTA.Items.Add(T.Tables(0).Rows(I).ItemArray(0))
                For J = 1 To 2
                    LISTA.Items(LISTA.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).ItemArray(J))
                Next
            Next
        End If
    End Sub

    Private Sub GBT_BACK_Click(sender As Object, e As EventArgs) Handles GBT_BACK.Click
        FRM_PROFESOR_MENU.Show()
        Me.Close()
    End Sub

    Private Sub FRM_PUNTAJES_GENERAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = FRM_MAIN
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub LISTA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LISTA.SelectedIndexChanged
        Try
            If LISTA.SelectedItems.Count > 0 Then
                Dim ID As Integer = LISTA.SelectedItems(0).SubItems(0).Text
                'IDA_OBJ = ID
                T.Tables.Clear()
                SQL = "SELECT ID, PUNTOS, JUGADOR_NOMBRE FROM SCORES WHERE ID = " & ID & ""
                CARGAR_TABLA(T, SQL)
            End If
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub

    Private Sub TXT_BUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXT_BUSCAR.TextChanged
        Try
            BUSCANDO(TXT_BUSCAR.Text)
        Catch ex As Exception
            MsgBox("Error técnico:" & vbCrLf & ex.Message, vbOKOnly, "Error del Programa")
        End Try
    End Sub
End Class