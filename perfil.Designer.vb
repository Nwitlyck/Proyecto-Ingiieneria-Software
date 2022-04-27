<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(perfil))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxNombrePro = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxProducto = New System.Windows.Forms.TextBox()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.TextBoxMarca = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Buttonedit = New System.Windows.Forms.Button()
        Me.Buttondelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnmin = New System.Windows.Forms.PictureBox()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LabelSuper = New System.Windows.Forms.Label()
        Me.DataGridViewDatos = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.btnmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(578, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(587, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id del Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(628, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(592, 399)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Supermercado"
        '
        'TextBoxNombrePro
        '
        Me.TextBoxNombrePro.Font = New System.Drawing.Font("Bahnschrift Condensed", 9.0!)
        Me.TextBoxNombrePro.Location = New System.Drawing.Point(671, 280)
        Me.TextBoxNombrePro.Name = "TextBoxNombrePro"
        Me.TextBoxNombrePro.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxNombrePro.TabIndex = 4
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Font = New System.Drawing.Font("Bahnschrift Condensed", 9.0!)
        Me.TextBoxPrecio.Location = New System.Drawing.Point(671, 335)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxPrecio.TabIndex = 6
        '
        'TextBoxProducto
        '
        Me.TextBoxProducto.Font = New System.Drawing.Font("Bahnschrift Condensed", 9.0!)
        Me.TextBoxProducto.Location = New System.Drawing.Point(671, 223)
        Me.TextBoxProducto.Name = "TextBoxProducto"
        Me.TextBoxProducto.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxProducto.TabIndex = 7
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.ButtonAgregar.Location = New System.Drawing.Point(671, 545)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(100, 32)
        Me.ButtonAgregar.TabIndex = 8
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'TextBoxMarca
        '
        Me.TextBoxMarca.Font = New System.Drawing.Font("Bahnschrift Condensed", 9.0!)
        Me.TextBoxMarca.Location = New System.Drawing.Point(671, 452)
        Me.TextBoxMarca.Name = "TextBoxMarca"
        Me.TextBoxMarca.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxMarca.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(628, 457)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Marca"
        '
        'Buttonedit
        '
        Me.Buttonedit.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Buttonedit.Location = New System.Drawing.Point(537, 545)
        Me.Buttonedit.Name = "Buttonedit"
        Me.Buttonedit.Size = New System.Drawing.Size(100, 32)
        Me.Buttonedit.TabIndex = 13
        Me.Buttonedit.Text = "Actualizar"
        Me.Buttonedit.UseVisualStyleBackColor = True
        '
        'Buttondelete
        '
        Me.Buttondelete.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Buttondelete.Location = New System.Drawing.Point(799, 545)
        Me.Buttondelete.Name = "Buttondelete"
        Me.Buttondelete.Size = New System.Drawing.Size(100, 32)
        Me.Buttondelete.TabIndex = 14
        Me.Buttondelete.Text = "Eliminar"
        Me.Buttondelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Location = New System.Drawing.Point(77, 162)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(397, 415)
        Me.DataGridView1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel2.Controls.Add(Me.btnmin)
        Me.Panel2.Controls.Add(Me.btncerrar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(972, 31)
        Me.Panel2.TabIndex = 22
        '
        'btnmin
        '
        Me.btnmin.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnmin.Image = CType(resources.GetObject("btnmin.Image"), System.Drawing.Image)
        Me.btnmin.Location = New System.Drawing.Point(915, 0)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(30, 31)
        Me.btnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmin.TabIndex = 24
        Me.btnmin.TabStop = False
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(942, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(30, 31)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncerrar.TabIndex = 23
        Me.btncerrar.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(886, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 32)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Cuenta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 37)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(868, 41)
        Me.DataGridView2.TabIndex = 24
        Me.DataGridView2.Visible = False
        '
        'LabelSuper
        '
        Me.LabelSuper.AutoSize = True
        Me.LabelSuper.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!)
        Me.LabelSuper.Location = New System.Drawing.Point(668, 399)
        Me.LabelSuper.Name = "LabelSuper"
        Me.LabelSuper.Size = New System.Drawing.Size(0, 17)
        Me.LabelSuper.TabIndex = 25
        '
        'DataGridViewDatos
        '
        Me.DataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDatos.Location = New System.Drawing.Point(12, 84)
        Me.DataGridViewDatos.Name = "DataGridViewDatos"
        Me.DataGridViewDatos.Size = New System.Drawing.Size(76, 35)
        Me.DataGridViewDatos.TabIndex = 26
        Me.DataGridViewDatos.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 638)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 56)
        Me.Button2.TabIndex = 128
        Me.Button2.Text = "Cerrar Secion"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(972, 706)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridViewDatos)
        Me.Controls.Add(Me.LabelSuper)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Buttondelete)
        Me.Controls.Add(Me.Buttonedit)
        Me.Controls.Add(Me.TextBoxMarca)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.TextBoxProducto)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.TextBoxNombrePro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "perfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfil"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.btnmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxNombrePro As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxProducto As TextBox
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents TextBoxMarca As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Buttonedit As Button
    Friend WithEvents Buttondelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnmin As PictureBox
    Friend WithEvents btncerrar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents LabelSuper As Label
    Friend WithEvents DataGridViewDatos As DataGridView
    Friend WithEvents Button2 As Button
End Class
