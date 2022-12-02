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
        public int ExpectedOutcome { get; set; }
        public int OLDRoundScore
        {
            get
            {
                return this.OLDWinner + this.ExpectedOutcome;
            }
        }
        public int OLDWinner
        {
            get
            {
                if (this.Player1 == this.ExpectedOutcome)
                {
                    return 3;
                }
                else
                {
                    var diff = this.Player1 - this.ExpectedOutcome;
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
        public int NewRoundScore
        {
            get
            {
                return 0;
            }
        }
        public int NewWinner
        {
            get
            {
                return ;
            }
        }
    }
}
