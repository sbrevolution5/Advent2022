using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2022.Models
{
    public class CrateStack
    {
        public int StackNumber { get; set; }
        public Stack<char> Crates { get; set; }=new Stack<char>();
    }
}
