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
    
    public partial class cop_Pago_iva_GetCmb_Result
    {
        public int id_pago_Iva { get; set; }
        public Nullable<System.DateTime> fecha_pago_Iva { get; set; }
        public Nullable<decimal> pago_Iva { get; set; }
        public string numero_recibo_pago_Iva { get; set; }
        public int id_empresa { get; set; }
        public int id_Iva { get; set; }
        public Nullable<bool> efectivo_Iva { get; set; }
        public string numero_cheque_Iva { get; set; }
        public Nullable<System.DateTime> fecha_emision_cheque_Iva { get; set; }
        public Nullable<System.DateTime> fecha_pago_cheque_Iva { get; set; }
        public string detalle_cheque_Iva { get; set; }
        public string detalle_pago { get; set; }
    }
}
