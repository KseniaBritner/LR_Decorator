using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Discount : AdishCoffeeDecorator
    {
        public Discount(Coffee coffee) : base(coffee)
        {
        }
        public override double Price()
        {
            return base.Price() * 0.95; 
        }
        public override void Print()
        {
            Console.WriteLine($"Кофе со скидкой: {Price()} руб");
        }
    }
}
