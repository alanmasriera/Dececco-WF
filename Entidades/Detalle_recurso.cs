//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detalle_recurso
    {
        public int id_detalle_recurso { get; set; }
        public Nullable<int> id_actividad_proyecto { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public Nullable<decimal> cantidad_hora { get; set; }
        public Nullable<decimal> porcentaje_avance { get; set; }
        public string motivo { get; set; }
        public string tipo { get; set; }
        public Nullable<bool> realizada { get; set; }
        public bool forzada { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_fin { get; set; }
        public Nullable<int> id_estado { get; set; }
        public Nullable<decimal> duracion_cadista { get; set; }
        public Nullable<System.DateTime> fecha_inicio_cadista { get; set; }
        public Nullable<System.DateTime> fecha_fin_cadista { get; set; }
    }
}
