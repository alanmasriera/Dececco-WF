using System;
using System.Collections.Generic;
using Entidades;
using System.Data;
using System.IO;

namespace ControladoresLogica
{
    public abstract class AControladorProyecto
    {
        public abstract bool AsignarMiembros(List<USUARIO> usuarios, int idProyecto);

        
        public static void GenerarCarpetasProyecto(string path, int id_proyecto, int? id_subproyecto, bool esProyecto)
        {
            var subproyectosHijos = new List<SUBPROYECTO>();

            if (esProyecto)
            {
                path = path + "/" + ControladorProyecto.ObtenerPorID(id_proyecto).nombre_proyecto;
                Directory.CreateDirectory(path); 
            }
            subproyectosHijos = ControladorSubproyecto.ObtenerPorProyecto(id_proyecto, id_subproyecto);
            if (subproyectosHijos.Count > 0)
            {
                foreach (var subproyecto in subproyectosHijos)
                {
                    Directory.CreateDirectory(path + "/" + subproyecto.nombre);
                    GenerarCarpetasProyecto(path + "/" + subproyecto.nombre, id_proyecto, subproyecto.id_subproyecto, false);
                }
            }
        }



    }
}