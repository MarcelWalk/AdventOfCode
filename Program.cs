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

            Console.WriteLine(DayThree.Day3_P1(inputArray));
            Console.ReadLine();
        }
    }
}