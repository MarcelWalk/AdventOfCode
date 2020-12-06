using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class DaySix
    {
        public static int Day6_P1(string[] groups)
        {
            var counter = 0;

            foreach (var grp in groups)
            {
                var persons = grp.Split("\r\n");
                var answerList = new List<char>();

                foreach (var pers in persons)
                {
                    var answers = pers.ToCharArray();
                    foreach (var ans in answers)
                    {
                        if (!answerList.Contains(ans))
                            answerList.Add(ans);
                    }

                }

                System.Console.WriteLine("Group Result = " + answerList.Count);
                counter += answerList.Count;
            }

            return counter;
        }
        public static int Day6_P2(string[] groups)
        {
            var groupedChars = groups.Select(x => x.Split("\r\n").Aggregate((a,b) => a+b).ToCharArray().GroupBy(x=>x).Select(grp => new { Char = grp.Key, Count = grp.Count() })).ToArray();
            var neededAmount = groups.Select(x => x.Split("\r\n").Count()).ToArray();
            var counter = 0;

            for (int i = 0; i < groupedChars.Count(); i++)
            {
                var x = groupedChars[i].Where(x=> x.Count == neededAmount[i]).Count();
                counter += x;
            }

            return counter;
        }
    }
}