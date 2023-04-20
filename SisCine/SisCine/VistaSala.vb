Public Class VistaSala
    Public codsala As Integer

    Dim funciones As New FunPeliculas
    Dim funventas As New FunVentas
    Dim funAsignar As New FunAsignarPelicula
    Dim datos As New datosasignarPelicula

    Dim codCartelera As Integer
    Dim tabla As New DataTable
    Private Sub VistaSala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = InterfazPrincipal

        peliculasporsala()
        GenerarButon()
        btnVaciarSala.Enabled = False
    End Sub
    Public Function DarCodPelicula() As Integer
        Try
            Dim i As Integer = Convert.ToInt32(cboPeliculas.SelectedValue.ToString)
            Return i
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub peliculasporsala()
        Try
            tabla = funciones.PeliculasPorSala(codsala, cboPeliculas)
            For i = 0 To tabla.rows.count - 1
                If Convert.ToInt32(tabla.Rows(i).Item(1).ToString) = DarCodPelicula() Then
                    lblHora.Text = tabla.Rows(i).Item(2).ToString
                End If
            Next

        Catch ex As exception
            msgbox(ex.message)
        End Try
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        CargarSala()
        btnVer.BackColor = Color.Transparent
        btnVaciarSala.Enabled = True
    End Sub

    Private Sub cboPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeliculas.SelectedIndexChanged
        Try

            For i = 0 To tabla.Rows.Count - 1
                If Convert.ToInt32(tabla.Rows(i).Item(1).ToString) = DarCodPelicula() Then
                    lblHora.Text = tabla.Rows(i).Item(2).ToString
                End If
            Next

            btnVer.BackColor = Color.Green
            btnVaciarSala.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function DarCodCartelera() As Integer
        Try
            datos._CodSala = codsala
            datos._CodPelicula = DarCodPelicula()
            datos._HoraInicio = lblHora.Text
            Dim tabla As New DataTable
            tabla = funventas.DetalleSalida(datos)
            codCartelera = Convert.ToInt32(tabla.Rows(0).Item(2).ToString)
            Return codCartelera
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Sub CargarSala()
        Try
            Dim dt As New DataTable
            dt = funventas.CargarSala(DarCodCartelera())



            For Each boton As Object In gbPreferencial.Controls
                If TypeOf (boton) Is Button Then
                    boton.BackColor = Color.Transparent
                End If
            Next

            For Each boton As Object In gbTradicional.Controls
                If TypeOf (boton) Is Button Then
                    boton.BackColor = Color.Transparent
                End If
            Next






            For i = 0 To dt.Rows.Count - 1


                For Each boton As Object In gbPreferencial.Controls
                    If TypeOf (boton) Is Button Then
                        If dt.Rows(i).Item(0).ToString = boton.Name Then
                            boton.BackColor = Color.Red
                        End If
                    End If
                Next

                For Each boton As Object In gbTradicional.Controls
                    If TypeOf (boton) Is Button Then
                        If dt.Rows(i).Item(0).ToString = boton.Name Then
                            boton.BackColor = Color.Red         
                        End If
                    End If
                Next

            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GenerarButon()
        Dim b As Integer = 1
        Dim extraf As Integer = 0
        Dim extrac As Integer = 0

        For x = 0 To 270 Step 30
            If x > (250 / 2) Then
                extrac = 20
            End If

            For i = 0 To 120 Step 30
                Detalle_buttonTradicional(("T" & b.ToString), x + extrac, i, gbTradicional)
                Detalle_buttonPreferencial(("P" & b.ToString), x + extrac, i, gbPreferencial)
                b += 1
            Next
        Next
    End Sub
    '================================ DETALLE DE LOS BOTONES DE ASIENTOS POR CREAR ===========================
    Private Sub Detalle_buttonTradicional(ByVal nombre As String, ByVal x As Integer, ByVal y As Integer, tipo As Object)
        Dim btn As New Button
        Dim la As New Label

        With btn
            .Name = "btn" & nombre
            .Text = nombre
            .Location = New System.Drawing.Point(x, y)
            .Size = New System.Drawing.Size(30, 25)
        End With

        'AddHandler btn.Click, AddressOf ButtonTradicional_Click
        tipo.Controls.Add(btn)
    End Sub
    Private Sub Detalle_buttonPreferencial(ByVal nombre As String, ByVal x As Integer, ByVal y As Integer, tipo As Object)
        Dim btn As New Button
        Dim la As New Label

        With btn
            .Name = "btn" & nombre
            .Text = nombre
            .Location = New System.Drawing.Point(x, y)
            .Size = New System.Drawing.Size(30, 25)
        End With

        'AddHandler btn.Click, AddressOf ButtonPreferencial_Click
        tipo.Controls.Add(btn)
    End Sub

    Private Sub btnVaciarSala_Click(sender As Object, e As EventArgs) Handles btnVaciarSala.Click


        If funAsignar.EliminarCartelera(codCartelera) Then
            MsgBox("Cartelera Eliminada Exitosamente", MsgBoxStyle.Information, "Mensaje del Sistema")
            Me.Close()
        Else
            MsgBox("Cartelera No Eliminada", MsgBoxStyle.Information, "Mensaje del Sistema")

        End If
    End Sub
End Class