Imports System.Data.SqlClient


Public Class FunPeliculas
    Public Function DetallePelicula(ByVal Cod_Pelicula As Integer) As DataTable
        Try
            conectar()
            Dim tabla As New DataTable
            Dim cmd As New SqlCommand("DetallePelicula", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Cod_Pelicula", Cod_Pelicula)
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(tabla)
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try

    End Function
    Public Sub CargarPeliculasLista(ByVal lbListaPeliculas As Object)
        Try
            conectar()
            Dim table As New DataTable
            Dim sql As String = "select Cod_Pelicula,TituloPelicula from Peliculas"
            Dim adp As New SqlDataAdapter(sql, con)
            adp.Fill(table)

            lbListaPeliculas.DisplayMember = "TituloPelicula"
            lbListaPeliculas.ValueMember = "Cod_Pelicula"
            lbListaPeliculas.DataSource = table

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try

    End Sub

    Public Sub CargarSalaLista(ByVal listasala As Object)
        Try
            conectar()
            Dim table As New DataTable
            Dim sql As String = "select Cod_Sala,NomSala from Sala"
            Dim adp As New SqlDataAdapter(sql, con)
            adp.Fill(table)

            listasala.DisplayMember = "NomSala"
            listasala.ValueMember = "Cod_Sala"
            listasala.DataSource = table

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
    End Sub


    Public Function Guardar_Pelicula(ByVal datos As datospeliculas) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("AgregarPelicula", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@titulo", datos._Titulo)
                .AddWithValue("@duracion", datos._Duracion)
                .AddWithValue("@genero", datos._Genero)
                .AddWithValue("@clasificacion", datos._Clasificacion)
                .AddWithValue("@formato", datos._Formato)
                .AddWithValue("@portada", datos._Portada)
            End With

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function Editar_Pelicula(ByVal cod As Integer, ByVal datos As datospeliculas) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("EditarPelicula", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@cod_Pelicula", cod)
                .AddWithValue("@titulo", datos._Titulo)
                .AddWithValue("@duracion", datos._Duracion)
                .AddWithValue("@genero", datos._Genero)
                .AddWithValue("@clasificacion", datos._Clasificacion)
                .AddWithValue("@formato", datos._Formato)
                .AddWithValue("@portada", datos._Portada)
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

    Public Function Eliminar_Pelicula(ByVal cod As Integer) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("EliminarPelicula", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@cod_pelicula", cod)

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

    Public Function ListaPeliculas() As DataTable
        Try
            conectar()
            Dim tabla As New DataTable
            Dim cmd As New SqlCommand("select TituloPelicula,Duracion,Genero,Clasificacion,Formato from Peliculas", con)
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(tabla)
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function PeliculasPorSala(ByVal codSala As Integer, ByVal cbo As ComboBox) As DataTable
        Try
            conectar()
            Dim tabla As New DataTable
            Dim cmd As New SqlCommand("PeliculasPorSala", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CodSala", codSala)
            Dim adp As New SqlDataAdapter(cmd)


            adp.Fill(tabla)


            cbo.DisplayMember = "TituloPelicula"
            cbo.ValueMember = "Cod_Pelicula"
            cbo.DataSource = tabla
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
End Class
