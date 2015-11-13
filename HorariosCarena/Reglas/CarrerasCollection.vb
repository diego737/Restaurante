Imports System.ComponentModel
Imports System.Text

Public Class CarrerasCollection
    Inherits BindingList(Of CarreraClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)

        e.NewObject = New CarreraClass()

    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each carrera In Me
            If prop.GetValue(carrera).Equals(key) Then
                Return Me.IndexOf(carrera)
            End If
        Next

        Return -1
    End Function
    Public Sub New()
        Me.TraerCarreras()
    End Sub


    Public Function TraerCarreras() As CarrerasCollection
        Dim objBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiCarrera As CarreraClass

        objBaseDatos.objTabla = "carreras"
        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            MiCarrera = New CarreraClass
            MiCarrera.id = CInt(dr("Id"))
            MiCarrera.carrera = CStr(dr("carrera"))

            Me.Add(MiCarrera)
        Next

        Return Me

    End Function

    Public Sub InsertarCarrera(ByVal Micarrera As CarreraClass)
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Carreras"

        
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(Carrera)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & Micarrera.carrera & "')")
        Micarrera.id = objBaseDatos.Insertar(vSQL.ToString)

        If Micarrera.id > 0 Then

            Me.Add(Micarrera)
        Else
            MessageBox.Show("No fue posible agregar el registro.")
        End If
       

    End Sub

    Public Sub EliminarCarrera(ByVal MiCarrera As CarreraClass)
        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Carreras"
        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiCarrera.id)
        If resultado Then
            ' Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiCarrera)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
        End If
    End Sub

    'Public Sub ActualizarModulo(ByVal MiModulo As ModuloClass)
    Public Sub ActualizarCarrera(ByVal MiCarrera As CarreraClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base hporarios.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Carrera"

        'Actualizo la tabla horarios con el Id.
        'CORREGIR objBaseDatos.Actualizar(MiCarrera, Id)

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("Carrera='" & MiCarrera.carrera.ToString & "'")
        vSQL.Append(" VALUES ")
        ' vSQL.Append("(" & MiCarrera.carrera & "')")


        Dim resultado As Boolean
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiCarrera.id)

        If resultado Then
            ' Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiCarrera)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

            Me.Items.Item(Me.FindCore(myProperty, MiCarrera.id)) = MiCarrera
        Else
            MessageBox.Show("No fue posible modificar el registro.")
        End If
    End Sub

End Class

