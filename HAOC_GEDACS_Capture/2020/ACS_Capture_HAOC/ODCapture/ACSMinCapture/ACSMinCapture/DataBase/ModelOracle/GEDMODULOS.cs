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
    
    public partial class GEDMODULOS
    {
        public GEDMODULOS()
        {
            this.GEDOBJETOS = new HashSet<GEDOBJETOS>();
        }
    
        public decimal MOD_IDMODULO { get; set; }
        public string MOD_DESCRICAO { get; set; }
        public decimal MOD_ORDEM { get; set; }
    
        public virtual ICollection<GEDOBJETOS> GEDOBJETOS { get; set; }
    }
}
