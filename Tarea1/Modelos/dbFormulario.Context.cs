﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarea1.Modelos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CNSFFORMULARIOS2Entities : DbContext
    {
        public CNSFFORMULARIOS2Entities()
            : base("name=CNSFFORMULARIOS2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<IntellIDE_Autorizacion_Agentes_de_Seguros> IntellIDE_Autorizacion_Agentes_de_Seguros { get; set; }
        public virtual DbSet<IntellIDE_PRUEBA01> IntellIDE_PRUEBA01 { get; set; }
        public virtual DbSet<IntellIDE_PRUEBA02> IntellIDE_PRUEBA02 { get; set; }
        public virtual DbSet<IntellIDE_Refrendo_de_Agente_de_Seguros> IntellIDE_Refrendo_de_Agente_de_Seguros { get; set; }
        public virtual DbSet<IntellIDE_Tramite_de_prueba> IntellIDE_Tramite_de_prueba { get; set; }
        public virtual DbSet<TB_ACTIVIDADES> TB_ACTIVIDADES { get; set; }
        public virtual DbSet<TB_CLASIFICACION> TB_CLASIFICACION { get; set; }
        public virtual DbSet<TB_COMENTARIOS> TB_COMENTARIOS { get; set; }
        public virtual DbSet<TB_DIRECCIONES> TB_DIRECCIONES { get; set; }
        public virtual DbSet<TB_DOCUMENTOS> TB_DOCUMENTOS { get; set; }
        public virtual DbSet<TB_DOCUMENTOS_TRAMITES> TB_DOCUMENTOS_TRAMITES { get; set; }
        public virtual DbSet<TB_INSTITUCIONES> TB_INSTITUCIONES { get; set; }
        public virtual DbSet<TB_LOG> TB_LOG { get; set; }
        public virtual DbSet<TB_MISDOCUMENTOS> TB_MISDOCUMENTOS { get; set; }
        public virtual DbSet<TB_OFICINAS> TB_OFICINAS { get; set; }
        public virtual DbSet<TB_OFICINAS_TB_TRAMITES> TB_OFICINAS_TB_TRAMITES { get; set; }
        public virtual DbSet<TB_TIPO_DOCUMENTOS> TB_TIPO_DOCUMENTOS { get; set; }
        public virtual DbSet<TB_TRAMITES> TB_TRAMITES { get; set; }
        public virtual DbSet<TB_TRAMITES_TB_CLASIFICACION> TB_TRAMITES_TB_CLASIFICACION { get; set; }
        public virtual DbSet<TB_USER_TB_TRAMITES> TB_USER_TB_TRAMITES { get; set; }
        public virtual DbSet<TB_USERS> TB_USERS { get; set; }
        public virtual DbSet<TB_HTMLS> TB_HTMLS { get; set; }
    }
}
