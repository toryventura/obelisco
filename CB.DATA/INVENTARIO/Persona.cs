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
    
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            this.CategoriaVendedorHs = new HashSet<CategoriaVendedorH>();
            this.MLMs = new HashSet<MLM>();
            this.MLMs1 = new HashSet<MLM>();
            this.ProveedorProductoes = new HashSet<ProveedorProducto>();
            this.Rendicions = new HashSet<Rendicion>();
            this.TipoClientes = new HashSet<TipoCliente>();
            this.Usuarios = new HashSet<Usuario>();
        }
    
        public string CodCliente { get; set; }
        public string NIT { get; set; }
        public string CI { get; set; }
        public string CodCuenta { get; set; }
        public string NombreP { get; set; }
        public string Apellido { get; set; }
        public string Seg_Apellido { get; set; }
        public string Contacto { get; set; }
        public string Ciudad { get; set; }
        public string DireccionDomicilio { get; set; }
        public string DireccionTrabajo { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Correo { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public int Estado { get; set; }
        public int EsUsuario { get; set; }
        public int IdArea { get; set; }
        public int EsCliente { get; set; }
        public int EsProveedor { get; set; }
        public int EsVendedor { get; set; }
        public int EsAlmacenero { get; set; }
        public int EsCajero { get; set; }
        public int SolicitaPedido { get; set; }
        public int AutorizaPedido { get; set; }
        public int AutorizaCotizacion { get; set; }
        public int SolicitaOCompra { get; set; }
        public int RevisaOCompra { get; set; }
        public int AutorizaOCompra { get; set; }
        public string UsuaReg { get; set; }
        public System.DateTime FechaReg { get; set; }
        public double LimiteCredito { get; set; }
        public string Ccosto { get; set; }
        public string CodSubcc { get; set; }
        public int Consolidado { get; set; }
        public string Vendedor { get; set; }
        public int DiasCredito { get; set; }
        public int TipoPrecio { get; set; }
        public string NombreFactura { get; set; }
        public string NomCorto { get; set; }
        public string clave { get; set; }
        public bool EsVendedorF { get; set; }
        public bool EmiteFactura { get; set; }
        public Nullable<int> CodEstado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriaVendedorH> CategoriaVendedorHs { get; set; }
        public virtual FondoFijo FondoFijo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MLM> MLMs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MLM> MLMs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProveedorProducto> ProveedorProductoes { get; set; }
        public virtual TipoEstado TipoEstado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rendicion> Rendicions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoCliente> TipoClientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
