using Advent2022.Models;
namespace Advent2022.Services
{
    public class CargoCrane
    {

        public string SkimTheTop(string input)
        {
            var stacks = ParseStacks(input);
            var instructions = ParseInstructions(input);
            throw new NotImplementedException();
            return "";
        }

        private List<CraneCommand> ParseInstructions(string input)
        {
            var half = input.Split("\r\n\r\n");
            var instructions = half[1].Split("\r\n");
            var res = new List<CraneCommand>();
            foreach (var line in instructions)
            {
                var parts = line.Split(' ');
                var inst = new CraneCommand()
                {
                    Count = int.Parse(parts[1]),
                    Start = int.Parse(parts[3]),
                    End = int.Parse(parts[5])
                };
                res.Add(inst);
            }
            return res;
        }

        private List<CrateStack> ParseStacks(string input)
        {
            var half = input.Split(" 1  ");
            var stacks = half[0];
            var res = new List<CrateStack>();
            //Need to get stacks horizontally, HOWWWWWW
            var rows = stacks.Split("\r\n");
            var totalCrates = rows[0].Length / 4;
            totalCrates++;
            for (int i = 1; i <= totalCrates; i++)
            {
                res.Add(new CrateStack()
                {
                    StackNumber = i,
                });
            }
            rows = rows.Reverse().ToArray();
            foreach (var row in rows)
            {
                for (int i = 0; i < row.Length; i += 4)
                {
                    if (row.ElementAt(i) == '[')
                    {
                        var currstack = res.Where(c => c.StackNumber == (i/4)+1).First();
                        currstack.Crates.Push(row.ElementAt(i + 1));
                    }
                }
            }
            return res;
        }
    }
}