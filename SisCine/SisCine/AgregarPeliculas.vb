Public Class AgregarPeliculas
    Dim dato As New datospeliculas
    Dim funcion As New FunPeliculas

    Private Sub AgregarPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = InterfazPrincipal
        controles_inicio()
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Dim filedialog As New OpenFileDialog
        filedialog.Filter = "Imagenes(*.jpg)|*.jpg|Imagenes(*.png)|*.png"
        filedialog.Title = "Elije la portada de la pelicula"
        If filedialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            picimagen.Image = New Bitmap(filedialog.FileName)
            picimagen.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            Return
        End If
    End Sub
    Public Sub controles_inicio()

        txttitulo.Text = ""
        txtDuracion.Clear()
        cbogenero.SelectedIndex = -1
        cboclasificacion.SelectedIndex = -1
        cboformato.SelectedIndex = -1


        picimagen.Image = Nothing
        gbdatos.Enabled = False
        gbportada.Enabled = False
        btnnuevo.Visible = True
        btnguardar.Visible = False
        btnretornar.Visible = True
        btncancelar.Visible = False
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If Len(Trim(txttitulo.Text)) = 0 Or Len(Trim(txtDuracion.Text)) = 1 Or Not cbogenero.SelectedIndex > -1 Or Not cbogenero.SelectedIndex > -1 Or Not cboformato.SelectedIndex > -1 Or picimagen.Image Is Nothing Then
                MsgBox("Rellene todo los datos porfavor", MsgBoxStyle.Information, "Mensaje del sistema")
                Return
            End If

            dato._Titulo = txttitulo.Text
            dato._Duracion = txtDuracion.Text
            'dato._Duracion = TimeSpan.Parse(txtDuracion.Text)
            dato._Genero = cbogenero.Text
            dato._Clasificacion = cboclasificacion.Text
            dato._Formato = cboformato.Text

            Dim ms As New IO.MemoryStream()
            If Not picimagen Is Nothing Then
                picimagen.Image.Save(ms, picimagen.Image.RawFormat)
            End If

            dato._Portada = ms.GetBuffer
            If funcion.Guardar_Pelicula(dato) Then
                MessageBox.Show("Pelicula agregada con exito")
                controles_inicio()
            Else
                MessageBox.Show("Error al agregar la pelicula")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        gbdatos.Enabled = True
        gbportada.Enabled = True
        btnnuevo.Visible = False
        btnguardar.Visible = True
        btnretornar.Visible = False
        btncancelar.Visible = True
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        controles_inicio()
    End Sub

    Private Sub btnretornar_Click(sender As Object, e As EventArgs) Handles btnretornar.Click
        Me.Close()
    End Sub
End Class