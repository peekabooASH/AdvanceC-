using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculater aCalculater=new Calculater();
           
            Console.WriteLine( aCalculater.Add(10, 20));
            Console.WriteLine(aCalculater.Sub(20, 10));
            int a = 100;
            bool istrue= a.isBigger();
            Console.WriteLine(istrue);

        

            Student aStudent=new Student(){Name = "ash",RegNo = "101"};
            List<Student> students=new List<Student>()
            {
              new Student(){Name="Ash",RegNo ="101" },
              new Student(){Name="Asm",RegNo ="102" }
            };
            foreach (var student in students)
            {
                Console.WriteLine(student.Name+" "+student.RegNo);

            }
            var aList = new[]
            {
                new{ Name="ash",RegNo="101"},
                 new{ Name="asm",RegNo="102"}
                
            };

            Show(aList);
            Console.ReadKey();
        }

        private static void Show(IEnumerable<dynamic>  aList)
        {
            foreach (var aValue in aList)
            {
                Console.WriteLine(aValue.Name+" "+aValue.RegNo);
            }
        }
    }
}
