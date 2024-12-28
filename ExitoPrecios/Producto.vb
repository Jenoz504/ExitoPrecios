Public Class Producto
    Friend codigoProducto As String
    Friend producto As String
    Friend precio As Double
    Friend precio2 As Double

    Public Sub New(codigoProducto As String, producto As String, precio As Double, precio2 As Double)
        Me.codigoProducto = codigoProducto
        Me.producto = producto
        Me.precio = precio
        Me.precio2 = precio2
    End Sub

    Public Sub New()

    End Sub

    Public Sub New(codigoProducto As String, precio As Double, precio2 As Double)
        Me.codigoProducto = codigoProducto
        Me.precio = precio
        Me.precio2 = precio2
    End Sub

End Class
