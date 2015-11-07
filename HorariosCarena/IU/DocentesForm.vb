Public Class DocentesForm
    Dim operacion_ As String
    Dim MiDocente As New DocenteClass

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
  

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'MiDocente.Id = CInt(TextBox1.Text)
        MiDocente.Nombres = NOMBRE.Text
        MiDocente.Apellidos = APELLIDO.Text
        MiDocente.Correo = CORREO_STR.Text

        Select Case operacion_
            Case "Alta"
                If TextBox1.Text Is Nothing Then Exit Sub

                If NOMBRE.Text Is Nothing Then Exit Sub

                If APELLIDO.Text Is Nothing Then Exit Sub

                If CORREO_STR.Text Is Nothing Then Exit Sub

                docentes_list.InsertarDocente(MiDocente)

            Case "Elimina"

                docentes_list.EliminarDocente(MiDocente)

            Case "Modifica"

                docentes_list.ActualizarDocente(MiDocente)
                DocentesGrid.DataGridView1.Refresh()

        End Select

        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

   
    Private Sub NOMBRE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NOMBRE.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    
    Private Sub APELLIDO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles APELLIDO.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CORREO_STR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CORREO_STR.KeyPress
     
        Select Case e.KeyChar
            Case CChar("a") To CChar("z")


            Case CChar(".")

                If CORREO_STR.TextLength = 0 Then Exit Sub

                Dim correo, pto As String

                correo = CORREO_STR.Text

                pto = correo.Substring(correo.Length - 1, 1)


                If pto = "." Then
                    e.Handled = True
                End If

            Case CChar("@")

                Dim correo, arro As String

                correo = CORREO_STR.Text

                arro = correo.Substring(correo.Length - 1, 1)


                If arro = "@" Then
                    e.Handled = True
                End If

            Case CChar("_"), CChar("-")

                e.Handled = False

            Case Else


                'If Char.IsControl(e.KeyChar) Then
                '    e.Handled = False
                'Else
                '    e.Handled = True
                'End If



        End Select

    End Sub

    Private Sub CORREO_STR_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CORREO_STR.LostFocus
        
        Dim correo, cuenta, dominio As String
        Dim arroba, punto As Integer
        Dim ente(10) As String

        ente(0) = ".com"
        ente(1) = ".org"
        ente(2) = ".net"
        ente(3) = ".edu"
        ente(4) = ".gov"
        ente(5) = ".gob"
        ente(6) = ".mil"
        ente(7) = ".inf"
        ente(8) = ".tur"
        ente(9) = ".ar"
        ente(10) = ""
        correo = CORREO_STR.Text

        arroba = correo.IndexOf("@")

        If arroba = -1 Then
            MsgBox("falta arroba")
            TextBox1.Focus()
            Exit Sub
        End If

       
        cuenta = correo.Substring(0, arroba)
        dominio = correo.Substring(arroba + 1)


        punto = dominio.IndexOf(".")

        If punto = -1 Then
            TextBox1.Focus()
            MsgBox("Falta el punto en el dominio.")
            Exit Sub
        End If

        Dim ult, pri As String


        pri = correo.Substring(0, 1)

        ult = correo.Substring(correo.Length - 1)

        If pri = "@" Then
            MsgBox("No puede comenzar con arroba.")
            TextBox1.Focus()
            Exit Sub
        End If

        If ult = "@" Then
            MsgBox("No puede terminar con arroba.")
            TextBox1.Focus()
            Exit Sub
        End If

        If pri = "." Then
            MsgBox("No puede comenzar con punto.")
            TextBox1.Focus()
            Exit Sub
        End If

        If ult = "." Then
            MsgBox("No puede terminar con punto.")
            TextBox1.Focus()
            Exit Sub
        End If

        Dim x, ext As Integer

        For x = 0 To 8

            ext = dominio.IndexOf(ente(x))


            If ext > 0 Then
                Exit For
            End If
        Next

        If ext = -1 Then
            MsgBox("falta terminacion o terminacion inválida")
            TextBox1.Focus()
            Exit Sub
        End If



    End Sub

    Private Sub DocentesForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If operacion_ <> "Alta" Then
            MiDocente.Id = CInt(TextBox1.Text)
            MiDocente.Nombres = NOMBRE.SelectedText
            MiDocente.Apellidos = APELLIDO.SelectedText
            MiDocente.Correo = CORREO_STR.SelectedText
        End If
    End Sub
End Class