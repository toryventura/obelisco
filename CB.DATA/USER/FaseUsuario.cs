//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CB.DATA.USER
{
    using System;
    using System.Collections.Generic;
    
    public partial class FaseUsuario
    {
        public int IDfaseusuario { get; set; }
        public Nullable<int> Idfase { get; set; }
        public Nullable<int> Idusuario { get; set; }
    
        public virtual Fase Fase { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
