Public Class ModuloClass
    Dim Id_ As Integer
    Dim IdDia_ As Integer
    Dim Inicio_ As Integer
    Dim Fin_ As Integer

    Public Property Id() As Integer

        Get
            Return Id_

        End Get
        Set(ByVal value As Integer)

            Id_ = value

        End Set
    End Property

    Public Property IdDia() As Integer
        Get
            Return IdDia_

        End Get
        Set(ByVal value As Integer)

            IdDia_ = value

        End Set
    End Property

    Public Property inicio() As Integer
        Get
            Return Inicio_

        End Get
        Set(ByVal value As Integer)

            Inicio_ = value

        End Set
    End Property

    Public Property fin() As Integer
        Get
            Return Fin_

        End Get
        Set(ByVal value As Integer)

            Fin_ = value

        End Set
    End Property
End Class
