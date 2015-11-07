Imports System.ComponentModel
Imports System.Text

Public Class CarrerasCollection
    Inherits BindingList(Of CarreraClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)

        e.NewObject = New CarreraClass()

    End Sub
    'Este método se ejecuta cuando se crea el objeto.
    'Es el método constructor de la clase.
    Public Sub New()
        'Llena la instancia del objeto list con datos provenientes de Clases.
        Me.TraerCarreras()

    End Sub

    Public Function TraerCarreras() As CarrerasCollection
        'Instancio el el Objeto BaseDatosClass para acceder al la base carreras.
        Dim objBaseDatos As New BaseDatosClass

        'Instancio un DataTable
        Dim MiDataTable As New DataTable

        Dim MiCarrera As CarreraClass

        objBaseDatos.objTabla = "carreras"
        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            MiCarrera = New CarreraClass

            MiCarrera.id = CInt(dr("Id"))
            MiCarrera.carrera = CStr(dr("carrera"))

            Me.Add(MiCarrera)
        Next

        Return Me

    End Function

    Public Sub InsertarCarrera(ByVal Micarrera As CarreraClass)
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Carreras"

        
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(Carrera)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & Micarrera.carrera & "')")

        'Agrego MiHorario en la tabla horarios.
        objBaseDatos.Insertar(vSQL.ToString)
        'Agrego MiCarrera en la colección actual.
        Me.Add(Micarrera)

        'vResultado = True

        ''Return vResultado

    End Sub

    Public Sub EliminarCarrera(ByVal Id As Integer)
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Carreras"

        'Lo elimino en de la tabla horarios en la base horarios.
        objBaseDatos.Eliminar(Id)

        'Elimino MiCarrera con el Id en la colección actual.

        Me.RemoveAt(Id)

    End Sub

    Public Sub ActualizarCarrera(ByVal MiCarrera As CarreraClass, ByVal Id As Integer)

        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Carrera"

        'Actualizo la tabla horarios con el Id.
        'CORREGIR objBaseDatos.Actualizar(MiCarrera, Id)

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(Carrera)")
        vSQL.Append(" VALUES ")
        vSQL.Append("(" & MiCarrera.carrera & "')")

        'Actualizo la tabla horarios con el Id.
        objBaseDatos.Actualizar(vSQL.ToString, Id)

        'Actualizo la colección.
        Me.Item(Id).id = MiCarrera.id
        Me.Item(Id).carrera = MiCarrera.carrera

    End Sub

End Class

