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
    
    public partial class GEDAREAS
    {
        public GEDAREAS()
        {
            this.GEDDIVISOES = new HashSet<GEDDIVISOES>();
            this.GEDTIPOCLIENTE = new HashSet<GEDTIPOCLIENTE>();
            this.GEDUNIDADEXAREAS = new HashSet<GEDUNIDADEXAREAS>();
        }
    
        public decimal ARE_IDAREA { get; set; }
        public string ARE_DESCRICAO { get; set; }
        public Nullable<decimal> ARE_IDLABELGENERICO { get; set; }
    
        public virtual GEDLABELGENERICO GEDLABELGENERICO { get; set; }
        public virtual ICollection<GEDDIVISOES> GEDDIVISOES { get; set; }
        public virtual ICollection<GEDTIPOCLIENTE> GEDTIPOCLIENTE { get; set; }
        public virtual ICollection<GEDUNIDADEXAREAS> GEDUNIDADEXAREAS { get; set; }
    }
}
