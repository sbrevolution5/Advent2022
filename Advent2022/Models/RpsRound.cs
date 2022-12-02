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
                this.Winner
            } set; }
        public int Winner
        {
            get
            {
                int p1 = 0;
                p1 = this.Player1 switch
                {
                    
                if (p1 == p2)
                {
                    return 3;
                }
                else
                {
                    var diff = p1 - p2;
                    if (diff == -1 || diff == 2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }

            }
        }
    }
}
