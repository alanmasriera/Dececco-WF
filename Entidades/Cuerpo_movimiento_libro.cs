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
    
    public partial class Cuerpo_movimiento_libro
    {
        public int id_cuerpo_movimiento_libro { get; set; }
        public Nullable<int> id_cuenta_imputable { get; set; }
        public Nullable<decimal> debe { get; set; }
        public Nullable<decimal> haber { get; set; }
        public Nullable<int> id_movimiento_libro { get; set; }
        public Nullable<int> id_usuario { get; set; }
    }
}