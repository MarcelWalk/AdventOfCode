using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    public class DayOne
    {
        public static int Day1_P1(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    //Skip if both are at the same index
                    if (i != j)
                    {
                        if (int.Parse(input[i]) + int.Parse(input[j]) == 2020)
                            return int.Parse(input[i]) * int.Parse(input[j]);
                    }
                }
            }

            throw new ArgumentNullException("Could not find number");
        }

        public static int Day1_P2(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    for (int k = 0; k < input.Length; k++)
                    {
                        //Skip if both are at the same index
                        if (i != j && i != k && j != k)
                        {
                            if (int.Parse(input[i]) + int.Parse(input[j]) + int.Parse(input[k]) == 2020)
                                return int.Parse(input[i]) * int.Parse(input[j]) * int.Parse(input[k]);
                        }
                    }

                }
            }
            throw new ArgumentNullException("Could not find number");
        }
    }
}
