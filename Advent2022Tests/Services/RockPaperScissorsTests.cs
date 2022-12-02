using Microsoft.VisualStudio.TestTools.UnitTesting;
using Advent2022.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace Advent2022.Services.Tests
{
    [TestClass()]
    public class RockPaperScissorsTests
    {
        private string input = @"A Y
B X
C Z";
        [TestMethod()]
        public void CalcScoreTest()
        {
            var rps = new RockPaperScissors();
            var res = rps.CalcOLDScore(input);
            res.Should().Be(15);

        }
        public void CalcNewScoreTest()
        {
            var rps = new RockPaperScissors();
            var res = rps.CalcTrueScore(input);
            res.Should().Be(12);
        }
    }
}