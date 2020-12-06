using System;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = File.ReadAllText("./Files/Day6.input").Split("\r\n\r\n");

            Console.WriteLine(DaySix.Day6_P2(input));

            Console.ReadLine();
        }
    }
}