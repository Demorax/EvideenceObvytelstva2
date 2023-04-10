using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvideenceObvytelstva2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string OborStudia { get; set; }
        public int Rocnik { get; set; }

        public int SkolaId { get; set; }

        public virtual ICollection<Osoba> Osobas { get; set; }
        public virtual Skola Skola { get; set; }

        public Student() { }

        public Student(int id, string oborStudia, int rocnik, int skolaId)
        {
            Id = id;
            OborStudia = oborStudia;
            Rocnik = rocnik;
            SkolaId = skolaId;
        }

        public Student(string oborStudia, int rocnik, int skolaId)
        {
            OborStudia = oborStudia;
            Rocnik = rocnik;
            SkolaId = skolaId;
        }

        public override string? ToString()
        {
            return $"{OborStudia}, {Rocnik}";
        }
    }



}
