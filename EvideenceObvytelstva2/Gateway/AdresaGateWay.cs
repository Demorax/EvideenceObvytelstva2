using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvideenceObvytelstva2.Models;
using Microsoft.EntityFrameworkCore;

namespace EvideenceObvytelstva2.Gateway
{
    public class AdresaGateWay
    {
        ApplicationDB database = new ApplicationDB();

        public bool Add(Adresa adresa)
        {
            database.Add(adresa);
            return database.SaveChanges() > 0;
        }

        public List<Adresa> GetAll()
        {
            return database.Adresses.ToList();
        }

        public bool Update(Adresa adresa)
        {
            var gate = database.Adresses.FirstOrDefault(e => e.Id == adresa.Id);
            if (gate == null)
            {
                return false;
            }
            gate.Id = adresa.Id;
            gate.Ulice = adresa.Ulice;
            gate.cisloPopisne = adresa.cisloPopisne;
            gate.psc = adresa.psc;
            gate.Obec = adresa.Obec;
            return database.SaveChanges() > 0;
        }

        public bool Delete(int id) 
        {
            var adresa = database.Adresses.FirstOrDefault(e => e.Id == id);
            if (adresa == null)
            {
                return false;
            }
            database.Adresses.Remove(adresa);
            return database.SaveChanges() > 0;
        }

        public bool AdresaExist(int id) {
            using (var tempDb = new ApplicationDB())
            {
                return tempDb.Adresses.Any(e => e.Id == id);
            }
        }

        public Adresa GetAdresa(int id)
        {
            using (var tempDb = new ApplicationDB())
            {
                return tempDb.Adresses.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
