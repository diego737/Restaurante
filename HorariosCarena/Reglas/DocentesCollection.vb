Imports System.ComponentModel

Public Class DocentesCollection

    Inherits BindingList(Of DocenteClass)
    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New DocenteClass 'DocenteCollection ?
    End Sub
    'Public Function TraerDocentes() As DocentesCollection
    '    'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
    '    Dim objBaseDatos As New BaseDatosClass

    '    'Instancio un DataTable
    '    Dim MiDataTable As New DataTable

    '    Dim Midocente As DocenteClass

    '    objBaseDatos.objTabla = "horarios"
    '    MiDataTable = objBaseDatos.Consultar

    '    For Each dr As DataRow In MiDataTable.Rows
    '        Midocente = New DocenteClass

    '        ' Midocente.Id = CInt(dr("Id"))
    '        Midocente.Nombres = CStr(dr("Nombres"))
    '        Midocente.Apellidos = CInt(dr("Apellidos"))
    '        Midocente.IdAsignatura = CInt(dr("IdAsignatura"))
    '        Midocente.IdModulo = CInt(dr("IdModulo"))

    '        Me.Add(Midocente)
    '    Next

    '    Return Me

    'End Function

    'Public Sub InsertarHorario(ByVal MiHorario As HorarioClass)
    '    'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
    '    Dim objBaseDatos As New BaseDatosClass
    '    objBaseDatos.objTabla = "horarios"

    '    Me.Add(MiHorario)
    '    'objBaseDatos.Insertar(MiHorario)

    'End Sub

    'Public Sub EliminarHorario(ByVal Id As Integer)
    '    'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
    '    Dim objBaseDatos As New BaseDatosClass
    '    objBaseDatos.objTabla = "horarios"

    '    'Lo elimino en de la tabla horarios en la base horarios.
    '    objBaseDatos.Eliminar(Id)

    '    'Elimino MiHorario con el Id en la colección actual.
    '    Me.RemoveAt(Id)

    'End Sub

    'Public Sub ActualizarHorario(ByVal MiHorario As HorarioClass, ByVal Id As Integer)

    '    'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
    '    Dim objBaseDatos As New BaseDatosClass
    '    objBaseDatos.objTabla = "horarios"

    '    'Actualizo la tabla horarios con el Id.
    '    objBaseDatos.Actualizar(MiHorario, Id)

    '    'Elimino MiHorario con el Id en la colección actual.
    '    'horarios_list.Item(indice_) = MiHorario
    '    Me.RemoveAt(Id)
    'end sub



End Class
