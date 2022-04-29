<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.panelcabecera = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btncerrarsesion = New System.Windows.Forms.Button()
        Me.btnperfil = New System.Windows.Forms.Button()
        Me.btntiendas = New System.Windows.Forms.Button()
        Me.btnlista = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.PictureBox()
        Me.panelcontenedor = New System.Windows.Forms.Panel()
        Me.ocultmenu = New System.Windows.Forms.Timer(Me.components)
        Me.mostmenu = New System.Windows.Forms.Timer(Me.components)
        Me.panelcabecera.SuspendLayout()
        Me.panelmenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelcabecera
        '
        Me.panelcabecera.BackColor = System.Drawing.Color.DarkTurquoise
        Me.panelcabecera.Controls.Add(Me.Label3)
        Me.panelcabecera.Controls.Add(Me.btnmin)
        Me.panelcabecera.Controls.Add(Me.btncerrar)
        Me.panelcabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelcabecera.Location = New System.Drawing.Point(0, 0)
        Me.panelcabecera.Name = "panelcabecera"
        Me.panelcabecera.Size = New System.Drawing.Size(1212, 40)
        Me.panelcabecera.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Menu Principal"
        '
        'btnmin
        '
        Me.btnmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmin.FlatAppearance.BorderSize = 0
        Me.btnmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmin.Image = CType(resources.GetObject("btnmin.Image"), System.Drawing.Image)
        Me.btnmin.Location = New System.Drawing.Point(1123, 0)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(40, 40)
        Me.btnmin.TabIndex = 5
        Me.btnmin.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(1169, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(40, 40)
        Me.btncerrar.TabIndex = 4
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelmenu.Controls.Add(Me.PictureBox1)
        Me.panelmenu.Controls.Add(Me.Panel9)
        Me.panelmenu.Controls.Add(Me.Panel8)
        Me.panelmenu.Controls.Add(Me.Panel7)
        Me.panelmenu.Controls.Add(Me.Panel6)
        Me.panelmenu.Controls.Add(Me.Panel5)
        Me.panelmenu.Controls.Add(Me.Panel4)
        Me.panelmenu.Controls.Add(Me.btncerrarsesion)
        Me.panelmenu.Controls.Add(Me.btnperfil)
        Me.panelmenu.Controls.Add(Me.btntiendas)
        Me.panelmenu.Controls.Add(Me.btnlista)
        Me.panelmenu.Controls.Add(Me.btnbuscar)
        Me.panelmenu.Controls.Add(Me.btnhome)
        Me.panelmenu.Controls.Add(Me.btnmenu)
        Me.panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelmenu.Location = New System.Drawing.Point(0, 40)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(240, 706)
        Me.panelmenu.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(55, 437)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel9.Location = New System.Drawing.Point(0, 653)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(5, 50)
        Me.Panel9.TabIndex = 22
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel8.Location = New System.Drawing.Point(0, 314)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(5, 50)
        Me.Panel8.TabIndex = 21
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel7.Location = New System.Drawing.Point(0, 258)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 50)
        Me.Panel7.TabIndex = 20
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel6.Location = New System.Drawing.Point(0, 202)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 19
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel5.Location = New System.Drawing.Point(0, 146)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 18
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel4.Location = New System.Drawing.Point(0, 90)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 17
        '
        'btncerrarsesion
        '
        Me.btncerrarsesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrarsesion.FlatAppearance.BorderSize = 0
        Me.btncerrarsesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btncerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrarsesion.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrarsesion.ForeColor = System.Drawing.Color.White
        Me.btncerrarsesion.Image = CType(resources.GetObject("btncerrarsesion.Image"), System.Drawing.Image)
        Me.btncerrarsesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncerrarsesion.Location = New System.Drawing.Point(4, 653)
        Me.btncerrarsesion.Name = "btncerrarsesion"
        Me.btncerrarsesion.Size = New System.Drawing.Size(236, 50)
        Me.btncerrarsesion.TabIndex = 16
        Me.btncerrarsesion.Text = "     Cerrar Sesión"
        Me.btncerrarsesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncerrarsesion.UseVisualStyleBackColor = True
        '
        'btnperfil
        '
        Me.btnperfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnperfil.FlatAppearance.BorderSize = 0
        Me.btnperfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnperfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnperfil.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnperfil.ForeColor = System.Drawing.Color.White
        Me.btnperfil.Image = CType(resources.GetObject("btnperfil.Image"), System.Drawing.Image)
        Me.btnperfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnperfil.Location = New System.Drawing.Point(3, 314)
        Me.btnperfil.Name = "btnperfil"
        Me.btnperfil.Size = New System.Drawing.Size(236, 50)
        Me.btnperfil.TabIndex = 15
        Me.btnperfil.Text = "     Perfil"
        Me.btnperfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnperfil.UseVisualStyleBackColor = True
        '
        'btntiendas
        '
        Me.btntiendas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntiendas.FlatAppearance.BorderSize = 0
        Me.btntiendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btntiendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntiendas.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntiendas.ForeColor = System.Drawing.Color.White
        Me.btntiendas.Image = CType(resources.GetObject("btntiendas.Image"), System.Drawing.Image)
        Me.btntiendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntiendas.Location = New System.Drawing.Point(3, 258)
        Me.btntiendas.Name = "btntiendas"
        Me.btntiendas.Size = New System.Drawing.Size(236, 50)
        Me.btntiendas.TabIndex = 14
        Me.btntiendas.Text = "     Tiendas"
        Me.btntiendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btntiendas.UseVisualStyleBackColor = True
        '
        'btnlista
        '
        Me.btnlista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlista.FlatAppearance.BorderSize = 0
        Me.btnlista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnlista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlista.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlista.ForeColor = System.Drawing.Color.White
        Me.btnlista.Image = CType(resources.GetObject("btnlista.Image"), System.Drawing.Image)
        Me.btnlista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlista.Location = New System.Drawing.Point(4, 202)
        Me.btnlista.Name = "btnlista"
        Me.btnlista.Size = New System.Drawing.Size(236, 50)
        Me.btnlista.TabIndex = 13
        Me.btnlista.Text = "     Lista de  Compra"
        Me.btnlista.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlista.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbuscar.FlatAppearance.BorderSize = 0
        Me.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ForeColor = System.Drawing.Color.White
        Me.btnbuscar.Image = CType(resources.GetObject("btnbuscar.Image"), System.Drawing.Image)
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.Location = New System.Drawing.Point(3, 146)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(237, 50)
        Me.btnbuscar.TabIndex = 12
        Me.btnbuscar.Text = "     Buscar"
        Me.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnhome
        '
        Me.btnhome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhome.FlatAppearance.BorderSize = 0
        Me.btnhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhome.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.Color.White
        Me.btnhome.Image = CType(resources.GetObject("btnhome.Image"), System.Drawing.Image)
        Me.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhome.Location = New System.Drawing.Point(3, 90)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(236, 50)
        Me.btnhome.TabIndex = 11
        Me.btnhome.Text = "     Home"
        Me.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhome.UseVisualStyleBackColor = True
        '
        'btnmenu
        '
        Me.btnmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmenu.Image = CType(resources.GetObject("btnmenu.Image"), System.Drawing.Image)
        Me.btnmenu.Location = New System.Drawing.Point(184, 6)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(56, 43)
        Me.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmenu.TabIndex = 10
        Me.btnmenu.TabStop = False
        '
        'panelcontenedor
        '
        Me.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelcontenedor.Location = New System.Drawing.Point(240, 40)
        Me.panelcontenedor.Name = "panelcontenedor"
        Me.panelcontenedor.Size = New System.Drawing.Size(972, 706)
        Me.panelcontenedor.TabIndex = 3
        '
        'ocultmenu
        '
        '
        'mostmenu
        '
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 746)
        Me.Controls.Add(Me.panelcontenedor)
        Me.Controls.Add(Me.panelmenu)
        Me.Controls.Add(Me.panelcabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenu"
        Me.Text = "menu"
        Me.panelcabecera.ResumeLayout(False)
        Me.panelcabecera.PerformLayout()
        Me.panelmenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelcabecera As Panel
    Friend WithEvents btnmin As Button
    Friend WithEvents btncerrar As Button
    Friend WithEvents panelmenu As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btncerrarsesion As Button
    Friend WithEvents btnperfil As Button
    Friend WithEvents btntiendas As Button
    Friend WithEvents btnlista As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents btnmenu As PictureBox
    Friend WithEvents panelcontenedor As Panel
    Friend WithEvents ocultmenu As Timer
    Friend WithEvents mostmenu As Timer
    Friend WithEvents Label3 As Label
End Class
