Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class SecionAdmin
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Public x As String

    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)
    Public Sub IniSesion()

        If TextBox1.Text = "" Then
            MessageBox.Show("Ingrese un usuario")
        Else
            If TextBox2.Text = "" Then
                MessageBox.Show("Ingrese una contraseña")
            Else
                Dim spaces = UBound(Split(TextBox1.Text, " "))
                Dim spaces1 = UBound(Split(TextBox2.Text, " "))
                If (spaces = 0 Or spaces1 = 0) Then
                    Dim Accesso As String
                    Dim Usuarios As String = TextBox1.Text
                    Dim Contrasena As String = TextBox2.Text
                    Dim strCommand As String = "select 'S' from AdminUsuario where usuario = '" & Usuarios & "' and contrasena = '" & Contrasena & "'"
                    Dim command As SqlCommand = New SqlCommand(strCommand, Connect)
                    command.CommandType = CommandType.Text

                    Connect.Open()

                    Accesso = command.ExecuteScalar

                    If Accesso = "S" Then
                        perfil.Show()
                        Me.Hide()
                    Else
                        MsgBox("Usuario y contraseña no valido")
                    End If

                    Connect.Close()
                Else
                    MessageBox.Show("No use espacios")
                End If
            End If
        End If
    End Sub

    Private Sub ButtonIniciosesion_Click(sender As Object, e As EventArgs) Handles ButtonIniciosesion.Click
        Call IniSesion()
    End Sub

    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        FormRegistrarAdmin.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub ButtonCC_Click(sender As Object, e As EventArgs) Handles ButtonCC.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormMenu.Show()
        Me.Show()
    End Sub
End Class