Imports ExitoPrecios.Producto
Imports MySql.Data.MySqlClient

Public Class frmCrearProducto

    'Globales de conexion
    Dim conexion As New MySqlConnection
    Dim datos As DataSet

    'Funciones
    Public Sub New(codigo As String)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        txtCodigo.Text = codigo
        txtDescripcion.Select()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        limpiar()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub guardarProducto()
        Dim codigo As String = txtCodigo.Text
        Dim descripcion As String = txtDescripcion.Text
        Dim precio As Double
        Dim precio2 As Double
        Dim existencias As Integer = txtExistencias.Text
        Dim unidades As Double = txtUnidades.Text
        'Comprobar error en el precio
        If txtPrecio.Text = "" Then
            precio = 0
        Else
            precio = txtPrecio.Text
        End If

        'Comprobar error en el precio2
        If txtPrecio2.Text = "" Then
            precio2 = 0
        Else
            precio2 = txtPrecio2.Text
        End If

        Dim inventario As New Producto
        'If chkUnidad.Checked = True Then
        '    inventario.asignarPadre(codigo, txtCodigoHijo.Text)
        '    inventario.guardarProductoSinHijo(codigo, descripcion, precio, existencias, unidades)
        'Else
        '    inventario.guardarProductoSinHijo(codigo, descripcion, precio, existencias, 1)
        'End If
    End Sub

    Private Sub abrirConexion()
        Try
            conexion.ConnectionString = My.Settings.conexion
            conexion.Open()

        Catch ex As Exception
            conexion.Close()
            conexion.Open()

        End Try
    End Sub

    'Controles
    Private Sub frmCrearProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()
        txtCodigo.Select()
        cambiar(False)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guardarProducto()
        limpiar()
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtExistencias.Text = "0"
        txtUnidades.Text = "0"
        txtPrecio.Text = "0"
        txtCodigoHijo.Text = ""
        txtDecripcionHijo.Text = ""
        txtPrecio.Text = ""
        txtCodigo.Select()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDescripcion.Select()
        End If
    End Sub

    Private Sub txtPrecio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            guardarProducto()
        End If
    End Sub

    Private Sub txtExistencias_KeyDown(sender As Object, e As KeyEventArgs) Handles txtExistencias.KeyDown
        If e.KeyCode = Keys.Enter Then
            guardarProducto()
        End If
    End Sub

    Private Sub btnSeleccionarHijo_Click(sender As Object, e As EventArgs) Handles btnSeleccionarHijo.Click
        frmInventarioRapido.ShowDialog()
        txtCodigoHijo.Text = frmInventarioRapido.dtgProductos.Item(0, frmInventarioRapido.dtgProductos.CurrentRow.Index).Value.ToString
        txtDecripcionHijo.Text = frmInventarioRapido.dtgProductos.Item(1, frmInventarioRapido.dtgProductos.CurrentRow.Index).Value.ToString
        txtPrecioHijo.Text = frmInventarioRapido.dtgProductos.Item(2, frmInventarioRapido.dtgProductos.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub chkUnidad_CheckedChanged(sender As Object, e As EventArgs) Handles chkUnidad.CheckedChanged
        cambiar(chkUnidad.Checked)
    End Sub

    Private Sub cambiar(activo As Boolean)
        'txtCodigoHijo.Enabled = activo
        'txtDecripcionHijo.Enabled = activo
        'txtPrecioHijo.Enabled = activo
        'lblCodigoHijo.Enabled = activo
        'lblDescripcionHijo.Enabled = activo
        'lblprecioHijo.Enabled = activo
        btnSeleccionarHijo.Enabled = activo
        txtUnidades.Enabled = activo
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblprecioHijo_Click(sender As Object, e As EventArgs) Handles lblprecioHijo.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class