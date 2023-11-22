using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Limon : AdishCoffeeDecorator
    {
        public Limon(Coffee coffee) : base(coffee)
        {
            AddAdish(2);
        }
        public override void Print()
        {
            Console.WriteLine($"Цена кофе с лимоном: {Price()}$");
        }
    }
}
