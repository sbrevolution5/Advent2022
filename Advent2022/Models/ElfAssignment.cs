using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2022.Models
{
    public class ElfAssignment
    {
        public int Low { get; set; }
        public int High { get; set; }
        public int Size { get { return High - Low + 1; } }
    }
}
