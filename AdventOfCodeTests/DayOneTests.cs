using NUnit.Framework;
using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdventOfCode.Tests
{
    [TestFixture()]
    public class DayOneTests
    {
        [Test()]
        public void Day1_P1Test()
        {
            var input = File.ReadAllText("./Files/Day_1/Day1_Test.input").Split("\r\n");
            Assert.AreEqual(514579, DayOne.Day1_P1(input));
        }

        [Test()]
        public void Day1_P2Test()
        {
            var input = File.ReadAllText("./Files/Day_1/Day1_Test.input").Split("\r\n");
            Assert.AreEqual(241861950, DayOne.Day1_P2(input));
        }
    }
}