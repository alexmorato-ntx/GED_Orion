//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACSMinCapture.DataBase.ModelOracle
{
    using System;
    using System.Collections.Generic;
    
    public partial class GEDPERFIS
    {
        public GEDPERFIS()
        {
            this.GEDPERFISXOBJETOS = new HashSet<GEDPERFISXOBJETOS>();
            this.GEDPERFISXUSUARIOS = new HashSet<GEDPERFISXUSUARIOS>();
        }
    
        public decimal PRF_IDPERFIL { get; set; }
        public Nullable<decimal> PRF_IDGRUPOUSUARIO { get; set; }
        public Nullable<decimal> PRF_IDUNIDADE { get; set; }
        public string PRF_DESCRICAO { get; set; }
    
        public virtual GEDGRUPOSUSUARIOS GEDGRUPOSUSUARIOS { get; set; }
        public virtual GEDUNIDADES GEDUNIDADES { get; set; }
        public virtual ICollection<GEDPERFISXOBJETOS> GEDPERFISXOBJETOS { get; set; }
        public virtual ICollection<GEDPERFISXUSUARIOS> GEDPERFISXUSUARIOS { get; set; }
    }
}
