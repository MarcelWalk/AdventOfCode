using System.IO;
using System;
using System.Linq;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("./files/Day2.input");
            System.Console.WriteLine(DayTwo.Day2_P2(input));
            System.Console.ReadLine();      
        }
    }
}
