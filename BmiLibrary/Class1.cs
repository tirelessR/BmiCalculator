using System;
using System.Collections.Generic;

namespace BmiLibrary
{
    public static class BmiCalculator
    {
        public static double MinHeight = 0;
        public static double MinWeight = 0;
        public static double MaxHeight = 3;
        public static double MaxWeight = 700;

        public static Dictionary<double, string> BmiDescriptions = new Dictionary<double, string>()
        {
            { 16, "Выраженный дефицит массы тела" },
            { 18.5, "Дефицит массы тела" },
            { 25, "Норма" },
            { 30, "Избыточная масса тела(предожирение)" },
            { 35, "Ожирение 1-й степени" },
            { 40, "Ожирение 2-й степени" },
            { Double.MaxValue, "Ожирение 3-й степени" }
        };
        public static string GetCommentAboutBmi(double bmi)
        {
            foreach (var pair in BmiDescriptions)
            {
                if (bmi < pair.Key)
                    return pair.Value;
            }
            return BmiDescriptions[Double.MaxValue];
        }
        
        /// <summary>
        /// Вычисляет индекс массы тела (ИМТ)
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double GetBmi(double weight, double height)
        {
            ValidationLibrary.ValidationHelper.CheckRangeValue(height,
                MinHeight,
                MaxHeight,
                $"Неверный рост: ожидалось от {MinHeight} до {MaxHeight}");
            ValidationLibrary.ValidationHelper.CheckRangeValue(weight,
                MinWeight,
                MaxWeight,
                $"Неверный вес: ожидалось от {MinWeight} до {MaxWeight}");
            return weight / Math.Pow(height, 2);
        }
        
    }
}