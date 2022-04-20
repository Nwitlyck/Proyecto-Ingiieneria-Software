Imports System.Data.SqlClient
Public Class FormPerfilUsuarios
    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)
    Dim bool As Boolean
    Private Sub ButtonCC_Click(sender As Object, e As EventArgs) Handles ButtonCC.Click
        CamiarContraseña.Show()
        Me.Close()
    End Sub

    Private Sub FormPerfilUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User.Text = InicioSesion.TextBox1.Text
        Call Cargar()
    End Sub

    Public Sub Cargar()
        Dim usuario As String = InicioSesion.TextBox1.Text
        Dim searchQuery As String = "SELECT * From Usuarios WHERE Usuario like '%" & usuario & "%'"
        Dim command As New SqlCommand(searchQuery, Connect)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

        NumericUpDownEdad.Value = DataGridView1.Rows(0).Cells(2).Value
        TextBoxUbicacion.Text = DataGridView1.Rows(0).Cells(3).Value.ToString
        TextBoxNombre.Text = DataGridView1.Rows(0).Cells(4).Value.ToString
        TextBox1apellido.Text = DataGridView1.Rows(0).Cells(5).Value.ToString
        TextBox2apellido.Text = DataGridView1.Rows(0).Cells(6).Value.ToString
        TextBoxCelular.Text = DataGridView1.Rows(0).Cells(7).Value.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1apellido.Text = "" Or TextBoxNombre.Text = "" Then

            MessageBox.Show("Rellene el nombre y el primer apellido por lo menos")

        Else
            Dim espaciosNombre = UBound(Split(TextBoxNombre.Text, " "))
            Dim espaciosAp1 = UBound(Split(TextBox1apellido.Text, " "))
            Dim espaciosAp2 = UBound(Split(TextBox2apellido.Text, " "))
            Dim espaciosCelular = UBound(Split(TextBoxCelular.Text, " "))

            If espaciosNombre = 0 And espaciosAp1 = 0 And espaciosAp2 = 0 And espaciosCelular = 0 Then
                Dim anadir As New SqlCommand("UPDATE Usuarios SET Edad = @Edad ,Direccion = @Direccion ,Nombre = @Nombre ,PApellido = @PApellido  ,SApellido = @SApellido ,Celular = @Celular WHERE Usuario = @Usuario ", Connect)

                anadir.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = User.Text
                anadir.Parameters.Add("@Edad", SqlDbType.Int).Value = NumericUpDownEdad.Value
                anadir.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = TextBoxUbicacion.Text
                anadir.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = TextBoxNombre.Text
                anadir.Parameters.Add("@PApellido", SqlDbType.VarChar).Value = TextBox1apellido.Text
                anadir.Parameters.Add("@SApellido", SqlDbType.VarChar).Value = TextBox2apellido.Text
                anadir.Parameters.Add("@Celular", SqlDbType.Int).Value = Convert.ToInt32(TextBoxCelular.Text)

                Connect.Open()
                If anadir.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Datos Actualizados")
                Else
                    MessageBox.Show("Datos no Actualizados")
                End If
                Connect.Close()
                Call Cargar()

            Else
                MessageBox.Show("No use espacios")
            End If
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim DeleteUser As New SqlCommand("DELETE FROM Usuarios WHERE usuario = @usuario", Connect)
        DeleteUser.Parameters.Add("@usuario", SqlDbType.VarChar).Value = User.Text
        Connect.Open()
        If DeleteUser.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Eliminado con exito")
        Else
            MessageBox.Show("Usuario no eliminado")
        End If
        Connect.Close()
        Dim limpiar As New SqlCommand("DELETE FROM Lista ", Connect)
        Connect.Open()
        If limpiar.ExecuteNonQuery() = 1 Then
        Else
        End If
        Connect.Close()
        InicioSesion.Show()
        InicioSesion.TextBox1.Text = ""
        InicioSesion.TextBox2.Text = ""
        FormMenu.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBoxCelular_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCelular.TextChanged

    End Sub

    Private Sub NumericUpDownEdad_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownEdad.ValueChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub User_Click(sender As Object, e As EventArgs) Handles User.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2apellido_TextChanged(sender As Object, e As EventArgs) Handles TextBox2apellido.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1apellido_TextChanged(sender As Object, e As EventArgs) Handles TextBox1apellido.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBoxUbicacion_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUbicacion.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class