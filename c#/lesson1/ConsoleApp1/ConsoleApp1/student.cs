using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public char Class { get; set; }
        public double Markavg { get; set; }
        public Student()
        {
            
        }
        public Student(string Id, string Name, DateTime BirthDate, char Class, double Markavg)
        {
            this.Id = Id;
            this.Name = Name;
            this.BirthDate = BirthDate;
            this.Class = Class;
            this. Markavg =  Markavg;

        }
    }
}
