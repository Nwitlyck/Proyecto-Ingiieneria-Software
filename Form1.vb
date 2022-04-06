Imports System.Data.SqlClient

Public Class FormBuscar

    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)
    Dim cero, dos As Integer
    Dim uno, tres, cuatro As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FilterData("")

    End Sub

    Public Sub FilterData(valueToSearch As String)

        Dim searchQuery As String = "SELECT * From BuscadorPro WHERE CONCAT(NombrePro,Precio,Supermercado,Marca) like '%" & valueToSearch & "%' ORDER BY Precio"

        Dim command As New SqlCommand(searchQuery, Connect)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table


    End Sub

    Private Sub ButtonAgregaradeseados_Click(sender As Object, e As EventArgs) Handles ButtonAgregaradeseados.Click
        Dim guardar As New SqlCommand("INSERT INTO Lista (CodigoPro ,NombrePro ,Precio ,Supermercado ,Marca) VALUES (@CodigoPro ,@NombrePro ,@Precio ,@Supermercado ,@Marca)", Connect)

        guardar.Parameters.Add("@NombrePro", SqlDbType.VarChar).Value = uno
        guardar.Parameters.Add("@CodigoPro", SqlDbType.Int).Value = cero
        guardar.Parameters.Add("@Precio", SqlDbType.Int).Value = dos
        guardar.Parameters.Add("@Supermercado", SqlDbType.VarChar).Value = tres
        guardar.Parameters.Add("@Marca", SqlDbType.VarChar).Value = cuatro
        Connect.Open()
        If guardar.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Producto guardado")
        Else
            MessageBox.Show("Producto no guardado")
        End If
        Connect.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        FilterData(TextBox1.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        perfil.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim lineaselecionada As DataGridViewRow = DataGridView1.Rows(index)
        cero = lineaselecionada.Cells(0).Value
        uno = lineaselecionada.Cells(1).Value.ToString
        dos = lineaselecionada.Cells(2).Value
        tres = lineaselecionada.Cells(3).Value.ToString
        cuatro = lineaselecionada.Cells(4).Value.ToString
        Dim txt As String
        For x As Integer = 0 To 4 Step 1
            txt += lineaselecionada.Cells(x).Value.ToString + vbCrLf + vbCrLf
        Next
        Label1.Text = txt

    End Sub


End Class
