using System;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = File.ReadAllText("./files/Day4.input").Split("\n\n");

            Console.WriteLine(DayFour.Day4_P2(input));

            Console.ReadLine();
        }
    }
}