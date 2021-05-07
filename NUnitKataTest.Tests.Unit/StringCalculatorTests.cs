using NUnit.Framework;
using NUnitKataTest.Lib;
using System;

namespace NUnitKataTest.Tests.Unit
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void Add_EmptyString_ReturnZero(string numbers)
        {
            var result = StringCalculator.Add(numbers);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase("0", 0)]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("100", 100)]
        public void Add_SingleNumberInString_ReturnNumberInt(string numbers, int expectedResult)
        {
            var result = StringCalculator.Add(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("1,2,3", 6)]
        [TestCase("45,100,40", 185)]
        public void Add_DefultDelimitersInString_ReturnSum(string numbers, int expectedResult)
        {
            var result = StringCalculator.Add(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("1\n2\n3", 6)]
        [TestCase("45\n40", 85)]
        public void Add_NewLineDelimitersInString_ReturnSum(string numbers, int expectedResult)
        {
            var result = StringCalculator.Add(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("0,2,1000", 1002)]
        [TestCase("0,2,1001", 2)]
        public void Add_MoreThanThousandNumberInString_IgnoreThatNumber(string numbers, int expectedResult)
        {
            var result = StringCalculator.Add(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("//*\n1*2", 3)]
        [TestCase("//*#\n1*2#3", 6)]
        [TestCase("//**\n1**2", 3)]
        public void Add_DefineDelimiterInString_UseNewDelimiter(string numbers, int expectedResult)
        {
            var result = StringCalculator.Add(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("1,-1", -1)]
        public void Add_NegativeNumberInString_ThrowException(string numbers, int negativeNumber)
        {
            var exception = Assert.Throws<ArgumentException>(() => StringCalculator.Add(numbers));
            Assert.That(exception.Message
                , Is.EqualTo(String.Format("string contains [{0}], which does not meet rule. entered number should not negative.", negativeNumber)));
        }
    }
}
