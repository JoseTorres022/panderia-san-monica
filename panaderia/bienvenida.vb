Imports System.Runtime.InteropServices
Public Class bienvenida
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
            Bbar.Visible = False
        End If

        If ProgressBar1.Value = 100 Then
            Bbar.Visible = True
            Timer1.Stop()
        End If
    End Sub
    Private Sub bienvenida_Load(sender As Object, e As EventArgs) Handles Me.Load
        ProgressBar1.Value = 0
        Me.Opacity = 0
        Timer1.Start()
    End Sub
    Private Sub Bbar_Click(sender As Object, e As EventArgs) Handles Bbar.Click
        sistemaprincipal.Show()
        Me.Hide()
    End Sub
    Private Sub Bcerrar_Click(sender As Object, e As EventArgs) Handles Bcerrar.Click
        Me.Close()
    End Sub
    Private Sub Bminimizar_Click(sender As Object, e As EventArgs) Handles Bminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub bienvenida_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class
