Public Class ModuloClass
    Dim Id_ As Integer
    Dim IdDia_ As Integer
    Dim dia_ As String
    Dim dia_inicio_ As String
    Dim Inicio_ As String
    Dim Fin_ As String

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

    Public Property Inicio() As String
        Get
            Return Inicio_

        End Get
        Set(ByVal value As String)

            Inicio_ = value

        End Set
    End Property

    Public Property Fin() As String
        Get
            Return Fin_

        End Get
        Set(ByVal value As String)

            Fin_ = value

        End Set
    End Property

    Public Property Dia() As String
        Get

            Return dia_

        End Get

        Set(ByVal value As String)

            dia_ = value

        End Set
    End Property

    Public ReadOnly Property Dia_Inicio() As String
        Get
            Return dia_ + " " + Inicio_
        End Get
    End Property
End Class
