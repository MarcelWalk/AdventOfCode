using System;

namespace AdventOfCode
{
    public class DayThree
    {
        public static long Day3_P1(char[][] map,int right, int down)
        {
            var x = 0;

            //counting all the trees
            long treeCounter = 0;

            //You start on the open square (.) in the top-left corner
            for (var y = 0; y < map.Length; y+= down) // down 1
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

                //right 3
                x += right;
                if (x >= map[y].Length)
                    x -= map[y].Length;
            }
            return treeCounter;
        }
    }
}