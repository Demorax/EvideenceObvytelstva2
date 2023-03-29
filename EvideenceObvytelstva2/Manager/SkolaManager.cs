using EvideenceObvytelstva2.Gateway;
using EvideenceObvytelstva2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvideenceObvytelstva2.Manager
{
    public class SkolaManager
    {
        SkolaGateWay SkolaGateWay = new SkolaGateWay();

        public bool Add(Skola skola)
        {
            return SkolaGateWay.Add(skola); 
        }

        public List<Skola> GetAll()
        {
            return SkolaGateWay.GetAll();
        }
        public bool Update(Skola skola)
        {
            return SkolaGateWay.Update(skola);
        }
        public bool Delete(int id)
        {
            return SkolaGateWay.Delete(id);
        }

        public bool SkolaExist(int id)
        {
            return SkolaGateWay.SkolaExist(id);
        }

        public Skola GetSkola(int id)
        {
            return SkolaGateWay.GetSkola(id);
        }
    }
}
