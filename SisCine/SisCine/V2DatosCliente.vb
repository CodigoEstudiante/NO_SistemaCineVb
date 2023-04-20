Public Class V2DatosCliente
    Public cod_cartelera As Integer
    Public NomPelicula As String
    Public mpex As Integer
    Public mtex As Integer
    Private tap As Integer
    Private tat As Integer
    Dim datosCod As datosCod
    Private Sub V2DatosCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = InterfazPrincipal
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
      
        If validarPreferecial() = False Then
            MsgBox("Asiento Preferencial Excedidos, Ingrese de Nuevo", MsgBoxStyle.Information, "Mensaje del Sistema")
            txtmp1.Text = ""
            txtmp2.Text = ""
            txtmp3.Text = ""
        ElseIf validarTradicional() = False Then
            MsgBox("Asiento Tradicional Excedidos, Ingrese de Nuevo", MsgBoxStyle.Information, "Mensaje del Sistema")
            txtmt1.Text = ""
            txtmt2.Text = ""
            txtmt3.Text = ""
        Else
            If Trim(txtNombre.Text) = "" Or Trim(txtApellido.Text) = "" Or Trim(txtDni.Text) = "" Then
                MsgBox("Faltan Completar Datos del Cliente", MsgBoxStyle.Information, "Mensaje del Sitema")
                Return
            End If

            If tap = 0 And tat = 0 Then
                MsgBox("No hay Asientos Seleccionados", MsgBoxStyle.Information, "Mensaje del Sitema")
                Return
            End If

            MsgBox("Correcto")
            V3SeleccionAsiento.codCartelera = Me.cod_cartelera
            V3SeleccionAsiento.NomCliente = txtNombre.Text
            V3SeleccionAsiento.ApeCliente = txtApellido.Text
            V3SeleccionAsiento.Dni = txtDni.Text
            V3SeleccionAsiento.AsiPre = tap
            V3SeleccionAsiento.AsiTra = tat
            V3SeleccionAsiento.MontoTotal = SumaMonto()
            V3SeleccionAsiento.NomPelicula = NomPelicula
            Me.Close()
            V3SeleccionAsiento.Show()
        End If
    End Sub

    Public Function SumaSubMonto(ByVal d1 As String, ByVal d2 As String) As Integer
        Dim valor, v1, v2 As Integer
        If Trim(d1) = "" Then
            Return 0
        End If

        Try
            v1 = Convert.ToInt32(d1)
            v2 = Convert.ToInt32(d2)
            valor = v1 * v2
            Return valor
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    Public Function SumaMonto() As Integer
        Dim d1, d2, d3, d4, d5, d6 As String
        d1 = lblmps1.Text
        d2 = lblmps2.Text
        d3 = lblmps3.Text

        d4 = lblmts1.Text
        d5 = lblmts2.Text
        d6 = lblmts3.Text

        Dim v1, v2, v3, v4, v5, v6, vt As Integer
        v1 = Val(d1)
        v2 = Val(d2)
        v3 = Val(d3)
        v4 = Val(d4)
        v5 = Val(d5)
        v6 = Val(d6)

        vt = v1 + v2 + v3 + v4 + v5 + v6
        Return vt
    End Function
    Public Function validarPreferecial() As Boolean
        Try
            Dim d1, d2, d3 As String
            d1 = Trim(txtmp1.Text)
            d2 = Trim(txtmp2.Text)
            d3 = Trim(txtmp3.Text)
            Dim v1, v2, v3, vt As Integer

            If IsNumeric(d1) Then
                v1 = Convert.ToInt32(d1)
            Else
                v1 = 0
            End If

            If IsNumeric(d2) Then
                v2 = Convert.ToInt32(d2)
            Else
                v2 = 0
            End If

            If IsNumeric(d3) Then
                v3 = Convert.ToInt32(d3)
            Else
                v3 = 0
            End If

            vt = v1 + v2 + v3


            If vt < mpex Then
                tap = vt
                Return True
            Else
                tap = vt
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
       
    End Function
    Public Function validarTradicional() As Boolean
        Try
            Dim d1, d2, d3 As String
            d1 = Trim(txtmt1.Text)
            d2 = Trim(txtmt2.Text)
            d3 = Trim(txtmt3.Text)
            Dim v1, v2, v3, vt As Integer

            If IsNumeric(d1) Then
                v1 = Convert.ToInt32(d1)
            Else
                v1 = 0
            End If

            If IsNumeric(d2) Then
                v2 = Convert.ToInt32(d2)
            Else
                v2 = 0
            End If

            If IsNumeric(d3) Then
                v3 = Convert.ToInt32(d3)
            Else
                v3 = 0
            End If

            vt = v1 + v2 + v3


            If vt < mtex Then
                tat = vt
                Return True
            Else
                tat = vt
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function
    Private Sub txtmp1_TextChanged(sender As Object, e As EventArgs) Handles txtmp1.TextChanged
     

        lblmps1.Text = SumaSubMonto(txtmp1.Text, lblmp1.Text)
        txtTotal.Text = FormatNumber(SumaMonto())
    End Sub

    Private Sub txtmp2_TextChanged(sender As Object, e As EventArgs) Handles txtmp2.TextChanged
    
        lblmps2.Text = SumaSubMonto(txtmp2.Text, lblmp2.Text)
        txtTotal.Text = FormatNumber(SumaMonto())
    End Sub

    Private Sub txtmp3_TextChanged(sender As Object, e As EventArgs) Handles txtmp3.TextChanged
       
        lblmps3.Text = SumaSubMonto(txtmp3.Text, lblmp3.Text)
        txtTotal.Text = FormatNumber(SumaMonto())
    End Sub



    Private Sub txtmt1_TextChanged(sender As Object, e As EventArgs) Handles txtmt1.TextChanged
        lblmts1.Text = SumaSubMonto(txtmt1.Text, lblmt1.Text)
        txtTotal.Text = FormatNumber(SumaMonto())
    End Sub

    Private Sub txtmt2_TextChanged(sender As Object, e As EventArgs) Handles txtmt2.TextChanged
        lblmts2.Text = SumaSubMonto(txtmt2.Text, lblmt2.Text)
        txtTotal.Text = FormatNumber(SumaMonto())
    End Sub

    Private Sub txtmt3_TextChanged(sender As Object, e As EventArgs) Handles txtmt3.TextChanged
        lblmts3.Text = SumaSubMonto(txtmt3.Text, lblmt3.Text)
        txtTotal.Text = FormatNumber(SumaMonto())
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        V1SeleccionPelicula.Show()
    End Sub
End Class