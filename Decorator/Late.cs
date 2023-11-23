using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Late : Coffee
    {
        public Late() : base(20)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Цена лате: {Price()} руб");
        }
    }
}
