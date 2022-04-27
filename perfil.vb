Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class perfil
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)

    Public Sub Datos()
        Dim y As String
        Dim v As Integer = 0
        Dim u As Integer
        Dim Bandera As Boolean = False
        Dim searchQuery2 As String = "SELECT * From BuscadorPro"
        Dim command2 As New SqlCommand(searchQuery2, Connect)
        Dim adapter2 As New SqlDataAdapter(command2)
        Dim Hola As New DataTable()
        adapter2.Fill(Hola)
        DataGridViewDatos.DataSource = Hola
        u = DataGridViewDatos.Rows.Count - 2
        For x As Integer = 0 To u Step 1
            y = DataGridViewDatos.Rows(x).Cells(0).Value.ToString

            If y.Equals(TextBoxProducto.Text) Then
                MessageBox.Show("Ya existe esa ID")
                TextBoxProducto.Text = ""
            End If
        Next

    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Datos()
        If TextBoxProducto.Text = "" Or TextBoxNombrePro.Text = "" Or TextBoxPrecio.Text = "" Or TextBoxMarca.Text = "" Then
            MessageBox.Show("Hay un espacio en blanco")
        Else
            Dim anadir As New SqlCommand("INSERT INTO BuscadorPro(NombrePro ,CodigoPro ,Precio ,Supermercado,Marca) VALUES(@NombrePro, @CodigoPro ,@Precio ,@Supermercado, @Marca)", Connect)
            anadir.Parameters.Add("@NombrePro", SqlDbType.VarChar).Value = TextBoxNombrePro.Text
            anadir.Parameters.Add("@CodigoPro", SqlDbType.Int).Value = TextBoxProducto.Text
            anadir.Parameters.Add("@Precio", SqlDbType.Int).Value = TextBoxPrecio.Text
            anadir.Parameters.Add("@Supermercado", SqlDbType.VarChar).Value = LabelSuper.Text
            anadir.Parameters.Add("@Marca", SqlDbType.VarChar).Value = TextBoxMarca.Text
            Connect.Open()
            If anadir.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Añadido")
                TextBoxNombrePro.Text = ""
                TextBoxProducto.Text = ""
                TextBoxPrecio.Text = ""
                TextBoxMarca.Text = ""
                Cargar()
            Else
                MessageBox.Show("No Añadido")
            End If
            Connect.Close()
        End If
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
                MessageBox.Show("Eliminado")
                TextBoxNombrePro.Text = ""
                TextBoxProducto.Text = ""
                TextBoxPrecio.Text = ""
                TextBoxMarca.Text = ""
                Cargar()
            Else
                MessageBox.Show("No Eliminado")
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
                MessageBox.Show("Informacion Actualizado")
                TextBoxNombrePro.Text = ""
                TextBoxProducto.Text = ""
                TextBoxPrecio.Text = ""
                TextBoxMarca.Text = ""
                Cargar()
            Else
                MessageBox.Show("No Informacion Actualizado")
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SecionAdmin.TextBox1.Text = ""
        SecionAdmin.TextBox2.Text = ""
        SecionAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class