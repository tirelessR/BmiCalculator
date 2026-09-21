using System;
using NUnit.Framework;
using BmiLibrary;


namespace BmiTestProject
{
    [TestFixture]
    public class Tests
    {

        [TestCase(80, 1.7)]
        [TestCase(60, 1.8)]
        public void HappyPath(double weight, double height)
        {
            double calculated = Math.Round(BmiCalculator.GetBmi(weight, height), 2);
            double expected = Math.Round(weight / Math.Pow(height, 2), 2);

            Assert.That(calculated, Is.EqualTo(expected).Within(0.01));
        }

    }
}