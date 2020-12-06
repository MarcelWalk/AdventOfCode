using NUnit.Framework;
using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdventOfCode.Tests
{
    [TestFixture()]
    public class DayFourTests
    {
        [Test()]
        public void Day4_P1Test()
        {
            var input = File.ReadAllText("./Files/Day_4/Day4_Test.input").Split("\r\n\r\n");
            Assert.AreEqual(2, DayFour.Day4_P1(input));
        }

        [Test()]
        public void Day4_P2Test()
        {
            var valid = File.ReadAllText("./Files/Day_4/Day4_Test_Valid.input").Split("\r\n\r\n");
            var invalid = File.ReadAllText("./Files/Day_4/Day4_Test_Invalid.input").Split("\r\n\r\n");
            Assert.AreEqual(4, DayFour.Day4_P2(valid));
            Assert.AreEqual(0, DayFour.Day4_P2(invalid));
        }
    }
}