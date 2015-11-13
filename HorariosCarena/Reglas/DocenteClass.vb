Public Class DocenteClass

    Dim Id_ As Integer
    Dim Nombres_ As String
    Dim Apellidos_ As String
    Dim Correo_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property Nombres() As String
        Get
            Return Nombres_
        End Get
        Set(ByVal value As String)
            Nombres_ = value
        End Set
    End Property

    Public Property Apellidos() As String
        Get
            Return Apellidos_
        End Get
        Set(ByVal value As String)
            Apellidos_ = value
        End Set
    End Property

    Public Property Correo() As String
        Get
            Return Correo_
        End Get
        Set(ByVal value As String)
            Correo_ = value
        End Set
    End Property

    Public ReadOnly Property NomyApe() As String
        Get
            Return Nombres_ & " " & Apellidos_
        End Get
    End Property
End Class
