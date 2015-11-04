Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Text

Public Class ModuloCollection
    Inherits BindingList(Of ModuloClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New ModuloClass()
    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each modulo In Me
            If prop.GetValue(modulo).Equals(key) Then
                Return Me.IndexOf(modulo)
            End If
        Next

        Return -1
    End Function

    'Private Function Find(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find

    'End Function

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

    Public Sub EliminarModulo(ByVal OModulo As ModuloClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Modulos"

        Try
            objBaseDatos.Eliminar(OModulo.Id)

            Me.Remove(OModulo)

        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message)

        Catch ex1 As SqlException
            MessageBox.Show(ex1.Message)

        End Try

    End Sub

    Public Sub ActualizarModulo(ByVal MiModulo As ModuloClass)

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
            objBaseDatos.Actualizar(vSQL.ToString, MiModulo.Id)

            Me.Items.Item(Me.FindCore(MiModulo.Id, MiModulo.Id)) = MiModulo

        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message)

        Catch ex1 As SqlException
            MessageBox.Show(ex1.Message)

        End Try

    End Sub

End Class

