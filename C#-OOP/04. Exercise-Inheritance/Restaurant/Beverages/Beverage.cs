﻿namespace Restaurant
{
    public class Beverage : Product
    {
        protected Beverage(string name, decimal price, double milliliters) 
            : base(name, price)
        {
            this.Milliliters = milliliters;
        }

        public double Milliliters { get; set; }
    }
}
