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
    
    public partial class RendicionCliente
    {
        public string CodRendicionCliente { get; set; }
        public string CodCliente { get; set; }
        public System.DateTime Fecha { get; set; }
        public string CodCuenta { get; set; }
        public string CodCcosto { get; set; }
        public string CodSubCcosto { get; set; }
        public decimal MontoBs { get; set; }
        public decimal MontoSus { get; set; }
        public bool EsFacturado { get; set; }
        public string nroFac { get; set; }
        public string CodCtaxCobrar { get; set; }
        public int CodComp { get; set; }
        public string CodGestion { get; set; }
        public string TipoComp { get; set; }
        public Nullable<System.DateTime> FechaReg { get; set; }
        public string UsuarioReg { get; set; }
        public bool TieneITF { get; set; }
        public bool TieneComision { get; set; }
        public double PorcComision { get; set; }
    }
}
