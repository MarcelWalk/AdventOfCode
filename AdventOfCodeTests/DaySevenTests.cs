using NUnit.Framework;
using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdventOfCode.Tests
{
    [TestFixture()]
    public class DaySevenTests
    {
        [Test()]
        public void Day7_P1Test()
        {
            var input = File.ReadAllText("./Files/Day_7/Day7_Test.input").Split("\r\n");
            Assert.AreEqual(4, DaySeven.Day7_P1(input));
        }

        [Test()]
        public void Day7_P2Test()
        {
            var input = File.ReadAllText("./Files/Day_6/Day6_Test.input").Split("\r\n");
            Assert.AreEqual(6, DaySeven.Day7_P2(input));
        }
    }
}