using Advent2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2022.Services
{
    public class RucksackSorter
    {
        public int GetDuplicatePriority(string input)
        {
            List<string> sackstrings = ParseInput(input);
            List<Sack> sacks = ProcessSacks(sackstrings);
            return sacks.Select(s=>s.Priority).Sum();
        }

        private List<Sack> ProcessSacks(List<string> sackstrings)
        {
            var res = new List<Sack>();
            foreach (var sack in sackstrings)
            {
                var x = new Sack();
                x.Input = sack;
                res.Add(x);
            }
            foreach (var sack in res)
            {
                SplitInput(sack);
                FindDuplicate(sack);
                SetPriority(sack);
            }
            throw new NotImplementedException();
        }

        private void FindDuplicate(Sack sack)
        {
            sack.Duplicate = 'a';
        }

        private void SetPriority(Sack sack)
        {
            sack.Priority = sack.Priority - 50;
        }

        private void SplitInput(Sack sack)
        {
            var halfwaypt = sack.Input.Length / 2;
            var h1 = sack.Input.Substring(0, halfwaypt);
            var h2 = sack.Input.Substring(halfwaypt, halfwaypt - 1);
            sack.Halves.Add(h1);
            sack.Halves.Add(h2);
        }

        private List<string> ParseInput(string input)
        {
            var res = new List<string>();
            var lines = input.Split("\r\n");
            foreach (var line in lines)
            {
                res.Add(line);
            }
            return res;
        }
    }
}
