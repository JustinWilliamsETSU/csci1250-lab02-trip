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
