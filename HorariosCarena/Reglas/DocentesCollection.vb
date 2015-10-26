Imports System.ComponentModel

Public Class DocentesCollection

    Inherits BindingList(Of DocenteClass)
    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New DocenteClass 'DocenteCollection ?
    End Sub
    Public Function TraerDocentes() As DocentesCollection
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass

        'Instancio un DataTable
        Dim MiDataTable As New DataTable

        Dim Midocente As DocenteClass

        objBaseDatos.objTabla = "docentes"
        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            Midocente = New DocenteClass

            ' Midocente.Id = CInt(dr("Id"))
            Midocente.Apellidos = CStr(dr("Apellidos"))
            Midocente.Nombres = CStr(dr("IdAsignatura"))
            Midocente.Correo = CStr(dr("IdModulo"))

            Me.Add(Midocente)
        Next

        Return Me

    End Function

    Public Sub InsertarDocentes(ByVal MiDocente As DocenteClass)
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "docentes"

        Me.Add(MiDocente)
        'objBaseDatos.Insertar(MiHorario)

    End Sub

    Public Sub EliminarDocente(ByVal Id As Integer)
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "docentes"

        'Lo elimino en de la tabla horarios en la base horarios.
        objBaseDatos.Eliminar(Id)

        'Elimino MiHorario con el Id en la colección actual.
        Me.RemoveAt(Id)

    End Sub

    Public Sub ActualizarDocente(ByVal MiDocente As DocenteClass, ByVal Id As Integer)

        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "docentes"

        'Actualizo la tabla horarios con el Id.
        objBaseDatos.Actualizar(MiDocente, Id)

        'Elimino MiHorario con el Id en la colección actual.
        'docentes_list.Item(indice_) = MiDocente
        Me.RemoveAt(Id)
    End Sub



End Class
