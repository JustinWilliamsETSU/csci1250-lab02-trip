/*
 * Name:        Justin Williams
 * Course:      CSCI 1250, Section 002
 * Assignment:  Lab 02, Trip Calculator
 * Date:        September 23, 2026
 * Description: Calculates the food, fuel, and work hours behind one road trip.
 */

// Gathers user input
System.Console.WriteLine("=== Part 1: Road Trip ===");
System.Console.Write("Round trip miles: ");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Miles per gallon: ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Price per gallon: ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

// Calculates the math
double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;
double fuelCost = gallonsNeeded * pricePerGallon;

// Output
System.Console.WriteLine("\nGallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));

// Pizza Party input
System.Console.WriteLine("\n=== Part 2: Pizza Party ===");
System.Console.Write("How many people are going? ");
int peopleGoing = Convert.ToInt32(Console.ReadLine());

System.Console.Write("How many pizzas? ");
int pizzas = Convert.ToInt32(Console.ReadLine());

System.Console.Write("What is the price per pizza? ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

// How many slices per pizza, and how many slices total that makes, and price
const int slicesperPizza = 8;
double totalSlices = slicesperPizza * pizzas;
double slicesPerPerson = totalSlices / peopleGoing;
double pizzaCost = pizzas * pizzaPrice;

// Pizzas Output
System.Console.WriteLine("\nTotal slices: " + totalSlices);
System.Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
System.Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));

// Paycheck input
System.Console.WriteLine("\n=== Part 3: Paycheck ===");
System.Console.Write("How many hours did you work this week? ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

System.Console.Write("What is your hourly rate? ");
double hourlyRate = Convert.ToDouble(Console.ReadLine());

const double taxRate = 0.18;

// Calculating three things
double grossPay = hoursWorked * hourlyRate;
double taxWithheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWithheld;

// Paycheck Output
System.Console.WriteLine("\nGross pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
System.Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));