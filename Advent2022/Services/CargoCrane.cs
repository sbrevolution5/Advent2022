using Advent2022.Models;
using System.Text;

namespace Advent2022.Services
{
    public class CargoCrane
    {

        public string SkimTheTop(string input)
        {
            var stacks = ParseStacks(input);
            var instructions = ParseInstructions(input);
            foreach (var instruction in instructions)
            {
                MoveCrates(stacks, instruction);
            }
            var res = new StringBuilder();
            foreach (var stack in stacks)
            {
                res.Append(stack.Crates.Peek());
            }
            return res.ToString();
        }
        public string SkimAgain(string input)
        {
            var stacks = ParseStacks(input);
            var instructions = ParseInstructions(input);
            foreach (var instruction in instructions)
            {
                MoveMoreCrates(stacks, instruction);
            }
            var res = new StringBuilder();
            foreach (var stack in stacks)
            {
                res.Append(stack.Crates.Peek());
            }
            return res.ToString();
        }

        private void MoveMoreCrates(List<CrateStack> stacks, CraneCommand instruction)
        {
            var stack1 = stacks.Where(s => s.StackNumber == instruction.Start).First();
            var stack2 = stacks.Where(s => s.StackNumber == instruction.End).First();
            var i = 0;
            var crateStack = new Stack<char>();
            for (i = i; i < instruction.Count; i++)
            {
                crateStack.Push(stack1.Crates.Pop());
            }
            for (i = i; i > 0; i--)
            {

                stack2.Crates.Push(crateStack.Pop());
            }
        }

        private void MoveCrates(List<CrateStack> stacks, CraneCommand instruction)
        {
            var stack1 = stacks.Where(s => s.StackNumber == instruction.Start).First();
            var stack2 = stacks.Where(s => s.StackNumber == instruction.End).First();
            for (int i = 0; i < instruction.Count; i++)
            {
                var crate = stack1.Crates.Pop();
                stack2.Crates.Push(crate);
            }
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
                        var currstack = res.Where(c => c.StackNumber == (i / 4) + 1).First();
                        currstack.Crates.Push(row.ElementAt(i + 1));
                    }
                }
            }
            return res;
        }
    }
}