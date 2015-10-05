Public Class HorarioClass
    Dim Id_ As Integer
    Dim IdCarrera_ As Integer
    Dim IdDia_ As Integer
    Dim IdAsignatura_ As Integer
    Dim IdModulo_ As Integer

    Public ReadOnly Property Id() As Integer
        Get
            Return Id_

        End Get
    End Property
    Public Property IdDia() As Integer
        Get
            Return IdDia_

        End Get
        Set(ByVal value As Integer)

            IdDia_ = value

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

    Public Property IdAsignatura() As Integer
        Get
            Return IdAsignatura_

        End Get
        Set(ByVal value As Integer)

            IdAsignatura_ = value

        End Set
    End Property

    Public Property IdModulo() As Integer
        Get
            Return IdModulo_

        End Get
        Set(ByVal value As Integer)

            IdModulo_ = value

        End Set
    End Property
End Class
