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
    
    public partial class GEDTIPOAUDITOR1
    {
        public GEDTIPOAUDITOR1()
        {
            this.GEDAUDITORXCONVENIO = new HashSet<GEDAUDITORXCONVENIO1>();
            this.GEDAUDITORXPASSAGEM = new HashSet<GEDAUDITORXPASSAGEM1>();
        }
    
        public decimal TPA_IDTIPOAUDITOR { get; set; }
        public decimal TPA_IDUSUARIO { get; set; }
        public Nullable<decimal> TPA_FLAGCONVENIO { get; set; }
        public Nullable<decimal> TPA_FLAGUNIVERSAL { get; set; }
        public Nullable<decimal> TPA_FLAGCLIENTE { get; set; }
        public Nullable<decimal> TPA_FLAGATIVO { get; set; }
        public string TPA_OBSERVACAO { get; set; }
        public Nullable<decimal> TPA_FLAGGRUPOUSUARIO { get; set; }
    
        public virtual ICollection<GEDAUDITORXCONVENIO1> GEDAUDITORXCONVENIO { get; set; }
        public virtual ICollection<GEDAUDITORXPASSAGEM1> GEDAUDITORXPASSAGEM { get; set; }
        public virtual GEDUSUARIOS1 GEDUSUARIOS { get; set; }
    }
}
