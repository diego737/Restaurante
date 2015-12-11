Imports System.IO

'Este módulo se declara como inicial en las propiedades del proyecto para
'que de esta forma las listas permanezcan visibles y cargadas con los datos
'provenientes de la base de datos horarios.
Module ModuloPrincipal

    'Declaro públicas las listas para que se van a utilizar en el proyecto.
    'Se van a ver en todo el proyecto.
    Public asignaturas_list As AsignaturasCollection
    Public carreras_list As CarrerasCollection
    Public disponibilidades_list As DisponibilidadesCollection
    Public docentes_list As DocentesCollection
    Public horarios_list As HorariosCollection
    Public modulos_list As ModuloCollection

    Sub Main()
        'Se crean las instancias u objetos de cada colección.
        'Las listas estan creadas pero no contienen datos hasta el momento.
        asignaturas_list = New AsignaturasCollection
        disponibilidades_list = New DisponibilidadesCollection
        horarios_list = New HorariosCollection
        modulos_list = New ModuloCollection
        carreras_list = New CarrerasCollection
        docentes_list = New DocentesCollection

        'Carga el MenuForm.
        Application.Run(MenuForm)
    End Sub

End Module
