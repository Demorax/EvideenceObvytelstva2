using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvideenceObvytelstva2.Models
{
    public class Osoba
    {
        public int Id { get; set; }
        public string KrestniJmeno { get; set; }
        public string Prijmeni { get; set; }

        public string Titul { get; set; }

        public int Vek { get; set; }
        public int AddressId { get; set; }
        
        public int? StudentId { get; set; }
        public int? ZamestnanecId { get; set; }

        public virtual Adresa Adresa { get; set; }
        public virtual Student? Student { get; set; }
        public virtual Zamestnanec? Zamestnanec { get; set; }

        public Osoba(int id, string krestniJmeno, string prijmeni, string titul, int vek, int addressId, int? studentId, int? zamestnanecId)
        {
            Id = id;
            KrestniJmeno = krestniJmeno;
            Prijmeni = prijmeni;
            Titul = titul;
            Vek = vek;
            AddressId = addressId;
            StudentId = studentId;
            ZamestnanecId = zamestnanecId;
        }

        public Osoba()
        {
        }

        public Osoba(string krestniJmeno, string prijmeni, string titul, int vek, int addressId, int? studentId, int? zamestnanecId)
        {
            KrestniJmeno = krestniJmeno;
            Prijmeni = prijmeni;
            Titul = titul;
            Vek = vek;
            AddressId = addressId;
            StudentId = studentId;
            ZamestnanecId = zamestnanecId;
        }
    }
}
