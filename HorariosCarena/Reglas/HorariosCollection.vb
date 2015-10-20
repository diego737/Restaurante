Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class HorariosCollection
    Inherits BindingList(Of HorarioClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)

        e.NewObject = New HorarioClass()

    End Sub

    Public Function TraerHorarios() As HorariosCollection
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass

        'Instancio un DataTable
        Dim MiDataTable As New DataTable

        Dim Mihorario As HorarioClass

        objBaseDatos.objTabla = "horarios"
        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            Mihorario = New HorarioClass

            Mihorario.IdCarrera = CInt(dr("IdCarrera"))
            Mihorario.IdDia = CInt(dr("IdDia"))
            Mihorario.IdAsignatura = CInt(dr("IdAsignatura"))
            Mihorario.IdModulo = CInt(dr("IdModulo"))

            Me.Add(Mihorario)
        Next

        Return Me

    End Function

    Public Sub InsertarHorario(ByVal MiHorario As HorarioClass)
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "horarios"

        Me.Add(MiHorario)

    End Sub

    Public Sub EliminarHorario(ByVal Id As Integer)
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass

        'Lo elimino en de la tabla horarios en la base horarios.
        objBaseDatos.Eliminar(Id)

        'Elimino MiHorario con el Id en la colección actual.
        Me.RemoveAt(Id)

    End Sub

    Public Sub ActualizarHorario(ByVal MiHorario As HorarioClass, ByVal Id As Integer)

        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass

        'Actualizo la tabla horarios con el Id.
        objBaseDatos.Actualizar(MiHorario, Id)

        'Elimino MiHorario con el Id en la colección actual.
        'horarios_list.Item(indice_) = MiHorario
        Me.RemoveAt(Id)

    End Sub

End Class
