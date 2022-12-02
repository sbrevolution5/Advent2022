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
            //Terminology is outdated, expected outcome WAS player 2
            get
            {
                return this.OLDWinner + this.ExpectedOutcome;
            }
        }
        public int OLDWinner
        {
            //Terminology is outdated, expected outcome WAS player 2
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
                return this.ExpectedOutcome + this.WhatToPlay;
            }
        }
        public int WhatToPlay
        {
            get
            {
                int res = 0;
                switch (this.ExpectedOutcome)
                {
                    case 0:
                        //else lose
                        res = this.Player1 - 1;
                        if (res == 0)
                        {
                            res = 3;
                        }
                        break;
                    case 3:
                        //if tie, difference is 0
                        res = this.Player1;
                        break;
                    case 6:
                        //if win difference is -1 or 2
                        res = this.Player1 + 1;
                        if(res == 4)
                        {
                            res = 1;
                        }
                        break;
                    default: throw new InvalidDataException();
                }
                return res;
            }
        }
    }
}
