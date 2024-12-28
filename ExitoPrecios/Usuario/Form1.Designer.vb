<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Precio = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstPrecioProducto = New System.Windows.Forms.ListBox()
        Me.lstDescripcionProducto = New System.Windows.Forms.ListBox()
        Me.lstCodigoProducto = New System.Windows.Forms.ListBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrecioActual = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecioNuevo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lstPrecioNuevo = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecio2Actual = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNuevoPrecio2 = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lstSugerencias = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lstPrecioProducto2 = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lstPrecioNuevo2 = New System.Windows.Forms.ListBox()
        Me.btnActualizarProductos = New System.Windows.Forms.Button()
        Me.btnEliminardeLista = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Precio
        '
        Me.Precio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Precio.AutoSize = True
        Me.Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio.Location = New System.Drawing.Point(354, 329)
        Me.Precio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(79, 16)
        Me.Precio.TabIndex = 32
        Me.Precio.Text = "Precio viejo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(185, 330)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Descripción"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 329)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Código Producto"
        '
        'lstPrecioProducto
        '
        Me.lstPrecioProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPrecioProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrecioProducto.FormattingEnabled = True
        Me.lstPrecioProducto.ItemHeight = 16
        Me.lstPrecioProducto.Location = New System.Drawing.Point(342, 351)
        Me.lstPrecioProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPrecioProducto.Name = "lstPrecioProducto"
        Me.lstPrecioProducto.Size = New System.Drawing.Size(113, 212)
        Me.lstPrecioProducto.TabIndex = 27
        '
        'lstDescripcionProducto
        '
        Me.lstDescripcionProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstDescripcionProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDescripcionProducto.FormattingEnabled = True
        Me.lstDescripcionProducto.ItemHeight = 16
        Me.lstDescripcionProducto.Location = New System.Drawing.Point(166, 351)
        Me.lstDescripcionProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.lstDescripcionProducto.Name = "lstDescripcionProducto"
        Me.lstDescripcionProducto.Size = New System.Drawing.Size(202, 212)
        Me.lstDescripcionProducto.TabIndex = 26
        '
        'lstCodigoProducto
        '
        Me.lstCodigoProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstCodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCodigoProducto.FormattingEnabled = True
        Me.lstCodigoProducto.ItemHeight = 16
        Me.lstCodigoProducto.Location = New System.Drawing.Point(41, 351)
        Me.lstCodigoProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCodigoProducto.Name = "lstCodigoProducto"
        Me.lstCodigoProducto.Size = New System.Drawing.Size(130, 212)
        Me.lstCodigoProducto.TabIndex = 25
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(229, 102)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(186, 22)
        Me.txtNombre.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(431, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Precio actual"
        '
        'txtPrecioActual
        '
        Me.txtPrecioActual.Enabled = False
        Me.txtPrecioActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioActual.Location = New System.Drawing.Point(435, 102)
        Me.txtPrecioActual.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecioActual.Name = "txtPrecioActual"
        Me.txtPrecioActual.Size = New System.Drawing.Size(71, 22)
        Me.txtPrecioActual.TabIndex = 38
        Me.txtPrecioActual.Text = "0"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(49, 101)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(169, 22)
        Me.txtCodigo.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(255, 70)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Código"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(656, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Nuevo precio"
        '
        'txtPrecioNuevo
        '
        Me.txtPrecioNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioNuevo.Location = New System.Drawing.Point(660, 102)
        Me.txtPrecioNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecioNuevo.Name = "txtPrecioNuevo"
        Me.txtPrecioNuevo.Size = New System.Drawing.Size(71, 22)
        Me.txtPrecioNuevo.TabIndex = 42
        Me.txtPrecioNuevo.Text = "0"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(583, 329)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Precio nuevo"
        '
        'lstPrecioNuevo
        '
        Me.lstPrecioNuevo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPrecioNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrecioNuevo.FormattingEnabled = True
        Me.lstPrecioNuevo.ItemHeight = 16
        Me.lstPrecioNuevo.Location = New System.Drawing.Point(566, 351)
        Me.lstPrecioNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPrecioNuevo.Name = "lstPrecioNuevo"
        Me.lstPrecioNuevo.Size = New System.Drawing.Size(134, 212)
        Me.lstPrecioNuevo.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(544, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Precio2 actual"
        '
        'txtPrecio2Actual
        '
        Me.txtPrecio2Actual.Enabled = False
        Me.txtPrecio2Actual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio2Actual.Location = New System.Drawing.Point(548, 102)
        Me.txtPrecio2Actual.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecio2Actual.Name = "txtPrecio2Actual"
        Me.txtPrecio2Actual.Size = New System.Drawing.Size(71, 22)
        Me.txtPrecio2Actual.TabIndex = 45
        Me.txtPrecio2Actual.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(766, 70)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Nuevo precio2"
        '
        'txtNuevoPrecio2
        '
        Me.txtNuevoPrecio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoPrecio2.Location = New System.Drawing.Point(770, 102)
        Me.txtNuevoPrecio2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNuevoPrecio2.Name = "txtNuevoPrecio2"
        Me.txtNuevoPrecio2.Size = New System.Drawing.Size(71, 22)
        Me.txtNuevoPrecio2.TabIndex = 47
        Me.txtNuevoPrecio2.Text = "0"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnAgregar.Location = New System.Drawing.Point(881, 69)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(121, 69)
        Me.btnAgregar.TabIndex = 49
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lstSugerencias
        '
        Me.lstSugerencias.FormattingEnabled = True
        Me.lstSugerencias.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.lstSugerencias.Location = New System.Drawing.Point(49, 123)
        Me.lstSugerencias.Name = "lstSugerencias"
        Me.lstSugerencias.Size = New System.Drawing.Size(169, 82)
        Me.lstSugerencias.TabIndex = 50
        Me.lstSugerencias.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(465, 329)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Precio2 viejo"
        '
        'lstPrecioProducto2
        '
        Me.lstPrecioProducto2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPrecioProducto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrecioProducto2.FormattingEnabled = True
        Me.lstPrecioProducto2.ItemHeight = 16
        Me.lstPrecioProducto2.Location = New System.Drawing.Point(453, 351)
        Me.lstPrecioProducto2.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPrecioProducto2.Name = "lstPrecioProducto2"
        Me.lstPrecioProducto2.Size = New System.Drawing.Size(113, 212)
        Me.lstPrecioProducto2.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(713, 329)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Precio2 nuevo"
        '
        'lstPrecioNuevo2
        '
        Me.lstPrecioNuevo2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPrecioNuevo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrecioNuevo2.FormattingEnabled = True
        Me.lstPrecioNuevo2.ItemHeight = 16
        Me.lstPrecioNuevo2.Location = New System.Drawing.Point(696, 351)
        Me.lstPrecioNuevo2.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPrecioNuevo2.Name = "lstPrecioNuevo2"
        Me.lstPrecioNuevo2.Size = New System.Drawing.Size(134, 212)
        Me.lstPrecioNuevo2.TabIndex = 53
        '
        'btnActualizarProductos
        '
        Me.btnActualizarProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizarProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnActualizarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarProductos.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnActualizarProductos.Location = New System.Drawing.Point(769, 588)
        Me.btnActualizarProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizarProductos.Name = "btnActualizarProductos"
        Me.btnActualizarProductos.Size = New System.Drawing.Size(213, 69)
        Me.btnActualizarProductos.TabIndex = 55
        Me.btnActualizarProductos.Text = "Actualizar productos"
        Me.btnActualizarProductos.UseVisualStyleBackColor = False
        '
        'btnEliminardeLista
        '
        Me.btnEliminardeLista.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminardeLista.BackColor = System.Drawing.Color.Brown
        Me.btnEliminardeLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminardeLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminardeLista.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnEliminardeLista.Location = New System.Drawing.Point(881, 241)
        Me.btnEliminardeLista.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminardeLista.Name = "btnEliminardeLista"
        Me.btnEliminardeLista.Size = New System.Drawing.Size(101, 69)
        Me.btnEliminardeLista.TabIndex = 56
        Me.btnEliminardeLista.Text = "Eliminar de la lista"
        Me.btnEliminardeLista.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnActualizar.Location = New System.Drawing.Point(881, 318)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(101, 72)
        Me.btnActualizar.TabIndex = 57
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button5.Location = New System.Drawing.Point(881, 162)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 71)
        Me.Button5.TabIndex = 58
        Me.Button5.Text = "Crear producto"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 681)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminardeLista)
        Me.Controls.Add(Me.btnActualizarProductos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lstPrecioNuevo2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lstPrecioProducto2)
        Me.Controls.Add(Me.lstSugerencias)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNuevoPrecio2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrecio2Actual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrecioNuevo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrecioActual)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Precio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstPrecioNuevo)
        Me.Controls.Add(Me.lstPrecioProducto)
        Me.Controls.Add(Me.lstDescripcionProducto)
        Me.Controls.Add(Me.lstCodigoProducto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Precio As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lstPrecioProducto As ListBox
    Friend WithEvents lstDescripcionProducto As ListBox
    Friend WithEvents lstCodigoProducto As ListBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrecioActual As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrecioNuevo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lstPrecioNuevo As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecio2Actual As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNuevoPrecio2 As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lstSugerencias As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lstPrecioProducto2 As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lstPrecioNuevo2 As ListBox
    Friend WithEvents btnActualizarProductos As Button
    Friend WithEvents btnEliminardeLista As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Button5 As Button
End Class
