Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class CamiarContraseña
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)
    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        InicioSesion.Show()
        Me.Close()
    End Sub

    Private Sub ButtonIniciosesion_Click(sender As Object, e As EventArgs) Handles ButtonIniciosesion.Click
        If TextBoxNombre.Text = "" Then
            MessageBox.Show("El espacio de usuario esta vacio")
        Else
            If TextBoxContrarena.Text = "" Then
                MessageBox.Show("El espacio de nueva contrasena esta vacio")
            Else
                If TextBoxReContrasena.Text = "" Then
                    MessageBox.Show("El espacio de confirmar contrasena esta vacio")
                Else
                    If TextBoxContrarena.Text = TextBoxReContrasena.Text Then
                        Dim EspCont = UBound(Split(TextBoxContrarena.Text, " "))
                        Dim EspReCont = UBound(Split(TextBoxReContrasena.Text, " "))
                        Dim EspUser = UBound(Split(TextBoxNombre.Text, " "))
                        If EspCont = 0 And EspReCont = 0 And EspUser = 0 Then
                            Dim Cambiar_Contrassena As New SqlCommand("UPDATE Usuarios SET Contrasena = @Contrasena WHERE Usuario = @Usuario", Connect)

                            Cambiar_Contrassena.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = TextBoxContrarena.Text
                            Cambiar_Contrassena.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = TextBoxNombre.Text

                            Connect.Open()
                            If Cambiar_Contrassena.ExecuteNonQuery() = 1 Then
                                MessageBox.Show("Contrasena cambiada exitosamente")
                            Else

                            End If
                            Connect.Close()
                            InicioSesion.Show()
                            Me.Close()
                        Else
                            MessageBox.Show("No use espacios")
                        End If

                    Else
                            MessageBox.Show("No coinciden las contrasenas")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Application.Exit()
    End Sub



    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class