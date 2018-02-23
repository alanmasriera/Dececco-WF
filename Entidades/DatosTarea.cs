using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatosTarea
    {
        public SUBPROYECTO subproyecto { get; set; }
        public Proyecto proyecto { get; set; }
        public Actividad actividad { get; set; }
        public Actividad_proyecto actividad_proyecto { get; set; }
        public Detalle_recurso tarea { get; set; }
    }
}
