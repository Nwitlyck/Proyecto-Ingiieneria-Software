Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class PerfilAdmin
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)
    Private Sub PerfilAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Cargar()
    End Sub
    Public Sub Cargar()
        User.Text = perfil.DataGridView2.Rows(0).Cells(0).Value.ToString
        TextBoxNombre.Text = perfil.DataGridView2.Rows(0).Cells(1).Value.ToString
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = TextBox2.Text Then
            MessageBox.Show("Complete los campos obligatorios")
        Else
            Dim espNom = UBound(Split(TextBox1.Text, " "))
            Dim espAp1 = UBound(Split(TextBoxNombre.Text, " "))
            Dim espAp2 = UBound(Split(User.Text, " "))

            If espNom = 0 And espAp1 = 0 And espAp2 = 0 Then
                Dim anadir As New SqlCommand("UPDATE AdminUsuario SET Usuario = @Usuario ,Contrasena = @Contrasena WHERE Empresa = @Empresa", Connect)
                anadir.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = TextBoxNombre.Text
                anadir.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = TextBox2.Text
                anadir.Parameters.Add("@Empresa", SqlDbType.VarChar).Value = User.Text
                Connect.Open()
                If anadir.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Datos Actualizados")
                Else
                    MessageBox.Show("Datos No Actualizados")
                End If
                Connect.Close()
                Call Cargar()
            Else
                MessageBox.Show("No use ")
            End If

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        perfil.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SecionAdmin.TextBox1.Text = ""
        SecionAdmin.TextBox2.Text = ""
        SecionAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim DeleteUser As New SqlCommand("DELETE FROM AdminUsuario WHERE usuario = @usuario", Connect)
        DeleteUser.Parameters.Add("@usuario", SqlDbType.VarChar).Value = User.Text
        Connect.Open()
        If DeleteUser.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Eliminado con exito")
        Else
            MessageBox.Show("Usuario no eliminado")
        End If
        SecionAdmin.Show()
        SecionAdmin.TextBox1.Text = ""
        SecionAdmin.TextBox2.Text = ""
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class