<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPerfilUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonCC = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUbicacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1apellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2apellido = New System.Windows.Forms.TextBox()
        Me.User = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDownEdad = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxCelular = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Proyecto_Ingiieneria_Software.My.Resources.Resources.profile_g888983ebd_640
        Me.PictureBox1.Location = New System.Drawing.Point(153, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ButtonCC
        '
        Me.ButtonCC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonCC.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCC.Location = New System.Drawing.Point(12, 622)
        Me.ButtonCC.Name = "ButtonCC"
        Me.ButtonCC.Size = New System.Drawing.Size(129, 72)
        Me.ButtonCC.TabIndex = 12
        Me.ButtonCC.Text = "Olvide Contraseña"
        Me.ButtonCC.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(825, 622)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 72)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Actualizar Informacion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(149, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Direccion"
        '
        'TextBoxUbicacion
        '
        Me.TextBoxUbicacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxUbicacion.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.TextBoxUbicacion.Location = New System.Drawing.Point(153, 386)
        Me.TextBoxUbicacion.Multiline = True
        Me.TextBoxUbicacion.Name = "TextBoxUbicacion"
        Me.TextBoxUbicacion.Size = New System.Drawing.Size(320, 141)
        Me.TextBoxUbicacion.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(657, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxNombre.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.TextBoxNombre.Location = New System.Drawing.Point(655, 147)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(133, 31)
        Me.TextBoxNombre.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(658, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Primer Apellido"
        '
        'TextBox1apellido
        '
        Me.TextBox1apellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1apellido.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.TextBox1apellido.Location = New System.Drawing.Point(655, 232)
        Me.TextBox1apellido.Name = "TextBox1apellido"
        Me.TextBox1apellido.Size = New System.Drawing.Size(133, 31)
        Me.TextBox1apellido.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(652, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 23)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Segundo Apellido"
        '
        'TextBox2apellido
        '
        Me.TextBox2apellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2apellido.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.TextBox2apellido.Location = New System.Drawing.Point(656, 309)
        Me.TextBox2apellido.Name = "TextBox2apellido"
        Me.TextBox2apellido.Size = New System.Drawing.Size(133, 31)
        Me.TextBox2apellido.TabIndex = 20
        '
        'User
        '
        Me.User.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.User.AutoSize = True
        Me.User.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.Location = New System.Drawing.Point(149, 232)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(46, 23)
        Me.User.TabIndex = 23
        Me.User.Text = "User"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(288, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 23)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Edad"
        '
        'NumericUpDownEdad
        '
        Me.NumericUpDownEdad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDownEdad.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.NumericUpDownEdad.Location = New System.Drawing.Point(315, 122)
        Me.NumericUpDownEdad.Name = "NumericUpDownEdad"
        Me.NumericUpDownEdad.Size = New System.Drawing.Size(45, 31)
        Me.NumericUpDownEdad.TabIndex = 28
        Me.NumericUpDownEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(657, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 23)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Celular"
        '
        'TextBoxCelular
        '
        Me.TextBoxCelular.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxCelular.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.TextBoxCelular.Location = New System.Drawing.Point(656, 386)
        Me.TextBoxCelular.Name = "TextBoxCelular"
        Me.TextBoxCelular.Size = New System.Drawing.Size(133, 31)
        Me.TextBoxCelular.TabIndex = 29
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(633, 579)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(151, 115)
        Me.DataGridView1.TabIndex = 31
        Me.DataGridView1.Visible = False
        '
        'FormPerfilUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 706)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxCelular)
        Me.Controls.Add(Me.NumericUpDownEdad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2apellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1apellido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxUbicacion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonCC)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPerfilUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPerfilUsuarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownEdad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonCC As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxUbicacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1apellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2apellido As TextBox
    Friend WithEvents User As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDownEdad As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxCelular As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
