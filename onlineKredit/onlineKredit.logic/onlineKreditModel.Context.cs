﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace onlineKredit.logic
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbOnlineKredit : DbContext
    {
        public dbOnlineKredit()
            : base("name=dbOnlineKredit")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Arbeitgeber> AlleArbeitgeber { get; set; }
        public DbSet<Beschaeftigungsart> AlleBeschaeftigungsarten { get; set; }
        public DbSet<Branche> AlleBranchen { get; set; }
        public DbSet<Einstellungen> AlleEinstellungen { get; set; }
        public DbSet<Familienstand> AlleFamilienstaende { get; set; }
        public DbSet<FinanzielleSituation> AlleFinanzielleSituationen { get; set; }
        public DbSet<IdentifikationsArt> AlleIdentifikationsArten { get; set; }
        public DbSet<KontaktDaten> AlleKontaktDaten { get; set; }
        public DbSet<KontoDaten> AlleKontoDaten { get; set; }
        public DbSet<Kredit> AlleKredite { get; set; }
        public DbSet<Kunde> AlleKunden { get; set; }
        public DbSet<Land> AlleLaender { get; set; }
        public DbSet<Ort> AlleOrte { get; set; }
        public DbSet<Schulabschluss> AlleSchulabschluesse { get; set; }
        public DbSet<Titel> AlleTitel { get; set; }
        public DbSet<tblWohnart> tblWohnart { get; set; }
    }
}
