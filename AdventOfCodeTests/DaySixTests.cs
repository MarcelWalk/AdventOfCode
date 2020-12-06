using NUnit.Framework;
using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdventOfCode.Tests
{
    [TestFixture()]
    public class DaySixTests
    {
        [Test()]
        public void Day6_P1Test()
        {
            var input = File.ReadAllText("./Files/Day_6/Day6_Test.input").Split("\r\n\r\n");
            Assert.AreEqual(11, DaySix.Day6_P1(input));
        }

        [Test()]
        public void Day6_P2Test()
        {
            var input = File.ReadAllText("./Files/Day_6/Day6_Test.input").Split("\r\n\r\n");
            Assert.AreEqual(6, DaySix.Day6_P2(input));
        }
    }
}