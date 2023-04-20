
Imports System.Data.SqlClient
Module BasedelSitema
    Public con As New SqlConnection("Data Source=(local);Initial Catalog=SistemaCine;Integrated Security=True")

    'Public con As New SqlConnection("Data Source=(local);Initial Catalog=SistemaCine;User ID=sa ; Password = 123")

    Public cmd As New SqlCommand
    Public sql As String
    Public adp As New SqlDataAdapter
    Public dt As DataTable

 
    Public Sub conectar()

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub desconectar()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub


    Public Function login_Acesso(ByVal text1 As String, ByVal text2 As String) As Boolean
        'Try
        '    con.Open()
        '    sql = "SELECT * FROM Usuarios WHERE Usuario = @usu AND Contraseña= @con"
        '    cmd = New OleDbCommand(sql, con)
        '    cmd.Parameters.Add(New OleDbParameter("@usu", text1))
        '    cmd.Parameters.Add(New OleDbParameter("@con", text2))
        '    Dim dr As OleDbDataReader
        '    dr = cmd.ExecuteReader
        '    If dr.HasRows Then
        '        dr.Close()
        '        Return True
        '    Else
        '        dr.Close()
        '        Return False
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    Return False
        'Finally
        '    con.Close()
        'End Try
    End Function

End Module
