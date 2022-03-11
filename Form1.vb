Imports System.Data.SqlClient

Public Class FormBuscar

    Dim Connect As New SqlConnection(“Data Source = DESKTOP-15I0T6V\MSSQLSERVER1; Initial Catalog = ProyectoDatos; Integrated Security = True”)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FilterData("")

    End Sub

    Public Sub FilterData(valueToSearch As String)

        Dim searchQuery As String = "SELECT * From BuscadorPro WHERE CONCAT(NombrePro,CodigoPro,Precio,Supermercado) like '%" & valueToSearch & "%'"

        Dim command As New SqlCommand(searchQuery, Connect)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

        'Dim SelectRow As DataGridViewRow
        'SelectRow = DataGridView1.Rows(0)
        'Label1.Text = SelectRow.Cells(0).Value.ToString()
        'Label2.Text = SelectRow.Cells(2).Value.ToString()

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        FilterData(TextBox1.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        perfil.Show()
        Me.Hide()
    End Sub
End Class
