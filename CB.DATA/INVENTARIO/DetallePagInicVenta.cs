//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CB.DATA.INVENTARIO
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetallePagInicVenta
    {
        public int CodPagoInic { get; set; }
        public string CodVenta { get; set; }
        public System.DateTime FechaPago { get; set; }
        public short TipoPago { get; set; }
        public double Monto { get; set; }
        public double MontoBs { get; set; }
        public string Glosa { get; set; }
    
        public virtual TipoPago TipoPago1 { get; set; }
        public virtual Venta Venta { get; set; }
    }
}
