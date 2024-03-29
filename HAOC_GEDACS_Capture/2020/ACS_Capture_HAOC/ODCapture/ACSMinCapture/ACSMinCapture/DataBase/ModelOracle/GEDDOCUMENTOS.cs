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
    
    public partial class GEDDOCUMENTOS
    {
        public GEDDOCUMENTOS()
        {
            this.GEDCONTROLECERTIFICADO = new HashSet<GEDCONTROLECERTIFICADO>();
            this.GEDOCORRENCIAS = new HashSet<GEDOCORRENCIAS>();
        }
    
        public decimal DOC_IDDOCUMENTO { get; set; }
        public Nullable<decimal> DOC_IDVOLUME { get; set; }
        public decimal DOC_IDDIVISAO { get; set; }
        public Nullable<decimal> DOC_IDPASSAGEM { get; set; }
        public Nullable<decimal> DOC_IDFORMATO { get; set; }
        public Nullable<decimal> DOC_IDTIPODOCUMENTO { get; set; }
        public string DOC_PATH { get; set; }
        public string DOC_NOMEARQUIVO { get; set; }
        public Nullable<System.DateTime> DOC_DATAHORACADASTRO { get; set; }
        public Nullable<decimal> DOC_FLAGCERTIFICADO { get; set; }
        public Nullable<decimal> DOC_IDSUBTIPODOCUMENTO { get; set; }
        public Nullable<System.DateTime> DOC_DATAVENCIMENTO { get; set; }
        public Nullable<System.DateTime> DOC_DATAEMISSAO { get; set; }
        public Nullable<decimal> DOC_TEMPOVALIDADE { get; set; }
        public Nullable<decimal> DOC_VENCIMENTORESOLVIDO { get; set; }
        public Nullable<decimal> DOC_IDUSUARIOACSCAPTURE { get; set; }
        public Nullable<decimal> DOC_IDUSUARIOASSINANIVEL1 { get; set; }
        public Nullable<decimal> DOC_IDUSUARIOASSINANIVEL2 { get; set; }
        public Nullable<decimal> DOC_IDUSUARIOASSINANIVEL3 { get; set; }
        public Nullable<System.DateTime> DOC_DATAASSINANIVEL1 { get; set; }
        public Nullable<System.DateTime> DOC_DATAASSINANIVEL2 { get; set; }
        public Nullable<System.DateTime> DOC_DATAASSINANIVEL3 { get; set; }
        public string DOC_P7S { get; set; }
        public Nullable<decimal> DOC_FLAGATIVO { get; set; }
        public string DOC_OBSERVACAO { get; set; }
        public string DOC_DETAIL_CERT { get; set; }
        public Nullable<decimal> DOC_VERSAO { get; set; }
        public string DOC_EXTENSAONOMEARQUIVO { get; set; }
        public Nullable<decimal> DOC_TIPOCAPTURA { get; set; }
        public string DOC_CHAVEBUSCA1 { get; set; }
        public string DOC_CHAVEBUSCA2 { get; set; }
        public string DOC_CHAVEBUSCA3 { get; set; }
        public string DOC_CHAVEBUSCA4 { get; set; }
        public Nullable<decimal> DOC_ORDEM_VISUALIZACAO { get; set; }
        public Nullable<decimal> DOC_FLAGAPROVADO { get; set; }
        public Nullable<decimal> DOC_IDUSUARIOASSINANIVEL3_2 { get; set; }
        public Nullable<System.DateTime> DOC_DATAASSINANIVEL3_2 { get; set; }
        public Nullable<decimal> DOC_FLAGDOCEXTERNO { get; set; }
        public Nullable<decimal> DOC_FLAGREVISADO { get; set; }
        public Nullable<decimal> DOC_FLAGPENDENTEUPLOAD { get; set; }
        public decimal DOC_IDGRUPOUSUARIOCAPTURA { get; set; }
        public string DOC_HASHDOCUMENTOCERTILLION { get; set; }
        public Nullable<decimal> DOC_IDURLSTORAGE { get; set; }
        public string DOC_VERSAOACS { get; set; }
    
        public virtual ICollection<GEDCONTROLECERTIFICADO> GEDCONTROLECERTIFICADO { get; set; }
        public virtual GEDDIVISOES GEDDIVISOES { get; set; }
        public virtual GEDFORMATOS GEDFORMATOS { get; set; }
        public virtual GEDGRUPOSUSUARIOS GEDGRUPOSUSUARIOS { get; set; }
        public virtual GEDPASSAGENS GEDPASSAGENS { get; set; }
        public virtual GEDTIPOSDOCUMENTOS GEDTIPOSDOCUMENTOS { get; set; }
        public virtual GEDVOLUMES GEDVOLUMES { get; set; }
        public virtual ICollection<GEDOCORRENCIAS> GEDOCORRENCIAS { get; set; }
    }
}
