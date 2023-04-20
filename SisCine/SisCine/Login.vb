Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim t As String = "SISTEMA DE CINE  "
        Static Dim ti As String = ""
        Static Dim ind As Integer

        If ind = t.Length Then
            ind = 0
            ti = ""
        End If

        For i = ind To t.Length - 1
            ti += t.Substring(i, 1)
            ind += 1
            Exit For
        Next

        Me.Text = ti

    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        If txtusuario.Text <> "" And txtusuario.Text <> "" Then
            If login_Acesso(txtusuario.Text, txtcontraseña.Text) Then
                Me.Hide()
                InterfazPrincipal.Show()
            Else
                MessageBox.Show("Usuario o Contraseña no valido")
            End If
        End If
    End Sub
End Class