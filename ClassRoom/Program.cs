using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom Class=new ClassRoom("3Q",new List<Student>(), new DateTime(2019,08,28));
            Class.ClassList.Add(new Student("Paula-Catalina Curca", 07, 17));
            Class.ClassList.Add(new Student("Radu Adumitroaei",10,03));
            Class.ClassList.Add(new Student("Alex Lazaroiu", 05, 23));
            Class.ClassList.Add(new Student("Kristaps Mezatucs", 11, 04));

            foreach (var VARIABLE in Class.ClassList)
            {
                Console.WriteLine(VARIABLE.Name + VARIABLE.BirthDay+ VARIABLE.BirthMonth);
            }

            Console.ReadKey();
        }
    }
}
