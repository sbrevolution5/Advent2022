using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2022.Models
{
    public class ElfAssignmentPair
    {
        public List<ElfAssignment> Pair { get; set; } = new List<ElfAssignment>();
        public bool FullContain { get; set; }
        public int Lowest { get; set; }
        public int Highest { get; set; }
        public bool Overlaps { get; set; }
    }
}
