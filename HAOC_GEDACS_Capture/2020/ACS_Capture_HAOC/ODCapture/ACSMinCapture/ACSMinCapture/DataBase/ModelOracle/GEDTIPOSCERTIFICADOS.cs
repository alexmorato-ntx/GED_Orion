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
    
    public partial class GEDTIPOSCERTIFICADOS
    {
        public GEDTIPOSCERTIFICADOS()
        {
            this.GEDCONTROLECERTIFICADO = new HashSet<GEDCONTROLECERTIFICADO>();
        }
    
        public decimal TPC_IDCERTIFICADO { get; set; }
        public string TPC_NOME { get; set; }
        public Nullable<decimal> TPC_FLAGATIVO { get; set; }
    
        public virtual ICollection<GEDCONTROLECERTIFICADO> GEDCONTROLECERTIFICADO { get; set; }
    }
}
