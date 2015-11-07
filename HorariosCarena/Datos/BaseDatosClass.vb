Option Strict On

Imports System.Data
Imports System.Data.SqlClient

Public Class BaseDatosClass

    'Inicializamos el string de la cadena de conexi�n.
    Dim CadenaConexion As String = "Data Source=.\SQLEXPRESS; DataBase=horarios; User=sa; Password=carena"

    'Instaciamos un objeto SqlConnection pasando como par�metro la cadena
    Dim objConexion As New SqlConnection(CadenaConexion)

    'Nombre de la tabla.
    Dim objTabla_ As String

    ''' <summary>
    ''' Indica la tabla con la que va a trabajar la instancia.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property objTabla() As String
        Get
            Return objTabla_
        End Get
        Set(ByVal value As String)
            objTabla_ = value
        End Set
    End Property

    ''' <summary>
    ''' Sirve para hacer consultas gen�ricas
    ''' a utilizar en las reglas de negocio.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Consultar() As DataTable

        'Comando SQL
        Dim objComando As String = "SELECT * FROM " & objTabla_

        'Declaramos el objeto DataAdapter
        Dim objDataAdapter As New SqlDataAdapter(objComando, objConexion)

        'Instanciamos un objeto DataTable
        Dim objDataTable As New DataTable

        'Abrimos la conexi�n a la base de datos.
        objConexion.Open()

        Try
            'Intentamos llenar el datatable con el DataAdapter.
            objDataAdapter.Fill(objDataTable)

        Catch ex1 As InvalidOperationException
            MessageBox.Show(ex1.Message)

        Catch ex2 As SqlException
            MessageBox.Show(ex2.Message)

        Finally
            'Cerramos la conexi�n.
            objConexion.Close()

        End Try

        Return objDataTable

    End Function

    ''' <summary>
    ''' Inserta un registro en la tabla especificada.
    ''' </summary>
    ''' <param name="comandoSQL"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Insertar(ByVal comandoSQL As String) As Integer

        'Comando SQL
        Dim objComando As String = "INSERT INTO " & objTabla_ & " " & comandoSQL & "; SELECT SCOPE_IDENTITY()"
        Dim Id As Integer

        Using objConexion As New SqlConnection(CadenaConexion)
            Dim cmd As New SqlCommand(objComando, objConexion)

            'Abrimos la conexi�n a la base de datos.
            objConexion.Open()

            Try
                'Ejecutamos el comando objCommand y se obtiene la devoluci�n
                'de un escalar que representa el Id del �ltimo registro insertado.
                Id = CInt(cmd.ExecuteScalar())

            Catch ex1 As InvalidOperationException
                MessageBox.Show(ex1.Message)

            Catch ex2 As SqlException
                MessageBox.Show(ex2.Message)

            Finally
                'Cerramos la conexi�n.
                objConexion.Close()

            End Try

            objConexion.Close()
        End Using

        Return Id

    End Function

    ''' <summary>
    ''' Elimina el registro de la tabla con el Id indicado.
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <remarks></remarks>
    Public Sub Eliminar(ByVal Id As Integer)
        'Comando SQL
        Dim objComando As String = "DELETE FROM " & objTabla_ & " WHERE ID = @Id"

        Using objConexion As New SqlConnection(CadenaConexion)
            Dim cmd As New SqlCommand(objComando, objConexion)

            'Esto reemplaza el valor de Id en el parametro @ID
            cmd.Parameters.AddWithValue("@ID", Id)

            'Abrimos la conexi�n a la base de datos.
            objConexion.Open()

            Try
                'Intentamos ejecutar el comando SQL.
                cmd.ExecuteNonQuery()

            Catch ex1 As InvalidOperationException
                MessageBox.Show(ex1.Message)

            Catch ex2 As SqlException
                MessageBox.Show(ex2.Message)

            Finally
                'Cerramos la conexi�n.
                objConexion.Close()

            End Try

        End Using
    End Sub

    ''' <summary>
    ''' Actualiza el registro de la tabla con el Id indicado.
    ''' </summary>
    ''' <param name="comandosql"></param>
    ''' <param name="Id"></param>
    ''' <remarks></remarks>
    Public Sub Actualizar(ByVal comandosql As String, ByVal Id As Integer)

        'Comando SQL
        Dim objComando As String = "UPDATE " & objTabla_ & " SET " & comandosql & " WHERE ID = @ID"

        Using objConexion As New SqlConnection(CadenaConexion)

            Dim cmd As New SqlCommand(objComando, objConexion)

            'Esto reemplaza el valor de Id en el parametro @ID
            cmd.Parameters.AddWithValue("@ID", Id)

            'Abrimos la conexi�n a la base de datos.
            objConexion.Open()

            Try
                'Intentamos ejecutar el comando SQL.
                cmd.ExecuteNonQuery()

            Catch ex1 As InvalidOperationException
                MessageBox.Show(ex1.Message)

            Catch ex2 As SqlException
                MessageBox.Show(ex2.Message)

            Finally
                'Cerramos la conexi�n.
                objConexion.Close()

            End Try

        End Using

    End Sub

End Class
