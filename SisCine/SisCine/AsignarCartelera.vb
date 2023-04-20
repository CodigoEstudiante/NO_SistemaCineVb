Public Class AsignarCartelera
    Dim dato As New datosasignarPelicula
    Dim funcionesAsignar As New FunAsignarPelicula
    Dim funciones As New FunPeliculas
    Private Sub AsignarCartelera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = InterfazPrincipal
        funciones.CargarPeliculasLista(cboPelicula)
        funciones.CargarSalaLista(cboSala)
        ControlesIniciales()
        dgvListaCartelera.DataSource = funcionesAsignar.ListaCartelera()
    End Sub
    Public Sub ControlesIniciales()
        btnValidar.BackColor = Color.Transparent
        gbdatos.Enabled = False
        btnNuevo.Visible = True

        btnGuardar.Visible = False
        btnGuardar.Enabled = False

        btnCancelar.Enabled = False

        txthora.Clear()
        txtminuto.Clear()
        txtHoraFin.Clear()
    End Sub
    Public Function Cod_pelicula(ByVal ComboCod As Object) As Integer
        Dim Cod As Integer = Convert.ToInt32(ComboCod.SelectedValue.ToString)
        Return Cod
    End Function
   
    Private Sub cboPelicula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPelicula.SelectedIndexChanged
        Try

            Dim tabla As New DataTable
            tabla = funciones.DetallePelicula(Cod_pelicula(cboPelicula))
            txtDuracion.Text = (tabla.Rows(0).Item(1).ToString).Substring(1)
            Dim i() As Byte = tabla(0).Item(5)
            Dim ms As New IO.MemoryStream(i)
            picPortada.Image = Image.FromStream(ms)
            picPortada.SizeMode = PictureBoxSizeMode.StretchImage

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'HabilitarControles(False)
        End Try
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Try

            If Trim(txtDuracion.Text) = "" Or Trim(txthora.Text) = "" Or Trim(txtminuto.Text) = "" Or Trim(txtHoraFin.Text) = "" Then
                MsgBox("Verifique que las horas Sean válidas", MsgBoxStyle.Information, "Mensaje del Sistema")
                Return
            End If

            dato._CodSala = Cod_pelicula(cboSala)
            dato._HoraInicio = (txthora.Text & ":" & txtminuto.Text)
            dato._HoraFin = txtHoraFin.Text
            If funcionesAsignar.ValidarCartelera(dato) Then
                MsgBox("Hora Correcta", MsgBoxStyle.Information, "Mensaje del Sistema")
                btnGuardar.Enabled = True
            Else
                MsgBox("La hora se cruza con otra, Porfavor cambie la Hora de Inicio", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                btnGuardar.Enabled = False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Public Function PermisoGenerar() As Boolean
        If Trim(txthora.Text) <> "" And Trim(txtminuto.Text) <> "" Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub GenerarHoraFinal()
        'SACAMOS LA HORA Y LOS MINUTOS DE LA HORA DURACION
        Dim i, hd, md As Integer

        i = InStr(txtDuracion.Text, ":")
        hd = Convert.ToInt32(txtDuracion.Text.Substring(0, i - 1))
        md = Convert.ToInt32(txtDuracion.Text.Substring(i, 2))

        'SACAMOS LA HORA Y LOS MINUTOS DE LA HORA INICIAL
        Dim hi, mi As Integer

        hi = Convert.ToInt32(txthora.Text)
        mi = Convert.ToInt32(txtminuto.Text)

        'CREAMOS LA HORA FINAL
        Dim mtexto As String
        Dim he As Integer
        Dim Minutos, hf, mf As Integer

        Minutos = (md + mi) + 30

        If (hd + hi) > 23 Then
            MsgBox("Error de hora, escoga otra porfavor", MsgBoxStyle.Information, "Mensaje del Sistema")
            txtHoraFin.Clear()
            Exit Sub
        End If

        If Minutos < 60 Then
            hf = hd + hi
            mf = Minutos
        Else
            he = Minutos / 60

            hf = hd + hi + he
            mf = Minutos Mod 60
        End If

        If hf > 23 Then
            MsgBox("Error de hora, escoga otra porfavor", MsgBoxStyle.Information, "Mensaje del Sistema")
            txtHoraFin.Clear()
            Exit Sub
        End If

        If mf < 10 Then
            mtexto = "0" & Convert.ToString(mf)
        Else
            mtexto = Convert.ToInt32(mf)
        End If

        txtHoraFin.Text = Convert.ToInt32(hf) & ":" & mtexto
    End Sub

    Private Sub txthora_TextChanged(sender As Object, e As EventArgs) Handles txthora.TextChanged
        If PermisoGenerar() Then
            GenerarHoraFinal()
            btnValidar.BackColor = Color.Green
            btnGuardar.Enabled = False
        Else
            txtHoraFin.Clear()
        End If
    End Sub

    Private Sub txtminuto_TextChanged(sender As Object, e As EventArgs) Handles txtminuto.TextChanged
        If PermisoGenerar() Then
            GenerarHoraFinal()
            btnValidar.BackColor = Color.Green
        Else
            txtHoraFin.Clear()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ControlesIniciales()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Visible = False
        btnGuardar.Visible = True
        btnCancelar.Enabled = True
        gbdatos.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If Trim(txtDuracion.Text) = "" Or Trim(txthora.Text) = "" Or Trim(txtminuto.Text) = "" Or Trim(txtHoraFin.Text) = "" Then
                MsgBox("Verifique que las horas Sean válidas", MsgBoxStyle.Information, "Mensaje del Sistema")
                Return
            End If

            dato._CodSala = Cod_pelicula(cboSala)
            dato._CodPelicula = Cod_pelicula(cboPelicula)
            dato._HoraInicio = (txthora.Text & ":" & txtminuto.Text)
            dato._HoraFin = txtHoraFin.Text

            If funcionesAsignar.AgregarCartelera(dato) Then
                MsgBox("Datos Agregados Correctamente", MsgBoxStyle.Information, "Mensaje del Sistema")
                dgvListaCartelera.DataSource = funcionesAsignar.ListaCartelera()
                ControlesIniciales()
            Else
                MsgBox("Datos No Agregados Correctamente", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                dgvListaCartelera.DataSource = funcionesAsignar.ListaCartelera()
                ControlesIniciales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim cod As Integer = Val(txtCod.Text)
        If funcionesAsignar.EliminarCartelera(cod) Then
            MsgBox("Cartelera Eliminada Exitosamente", MsgBoxStyle.Information, "Mensaje del Sistema")
            dgvListaCartelera.DataSource = funcionesAsignar.ListaCartelera()
        Else
            MsgBox("Cartelera No Eliminada", MsgBoxStyle.Information, "Mensaje del Sistema")
            dgvListaCartelera.DataSource = funcionesAsignar.ListaCartelera()
        End If
    End Sub

    Private Sub cboSala_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSala.SelectedIndexChanged

    End Sub
End Class