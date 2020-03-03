﻿namespace WildFarm.Models.Animals
{
    public abstract class Bird : Animal
    {
        private double wingSize;

        public Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            this.wingSize = wingSize;
        }

        public double WingSize
        {
            get { return wingSize; }
            private set { wingSize = value; }
        }
    }
}
