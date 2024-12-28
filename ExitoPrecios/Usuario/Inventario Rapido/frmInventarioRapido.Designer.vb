<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventarioRapido
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.dtgProductos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnActualizarProducto = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dtgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboBuscar
        '
        Me.cboBuscar.DisplayMember = "Código"
        Me.cboBuscar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"Código", "Nombre"})
        Me.cboBuscar.Location = New System.Drawing.Point(17, 58)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(121, 25)
        Me.cboBuscar.TabIndex = 14
        Me.cboBuscar.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Código"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Buscar por"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProducto.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarProducto.Location = New System.Drawing.Point(396, 31)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(136, 51)
        Me.btnBuscarProducto.TabIndex = 11
        Me.btnBuscarProducto.Text = "Buscar "
        Me.btnBuscarProducto.UseVisualStyleBackColor = False
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.Location = New System.Drawing.Point(211, 59)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(139, 23)
        Me.txtbusqueda.TabIndex = 10
        '
        'dtgProductos
        '
        Me.dtgProductos.AllowUserToAddRows = False
        Me.dtgProductos.AllowUserToDeleteRows = False
        Me.dtgProductos.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.dtgProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgProductos.ColumnHeadersHeight = 30
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgProductos.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtgProductos.Location = New System.Drawing.Point(27, 117)
        Me.dtgProductos.Name = "dtgProductos"
        Me.dtgProductos.ReadOnly = True
        Me.dtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgProductos.Size = New System.Drawing.Size(505, 225)
        Me.dtgProductos.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(396, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 51)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Seleccionar "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnActualizarProducto
        '
        Me.btnActualizarProducto.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnActualizarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarProducto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarProducto.ForeColor = System.Drawing.SystemColors.Control
        Me.btnActualizarProducto.Location = New System.Drawing.Point(211, 371)
        Me.btnActualizarProducto.Name = "btnActualizarProducto"
        Me.btnActualizarProducto.Size = New System.Drawing.Size(141, 51)
        Me.btnActualizarProducto.TabIndex = 17
        Me.btnActualizarProducto.Text = "Actualizar Producto"
        Me.btnActualizarProducto.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(27, 371)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 51)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Crear Producto"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmInventarioRapido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnActualizarProducto)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtgProductos)
        Me.Controls.Add(Me.cboBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscarProducto)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Name = "frmInventarioRapido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInventarioRapido"
        CType(Me.dtgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboBuscar As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents txtbusqueda As TextBox
    Friend WithEvents dtgProductos As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents btnActualizarProducto As Button
    Friend WithEvents Button2 As Button
End Class
