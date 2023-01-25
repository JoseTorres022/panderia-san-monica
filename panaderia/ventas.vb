Imports System.Runtime.InteropServices
Public Class ventas
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub ventas_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mensaje si es que se establece la conexion
        MsgBox("Conexion establecida correctamente", MsgBoxStyle.Information, "Santa Monica")
        leerBD()
    End Sub
    Dim obj As New CRUDPan
    Sub leerBD()
        obj.conexion()
        Dim Sql As String = "Select * From ventas"
        obj.consulta(DGventas, Sql)
    End Sub
    Private Sub Bagregar_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
        'Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Insert Into ventas (idTicket, producto, precioUnidad, piezasVendidas, totalTicket, fecha) Values " & "('" & TbId.Text & "'," &
                                                                                                                  "'" & TbProducto.Text & "'," &
                                                                                                                  "'" & TbPreUnidad.Text & "'," &
                                                                                                                  "'" & TbPieVendidas.Text & "'," &
                                                                                                                  "'" & TbTotalTicket.Text & "'," &
                                                                                                                  "'" & TbFecha.Text & "');"
        obj.operaciones(DGventas, Sql)
        MsgBox("Datos guardamos correctamente", MsgBoxStyle.Information, "Santa Monica")
        leerBD()
    End Sub
    Private Sub Brefresh_Click(sender As Object, e As EventArgs) Handles Brefresh.Click
        leerBD()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sistemaprincipal.Show()
        Me.Close()
    End Sub
End Class