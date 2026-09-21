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
            
            weight = ConsoleHelper.ConsoleHelper.ReadDoubleValue("Введите свой вес(кг): "); 
            height = ConsoleHelper.ConsoleHelper.ReadDoubleValue("Введите свой рост(м): ");
            
            var bmi = BmiCalculator.GetBmi(weight, height);
            Console.WriteLine($"Ваш ИМТ: {bmi:F1} \n {BmiCalculator.GetCommentAboutBmi(bmi)}");
            
        }
    }
}