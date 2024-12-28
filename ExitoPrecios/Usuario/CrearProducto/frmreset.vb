Public Class frmreset
    Dim formulario As Form
    Public Sub New(_formulario As Form)
        InitializeComponent()
        formulario = _formulario
        formulario.Show()
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub

    Private Sub frmreset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class