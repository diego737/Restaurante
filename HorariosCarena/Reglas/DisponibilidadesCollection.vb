Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text

Public Class DisponibilidadesCollection
    Inherits BindingList(Of DisponibilidadClass)
    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New DisponibilidadClass



    End Sub
    Public Function TraerDisponibilidad() As DisponibilidadesCollection
        Dim objBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiDisponibilidad As DisponibilidadClass

        objBaseDatos.objTabla = "Disponibilidades"
        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            MiDisponibilidad = New DisponibilidadClass

            MiDisponibilidad.IdDocente = CInt(dr("IdDocente"))
            MiDisponibilidad.IdModulo = CInt(dr("IdModulo"))

            Me.Add(MiDisponibilidad)
        Next

        Return Me

    End Function
    Public Sub InsertarDisponibilidad(ByVal MiDisponibilidad As DisponibilidadClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Disponibilidades"

        'Agrego MiHorario en la colección actual.
        Me.Add(MiDisponibilidad)
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False


        vSQL.Append(",IdDocente")
        vSQL.Append(",IdModulo")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & MiDisponibilidad.IdDocente & "'")
        vSQL.Append(",'" & MiDisponibilidad.IdModulo & "'")


        'Agrego MiHorario en la tabla horarios.
        objBaseDatos.Insertar(vSQL.ToString)

        vResultado = True

        'Return vResultado

    End Sub

    Public Sub EliminarDisponibilidad(ByVal Id As Integer)

        Dim objBaseDatos As New BaseDatosClass


        objBaseDatos.Eliminar(Id)


        Me.RemoveAt(Id)

    End Sub

    Public Sub ActualizarDisponibilidad(ByVal MiDisponibilidad As DisponibilidadClass, ByVal Id As Integer)

        Dim objBaseDatos As New BaseDatosClass

        'CORREGIR objBaseDatos.Actualizar(MiDisponibilidad, Id)

        Me.RemoveAt(Id)

    End Sub

End Class







