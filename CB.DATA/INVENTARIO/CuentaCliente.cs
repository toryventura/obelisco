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
    
    public partial class CuentaCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuentaCliente()
        {
            this.CuentaClienteMovs = new HashSet<CuentaClienteMov>();
        }
    
        public string CodCliente { get; set; }
        public int CodCuenta { get; set; }
        public System.DateTime FechaIng { get; set; }
        public string Observacion { get; set; }
        public string CodUsua { get; set; }
        public int CodSucursal { get; set; }
        public int Disponible { get; set; }
        public System.DateTime FechaReg { get; set; }
        public string CodReg { get; set; }
        public int Consolidado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaClienteMov> CuentaClienteMovs { get; set; }
    }
}
