Imports System.Data.SqlClient
Public Class perfil
    Dim Connect As New SqlConnection(“Data Source = DESKTOP-15I0T6V\MSSQLSERVER1; Initial Catalog = ProyectoDatos; Integrated Security = True”)

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Dim anadir As New SqlCommand("INSERT INTO BuscadorPro(NombrePro ,CodigoPro ,Precio ,Supermercado) VALUES(@NombrePro, @CodigoPro ,@Precio ,@Supermercado)", Connect)

        anadir.Parameters.Add("@NombrePro", SqlDbType.VarChar).Value = TextBoxNombrePro.Text
        anadir.Parameters.Add("@CodigoPro", SqlDbType.Int).Value = TextBoxProducto.Text
        anadir.Parameters.Add("@Precio", SqlDbType.Int).Value = TextBoxPrecio.Text
        anadir.Parameters.Add("@Supermercado", SqlDbType.VarChar).Value = TextBoxSupermercado.Text

        Connect.Open()
        If anadir.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Union realizada")
        Else
            MessageBox.Show("Union no realizada")
        End If
        Connect.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormBuscar.Show()
        Me.Hide()
    End Sub
End Class