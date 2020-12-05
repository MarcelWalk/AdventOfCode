using System;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = File.ReadAllText("./files/Day5.input").Split("\n");

            Console.WriteLine(DayFive.Day5_P2(input));

            Console.ReadLine();
        }
    }
}