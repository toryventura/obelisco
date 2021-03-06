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
    
    public partial class Contrato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contrato()
        {
            this.Clausulas = new HashSet<Clausula>();
        }
    
        public int contratoID { get; set; }
        public string descripcion_contrato { get; set; }
        public int tipo_contratoID { get; set; }
        public string tipo_transaccion { get; set; }
        public Nullable<int> proyectoID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clausula> Clausulas { get; set; }
        public virtual Proyecto Proyecto { get; set; }
        public virtual TipoContrato TipoContrato { get; set; }
    }
}
