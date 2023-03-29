using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvideenceObvytelstva2.Models
{
    public class Zamestnani
    {
        public int Id { get; set; }
        public string NazevFirmy { get; set; }
        public string Poznamka { get; set; }
        public int AdresaId { get; set; }
        public virtual ICollection<Zamestnanec> Zamestnanecs { get; set; }
        public virtual Adresa Adresa { get; set; }
        public Zamestnani(int id, string nazevFirmy, string poznamka, int adresaId)
        {
            Id = id;
            NazevFirmy = nazevFirmy;
            Poznamka = poznamka;
            AdresaId = adresaId;    
        }
        public Zamestnani() { }

        public Zamestnani(string nazevFirmy, string poznamka, int adresaId)
        {
            NazevFirmy = nazevFirmy;
            Poznamka = poznamka;
            AdresaId = adresaId;
        }
    }
}
