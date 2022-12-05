using Advent2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2022.Services
{
    public class CampCleanup
    {
        public int FindNumberOfParentPairs(string input)
        {
            List<ElfAssignmentPair> elves = ParseInput(input);
            var res = 0;
            foreach (var pair in elves)
            {
                PairContainsOther(pair);
            }
            if (elves.Where(e => e.Highest < e.Lowest).Any())
            {
                throw new InvalidOperationException();
            }
            return elves.Where(e=>e.FullContain).Count();
        }

        private void PairContainsOther(ElfAssignmentPair pair)
        {
            var e1 = pair.Pair[0];
            var e2 = pair.Pair[1];
            if (e1.Low>= e2.Low&& e1.High<= e2.High)
            {
                pair.FullContain = true;
            }
            else if (e1.Low<= e2.Low&& e1.High>= e2.High)
            {
                pair.FullContain= true;
            }
            else 
                pair.FullContain = false;
        }

        private bool OuterContainsInner(ElfAssignment outer, ElfAssignment inner)
        {
            return outer.Low <= inner.Low && outer.High >= inner.High;
        }

        private List<ElfAssignmentPair> ParseInput(string input)
        {
            var res = new List<ElfAssignmentPair>();
            var lines = input.Split("\r\n");
            foreach (var line in lines)
            {
                var pair = new ElfAssignmentPair();
                var assigns = line.Split(",");
                foreach (var assign in assigns)
                {
                    var elf = new ElfAssignment();
                    var nums = assign.Split("-");
                    elf.Low = int.Parse(nums[0]);
                    elf.High = int.Parse(nums[1]);
                    pair.Pair.Add(elf);
                }
                res.Add(pair);
            }
            return res;
        }
    }
}
