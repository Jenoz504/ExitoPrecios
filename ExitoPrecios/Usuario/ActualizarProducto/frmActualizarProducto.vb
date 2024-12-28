Imports MySql.Data.MySqlClient

Public Class frmActualizarProducto

    'Globales de conexion
    Dim conexion As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As MySqlDataAdapter

    'Globales de recibimiento de datos
    Private intervarcodigo As String
    Private intervardescripcion As String
    Private intervarprecio As Single
    Private intervarprecio2 As Single
    Private intervarexistencias As Integer


    Public Sub New(codigo As String, descripcion As String, precio As Single, precio2 As Single, existencias As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        intervarcodigo = codigo
        intervardescripcion = descripcion
        intervarprecio = precio
        intervarPrecio2 = precio2
        intervarexistencias = existencias
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub actualizarProducto(newCodigo As String, newDescripcion As String, newPrecio As Single, newPrecio2 As Single, newExistencias As Integer, oldCodigo As String)
        conexion.ConnectionString = My.Settings.conexion
        conexion.Open()
        Dim tabla As String = "inventario"

        Try

            Dim comando As New MySqlCommand("Update inventario SET codigoProducto = @codigoProducto, producto = @producto, precio = @precio, precio2 = @precio2, existenciasLocal =  @existenciasLocal WHERE codigoProducto = @oldCodigoProducto;", conexion)
            comando.Parameters.AddWithValue("@codigoProducto", newCodigo)
            comando.Parameters.AddWithValue("@producto", newDescripcion)
            comando.Parameters.AddWithValue("@precio", newPrecio)
            comando.Parameters.AddWithValue("@precio2", newPrecio2)
            comando.Parameters.AddWithValue("@existenciasLocal", newExistencias)
            comando.Parameters.AddWithValue("@oldCodigoProducto", oldCodigo)
            
            comando.ExecuteNonQuery()
            conexion.Close()

            MsgBox("Datos actualizados")

            Me.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub


    Private Sub frmActualizarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Igualar variables textbox a las variables que ahora son que heredamos
        txtCodigo.Text = intervarcodigo
        txtDescripcion.Text = intervardescripcion
        txtPrecio.Text = intervarprecio
        txtPrecio2.Text = intervarprecio2
        txtExistencias.Text = intervarexistencias
        txtOldCodigo.Text = intervarcodigo

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'Variables con informacion actualizada
        Dim newCodigo As String = txtCodigo.Text
        Dim newDescripcion As String = txtDescripcion.Text
        Dim newPrecio As Single = txtPrecio.Text
        Dim newPrecio2 As Single = txtPrecio2.Text
        Dim newExistencias As Integer = txtExistencias.Text
        Dim oldCodigo As String = txtOldCodigo.Text

        'Enviando variables con informacion actualizada
        actualizarProducto(newCodigo, newDescripcion, newPrecio, newPrecio2, newExistencias, oldCodigo)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtPrecio.Text = ""
        txtExistencias.Text = ""
        txtOldCodigo.Text = ""
        Me.Close()
    End Sub
End Class