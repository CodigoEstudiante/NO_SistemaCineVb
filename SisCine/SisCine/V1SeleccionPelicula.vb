Public Class V1SeleccionPelicula
    Dim funcionesP As New FunPeliculas
    Dim funventa As New FunVentas
    Dim datos As New datosasignarPelicula
    Public datosCod As New datosCod


    Private Sub V1SeleccionPelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = InterfazPrincipal
        funventa.ListaPeliculas(cboPelicula)
    End Sub
    Public Function Dar_Cod(ByVal cbo As ComboBox) As Integer
        Dim Cod As Integer = Convert.ToInt32(cbo.SelectedValue.ToString)
        Return Cod
    End Function

    Private Sub cboPelicula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPelicula.SelectedIndexChanged
        Try

            Dim tabla As New DataTable
            tabla = funcionesP.DetallePelicula(Dar_Cod(cboPelicula))

            lblDuracion.Text = (tabla.Rows(0).Item(1).ToString).Substring(1)

            lblGenero.Text = tabla(0).Item(2).ToString

            lblClasificacion.Text = tabla(0).Item(3).ToString

            lblFormato.Text = tabla(0).Item(4).ToString


            Dim i() As Byte = tabla(0).Item(5)
            Dim ms As New IO.MemoryStream(i)
            PicPortada.Image = Image.FromStream(ms)
            PicPortada.SizeMode = PictureBoxSizeMode.StretchImage

            funventa.ListaSalas(cboSala, Dar_Cod(cboPelicula))
            DetalleSalida()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboSala_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSala.SelectedIndexChanged
        Try
            Dim tabla As New DataTable

            tabla = funventa.SalaDetalle(Dar_Cod(cboPelicula), Dar_Cod(cboSala))

            cboHora.DisplayMember = "HoraInicio"
            cboHora.DataSource = tabla
            DetalleSalida()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboHora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHora.SelectedIndexChanged
        DetalleSalida()
    End Sub

    Public Sub DetalleSalida()
        Try
            Dim tabla As New DataTable
            datos._CodPelicula = Dar_Cod(cboPelicula)
            datos._CodSala = Dar_Cod(cboSala)
            datos._HoraInicio = cboHora.Text
            tabla = funventa.DetalleSalida(datos)

            lblAP.Text = tabla.Rows(0).Item(0).ToString
            lblAT.Text = tabla.Rows(0).Item(1).ToString

            datosCod._Cod_Cartelera = Convert.ToInt32(tabla.Rows(0).Item(2).ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Try
            V2DatosCliente.Show()
            V2DatosCliente.cod_cartelera = Convert.ToInt32(datosCod._Cod_Cartelera.ToString)
            V2DatosCliente.mpex = Convert.ToInt32(lblAP.Text)
            V2DatosCliente.mtex = Convert.ToInt32(lblAT.Text)
            V2DatosCliente.NomPelicula = cboPelicula.Text
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class