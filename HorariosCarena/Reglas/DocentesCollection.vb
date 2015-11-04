Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Text

Public Class DocentesCollection

    Inherits BindingList(Of DocenteClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New DocenteClass 'DocenteCollection ?
    End Sub
    'Este método se ejecuta cuando se crea el objeto.
    'Es el método constructor de la clase.
    Public Sub New()
        'Llena la instancia del objeto list con datos provenientes de Docentes.
        Me.TraerDocentes()

    End Sub
    Public Function TraerDocentes() As DocentesCollection
        'Instancio el el Objeto BaseDatosClass para acceder al la base docentes.
        Dim objBaseDatos As New BaseDatosClass

        'Instancio un DataTable
        Dim MiDataTable As New DataTable

        Dim Midocente As DocenteClass

        objBaseDatos.objTabla = "docentes"
        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            Midocente = New DocenteClass

            Midocente.Id = CInt(dr("Id"))
            Midocente.Apellidos = CStr(dr("Apellidos"))
            Midocente.Nombres = CStr(dr("Nombres"))
            Midocente.Correo = CStr(dr("Correos"))

            Me.Add(Midocente)
        Next

        Return Me

    End Function

    Public Sub InsertarDocentes(ByVal MiDocente As DocenteClass)
        'Instancio el el Objeto BaseDatosClass para acceder al la base docentes.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "docentes"

       
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        'vSQL.Append("(Id")
        vSQL.Append("(Nombres")
        vSQL.Append(",Apellidos")
        vSQL.Append(",Correos)")

        vSQL.Append(" VALUES ")
        ' vSQL.Append("('" & MiDocente.Id & "'")
        vSQL.Append("('" & MiDocente.Nombres & "'")
        vSQL.Append(",'" & MiDocente.Apellidos & "'")
        vSQL.Append(",'" & MiDocente.Correo & "')")


        Try
            'Agrego MiDocente en la tabla horarios.
            objBaseDatos.Insertar(vSQL.ToString)

            'Agrego MiDocente en la colección actual.
            Me.Add(MiDocente)

        Catch ex1 As InvalidOperationException
            MessageBox.Show(ex1.Message)

        Catch ex2 As SqlException
            MessageBox.Show(ex2.Message)

        End Try

    End Sub

    Public Sub EliminarDocente(ByVal Id As Integer)
        'Instancio el el Objeto BaseDatosClass para acceder al la base docentes.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "docentes"

        Try
            'Lo elimino en de la tabla docentes en la base docentes.
            objBaseDatos.Eliminar(Id)

            'Elimino MiDocente con el Id en la colección actual.
            Me.RemoveAt(Id)
        Catch ex1 As InvalidOperationException
            MessageBox.Show(ex1.Message)

        Catch ex2 As SqlException
            MessageBox.Show(ex2.Message)

        End Try


    End Sub

    Public Sub ActualizarDocente(ByVal MiDocente As DocenteClass, ByVal Id As Integer)

        'Instancio el el Objeto BaseDatosClass para acceder al la base docentes.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "docentes"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        'vSQL.Append("(ID")
        vSQL.Append("(Nombres")
        vSQL.Append(",Apellidos")
        vSQL.Append(",Correos)")

        vSQL.Append(" VALUES ")
        'vSQL.Append("('" & MiDocente.Id & "'")
        vSQL.Append("('" & MiDocente.Nombres & "'")
        vSQL.Append(",'" & MiDocente.Apellidos & "'")
        vSQL.Append(",'" & MiDocente.Correo & "')")

        Try
            'Actualizo la tabla docentes con el Id.
            objBaseDatos.Actualizar(vSQL.ToString, Id)

            'Actualizo la colección.
            Me.Item(Id).Id = MiDocente.Id
            Me.Item(Id).Apellidos = MiDocente.Apellidos
            Me.Item(Id).Nombres = MiDocente.Nombres
            Me.Item(Id).Correo = MiDocente.Correo

        Catch ex1 As InvalidOperationException
            MessageBox.Show(ex1.Message)

        Catch ex2 As SqlException
            MessageBox.Show(ex2.Message)

        End Try
    End Sub



End Class
