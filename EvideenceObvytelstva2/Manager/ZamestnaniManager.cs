using EvideenceObvytelstva2.Gateway;
using EvideenceObvytelstva2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvideenceObvytelstva2.Manager
{
    public class ZamestnaniManager
    {
        ZamestnaniGateWay ZamestnaniGateWay = new ZamestnaniGateWay();

        public bool Add(Zamestnani zamestnani)
        {
            return ZamestnaniGateWay.Add(zamestnani); 
        }

        public List<Zamestnani> GetAll()
        {
            return ZamestnaniGateWay.GetAll();
        }
        public bool Update(Zamestnani zamestnani)
        {
            return ZamestnaniGateWay.Update(zamestnani);
        }
        public bool Delete(int id)
        {
            return ZamestnaniGateWay.Delete(id);
        }

        public bool ZamestnaniExist(int id)
        {
            return ZamestnaniGateWay.ZamestnaniExist(id);
        }

        public Zamestnani GetZamestnani(int id)
        {
            return ZamestnaniGateWay.GetZamestnani(id);
        }
    }
}
