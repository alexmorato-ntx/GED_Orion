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
    
    public partial class GEDTIPOCLIENTE1
    {
        public GEDTIPOCLIENTE1()
        {
            this.GEDTIPOBUSCA = new HashSet<GEDTIPOBUSCA1>();
        }
    
        public decimal TIC_IDTIPOCLIENTE { get; set; }
        public decimal TIC_IDAREA { get; set; }
        public string TIC_DESCRICAO { get; set; }
        public Nullable<decimal> TIC_FLAGATIVO { get; set; }
        public string TIC_LABELREGISTRO { get; set; }
        public Nullable<decimal> TIC_VISIBLEREGISTRO { get; set; }
        public string TIC_LABELNOME { get; set; }
        public Nullable<decimal> TIC_VISIBLENOME { get; set; }
        public string TIC_LABELDATA { get; set; }
        public Nullable<decimal> TIC_VISIBLEDATA { get; set; }
        public string TIC_LABELPASSAGEM { get; set; }
        public Nullable<decimal> TIC_VISIBLEPASSAGEM { get; set; }
        public string TIC_LABELUNIDADE { get; set; }
        public Nullable<decimal> TIC_VISIBLEUNIDADE { get; set; }
        public string TIC_LABELPREFIXOIMAGEM { get; set; }
        public Nullable<decimal> TIC_VISIBLEPREFIXOIMAGEM { get; set; }
        public Nullable<decimal> TIC_FLAGTIPOCLIENTE { get; set; }
        public string TIC_LABELDATAPASSAGEM { get; set; }
    
        public virtual GEDAREAS1 GEDAREAS { get; set; }
        public virtual ICollection<GEDTIPOBUSCA1> GEDTIPOBUSCA { get; set; }
    }
}
