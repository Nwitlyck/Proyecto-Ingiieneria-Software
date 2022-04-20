Imports System.Data.SqlClient
Public Class PerfilAdmin
    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)
    Private Sub PerfilAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Cargar()
    End Sub
    Public Sub Cargar()
        User.Text = perfil.DataGridView2.Rows(0).Cells(0).Value.ToString
        TextBoxNombre.Text = perfil.DataGridView2.Rows(0).Cells(1).Value.ToString
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = TextBox2.Text Then
            MessageBox.Show("Complete los campos obligatorios")
        Else
            Dim espNom = UBound(Split(TextBox1.Text, " "))
            Dim espAp1 = UBound(Split(TextBoxNombre.Text, " "))
            Dim espAp2 = UBound(Split(User.Text, " "))

            If espNom = 0 And espAp1 = 0 And espAp2 = 0 Then
                Dim anadir As New SqlCommand("UPDATE AdminUsuario SET Usuario = @Usuario ,Contrasena = @Contrasena WHERE Empresa = @Empresa", Connect)
                anadir.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = TextBoxNombre.Text
                anadir.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = TextBox2.Text
                anadir.Parameters.Add("@Empresa", SqlDbType.VarChar).Value = User.Text
                Connect.Open()
                If anadir.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Datos Actualizados")
                Else
                    MessageBox.Show("Datos No Actualizados")
                End If
                Connect.Close()
                Call Cargar()
            Else
                MessageBox.Show("No use ")
            End If

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        perfil.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SecionAdmin.TextBox1.Text = ""
        SecionAdmin.TextBox2.Text = ""
        SecionAdmin.Show()
        Me.Hide()
    End Sub
End Class