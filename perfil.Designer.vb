﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class perfil
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxNombrePro = New System.Windows.Forms.TextBox()
        Me.TextBoxSupermercado = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxProducto = New System.Windows.Forms.TextBox()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.TextBoxMarca = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Buttonedit = New System.Windows.Forms.Button()
        Me.Buttondelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(346, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(355, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id del Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(396, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(360, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Supermercado"
        '
        'TextBoxNombrePro
        '
        Me.TextBoxNombrePro.Location = New System.Drawing.Point(439, 252)
        Me.TextBoxNombrePro.Name = "TextBoxNombrePro"
        Me.TextBoxNombrePro.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombrePro.TabIndex = 4
        '
        'TextBoxSupermercado
        '
        Me.TextBoxSupermercado.Location = New System.Drawing.Point(439, 332)
        Me.TextBoxSupermercado.Name = "TextBoxSupermercado"
        Me.TextBoxSupermercado.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSupermercado.TabIndex = 5
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(439, 291)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrecio.TabIndex = 6
        '
        'TextBoxProducto
        '
        Me.TextBoxProducto.Location = New System.Drawing.Point(439, 212)
        Me.TextBoxProducto.Name = "TextBoxProducto"
        Me.TextBoxProducto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxProducto.TabIndex = 7
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.ButtonAgregar.Location = New System.Drawing.Point(439, 455)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(100, 32)
        Me.ButtonAgregar.TabIndex = 8
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'TextBoxMarca
        '
        Me.TextBoxMarca.Location = New System.Drawing.Point(439, 372)
        Me.TextBoxMarca.Name = "TextBoxMarca"
        Me.TextBoxMarca.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMarca.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(396, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Marca"
        '
        'Buttonedit
        '
        Me.Buttonedit.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Buttonedit.Location = New System.Drawing.Point(305, 455)
        Me.Buttonedit.Name = "Buttonedit"
        Me.Buttonedit.Size = New System.Drawing.Size(100, 32)
        Me.Buttonedit.TabIndex = 13
        Me.Buttonedit.Text = "Editar"
        Me.Buttonedit.UseVisualStyleBackColor = True
        '
        'Buttondelete
        '
        Me.Buttondelete.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Buttondelete.Location = New System.Drawing.Point(567, 455)
        Me.Buttondelete.Name = "Buttondelete"
        Me.Buttondelete.Size = New System.Drawing.Size(100, 32)
        Me.Buttondelete.TabIndex = 14
        Me.Buttondelete.Text = "Delete"
        Me.Buttondelete.UseVisualStyleBackColor = True
        '
        'perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(972, 706)
        Me.Controls.Add(Me.Buttondelete)
        Me.Controls.Add(Me.Buttonedit)
        Me.Controls.Add(Me.TextBoxMarca)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.TextBoxProducto)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.TextBoxSupermercado)
        Me.Controls.Add(Me.TextBoxNombrePro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "perfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxNombrePro As TextBox
    Friend WithEvents TextBoxSupermercado As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxProducto As TextBox
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents TextBoxMarca As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Buttonedit As Button
    Friend WithEvents Buttondelete As Button
End Class
