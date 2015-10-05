Imports System.ComponentModel

Public Class CarreraCollection

    Inherits BindingList(Of CarreraClass)
    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New CarreraCollection
    End Sub

End Class
