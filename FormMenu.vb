Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class FormMenu
    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles panelcabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Dim limpiar As New SqlCommand("DELETE FROM Lista ", Connect)
        Connect.Open()
        If limpiar.ExecuteNonQuery() = 1 Then
        Else
        End If
        Connect.Close()
        InicioSesion.Show()
        Me.Close()
    End Sub

    Private Sub btnmax_Click(sender As Object, e As EventArgs) Handles btnmax.Click
        btnmax.Visible = False
        btnres.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnres_Click(sender As Object, e As EventArgs) Handles btnres.Click
        btnres.Visible = False
        btnmax.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub panelcabecera_MouseMove(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub ocultmenu_Tick(sender As Object, e As EventArgs) Handles ocultmenu.Tick
        If panelmenu.Width <= 60 Then
            Me.ocultmenu.Enabled = False
        Else
            Me.panelmenu.Width = panelmenu.Width - 20
        End If
    End Sub

    Private Sub mostmenu_Tick(sender As Object, e As EventArgs) Handles mostmenu.Tick
        If panelmenu.Width >= 240 Then
            Me.mostmenu.Enabled = False
        Else
            Me.panelmenu.Width = panelmenu.Width + 20

        End If
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If panelmenu.Width = 240 Then
            ocultmenu.Enabled = True
        ElseIf panelmenu.Width = 60 Then
            mostmenu.Enabled = True

        End If
    End Sub
    Private Sub AbrirFomEnPanel(ByVal Formhijo As Object)
        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.panelcontenedor.Controls.Add(fh)
        Me.panelcontenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        AbrirFomEnPanel(New FormBuscar)
    End Sub

    Private Sub btncerrarsesion_Click(sender As Object, e As EventArgs) Handles btncerrarsesion.Click
        Dim limpiar As New SqlCommand("DELETE FROM Lista ", Connect)
        Connect.Open()
        If limpiar.ExecuteNonQuery() = 1 Then
        Else
        End If
        Connect.Close()
        InicioSesion.Show()
        Me.Close()
    End Sub

    Private Sub btnperfil_Click(sender As Object, e As EventArgs) Handles btnperfil.Click
        AbrirFomEnPanel(New perfil)

    End Sub

    Private Sub btnlista_Click(sender As Object, e As EventArgs) Handles btnlista.Click
        AbrirFomEnPanel(New FormListaCompras)
    End Sub
End Class