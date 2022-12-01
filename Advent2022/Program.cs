
// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.WriteLine("Please enter the day you wish to solve");
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
            break;
        }
        else
        {
            switch (dayNum)
            {
                case 1:
                    dayNum = 1;
                    break;
                default:
                    Console.WriteLine("Number is either over 25 or puzzle not complete for that day");
                    break;
            }
        }
    }
}