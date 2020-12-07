using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public class DaySeven
    {
        static Dictionary<string, List<string>> types;
        static HashSet<string> set = new HashSet<string>();

        public static int Day7_P1(string[] input)
        {
            types = GetBagTypes(input);

            GetPossiblities("shiny gold");
            return set.Count;
        }

        public static int Day7_P2(string[] groups)
        {
            return 0;
        }

        //Surrendered -> Rework!
        static void GetPossiblities(string bag)
        {
            foreach (var pair in types.Where(p => p.Value.Contains(bag)))
            {
                set.Add(pair.Key);
                GetPossiblities(pair.Key);
            }
        }


        private static Dictionary<string, List<string>> GetBagTypes(string[] input)
        {
            var bagTypes = new Dictionary<string, List<string>>();

            foreach (var item in input)
            {
                var bagSplit = item.Split("contain")
                    .Select(x => x.Trim())
                    .ToList();

                var containedBags = bagSplit[1].ToLower()
                    .Replace("bags", "")
                    .Replace("bag", "")
                    .Replace(".", "")
                    .Split(",")
                    .Select(x => x.Trim()).Where(x => x != "no other")
                    .Select(x => x.Split()[1] + " " + x.Split()[2])
                    .ToList();

                bagTypes.Add(bagSplit[0].Replace("bags", "").Replace("bag", "").Trim(), containedBags);
            }

            return bagTypes;
        }
    }
}