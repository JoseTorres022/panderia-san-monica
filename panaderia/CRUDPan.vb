'importamos la libreria SQlite
Imports System.Data.SQLite
Public Class CRUDPan
    'Creamos la conexion de la base de datos
    Dim con As New SQLiteConnection("Data Source=panaderia.db; Version=3;")

    'creamos el procedimiento de conexion
    Sub conexion()
        'usamos el Try para capturar errores
        Try
            'abrimos la conexion
            con.Open()

            'cerramos la conexion
            con.Close()
        Catch ex As Exception
            'mensaje si es que sale algun error
            MsgBox("Ha ocurrido un error, posible causa: " & ex.Message, MsgBoxStyle.Critical, "Santa Monica")
        End Try
    End Sub

    'creamos un procedimiento para la consulta y le indicamos que debe obtener 2 parametros
    'para ejecutarse correctamente
    Sub consulta(ByVal tabla As DataGridView, ByVal sql As String)
        'usamos Try para capturar los errores
        Try
            'creamos un objeto de tipo SQLiteDataAdapter con dos parametros
            Dim sqlda As New SQLiteDataAdapter(sql, con)
            'creamos ootr objeto de tipo DataTable
            Dim dt As New DataTable
            'psamos la informacion del SQLiteDataAdapter al DataTable mediente la propiedad Fill
            sqlda.Fill(dt)
            'aqui mostramos los datos en el DataGridView
            tabla.DataSource = dt
        Catch ex As Exception
            MsgBox("Ha ocurrido un en la cosulta, posible causa: " & ex.Message, MsgBoxStyle.Critical, "Santa Monica")
        End Try
    End Sub

    'creamos un procedimiento para Agregar,Actualizar y Eliminar,
    'le indicamos que debe pedir 2 parametros para ejecutarse correctamente
    Sub operaciones(ByVal tabla As DataGridView, ByVal sql As String)
        'abrimos la conexion
        con.Open()
        'usamos el Try para capturar errores
        Try
            'creamos un objeto de tipo Command que almacenara las intrucciones
            'necesita 2 parametros para ejecutarse
            Dim cmd As New SQLiteCommand(sql, con)
            'ejecutamos la instruccione mediante la proiedad ExcuteNonQuery
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Ha ocurrido un en la operacion, posible causa: " & ex.Message, MsgBoxStyle.Critical, "Santa Monica")
        End Try
        'cerramos la conexion
        con.Close()
    End Sub
End Class