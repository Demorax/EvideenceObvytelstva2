using EvideenceObvytelstva2.Gateway;
using EvideenceObvytelstva2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvideenceObvytelstva2.Manager
{
    public class OsobaManager
    {
        OsobaGateWay OsobaGateWay = new OsobaGateWay();

        public bool Add(Osoba osoba)
        {
            return OsobaGateWay.Add(osoba); 
        }

        public List<Osoba> GetAll()
        {
            return OsobaGateWay.GetAll();
        }
        public bool Update(Osoba osoba)
        {
            return OsobaGateWay.Update(osoba);
        }
        public bool Delete(int id)
        {
            return OsobaGateWay.Delete(id);
        }
    }
}
