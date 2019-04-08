﻿using System;

namespace _02.Graduation
    {
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int i = 1;
            double sumOfGrades = 0;
            int countOfFailYears = 0;
            while (i <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                if (currentGrade >= 4 && currentGrade <= 6)
                {
                    sumOfGrades += currentGrade;
                    i++;
                }                
                else {
                    countOfFailYears++;
                    if (countOfFailYears > 1)
                    {
                        break;
                    }
                }            
            }
            if (countOfFailYears > 1)
            {
                Console.WriteLine($"{name} has been excluded at {i} grade");
            }
            else
            {
                double averageGrade = sumOfGrades / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
            }
        }
    }
}