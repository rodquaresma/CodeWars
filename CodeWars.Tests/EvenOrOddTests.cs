using CodeWars.Business;
using NUnit.Framework;

namespace CodeWars.Tests
{
    public class Tests
    {
        private EvenOrOddBusiness evenOrOddBusiness = new EvenOrOddBusiness();       
        

        [Test]
        public void MyTest()
        {
            Assert.That(evenOrOddBusiness.EvenOrOdd(2), Is.EqualTo("Even"));
            Assert.That(evenOrOddBusiness.EvenOrOdd(1), Is.EqualTo("Odd"));
            Assert.That(evenOrOddBusiness.EvenOrOdd(0), Is.EqualTo("Even"));
            Assert.That(evenOrOddBusiness.EvenOrOdd(7), Is.EqualTo("Odd"));
            Assert.That(evenOrOddBusiness.EvenOrOdd(-1), Is.EqualTo("Odd"));
        }
    }
}