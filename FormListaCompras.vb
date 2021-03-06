Imports System.Data.SqlClient
Public Class FormListaCompras
    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)
    Dim cero As Integer
    Private Sub FormListaCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call compras()
    End Sub
    Public Sub compras()
        TextBoxtotal.Text = "0"
        Dim adapter As New SqlDataAdapter("SELECT * FROM Lista ORDER BY Precio", Connect)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        For x As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            TextBoxtotal.Text = TextBoxtotal.Text + DataGridView1.Rows(x).Cells(2).Value
        Next

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Escriba un ID de producto")
        Else
            Dim eliminar As New SqlCommand("DELETE FROM Lista WHERE CodigoPro = @CodigoPro", Connect)
            eliminar.Parameters.Add("@CodigoPro", SqlDbType.Int).Value = TextBox1.Text
            Connect.Open()
            If eliminar.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Producto eliminaado")
                Call compras()
            Else
                MessageBox.Show("Producto no eliminado")
            End If
            Connect.Close()
            compras()
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim index As Integer = e.RowIndex
        Dim lineaselecionada As DataGridViewRow = DataGridView1.Rows(index)
        cero = lineaselecionada.Cells(0).Value
        MessageBox.Show(cero)
    End Sub
End Class