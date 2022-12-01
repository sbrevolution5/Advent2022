using Advent2022.Models;

namespace Advent2022.Services
{

    public class CalorieCounter
    {
        public CalorieCounter()
        {
        }
        public int Top3(string input)
        {
            List<CalorieElf> elves = ParseInput(input);
            elves.Sort();
            List<CalorieElf> top3 = elves.Take(3).ToList();
            return top3.Select(e => e.Total).Sum();

        }
        public int Count(string input)
        {
            List<CalorieElf> elves = ParseInput(input);
            var highCals = 0;
            foreach (var elf in elves)
            {
                if (elf.Total >highCals)
                {
                    highCals = elf.Total;
                }
            }
            return highCals;
        }

        private List<CalorieElf> ParseInput(string input)
        {
            var lines = input.Split("\r\n");
            var res = new List<CalorieElf>();
            CalorieElf currentElf = new CalorieElf();
            foreach (var line in lines)
            {

                if (String.IsNullOrEmpty(line))
                {
                    res.Add(currentElf);
                    currentElf = new CalorieElf();
                }
                else
                {
                    currentElf.Calories.Add(int.Parse(line));
                }
            }
            res.Add(currentElf);
            return res;
        }
    }
}