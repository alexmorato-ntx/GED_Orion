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
    
    public partial class GEDDIVISOES
    {
        public GEDDIVISOES()
        {
            this.GEDDIVISAOXGRUPOUSUARIO = new HashSet<GEDDIVISAOXGRUPOUSUARIO>();
            this.GEDDOCUMENTOS = new HashSet<GEDDOCUMENTOS>();
            this.GEDTIPOSDOCUMENTOS = new HashSet<GEDTIPOSDOCUMENTOS>();
        }
    
        public decimal DIV_IDDIVISAO { get; set; }
        public Nullable<decimal> DIV_IDAREA { get; set; }
        public string DIV_DESCRICAO { get; set; }
        public string DIV_CODIGOREDUZIDO { get; set; }
        public Nullable<decimal> DIV_FLAGATIVO { get; set; }
        public Nullable<decimal> DIV_FLAGTIPOCLIENTE { get; set; }
    
        public virtual GEDAREAS GEDAREAS { get; set; }
        public virtual ICollection<GEDDIVISAOXGRUPOUSUARIO> GEDDIVISAOXGRUPOUSUARIO { get; set; }
        public virtual ICollection<GEDDOCUMENTOS> GEDDOCUMENTOS { get; set; }
        public virtual ICollection<GEDTIPOSDOCUMENTOS> GEDTIPOSDOCUMENTOS { get; set; }
    }
}
