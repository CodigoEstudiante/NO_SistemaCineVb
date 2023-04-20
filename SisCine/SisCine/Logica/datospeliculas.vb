Public Class datospeliculas

    Private titulo As String
    Private duracion As String
    Private genero As String
    Private clasificacion As String
    Private formato As String
    Private portada() As Byte

    Public Property _Titulo
        Set(value)
            titulo = value
        End Set
        Get
            Return titulo
        End Get
    End Property
    Public Property _Duracion
        Set(value)

            duracion = value
        End Set
        Get
            Return duracion
        End Get
    End Property
    Public Property _Genero
        Set(value)
            genero = value
        End Set
        Get
            Return genero
        End Get
    End Property
    Public Property _Clasificacion
        Set(value)
            clasificacion = value
        End Set
        Get
            Return clasificacion
        End Get
    End Property
    Public Property _Formato
        Set(value)
            formato = value
        End Set
        Get
            Return formato
        End Get
    End Property
    Public Property _Portada
        Set(value)
            portada = value
        End Set
        Get
            Return portada
        End Get
    End Property
End Class
