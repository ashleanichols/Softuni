﻿using System;

namespace WildFarm.Models.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
