Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class FormRegistrar
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnres_Click(sender As Object, e As EventArgs) Handles btnres.Click
        btnres.Visible = False
        btnmax.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnmax_Click(sender As Object, e As EventArgs) Handles btnmax.Click
        btnmax.Visible = False
        btnres.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        Dim registro As New SqlCommand("INSERT INTO Usuarios (Usuario, Contrasena, Edad) VALUES (@Usuario, @Contrasena, @Edad)", Connect)
        If TextBox1.Text = "" Then
            MessageBox.Show("Ingrese un usuario")
        Else
            If NumericUpDown1.Value < 18 Then
                MessageBox.Show("Ocupas 18 para poder registrarte")
            Else
                If TextBox2.Text = "" Then
                    MessageBox.Show("Ingrese una contraseña")
                Else
                    If TextBox2.Text = TextBox3.Text Then
                        Dim EspCont = UBound(Split(TextBox2.Text, " "))
                        Dim EspReCont = UBound(Split(TextBox3.Text, " "))
                        Dim EspUser = UBound(Split(TextBox1.Text, " "))
                        If EspCont = 0 And EspReCont = 0 And EspUser = 0 Then


                            registro.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = TextBox1.Text
                            registro.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = TextBox2.Text
                            registro.Parameters.Add("@Edad", SqlDbType.Int).Value = NumericUpDown1.Value
                            Connect.Open()
                            If registro.ExecuteNonQuery = 1 Then
                                MessageBox.Show("Registro Exitoso")
                                InicioSesion.Show()
                                Me.Close()
                            Else
                                MessageBox.Show("Registro no Exitoso")
                            End If
                            Connect.Close()

                        Else
                            MessageBox.Show("No use espacios")
                        End If
                    Else
                        MessageBox.Show("Las contraseña no coinciden")
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InicioSesion.Show()
        Me.Close()
    End Sub

    Private Sub FormRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class