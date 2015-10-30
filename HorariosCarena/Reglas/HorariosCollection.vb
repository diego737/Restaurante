Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Text

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

            Mihorario.Id = CInt(dr("Id"))
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

        'Agrego MiHorario en la colección actual.
        Me.Add(MiHorario)
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(IdAsignatura")
        vSQL.Append(",IdCarrera")
        vSQL.Append(",IdDia")
        vSQL.Append(",IdModulos)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & MiHorario.IdAsignatura & "'")
        vSQL.Append(",'" & MiHorario.IdCarrera & "'")
        vSQL.Append(",'" & MiHorario.IdDia & "'")
        vSQL.Append(",'" & MiHorario.IdModulo & "')")

        'Agrego MiHorario en la tabla horarios.
        objBaseDatos.Insertar(vSQL.ToString)

        vResultado = True

        'Return vResultado

    End Sub

    Public Sub EliminarHorario(ByVal Id As Integer)
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "horarios"

        'Lo elimino en de la tabla horarios en la base horarios.
        objBaseDatos.Eliminar(Id)

        'Elimino MiHorario con el Id en la colección actual.
        Me.RemoveAt(Id)

    End Sub

    Public Sub ActualizarHorario(ByVal MiHorario As HorarioClass, ByVal Id As Integer)

        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "horarios"

        'Actualizo la tabla horarios con el Id.
        objBaseDatos.Actualizar(MiHorario, Id)

        Me.Item(Id).IdDia = MiHorario.IdDia
        Me.Item(Id).IdCarrera = MiHorario.IdCarrera
        Me.Item(Id).IdAsignatura = MiHorario.IdAsignatura
        Me.Item(Id).IdModulo = MiHorario.IdModulo

    End Sub

End Class
