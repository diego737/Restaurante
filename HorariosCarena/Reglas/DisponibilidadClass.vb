Public Class DisponibilidadClass
    Dim id_ As Integer
    Dim IdDocente_ As Integer
    Dim IdModulo_ As Integer
    Public ReadOnly Property Id() As Integer
        Get
            Return id_



        End Get
    End Property
    Public Property IdDocente() As Integer
        Get
            Return IdDocente_
        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property IdModulo() As Integer
        Get
            Return IdModulo_
        End Get
        Set(ByVal value As Integer)

        End Set
    End Property
End Class
