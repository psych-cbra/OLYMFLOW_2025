Module BASE_DATOS
    Public Db As New OleDb.OleDbConnection 'Esta es la variable que representa la Base de Datos
    Public T As New DataSet '   T es la variable que trae informacion
    Public SQL As String '  Esta es la variable string que se usa para importar/exportar informacion de la Base de Datos

    Friend Sub CONECTAR()
        Dim Ruta As String
        Ruta = "File Name=" & Application.StartupPath & "\route.udl" '   Conecta la Base de Datos con el Proyecto
        Db.ConnectionString = Ruta
        Db.Open()
    End Sub

    Friend Sub DESCONECTAR() '  Desconecta la Base de Datos para que no quede abierta
        Db.Close()
    End Sub

    Friend Sub CARGAR_TABLA(ByRef Tabla_Temporal As DataSet, ByVal Sql As String) ' Importa parametros de una tabla de la Base de Datos
        CONECTAR()
        Dim Consulta As New OleDb.OleDbDataAdapter(Sql, Db)
        Consulta.Fill(Tabla_Temporal)
        DESCONECTAR()
    End Sub

    Friend Sub EJECUTAR(ByVal Sql As String) '  Metodo para añadir, actualizar o quitar información de la Base de Datos
        CONECTAR()
        Dim Comando As New OleDb.OleDbCommand(Sql, Db)
        Comando.ExecuteNonQuery()
        DESCONECTAR()
    End Sub
    '   Crea una llave primaria para una tabla
    Function PK(ByVal TABLA As String, ByVal ID As String) As Integer
        T.Tables.Clear()
        SQL = "SELECT " & ID & " FROM " & TABLA
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            T.Tables.Clear()
            SQL = "SELECT MAX(ID) FROM " & TABLA
            CARGAR_TABLA(T, SQL)
            PK = T.Tables(0).Rows(0).ItemArray(0) + 1
        Else
            PK = 1
        End If
    End Function
End Module
