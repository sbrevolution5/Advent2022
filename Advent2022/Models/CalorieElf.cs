namespace Advent2022.Models
{

    internal class CalorieElf
    {
        public List<int> Calories { get; set; }=new List<int>();
        public int Total { get { return Calories.Sum(); } }
    }
}