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
        [TestCase(700, 3)]
        public void HappyPath(double weight, double height)
        {
            double calculated = Math.Round(BmiCalculator.GetBmi(weight, height), 2);
            double expected = Math.Round(weight / Math.Pow(height, 2), 2);

            Assert.That(calculated, Is.EqualTo(expected).Within(0.01));
        }

        [TestCase(80, -1.7)]
        [TestCase(-50, 1.5)]
        [TestCase(-75, -1.8)]
        public void TestForNegativeValues(double weight, double height)
        {
            Assert.Throws<ArgumentException>(() =>  BmiCalculator.GetBmi(weight, height));
        }
        
        [TestCase(80, 3.01)]
        [TestCase(54, 500)]
        [TestCase(65, double.MaxValue)]
        public void TestForHeightHigherThanMax(double weight, double height)
        {
            Assert.Throws<ArgumentException>(() =>  BmiCalculator.GetBmi(weight, height));
        }
        
        [TestCase(701, 1.8)]
        [TestCase(15000, 1.67)]
        [TestCase(double.MaxValue, 1.84)]
        public void TestForWeightHigherThanMax(double weight, double height)
        {
            Assert.Throws<ArgumentException>(() =>  BmiCalculator.GetBmi(weight, height));
        }

    }
}