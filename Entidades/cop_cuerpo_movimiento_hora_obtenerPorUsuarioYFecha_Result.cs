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
    
    public partial class cop_cuerpo_movimiento_hora_obtenerPorUsuarioYFecha_Result
    {
        public int id_cuerpo_movimiento_hora { get; set; }
        public int id_movimiento_hora { get; set; }
        public Nullable<int> id_actividad_proyecto { get; set; }
        public Nullable<System.DateTime> Entrada { get; set; }
        public Nullable<System.DateTime> Salida { get; set; }
        public string Proyecto { get; set; }
        public string Actividad { get; set; }
        public string Subproyecto { get; set; }
        public string Tipo { get; set; }
    }
}
