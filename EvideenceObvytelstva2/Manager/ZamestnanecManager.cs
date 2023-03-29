using EvideenceObvytelstva2.Gateway;
using EvideenceObvytelstva2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvideenceObvytelstva2.Manager
{
    public class ZamestnanecManager
    {
        ZamestnanecGateWay zamestnanecGateWay = new ZamestnanecGateWay();

        public bool Add(Zamestnanec zamestnanec)
        {
            return zamestnanecGateWay.Add(zamestnanec); 
        }

        public List<Zamestnanec> GetAll()
        {
            return zamestnanecGateWay.GetAll();
        }
        public bool Update(Zamestnanec zamestnanec)
        {
            return zamestnanecGateWay.Update(zamestnanec);
        }
        public bool Delete(int id)
        {
            return zamestnanecGateWay.Delete(id);
        }

        public bool ZamestnanecExist(int? id)
        {
            return zamestnanecGateWay.ZamestnanecExist(id);
        }

        public Zamestnanec GetZamestnanec(int id)
        {
            return zamestnanecGateWay.GetZamestnanec(id);
        }
    }
}
