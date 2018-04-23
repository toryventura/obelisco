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
    
    public partial class FlujoEfectivo
    {
        public int NroFlujo { get; set; }
        public string NroTesoreria { get; set; }
        public int NroTesoreriaTrans { get; set; }
        public System.DateTime Fecha { get; set; }
        public int TipoDoc { get; set; }
        public Nullable<decimal> NroCheque { get; set; }
        public string TipoMov { get; set; }
        public string Responsable { get; set; }
        public string Concepto { get; set; }
        public decimal MontoBs { get; set; }
        public decimal MontoSus { get; set; }
        public string CodCuentaFlujo { get; set; }
        public int CodComp { get; set; }
        public string CodGestion { get; set; }
        public string TipoComp { get; set; }
        public System.DateTime FechaReg { get; set; }
        public string UsuaReg { get; set; }
        public System.DateTime FechaModif { get; set; }
        public string UsuaModif { get; set; }
    
        public virtual PlanCuentaFlujo PlanCuentaFlujo { get; set; }
        public virtual Tesoreria Tesoreria { get; set; }
    }
}