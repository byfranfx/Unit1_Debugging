using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1_Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.FirstName = "Fran";
            p.LastName = "Gomez";

            Console.WriteLine(p.FunkyNameBuilder());
            Console.ReadLine();
        }
    }
}
