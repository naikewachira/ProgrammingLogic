namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 5;
        int c = 15;
        Console.WriteLine(a > b);
        Console.WriteLine(a < c);
        Console.WriteLine(a > b && a > c);
        Console.WriteLine(a  > b|| a < c || a > b && a > c); 
        bool isRaining = true;
        bool haveUmbrella = false;
        if (isRaining = true && haveUmbrella == false) {
        Console.WriteLine("Take an umbrella if it’s raining and you don’t have one."); 
        }
        else {
        Console.WriteLine("You're good to go!");          
        }
        Console.WriteLine("What is your age: ");
        string age = Console.ReadLine();
        int yourAge = Convert.ToInt32(age);
        if (yourAge < 5) {
        Console.WriteLine("Ticket is free!");
        }
        else if (yourAge <= 12) {
        Console.WriteLine("Child ticket: $5");
        }
        else if (yourAge <= 64) {
        Console.WriteLine("Standard ticket: $10");
        }
        else {
        Console.WriteLine("Senior ticket: $6");
        }
        Console.WriteLine("Enter a day of the week (1-7): ");
        string day = Console.ReadLine();
        int weekDay = Convert.ToInt32(day);
         switch (weekDay)
    {
        case 1:
            Console.WriteLine("");
            break;

        case 2:
            Console.WriteLine("Tuesday");
            break;

        case 3:
            Console.WriteLine("Wednesday");
            break;

        case 4 :
            Console.WriteLine("Thursday");
            break;

        case 5 :
            Console.WriteLine("Friday");
            break;
        case 6 :
            Console.WriteLine("Saturday");
            break;
        case 7 :
            Console.WriteLine("Sunday");
            break;
        default:
            Console.WriteLine("Invalid day!");
            break;
    }
    }
}   
