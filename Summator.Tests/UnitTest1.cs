using NUnit.Framework;

using System;

namespace Summator.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSumTwoPositiveNumbers()
        {
            int result = SummatorClass.Sum(new int[]{5, 2});
            Assert.That(result == 7);
        }
        
        [Test]
        public void TestSumOnePositiveNumber()
        {
            int result = SummatorClass.Sum(new int[]{5});
            Assert.That(result == 5);
        }
        
        [Test]
        public void TestSumTwoNegativeNumbers()
        {
            int result = SummatorClass.Sum(new int[]{-5, -2});
            Assert.That(result == -7);
        }
        
        [Test]
        public void TestSumEmptyArray()
        {
            int result = SummatorClass.Sum(new int[]{});
            Assert.That(result == 0);
        }

        [Test]
        public void TestSumBigNumbers()
        {
            int actual =  SummatorClass.Sum(new int[]{ 2000000000, 2000000000, 2000000000 });
            Assert.That(actual < int.MaxValue);
        }
        
        [Test]
        public void TestAverageTwoPositiveNumbers()
        {
            double result = SummatorClass.Average(new int[]{5, 7});
            Assert.That(result == 6);
        }
        
        [Test]
        public void TestAverageTwoRealNumbers()
        {
            double result = SummatorClass.Average(new int[]{-5, -8});
            double expected = -6.5;
            Assert.That(result,Is.EqualTo(expected));
        }
        
        [Test]
        public void TestAverageEmptyArray()
        {
            double result = SummatorClass.Average(new int[]{});
            Assert.That(result,Is.EqualTo(0));
        }
    }
}