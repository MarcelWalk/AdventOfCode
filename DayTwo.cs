using System.Linq;

namespace AdventOfCode{
    public class DayTwo{
        public static int Day2_P1(string[] corruptPasswds){

            var counter = 0;

            foreach (var dbEntry in corruptPasswds)
            {
                //0: Policy
                //1: CheckChar
                //2: Password
                var split = dbEntry.Split(" ");

                //0: Min
                //1: Max
                var minMax = split[0].Split('-');

                var checkchar = split[1].Replace(":", "");

                var charCount = split[2].Count(x => x.ToString() == checkchar);

                if( charCount >= int.Parse(minMax[0]) && charCount <= int.Parse(minMax[1])){
                    counter++;
                }    
            }

            return counter;
        }

        public static int Day2_P2(string[] corruptPasswds){

            var counter = 0;

            foreach (var dbEntry in corruptPasswds)
            {
                //0: Policy
                //1: CheckChar
                //2: Password
                var split = dbEntry.Split(" ");

                //0: I1
                //1: I2
                var index = split[0].Split('-').Select(x => int.Parse(x)).ToArray();

                var checkchar = split[1][0];

                var bothChar = split[2][index[0]-1] == checkchar && split[2][index[1]-1] == checkchar;
                var oneChar = split[2][index[0]-1] == checkchar || split[2][index[1]-1] == checkchar;
                if(!bothChar && oneChar)
                    counter++;
            }

            return counter;
        }
    }
}