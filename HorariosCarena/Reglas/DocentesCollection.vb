Imports System.ComponentModel
Imports System.Text

Public Class DocentesCollection

    Inherits BindingList(Of DocenteClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New DocenteClass 'DocenteCollection ?
    End Sub
    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each docente In Me
            If prop.GetValue(docente).Equals(key) Then
                Return Me.IndexOf(docente)
            End If
        Next

        Return -1
    End Function

    'Este método se ejecuta cuando se crea el objeto.
    'Es el método constructor de la clase.
    Public Sub New()
        'Llena la instancia del objeto list con datos provenientes de Docentes.
        Me.TraerDocentes()

    End Sub

    Public Function TraerDocentes() As DocentesCollection
        'Instancio el el Objeto BaseDatosClass para acceder al la base docentes.
        Dim objBaseDatos As New BaseDatosClass
     
        'Instancio un DataTable
        Dim MiDataTable As New DataTable

        Dim Midocente As DocenteClass

        objBaseDatos.objTabla = "docentes"
        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            Midocente = New DocenteClass

            Midocente.Id = CInt(dr("Id"))
            Midocente.Apellidos = CStr(dr("Apellidos"))
            Midocente.Nombres = CStr(dr("Nombres"))
            Midocente.Correo = CStr(dr("Correos"))

            Me.Add(Midocente)
        Next

        Return Me

    End Function

    Public Sub InsertarDocente(ByVal MiDocente As DocenteClass)
        'Instancio el el Objeto BaseDatosClass para acceder al la base docentes.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "docentes"


        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        'vSQL.Append("(Id")
        vSQL.Append("(Nombres")
        vSQL.Append(",Apellidos")
        vSQL.Append(",Correos)")

        vSQL.Append(" VALUES ")
        ' vSQL.Append("('" & MiDocente.Id & "'")
        vSQL.Append("('" & MiDocente.Nombres & "'")
        vSQL.Append(",'" & MiDocente.Apellidos & "'")
        vSQL.Append(",'" & MiDocente.Correo & "')")


        'Agrego MiDocente en la tabla horarios.
        MiDocente.Id = objBaseDatos.Insertar(vSQL.ToString)

        'Agrego MiDocente en la colección actual.
        Me.Add(MiDocente)

    End Sub

    Public Sub EliminarDocente(ByVal MiDocente As DocenteClass)
        'Instancio el el Objeto BaseDatosClass para acceder al la base docentes.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "docentes"

        'Lo elimino en de la tabla docentes en la base docentes.

        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiDocente.Id)
        If resultado Then
            ' Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiDocente)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

            ' MiModulo.Dia = dias(MiModulo.IdDia - 1)
            Me.RemoveAt(Me.FindCore(myProperty, MiDocente.Id))
        Else
            MessageBox.Show("No fue posible Eliminar el registro.")
        End If

    End Sub

    Public Sub ActualizarDocente(ByVal MiDocente As DocenteClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base docentes.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "docentes"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("Nombres='" & MiDocente.Nombres.ToString & "'")
        vSQL.Append(",Apellidos='" & MiDocente.Apellidos.ToString & "'")
        vSQL.Append(",Correos='" & MiDocente.Correo.ToString & "'")
        Dim resultado As Boolean

        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiDocente.Id)
        If resultado Then
            ' Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiDocente)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

            'MiModulo.Dia = dias(MiModulo.IdDia - 1)
            Me.Items.Item(Me.FindCore(myProperty, MiDocente.Id)) = MiDocente
        Else
            MessageBox.Show("No fue posible modificar el registro.")
        End If
    End Sub

End Class
