Imports System.Runtime.InteropServices
Public Class sucursales
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        administracion.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub sucursales_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Dim obj As New CRUDPan
    Private Sub sucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mensaje si es que se establece la conexion
        MsgBox("Conexion establecida correctamente", MsgBoxStyle.Information, "Santa Monica")
        leerBD()
    End Sub
    Sub leerBD()
        obj.conexion()
        Dim Sql As String = "Select * From sucursal"
        obj.consulta(DGsucursales, Sql)
    End Sub

    Private Sub Bagregar_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
        'Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Insert Into sucursal (idSucursal, nomSucursal, dirSucursal) Values " & "('" & TbId.Text & "'," &
                                                                                                     "'" & TbNomSucursal.Text & "'," &
                                                                                                     "'" & TbDirSucursal.Text & "');"
        obj.operaciones(DGsucursales, Sql)
        MsgBox("Datos guardados correctamente", MsgBoxStyle.Information, "Santa Monica")
        leerBD()
    End Sub

    Private Sub Beliminar_Click(sender As Object, e As EventArgs) Handles Beliminar.Click
        'Creamos la variable Sql que eliminara la instruccion de tipo SQL
        Dim Sql As String = "Delete From sucursal Where idSucursal = " & TbId.Text & ""
        obj.operaciones(DGsucursales, Sql)
        leerBD()
    End Sub

    Private Sub Bactualizar_Click(sender As Object, e As EventArgs) Handles Bactualizar.Click
        'Creamos la variable Sql que actualizara la instruccion de tipo SQL
        Dim Sql As String = "Update sucursal Set nomSucursal='" & TbNomSucursal.Text & "',dirSucursal='" & TbDirSucursal.Text & "' Where idSucursal = " & TbId.Text & ""
        obj.operaciones(DGsucursales, Sql)
        leerBD()
    End Sub

    Private Sub Brefresh_Click(sender As Object, e As EventArgs) Handles Brefresh.Click
        leerBD()
    End Sub
End Class