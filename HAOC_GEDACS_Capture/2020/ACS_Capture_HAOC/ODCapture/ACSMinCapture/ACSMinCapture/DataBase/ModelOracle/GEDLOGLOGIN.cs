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
    
    public partial class GEDLOGLOGIN
    {
        public decimal LLG_IDLOGLOGIN { get; set; }
        public Nullable<decimal> LLG_IDUSUARIO { get; set; }
        public string LLG_IPESTACAO { get; set; }
        public Nullable<decimal> LLG_IDUNIDADE { get; set; }
        public Nullable<decimal> LLG_FLAGLOGIN { get; set; }
        public Nullable<System.DateTime> LLG_DATAHORALOGIN { get; set; }
        public Nullable<decimal> LLG_FLAGLOGOUT { get; set; }
        public Nullable<System.DateTime> LLG_DATAHORALOGOUT { get; set; }
        public string LLG_OBSERVACAO { get; set; }
        public string LLG_TOKEN { get; set; }
    }
}
