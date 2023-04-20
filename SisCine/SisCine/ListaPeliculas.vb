Public Class ListaPeliculas
    Dim fun As New FunPeliculas
    Private Sub ListaPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = InterfazPrincipal
        dgvPeliculas.DataSource = fun.ListaPeliculas()
    End Sub
End Class