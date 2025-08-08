/* Purpose : A program that prompts the user to enter their points
for both tests and the exam and converts the values to
integers then evaluates their equivalent remarks.
Language : C #
Programmers: John Kevin R. De Chavez
Naomi Kristin Odejar
Date Created : 02/27/2024
Date Modified : 02/27/2024
*/

using System;

class MainCode {
  static void Main() {
    // Asking for user input
    int testScore1, testScore2, mainExamScore, totalScore;
    string gradeRemarks;

    while (true)
    {
    try {
        Console.Write("Enter your score in Test 1: ");
        testScore1 = Convert.ToInt32(Console.ReadLine());
        if (testScore1 < 0 || testScore1 > 25) {
            Console.WriteLine("Score is out of range! Please enter your score again.");
            continue;
        } else
            break;
    } catch {
        Console.WriteLine("Invalid input! Please enter your score again.");
    }
    }
    
    while (true)
    {
    try {
        Console.Write("Enter your score in Test 2: ");
        testScore2 = Convert.ToInt32(Console.ReadLine());
        if (testScore1 < 0 || testScore1 > 25) {
            Console.WriteLine("Score is out of range! Please enter your score again.");
            continue;
        } else
            break;
    } catch {
        Console.WriteLine("Invalid input! Please enter your score again.");
    }
    }
    
    while (true)
    {
    try {
        Console.Write("Enter your score in the Main Exam: ");
        mainExamScore = Convert.ToInt32(Console.ReadLine());
        if (testScore1 < 0 || testScore1 > 50) {
            Console.WriteLine("Score is out of range! Please enter your score again.");
            continue;
        } else
            break;
    } catch {
        Console.WriteLine("Invalid input! Please enter your score again.");
    }
    }
    
    // Conditional statements
    totalScore = testScore1 + testScore2 + mainExamScore;
    if (totalScore < 50 || mainExamScore < 25)
        gradeRemarks = "Fail";
    else
    {
        if (totalScore < 60)
            gradeRemarks = "Pass";
        else if (totalScore < 80)
            gradeRemarks = "Credit";
        else
            gradeRemarks = "Distinction";
    }
   
   Console.WriteLine($"Your total score is {totalScore} and your grade remarks is \"{gradeRemarks}\"."); 
  }
}
