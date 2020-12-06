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
            var input = File.ReadAllText("./Files/Day6_Test.in").Split("\r\n\r\n");
            var result = DaySix.Day6_P1(input);
            Assert.IsTrue(result == 11);
        }

        [Test()]
        public void Day6_P2Test()
        {
            var input = File.ReadAllText("./Files/Day6_Test.in").Split("\r\n\r\n");
            var result = DaySix.Day6_P2(input);
            Assert.IsTrue(result == 6);
        }
    }
}