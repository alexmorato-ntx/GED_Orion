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
    
    public partial class GEDUNIDADEXAREAS1
    {
        public GEDUNIDADEXAREAS1()
        {
            this.GEDUSUARIOSXUNIDADESXAREAS = new HashSet<GEDUSUARIOSXUNIDADESXAREAS1>();
        }
    
        public decimal UXA_IDUNIDADEXAREA { get; set; }
        public decimal UXA_IDUNIDADE { get; set; }
        public decimal UXA_IDAREA { get; set; }
    
        public virtual GEDAREAS1 GEDAREAS { get; set; }
        public virtual GEDUNIDADES1 GEDUNIDADES { get; set; }
        public virtual ICollection<GEDUSUARIOSXUNIDADESXAREAS1> GEDUSUARIOSXUNIDADESXAREAS { get; set; }
    }
}
