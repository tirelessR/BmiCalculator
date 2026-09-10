using System;
using BmiLibrary;

namespace ConsoleApplication1
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            double weight;
            double height;
            
            weight = ConsoleHelper.ConsoleHelper.ReadDoubleValue("Введите свой вес: "); 
            height = ConsoleHelper.ConsoleHelper.ReadDoubleValue("Введите свой рост(м): ");
            
            var bmi = BmiLibrary.BmiCalculator.getBmi(weight, height);
            Console.WriteLine("BMI: " + bmi + "\n" + BmiCalculator.GetCommentAboutBmi(bmi));
            
        }
    }
}