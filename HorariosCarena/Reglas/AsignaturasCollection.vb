Imports System.ComponentModel
Imports System.Text

Public Class AsignaturasCollection
    Inherits BindingList(Of AsignaturaClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)

        e.NewObject = New AsignaturaClass

    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each asignatura In Me
            If prop.GetValue(asignatura).Equals(key) Then
                Return Me.IndexOf(asignatura)
            End If
        Next

        Return -1
    End Function

    Public Sub New()
        Me.TraerAsignatura()
    End Sub

    Public Function TraerAsignatura() As AsignaturasCollection
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass

        'Instancio un DataTable
        Dim MiDataTable As New DataTable

        Dim Miasignatura As AsignaturaClass

        objBaseDatos.objTabla = "Asignaturas"
        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            Miasignatura = New AsignaturaClass

            Miasignatura.Id = CInt(dr("Id"))
            Miasignatura.IdCarrera = CInt(dr("IdCarrera"))
            Miasignatura.Modulos = CInt(dr("Modulos"))
            ' Miasignatura.Asignados = CInt(dr("IdAsignados"))
            Miasignatura.IdDocente = CInt(dr("IdDocente"))

            Me.Add(Miasignatura)
        Next

        Return Me

    End Function

    Public Sub InsertarAsignatura(ByVal Miasignatura As AsignaturaClass)
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Asignaturas"

        'Agrego MiHorario en la colección actual.
        'Me.Add(Miasignatura)

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(Asignados")
        vSQL.Append(",IdCarrera")
        vSQL.Append(",IdDocente")
        vSQL.Append(",Modulos)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & Miasignatura.Asignados & "'")
        vSQL.Append(",'" & Miasignatura.IdCarrera & "'")
        vSQL.Append(",'" & Miasignatura.IdDocente & "'")
        vSQL.Append(",'" & Miasignatura.Modulos & "')")

        Try
            Miasignatura.Id = objBaseDatos.Insertar(vSQL.ToString)

            Me.Add(Miasignatura)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Public Sub EliminarAsignatura(ByVal MiAsignatura As AsignaturaClass)
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Asignaturas"

        Try
            'Lo elimino en de la tabla horarios en la base horarios.
            objBaseDatos.Eliminar(MiAsignatura.Id)

            'Elimino Miasignatura con el Id en la colección actual.
            ' Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiAsignatura)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Public Sub ActualizarAsignatura(ByVal Miasignatura As AsignaturaClass, ByVal Id As Integer)

        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Asignatura"

        'Actualizo la tabla horarios con el Id.
        'CORREGIR objBaseDatos.Actualizar(Miasignatura, Id)

        Me.Item(Id).IdDocente = Miasignatura.IdDocente
        Me.Item(Id).IdCarrera = Miasignatura.IdCarrera
        Me.Item(Id).Modulos = Miasignatura.Modulos
        Me.Item(Id).Asignados = Miasignatura.Asignados

        'Elimino Miasignatura con el Id en la colección actual.
        'horarios_list.Item(indice_) = Miasignatura
        'Me.RemoveAt(Id)

    End Sub


End Class
