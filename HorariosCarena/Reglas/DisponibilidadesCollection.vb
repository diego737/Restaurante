Imports System.ComponentModel
Imports System.Text

Public Class DisponibilidadesCollection
    Inherits BindingList(Of DisponibilidadClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New DisponibilidadClass

    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each disponibilidad In Me
            If prop.GetValue(disponibilidad).Equals(key) Then
                Return Me.IndexOf(disponibilidad)
            End If
        Next

        Return -1
    End Function

    Public Sub New()
        Me.TraerDisponibilidad()
    End Sub
    Public Function TraerDisponibilidad() As DisponibilidadesCollection

        Dim objBaseDatos As New BaseDatosClass

        Dim MiDataTable As New DataTable

        Dim MiDisponibilidad As DisponibilidadClass

        objBaseDatos.objTabla = "Disponibilidades"
        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            MiDisponibilidad = New DisponibilidadClass

            MiDisponibilidad.Id = CInt(dr("Id"))
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

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False


        vSQL.Append("(IdDocente")
        vSQL.Append(",IdModulo)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & MiDisponibilidad.IdDocente & "'")
        vSQL.Append(",'" & MiDisponibilidad.IdModulo & "')")

        'Agrego MiHorario en la tabla horarios.
        MiDisponibilidad.Id = objBaseDatos.Insertar(vSQL.ToString)
        If MiDisponibilidad.Id > 0 Then
            Me.Add(MiDisponibilidad)
        Else
            MessageBox.Show("no fue posible agregar el registro.")
        End If

    End Sub

    Public Sub EliminarDisponibilidad(ByVal MiDisponibilidad As DisponibilidadClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Disponibilidades"

        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiDisponibilidad.Id)

        If resultado Then
            ' Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiDisponibilidad)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

            Me.RemoveAt(Me.FindCore(myProperty, MiDisponibilidad.Id))

        Else
            MessageBox.Show("no fue posible agregar el registro.")

        End If


    End Sub

    Public Sub ActualizarDisponibilidad(ByVal MiDisponibilidad As DisponibilidadClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Disponibilidades"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False


        vSQL.Append(",IdDocente='" & MiDisponibilidad.IdDocente.ToString & "'")
        vSQL.Append("',IdModulo='" & MiDisponibilidad.IdModulo.ToString & "'")

        Dim resultado As Boolean
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiDisponibilidad.Id)

        If resultado Then
            ' Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiDisponibilidad)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)


            Me.Items.Item(Me.FindCore(myProperty, MiDisponibilidad.Id)) = MiDisponibilidad

        Else
            MessageBox.Show("no fue posible modificar el registro.")
        End If

    End Sub

End Class







