using System;
using NUnit.Framework;
using BmiLibrary;


namespace BmiTestProject
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Happy1()
        {
            double weight = 80, height = 1.7;
            
            double calculated = Math.Round(BmiCalculator.GetBmi(weight, height), 2);

            Assert.That(calculated, Is.EqualTo(27.68));
        }
    }
}