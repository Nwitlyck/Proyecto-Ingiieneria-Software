Imports System.Data.SqlClient

Public Class FormBuscar

    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)
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



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        FilterData(TextBox1.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        perfil.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub
End Class
