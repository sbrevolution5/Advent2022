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
    public class CargoCraneTests
    {
        private string _input= @"    [D]    
[N] [C]    
[Z] [M] [P]
 1   2   3 

move 1 from 2 to 1
move 3 from 1 to 3
move 2 from 2 to 1
move 1 from 1 to 2";
        [TestMethod()]
        public void SkimTheTopTest()
        {
            var crane = new CargoCrane();
            var res = crane.SkimTheTop(_input);
            res.Should().Be("CMZ");
        }
    }
}