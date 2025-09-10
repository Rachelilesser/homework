using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class lesson1
    {
        static void Main(string[] args)
        {


            
            Student[] stu = { new Student()
                                    { Id = "12121212",
                                      Name = "racheli",
                                      BirthDate = new DateTime(2004, 9, 10),
                                     Class='a',
                                      Markavg=100

                                    },
                                    
                                      new Student()
                                    { Id = "2424242",
                                      Name = "naama",
                                      BirthDate = new DateTime(2005, 10, 10),
                                      Class='b',
                                       Markavg=85},
                                    new Student()
                                    { Id = "6767667667",
                                      Name = "dina",
                                      BirthDate = new DateTime(2007, 10, 12),
                                    Class='c',
                                     Markavg=96},

                                      new Student()
                                    { Id = "65657543",
                                      Name = "sara",
                                      BirthDate = new DateTime(2006, 10, 12),
                                      Class='b',
                                       Markavg=88},
                                     new Student()
                                    { Id = "99999999999",
                                      Name = "libi",
                                      BirthDate = new DateTime(2005, 10, 10),
                                      Class='a',
                                       Markavg=70}






            };
            var Big = (from s in stu
                          where s.BirthDate.Year < 2006
                          select new{ Name = s.Name, Id = s.Id }).ToArray();
            var Smart = (from s in stu
                       where s.Markavg>50
                       orderby s.Markavg
                         select new { Name = s.Name, Markavg = s.Markavg }).ToArray();
            var names = (from s in stu
                       orderby s.Name
                       select new { Name = s.Name }).ToArray();
            var Class = (from s in stu
                       where s.Class=='a'
                       select new { Name = s.Name, Id = s.Id ,s.Class}).ToArray();
            var month = (from s in stu
                       where s.BirthDate.Month ==12
                       select new { Name = s.Name,s.BirthDate }).ToArray();


            Console.WriteLine(Big);
            Console.WriteLine(Smart);
            Console.WriteLine(names);
            Console.WriteLine(Class);
            Console.WriteLine(month);



            Console.ReadLine();
        }
    }
}
