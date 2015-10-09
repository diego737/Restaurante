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
        'Dim vSQL As New StringBuilder
        'Dim vResultado As Boolean = False

        'vSQL.Append("INSERT INTO Ciudades ")
        'vSQL.Append("(idCiudad")
        'vSQL.Append(",idProvincia")
        'vSQL.Append(",nombre")
        'vSQL.Append(")")
        'vSQL.Append(" VALUES ")
        'vSQL.Append("('" & Me.m_IdCiudad & "'")
        'vSQL.Append(",'" & Me.m_IdProvincia & "'")
        'vSQL.Append(",'" & Me.m_Nombre & "'")
        'vSQL.Append(")")

        'Call oDB.EjecutarComando(vSQL.ToString)


        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "horarios"

        'Dim sel As String

        'sel = "INSERT INTO horarios" & _
        '    "(Nombre, Apellidos, Email, Fecha, Descripcion) " & _
        '    "VALUES " & _
        '    "(@Nombre, @Apellidos, @Email, @Fecha, @Descripcion) " & _
        '    "SELECT @@Identity"

        'Using con As New SqlConnection(objBaseDatos.conexion)
        '    Dim cmd As New SqlCommand(sel, con)
        '    cmd.Parameters.AddWithValue("@Nombre", nombre)
        '    cmd.Parameters.AddWithValue("@Apellidos", apellidos)
        '    cmd.Parameters.AddWithValue("@Email", email)
        '    cmd.Parameters.AddWithValue("@Fecha", fecha)
        '    cmd.Parameters.AddWithValue("@Descripcion", descripcion)
        '    con.Open()
        '    Dim t As Integer = CInt(cmd.ExecuteScalar())
        '    con.Close()
        '    Return t
        'End Using

        'objBaseDatos.Insertar(objDataRow)

        'Agrego MiHorario a la colección actual.
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
