Public Class datosCod
    Public cod_Cartelera As Integer
    Private cod_Cliente As Integer

    Public Property _Cod_Cartelera
        Set(value)
            cod_Cartelera = value
        End Set
        Get
            Return cod_Cartelera
        End Get
    End Property

    Public Property _Cod_Cliente
        Set(value)
            cod_Cliente = value
        End Set
        Get
            Return cod_Cliente
        End Get
    End Property
End Class
