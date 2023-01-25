Imports System.Runtime.InteropServices
Public Class pedidos
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub pedidos_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Dim obj As New CRUDPan
    Private Sub pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mensaje si es que se establece la conexion
        MsgBox("Conexion establecida correctamente", MsgBoxStyle.Information, "Santa Monica")
        leerBD()
    End Sub
    Sub leerBD()
        obj.conexion()
        Dim Sql As String = "Select * From pedidos"
        obj.consulta(DGpedidos, Sql)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sistemaprincipal.Show()
        Me.Close()
    End Sub
    Private Sub Bagregar_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
        'Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Insert Into pedidos (idPedido, cliente, producto, unidades, precioTotal) Values " & "('" & TbId.Text & "'," &
                                                                                                                  "'" & TbCliente.Text & "'," &
                                                                                                                  "'" & TbProductos.Text & "'," &
                                                                                                                  "'" & TbUnidades.Text & "'," &
                                                                                                                  "'" & TbTotal.Text & "');"
        obj.operaciones(DGpedidos, Sql)
        MsgBox("Datos guardamos correctamente", MsgBoxStyle.Information, "Santa Monica")
        leerBD()
    End Sub
    Private Sub Beliminar_Click(sender As Object, e As EventArgs) Handles Beliminar.Click
        'Creamos la variable Sql que eliminara la instruccion de tipo SQL
        Dim Sql As String = "Delete From pedidos Where idPedido = " & TbId.Text & ""
        obj.operaciones(DGpedidos, Sql)
        leerBD()
    End Sub
    Private Sub Bactualizar_Click(sender As Object, e As EventArgs) Handles Bactualizar.Click
        'Creamos la variable Sql que actualizara la instruccion de tipo SQL
        Dim Sql As String = "Update pedidos Set cliente='" & TbCliente.Text & "',producto='" & TbProductos.Text & "',unidades='" & TbUnidades.Text & "',precioTotal='" & TbTotal.Text & "' Where idPedido= " & TbId.Text & ""
        obj.operaciones(DGpedidos, Sql)
        leerBD()
    End Sub
    Private Sub Brefresh_Click(sender As Object, e As EventArgs) Handles Brefresh.Click
        leerBD()
    End Sub
End Class