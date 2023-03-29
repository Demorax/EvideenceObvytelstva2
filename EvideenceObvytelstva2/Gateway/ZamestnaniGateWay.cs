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
    public class ZamestnaniGateWay
    {
        ApplicationDB database = new ApplicationDB();
        AdresaManager adresaManager = new AdresaManager();

        public bool Add(Zamestnani zamestnani)
        {
            if (adresaManager.AdresaExist(zamestnani.AdresaId))
            {
                database.Add(zamestnani);
            }
            return database.SaveChanges() > 0;
        }

        public List<Zamestnani> GetAll()
        {
            return database.Zamestnanis.ToList();
        }

        public bool Update(Zamestnani zamestnani)
        {
            var gate = database.Zamestnanis.FirstOrDefault(e => e.Id == zamestnani.Id);
            if (gate == null)
            {
                return false;
            }
            if (adresaManager.AdresaExist(zamestnani.AdresaId))
            {
                gate.Id = zamestnani.Id;
                gate.AdresaId = zamestnani.AdresaId;
                gate.NazevFirmy = zamestnani.NazevFirmy;
                gate.Poznamka = zamestnani.Poznamka;
            }
            
            return database.SaveChanges() > 0;
        }

        public bool Delete(int id) 
        {
            var zamestnani = database.Zamestnanis.FirstOrDefault(e => e.Id == id);
            if (zamestnani == null)
            {
                return false;
            }
            database.Zamestnanis.Remove(zamestnani);
            return database.SaveChanges() > 0;
        }
        public bool ZamestnaniExist(int id)
        {
            using (var tempDb = new ApplicationDB())
            {
                return tempDb.Zamestnanis.Any(e => e.Id == id);
            }
        }

        public Zamestnani GetZamestnani(int id)
        {
            using (var tempDb = new ApplicationDB())
            {
                return tempDb.Zamestnanis.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
