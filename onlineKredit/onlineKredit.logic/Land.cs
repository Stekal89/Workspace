
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
    using System.Collections.Generic;
    
public partial class Land
{

    public Land()
    {

        this.AlleKunden = new HashSet<Kunde>();

        this.AlleOrte = new HashSet<Ort>();

    }


    public string ID { get; set; }

    public string Bezeichnung { get; set; }



    public virtual ICollection<Kunde> AlleKunden { get; set; }

    public virtual ICollection<Ort> AlleOrte { get; set; }

}

}
