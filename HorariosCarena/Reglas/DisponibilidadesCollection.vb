Imports System.ComponentModel
Imports System.Data.SqlClient
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

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Disponibilidades"

        Me.Add(MiDisponibilidad)

    End Sub
    Public Sub EliminarDisponibilidad(ByVal Id As Integer)

        Dim objBaseDatos As New BaseDatosClass


        objBaseDatos.Eliminar(Id)


        Me.RemoveAt(Id)

    End Sub

    Public Sub ActualizarDisponibilidad(ByVal MiDisponibilidad As DisponibilidadClass, ByVal Id As Integer)

        Dim objBaseDatos As New BaseDatosClass

        objBaseDatos.Actualizar(MiDisponibilidad, Id)

        Me.RemoveAt(Id)

    End Sub

End Class







