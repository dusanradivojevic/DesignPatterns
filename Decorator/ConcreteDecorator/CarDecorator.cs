﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CarDecorator : ICar
    {
        private ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public string Make => car.Make;

        public double GetPrice()
        {
            return car.GetPrice();
        }
        public abstract double GetDiscountedPrice();
    }
}
