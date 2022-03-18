Imports System.Data.SqlClient
Public Class Inicio_secion

    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)
    Public Sub IniSesion()
        If TextBox1.Text = "" Then
            MessageBox.Show("Ingrese un usuario")
        Else
            If TextBox2.Text = "" Then
                MessageBox.Show("Ingrese una contraseña")
            Else
                Dim command As New SqlCommand("select * from Usuarios where Usuario = @Usuario and Contrasena = @Contrasena  ", Connect)

                command.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = TextBox1.Text
                command.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = TextBox2.Text

                Dim adapter As New SqlDataAdapter(command)
                Dim tabla As New DataTable()
                adapter.Fill(tabla)

                If tabla.Rows.Count() <= 0 Then

                    MessageBox.Show("Usuario o contraseña incorrectas")

                Else

                    MessageBox.Show("Inicio de sesion correcto")
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    FormBuscar.Show()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonIniciosesion_Click(sender As Object, e As EventArgs) Handles ButtonIniciosesion.Click
        Call IniSesion()
    End Sub

    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        Dim registro As New SqlCommand("INSERT INTO Usuarios (Usuario, Contrasena) VALUES (@Usuario, @Contrasena)", Connect)
        If TextBox1.Text = "" Then
            MessageBox.Show("Ingrese un usuario")
        Else
            If TextBox2.Text = "" Then
                MessageBox.Show("Ingrese una contraseña")
            Else
                registro.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = TextBox1.Text
                registro.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = TextBox2.Text
                Connect.Open()
                If registro.ExecuteNonQuery = 1 Then
                    MessageBox.Show("Registro Exitoso")
                Else
                    MessageBox.Show("Registro no Exitoso")
                End If
                Connect.Close()
            End If
        End If

    End Sub

End Class