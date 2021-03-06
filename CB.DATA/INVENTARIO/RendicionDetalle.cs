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
    
    public partial class RendicionDetalle
    {
        public int CodRendicion { get; set; }
        public int NumItem { get; set; }
        public System.DateTime FechaItem { get; set; }
        public int TipoRend { get; set; }
        public bool TieneIVA { get; set; }
        public bool EsCombustible { get; set; }
        public string NroDocRend { get; set; }
        public string Glosa { get; set; }
        public double Bs { get; set; }
        public double Sus { get; set; }
        public string CodCuenta { get; set; }
        public string CodProveedor { get; set; }
        public string NIT { get; set; }
        public string RazonSocial { get; set; }
        public long NroAutorizacion { get; set; }
        public string CodControl { get; set; }
        public double Excentos { get; set; }
        public double ICE { get; set; }
        public double ImpNetoIVA { get; set; }
        public string UsuaReg { get; set; }
        public Nullable<System.DateTime> FechaReg { get; set; }
        public string UsuaModif { get; set; }
        public Nullable<System.DateTime> FechaModif { get; set; }
        public string CCosto { get; set; }
        public string SubCCosto { get; set; }
        public string CodCliente { get; set; }
        public Nullable<int> GastoARecuperar { get; set; }
        public string CodRendicionGasto { get; set; }
        public int CodGasto { get; set; }
    
        public virtual Rendicion Rendicion { get; set; }
        public virtual TipoRendicion TipoRendicion { get; set; }
        public virtual TipoRendicion TipoRendicion1 { get; set; }
    }
}
