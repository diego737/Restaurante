Option Strict On

Imports System.Data
Imports System.Data.SqlClient

Public Class BaseDatosClass

    'Declaramos el string de conexión.
    Dim CadenaConexion As String = "Data Source=.\SQLEXPRESS; DataBase=horarios; User=sa; Password=carena"

    'Instaciamos un objeto SqlConnection pasando como parámetro la cadena
    Dim objConexion As New SqlConnection(CadenaConexion)

    'Nombre de la tabla.
    Dim objTabla_ As String

    Public Property objTabla() As String
        Get
            Return objTabla_
        End Get
        Set(ByVal value As String)
            objTabla_ = value
        End Set
    End Property

    Public Function Consultar() As DataTable

        'Comando SQL
        Dim objComando As String = "SELECT * FROM " & objTabla_

        'Declaramos el objeto DataAdapter
        Dim objDataAdapter As New SqlDataAdapter(objComando, objConexion)

        'Instanciamos un objeto DataTable
        Dim objDataTable As New DataTable

        'Abrimos la conexión a la base de datos con control de excepciones (errores).
        Try
            objConexion.Open()
            'MessageBox.Show("Conexión correcta.")

        Catch ex1 As InvalidOperationException
            MessageBox.Show(ex1.Message)

        Catch ex2 As SqlException
            MessageBox.Show(ex2.Message)

        Finally
            'Llenamos el datatable con el DataAdapter.
            objDataAdapter.Fill(objDataTable)

            'Cerramos la conexión.
            objConexion.Close()

        End Try

        Return objDataTable
    End Function

    Public Function Insertar(ByVal objDataRow As DataRow) As Integer

        'Comando SQL
        Dim objComando As String = "SELECT * FROM " & objTabla_

        'Declaramos el objeto DataAdapter
        Dim objDataAdapter As New SqlDataAdapter(objComando, objConexion)

        'Instanciamos un objeto DataTable
        Dim objDataTable As New DataTable

        Dim objCommandBuilder As New SqlCommandBuilder(objDataAdapter)

        objDataAdapter.Fill(objDataTable)

        Dim dr As DataRow = objDataTable.NewRow

        objDataTable.Rows.Add(objDataAdapter)

        objDataAdapter.Update(objDataTable)

        Return CInt(dr("ID"))
    End Function

    Public Sub Eliminar(ByVal Id As Integer)
        'Comando SQL
        Dim objComando As String = "DELETE FROM " & objTabla_ & " WHERE ID = @ID"

        'Declaramos el objeto DataAdapter
        Dim objDataAdapter As New SqlDataAdapter(objComando, objConexion)

        'Instanciamos un objeto DataTable
        Dim objDataTable As New DataTable

        Using objConexion As New SqlConnection(CadenaConexion)
            Dim cmd As New SqlCommand(objComando, objConexion)

            cmd.Parameters.AddWithValue("@ID", id)

            objConexion.Open()

            cmd.ExecuteNonQuery()

            objConexion.Close()
        End Using
    End Sub

    Public Sub Actualizar(ByVal fila As Object, ByVal Id As Integer)
        'Comando SQL
        Dim objComando As String = "SELECT * FROM " & objTabla_ & " WHERE ID = @ID"

        'Declaramos el objeto DataAdapter
        Dim objDataAdapter As New SqlDataAdapter(objComando, objConexion)

        'Instanciamos un objeto DataTable
        Dim objDataTable As New DataTable

        Dim sCon As String = CadenaConexion
        Dim sel As String

        sel = "UPDATE " & objTabla_ & _
            " SET Nombre = @Nombre, Apellidos = @Apellidos, Email = @Email, Fecha = @Fecha" & _
            " WHERE ID = @ID"

        'Using con As New SqlConnection(sCon)
        '    Dim cmd As New SqlCommand(sel, con)
        '    cmd.Parameters.AddWithValue("@ID", Id)
        '    cmd.Parameters.AddWithValue("@Nombre", nombre)
        '    cmd.Parameters.AddWithValue("@Apellidos", apellidos)
        '    cmd.Parameters.AddWithValue("@Email", email)
        '    cmd.Parameters.AddWithValue("@Fecha", fecha)

        '    con.Open()
        '    Dim t As Integer = cmd.ExecuteNonQuery()
        '    con.Close()

        '    'Console.WriteLine("Filas actualizadas: {0}", t)
        'End Using
    End Sub

End Class

Public Class BaseDatosException
    Inherits ApplicationException

    Public Sub New(ByVal mensaje As String, ByVal original As Exception)
        MyBase.New(mensaje, original)
    End Sub

    Public Sub New(ByVal mensaje As String)
        MyBase.New(mensaje)
    End Sub
End Class
