Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class FormRegistrarAdmin
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Public x As String
    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SecionAdmin.Show()
        Me.Close()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click

        If TextBox2.Text = "" Then
            MessageBox.Show("Ingrese contrasena")
        Else
            If TextBox1.Text = "" Then
                MessageBox.Show("Ingrese usuario")
            Else
                If TextBox2.Text = TextBox3.Text Then
                    Dim EspCont = UBound(Split(TextBox2.Text, " "))
                    Dim EspReCont = UBound(Split(TextBox3.Text, " "))
                    Dim EspUser = UBound(Split(TextBox1.Text, " "))
                    Dim EspEmp = UBound(Split(TextBoxEmpresa.Text, " "))
                    If EspCont = 0 And EspCont = 0 And EspUser = 0 And EspEmp = 0 Then
                        Dim registro As New SqlCommand(“INSERT INTO AdminUsuario (Usuario, Empresa, Contrasena) Values (@Usuario, @Empresa, @Contrasena)", Connect)
                        registro.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = TextBox1.Text
                        registro.Parameters.Add("@Empresa", SqlDbType.VarChar).Value = TextBoxEmpresa.Text
                        registro.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = TextBox2.Text
                        Connect.Open()
                        If registro.ExecuteNonQuery() = 1 Then
                            MessageBox.Show("Registro Exitoso")
                            SecionAdmin.Show()
                            Me.Close()
                        Else
                            MessageBox.Show("Registro no Exitoso")
                        End If
                        Connect.Close()
                    Else
                        MessageBox.Show("No use espacios")
                    End If
                Else
                    MessageBox.Show("Las contrasenas no coinciden")
                End If
            End If
        End If
    End Sub
End Class