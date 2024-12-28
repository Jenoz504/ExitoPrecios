Public Class FrmModificar
    Private precio1 As Single
    Private precio2 As Single


    Private Shadows Sub enter()
        precio1 = txtPrecio1.Text
        precio2 = txtprecio2.Text
        Me.Close()
    End Sub
    Public Sub New(prmtprecio1 As Single, prmtPrecio2 As Single)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        precio1 = prmtprecio1
        precio2 = prmtPrecio2
    End Sub

    Private Sub frmModificarFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPrecio1.Text = precio1
        txtprecio2.Text = precio2
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        precio1 = txtPrecio1.Text
        precio2 = txtprecio2.Text
        Me.Close()
    End Sub

    Private Sub frmModificarFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            enter()
        End If

    End Sub

    Private Sub txtprecio1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecio1.KeyDown
        If e.KeyCode = Keys.Enter Then
            enter()
        End If
    End Sub
End Class