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
    
    public partial class GEDSTATUSLOTE1
    {
        public GEDSTATUSLOTE1()
        {
            this.GEDLOTESXUSUARIOS = new HashSet<GEDLOTESXUSUARIOS1>();
        }
    
        public decimal STL_ID { get; set; }
        public string STL_DESCRICAO { get; set; }
    
        public virtual ICollection<GEDLOTESXUSUARIOS1> GEDLOTESXUSUARIOS { get; set; }
    }
}
