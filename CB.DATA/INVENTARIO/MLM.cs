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
    
    public partial class MLM
    {
        public string CodPadre { get; set; }
        public string CodHijo { get; set; }
        public System.DateTime FIni { get; set; }
        public Nullable<System.DateTime> FFin { get; set; }
        public string Obs { get; set; }
        public Nullable<bool> Activo { get; set; }
        public string UsuaReg { get; set; }
        public System.DateTime FechaReg { get; set; }
        public string UsuaModif { get; set; }
        public System.DateTime FechaModif { get; set; }
    
        public virtual Persona Persona { get; set; }
        public virtual Persona Persona1 { get; set; }
    }
}
