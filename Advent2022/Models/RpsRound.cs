using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2022.Models
{
    internal class RpsRound
    {
        public int Player1 { get; set; }
        public int Player2 { get; set; }
        public int RoundScore { get {
                return this.Winner + this.Player2;
            }
        }
        public int Winner
        {
            get
            {
                if (this.Player1 == this.Player2)
                {
                    return 3;
                }
                else
                {
                    var diff = this.Player1 - this.Player2;
                    if (diff == -1 || diff == 2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }

            }
        }
    }
}
