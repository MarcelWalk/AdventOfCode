using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class DayFour
    {

        /*
        The expected fields are as follows:
        byr (Birth Year)
        iyr (Issue Year)
        eyr (Expiration Year)
        hgt (Height)
        hcl (Hair Color)
        ecl (Eye Color)
        pid (Passport ID)
        cid (Country ID) ALLOWED TO BE EMPTY
        */

        public static int Day4_P1(string[] passports)
        {
            var validationResults = new List<bool>();
                foreach (var p in passports)
                {

                if(
                    p.Contains("byr") &&
                    p.Contains("iyr") &&
                    p.Contains("eyr") &&
                    p.Contains("hgt") &&
                    p.Contains("hcl") &&
                    p.Contains("ecl") &&
                    p.Contains("pid")
                    ){
                        validationResults.Add(true);
                    } else{
                        validationResults.Add(false);
                    }
                }

return validationResults.Where(x=>x).Count();
        }

         public static int Day4_P2(string[] passports)
        {
            var validationResults = new List<bool>();
                foreach (var p in passports)
                {

                var fields = p.Split(new char[] { ' ', '\n' });

                try{

                    foreach (var field in fields)
                    {
                        var fieldSplit = field.Split(':');
                        switch(fieldSplit[0]){
                            case "byr": //four digits; at least 1920 and at most 2002
                                var byr = int.Parse(fieldSplit[1]);
                                if(fieldSplit[1].Length != 4 || (byr < 1920 || byr > 2002))
                                    throw new Exception("BYR Invalid");
                                break;
                            case "iyr": //four digits; at least 2010 and at most 2020
                                var iyr = int.Parse(fieldSplit[1]);
                                if(fieldSplit[1].Length != 4 || (iyr < 2010 || iyr > 2020))
                                    throw new Exception("IYR Invalid");
                                break;
                            case "eyr": //four digits; at least 2020 and at most 2030
                                var eyr = int.Parse(fieldSplit[1]);
                                if(fieldSplit[1].Length != 4 || (eyr < 2020 || eyr > 2030))
                                    throw new Exception("EYR Invalid");
                                break;
                            case "hgt": //If cm, the number must be at least 150 and at most 193.
                                        //If in, the number must be at least 59 and at most 76.
                                var hgt = int.Parse(fieldSplit[1].Replace("in","").Replace("cm",""));
                                if (fieldSplit[1].EndsWith("in"))
                                {
                                    if (hgt < 59 || hgt > 76)
                                    {
                                        throw new Exception("HGT Inch Invalid");
                                    }
                                }
                                else if (fieldSplit[1].EndsWith("cm"))
                                {
                                    if (hgt < 150 || hgt > 193)
                                    {
                                        throw new Exception("HGT CM Invalid");
                                    }
                                        
                                }
                                else
                                    throw new Exception("HGT Invalid");
                                break;
                            case "hcl": //a # followed by exactly six characters 0-9 or a-f
                                if(!Regex.IsMatch(fieldSplit[1],"^#[0-9a-f]{6}$"))
                                    throw new Exception("HCL Invalid");
                                break;
                            case "ecl": //exactly one of: amb blu brn gry grn hzl oth
                                string[] colors = new string[] { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

                                if(!colors.Any(x => x.ToLower() == fieldSplit[1]))
                                    throw new Exception("ECL Invalid");
                                break;
                            case "pid": //a nine-digit number, including leading zeroes.
                                if(fieldSplit[1].Count() != 9 && !long.TryParse(fieldSplit[1], out long res))
                                    throw new Exception("PID Invalid");
                                break; 

                            default:
                                break;
                        }
                    }
                        if(
                    p.Contains("byr") &&
                    p.Contains("iyr") &&
                    p.Contains("eyr") &&
                    p.Contains("hgt") &&
                    p.Contains("hcl") &&
                    p.Contains("ecl") &&
                    p.Contains("pid")
                    ){
                        validationResults.Add(true);
                    } else{
                        throw new Exception("Field/s Missing");
                    }
                    } catch(Exception e){
                        System.Console.WriteLine(e.Message);
                        validationResults.Add(false);
                    }
                }

            return validationResults.Where(x=>x).Count();
        }
    }
}