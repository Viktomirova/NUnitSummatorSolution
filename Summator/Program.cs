using System;

namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SummatorClass.Sum(new int[] {1, 2, 3, 4, 5, 6}));
            Console.WriteLine(SummatorClass.Average(new int[] {-5, -8}));
        }
    }
}
