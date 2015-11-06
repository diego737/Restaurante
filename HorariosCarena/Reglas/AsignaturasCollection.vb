Imports System.ComponentModel
Imports System.Text

Public Class AsignaturasCollection
    Inherits BindingList(Of AsignaturaClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)

        e.NewObject = New AsignaturaClass  'DocenteCollection ?

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
            Miasignatura.Asignados = CInt(dr("IdAsignados"))
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
        Me.Add(Miasignatura)
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

        'Agrego MiHorario en la tabla horarios.
        objBaseDatos.Insertar(vSQL.ToString)

        vResultado = True

        'Return vResultado
        'Agrego MiHOrario en la tabla asignatura.
        'objBaseDatos.Insertar(vSQL.ToString)

        'Agrego MiHorario en la colección actual.
        'Me.Add(Miasignatura)

    End Sub

    Public Sub EliminarAsignatura(ByVal Id As Integer)
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Asignaturas"

        'Lo elimino en de la tabla horarios en la base horarios.
        objBaseDatos.Eliminar(Id)

        'Elimino Miasignatura con el Id en la colección actual.
        Me.RemoveAt(Id)

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
