using NUnit.Framework;

using System;

namespace Summator.Tests
{
    [TestFixture]
    public class SummatorTests
    {
        Summator summator;

        [SetUp]
        public void Setup()
        {
            summator = new Summator();
            //Console.WriteLine("Test started: " + DateTime.Now);
        }

        //[OneTimeSetUp]
        //public void OneTimeSetup()
        //{
        //    summator = new SummatorClass();
        //    Console.WriteLine("All Tests started: " + DateTime.Now);
        //}

        [Test]
        [Category ("Important")]
        public void TestSumTwoPositiveNumbers()
        {
            int result = summator.Sum(new int[]{5, 2});
            Assert.That(result == 7);
        }
        
        [Test]
        [Category ("Low")]
        public void TestSumOnePositiveNumber()
        {
            int result = summator.Sum(new int[]{5});
            Assert.That(result == 5);
        }
        
        [Test]
        [Category ("Important")]
        public void TestSumTwoNegativeNumbers()
        {
            int result = summator.Sum(new int[]{-5, -2});
            Assert.That(result == -7);
        }
        
        [Test]
        [Category ("Critical")]
        public void TestSumEmptyArray()
        {
            int result = summator.Sum(new int[]{});
            Assert.That(result == 0);
        }

        [Test]
        [Category ("Low")]
        public void TestSumBigNumbers()
        {
            long actual =  summator.SumBig(new int[]{ 2000000000, 2000000000, 2000000000 });
            Assert.That(actual == 6000000000);
        }
        
        [Test]
        [Category ("Important")]
        public void TestAverageTwoPositiveNumbers()
        {
            double result = summator.Average(new int[]{5, 7});
            Assert.That(result == 6);
        }
        
        [Test]
        [Category ("Important")]
        public void TestAverageTwoRealNumbers()
        {
            double result = summator.Average(new int[]{-5, -8});
            double expected = -6.5;
            Assert.That(result,Is.EqualTo(expected));
        }
        
        [Test]
        [Category ("Critical")]
        public void TestAverageEmptyArray()
        {
            double result = summator.Average(new int[]{});
            Assert.That(result,Is.EqualTo(0));
        }

        [TearDown]
        public void TearDown()
        {
            summator = null;
            //Console.WriteLine("Test ended: " + DateTime.Now);
        }

        //[OneTimeTearDown]
        //public void OneTimeTearDown()
        //{
        //    summator = null;
        //    Console.WriteLine("All Tests ended: " + DateTime.Now);
        //}
    }
}