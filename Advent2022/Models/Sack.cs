using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2022.Models
{
    public class Sack
    {
        public string Input { get; set; }
        public List<string> Halves { get; set; } = new List<string>();
        public int GroupNumber { get; set; }
        public char Badge { get; set; }
        public int BadgePriority { get; set; }
        public char Duplicate { get; set; }
        public int Priority { get; set; }
    }
}
