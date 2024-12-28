<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCrearProducto
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
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtExistencias = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.chkUnidad = New System.Windows.Forms.CheckBox()
        Me.lblCodigoHijo = New System.Windows.Forms.Label()
        Me.txtCodigoHijo = New System.Windows.Forms.TextBox()
        Me.btnSeleccionarHijo = New System.Windows.Forms.Button()
        Me.lblprecioHijo = New System.Windows.Forms.Label()
        Me.lblDescripcionHijo = New System.Windows.Forms.Label()
        Me.txtPrecioHijo = New System.Windows.Forms.TextBox()
        Me.txtDecripcionHijo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrecio2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(57, 72)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(135, 26)
        Me.txtCodigo.TabIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(209, 72)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(341, 26)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(556, 72)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(66, 26)
        Me.txtPrecio.TabIndex = 2
        '
        'txtExistencias
        '
        Me.txtExistencias.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExistencias.Location = New System.Drawing.Point(189, 145)
        Me.txtExistencias.Name = "txtExistencias"
        Me.txtExistencias.Size = New System.Drawing.Size(78, 26)
        Me.txtExistencias.TabIndex = 3
        Me.txtExistencias.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Código*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(552, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Precio*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Existencias"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLimpiar.BackColor = System.Drawing.Color.Brown
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLimpiar.Location = New System.Drawing.Point(276, 404)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(131, 44)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardar.Location = New System.Drawing.Point(81, 404)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(131, 44)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.Brown
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelar.Location = New System.Drawing.Point(469, 404)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(131, 44)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(286, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Unidades por producto"
        '
        'txtUnidades
        '
        Me.txtUnidades.Enabled = False
        Me.txtUnidades.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidades.Location = New System.Drawing.Point(289, 145)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(78, 26)
        Me.txtUnidades.TabIndex = 11
        Me.txtUnidades.Text = "1"
        '
        'chkUnidad
        '
        Me.chkUnidad.AutoSize = True
        Me.chkUnidad.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUnidad.Location = New System.Drawing.Point(390, 148)
        Me.chkUnidad.Margin = New System.Windows.Forms.Padding(2)
        Me.chkUnidad.Name = "chkUnidad"
        Me.chkUnidad.Size = New System.Drawing.Size(142, 23)
        Me.chkUnidad.TabIndex = 13
        Me.chkUnidad.Text = "Adjuntar Unidad"
        Me.chkUnidad.UseVisualStyleBackColor = True
        '
        'lblCodigoHijo
        '
        Me.lblCodigoHijo.AutoSize = True
        Me.lblCodigoHijo.Enabled = False
        Me.lblCodigoHijo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoHijo.Location = New System.Drawing.Point(55, 230)
        Me.lblCodigoHijo.Name = "lblCodigoHijo"
        Me.lblCodigoHijo.Size = New System.Drawing.Size(100, 20)
        Me.lblCodigoHijo.TabIndex = 15
        Me.lblCodigoHijo.Text = "Código Hijo*"
        '
        'txtCodigoHijo
        '
        Me.txtCodigoHijo.Enabled = False
        Me.txtCodigoHijo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoHijo.Location = New System.Drawing.Point(57, 253)
        Me.txtCodigoHijo.Name = "txtCodigoHijo"
        Me.txtCodigoHijo.Size = New System.Drawing.Size(135, 26)
        Me.txtCodigoHijo.TabIndex = 14
        '
        'btnSeleccionarHijo
        '
        Me.btnSeleccionarHijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnSeleccionarHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionarHijo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarHijo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSeleccionarHijo.Location = New System.Drawing.Point(207, 234)
        Me.btnSeleccionarHijo.Name = "btnSeleccionarHijo"
        Me.btnSeleccionarHijo.Size = New System.Drawing.Size(175, 44)
        Me.btnSeleccionarHijo.TabIndex = 16
        Me.btnSeleccionarHijo.Text = "Seleccionar Hijo"
        Me.btnSeleccionarHijo.UseVisualStyleBackColor = False
        '
        'lblprecioHijo
        '
        Me.lblprecioHijo.AutoSize = True
        Me.lblprecioHijo.Enabled = False
        Me.lblprecioHijo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecioHijo.Location = New System.Drawing.Point(400, 290)
        Me.lblprecioHijo.Name = "lblprecioHijo"
        Me.lblprecioHijo.Size = New System.Drawing.Size(92, 20)
        Me.lblprecioHijo.TabIndex = 20
        Me.lblprecioHijo.Text = "Precio Hijo*"
        '
        'lblDescripcionHijo
        '
        Me.lblDescripcionHijo.AutoSize = True
        Me.lblDescripcionHijo.Enabled = False
        Me.lblDescripcionHijo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionHijo.Location = New System.Drawing.Point(53, 288)
        Me.lblDescripcionHijo.Name = "lblDescripcionHijo"
        Me.lblDescripcionHijo.Size = New System.Drawing.Size(132, 20)
        Me.lblDescripcionHijo.TabIndex = 19
        Me.lblDescripcionHijo.Text = "Descripción Hijo*"
        '
        'txtPrecioHijo
        '
        Me.txtPrecioHijo.Enabled = False
        Me.txtPrecioHijo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioHijo.Location = New System.Drawing.Point(404, 312)
        Me.txtPrecioHijo.Name = "txtPrecioHijo"
        Me.txtPrecioHijo.Size = New System.Drawing.Size(66, 26)
        Me.txtPrecioHijo.TabIndex = 18
        '
        'txtDecripcionHijo
        '
        Me.txtDecripcionHijo.Enabled = False
        Me.txtDecripcionHijo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecripcionHijo.Location = New System.Drawing.Point(57, 312)
        Me.txtDecripcionHijo.Name = "txtDecripcionHijo"
        Me.txtDecripcionHijo.Size = New System.Drawing.Size(341, 26)
        Me.txtDecripcionHijo.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 23)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Datos del producto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(276, 23)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Datos del producto a detalle"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 20)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Precio Mayorista"
        '
        'txtPrecio2
        '
        Me.txtPrecio2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio2.Location = New System.Drawing.Point(57, 145)
        Me.txtPrecio2.Name = "txtPrecio2"
        Me.txtPrecio2.Size = New System.Drawing.Size(66, 26)
        Me.txtPrecio2.TabIndex = 23
        '
        'frmCrearProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(674, 459)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPrecio2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblprecioHijo)
        Me.Controls.Add(Me.lblDescripcionHijo)
        Me.Controls.Add(Me.txtPrecioHijo)
        Me.Controls.Add(Me.txtDecripcionHijo)
        Me.Controls.Add(Me.btnSeleccionarHijo)
        Me.Controls.Add(Me.lblCodigoHijo)
        Me.Controls.Add(Me.txtCodigoHijo)
        Me.Controls.Add(Me.chkUnidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUnidades)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtExistencias)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Name = "frmCrearProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCrearProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtExistencias As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUnidades As TextBox
    Friend WithEvents chkUnidad As CheckBox
    Friend WithEvents lblCodigoHijo As Label
    Friend WithEvents txtCodigoHijo As TextBox
    Friend WithEvents btnSeleccionarHijo As Button
    Friend WithEvents lblprecioHijo As Label
    Friend WithEvents lblDescripcionHijo As Label
    Friend WithEvents txtPrecioHijo As TextBox
    Friend WithEvents txtDecripcionHijo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPrecio2 As TextBox
End Class
