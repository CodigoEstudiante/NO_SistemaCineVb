Imports System.Data.SqlClient
Public Class FunAsignarPelicula
    Public Function ValidarCartelera(ByVal datos As datosasignarPelicula) As Boolean
        Try
            conectar()
            Dim permitir As Boolean = True
          
            Dim dt As New DataTable
            Dim adp As New SqlDataAdapter("select Cod_Sala,HotaFin,HoraInicio from Cartelera", con)
            adp.Fill(dt)

            If dt.Rows.Count < 1 Then
                Return True
                Exit Function
            Else
                For i = 0 To dt.Rows.Count - 1
                    If Convert.ToInt32(dt.Rows(i).Item(0)) = datos._CodSala Then
                        'MsgBox(dt.Rows(i).Item(1).ToString)
                        If Convert.ToDateTime(datos._HoraInicio) > Convert.ToDateTime(dt.Rows(i).Item(1).ToString) Then
                            permitir = True
                        ElseIf Convert.ToDateTime(datos._HoraFin) < Convert.ToDateTime(dt.Rows(i).Item(2).ToString) Then
                            permitir = True
                        Else
                            permitir = False
                            Exit For

                        End If
                    End If
                Next
            End If


            If permitir Then
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

    Public Function AgregarCartelera(ByVal datos As datosasignarPelicula) As Boolean
        Try
            conectar()

            Dim cmd As New SqlCommand("AgregarCartelera", con)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("@Cod_Sala", datos._CodSala)
                .AddWithValue("@Cod_Pelicula", datos._CodPelicula)
                .AddWithValue("@horainicio", datos._HoraInicio)
                .AddWithValue("@HoraFin", datos._HoraFin)
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

    Public Function ListaCartelera() As DataTable
        Try
            conectar()
            Dim cmd As New SqlCommand("ListaDetalleCartelera", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adp As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adp.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try

    End Function

    Public Function EliminarCartelera(ByVal cod As Integer) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("Delete from Cartelera where Cod_Cartelera = " & Str(cod), con)

            If MsgBox("¿Desea Eliminar la Cartelera?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje Del sistema") = MsgBoxResult.No Then

                Return Nothing
                Exit Function
            End If

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
End Class
