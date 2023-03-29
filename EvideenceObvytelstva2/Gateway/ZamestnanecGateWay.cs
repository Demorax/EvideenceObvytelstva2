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
    public class ZamestnanecGateWay
    {
        ApplicationDB database = new ApplicationDB();
        ZamestnaniManager manager = new ZamestnaniManager();

        public bool Add(Zamestnanec zamestnanec)
        {
            if (manager.ZamestnaniExist(zamestnanec.ZamestnaniId))
            {
                database.Add(zamestnanec);
            }
            return database.SaveChanges() > 0;
        }

        public List<Zamestnanec> GetAll()
        {
            return database.Zamestnanecs.ToList();
        }

        public bool Update(Zamestnanec zamestnanec)
        {
            var gate = database.Zamestnanecs.FirstOrDefault(e => e.Id == zamestnanec.Id);
            if (gate == null)
            {
                return false;
            }
            if (manager.ZamestnaniExist(zamestnanec.ZamestnaniId))
            {
                gate.Id = zamestnanec.Id;
                gate.Nastup = zamestnanec.Nastup;
                gate.Oddeleni = zamestnanec.Oddeleni;
                gate.ZamestnaniId = zamestnanec.ZamestnaniId;
            }
           
            return database.SaveChanges() > 0;
        }

        public bool Delete(int id) 
        {
            var zamestnanec = database.Zamestnanecs.FirstOrDefault(e => e.Id == id);
            if (zamestnanec == null)
            {
                return false;
            }
            database.Zamestnanecs.Remove(zamestnanec);
            return database.SaveChanges() > 0;
        }

        public bool ZamestnanecExist(int? id)
        {
            using (var tempDb = new ApplicationDB())
            {
                return tempDb.Zamestnanecs.Any(e => e.Id == id);
            }
        }

        public Zamestnanec GetZamestnanec(int id)
        {
            using (var tempDb = new ApplicationDB())
            {
                return tempDb.Zamestnanecs.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
