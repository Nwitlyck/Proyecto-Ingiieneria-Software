﻿Imports System.Data.SqlClient
Imports System.Runtime.InteropServices


Public Class InicioSesion
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Public x As String

    Dim Connect As New SqlConnection(“Data Source = ALVARO\SQLPRUEBA; Initial Catalog = ProyectoDatos; Integrated Security = True”)
    Public Sub IniSesion()

        If TextBox1.Text = "" Then
            MessageBox.Show("Ingrese un usuario")
        Else
            If TextBox2.Text = "" Then
                MessageBox.Show("Ingrese una contraseña")
            Else
                Dim spaces = UBound(Split(TextBox1.Text, " "))
                Dim spaces1 = UBound(Split(TextBox2.Text, " "))
                If (spaces = 0 Or spaces1 = 0) Then
                    Dim command As New SqlCommand("select * from Usuarios where Usuario = @Usuario and Contrasena = @Contrasena  ", Connect)

                    command.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = TextBox1.Text
                    command.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = TextBox2.Text

                    Dim adapter As New SqlDataAdapter(command)
                    Dim tabla As New DataTable()
                    adapter.Fill(tabla)

                    If tabla.Rows.Count() <= 0 Then

                        MessageBox.Show("Usuario o contraseña incorrectas")

                    Else

                        MessageBox.Show("Inicio de sesion correcto")
                        FormMenu.Show()
                        x = TextBox1.Text
                        Me.Hide()

                    End If
                Else
                    MessageBox.Show("No use espacios")
                End If
            End If
        End If
    End Sub

    Private Sub ButtonIniciosesion_Click(sender As Object, e As EventArgs) Handles ButtonIniciosesion.Click
        Call IniSesion()
    End Sub

    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        FormRegistrar.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("SELECT * FROM Lista", Connect)
        Dim table As New DataTable()
        adapter.Fill(table)
        Dim tanke = table.Rows.Count
        If tanke > 1 Then
            FormMenu.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ButtonCC_Click(sender As Object, e As EventArgs) Handles ButtonCC.Click
        CamiarContraseña.Show()
        Me.Close()
    End Sub
End Class