Public Class datosCliente

    Private NomCliente As String
    Private ApeCliente As String
    Private DNI As String
    Private AsiTraLi As Integer
    Private AsiPreLi As Integer
    Private Monto As Integer
    Public Property _NomCliente
        Set(value)
            NomCliente = value
        End Set
        Get
            Return NomCliente
        End Get
    End Property

    Public Property _ApeCliente
        Set(value)
            ApeCliente = value
        End Set
        Get
            Return ApeCliente
        End Get
    End Property
    Public Property _DNI
        Set(value)
            DNI = value
        End Set
        Get
            Return DNI
        End Get
    End Property

    Public Property _AsiTraLi
        Set(value)
            AsiTraLi = value
        End Set
        Get
            Return AsiTraLi
        End Get
    End Property
    Public Property _AsiPreLi
        Set(value)
            AsiPreLi = value
        End Set
        Get
            Return AsiPreLi
        End Get
    End Property

    Public Property _Monto
        Set(value)
            Monto = value
        End Set
        Get
            Return Monto
        End Get
    End Property
End Class
