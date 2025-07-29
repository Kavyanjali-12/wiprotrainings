//importing NUnit TEst Frameworks
using NUnit.Framework;     // allows you to use [Test], Assert, etc.
using CalculatorApp;       // gives access to the Calculator class
namespace mathLibrary
{
    public class Tests
    {
        private Calculator calc;
        [SetUp]  // attribute: runs this method before every [Test] method
        public void Setup()
        {
            calc = new Calculator();  //allocating memory using 'new'
        }

        [Test]      // this method is a unit test
        public void Adding()
        {
            // Assert.Pass();  for passing the flow of execution
            int result = calc.Add(2, 3);      // calling Add() method
            Assert.AreEqual(5, result);      // checks if result is 5
        }
        [Test]
        public void Subtracting()
        {
            //Assert.Pass();
            int result = calc.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }
    }
}