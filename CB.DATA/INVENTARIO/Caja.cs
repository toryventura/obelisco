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
    
    public partial class Caja
    {
        public string CodCajaIng { get; set; }
        public int CodSucCaja { get; set; }
        public string CodCliente { get; set; }
        public string Cliente { get; set; }
        public Nullable<int> TipoDoc { get; set; }
        public string CodDoc { get; set; }
        public int CodSucursal { get; set; }
        public System.DateTime Fecha { get; set; }
        public double TC { get; set; }
        public string CodUsuario { get; set; }
        public string NroTesoreria { get; set; }
        public string Concepto { get; set; }
        public Nullable<double> SaldoAnterior { get; set; }
        public double MontoSus { get; set; }
        public double MontoBs { get; set; }
        public string NroCheque { get; set; }
        public string BancoCheque { get; set; }
        public Nullable<double> MontoChequeSus { get; set; }
        public Nullable<double> MontoChequeBs { get; set; }
        public string TipoTarjeta { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public string NroAutorizacion { get; set; }
        public Nullable<double> MontoTarjetaSus { get; set; }
        public Nullable<double> MontoTarjetaBs { get; set; }
        public Nullable<double> CtaSus { get; set; }
        public Nullable<double> Saldo { get; set; }
        public Nullable<System.DateTime> HoraIn { get; set; }
        public Nullable<System.DateTime> FechaReg { get; set; }
        public string CodReg { get; set; }
        public Nullable<int> Consolidado { get; set; }
        public int ComprIngreso { get; set; }
        public string CodGestion { get; set; }
        public string TipoComp { get; set; }
        public string CodCtaxPagar { get; set; }
    
        public virtual Documento Documento { get; set; }
    }
}