using AdventOfCode21.Common;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode21.Day2
{
    public class Program : Base
    {
        static void Main(string[] args)
        {
            var input = LoadInput("Day2")
                .Select(x => {
                    var line = x.Split(" ");
                    
                    return (line[0], Convert.ToInt32(line[1]));
                });

            Console.WriteLine($"Task1 answer: {Task1(input)}");
            Console.WriteLine($"Task1 answer: {Task2(input)}");
        }

        public static int Task1(IEnumerable<(string, int)> input)
        {
            var xPos = 0;
            var yPos = 0;

            foreach((string direction, int value) in input)
            {
                switch (direction)
                {
                    case "forward":
                        xPos += value;
                        break;
                    case "up":
                        yPos -= value;
                        break;
                    case "down":
                        yPos += value;
                        break;
                    default:
                        break;
                }
            }

            return xPos * yPos;
        }

        public static int Task2(IEnumerable<(string, int)> input)
        {
            var xPos = 0;
            var yPos = 0;
            var aim = 0;

            foreach ((string direction, int value) in input)
            {
                switch (direction)
                {
                    case "forward":
                        xPos += value;
                        yPos += (value * aim);
                        break;
                    case "up":
                        aim -= value;
                        break;
                    case "down":
                        aim += value;
                        break;
                    default:
                        break;
                }
            }

            return xPos * yPos;
        }
    }
}
