Public Class CarreraClass
    Dim Id_, Curso_ As Integer
    Dim Carrera_ As String

    Public ReadOnly Property Id() As Integer
        Get
            Return Id_
        End Get
    End Property

    Public Property Carrera() As String
        Get
            Return Carrera_
        End Get
        Set(ByVal value As String)
            Carrera_ = value
        End Set
    End Property

    Public Property Curso() As Integer
        Get
            Return Curso_
        End Get
        Set(ByVal value As Integer)
            Curso_ = value
        End Set
    End Property

End Class