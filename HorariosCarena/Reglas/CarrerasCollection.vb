Imports System.Data.SqlClient

Imports System.ComponentModel

Public Class CarrerasCollection
    Inherits BindingList(Of CarreraClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)

        e.NewObject = New CarreraClass()

    End Sub

End Class

