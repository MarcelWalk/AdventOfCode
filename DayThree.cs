using System;

namespace AdventOfCode
{
    public class DayThree
    {
        public static int Day3_P1(char[][] map)
        {
            /*
            Starting at the top-left corner of your map and following a slope of right 3 and down 1, how many trees would you encounter?
            */
            var x = 0;
            var treeCounter = 0;
            for (var y = 0; y < map.Length; y++)
                if (x < map[y].Length)
                {
                    Console.Write($"{y}, {x} | ");
                    switch (map[y][x])
                    {
                        case '.':
                            Console.WriteLine("Open");
                            break;
                        case '#':
                            Console.WriteLine("Tree");
                            treeCounter++;
                            break;
                    }

                    x += 3;
                }
                else
                {
                    x = 3;
                }

            return treeCounter;
        }
    }
}