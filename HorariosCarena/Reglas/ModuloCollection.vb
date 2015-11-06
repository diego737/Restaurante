Imports System.ComponentModel
Imports System.Text

Public Class ModuloCollection
    Inherits BindingList(Of ModuloClass)

    'Este array es solo para módulos.
    Public dias() As String = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes"}

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
            MiModulo.Dia = dias(CInt(dr("IdDIa")) - 1)
            MiModulo.Inicio = CStr(dr("Inicio"))
            MiModulo.Fin = CStr(dr("Fin"))

            Me.Add(MiModulo)
        Next

        Return Me

    End Function

    Public Sub InsertarModulo(ByVal MiModulo As ModuloClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Modulos"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(IdDia")
        vSQL.Append(",Inicio")
        vSQL.Append(",Fin)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & MiModulo.IdDia & "'")
        vSQL.Append(",'" & MiModulo.Inicio & "'")
        vSQL.Append(",'" & MiModulo.Fin & "')")

        'El método insertar me devuelve el Id de la fila insertada.
        MiModulo.Id = objBaseDatos.Insertar(vSQL.ToString)

        MiModulo.Dia = dias(MiModulo.IdDia - 1)
        Me.Add(MiModulo)

    End Sub

    Public Sub EliminarModulo(ByVal MiModulo As ModuloClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Modulos"

        objBaseDatos.Eliminar(MiModulo.Id)

        ' Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiModulo)

        'Sets an PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

        MiModulo.Dia = dias(MiModulo.IdDia - 1)
        Me.RemoveAt(Me.FindCore(myProperty, MiModulo.Id))

    End Sub

    Public Sub ActualizarModulo(ByVal MiModulo As ModuloClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Modulos"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("IdDia=" & MiModulo.IdDia.ToString)
        vSQL.Append(",Inicio='" & MiModulo.Inicio.ToString)
        vSQL.Append("',Fin='" & MiModulo.Fin.ToString & "'")

        objBaseDatos.Actualizar(vSQL.ToString, MiModulo.Id)

        ' Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiModulo)

        'Sets an PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

        MiModulo.Dia = dias(MiModulo.IdDia - 1)
        Me.Items.Item(Me.FindCore(myProperty, MiModulo.Id)) = MiModulo

    End Sub

End Class

