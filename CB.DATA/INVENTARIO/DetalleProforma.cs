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
    
    public partial class DetalleProforma
    {
        public string CodProforma { get; set; }
        public string CodProducto { get; set; }
        public string NombreProducto { get; set; }
        public int TipoCliente { get; set; }
        public double Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double PrecioBs { get; set; }
        public double PorcentajeDescuento { get; set; }
        public double MontoDescuento { get; set; }
        public double DescuentoBs { get; set; }
    }
}