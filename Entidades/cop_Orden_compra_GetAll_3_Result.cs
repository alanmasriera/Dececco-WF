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
    
    public partial class cop_Orden_compra_GetAll_3_Result
    {
        public int id_orden_compra { get; set; }
        public Nullable<System.DateTime> fecha_orden_compra { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string observacion { get; set; }
        public string acepto_orden_compra { get; set; }
        public Nullable<decimal> total_orden_compra { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public int id_presupuesto { get; set; }
    }
}