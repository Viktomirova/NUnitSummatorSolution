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
            int actual = SummatorClass.Sum(new int[] { 2000000000, 2000000000, 2000000000 });
            Assert.AreNotEqual(actual, 6000000000);
        }
        
        [Test]
        public void TestAverageTwoPositiveNumbers()
        {
            int result = SummatorClass.Average(new int[]{5, 7});
            Assert.That(result == 6);
        }
    }
}