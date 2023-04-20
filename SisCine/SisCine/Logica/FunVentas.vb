Imports System.Data.SqlClient
Public Class FunVentas
    Public Sub ListaPeliculas(ByVal cbo As ComboBox)
        Try
            conectar()
            Dim cmd As New SqlCommand("ListaPelicula", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adp As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            adp.Fill(tabla)

            cbo.DisplayMember = "TituloPelicula"
            cbo.ValueMember = "Cod_Pelicula"
            cbo.DataSource = tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
    End Sub

    Public Sub ListaSalas(ByVal cbo As ComboBox, ByVal cod As Integer)
        Try
            conectar()
            Dim cmd As New SqlCommand("ListaSala", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CodPelicula", cod)
            Dim adp As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            adp.Fill(tabla)

            cbo.DisplayMember = "NomSala"
            cbo.ValueMember = "Cod_Sala"
            cbo.DataSource = tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
    End Sub

    Public Function SalaDetalle(ByVal codPelicula As Integer, ByVal codSala As Integer) As DataTable
        Try
            conectar()
            Dim cmd As New SqlCommand("SalaDetalle", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Cod_Pelicula", codPelicula)
            cmd.Parameters.AddWithValue("@Cod_Sala", codSala)
            Dim adp As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            If cmd.ExecuteNonQuery Then
                adp.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function DetalleSalida(ByVal datos As datosasignarPelicula) As DataTable
        Try
            conectar()
            Dim cmd As New SqlCommand("DetalleSalida", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Cod_Pelicula", datos._CodPelicula)
            cmd.Parameters.AddWithValue("@Cod_Sala", datos._CodSala)
            cmd.Parameters.AddWithValue("@HoraInicio", datos._HoraInicio)
            Dim adp As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            If cmd.ExecuteNonQuery Then
                adp.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function Dar_CodCliente() As Integer

        Try
            Dim codCliente As Integer
            conectar()
            Dim cmd As New SqlCommand("SELECT TOP 1 Cod_Cliente FROM Cliente ORDER BY Cod_Cliente DESC", con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            adp.Fill(tabla)
            codCliente = Convert.ToInt32(tabla.Rows(0).Item(0).ToString)
            Return codCliente
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function RegistroCliente(ByVal datos As datosCliente, ByVal cod As Integer) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("RegistroCliente", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@CodCartelera", cod)
                .AddWithValue("@NombreCl", datos._NomCliente)
                .AddWithValue("@ApellidoCl", datos._ApeCliente)
                .AddWithValue("@DNI", datos._DNI)
                .AddWithValue("@AsiTradicional", datos._AsiTraLi)
                .AddWithValue("@AsiPreferencial", datos._AsiPreLi)
                .AddWithValue("@MontoTotal", datos._Monto)
            End With

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function
    Public Sub RegistroAsientoCliente(ByVal codCartelera As Integer, ByVal numero As String, ByVal codCliente As Integer)
        Try
            conectar()
            Dim cmd As New SqlCommand("RegistroAsientoCliente", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@CodCartelera", codCartelera)
                .AddWithValue("@Numero", numero)
                .AddWithValue("@CodCliente", codCliente)
            End With

            If cmd.ExecuteNonQuery Then

            Else
                MsgBox("Error al guardar")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectar()
        End Try

    End Sub

    Public Function CargarSala(ByVal codCartelera As Integer) As DataTable
        Try
            conectar()
            Dim cmd As New SqlCommand("CargarSala", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@CodCartelera", codCartelera)
            End With

            If cmd.ExecuteNonQuery Then
                Dim adp As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                adp.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try

    End Function
End Class
