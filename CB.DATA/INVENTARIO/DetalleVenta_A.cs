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
    
    public partial class DetalleVenta_A
    {
        public string CodVenta { get; set; }
        public string CodProducto { get; set; }
        public string NombreProducto { get; set; }
        public int TipoCliente { get; set; }
        public double PrecioUnitario { get; set; }
        public double PrecioBs { get; set; }
        public double Cantidad { get; set; }
        public double PorcentajeDescuento { get; set; }
        public double MontoDescuento { get; set; }
        public double DescuentoBs { get; set; }
        public int Devuelto { get; set; }
        public int CantidadDevueltos { get; set; }
        public System.DateTime FechaReg { get; set; }
        public string IdUsua { get; set; }
        public int Item { get; set; }
    
        public virtual Venta_A Venta_A { get; set; }
    }
}
