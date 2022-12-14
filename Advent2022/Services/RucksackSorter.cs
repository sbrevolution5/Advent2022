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
        public int FindBadges(string input)
        {
            List<string> sackstrings = ParseInput(input);
            List<Sack> sacks = ProcessSacks(sackstrings);
            //get one of each group
            int groups = sacks.Select(s => s.GroupNumber).Max();
            var reps = new List<Sack>();
            for (int i = 1; i < groups+1; i++)
            {
                reps.Add(sacks.Where(s=>s.GroupNumber== i).First());
            }
            return reps.Select(s => s.BadgePriority).Sum();

        }

        private List<Sack> ProcessSacks(List<string> sackstrings)
        {
            var res = new List<Sack>();
            var group = 1;
            var i = 0;
            foreach (var sack in sackstrings)
            {
                var x = new Sack();
                x.Input = sack;
                x.GroupNumber = group;
                i++;
                if (i%3 == 0)
                {
                    group++;
                }
                res.Add(x);
            }
            foreach (var sack in res)
            {
                SortItems(sack);
                SplitInput(sack);
                FindDuplicate(sack);
                SetPriority(sack);
            }
            //Take Items for each group, and find the match.  
            var remain = res;
            for (int j = 0; j < res.Count(); j+=3)
            {
                var oneGroup = remain.Take(3);
                FindGroupBadge(oneGroup);
                remain = remain.Skip(3).ToList();
            }
            foreach(var sack in res)
            {
                SetBadgePriority(sack);
            }
            return res;
        }

        private void FindGroupBadge(IEnumerable<Sack> oneGroup)
        {
            var a = oneGroup.First();
            var b = oneGroup.ElementAt(1);
            var c = oneGroup.ElementAt(2);
            foreach (var ch in a.Items)
            {
                if (b.Items.Contains(ch))
                {
                    if (c.Items.Contains(ch))
                    {
                        a.Badge = ch;
                        b.Badge = ch;
                        c.Badge = ch;
                        return;
                    }
                }
            }
            throw new InvalidOperationException();
        }

        private void SortItems(Sack sack)
        {
            sack.Items = sack.Input.Distinct().ToList();
        }

        private void FindDuplicate(Sack sack)
        {
            var h1 = sack.Halves.First();
            var h2 = sack.Halves.Last();
            foreach (var c in h1)
            {
                if (h2.Contains(c))
                {
                    sack.Duplicate = c;
                    return;
                };
            }
            throw new InvalidOperationException();
        }

        private void SetPriority(Sack sack)
        {
            if (sack.Duplicate>96)
            {
                sack.Priority = sack.Duplicate - 96;
            }
            else
            {
                sack.Priority = sack.Duplicate-38;
            }
        }
        private void SetBadgePriority(Sack sack)
        {
            if (sack.Badge>96)
            {
                sack.BadgePriority = sack.Badge - 96;
            }
            else
            {
                sack.BadgePriority = sack.Badge-38;
            }
        }

        private void SplitInput(Sack sack)
        {
            var halfwaypt = sack.Input.Length / 2;
            var h1 = sack.Input.Substring(0, halfwaypt);
            var h2 = sack.Input.Substring(halfwaypt, halfwaypt);
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
