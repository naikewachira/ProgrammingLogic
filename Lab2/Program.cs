namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        int myInt = 4;
        double myDouble = 4.44D;
        float myFloat = 6.66f;
        char myChar = 'Q';
        bool myBool = false;
        string myString = "KFC Biscuit";
        Console.WriteLine("myInt: " + myInt + ".");
        Console.WriteLine("myDouble: " + myDouble + ".");
        Console.WriteLine("myFloat: " + myFloat + ".");
        Console.WriteLine("myChar: " + myChar + ".");
        Console.WriteLine("myBool: " + myBool + ".");
        Console.WriteLine("myString: " + myString + ".");
        double myDouble2 = 9.78;
        int myInt2 = (int) myDouble2;
        Convert.ToString(myInt);
        Convert.ToString(myBool);
        Console.WriteLine("Another string: " + myInt + ".");
        Console.WriteLine("Another string: " + myBool + ".");
        Console.WriteLine("Enter username: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        string age = Console.ReadLine();
        Convert.ToInt32(age);
        Console.WriteLine("Hello "  + userName + " you're " + age + " today, no?");
        int num1 = 7;
        int num2 = 3;
        num1 += 10;
        Console.WriteLine("Addition of num1: " + num1 + ".");
        num1 -= 2;
        Console.WriteLine("Subtraction of num1: " + num1 + ".");
        num1 *= 3;
        Console.WriteLine("Multiplication of num1: " + num1 + ".");
        num1 /= 2;
        Console.WriteLine("Division of num1: " + num1 + ".");
        num1 %= 2;
        Console.WriteLine("Modulus of num1: " + num1 + ".");
        num2 += 10;
        Console.WriteLine("Addition of num2: " + num2 + ".");
        num2 -= 2;
        Console.WriteLine("Subtraction of num2: " + num2 + ".");
        num2 *= 3;
        Console.WriteLine("Multiplication of num2: " + num2 + ".");    
        num2 /= 2;
        Console.WriteLine("Division of num2: " + num2 + ".");
        num2 %= 2;
        Console.WriteLine("Modulus of num2: " + num2 + ".");
        Console.WriteLine("num1: " + num1 + ".");
        Console.WriteLine("num2: " + num2 + ".");
        float floatingPoint1 = 1.123456789F;
        double floatingPoint2 = 1.123456789D;
        Console.WriteLine("Float: " + floatingPoint1 + ".");
        Console.WriteLine("Double: " + floatingPoint2 + ".");
        int ten = 10;
        ten++;
        Console.WriteLine(ten);
        ten--;
        Console.WriteLine(ten);
    }
}
