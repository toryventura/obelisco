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
    
    public partial class Cotizacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cotizacion()
        {
            this.CotizacionDetalles = new HashSet<CotizacionDetalle>();
        }
    
        public string CodCtz { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.DateTime FechaLimValidez { get; set; }
        public float TC { get; set; }
        public int Moneda { get; set; }
        public string CodCtzAnt { get; set; }
        public string CodPedido { get; set; }
        public string Glosa { get; set; }
        public string AutorizadoPor { get; set; }
        public System.DateTime FechaAuroriz { get; set; }
        public short Estado { get; set; }
        public System.DateTime FechaReg { get; set; }
        public string IdUsua { get; set; }
        public System.DateTime FechaMod { get; set; }
        public string IdUsuaMod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionDetalle> CotizacionDetalles { get; set; }
    }
}
