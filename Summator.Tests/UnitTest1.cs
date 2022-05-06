using NUnit.Framework;

using System;

namespace Summator.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category ("Important")]
        public void TestSumTwoPositiveNumbers()
        {
            int result = SummatorClass.Sum(new int[]{5, 2});
            Assert.That(result == 7);
        }
        
        [Test]
        [Category ("Low")]
        public void TestSumOnePositiveNumber()
        {
            int result = SummatorClass.Sum(new int[]{5});
            Assert.That(result == 5);
        }
        
        [Test]
        [Category ("Important")]
        public void TestSumTwoNegativeNumbers()
        {
            int result = SummatorClass.Sum(new int[]{-5, -2});
            Assert.That(result == -7);
        }
        
        [Test]
        [Category ("Critical")]
        public void TestSumEmptyArray()
        {
            int result = SummatorClass.Sum(new int[]{});
            Assert.That(result == 0);
        }

        [Test]
        [Category ("Low")]
        public void TestSumBigNumbers()
        {
            int actual =  SummatorClass.Sum(new int[]{ 2000000000, 2000000000, 2000000000 });
            Assert.That(actual < int.MaxValue);
        }
        
        [Test]
        [Category ("Important")]
        public void TestAverageTwoPositiveNumbers()
        {
            double result = SummatorClass.Average(new int[]{5, 7});
            Assert.That(result == 6);
        }
        
        [Test]
        [Category ("Important")]
        public void TestAverageTwoRealNumbers()
        {
            double result = SummatorClass.Average(new int[]{-5, -8});
            double expected = -6.5;
            Assert.That(result,Is.EqualTo(expected));
        }
        
        [Test]
        [Category ("Critical")]
        public void TestAverageEmptyArray()
        {
            double result = SummatorClass.Average(new int[]{});
            Assert.That(result,Is.EqualTo(0));
        }
    }
}
