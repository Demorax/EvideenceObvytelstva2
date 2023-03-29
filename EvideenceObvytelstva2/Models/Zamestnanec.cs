using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvideenceObvytelstva2.Models
{
    public class Zamestnanec
    {
        public int Id { get; set; }

        public DateOnly Nastup { get; set; } 

        public string Oddeleni { get; set; }

        public int ZamestnaniId { get; set; }
        public virtual Osoba Osoba { get; set; }
        public virtual Zamestnani Zamestnani { get; set; }

        public Zamestnanec() { }

        public Zamestnanec(int id, DateOnly nastup, string oddeleni, int zamestnaniId)
        {
            Id = id;
            Nastup = nastup;
            Oddeleni = oddeleni;
            ZamestnaniId = zamestnaniId;
        }

        public Zamestnanec(DateOnly nastup, string oddeleni, int zamestnaniId)
        {
            Nastup = nastup;
            Oddeleni = oddeleni;
            ZamestnaniId = zamestnaniId;
        }
    }
}
