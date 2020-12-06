using NUnit.Framework;
using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdventOfCode.Tests
{
    [TestFixture()]
    public class DayFiveTests
    {
        [Test()]
        public void Day5_P1Test()
        {
            var input = File.ReadAllText("./Files/Day_5/Day5_Test.input").Split("\r\n");
            Assert.AreEqual(820, DayFive.Day5_P1(input));
        }
    }
}