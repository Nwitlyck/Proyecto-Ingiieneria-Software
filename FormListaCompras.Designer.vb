<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormListaCompras
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxtotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Location = New System.Drawing.Point(194, 152)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 323)
        Me.DataGridView1.TabIndex = 93
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.Location = New System.Drawing.Point(197, 506)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(132, 49)
        Me.ButtonEliminar.TabIndex = 94
        Me.ButtonEliminar.Text = "Eliminar de la lista"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(635, 506)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 19)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Total"
        '
        'TextBoxtotal
        '
        Me.TextBoxtotal.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxtotal.Location = New System.Drawing.Point(639, 528)
        Me.TextBoxtotal.Name = "TextBoxtotal"
        Me.TextBoxtotal.ReadOnly = True
        Me.TextBoxtotal.Size = New System.Drawing.Size(100, 27)
        Me.TextBoxtotal.TabIndex = 96
        Me.TextBoxtotal.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 45)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Lista de Compra"
        '
        'FormListaCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 667)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxtotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormListaCompras"
        Me.Text = "FormListaCompras"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxtotal As TextBox
    Friend WithEvents Label2 As Label
End Class
