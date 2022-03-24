Imports System.Data.SqlClient
Public Class perfil
    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click

        Dim anadir As New SqlCommand("INSERT INTO BuscadorPro(NombrePro ,CodigoPro ,Precio ,Supermercado,Marca) VALUES(@NombrePro, @CodigoPro ,@Precio ,@Supermercado, @Marca)", Connect)

            anadir.Parameters.Add("@NombrePro", SqlDbType.VarChar).Value = TextBoxNombrePro.Text
            anadir.Parameters.Add("@CodigoPro", SqlDbType.Int).Value = TextBoxProducto.Text
            anadir.Parameters.Add("@Precio", SqlDbType.Int).Value = TextBoxPrecio.Text
            anadir.Parameters.Add("@Supermercado", SqlDbType.VarChar).Value = TextBoxSupermercado.Text
            anadir.Parameters.Add("@Marca", SqlDbType.VarChar).Value = TextBoxMarca.Text
            Connect.Open()
            If anadir.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Union realizada")
                TextBoxNombrePro.Text = ""
                TextBoxProducto.Text = ""
                TextBoxPrecio.Text = ""
                TextBoxSupermercado.Text = ""
                TextBoxMarca.Text = ""
            Else
                MessageBox.Show("Union no realizada")
            End If
        Connect.Close()

    End Sub

    Private Sub Buttonvolver_Click(sender As Object, e As EventArgs) 
        FormBuscar.Show()
        Me.Close()
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class