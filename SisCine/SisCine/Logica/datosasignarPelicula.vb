Public Class datosasignarPelicula
    Private CodPelicula As Integer
    Private CodSala As Integer
    Private HoraInicio As String
    Private HoraFin As String

    Public Property _CodSala
        Set(value)
            CodSala = value
        End Set
        Get
            Return CodSala
        End Get
    End Property

    Public Property _CodPelicula
        Set(value)
            CodPelicula = value
        End Set
        Get
            Return CodPelicula
        End Get
    End Property

    Public Property _HoraInicio
        Set(value)
            HoraInicio = value
        End Set
        Get
            Return HoraInicio
        End Get
    End Property

    Public Property _HoraFin
        Set(value)
            HoraFin = value
        End Set
        Get
            Return HoraFin
        End Get
    End Property
End Class
