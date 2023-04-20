
Public Class MantenimientoPeliculas
    Dim funciones As New FunPeliculas
    Dim Datos As New datospeliculas
    Private Sub MantenimientoPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = InterfazPrincipal
        funciones.CargarPeliculasLista(lbListaPeliculas)
        HabilitarControles(False)
    End Sub
    Public Function Cod_pelicula() As Integer
        Dim Cod As Integer = Convert.ToInt32(lbListaPeliculas.SelectedValue.ToString)
        Return Cod
    End Function

    Private Sub lbListaPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbListaPeliculas.SelectedIndexChanged
        Try


            Dim tabla As New DataTable
            tabla = funciones.DetallePelicula(Cod_pelicula())

            txtTitulo.Text = tabla.Rows(0).Item(0).ToString
            txtDuracion.Text = (tabla.Rows(0).Item(1).ToString).Substring(1)

            'MsgBox(tabla.Rows(0).Item(1).ToString)
            'txtDuracion.Text = tabla.Rows(0).Item(1).ToString

            cboGenero.Text = tabla(0).Item(2).ToString
            cboClasificacion.Text = tabla(0).Item(3).ToString
            cboFormato.Text = tabla(0).Item(4).ToString


            Dim i() As Byte = tabla(0).Item(5)
            Dim ms As New IO.MemoryStream(i)
            PicPortada.Image = Image.FromStream(ms)
            PicPortada.SizeMode = PictureBoxSizeMode.StretchImage

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            HabilitarControles(False)
        End Try
    End Sub

    Public Sub HabilitarControles(ByVal valor As Boolean)
        txtTitulo.Enabled = valor
        txtDuracion.Enabled = valor

        cboClasificacion.Enabled = valor
        cboGenero.Enabled = valor
        cboFormato.Enabled = valor

        btnBuscar.Enabled = valor


        btnEditar.Visible = Not valor
        btnGuardar.Visible = valor

        btnEliminar.Visible = Not valor
        btnCancelar.Visible = valor
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        HabilitarControles(True)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim openfiledialog As New OpenFileDialog

        openfiledialog.Filter = "Imagenes *.jpg|*.jpg|Imagenes *.png|*.png"

        If openfiledialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            PicPortada.Image = New Bitmap(openfiledialog.FileName)
            PicPortada.SizeMode = PictureBoxSizeMode.StretchImage
            'PicPortada.ImageLocation = openfiledialog.FileName
        Else
            Return
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        HabilitarControles(False)
        Try
            If Len(Trim(txtTitulo.Text)) = 0 Or Len(Trim(txtDuracion.Text)) = 1 Or Not cboGenero.SelectedIndex > -1 Or Not cboGenero.SelectedIndex > -1 Or Not cboFormato.SelectedIndex > -1 Or PicPortada.Image Is Nothing Then
                MsgBox("Rellene todo los datos porfavor", MsgBoxStyle.Information, "Mensaje del sistema")
                Return
            End If

            If MsgBox("¿Desea Guardar los Datos Cambiados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then

            Else
                HabilitarControles(False)
                Return
            End If

            Datos._Titulo = txtTitulo.Text
            Datos._Duracion = txtDuracion.Text
            Datos._Genero = cboGenero.Text
            Datos._Clasificacion = cboClasificacion.Text
            Datos._Formato = cboFormato.Text

            Dim ms As New IO.MemoryStream()

            If Not PicPortada.Image Is Nothing Then
                PicPortada.Image.Save(ms, PicPortada.Image.RawFormat)
            End If
            Datos._Portada = ms.GetBuffer

            If funciones.Editar_Pelicula(Cod_pelicula(), Datos) Then
                MsgBox("Detalles Guardados", MsgBoxStyle.Information, "Mensaje del Sistema")
                funciones.CargarPeliculasLista(lbListaPeliculas)
            Else
                MsgBox("Detalles No Guardados", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarControles(False)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MsgBox("¿Desea Eliminar esta Pelicula?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then

        Else
            HabilitarControles(False)
            Return
        End If

        Try
            If funciones.Eliminar_Pelicula(Cod_pelicula()) Then
                MsgBox("Pelicula Eliminada", MsgBoxStyle.Information, "Mensaje del Sistema")
                funciones.CargarPeliculasLista(lbListaPeliculas)
            Else
                MsgBox("Pelicula No Eliminada", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class