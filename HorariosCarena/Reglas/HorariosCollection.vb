Imports System.ComponentModel
Imports System.Text

Public Class HorariosCollection
    Inherits BindingList(Of HorarioClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)

        e.NewObject = New HorarioClass()

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


        'Agrego MiHorario en la tabla horarios.
        MiHorario.Id = objBaseDatos.Insertar(vSQL.ToString)

        'Agrego MiHorario en la colección actual.
        Me.Add(MiHorario)

    End Sub

    Public Sub EliminarHorario(ByVal MiHorario As HorarioClass)
        'Instancio el el Objeto BaseDatosClass para acceder al la base horarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Horarios"

        'Ejecuta el método base eliminar.
        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiHorario.Id)
        If resultado Then


            'Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiHorario)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

            Me.RemoveAt(Me.FindCore(myProperty, MiHorario.Id))
        Else
            MessageBox.Show("No fue posible agregar el registro.")
        End If
    End Sub

    Public Sub ActualizarHorario(ByVal MiHorario As HorarioClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base horarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "horarios"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(IdAsignatura='" & MiHorario.IdAsignatura.ToString & "'")
        vSQL.Append(",IdCarrera='" & MiHorario.IdCarrera.ToString & "'")
        vSQL.Append(",IdDia='" & MiHorario.IdDia.ToString & "'")
        vSQL.Append(",IdModulo='" & MiHorario.IdModulo.ToString & "'")

        'Actualizo la tabla horarios con el Id.
        Dim resultado As Boolean
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiHorario.Id)

        If resultado Then

            ' Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiHorario)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
            Me.Items.Item(Me.FindCore(myProperty, MiHorario.Id)) = MiHorario
        Else
            MessageBox.Show("No fue posible modificar el registro.")
        End If
    End Sub

End Class
