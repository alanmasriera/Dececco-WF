Public Class ClaseHora

    'variables
    Dim decHoraNormal As Decimal = 0
    Dim decHora50 As Decimal = 0
    Dim decHora100 As Decimal = 0
    Dim decHoraNocturna As Decimal = 0
    Dim decHoraEnfermedad As Decimal = 0
    Dim decHoraAccidente As Decimal = 0
    Dim decHoraFeriado As Decimal = 0
    ' Dim decHoraFeriadoTrabajado As Decimal = 0
    Dim decHoraNoTrabajada As Decimal = 0
    Dim decHoraViaje As Decimal = 0
    Dim decHoraViaje50 As Decimal = 0
    Dim decHoraViaje100 As Decimal = 0
    Dim decHoraAdministrativo As Decimal = 0

    'propiedades
    Private _HoraNormal As Decimal
    Public Property HoraNormal() As Decimal
        Get
            _HoraNormal = decHoraNormal
            Return _HoraNormal
        End Get
        Set(ByVal Value As Decimal)
            decHoraNormal = Value
        End Set
    End Property

    Private _Hora50 As Decimal
    Public Property Hora50() As Decimal
        Get
            _Hora50 = decHora50
            Return _Hora50
        End Get
        Set(ByVal Value As Decimal)
            decHora50 = Value
        End Set
    End Property

    Private _Hora100 As Decimal
    Public Property Hora100() As Decimal
        Get
            _Hora100 = decHora100
            Return _Hora100
        End Get
        Set(ByVal Value As Decimal)
            decHora100 = Value
        End Set
    End Property

    Private _HoraNocturna As Decimal
    Public Property HoraNocturna() As Decimal
        Get
            _HoraNocturna = decHoraNocturna
            Return _HoraNocturna
        End Get
        Set(ByVal Value As Decimal)
            decHoraNocturna = Value
        End Set
    End Property

    Private _HoraEnfermedad As Decimal
    Public Property HoraEnfermedad() As Decimal
        Get
            _HoraEnfermedad = decHoraEnfermedad
            Return _HoraEnfermedad
        End Get
        Set(ByVal Value As Decimal)
            decHoraEnfermedad = Value
        End Set
    End Property

    Private _HoraAccidente As Decimal
    Public Property HoraAccidente() As Decimal
        Get
            _HoraAccidente = decHoraAccidente
            Return _HoraAccidente
        End Get
        Set(ByVal Value As Decimal)
            decHoraAccidente = Value
        End Set
    End Property

    Private _HoraFeriado As Decimal
    Public Property HoraFeriado() As Decimal
        Get
            _HoraFeriado = decHoraFeriado
            Return _HoraFeriado
        End Get
        Set(ByVal Value As Decimal)
            decHoraFeriado = Value
        End Set
    End Property

    'Private _HoraFeriadoTrabajado As Decimal
    'Public Property HoraFeriadoTrabajado() As Decimal
    '    Get
    '        _HoraFeriadoTrabajado = decHoraFeriadoTrabajado
    '        Return _HoraFeriadoTrabajado
    '    End Get
    '    Set(ByVal Value As Decimal)
    '        decHoraFeriadoTrabajado = Value
    '    End Set
    'End Property

    Private _HoraNoTrabajada As Decimal
    Public Property HoraNoTrabajada() As Decimal
        Get
            _HoraNoTrabajada = decHoraNoTrabajada
            Return _HoraNoTrabajada
        End Get
        Set(ByVal Value As Decimal)
            decHoraNoTrabajada = Value
        End Set
    End Property

    Private _HoraViaje As Decimal
    Public Property HoraViaje() As Decimal
        Get
            _HoraViaje = decHoraViaje
            Return _HoraViaje
        End Get
        Set(ByVal Value As Decimal)
            decHoraViaje = Value
        End Set
    End Property

    Private _HoraViaje50 As Decimal
    Public Property HoraViaje50() As Decimal
        Get
            _HoraViaje50 = decHoraViaje50
            Return _HoraViaje50
        End Get
        Set(ByVal Value As Decimal)
            decHoraViaje50 = Value
        End Set
    End Property

    Private _HoraViaje100 As Decimal
    Public Property HoraViaje100() As Decimal
        Get
            _HoraViaje100 = decHoraViaje100
            Return _HoraViaje100
        End Get
        Set(ByVal Value As Decimal)
            decHoraViaje100 = Value
        End Set
    End Property

    Private _HoraAdministrativo As Decimal
    Public Property HoraAdministrativo() As Decimal
        Get
            _HoraAdministrativo = decHoraAdministrativo
            Return _HoraAdministrativo
        End Get
        Set(ByVal Value As Decimal)
            decHoraAdministrativo = Value
        End Set
    End Property
End Class
