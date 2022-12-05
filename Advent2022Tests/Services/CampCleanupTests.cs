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
    public class CampCleanupTests
    {
        private readonly string input = @"2-4,6-8
2-3,4-5
5-7,7-9
2-8,3-7
6-6,4-6
2-6,4-8";
        [TestMethod()]
        public void FindNumberOfParentPairsTest()
        {
            var cleanup = new CampCleanup();
            var res = cleanup.FindNumberOfParentPairs(input);
            res.Should().Be(2);
        }
    }
}