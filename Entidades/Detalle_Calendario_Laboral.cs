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
    
    public partial class Detalle_Calendario_Laboral
    {
        public int id_detalle_calendario_laboral { get; set; }
        public int id_definicion_calendario_laboral { get; set; }
        public int id_dia { get; set; }
        public bool importa_base { get; set; }
        public Nullable<bool> no_laborable { get; set; }
        public Nullable<System.TimeSpan> hora_desde_1 { get; set; }
        public Nullable<System.TimeSpan> hora_hasta_1 { get; set; }
        public Nullable<System.TimeSpan> hora_desde_2 { get; set; }
        public Nullable<System.TimeSpan> hora_hasta_2 { get; set; }
        public Nullable<System.TimeSpan> hora_desde_3 { get; set; }
        public Nullable<System.TimeSpan> hora_hasta_3 { get; set; }
        public Nullable<System.TimeSpan> hora_desde_4 { get; set; }
        public Nullable<System.TimeSpan> hora_hasta_4 { get; set; }
        public Nullable<System.TimeSpan> hora_desde_5 { get; set; }
        public Nullable<System.TimeSpan> hora_hasta_5 { get; set; }
    
        public virtual Definicion_Calendario_Laboral Definicion_Calendario_Laboral { get; set; }
        public virtual Dia Dia { get; set; }
    }
}
