Imports ExitoPrecios.Producto
Imports MySql.Data.MySqlClient

Public Class frmInventarioRapido
    'Globales de conexion
    Dim conexion As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As MySqlDataAdapter
    Private Sub seleccionar()
        'Dim codigo As String
        'codigo = dtgProductos.Item(0, dtgProductos.CurrentRow.Index).Value.ToString
        'frmFactura.txtcodigo2.Text = codigo
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        seleccionar()
        Me.Close()
    End Sub

    Private Sub actualizaGrid()
        Dim tabla As String = "inventario"
        ' Try
        conexion.ConnectionString = My.Settings.conexion
        conexion.Open()
        Dim consulta As String
        consulta = "SELECT  codigoProducto, producto, precio, precio2, existenciasLocal FROM inventario;"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, tabla)
        dtgProductos.DataSource = datos
        dtgProductos.DataMember = tabla
        conexion.Close()
        ' Catch ex As Exception
        '    MsgBox(ex)
        'End Try
    End Sub
    Private Sub envioDatosAntiguos()
        Dim inventario As New Producto
        Dim i As Integer = dtgProductos.CurrentRow.Index
        Dim codigo As String = dtgProductos.Item(0, i).Value
        Dim descripcion As String = dtgProductos.Item(1, i).Value
        Dim precio As Single = dtgProductos.Item(2, i).Value
        Dim precio2 As Single = dtgProductos.Item(3, i).Value
        Dim existencias As Integer = dtgProductos.Item(4, i).Value

        'If frmmenu.hayContrasena = True Then
        '    Dim frm As New frmContrasena(New frmActualizarProducto(codigo, descripcion, precio, precio2, existencias), False)
        '    frm.Show()
        'Else
        '    Dim formActualizacion As New frmActualizarProducto(codigo, descripcion, precio, precio2, existencias)
        '    formActualizacion.ShowDialog()
        'End If

    End Sub
    Private Sub buscarProducto(criterio As String, identificador As String)
        Dim tabla As String = "inventario"
        Try
            conexion.ConnectionString = My.Settings.conexion
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT codigoProducto, producto, precio, precio2, existenciasLocal FROM inventario where " + criterio + " LIKE '%" + identificador + "%';"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, tabla)
            dtgProductos.DataSource = datos
            dtgProductos.DataMember = tabla
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex)
        End Try
        txtbusqueda.Select()
    End Sub
    Private Sub frmInventarioRapido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizaGrid()
        txtbusqueda.Text = ""
        txtbusqueda.Select()
    End Sub
    Private Sub btnActualizarProducto_Click(sender As Object, e As EventArgs) Handles btnActualizarProducto.Click
        envioDatosAntiguos()
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        If cboBuscar.Text = "Código" Then
            buscarProducto("codigoProducto", txtbusqueda.Text)
        Else
            buscarProducto("producto", txtbusqueda.Text)
        End If
    End Sub

    Private Sub txtbusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbusqueda.KeyDown
        'Busqueda por enter
        If e.KeyCode = Keys.Enter Then
            If cboBuscar.Text = "Código" Then
                buscarProducto("codigoProducto", txtbusqueda.Text)
            Else
                buscarProducto("producto", txtbusqueda.Text)
            End If
        End If
    End Sub

    Private Sub dtgProductos_DoubleClick(sender As Object, e As EventArgs) Handles dtgProductos.DoubleClick
        seleccionar()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ''frmCrearProducto.ShowDialog()
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        If cboBuscar.Text = "RTN" Then
            buscarProducto("codigoProducto", txtbusqueda.Text)
        Else
            buscarProducto("producto", txtbusqueda.Text)
        End If
    End Sub
End Class