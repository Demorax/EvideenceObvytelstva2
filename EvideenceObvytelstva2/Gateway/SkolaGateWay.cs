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
    public class SkolaGateWay
    {
        ApplicationDB database = new ApplicationDB();
        AdresaManager adresaManager = new AdresaManager();

        public bool Add(Skola skola)
        {
            if (adresaManager.AdresaExist(skola.AdresaId))
            {
                database.Add(skola);
            }
            return database.SaveChanges() > 0;
        }

        public List<Skola> GetAll()
        {
            return database.Skolas.ToList();
        }

        public bool Update(Skola skola)
        {
            var gate = database.Skolas.FirstOrDefault(e => e.Id == skola.Id);
            if (gate == null)
            {
                return false;
            }
            if (adresaManager.AdresaExist(skola.AdresaId))
            {
                gate.Id = skola.Id;
                gate.NazevSkoly = skola.NazevSkoly;
                gate.Poznamka = skola.Poznamka;
                gate.AdresaId = skola.AdresaId;
            }
            return database.SaveChanges() > 0;
        }

        public bool Delete(int id) 
        {
            var skola = database.Skolas.FirstOrDefault(e => e.Id == id);
            if (skola == null)
            {
                return false;
            }
            database.Skolas.Remove(skola);
            return database.SaveChanges() > 0;
        }

        public bool SkolaExist(int id)
        {
            using (var tempDb = new ApplicationDB())
            {
                return tempDb.Skolas.Any(e => e.Id == id);
            }
        }

        public Skola GetSkola(int id)
        {
            using (var tempDb = new ApplicationDB())
            {
                return tempDb.Skolas.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
