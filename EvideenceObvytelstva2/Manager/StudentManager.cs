using EvideenceObvytelstva2.Gateway;
using EvideenceObvytelstva2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvideenceObvytelstva2.Manager
{
    public class StudentManager
    {
        StudentGateWay studentGateWay = new StudentGateWay();

        public bool Add(Student student)
        {
            return studentGateWay.Add(student); 
        }

        public List<Student> GetAll()
        {
            return studentGateWay.GetAll();
        }
        public bool Update(Student student)
        {
            return studentGateWay.Update(student);
        }
        public bool Delete(int id)
        {
            return studentGateWay.Delete(id);
        }

        public bool StudentExist(int? id)
        {
            return studentGateWay.StudentExist(id);
        }

        public Student GetStudent(int id)
        {
            return studentGateWay.GetStudent(id);
        }
    }
}
