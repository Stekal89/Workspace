﻿

//------------------------------------------------------------------------------
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

using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;


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

    public DbSet<Kredit> AlleKredite { get; set; }

    public DbSet<Kunde> AlleKunden { get; set; }

    public DbSet<Land> AlleLaender { get; set; }

    public DbSet<Ort> AlleOrte { get; set; }

    public DbSet<Schulabschluss> AlleSchulabschluesse { get; set; }

    public DbSet<Titel> AlleTitel { get; set; }

    public DbSet<Wohnart> AlleWohnarten { get; set; }

    public DbSet<KreditKarte> AlleKreditKarten { get; set; }

    public DbSet<tblLogin> tblLogin { get; set; }

    public DbSet<KontoDaten> AlleKontoDaten { get; set; }

    public DbSet<AdminLogin> AlleAdminLogins { get; set; }


    public virtual int pNeuenAdminEinfuegen(string benutzer, string passwort)
    {

        var benutzerParameter = benutzer != null ?
            new ObjectParameter("benutzer", benutzer) :
            new ObjectParameter("benutzer", typeof(string));


        var passwortParameter = passwort != null ?
            new ObjectParameter("passwort", passwort) :
            new ObjectParameter("passwort", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pNeuenAdminEinfuegen", benutzerParameter, passwortParameter);
    }

}

}

