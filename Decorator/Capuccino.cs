using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Capuccino : Coffee
    {
        public Capuccino() : base(25)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Цена капучино: {Price()}$");
        }
    }
}
