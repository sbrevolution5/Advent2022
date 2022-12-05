
// See https://aka.ms/new-console-template for more information
using Advent2022.Inputs;
using Advent2022.Services;

while (true)
{
    Console.WriteLine("Please enter the day you wish to solve.  Or enter 0 to exit with a bit of holiday cheer");
    string day = Console.ReadLine();
    long dayNum = 0;
    if (!Int64.TryParse(day, out dayNum))
    {
        Console.WriteLine("Number Not detected, input 0 to exit.");
    }
    else
    {
        if(dayNum == 0)
        {
            Console.WriteLine("Exiting code, Merry Christmas!");
            break;
        }
        else
        {
            switch (dayNum)
            {
                case 1:
                    var counter = new CalorieCounter();
                    Console.WriteLine($"The elf with the most calories has {counter.Count(InputFinder.Day1)} calories");
                    Console.WriteLine($"The Top 3 Elves have a total of {counter.Top3(InputFinder.Day1)} calories");
                    break;
                case 2:
                    var rps = new RockPaperScissors();
                    Console.WriteLine($"The total score for following the strategy guide is {rps.CalcOLDScore(InputFinder.Day2)}");
                    Console.WriteLine($"WAIT YOU STUPID, Thats not player 2's move! Its the expected outcome of the game!!!! The REAL total score for following the strategy guide is {rps.CalcTrueScore(InputFinder.Day2)}");
                    break;
                case 3:
                    var rucksack = new RucksackSorter();
                    Console.WriteLine($"The Total Priority of the duplicates is {rucksack.GetDuplicatePriority(InputFinder.Day3)}");
                    Console.WriteLine($"The Total Priority of each group's badge is {rucksack.FindBadges(InputFinder.Day3)}");
                    break;
                default:
                    Console.WriteLine("Number is either over 25 or puzzle not complete for that day");
                    break;
            }
        }
    }
}