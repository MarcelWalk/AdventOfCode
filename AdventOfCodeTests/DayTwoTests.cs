using NUnit.Framework;
using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdventOfCode.Tests
{
    [TestFixture()]
    public class DayTwoTests
    {
        [Test()]
        public void Day2_P1Test()
        {
            var input = File.ReadAllText("./Files/Day_2/Day2_Test.input").Split("\r\n");
            Assert.AreEqual(2, DayTwo.Day2_P1(input));
        }

        [Test()]
        public void Day2_P2Test()
        {
            var input = File.ReadAllText("./Files/Day_2/Day2_Test.input").Split("\r\n");
            Assert.AreEqual(1, DayTwo.Day2_P2(input));
        }
    }
}