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
    
    public partial class GEDUSUARIOS1
    {
        public GEDUSUARIOS1()
        {
            this.GEDLOTESXUSUARIOS = new HashSet<GEDLOTESXUSUARIOS1>();
            this.GEDOCORRENCIAS = new HashSet<GEDOCORRENCIAS1>();
            this.GEDPERFISXUSUARIOS = new HashSet<GEDPERFISXUSUARIOS1>();
            this.GEDTIPOAUDITOR = new HashSet<GEDTIPOAUDITOR1>();
            this.HELP_SUBMENU = new HashSet<HELP_SUBMENU>();
            this.GEDUSUARIOSXUNIDADESXAREAS = new HashSet<GEDUSUARIOSXUNIDADESXAREAS1>();
        }
    
        public decimal USR_IDUSUARIO { get; set; }
        public Nullable<decimal> USR_IDGRUPOUSUARIO { get; set; }
        public Nullable<decimal> USR_IDPESSOA { get; set; }
        public string USR_LOGIN { get; set; }
        public string USR_SENHA { get; set; }
        public Nullable<decimal> USR_FLAGATIVO { get; set; }
        public Nullable<decimal> USR_FIRSTACCESS { get; set; }
        public Nullable<System.DateTime> USR_DATAHORACADASTRO { get; set; }
        public Nullable<System.DateTime> USR_DATAHORALASTLOGIN { get; set; }
        public string USR_OBSERVACAO { get; set; }
        public Nullable<decimal> USR_FLAGIMPRIMIR { get; set; }
        public Nullable<decimal> USR_FLAGIMPORTACAO { get; set; }
        public Nullable<decimal> USR_FLAGDIGITALIZACAO { get; set; }
        public Nullable<decimal> USR_FLAGASSINA { get; set; }
        public Nullable<decimal> USR_NIVELASSINA { get; set; }
        public string USR_SERIALNUMBERCERT { get; set; }
        public Nullable<decimal> USR_FLAGADMACS { get; set; }
        public Nullable<decimal> USR_FLAGPROCESSAMENTO { get; set; }
    
        public virtual GEDGRUPOSUSUARIOS1 GEDGRUPOSUSUARIOS { get; set; }
        public virtual ICollection<GEDLOTESXUSUARIOS1> GEDLOTESXUSUARIOS { get; set; }
        public virtual ICollection<GEDOCORRENCIAS1> GEDOCORRENCIAS { get; set; }
        public virtual ICollection<GEDPERFISXUSUARIOS1> GEDPERFISXUSUARIOS { get; set; }
        public virtual GEDPESSOAS1 GEDPESSOAS { get; set; }
        public virtual ICollection<GEDTIPOAUDITOR1> GEDTIPOAUDITOR { get; set; }
        public virtual ICollection<HELP_SUBMENU> HELP_SUBMENU { get; set; }
        public virtual ICollection<GEDUSUARIOSXUNIDADESXAREAS1> GEDUSUARIOSXUNIDADESXAREAS { get; set; }
    }
}
