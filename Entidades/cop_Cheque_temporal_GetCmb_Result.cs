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
    
    public partial class cop_Cheque_temporal_GetCmb_Result
    {
        public int id_pk { get; set; }
        public int id_cheque { get; set; }
        public string tipo_cheque { get; set; }
        public Nullable<bool> control { get; set; }
        public string numero_cheque { get; set; }
        public Nullable<decimal> importe_cheque { get; set; }
        public string detalle { get; set; }
        public Nullable<System.DateTime> fecha_1 { get; set; }
        public Nullable<System.DateTime> fecha_2 { get; set; }
        public Nullable<System.DateTime> fecha_3 { get; set; }
        public string nombre_banco { get; set; }
        public string cliente_proveedor { get; set; }
        public Nullable<bool> vendido { get; set; }
    }
}
