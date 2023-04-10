using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvideenceObvytelstva2.Models
{
    public class Skola
    {
        public int Id { get; set; }
        public string NazevSkoly { get; set; }
        public string Poznamka { get; set; }
        public int AdresaId { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public virtual Adresa Adresa { get; set; }

        public Skola(int id, string nazevFirmy, string poznamka, int adresaId)
        {
            Id = id;
            NazevSkoly = nazevFirmy;
            Poznamka = poznamka;
            AdresaId = adresaId;
        }
        public Skola() { }

        public Skola(string nazevFirmy, string poznamka, int adresaId)
        {
            NazevSkoly = nazevFirmy;
            Poznamka = poznamka;
            AdresaId = adresaId;
        }

        public override string? ToString()
        {
            return $"{NazevSkoly}, {Poznamka}";
        }
    }
}
