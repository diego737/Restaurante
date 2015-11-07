Public Class CarreraClass
    Dim id_ As Integer
    Dim carrera_ As String

    Public Property id() As Integer

        Get
            Return id_

        End Get
        Set(ByVal value As Integer)
            id_ = value

        End Set
    End Property

    Public Property carrera() As String

        Get
            Return carrera_

        End Get
        Set(ByVal value As String)
            carrera_ = value

        End Set
    End Property

End Class
