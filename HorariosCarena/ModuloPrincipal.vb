Imports System.IO

Module ModuloPrincipal

    Public asignaturas_list As AsignaturasCollection
    'Public carreras_list As CarreaCollection
    Public disponibilidades_list As DisponibilidadesCollection
    Public docentes_list As DocentesCollection
    Public horarios_list As HorariosCollection
    Public modulos_list As ModuloCollection

    Sub Main()
        asignaturas_list = New AsignaturasCollection
        docentes_list = New DocentesCollection
        disponibilidades_list = New DisponibilidadesCollection
        horarios_list = New HorariosCollection
        modulos_list = New ModuloCollection
        'carreras_list = New CarreraCollection

        'Application.EnableVisuadocentes_listyles()
        Application.Run(MenuForm)
    End Sub

End Module
