using System;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = File.ReadAllText("./Files/Day1.input").Split("\r\n");

            Console.WriteLine(DayOne.Day1_P2(input));

            Console.ReadLine();
        }
    }
}