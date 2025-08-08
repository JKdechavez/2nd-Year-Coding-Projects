/* Purpose : A Driver's License Examination that assesses the examinee if they pass or fail the exam.
Language : C #
Programmers: John Kevin R. De Chavez
Naomi Kristin Odejar
Date Created : 03/01/2024
Date Modified : 03/01/2024
*/

using System;

class MainCode {
  static void Main() {
    
    // Correct answers
    char[] correctAns = { 'A', 'C', 'A', 'A', 'D', 'B', 'C', 'A', 'C', 'B', 'A', 'D', 'C', 'A', 'D', 'C', 'B', 'B', 'D', 'A' };
    
    // questions
    string[] questions = {
    @"1. What should you do at a stop sign?
    a) Come to a complete stop
    b) Speed up
    c) Roll through without stopping
    d) Honk the horn",

    @"2. What does a yellow traffic light indicate?
    a) Slow down and prepare to stop
    b) Go
    c) Stop
    d) Speed up",

    @"3. When approaching a school zone, you should:
    a) Slow down and watch for children
    b) Increase your speed
    c) Use your phone
    d) Ignore the signs",

    @"4. What does a white painted curb mean?
    a) No parking
    b) Loading zone
    c) Passenger loading zone
    d) Handicap parking",

    @"5. When should you use your headlights?
    a) During the day
    b) Never
    c) When visibility is reduced
    d) Only at night",

    @"6. If your car starts skidding on a slippery road, you should:
    a) Steer in the direction you want to go
    b) Accelerate
    c) Brake firmly
    d) Close your eyes",

    @"7. What is the purpose of a crosswalk?
    a) A place for pedestrians to cross the road
    b) Reserved for bicycles
    c) Parking spot for cars
    d) Skateboarding area",

    @"8. When can you use your horn?
    a) To alert others of your presence
    b) As a greeting
    c) To express frustration
    d) When passing a friend",

    @"9. What should you do if you have a tire blowout?
    a) Gradually release the gas pedal and steer in the direction you want to go
    b) Steer off the road
    c) Quickly change lanes
    d) Slam on the brakes",

    @"10. When is it legal to pass another vehicle on the right?
    a) Never
    b) Always
    c) When the vehicle is turning left
    d) Only on highways",

    @"11. What is the proper way to use a turn signal?
    a) Use it before changing lanes or turning
    b) Activate it after turning
    c) Use it before turning, but not when changing lanes
    d) It's not necessary to use turn signals",

    @"12. What is the legal blood alcohol concentration (BAC) limit for most drivers?
    a) 0.02%
    b) 0.05%
    c) 0.08%
    d) 0.10%",

    @"13. When should you use your high-beam headlights?
    a) On well-lit streets
    b) In fog, rain, or snow
    c) When following another vehicle
    d) In heavy traffic",

    @"14. What does a red octagonal sign mean?
    a) Stop
    b) Yield
    c) Speed limit
    d) One-way street",

    @"15. How far should you stay behind the vehicle in front of you?
    a) One car length
    b) Depend on the road conditions
    c) Tailgate closely
    d) Two seconds following distance",

    @"16. What does a solid yellow line on the road indicate?
    a) No passing
    b) Passing only on the right
    c) Passing for large vehicles only
    d) Passing allowed",

    @"17. When is it safe to use a cellphone while driving?
    a) Only in an emergency
    b) Always
    c) At stoplights
    d) When traffic is moving slowly",

    @"18. What does a flashing red traffic light mean?
    a) Treat it as a stop sign
    b) Stop and proceed when safe
    c) Slow down and proceed with caution
    d) Ignore it and proceed",

    @"19. What should you do if you see a pedestrian in a crosswalk?
    a) Yield the right-of-way
    b) Honk your horn
    c) Speed up and quickly pass
    d) Swerve to avoid them",

    @"20. How often should you check your vehicle's tire pressure?
    a) Only when it's visibly low
    b) Annually
    c) Monthly
    d) Never",
    };
    
    // Student's answers 
    char[] studentAnswers = new char[20];
    
    Console.WriteLine("Welcome to the Driver's License Examination!");
    while (true) {
    Console.WriteLine("Before we proceed with the examination, type \"yes\" to start the exam.");
    string confirmation = Console.ReadLine().ToLower();
    if (confirmation != "yes") {
        Console.WriteLine("Type the specified word to start the exam!");
        continue;
    }
    else
        break;
    }
    Console.WriteLine("Examination will now start. Goodluck on your test!");
    
    // Displaying questions and getting answers
    for (int s = 0; s < 20; s++)
    {
        Console.WriteLine(questions[s]);
        Console.Write("Enter your answer: ");
        studentAnswers[s] = Convert.ToChar(Console.ReadLine().ToUpper());
        Console.WriteLine();
        }

    // Grading the exam
    int correctCount = 0;
    int incorrectCount = 0;
    // store the question numbers of incorrectly answered questions
    int[] incorrectQues = new int[20]; 

    for (int l = 0; l < 20; l++)
    {
        if (studentAnswers[l] == correctAns[l])
            correctCount++;
        else {
            incorrectCount++;
            // storing the question number
            incorrectQues[incorrectCount - 1] = l + 1; 
        }
    }

    // Displaying results
    Console.WriteLine("===========Test Results===========");
    Console.WriteLine("Total Correct Answers: " + correctCount);
    Console.WriteLine("Total Incorrect Answers: " + incorrectCount);

    if (correctCount >= 15)
        Console.WriteLine("You Passed the Exam!");
    else
        Console.WriteLine("You Failed the Exam.");

    // Displaying question numbers of incorrectly answered questions
    if (incorrectCount > 0)
    {
        Console.WriteLine("Incorrectly Answered Questions:");
        for (int i = 0; i < incorrectCount; i++)
            Console.Write(incorrectQues[i] + " ");
    }
  }
}

