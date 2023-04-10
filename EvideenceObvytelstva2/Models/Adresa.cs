using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvideenceObvytelstva2.Models
{
    public class Adresa
    {
        public int Id { get; set; }
        public string Ulice { get; set; }
        public int cisloPopisne { get; set; }
        public int psc { get; set; }
        public string Obec { get; set; }

        public virtual ICollection<Osoba> Osobas { get; set; }
        public virtual ICollection<Zamestnani> Zamestnanis { get; set; }
        public virtual ICollection<Skola> Skolas { get; set; }

        public Adresa(string ulice, int cisloPopisne, int psc, string obec)
        {
            Ulice = ulice;
            this.cisloPopisne = cisloPopisne;
            this.psc = psc;
            Obec = obec;
        }
        public Adresa() { }

        public override string? ToString()
        {
            return $"{Ulice}, {cisloPopisne}, {psc}, {Obec}";
        }
    }
}
