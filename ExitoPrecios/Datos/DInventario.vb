Imports MySql.Data.MySqlClient

Public Class DInventario
    Dim conexion As New MySqlConnection(My.Settings.conexion)
    Dim lstsugerencias As New ListBox
    Public Function obtenerNombre(codigo)
        conexion.Open()
        Dim tabla As String = "inventario"
        Dim datos As DataSet

        Dim instruccion As String = "SELECT producto FROM inventario where codigoProducto = '" + codigo + "';"
        Dim comando As New MySqlCommand(instruccion)
        Dim adaptador As New MySqlDataAdapter(instruccion, conexion)
        datos = New DataSet
        Dim dt As New DataTable(tabla)
        adaptador.Fill(dt)

        conexion.Close()
        If dt.Rows.Count < 1 Then
            Return ""
        Else
            Dim row As DataRow = dt.Rows(0)
            Return CStr(row("producto"))
        End If
    End Function

    Public Function obtenerPrecio(codigo)
        conexion.Open()
        Dim tabla As String = "inventario"
        Dim datos As DataSet

        Dim instruccion As String = "SELECT precio FROM inventario where codigoProducto = '" + codigo + "';"
        Dim comando As New MySqlCommand(instruccion)
        Dim adaptador As New MySqlDataAdapter(instruccion, conexion)
        datos = New DataSet
        Dim dt As New DataTable(tabla)
        adaptador.Fill(dt)

        conexion.Close()
        If dt.Rows.Count < 1 Then
            Return ""
        Else
            Dim row As DataRow = dt.Rows(0)
            Return CStr(row("precio"))
        End If
    End Function

    Public Function obtenerPrecio2(codigo)
        conexion.Open()
        Dim tabla As String = "inventario"
        Dim datos As DataSet

        Dim instruccion As String = "SELECT precio2 FROM inventario where codigoProducto = '" + codigo + "';"
        Dim comando As New MySqlCommand(instruccion)
        Dim adaptador As New MySqlDataAdapter(instruccion, conexion)
        datos = New DataSet
        Dim dt As New DataTable(tabla)
        adaptador.Fill(dt)

        conexion.Close()
        If dt.Rows.Count < 1 Then
            Return ""
        Else
            Dim row As DataRow = dt.Rows(0)
            Return CStr(row("precio2"))
        End If
    End Function


    Public Function buscarSugerencia(identificador As String)
        conexion.Open()
        Dim tabla As String = "inventario"
        Dim datos As DataSet

        Dim instruccion As String = "SELECT codigoProducto FROM inventario WHERE codigoProducto LIKE '%" & identificador & "%';"
        Dim comando As New MySqlCommand(instruccion)
        Dim adaptador As New MySqlDataAdapter(instruccion, conexion)
        datos = New DataSet
        Dim dt As New DataTable(tabla)
        adaptador.Fill(dt)
        conexion.Close()

        Return dt

    End Function

    Public Sub actualizarPrecioProducto(codigo As String, precio As String, precio2 As String)
        Try
            conexion.Open()
            Dim comando As New MySqlCommand("Update inventario SET codigoProducto = @codigoProducto, precio = @precio, precio2 = @precio2 WHERE codigoProducto = @oldCodigoProducto;", conexion)
            comando.Parameters.AddWithValue("@codigoProducto", codigo)
            comando.Parameters.AddWithValue("@precio", precio)
            comando.Parameters.AddWithValue("@precio2", precio2)
            comando.Parameters.AddWithValue("@oldCodigoProducto", codigo)
            comando.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            Try
                conexion.Close()
            Catch
                conexion.Open()
                conexion.Close()
            End Try
            MsgBox(ex)
        End Try
    End Sub
End Class
