using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Entidades
{
    
    public class AvanceSubproyecto
    {
        public SUBPROYECTO subproyecto  { get; set; }
        public USUARIO responsableProduccion { get; set; }
        public USUARIO responsableCalidad { get; set; }
        public bool completado { get; set; }
        public bool completado_produccion { get; set; }
        public bool completado_control { get; set; }
        public bool completado_correccion_1 { get; set; }
        public Actividad_proyecto actividad_proyecto { get; set; }
        public USUARIO responsableCorreccion { get; set; }

    }
}
