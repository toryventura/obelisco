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
    
    public partial class detalleventa1
    {
        public string CodVenta { get; set; }
        public string CodProducto { get; set; }
        public string NombreProducto { get; set; }
        public int TipoCliente { get; set; }
        public Nullable<double> PrecioUnitario { get; set; }
        public Nullable<double> PrecioBs { get; set; }
        public int Cantidad { get; set; }
        public int PorcentajeDescuento { get; set; }
        public int MontoDescuento { get; set; }
        public int DescuentoBs { get; set; }
        public int Devuelto { get; set; }
        public int CantidadDevueltos { get; set; }
        public string FechaReg { get; set; }
        public string IdUsua { get; set; }
        public int Item { get; set; }
    }
}