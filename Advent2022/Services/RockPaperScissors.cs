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
        public int CalcOLDScore(string input)
        {
            IEnumerable<RpsRound> rounds = ParseInput(input);
            IEnumerable<int> scores = rounds.Select(r => r.OLDRoundScore);
            return scores.Sum();
        }
        public int CalcTrueScore(string input)
        {
            IEnumerable<RpsRound> rounds = ParseNewInput(input);
            IEnumerable<int> scores = rounds.Select(r => r.NewRoundScore);
            return scores.Sum();
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
                //expected outcome was player2 in part 1
                round.ExpectedOutcome = p2 switch
                {
                    'X' => 1,
                    'Y' => 2,
                    'Z' => 3,
                    _ => throw new InvalidOperationException(),
                };
                res.Add(round);
            }
            return res;
        }private IEnumerable<RpsRound> ParseNewInput(string input)
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
                round.ExpectedOutcome = p2 switch
                {
                    'X' => 0,
                    'Y' => 3,
                    'Z' => 6,
                    _ => throw new InvalidOperationException(),
                };
                res.Add(round);
            }
            return res;
        }
    }
}
