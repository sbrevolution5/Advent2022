using Advent2022.Models;

namespace Advent2022.Services
{

    public class CalorieCounter
    {
        public CalorieCounter()
        {
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