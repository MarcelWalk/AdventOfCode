using System;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = File.ReadAllLines("./files/Day3.input");
            var inputArray = input.Select(x => x.ToCharArray()).ToArray();

            var p1 = DayThree.Day3_P1(inputArray, 1, 1);
            var p2 = DayThree.Day3_P1(inputArray, 3, 1);
            var p3 = DayThree.Day3_P1(inputArray, 5, 1);
            var p4 = DayThree.Day3_P1(inputArray, 7, 1);
            var p5 = DayThree.Day3_P1(inputArray, 1, 2);

            long res = p1 * p2 * p3 * p4 * p5;

            Console.ReadLine();
        }
    }
}