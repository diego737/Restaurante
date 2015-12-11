Imports System.ComponentModel
Imports System.Text

Public Class HorariosCollection
    Inherits BindingList(Of HorarioClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        'Este m�todo define como se van agregar los elementos a la colecci�n.
        e.NewObject = New HorarioClass()

    End Sub

    'Propiedad que habilita la b�squeda en la colecci�n ya que no trae ese m�todo en forma nativa.
    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    'M�todo que busca un �tem dentro de la colecci�n.
    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each modulo In Me
            If prop.GetValue(modulo).Equals(key) Then
                Return Me.IndexOf(modulo)
            End If
        Next

        Return -1
    End Function

    'Este m�todo se ejecuta cuando se crea el objeto.
    'Es el m�todo constructor de la clase.
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

        'Establece la propiedad objTabla que define sobre que tabla
        'se van a realizar las  operaciones.
        objBaseDatos.objTabla = "horarios"
        'Ejecuta el m�todo consultar.
        MiDataTable = objBaseDatos.Consultar

        'Recorre cada elemento del DataTable.
        For Each dr As DataRow In MiDataTable.Rows
            'Crea una instancia de HorarioClass
            Mihorario = New HorarioClass

            'Establece las propiedades de Mihorario a partir del DataTable.
            Mihorario.Id = CInt(dr("Id"))
            Mihorario.IdCarrera = CInt(dr("IdCarrera"))
            Mihorario.IdDia = CInt(dr("IdDia"))
            Mihorario.IdAsignatura = CInt(dr("IdAsignatura"))
            Mihorario.IdModulo = CInt(dr("IdModulo"))

            'Agrega la instancia MiHorario a la actual colecci�n.
            Me.Add(Mihorario)
        Next

        'Retorna la colecci�n.
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

        'Agrego MiHorario en la colecci�n actual.
        Me.Add(MiHorario)

    End Sub

    Public Sub EliminarHorario(ByVal MiHorario As HorarioClass)
        'Instancio el el Objeto BaseDatosClass para acceder al la base horarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Horarios"

        'Ejecuta el m�todo base eliminar.
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
        'El m�todo actualizar es una funci�n que devuelve True o False
        'Seg�n como haya resultado la operaci�n sobre la tabla SQL.
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiHorario.Id)

        If resultado Then
            'El c�digo a continuaci�n sirve para localizar el �tem en la lista
            'en este caso un horario.
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
