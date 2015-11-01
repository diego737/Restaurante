Public Class AsignaturaClass

    Dim Id_ As Integer
    Dim IdCarrera_ As Integer
    Dim Modulos_ As Integer
    Dim Asignados_ As Integer
    Dim IdDocente_ As Integer

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property IdCarrera() As Integer
        Get
            Return IdCarrera_
        End Get
        Set(ByVal value As Integer)
            IdCarrera_ = value
        End Set
    End Property

    Public Property Modulos() As Integer
        Get
            Return Modulos_
        End Get
        Set(ByVal value As Integer)
            Modulos_ = value
        End Set
    End Property

    Public Property Asignados() As Integer
        Get
            Return Asignados_
        End Get
        Set(ByVal value As Integer)
            Asignados_ = value
        End Set
    End Property

    Public Property IdDocente() As Integer
        Get
            Return IdDocente_
        End Get
        Set(ByVal value As Integer)
            IdDocente_ = value
        End Set
    End Property

End Class
