using AdventOfCode21.Common;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode21.Day1
{
    public class Program : Base
    {
        static void Main(string[] args)
        {
            var input = LoadInput("Day1")
                .Select(x => Convert.ToInt32(x));

            Console.WriteLine($"Task1 answer: {Task1(input)}");
            Console.WriteLine($"Task1 answer: {Task2(input)}");
        }

        public static int Task1(IEnumerable<int> input)
        {
            var counter = 0;
            var prev = int.MaxValue;            
            foreach (int number in input)
            {
                if (number > prev) counter++;
                prev = number;
            }

            return counter;
        }

        public static int Task2(IEnumerable<int> input)
        {
            var windowedInput = input
                .Window(3)
                .Select(item => item.Sum());

            return Task1(windowedInput);
        }
    }
}
