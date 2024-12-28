<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizarProducto
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExistencias = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtOldCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecio2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Existencias"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Código"
        '
        'txtExistencias
        '
        Me.txtExistencias.Location = New System.Drawing.Point(40, 226)
        Me.txtExistencias.Name = "txtExistencias"
        Me.txtExistencias.Size = New System.Drawing.Size(123, 20)
        Me.txtExistencias.TabIndex = 11
        Me.txtExistencias.Text = "0"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(40, 131)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(123, 20)
        Me.txtPrecio.TabIndex = 10
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(40, 84)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(123, 20)
        Me.txtDescripcion.TabIndex = 9
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(40, 32)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(123, 20)
        Me.txtCodigo.TabIndex = 8
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(191, 64)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(105, 59)
        Me.btnActualizar.TabIndex = 16
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(191, 150)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 59)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtOldCodigo
        '
        Me.txtOldCodigo.Location = New System.Drawing.Point(188, 12)
        Me.txtOldCodigo.Name = "txtOldCodigo"
        Me.txtOldCodigo.Size = New System.Drawing.Size(123, 20)
        Me.txtOldCodigo.TabIndex = 18
        Me.txtOldCodigo.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Precio Mayorista"
        '
        'txtPrecio2
        '
        Me.txtPrecio2.Location = New System.Drawing.Point(40, 179)
        Me.txtPrecio2.Name = "txtPrecio2"
        Me.txtPrecio2.Size = New System.Drawing.Size(123, 20)
        Me.txtPrecio2.TabIndex = 19
        Me.txtPrecio2.Text = "0"
        '
        'frmActualizarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 263)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrecio2)
        Me.Controls.Add(Me.txtOldCodigo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtExistencias)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Name = "frmActualizarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmActualizarProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtExistencias As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtOldCodigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecio2 As TextBox
End Class
