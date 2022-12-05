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

            return 0;
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
