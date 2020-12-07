using System;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = File.ReadAllText("./Files/Day7.input").Split("\r\n");
            Console.WriteLine(DaySeven.Day7_P1(input));

            Console.ReadLine();
        }
    }
}