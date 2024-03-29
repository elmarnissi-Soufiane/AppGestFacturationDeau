﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppGestFacturationDeau
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class db_facture_eauEntities : DbContext
    {
        public db_facture_eauEntities()
            : base("name=db_facture_eauEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adherent> Adherents { get; set; }
        public virtual DbSet<Compteur> Compteurs { get; set; }
        public virtual DbSet<Consomation> Consomations { get; set; }
        public virtual DbSet<Tranche> Tranches { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Taxe> Taxes { get; set; }
        public virtual DbSet<Facture> Factures { get; set; }
    
        public virtual ObjectResult<Ps_Crystal_Result> Ps_Crystal(Nullable<int> mois)
        {
            var moisParameter = mois.HasValue ?
                new ObjectParameter("Mois", mois) :
                new ObjectParameter("Mois", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ps_Crystal_Result>("Ps_Crystal", moisParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> Ps_Taxe_Cry()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("Ps_Taxe_Cry");
        }
    
        public virtual ObjectResult<Ps_Tranche_Cry_Result> Ps_Tranche_Cry()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ps_Tranche_Cry_Result>("Ps_Tranche_Cry");
        }
    
        public virtual ObjectResult<Ps_Crystal_Facture_Result> Ps_Crystal_Facture(Nullable<int> mois)
        {
            var moisParameter = mois.HasValue ?
                new ObjectParameter("Mois", mois) :
                new ObjectParameter("Mois", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ps_Crystal_Facture_Result>("Ps_Crystal_Facture", moisParameter);
        }
    
        public virtual ObjectResult<PS_Paye_Cry_Result> PS_Paye_Cry(Nullable<int> moisFac, Nullable<int> idC)
        {
            var moisFacParameter = moisFac.HasValue ?
                new ObjectParameter("MoisFac", moisFac) :
                new ObjectParameter("MoisFac", typeof(int));
    
            var idCParameter = idC.HasValue ?
                new ObjectParameter("IdC", idC) :
                new ObjectParameter("IdC", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PS_Paye_Cry_Result>("PS_Paye_Cry", moisFacParameter, idCParameter);
        }
    
        [DbFunction("db_facture_eauEntities", "CALCUL_CONSOM")]
        public virtual IQueryable<CALCUL_CONSOM_Result> CALCUL_CONSOM(Nullable<int> cONS)
        {
            var cONSParameter = cONS.HasValue ?
                new ObjectParameter("CONS", cONS) :
                new ObjectParameter("CONS", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<CALCUL_CONSOM_Result>("[db_facture_eauEntities].[CALCUL_CONSOM](@CONS)", cONSParameter);
        }
    
        [DbFunction("db_facture_eauEntities", "PRIX_TRANCHE")]
        public virtual IQueryable<PRIX_TRANCHE_Result> PRIX_TRANCHE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<PRIX_TRANCHE_Result>("[db_facture_eauEntities].[PRIX_TRANCHE]()");
        }
    
        public virtual ObjectResult<PS_CALCUL_CONSOM_Result> PS_CALCUL_CONSOM(Nullable<int> cONS)
        {
            var cONSParameter = cONS.HasValue ?
                new ObjectParameter("CONS", cONS) :
                new ObjectParameter("CONS", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PS_CALCUL_CONSOM_Result>("PS_CALCUL_CONSOM", cONSParameter);
        }
    
        public virtual ObjectResult<Ps_Qte_Cry_Result> Ps_Qte_Cry(Nullable<int> mois)
        {
            var moisParameter = mois.HasValue ?
                new ObjectParameter("Mois", mois) :
                new ObjectParameter("Mois", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ps_Qte_Cry_Result>("Ps_Qte_Cry", moisParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> Ps_Pernete_Cry()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("Ps_Pernete_Cry");
        }
    }
}
