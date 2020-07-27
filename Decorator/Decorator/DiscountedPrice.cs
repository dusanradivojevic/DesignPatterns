using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DiscountedPrice : CarDecorator
    {
        public DiscountedPrice(ICar car) : base(car) { }
        public override double GetDiscountedPrice()
        {
            return .9 * base.GetPrice();
        }
    }
}
