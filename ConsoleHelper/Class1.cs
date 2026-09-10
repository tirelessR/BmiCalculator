using System;

namespace ConsoleHelper
{
    public class ConsoleHelper
    {
        /// <summary>
        /// Читает значение с консоли <see cref="message"/>
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Введённое значение</returns>
        public static double ReadDoubleValue(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
        }
    }
}