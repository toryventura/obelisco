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
    
    public partial class PedidoDetalle
    {
        public string CodPedido { get; set; }
        public string CodProducto { get; set; }
        public double CantPedida { get; set; }
        public double CantAutorizada { get; set; }
        public double PrecioPropuesto { get; set; }
        public double PrecioPropuestoSus { get; set; }
        public string Observacion { get; set; }
    
        public virtual Pedido Pedido { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
