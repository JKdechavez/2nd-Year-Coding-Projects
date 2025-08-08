/* Purpose : A program that predicts the approximate size of a
population of organisms.
Language : C #
Programmers: John Kevin R. De Chavez
Naomi Kristin Odejar
Date Created : 03/02/2024
Date Modified : 03/02/2024
 */

using System;

class MainCode {
  static void Main() {
    // asking user for data
    int startNum, daysToMultiply;
    double percentIncrease, population;
    
    Console.Write("Starting number of organisms: ");
    startNum = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Average daily increase (%): ");
    percentIncrease = Convert.ToInt32(Console.ReadLine());
    percentIncrease = (percentIncrease/100.0) + 1;
    
    Console.Write("Number of days to multiply: ");
    daysToMultiply = Convert.ToInt32(Console.ReadLine());
    
    // looping the calculation and display
    Console.WriteLine();
    population = startNum;
    Console.WriteLine("Day Approximate     Population");
    for (int s = 0; s < daysToMultiply; s++) 
    {
        if (s == 0) {
            Console.WriteLine($"{s + 1,-19} {startNum}");
            continue;
        } else {
        population *= percentIncrease;
        Console.WriteLine($"{s + 1,-19} {population}");
        }
    }
  } 
}

