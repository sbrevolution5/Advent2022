namespace Advent2022.Models
{

    internal class CalorieElf :IComparable<CalorieElf>
    {
        public List<int> Calories { get; set; }=new List<int>();
        public int Total { get { return Calories.Sum(); } }

        public int CompareTo(CalorieElf? other)
        {
            return -1*this.Total.CompareTo(other.Total);
        }
    }
}