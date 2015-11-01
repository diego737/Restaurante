Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Text

Public Class HorariosCollection
    Inherits BindingList(Of HorarioClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)

        e.NewObject = New HorarioClass()

    End Sub

    'Este método se ejecuta cuando se crea el objeto.
    'Es el método constructor de la clase.
    Public Sub New()
        'Llena la instancia del objeto list con datos provenientes de Horarios.
        Me.TraerHorarios()
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

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(IdAsignatura")
        vSQL.Append(",IdCarrera")
        vSQL.Append(",IdDia")
        vSQL.Append(",IdModulo)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & MiHorario.IdAsignatura & "'")
        vSQL.Append(",'" & MiHorario.IdCarrera & "'")
        vSQL.Append(",'" & MiHorario.IdDia & "'")
        vSQL.Append(",'" & MiHorario.IdModulo & "')")

        Try
            'Agrego MiHorario en la tabla horarios.
            objBaseDatos.Insertar(vSQL.ToString)

            'Agrego MiHorario en la colección actual.
            Me.Add(MiHorario)

        Catch ex1 As InvalidOperationException
            MessageBox.Show(ex1.Message)

        Catch ex2 As SqlException
            MessageBox.Show(ex2.Message)

        End Try

    End Sub

    Public Sub EliminarHorario(ByVal Id As Integer)
        'Instancio el el Objeto BaseDatosClass para acceder al la base horarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "horarios"

        Try
            'Lo elimino en de la tabla horarios en la base horarios.
            objBaseDatos.Eliminar(Id)

            'Elimino MiHorario con el Id en la colección actual.
            Me.RemoveAt(Id)
        Catch ex1 As InvalidOperationException
            MessageBox.Show(ex1.Message)

        Catch ex2 As SqlException
            MessageBox.Show(ex2.Message)

        End Try

    End Sub

    Public Sub ActualizarHorario(ByVal MiHorario As HorarioClass, ByVal Id As Integer)

        'Instancio el el Objeto BaseDatosClass para acceder al la base horarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "horarios"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(IdAsignatura")
        vSQL.Append(",IdCarrera")
        vSQL.Append(",IdDia")
        vSQL.Append(",IdModulo)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & MiHorario.IdAsignatura & "'")
        vSQL.Append(",'" & MiHorario.IdCarrera & "'")
        vSQL.Append(",'" & MiHorario.IdDia & "'")
        vSQL.Append(",'" & MiHorario.IdModulo & "')")

        Try
            'Actualizo la tabla horarios con el Id.
            objBaseDatos.Actualizar(vSQL.ToString, Id)

            'Actualizo la colección.
            Me.Item(Id).IdDia = MiHorario.IdDia
            Me.Item(Id).IdCarrera = MiHorario.IdCarrera
            Me.Item(Id).IdAsignatura = MiHorario.IdAsignatura
            Me.Item(Id).IdModulo = MiHorario.IdModulo

        Catch ex1 As InvalidOperationException
            MessageBox.Show(ex1.Message)

        Catch ex2 As SqlException
            MessageBox.Show(ex2.Message)

        End Try

    End Sub

End Class
