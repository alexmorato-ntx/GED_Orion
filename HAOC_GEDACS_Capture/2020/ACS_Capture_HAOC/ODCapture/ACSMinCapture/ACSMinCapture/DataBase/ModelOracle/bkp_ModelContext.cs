﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACSMinCapture.DataBase.ModelOracle
{
    class bkp_ModelContext
    {
        //using System;
        //using System.Data.Objects;
        //using System.Data.EntityClient;


        //public partial class EntitiesOracle : ObjectContext
        //{
       public const string ConnectionString = "name=EntitiesOracle";
        public const string ContainerName = "OracleModels";


        //public EntitiesOracle()
        //    : base(ConnectionString, ContainerName)
        //{
        //    this.ContextOptions.LazyLoadingEnabled = true;
        //}

        //public EntitiesOracle(string connectionString)
        //    : base(connectionString, ContainerName)
        //{
        //    this.ContextOptions.LazyLoadingEnabled = true;
        //}

        //public EntitiesOracle(EntityConnection connection)
        //    : base(connection, ContainerName)
        //{
        //    this.ContextOptions.LazyLoadingEnabled = true;
        //}

        //#region ObjectSet Properties




        //public ObjectSet<GEDGRUPOSUSUARIOS> GEDGRUPOSUSUARIOS
        //{
        //    get { return _gedGrupoUsuario ?? (_gedGrupoUsuario = CreateObjectSet<GEDGRUPOSUSUARIOS>("GEDGRUPOSUSUARIOS")); }
        //}
        //private ObjectSet<GEDGRUPOSUSUARIOS> _gedGrupoUsuario;



        //public ObjectSet<GEDLABELGENERICO> GEDLABELGENERICO
        //{
        //    get { return _gedLabeGenerico ?? (_gedLabeGenerico = CreateObjectSet<GEDLABELGENERICO>("GEDLABELGENERICO")); }
        //}
        //private ObjectSet<GEDLABELGENERICO> _gedLabeGenerico;



        //public ObjectSet<GEDUNIDADEXAREAS> GEDUNIDADEXAREAS
        //{
        //    get { return _gedUnidadexAreas ?? (_gedUnidadexAreas = CreateObjectSet<GEDUNIDADEXAREAS>("GEDUNIDADEXAREAS")); }
        //}
        //private ObjectSet<GEDUNIDADEXAREAS> _gedUnidadexAreas;



        //public ObjectSet<GEDAREAS> GEDAREAS
        //{
        //    get { return _gedAreas ?? (_gedAreas = CreateObjectSet<GEDAREAS>("GEDAREAS")); }
        //}
        //private ObjectSet<GEDAREAS> _gedAreas;


        //public ObjectSet<GEDUSUARIOSXUNIDADESXAREAS> GEDUSUARIOSXUNIDADESXAREAS
        //{
        //    get { return _gEDUSUARIOSXUNIDADESXAREAS ?? (_gEDUSUARIOSXUNIDADESXAREAS = CreateObjectSet<GEDUSUARIOSXUNIDADESXAREAS>("GEDUSUARIOSXUNIDADESXAREAS")); }
        //}
        //private ObjectSet<GEDUSUARIOSXUNIDADESXAREAS> _gEDUSUARIOSXUNIDADESXAREAS;


        //public ObjectSet<GEDTIPOAUDITOR> GEDTIPOAUDITOR
        //{
        //    get { return _gEDTIPOAUDITOR ?? (_gEDTIPOAUDITOR = CreateObjectSet<GEDTIPOAUDITOR>("GEDTIPOAUDITOR")); }
        //}
        //private ObjectSet<GEDTIPOAUDITOR> _gEDTIPOAUDITOR;

        //public ObjectSet<GEDPERFISXUSUARIOS> GEDPERFISXUSUARIOS
        //{
        //    get { return _gEDPERFISXUSUARIOS ?? (_gEDPERFISXUSUARIOS = CreateObjectSet<GEDPERFISXUSUARIOS>("GEDPERFISXUSUARIOS")); }
        //}
        //private ObjectSet<GEDPERFISXUSUARIOS> _gEDPERFISXUSUARIOS;


        //public ObjectSet<GEDPESSOAS> GEDPESSOAS
        //{
        //    get { return _gEDPessoas ?? (_gEDPessoas = CreateObjectSet<GEDPESSOAS>("GEDPESSOAS")); }
        //}
        //private ObjectSet<GEDPESSOAS> _gEDPessoas;


        //public ObjectSet<GEDCLIENTEPF> GEDCLIENTEPF
        //{
        //    get { return _gEDCLIENTEPF ?? (_gEDCLIENTEPF = CreateObjectSet<GEDCLIENTEPF>("GEDCLIENTEPF")); }
        //}
        //private ObjectSet<GEDCLIENTEPF> _gEDCLIENTEPF;

        //public ObjectSet<GEDCLIENTEPJ> GEDCLIENTEPJ
        //{
        //    get { return _gEDCLIENTEPJ ?? (_gEDCLIENTEPJ = CreateObjectSet<GEDCLIENTEPJ>("GEDCLIENTEPJ")); }
        //}
        //private ObjectSet<GEDCLIENTEPJ> _gEDCLIENTEPJ;

        //public ObjectSet<GEDDIVISOES> GEDDIVISOES
        //{
        //    get { return _gEDDivisoes ?? (_gEDDivisoes = CreateObjectSet<GEDDIVISOES>("GEDDIVISOES")); }
        //}
        //private ObjectSet<GEDDIVISOES> _gEDDivisoes;



        //public ObjectSet<GEDTIPOCLIENTE> GEDTIPOCLIENTE
        //{
        //    get { return _gEDTipoCliente ?? (_gEDTipoCliente = CreateObjectSet<GEDTIPOCLIENTE>("GEDTIPOCLIENTE")); }
        //}
        //private ObjectSet<GEDTIPOCLIENTE> _gEDTipoCliente;




        //public ObjectSet<GEDDOCUMENTOS> GEDDOCUMENTOS
        //{
        //    get { return _gEDDocumentos ?? (_gEDDocumentos = CreateObjectSet<GEDDOCUMENTOS>("GEDDOCUMENTOS")); }
        //}
        //private ObjectSet<GEDDOCUMENTOS> _gEDDocumentos;

        //public ObjectSet<GEDFORMATOS> GEDFORMATOS
        //{
        //    get { return _gEDFormatos ?? (_gEDFormatos = CreateObjectSet<GEDFORMATOS>("GEDFORMATOS")); }
        //}
        //private ObjectSet<GEDFORMATOS> _gEDFormatos;

        //public ObjectSet<GEDPASSAGENS> GEDPASSAGENS
        //{
        //    get { return _gEDPassagens ?? (_gEDPassagens = CreateObjectSet<GEDPASSAGENS>("GEDPASSAGENS")); }
        //}
        //private ObjectSet<GEDPASSAGENS> _gEDPassagens;

        //public ObjectSet<GEDSUBTIPOSDOCUMENTOS> GEDSUBTIPOSDOCUMENTOS
        //{
        //    get
        //    {
        //        return _gEDSubTiposDocumentos ?? (_gEDSubTiposDocumentos = CreateObjectSet<GEDSUBTIPOSDOCUMENTOS>

        //            ("GEDSUBTIPOSDOCUMENTOS"));
        //    }
        //}
        //private ObjectSet<GEDSUBTIPOSDOCUMENTOS> _gEDSubTiposDocumentos;



        //public ObjectSet<GEDTIPOSBUSCALOTES> GEDTIPOSBUSCALOTES
        //{
        //    get
        //    {
        //        return _gEDTIPOSBUSCALOTES ?? (_gEDTIPOSBUSCALOTES = CreateObjectSet<GEDTIPOSBUSCALOTES>

        //            ("GEDTIPOSBUSCALOTES"));
        //    }
        //}
        //private ObjectSet<GEDTIPOSBUSCALOTES> _gEDTIPOSBUSCALOTES;

        //public ObjectSet<GEDTIPOSBUSCALOTESPJ> GEDTIPOSBUSCALOTESPJ
        //{
        //    get
        //    {
        //        return _gEDTiposBuscaLotesPJ ?? (_gEDTiposBuscaLotesPJ = CreateObjectSet<GEDTIPOSBUSCALOTESPJ>

        //            ("GEDTIPOSBUSCALOTESPJ"));
        //    }
        //}
        //private ObjectSet<GEDTIPOSBUSCALOTESPJ> _gEDTiposBuscaLotesPJ;

        //public ObjectSet<GEDTIPOSDOCUMENTOS> GEDTIPOSDOCUMENTOS
        //{
        //    get
        //    {
        //        return _gEDTiposDocumentos ?? (_gEDTiposDocumentos = CreateObjectSet<GEDTIPOSDOCUMENTOS>

        //            ("GEDTIPOSDOCUMENTOS"));
        //    }
        //}
        //private ObjectSet<GEDTIPOSDOCUMENTOS> _gEDTiposDocumentos;


        //public ObjectSet<GEDCAPTIONCONTROL> GEDCAPTIONCONTROL
        //{
        //    get
        //    {
        //        return _gEDCaptionControl ?? (_gEDCaptionControl = CreateObjectSet<GEDCAPTIONCONTROL>

        //            ("GEDCAPTIONCONTROL"));
        //    }
        //}
        //private ObjectSet<GEDCAPTIONCONTROL> _gEDCaptionControl;

        //public ObjectSet<GEDLOGLOGIN> GEDLOGLOGIN
        //{
        //    get { return _gEDLogLogin ?? (_gEDLogLogin = CreateObjectSet<GEDLOGLOGIN>("GEDLOGLOGIN")); }
        //}
        //private ObjectSet<GEDLOGLOGIN> _gEDLogLogin;

        //public ObjectSet<GEDSTATUSLOTE> GEDSTATUSLOTE
        //{
        //    get { return _gEDStatusLote ?? (_gEDStatusLote = CreateObjectSet<GEDSTATUSLOTE>("GEDSTATUSLOTE")); }
        //}
        //private ObjectSet<GEDSTATUSLOTE> _gEDStatusLote;

        //public ObjectSet<GEDLOTESXUSUARIOS> GEDLOTESXUSUARIOS
        //{
        //    get
        //    {
        //        return _gEDLotesXUsuarios ?? (_gEDLotesXUsuarios = CreateObjectSet<GEDLOTESXUSUARIOS>

        //            ("GEDLOTESXUSUARIOS"));
        //    }
        //}
        //private ObjectSet<GEDLOTESXUSUARIOS> _gEDLotesXUsuarios;

        //public ObjectSet<GEDUSUARIOS> GEDUSUARIOS
        //{
        //    get { return _gEDUsuarios ?? (_gEDUsuarios = CreateObjectSet<GEDUSUARIOS>("GEDUSUARIOS")); }
        //}
        //private ObjectSet<GEDUSUARIOS> _gEDUsuarios;



        //public ObjectSet<GEDSETOR> GEDSETOR
        //{
        //    get { return _GEDSETOR ?? (_GEDSETOR = CreateObjectSet<GEDSETOR>("GEDSETOR")); }
        //}
        //private ObjectSet<GEDSETOR> _GEDSETOR;

        //public ObjectSet<GEDSETORXGRUPOUSUARIO> GEDSETORXGRUPOUSUARIO
        //{
        //    get { return _GEDSETORXGRUPOUSUARIO ?? (_GEDSETORXGRUPOUSUARIO = CreateObjectSet<GEDSETORXGRUPOUSUARIO>("GEDSETORXGRUPOUSUARIO")); }
        //}
        //private ObjectSet<GEDSETORXGRUPOUSUARIO> _GEDSETORXGRUPOUSUARIO;
        //#endregion

        //}
    }
}
