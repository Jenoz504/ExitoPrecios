Imports ExitoPrecios.LInventario

Public Class Form1
    Private LInventario As New LInventario()

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        Dim codigo As String = txtCodigo.Text
        LlenarTextBox(codigo)

    End Sub

    Private Sub LlenarTextBox(codigo As String)
        txtNombre.Text = LInventario.obtenerNombre(codigo)
        txtPrecioActual.Text = LInventario.obtenerPrecio(codigo)
        txtPrecio2Actual.Text = LInventario.obtenerPrecio2(codigo)
        lstSugerencias.DataSource = LInventario.buscarSugerencia(codigo)
        lstSugerencias.DisplayMember = "codigoProducto"
        lstSugerencias.ValueMember = "codigoProducto"
        'sugerencias, falla al momento de conectar el lst con la base de datos
        If lstSugerencias.Items.Count > 0 And txtCodigo.Text <> "" Then
            lstSugerencias.Visible = True
        Else
            lstSugerencias.Visible = False
        End If
    End Sub

    Private Sub lstSugerencias_Click(sender As Object, e As EventArgs) Handles lstSugerencias.Click
        listaSugerencia()
    End Sub

    Private Sub listaSugerencia()
        Dim seleccion As String
        seleccion = lstSugerencias.SelectedValue
        txtCodigo.Text = seleccion
        lstSugerencias.Visible = False
        txtPrecioNuevo.Select()
    End Sub
    Private Sub lstSugerencias_KeyUp(sender As Object, e As KeyEventArgs) Handles lstSugerencias.KeyUp
        If e.KeyCode = Keys.Enter Then
            listaSugerencia()
        End If
    End Sub
    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Down Then
            lstSugerencias.Select()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Select()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        agregarProducto()
    End Sub
    Private Sub agregarProducto()
        Dim codigo As String
        Dim descripcion As String
        Dim precioActual As Single
        Dim precio2Actual As Single
        Dim precioNuevo As Single
        Dim precio2Nuevo As Single

        codigo = txtCodigo.Text
        descripcion = txtNombre.Text
        precio2Actual = txtPrecio2Actual.Text
        Try
            precioActual = txtPrecioActual.Text
        Catch ex As Exception
            precioActual = 0
        End Try
        Try
            precioNuevo = txtPrecioNuevo.Text
        Catch ex As Exception
            precioActual = 0
        End Try

        If txtNuevoPrecio2.Text = "" Then
            precio2Nuevo = 0
        Else
            precio2Nuevo = txtNuevoPrecio2.Text
        End If

        If precioNuevo <> 0 Then
            lstCodigoProducto.Items.Add(codigo)
            lstDescripcionProducto.Items.Add(descripcion)
            lstPrecioProducto.Items.Add(Format(CSng(precioActual), "F"))
            lstPrecioProducto2.Items.Add(Format(CSng(precio2Actual), "F"))
            lstPrecioNuevo.Items.Add(Format(CSng(precioNuevo), "F"))
            lstPrecioNuevo2.Items.Add(Format(CSng(precio2Nuevo), "F"))
            limpiar()
        Else
            MsgBox("El Precio no puede ser 0")
        End If
        seleccionarUltimo()


    End Sub

    Private Sub limpiar()
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtPrecioNuevo.Text = ""
        txtNuevoPrecio2.Text = ""
        txtCodigo.Select()
    End Sub

    Private Sub seleccionarUltimo()
        'Selecciona el ultimo registro del data
        Dim ultimo As Integer
        ultimo = obtenerUltimoIndex()
        lstCodigoProducto.SelectedIndex = ultimo - 1
    End Sub

    Private Function obtenerUltimoIndex() As Integer
        Return lstCodigoProducto.Items.Count
    End Function

    Private Sub btnActualizarProductos_Click(sender As Object, e As EventArgs) Handles btnActualizarProductos.Click
        ActualizarProductos()
    End Sub

    Private Sub ActualizarProductos()
        LInventario.LlenarArreglo(lstCodigoProducto, lstPrecioNuevo, lstPrecioNuevo2, obtenerUltimoIndex())
        LInventario.ActualizarLista()
    End Sub

    Private Sub seleccionarListBoxEnCadena(index As Integer)
        On Error Resume Next
        lstCodigoProducto.SelectedIndex = index
        On Error Resume Next
        lstDescripcionProducto.SelectedIndex = index
        On Error Resume Next
        lstPrecioProducto.SelectedIndex = index
        On Error Resume Next
        lstPrecioProducto2.SelectedIndex = index
        On Error Resume Next
        lstPrecioNuevo.SelectedIndex = index
        On Error Resume Next
        lstPrecioNuevo2.SelectedIndex = index
        On Error Resume Next
    End Sub
    Private Sub lstCodigoProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCodigoProducto.SelectedIndexChanged
        seleccionarListBoxEnCadena(lstCodigoProducto.SelectedIndex)
    End Sub

    Private Sub lstDescripcionProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDescripcionProducto.SelectedIndexChanged
        seleccionarListBoxEnCadena(lstDescripcionProducto.SelectedIndex)
    End Sub

    Private Sub lstPrecioProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrecioProducto.SelectedIndexChanged
        seleccionarListBoxEnCadena(lstPrecioProducto.SelectedIndex)
    End Sub
    Private Sub lstPrecioProducto2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrecioProducto2.SelectedIndexChanged
        seleccionarListBoxEnCadena(lstPrecioProducto2.SelectedIndex)
    End Sub

    Private Sub lstPrecioNuevo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrecioNuevo.SelectedIndexChanged
        seleccionarListBoxEnCadena(lstPrecioNuevo.SelectedIndex)
    End Sub
    Private Sub lstPrecioNuevo2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrecioNuevo2.SelectedIndexChanged
        seleccionarListBoxEnCadena(lstPrecioNuevo2.SelectedIndex)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Actualizar()
    End Sub

    Private Sub Actualizar()
        Try
            Dim index As Integer = lstCodigoProducto.SelectedIndex
            Dim precio As Single = lstPrecioNuevo.SelectedItem
            Dim precio2 As Single = lstPrecioNuevo2.SelectedItem
            Dim frmactualizar As New FrmModificar(precio, precio2)
            frmactualizar.ShowDialog()
            Dim nuevoPrecio As Single = frmactualizar.txtPrecio1.Text
            Dim nuevoPrecio2 As Single = frmactualizar.txtprecio2.Text

            lstPrecioNuevo.Items.RemoveAt(index)
            lstPrecioNuevo2.Items.RemoveAt(index)
            lstPrecioNuevo.Items.Insert(index, Format(CSng(nuevoPrecio), "F"))
            lstPrecioNuevo2.Items.Insert(index, Format(CSng(nuevoPrecio2), "F"))
            txtCodigo.Select()
        Catch ex As Exception
            MsgBox("Seleccione un item para poder actualizar")
        End Try
    End Sub

    Private Sub btnEliminardeLista_Click(sender As Object, e As EventArgs) Handles btnEliminardeLista.Click
        If MsgBox("¿Seguro que quiere eliminar el producto de la factura?", vbYesNo, "Información") = vbYes Then
            eliminarItem()
        End If
    End Sub


    Private Sub eliminarItem()
        Dim index As Integer = lstPrecioProducto.SelectedIndex

        Try
            lstCodigoProducto.Items.RemoveAt(index)
            lstDescripcionProducto.Items.RemoveAt(index)
            lstPrecioProducto.Items.RemoveAt(index)
            lstPrecioProducto2.Items.RemoveAt(index)
            lstPrecioNuevo.Items.RemoveAt(index)
            lstPrecioNuevo2.Items.RemoveAt(index)
            txtCodigo.Select()
        Catch ex As Exception
            MsgBox("Seleccione el recuadro que desea eliminar")
        End Try
    End Sub

    Private Sub txtPrecioNuevo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPrecioNuevo.KeyUp
        If e.KeyCode = Keys.Enter Then
            agregarProducto()
        End If
    End Sub
End Class
