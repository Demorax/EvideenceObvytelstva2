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
    public class StudentGateWay
    {
        ApplicationDB database = new ApplicationDB();
        SkolaManager skolaManager = new SkolaManager();

        public bool Add(Student student)
        {
            if (skolaManager.SkolaExist(student.SkolaId))
            {
                database.Add(student);
            }
            return database.SaveChanges() > 0;
        }

        public List<Student> GetAll()
        {
            return database.Students.ToList();
        }

        public bool Update(Student student)
        {
            var gate = database.Students.FirstOrDefault(e => e.Id == student.Id);
            if (gate == null)
            {
                return false;
            }
            if (skolaManager.SkolaExist(student.SkolaId))
            {
                gate.Id = student.Id;
                gate.Rocnik = student.Rocnik;
                gate.OborStudia = student.OborStudia;
                gate.SkolaId = student.SkolaId;
            }

            return database.SaveChanges() > 0;
        }

        public bool Delete(int id) 
        {
            var skola = database.Students.FirstOrDefault(e => e.Id == id);
            if (skola == null)
            {
                return false;
            }
            database.Students.Remove(skola);
            return database.SaveChanges() > 0;
        }

        public bool StudentExist(int? id)
        {
            using (var tempDb = new ApplicationDB())
            {
                return tempDb.Students.Any(e => e.Id == id);
            }
        }

        public Student GetStudent(int id)
        {
            using (var tempDb = new ApplicationDB())
            {
                return tempDb.Students.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
