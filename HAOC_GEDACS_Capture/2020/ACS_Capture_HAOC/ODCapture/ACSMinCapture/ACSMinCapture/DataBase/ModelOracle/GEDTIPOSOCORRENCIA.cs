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
    
    public partial class GEDTIPOSOCORRENCIA
    {
        public GEDTIPOSOCORRENCIA()
        {
            this.GEDOCORRENCIAS = new HashSet<GEDOCORRENCIAS>();
        }
    
        public decimal TPO_IDTIPOOCORRENCIA { get; set; }
        public string TPO_DESCRICAO { get; set; }
        public Nullable<decimal> TPO_FLAGATIVO { get; set; }
    
        public virtual ICollection<GEDOCORRENCIAS> GEDOCORRENCIAS { get; set; }
    }
}