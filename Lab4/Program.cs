namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i<=10; i++) {
        Console.WriteLine(i);
        }
        Console.WriteLine();
        for (int e = 1; e<=20; e++) {
        if (e % 2 == 0) {
        Console.WriteLine(e);
        }
        }
        Console.WriteLine();
        int u = 5;
        while (u >= 5) {
        Console.WriteLine(u);
        u--;    
        }
        Console.WriteLine();
        int enter100;
        do {
        Console.WriteLine("Enter a number greater than 100: ");
        enter100 = Convert.ToInt32(Console.ReadLine());  
        }
        while (enter100 <= 100);
        Console.WriteLine();
        int wegottagetatleast10thou = 10;
        while (wegottagetatleast10thou <= 1000) {
        Console.WriteLine(wegottagetatleast10thou);
        wegottagetatleast10thou += 10;
        }
        Console.WriteLine();
        for (int q = 1; q < 10; q++) {
        for (int l = 1; l <= q; l++) {
        Console.Write("*");    
        }
        Console.WriteLine();
        }
    }
}
