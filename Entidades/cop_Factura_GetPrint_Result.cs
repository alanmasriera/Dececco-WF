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
    
    public partial class cop_Factura_GetPrint_Result
    {
        public int id_cuerpo_factura { get; set; }
        public int id_factura { get; set; }
        public string NUMERO { get; set; }
        public string REMITO { get; set; }
        public System.DateTime fecha_factura { get; set; }
        public Nullable<bool> anulada { get; set; }
        public Nullable<decimal> subtotal_factura { get; set; }
        public Nullable<bool> responsable_inscripto { get; set; }
        public Nullable<bool> responsable_no_inscripto { get; set; }
        public Nullable<bool> contado { get; set; }
        public Nullable<bool> cuenta_corriente { get; set; }
        public Nullable<decimal> impuesto { get; set; }
        public string condicion_pago { get; set; }
        public string referencia { get; set; }
        public Nullable<int> id_item { get; set; }
        public Nullable<decimal> cantidad_item { get; set; }
        public Nullable<int> nro_item { get; set; }
        public Nullable<decimal> precio_item { get; set; }
        public string descripcion_item { get; set; }
        public Nullable<decimal> total_iva { get; set; }
        public Nullable<decimal> total_factura { get; set; }
        public string total_letra { get; set; }
        public string nombre_cliente { get; set; }
        public string contacto { get; set; }
        public string dni_cliente { get; set; }
        public Nullable<int> id_calle { get; set; }
        public string direccion_cliente { get; set; }
        public Nullable<int> id_localidad { get; set; }
        public Nullable<int> id_provincia { get; set; }
        public string telefono { get; set; }
        public string mail { get; set; }
        public string web { get; set; }
        public string ingreso_bruto { get; set; }
        public Nullable<int> id_condicion_iva { get; set; }
    }
}
