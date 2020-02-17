﻿using System.Collections.Generic;

namespace PizzaCalories
{
    public static class ToppingValidator
    {
        private static Dictionary<string, double> toppingType;

        public static bool IsValid(string type)
        {
            Initialize();
            return toppingType.ContainsKey(type.ToLower());
        }

        public static double GetModifier(string type)
        {
            Initialize();
            return toppingType[type.ToLower()];
        }

        public static void Initialize()
        {
            if (toppingType == null)
            {                
                toppingType = new Dictionary<string, double>();

                toppingType.Add("meat", 1.2);
                toppingType.Add("veggies", 0.8);
                toppingType.Add("cheese", 1.1);
                toppingType.Add("sauce", 0.9);
            }
        }
    }
}
