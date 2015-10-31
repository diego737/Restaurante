Imports System.IO

Module ModuloPrincipal

    Public asignaturas_list As AsignaturasCollection
    Public carreras_list As CarrerasCollection
    Public disponibilidades_list As DisponibilidadesCollection
    Public docentes_list As DocentesCollection
    Public horarios_list As HorariosCollection
    Public modulos_list As ModuloCollection

    Sub Main()
        asignaturas_list = New AsignaturasCollection
        disponibilidades_list = New DisponibilidadesCollection
        horarios_list = New HorariosCollection
        horarios_list.TraerHorarios()
        modulos_list = New ModuloCollection
        carreras_list = New CarrerasCollection

        'Application.EnableVisuadocentes_listyles()
        Application.Run(MenuForm)
    End Sub

End Module
