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
        [TestMethod()]
        public void CalorieCounterTest()
        {
            var input = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";
            //act
            var res = CalorieCounter.Count(input);
            //assert

        }
    }
}