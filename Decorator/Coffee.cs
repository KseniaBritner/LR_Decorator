using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Coffee
    {
        private double _price;
        public Coffee(double basePrice)
        {
            if (basePrice < 0)
            {
                throw new ArgumentException("Цена кофе не может быть отрицательной.", nameof(basePrice));
            }

            _price = basePrice;
        }

        public virtual double Price()
        {
            return _price;
        }

        public void SetPrice(double price)
        {
            if (price < 0)
            {
                throw new ArgumentException("Цена кофе не может быть отрицательной.", nameof(price));
            }

            _price = price;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Цена кофе: {Price()}$");
        }
    }
}
