using Advent2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2022.Services
{
    public class RockPaperScissors
    {
        public int CalcScore(string input)
        {
            IEnumerable<RpsRound> rounds = ParseInput(input);
            IEnumerable<int> scores = rounds.Select(r => r.Score);
            throw new NotImplementedException();
        }

        private IEnumerable<RpsRound> ParseInput(string input)
        {
            var lines = input.Split("\r\n");
            var res = new List<RpsRound>();
            foreach (var line in lines)
            {
                RpsRound round = new RpsRound();
                var chars = line.Split(" ");
                var p1 = char.Parse(chars[0]);
                var p2 = char.Parse(chars[1]);
                round.Player1 = p1 switch
                {
                    'A' => 1,
                    'B' => 2,
                    'C' => 3,
                    _ => throw new InvalidOperationException(),
                };
                round.Player2 = p2 switch
                {
                    'X' => 1,
                    'Y' => 2,
                    'Z' => 3,
                    _ => throw new InvalidOperationException(),
                };
                res.Add(round);
            }
            return res;
        }
    }
}
