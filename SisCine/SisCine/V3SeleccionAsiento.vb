Public Class V3SeleccionAsiento
    Public codCartelera As Integer
    Public NomPelicula As String


    Public NomCliente As String
    Public ApeCliente As String
    Public Dni As String
    Public AsiTra As Integer
    Public AsiPre As Integer
    Public MontoTotal As Integer

    Private At As Integer
    Private Ap As Integer

    Dim datos As New datosCliente
    Dim funcioneVe As New FunVentas
    Private Sub V3SeleccionAsiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = InterfazPrincipal

        GenerarButon()
        CargarSala()
        lblNompelicula.Text = NomPelicula.ToString
        lblAsiTradiNum.Text = AsiTra.ToString
        lblAsiPrefeNum.Text = AsiPre.ToString

    End Sub

    Public Sub CargarSala()
        Try
            Dim dt As New DataTable
            dt = funcioneVe.CargarSala(codCartelera)
            For i = 0 To dt.Rows.Count - 1


                For Each boton As Object In gbPreferencial.Controls
                    If TypeOf (boton) Is Button Then
                        If dt.Rows(i).Item(0).ToString = boton.Name Then
                            boton.Enabled = False
                            boton.BackColor = Color.Red
                        End If
                    End If
                Next

                For Each boton As Object In gbTradicional.Controls
                    If TypeOf (boton) Is Button Then
                        If dt.Rows(i).Item(0).ToString = boton.Name Then
                            boton.Enabled = False
                            boton.BackColor = Color.Red
                        End If
                    End If
                Next

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub registrarCliente()
        Try
            datos._NomCliente = NomCliente
            datos._ApeCliente = ApeCliente
            datos._DNI = Dni
            datos._AsiPreLi = AsiPre
            datos._AsiTraLi = AsiTra
            datos._Monto = MontoTotal

            If funcioneVe.RegistroCliente(datos, codCartelera) Then

            Else
                MsgBox("Error al Agregar Cliente", MsgBoxStyle.Information, "Mensaje de Sitema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub RegistroAsientoCliente()
        Try
            For Each boton As Object In gbPreferencial.Controls
                If TypeOf (boton) Is Button Then
                    If boton.BackColor = Color.Green Then
                        funcioneVe.RegistroAsientoCliente(codCartelera, boton.Name, funcioneVe.Dar_CodCliente())
                    End If
                End If
            Next

            For Each boton As Object In gbTradicional.Controls
                If TypeOf (boton) Is Button Then
                    If boton.BackColor = Color.Green Then
                        funcioneVe.RegistroAsientoCliente(codCartelera, boton.Name, funcioneVe.Dar_CodCliente())
                    End If
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        registrarCliente()
        RegistroAsientoCliente()
        MsgBox("Registro completo", MsgBoxStyle.Information, "Mensaje del Sistema")
        Me.Close()
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

        AddHandler btn.Click, AddressOf ButtonTradicional_Click
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

        AddHandler btn.Click, AddressOf ButtonPreferencial_Click
        tipo.Controls.Add(btn)
    End Sub
    '================================ EVENTOS DE LOS BOTONES DE ASIENTOS CREADOS ===========================
    Private Sub ButtonTradicional_Click(ByVal sender As Button, ByVal e As EventArgs)
        'Private Sub Button_Click(ByVal sender As Button Object, ByVal e As EventArgs)

        For Each boton In gbTradicional.Controls
            If TypeOf (boton) Is Button Then
                If boton.Name = CType(sender, System.Windows.Forms.Button).Name Then
                    'MsgBox(sender.Text)
                    SeleccionarAsientosTra(sender, AsiTra)
                    Exit For
                End If
            End If
        Next

    End Sub
    Private Sub ButtonPreferencial_Click(ByVal sender As Button, ByVal e As EventArgs)
        'Private Sub Button_Click(ByVal sender As Button Object, ByVal e As EventArgs)

        For Each boton In gbPreferencial.Controls
            If TypeOf (boton) Is Button Then
                If boton.Name = CType(sender, System.Windows.Forms.Button).Name Then
                    'MsgBox(sender.Text)
                    SeleccionarAsientosPre(sender, AsiPre)
                    Exit For
                End If
            End If
        Next

    End Sub
    '================================ SUBPROCESOS DE LOS BOTONES DE ASIENTOS CREADOS ===========================
    Public Sub SeleccionarAsientosTra(ByVal boton As Button, ByVal TotalAsiento As Integer)

        If At < TotalAsiento Then
            If Not boton.BackColor = Color.Green Then
                boton.BackColor = Color.Green
                At += 1
            ElseIf boton.BackColor = Color.Green Then
                boton.BackColor = Color.Transparent
                At -= 1
            End If

        ElseIf At >= TotalAsiento And boton.BackColor = Color.Green Then
            boton.BackColor = Color.Transparent
            At -= 1
        End If
        'If At = TotalAsiento Then
        '    MsgBox("Limite Alcanzado")
        'End If

    End Sub

    Public Sub SeleccionarAsientosPre(ByVal boton As Button, ByVal TotalAsiento As Integer)

        If Ap < TotalAsiento Then
            If Not boton.BackColor = Color.Green Then
                boton.BackColor = Color.Green
                Ap += 1
            ElseIf boton.BackColor = Color.Green Then
                boton.BackColor = Color.Transparent
                Ap -= 1
            End If

        ElseIf Ap >= TotalAsiento And boton.BackColor = Color.Green Then
            boton.BackColor = Color.Transparent
            Ap -= 1
        End If

        'If Ap = TotalAsiento Then
        '    MsgBox("Limite Alcanzado")
        'End If

    End Sub


End Class