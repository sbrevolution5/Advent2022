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
    public class RucksackSorterTests
    {
        private readonly string _input = @"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw";
        [TestMethod()]
        public void GetDuplicatePriorityTest()
        {
            var sorter = new RucksackSorter();
            var result = sorter.GetDuplicatePriority(_input);
            result.Should().Be(157);
        }
    }
}