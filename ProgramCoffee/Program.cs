using System;
using Decorator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCoffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Syrup syrupLatte = new Syrup(new Late());
            syrupLatte.Print();
            Limon limonCappuccino = new Limon(new Capuccino());
            limonCappuccino.Print();
            Console.ReadLine();
        }
    }
}
