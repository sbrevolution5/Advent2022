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
            List<List<ElfAssignmentPair>> elves = ParseInput(input);
            var res = 0;
            foreach (var pair in elves)
            {
                if (PairContainsOther(pair))
                {
                    res++;
                }
            }
            return res;
        }

        private bool PairContainsOther(List<ElfAssignmentPair> pair)
        {
            var e1 = pair[0];
            var e2 = pair[1];
            if (e1.Low >= e2.Low)
            {
                return OuterContainsInner(e2, e1);
            }
            else
            {
                return OuterContainsInner(e1, e2);
            }
        }

        private bool OuterContainsInner(ElfAssignmentPair outer, ElfAssignmentPair inner)
        {
            return outer.Low <= inner.Low && outer.High >= inner.High;
        }

        private List<List<ElfAssignmentPair>> ParseInput(string input)
        {
            var res = new List<List<ElfAssignmentPair>>();
            var lines = input.Split("\r\n");
            foreach (var line in lines)
            {
                var pair = new List<ElfAssignmentPair>();
                var assigns = line.Split(",");
                foreach (var assign in assigns)
                {
                    var elf = new ElfAssignmentPair();
                    var nums = assign.Split("-");
                    elf.Low = int.Parse(nums[0]);
                    elf.High = int.Parse(nums[1]);
                    pair.Add(elf);
                }
                res.Add(pair);
            }
            return res;
        }
    }
}
