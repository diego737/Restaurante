Imports System.Data.SqlClient
Imports System.ComponentModel
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

            'Miasignatura.Id = CInt(dr("Id"))
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

        Me.Add(Miasignatura)
        'objBaseDatos.Insertar(Miasignatura)

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
        objBaseDatos.Actualizar(Miasignatura, Id)

        'Elimino Miasignatura con el Id en la colección actual.
        'horarios_list.Item(indice_) = Miasignatura
        Me.RemoveAt(Id)

    End Sub


End Class
