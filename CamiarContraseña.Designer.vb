<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CamiarContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CamiarContraseña))
        Me.btnmin = New System.Windows.Forms.PictureBox()
        Me.btnmax = New System.Windows.Forms.PictureBox()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonIniciosesion = New System.Windows.Forms.Button()
        Me.ButtonRegistrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxContrarena = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.btnres = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxReContrasena = New System.Windows.Forms.TextBox()
        CType(Me.btnmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnmin
        '
        Me.btnmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmin.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnmin.Image = CType(resources.GetObject("btnmin.Image"), System.Drawing.Image)
        Me.btnmin.Location = New System.Drawing.Point(712, 0)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(30, 31)
        Me.btnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmin.TabIndex = 20
        Me.btnmin.TabStop = False
        '
        'btnmax
        '
        Me.btnmax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmax.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnmax.Image = CType(resources.GetObject("btnmax.Image"), System.Drawing.Image)
        Me.btnmax.Location = New System.Drawing.Point(741, 0)
        Me.btnmax.Name = "btnmax"
        Me.btnmax.Size = New System.Drawing.Size(30, 31)
        Me.btnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmax.TabIndex = 19
        Me.btnmax.TabStop = False
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(770, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(30, 31)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncerrar.TabIndex = 18
        Me.btncerrar.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 450)
        Me.Panel1.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(714, 31)
        Me.Panel2.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(50, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ButtonIniciosesion
        '
        Me.ButtonIniciosesion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonIniciosesion.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIniciosesion.Location = New System.Drawing.Point(602, 264)
        Me.ButtonIniciosesion.Name = "ButtonIniciosesion"
        Me.ButtonIniciosesion.Size = New System.Drawing.Size(101, 51)
        Me.ButtonIniciosesion.TabIndex = 16
        Me.ButtonIniciosesion.Text = "Cambiar Contraseña"
        Me.ButtonIniciosesion.UseVisualStyleBackColor = True
        '
        'ButtonRegistrar
        '
        Me.ButtonRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonRegistrar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistrar.Location = New System.Drawing.Point(450, 264)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(91, 51)
        Me.ButtonRegistrar.TabIndex = 15
        Me.ButtonRegistrar.Text = "Volver"
        Me.ButtonRegistrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(431, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nueva Contraseña"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(465, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Usuario"
        '
        'TextBoxContrarena
        '
        Me.TextBoxContrarena.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxContrarena.Location = New System.Drawing.Point(586, 152)
        Me.TextBoxContrarena.Name = "TextBoxContrarena"
        Me.TextBoxContrarena.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxContrarena.TabIndex = 12
        Me.TextBoxContrarena.UseSystemPasswordChar = True
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxNombre.Location = New System.Drawing.Point(586, 110)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxNombre.TabIndex = 11
        '
        'btnres
        '
        Me.btnres.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnres.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnres.Image = CType(resources.GetObject("btnres.Image"), System.Drawing.Image)
        Me.btnres.Location = New System.Drawing.Point(741, 0)
        Me.btnres.Name = "btnres"
        Me.btnres.Size = New System.Drawing.Size(30, 31)
        Me.btnres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnres.TabIndex = 21
        Me.btnres.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(430, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Repita Contraseña"
        '
        'TextBoxReContrasena
        '
        Me.TextBoxReContrasena.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxReContrasena.Location = New System.Drawing.Point(586, 194)
        Me.TextBoxReContrasena.Name = "TextBoxReContrasena"
        Me.TextBoxReContrasena.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxReContrasena.TabIndex = 22
        Me.TextBoxReContrasena.UseSystemPasswordChar = True
        '
        'CamiarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxReContrasena)
        Me.Controls.Add(Me.btnmin)
        Me.Controls.Add(Me.btnmax)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonIniciosesion)
        Me.Controls.Add(Me.ButtonRegistrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxContrarena)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.btnres)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CamiarContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CamiarContraseña"
        CType(Me.btnmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnmin As PictureBox
    Friend WithEvents btnmax As PictureBox
    Friend WithEvents btncerrar As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonIniciosesion As Button
    Friend WithEvents ButtonRegistrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxContrarena As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents btnres As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxReContrasena As TextBox
End Class
