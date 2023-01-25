Imports System.Runtime.InteropServices
Public Class sistemaprincipal
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub sistemaprincipal_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub sistemaprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Badmin_Click(sender As Object, e As EventArgs) Handles Badmin.Click
        administracion.Show()
        Me.Close()
    End Sub
    Private Sub Bproductos_Click(sender As Object, e As EventArgs) Handles Bproductos.Click
        productos.Show()
        Me.Close()
    End Sub
    Private Sub Bpedidos_Click(sender As Object, e As EventArgs) Handles Bpedidos.Click
        pedidos.Show()
        Me.Close()
    End Sub
    Private Sub Bventas_Click(sender As Object, e As EventArgs) Handles Bventas.Click
        ventas.Show()
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lhora.Text = DateTime.Now.ToString("hh:mm:ss")
        Lfecha.Text = DateTime.Now.ToLongDateString()
    End Sub
    Private Sub Bcerrar_Click(sender As Object, e As EventArgs) Handles Bcerrar.Click
        bienvenida.Close()
        Me.Close()
    End Sub
    Private Sub Bminimizar_Click(sender As Object, e As EventArgs) Handles Bminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Badmin_Paint(sender As Object, e As PaintEventArgs) Handles Badmin.Paint
        Dim botonpath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim botonrect As Rectangle = Badmin.ClientRectangle
        botonrect.Inflate(0, 40)
        botonpath.AddEllipse(botonrect)
        Badmin.Region = New Region(botonpath)
    End Sub
    Private Sub Bproductos_Paint(sender As Object, e As PaintEventArgs) Handles Bproductos.Paint
        Dim botonpath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim botonrect As Rectangle = Bproductos.ClientRectangle
        botonrect.Inflate(0, 40)
        botonpath.AddEllipse(botonrect)
        Bproductos.Region = New Region(botonpath)
    End Sub

    Private Sub Bpedidos_Paint(sender As Object, e As PaintEventArgs) Handles Bpedidos.Paint
        Dim botonpath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim botonrect As Rectangle = Bpedidos.ClientRectangle
        botonrect.Inflate(0, 40)
        botonpath.AddEllipse(botonrect)
        Bpedidos.Region = New Region(botonpath)
    End Sub

    Private Sub Bventas_Paint(sender As Object, e As PaintEventArgs) Handles Bventas.Paint
        Dim botonpath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim botonrect As Rectangle = Bventas.ClientRectangle
        botonrect.Inflate(0, 40)
        botonpath.AddEllipse(botonrect)
        Bventas.Region = New Region(botonpath)
    End Sub
End Class