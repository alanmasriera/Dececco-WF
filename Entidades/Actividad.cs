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
    
    public partial class Actividad
    {
        private decimal? criticidad;

        public Actividad()
        {

        }
        public Actividad(decimal? criticidad, int idTipoActividad, string nombre, int v)
        {
            this.criticidad = criticidad;
            this.id_tipo_actividad = idTipoActividad;
            this.nombre_actividad = nombre;
            this.costo_standart = v;
        }

        public int id_actividad { get; set; }
        public string nombre_actividad { get; set; }
        public Nullable<decimal> tiempo_standart { get; set; }
        public Nullable<decimal> costo_standart { get; set; }
        public Nullable<int> id_tipo_actividad { get; set; }
    }
}
