using Advent2022.Services;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class CalorieCounterTests
    {
        private CalorieCounter _counter;
        private static string _input = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";
        [TestInitialize]
        public void SetUp()
        {
            _counter = new CalorieCounter();
        }
        [TestCleanup]
        public void CleanUp()
        {
            _counter = null;
        }
        [TestMethod()]
        public void CalorieCounterTest()
        {
            
            //act
            var res = _counter.Count(_input);
            //assert
            res.Should().Be(24000);
        }
        [TestMethod]
        public void Top3Test()
        {
            //arrange
            //act
            var res = _counter.Top3(_input);
            //assert
            res.Should().Be(45000);
        }
    }
}