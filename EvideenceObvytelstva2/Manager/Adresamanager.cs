using EvideenceObvytelstva2.Gateway;
using EvideenceObvytelstva2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvideenceObvytelstva2.Manager
{
    public class AdresaManager
    {
        AdresaGateWay AdresaGateWay = new AdresaGateWay();

        public bool Add(Adresa adresa)
        {
            return AdresaGateWay.Add(adresa); 
        }

        public List<Adresa> GetAll()
        {
            return AdresaGateWay.GetAll();
        }
        public bool Update(Adresa adresa)
        {
            return AdresaGateWay.Update(adresa);
        }
        public bool Delete(int id)
        {
            return AdresaGateWay.Delete(id);
        }

        public bool AdresaExist(int id)
        {
            return AdresaGateWay.AdresaExist(id);
        }

        public Adresa GetAdresa(int id)
        {
            return AdresaGateWay.GetAdresa(id);
        }
    }
}
