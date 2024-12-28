Imports ExitoPrecios.DInventario
Imports ExitoPrecios.Producto

Public Class LInventario
    Dim Dinventario As New DInventario()
    Dim arregloProductos As New List(Of Producto)

    Public Function obtenerNombre(codigo)
        Return Dinventario.obtenerNombre(codigo)
    End Function

    Public Function buscarSugerencia(identificador As String)
        Return Dinventario.buscarSugerencia(identificador)
    End Function


    Public Function obtenerPrecio(identificador As String)
        Return Dinventario.obtenerPrecio(identificador)
    End Function

    Public Function obtenerPrecio2(identificador As String)
        Return Dinventario.obtenerPrecio2(identificador)
    End Function

    Friend Sub LlenarArreglo(lstCodigoProducto As ListBox, lstPrecioNuevo As ListBox, lstPrecioNuevo2 As ListBox, ultimoIndex As Integer)
        Dim productoAActualizar As Producto
        For index = 0 To ultimoIndex - 1
            productoAActualizar = New Producto(lstCodigoProducto.Items.Item(index).ToString, lstPrecioNuevo.Items.Item(index).ToString, lstPrecioNuevo2.Items.Item(index).ToString)
            arregloProductos.Add(productoAActualizar)
        Next
    End Sub

    Friend Sub ActualizarLista()
        Dim index As Integer = 0
        For Each item As Producto In arregloProductos
            Dinventario.actualizarPrecioProducto(arregloProductos.Item(index).codigoProducto, arregloProductos.Item(index).precio, arregloProductos.Item(index).precio2)
            index = index + 1
        Next
    End Sub
End Class
