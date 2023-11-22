using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class AdishCoffeeDecorator : Coffee
    {
        private Coffee _coffee;
        public AdishCoffeeDecorator(Coffee coffee) : base(0)
        {
            if (coffee == null)
            {
                throw new ArgumentNullException(nameof(coffee), "Кофе не может быть пустым.");
            }
            _coffee = coffee;
        }
        protected void AddAdish(double adishPrice)
        {
            _coffee.SetPrice(_coffee.Price() + adishPrice);
        }
        public override double Price()
        {
            return _coffee.Price();
        }
        public override void Print()
        {
            _coffee.Print();
        }
    }
}
