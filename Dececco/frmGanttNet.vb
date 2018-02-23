Imports DlhSoft.ProjectDataControlLibrary

Public Class frmGanttNet

    Private Sub frmGanttNet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerSubproyecto(GanttChartView2)
    End Sub

    Private Sub ObtenerSubproyecto(manager As GanttChartView)
        manager.TasksTreeGrid.Columns.Add("Tareas", "Tareas")
        manager.TasksTreeGrid.Rows.Add()
        manager.TasksTreeGrid.Rows(0).Cells(0).Value = "20"
    End Sub

    'private void ObtenerSubproyectos(GanttChartDataGrid manager, GanttChartItem proyecto_padre, int id_subproyecto)
    '    {
    '        DataTable subproyectos;
    '        subproyectos = ObtenerPorProyecto(0, id_subproyecto);
    '        foreach (DataRow row_subproyecto in subproyectos.Rows)
    '        {
    '            GanttChartItem subproject = new GanttChartItem();
    '            subproject.Content = row_subproyecto["nombre"].ToString();
    '            subproject.AssignmentsContent = row_subproyecto["nombre"].ToString();
    '            manager.Items.Add(subproject);
    '            //_mManager.SetDuration(subproject, 3);
    '            //subproject.Complete = 0.5f;
    '            //subproject.IsCollapsed = true;
    '            //var span3 = Convert.ToDateTime(row_subproyecto["fecha_fin_estimada"]) - DateTime.Today;
    '            //_mManager.SetDuration(subproject, (int)Math.Round(span3.TotalDays));
    '            //manager.Group(proyecto_padre, subproject);
    '            subproject.Start = Convert.ToDateTime(row_subproyecto["fecha_inicio_estimada"]);
    '            subproject.Finish = Convert.ToDateTime(row_subproyecto["fecha_fin_estimada"]);


    '            if (proyecto_padre != null)
    '            {
    '                subproject.Predecessors.Add(new PredecessorItem { Item = proyecto_padre });
    '                subproject.Indentation = proyecto_padre.Indentation + 1;
    '            }
    '    Else
    '            {
    '                subproject.Indentation = 1;
    '            }


    '            if (ObtenerPorProyecto(0, Convert.ToInt32(row_subproyecto["id_subproyecto"])).Rows.Count > 0)
    '            {
    '                ObtenerSubproyectos(manager, subproject, Convert.ToInt32(row_subproyecto["id_subproyecto"]));
    '            }

    '            ObtenerActividades(manager, subproject, Convert.ToInt32(row_subproyecto["id_subproyecto"]));
    '        }

    '    }
End Class