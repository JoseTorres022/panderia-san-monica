Imports System.Runtime.InteropServices
Public Class proveedores

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub proveedores_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Dim obj As New CRUDPan
    Private Sub proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mensaje si es que se establece la conexion
        MsgBox("Conexion establecida correctamente", MsgBoxStyle.Information, "Santa Monica")
        leerBD()
    End Sub
    Sub leerBD()
        obj.conexion()
        Dim Sql As String = "Select * From proveedores"
        obj.consulta(DGproveedores, Sql)
    End Sub

    Private Sub Brefresh_Click(sender As Object, e As EventArgs) Handles Brefresh.Click
        leerBD()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        administracion.Show()
    End Sub

    Private Sub Bagregar_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
        'Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Insert Into proveedores (idProveedor, nomProveedor, nomRepartidor, unidadProveedor) Values " & "('" & TbId.Text & "'," &
                                                                                                              "'" & TbNombre.Text & "'," &
                                                                                                              "'" & TbRepartidor.Text & "'," &
                                                                                                              "'" & TbUnidad.Text & "');"
        obj.operaciones(DGproveedores, Sql)
        MsgBox("Datos guardamos correctamente", MsgBoxStyle.Information, "Santa Monica")
        leerBD()
    End Sub

    Private Sub Beliminar_Click(sender As Object, e As EventArgs) Handles Beliminar.Click
        'Creamos la variable Sql que eliminara la instruccion de tipo SQL
        Dim Sql As String = "Delete From proveedores Where idProveedor = " & TbId.Text & ""
        obj.operaciones(DGproveedores, Sql)
        leerBD()
    End Sub

    Private Sub Bactualizar_Click(sender As Object, e As EventArgs) Handles Bactualizar.Click
        'Creamos la variable Sql que actualizara la instruccion de tipo SQL
        Dim Sql As String = "Update proveedores Set nomProveedor='" & TbNombre.Text & "',nomRepartidor='" & TbRepartidor.Text & "',unidadProveedor='" & TbUnidad.Text & "' Where idProveedor = " & TbId.Text & ""
        obj.operaciones(DGproveedores, Sql)
        leerBD()
    End Sub
End Class