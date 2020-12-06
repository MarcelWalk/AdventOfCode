using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class DayFive
    {
        public static int Day5_P1(string[] inp)
        {

            var takenSeats = new List<int>();

            foreach (var item in inp)
            {
                var row = SpacePartitioning(item.Take(7).ToArray(), 128);
                var column = SpacePartitioning(item.Replace("R","B").Replace("L","F").Skip(7).ToArray(), 8);
                takenSeats.Add(row * 8 + column);
            }
            return takenSeats.OrderBy(x=>x).Last();
        }

        public static int Day5_P2(string[] inp)
        {
            var takenSeats = new List<int>();

            foreach (var item in inp)
            {
                var row = SpacePartitioning(item.Take(7).ToArray(), 128);
                var column = SpacePartitioning(item.Replace("R","B").Replace("L","F").Skip(7).ToArray(), 8);
                takenSeats.Add(row * 8 + column);
            }

            for (int i = takenSeats.OrderBy(x=>x).First(); i < takenSeats.OrderBy(x=>x).Last(); i++)
            {
                if(!takenSeats.Contains(i+1))
                    return i + 1;
            }

            throw new Exception("Seat not found");
        }

        //F -> Lower Half
        //B -> Upper Half
        private static int SpacePartitioning(char[] instructions, int count)
        {

            List<int> numberList = new List<int>();

            //Replicate Rows / Columns
            for (int i = 0; i < count; i++)
            {
                numberList.Add(i);
            }

            foreach (char ins in instructions)
            {

                var half = count / 2;

                switch (ins)
                {
                    case 'F':
                        numberList = numberList.Take(half).ToList();
                        break;

                    case 'B':
                        numberList.RemoveRange(0, half);
                        break;
                }

                count = half;
            }

            if (numberList.Count == 1)
                return numberList.First();
            else
                throw new Exception("Too many rows/columns left");
        }
    }
}