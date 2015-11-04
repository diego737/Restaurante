Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Text

Public Class ModuloCollection
    Inherits BindingList(Of ModuloClass)


    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)

        e.NewObject = New ModuloClass

    End Sub

    Public Sub New()
        Me.TraerModulos()
    End Sub

    Public Function TraerModulos() As ModuloCollection

        Dim objBaseDatos As New BaseDatosClass

        Dim MiDataTable As New DataTable

        Dim MiModulo As ModuloClass

        objBaseDatos.objTabla = "Modulos"
        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            MiModulo = New ModuloClass

            MiModulo.Id = CInt(dr("Id"))
            MiModulo.IdDia = CInt(dr("IdDia"))
            MiModulo.inicio = CInt(dr("Inicio"))
            MiModulo.fin = CInt(dr("fin"))

            Me.Add(MiModulo)

        Next

        Return Me

    End Function

    Public Sub InsertarModulo(ByVal MiModulo As ModuloClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Modulos"

        Me.Add(MiModulo)
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(IdDia")
        vSQL.Append(",Inicio")
        vSQL.Append(",Fin)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & MiModulo.IdDia & "'")
        vSQL.Append(",'" & MiModulo.inicio & "'")
        vSQL.Append(",'" & MiModulo.fin & "')")
        Try
            objBaseDatos.Insertar(vSQL.ToString)

            Me.Add(MiModulo)

        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message)

        Catch ex1 As SqlException
            MessageBox.Show(ex1.Message)
        End Try


    End Sub

    Public Sub EliminarModulo(ByVal Id As Integer)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Modulos"

        Try
            objBaseDatos.Eliminar(Id)

            Me.RemoveAt(Id)
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message)

        Catch ex1 As SqlException
            MessageBox.Show(ex1.Message)

        End Try

    End Sub

    Public Sub ActualizarModulo(ByVal MiModulo As ModuloClass, ByVal Id As Integer)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Modulos"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(IdDia")
        vSQL.Append(",Inicio")
        vSQL.Append(",Fin)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & MiModulo.IdDia & "'")
        vSQL.Append(",'" & MiModulo.inicio & "'")
        vSQL.Append(",'" & MiModulo.fin & "')")

        Try

            objBaseDatos.Actualizar(vSQL.ToString, Id)

            Me.Item(Id).Id = MiModulo.Id
            Me.Item(Id).IdDia = MiModulo.IdDia
            Me.Item(Id).inicio = MiModulo.inicio
            Me.Item(Id).fin = MiModulo.fin

        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message)

        Catch ex1 As SqlException
            MessageBox.Show(ex1.Message)

        End Try
      
    End Sub

End Class

