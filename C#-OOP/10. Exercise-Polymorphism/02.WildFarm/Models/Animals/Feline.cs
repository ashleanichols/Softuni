﻿namespace WildFarm.Models.Animals
{
    public abstract class Feline : Mammal
    {
        private string breed;

        protected Feline(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion)
        {
        }


        public string Breed
        {
            get { return breed; }
            private set { breed = value; }
        }

    }
}
