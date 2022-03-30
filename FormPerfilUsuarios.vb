Imports System.Data.SqlClient
Public Class FormPerfilUsuarios
    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)
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
            MessageBox.Show("Union realizada")
        Else
            MessageBox.Show("Union no realizada")
        End If
        Connect.Close()
        Call Cargar()
    End Sub
End Class