using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Syrup : AdishCoffeeDecorator
    {
        public Syrup(Coffee coffee) : base(coffee)
        {
            AddAdish(3);
        }
        public override void Print()
        {
            Console.WriteLine($"Цена кофе с сиропом: {Price()}$");
        }
    }
}
