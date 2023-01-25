Imports System.Runtime.InteropServices
Public Class administracion
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub administracion_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub administracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Bcerrar_Click(sender As Object, e As EventArgs) Handles Bcerrar.Click
        Me.Close()
        sistemaprincipal.Show()
    End Sub
    Private Sub Bminimizar_Click(sender As Object, e As EventArgs) Handles Bminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Bempleado_Click(sender As Object, e As EventArgs) Handles Bempleado.Click
        empleados.Show()
        Me.Close()
    End Sub
    Private Sub Bproveedor_Click(sender As Object, e As EventArgs) Handles Bproveedor.Click
        proveedores.Show()
        Me.Close()
    End Sub
    Private Sub Bsucursales_Click(sender As Object, e As EventArgs) Handles Bsucursales.Click
        sucursales.Show()
        Me.Close()
    End Sub
End Class