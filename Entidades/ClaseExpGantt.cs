using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseExpGantt
    {
        public int nivel { get; set; }
        public SUBPROYECTO subproyecto { get; set; }

        public Actividad_proyecto actividadProy { get; set; }

        public Actividad actividad { get; set; }

        public Detalle_recurso tarea { get; set; }

        public USUARIO usuario { get; set; }

    }
}
