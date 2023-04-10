using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvideenceObvytelstva2.Manager;
using EvideenceObvytelstva2.Models;
using Microsoft.EntityFrameworkCore;

namespace EvideenceObvytelstva2.Gateway
{
    public class OsobaGateWay
    {
        ApplicationDB database = new ApplicationDB();
        AdresaManager adresaManager = new AdresaManager();

        public bool Add(Osoba osoba)
        {
            if (adresaManager.AdresaExist(osoba.AddressId))
            {
                database.Add(osoba);
            }
            return database.SaveChanges() > 0;
        }

        public List<Osoba> GetAll()
        {
            return database.Osobas.ToList();
        }

        public bool Update(Osoba osoba)
        {
            var gate = database.Osobas.FirstOrDefault(e => e.Id == osoba.Id);
            if (gate == null)
            {
                return false;
            }
            gate.Id = osoba.Id;
            gate.TitulPred = osoba.TitulPred;
            gate.AddressId = osoba.AddressId;
            gate.KrestniJmeno = osoba.KrestniJmeno;
            gate.Prijmeni = osoba.Prijmeni;
            gate.TitulZa = osoba.TitulZa;
            gate.Vek = osoba.Vek;
            gate.StudentId = osoba.StudentId;
            gate.ZamestnanecId = osoba.ZamestnanecId;
            return database.SaveChanges() > 0;
        }

        public bool Delete(int id) 
        {
            var osoba = database.Osobas.FirstOrDefault(e => e.Id == id);
            if (osoba == null)
            {
                return false;
            }
            database.Osobas.Remove(osoba);
            return database.SaveChanges() > 0;
        }
    }
}
