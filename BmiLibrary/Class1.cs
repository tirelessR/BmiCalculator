using System;
using System.Collections.Generic;

namespace BmiLibrary
{
    public static class BmiCalculator
    {
        public static double minHeight = 0;
        public static double minWeight = 0;
        public static double maxHeight = 3;
        public static double maxWeight = 700;

        public static Dictionary<double, string> BmiDescriptions = new Dictionary<double, string>()
        {
            { 16, "Выраженный дефицит массы тела" },
            { 18.5, "Дефицит массы тела" },
            { 25, "Норма" },
            { 30, "Избыточная масса тела(предожирение)" },
            { 35, "Ожирение 1-й степени" },
            { 40, "Ожирение 2-й степени" },
            { Double.MaxValue, "Король жирных" }
        };
        public static string GetCommentAboutBmi(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Мало";
            }
            else if (bmi <= 25)
            {
                return "Норм";
            }
            else return "Ты вообще жирный";
        }
        
        /// <summary>
        /// Вычисляет индекс массы тела (ИМТ)
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double getBmi(double weight, double height)
        {
            ValidationLibrary.ValidationHelper.CheckRangeValue(height,
                minHeight,
                maxHeight,
                $"Неверный рост: ожидалось от {minHeight} до {maxHeight}");
            ValidationLibrary.ValidationHelper.CheckRangeValue(weight,
                minWeight,
                maxWeight,
                $"Неверный вес: ожидалось от {minWeight} до {maxWeight}");
            return weight / Math.Pow(height, 2);
        }
        
    }
}