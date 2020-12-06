using NUnit.Framework;
using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace AdventOfCode.Tests
{
    [TestFixture()]
    public class DayThreeTests
    {
        [Test()]
        public void Day3_P1Test()
        {
            var input = File.ReadAllLines("./Files/Day_3/Day3_Test.input");
            var inputArray = input.Select(x => x.ToCharArray()).ToArray();
            Assert.AreEqual(7, DayThree.Day3_P1(inputArray, 3, 1));
        }

        [Test()]
        public void Day3_P2Test()
        {
            var input = File.ReadAllLines("./Files/Day_3/Day3_Test.input");
            var inputArray = input.Select(x => x.ToCharArray()).ToArray();
            Assert.AreEqual(2, DayThree.Day3_P1(inputArray, 1, 1));
            Assert.AreEqual(7, DayThree.Day3_P1(inputArray, 3, 1));
            Assert.AreEqual(3, DayThree.Day3_P1(inputArray, 5, 1));
            Assert.AreEqual(4, DayThree.Day3_P1(inputArray, 7, 1));
            Assert.AreEqual(2, DayThree.Day3_P1(inputArray, 1, 2));
        }
    }
}