Public Class InterfazPrincipal


    Private Sub IntefazPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BasedelSitema.conectar()
    End Sub

    Private Sub AgregarPeliculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPeliculaToolStripMenuItem.Click
        AgregarPeliculas.Show()
    End Sub


    Private Sub VerTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTodasToolStripMenuItem.Click
        ListaPeliculas.Show()
    End Sub

    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click
        MantenimientoPeliculas.Show()
    End Sub

    Private Sub AsignarCateleraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarCateleraToolStripMenuItem.Click
        AsignarCartelera.Show()
    End Sub

    Private Sub ComprarBoletoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprarBoletoToolStripMenuItem.Click
        V1SeleccionPelicula.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir del Sistema?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub VerSala1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerSala1ToolStripMenuItem.Click
        VistaSala.codsala = 1
        VistaSala.Show()

    End Sub

    Private Sub VerSala2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerSala2ToolStripMenuItem.Click
        VistaSala.codsala = 2

        VistaSala.Show()

    End Sub
End Class
