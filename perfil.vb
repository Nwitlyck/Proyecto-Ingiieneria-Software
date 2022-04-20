Imports System.Data.SqlClient
Public Class perfil
    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Dim anadir As New SqlCommand("INSERT INTO BuscadorPro(NombrePro ,CodigoPro ,Precio ,Supermercado,Marca) VALUES(@NombrePro, @CodigoPro ,@Precio ,@Supermercado, @Marca)", Connect)

        anadir.Parameters.Add("@NombrePro", SqlDbType.VarChar).Value = TextBoxNombrePro.Text
        anadir.Parameters.Add("@CodigoPro", SqlDbType.Int).Value = TextBoxProducto.Text
        anadir.Parameters.Add("@Precio", SqlDbType.Int).Value = TextBoxPrecio.Text
        anadir.Parameters.Add("@Supermercado", SqlDbType.VarChar).Value = LabelSuper.Text
        anadir.Parameters.Add("@Marca", SqlDbType.VarChar).Value = TextBoxMarca.Text
        Connect.Open()
        If anadir.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Union realizada")
            TextBoxNombrePro.Text = ""
            TextBoxProducto.Text = ""
            TextBoxPrecio.Text = ""
            TextBoxMarca.Text = ""
            Cargar()
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

    Private Sub Buttondelete_Click(sender As Object, e As EventArgs) Handles Buttondelete.Click
        If TextBoxProducto.Text = "" Then
            MessageBox.Show("Escriba el codigo de producto que desea eliminar o seleccionelo")
        Else
            Dim anadir As New SqlCommand("DELETE FROM BuscadorPro WHERE CodigoPro = @CodigoPro", Connect)

            anadir.Parameters.Add("@CodigoPro", SqlDbType.Int).Value = TextBoxProducto.Text

            Connect.Open()
            If anadir.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Producto eliminado")
                TextBoxNombrePro.Text = ""
                TextBoxProducto.Text = ""
                TextBoxPrecio.Text = ""
                TextBoxMarca.Text = ""
                Cargar()
            Else
                MessageBox.Show("Union no realizada")
            End If
            Connect.Close()
        End If

    End Sub

    Private Sub Buttonedit_Click(sender As Object, e As EventArgs) Handles Buttonedit.Click
        If TextBoxNombrePro.Text = "" And TextBoxProducto.Text = "" And LabelSuper.Text = "" And TextBoxPrecio.Text = "" And LabelSuper.Text = "" And TextBoxMarca.Text = "" Then
            MessageBox.Show("Uno o mas campos estan vacios porfavor rellenar")
        Else
            Dim anadir As New SqlCommand("UPDATE BuscadorPro SET NombrePro = @NombrePro ,Precio = @Precio ,Supermercado = @Supermercado ,Marca = @Marca WHERE CodigoPro = @CodigoPro", Connect)

            anadir.Parameters.Add("@NombrePro", SqlDbType.VarChar).Value = TextBoxNombrePro.Text
            anadir.Parameters.Add("@CodigoPro", SqlDbType.Int).Value = TextBoxProducto.Text
            anadir.Parameters.Add("@Precio", SqlDbType.Int).Value = TextBoxPrecio.Text
            anadir.Parameters.Add("@Supermercado", SqlDbType.VarChar).Value = LabelSuper.Text
            anadir.Parameters.Add("@Marca", SqlDbType.VarChar).Value = TextBoxMarca.Text
            Connect.Open()
            If anadir.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Union realizada")
                TextBoxNombrePro.Text = ""
                TextBoxProducto.Text = ""
                TextBoxPrecio.Text = ""
                TextBoxMarca.Text = ""
                Cargar()
            Else
                MessageBox.Show("Union no realizada")
            End If
            Connect.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PerfilAdmin.Show()
        Me.Close()

    End Sub

    Private Sub perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Cargar()
    End Sub
    Public Sub Cargar()
        Dim usuario As String = SecionAdmin.TextBox1.Text
        Dim searchQuery As String = "SELECT * From AdminUsuario WHERE Usuario like '%" & usuario & "%'"
        Dim command As New SqlCommand(searchQuery, Connect)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView2.DataSource = table
        LabelSuper.Text = DataGridView2.Rows(0).Cells(1).Value.ToString

        Dim searchQuery1 As String = "SELECT * From BuscadorPro WHERE Supermercado like '%" & LabelSuper.Text & "%'"
        Dim command1 As New SqlCommand(searchQuery1, Connect)
        Dim adapter1 As New SqlDataAdapter(command1)
        Dim table1 As New DataTable()
        adapter1.Fill(table1)
        DataGridView1.DataSource = table1

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim lineaselecionada As DataGridViewRow = DataGridView1.Rows(index)
        TextBoxProducto.Text = lineaselecionada.Cells(0).Value.ToString
        TextBoxNombrePro.Text = lineaselecionada.Cells(1).Value.ToString
        TextBoxPrecio.Text = lineaselecionada.Cells(2).Value.ToString
        TextBoxMarca.Text = lineaselecionada.Cells(4).Value.ToString
    End Sub
End Class