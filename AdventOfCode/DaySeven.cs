using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class DaySeven
    {
        public static int Day7_P1(string[] input)
        {
            var types = GetBagTypes(input);

            var containsDirectly = types.Where(x => x.Value.Contains("shiny gold")).Select(x => x.Key);

            var res = GetPossiblities(containsDirectly, types, 0);

            return res;
        }

        public static int Day7_P2(string[] groups)
        {
            return 0;
        }

        private static int GetPossiblities(IEnumerable<string> contains, Dictionary<string, List<string>> types, int count)
        {
            var needsLookup = new List<string>();

            foreach (var item in contains)
            {
                var containsIndirect = types.Where(x => x.Value.Contains(item.Trim())).Select(x => x.Key);
                var x = containsIndirect.Count();
                needsLookup.AddRange(containsIndirect);
            }
            if (needsLookup.Count() != 0)
            {
                count += needsLookup.Count();
                return GetPossiblities(needsLookup, types, count);
            }
            else
            {
                return count;
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