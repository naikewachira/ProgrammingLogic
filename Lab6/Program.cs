namespace Lab6;

using System;

class Car
{
public string model;
public string color;
public int year;
public void Display()
{
Console.WriteLine("Car Details:");
Console.WriteLine("Model: " + model);
Console.WriteLine("Color: " + color);
Console.WriteLine("Year: " + year);
}
//Problem 1: Add a method with no parameters.
public void Start()
{
Console.WriteLine("The car is starting.");
}
//Problem 2: Add a method with parameters.
public void Drive(int miles)
{
Console.WriteLine("The car drove " + miles + " miles.");
}
//Problem 3: Add a method with a return value.
public string GetDescription()
{
return year + " " + color + " " + model;
}
//Problem 4: Add a Method that updates a field.
public void Repaint(string newColor)
{
color = newColor;
Console.WriteLine("The car has been repainted to " + newColor + ".");
}
}
class Program
{
static void Main(string[] args) {
Car myCar = new Car();
myCar.model = "Integra";
myCar.color = "Black";
myCar.year = 2001;
myCar.Display();
myCar.Start(); 
myCar.Drive(50);
string description = myCar.GetDescription();
Console.WriteLine(description);
myCar.Repaint("Red");
Console.WriteLine(myCar.color);
   }
}