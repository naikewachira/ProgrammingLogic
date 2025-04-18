namespace Lab5;
class Program
{
    static void Main(string[] args)
    {
        //Problem 1: Seasons of the Year
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
        Console.WriteLine("Season: " + season);
        }
        Console.WriteLine();
        //Problem 2: Days of the Week (1-7)
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number (1-7): ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int weekDay) && weekDay >= 1 && weekDay <= 7)
        {
        Console.WriteLine("That day is: " + days[weekDay - 1]);
        }
        else
        {
        Console.WriteLine("That's not a day of the week silly.");
        }
        Console.WriteLine();
        //Problem 3: Favorite Books and Authors
        string[] books = { "Blood Meridian", "Stoner", "Slaughterhouse-Five" };
        string[] authors = { "Cormac McCarthy", "John Edward Williams", "Kurt Vonnegut" };
        for (int i = 0; i < books.Length; i++)
        {
        Console.WriteLine(books[i] + " by " + authors[i]);
        }
        Console.WriteLine();
        //Problem 4: Temperature Tracker
        int[] temperatures = { 65, 72, 78, 75, 68 };
        Array.Sort(temperatures);
        Console.Write("Sorted Temperatures: ");
        foreach (int temp in temperatures)
        {
        Console.Write(temp + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Highest Temperature: " + temperatures[temperatures.Length - 1]);
        Console.WriteLine("Lowest Temperature: " + temperatures[0]);
        Console.WriteLine();
        //Problem 5: Reverse Countdown
        int[] countdown = { 5, 4, 3, 2, 1 };
        Array.Reverse(countdown);
        Console.Write("Countdown: ");
        foreach (int numbers in countdown)
        {
        Console.Write(numbers + " ");
        }
        Console.WriteLine();
    }
    
}
