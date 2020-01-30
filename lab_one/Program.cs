/* // Using statements that brings in code to construct program (i.e. using System or using Console)
 * 
 * // Start and stop represent my main method
 * START
 *     DECLARATIONS
 *          // This is the data that I'll need for this program 
 *          string answerKey [] = {"B","B","C"}
 *          string userChoices [3];
 *          string userSelection 
 *          string questions[] = {"What year did .NET Core come out?",
 *                               "What versions is .NET Core currently",
 *                               "Who created .NET Core?"}
 *          // Two dimensional array
 *          string optionChoices[ , ] = {
 *                                          {"A) 2007", "B) 2014", "C) 1994", "D) 2022"},
 *                                          {"A) 1.2", "B) 3.1", "C) 10.0", "D) 2.2"},
 *                                          {"A) Google", "B) Facebook", "C) Microsoft", "D) Dunwoody"}
 *                                      }
 *          num primingValue = 1; // Priming value which starts the program
 *          num EXIT = 2; //Sentinal Value which allows you to exit the program
 *          num x,y;
 *          num totalCorrect, totalIncorrect;
 *          
 *          OUTPUT "Welcome, this is a quiz on .NET Core. This quiz will consist of 3 questions.
 *                  You must have 2 out of 3 correct to pass the quiz."
 *          OUTPUT "To get started, please enter 1 to start the program"
 *          INPUT primingValue
 *          
 *          WHILE primingValue != EXIT
 *              
 *              // This loop controls the output of questions 
 *              FOR x = 0; x < questions.Length; x++
 *                  OUTPUT questions[x]
 *                  
 *                  // This inner loop output the option choices for each questions
 *                  FOR y = 0; y < optionChoices[x,y]; y++
 *                      OUTPUT optionChoices[x,y]
 *                  ENDFOR
 *                  
 *                  OUTPUT "Please enter your selection"
 *                  INPUT userSelection
 *                  
 *                  // Decision making logic to determine if they got the answers right or wrong\
 *                  // We can use "x" here because this is inside of a for loop so "x" will start at 0 in the answerKey array
 *                  // We declare the totalCorrect & incorrect variables here so that it isn't a constant and so it can reset if the user takes the quiz more than once
 *                  totalCorrect = 0
 *                  totalIncorrect = 0
 *                  // Make a method to ensure that the answer is uppercase like .ToUpper 
 *                  // This method below tells them if they got it correct after each questins
 *                  IF userSelection == answerKey[x] THEN
 *                      totalCorrect++ //this is the same thing as totalCorrect = totalCorrect + 1
 *                      OUTPUT "You got it right"
 *                  ELSE
 *                      totalIncorrect++
 *                      OUTPUT "You got it right" 
 *                  ENDIF
 *                  
 *                  // Adding user input to userChoices array
 *                  userChoices [x] = userSelection;  
 *                  
 *              ENDFOR
 *              
 *              // OUTPUT RESULTS
 *              OUTPUT "THe quiz has concluded, your results are listed below"
 *              OUTPUT "Total correect" + totalCorrect
 *              OUTPUT "Total incorrect" + totalIncorrect 
 *              
 *              // Decision logic to determine if they passed the quiz 
 *              IF totalCorrect >= 2 THEN
 *                  OUTPUT "You passed the quiz"
 *              ELSE
 *                  OUTPUT "Sorry you failed, please retake the quiz"
 *              ENDIF
 *              
 *              OUTPUT "To retake the quiz, please enter 1 or enter 2 to exit the quiz"
 *              INPUT primingValue
 *              
 *          ENDWHILE
 *          OUTPUT = "Thank you for taking the .NET Core quiz"
 * STOP
 */
using System;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variables 
            string [] answerKey = { "B","B","C","A","D","A","A","C","D","A" };
            string [] userChoices = new string[] { }; // this is an empty string
            string userSelection;
            string [] questions = { "What year was .NET Core developed?","What is the latest version of .NET Core?","Who created .NET Core?" };
            // two dimensional array
            string[,] optionChoices = {
                { "A) 2007", "B) 2014", "C) 1994", "D) 2022" },
                {"A) 1.2","B) 3.1","C) 10.0","D) 2.2" },
                {"A) Google","B) Facebook","C) Microsoft","D) Dunwoody" }
                                      };
            ConsoleKey primingValue = ConsoleKey.D2;
            ConsoleKey sentinelValue = ConsoleKey.Escape;
            int totalCorrect, totalIncorrect;

            // Welcome Message
            Console.WriteLine("Welcome, this is a quiz on .NET Core. This quiz will consist of 3 questions.\n" +
                               "You must have 2 out of 3 correct to pass the quiz.\n" +
                               "Please press any key to start the program");

            // Get priming value
            ConsoleKey userInput = Console.ReadKey().Key; // grabs any key input
            while (userInput != sentinelValue)
            {
                int x,y; 
                totalCorrect = 0;
                totalIncorrect = 0;
                // looping structure to loop through the questions and only print as many questions as are in the questions array
                // the x++ is what makes it add 1 to each iteration
                for (x = 0; x < questions.Length; x++)
                {
                    Console.WriteLine(questions[x]);

                    for (y = 0; y < optionChoices.GetLength(1); y++)
                    {
                        Console.WriteLine(optionChoices[x, y]);    
                    }

                    Console.WriteLine("Please enter your selection");
                    userSelection = Console.ReadLine().ToUpper();

                    if (userSelection == answerKey[x])
                    {
                        totalCorrect = totalCorrect + 1;
                        Console.WriteLine("You got it right");
                    }

                    else
                    {
                        totalIncorrect++;
                        Console.WriteLine("You got it wrong");
                    }
                } // End of 1st for loop

                Console.WriteLine("The quiz has concluded, your results are listed below");
                Console.WriteLine("Total Correct = " + totalCorrect);
                Console.WriteLine("Total Incorrect =" + totalIncorrect);

                // Decision logic to determine if they passed the quiz
                if (totalCorrect >= 2)
                {
                    Console.WriteLine("You passed!");
                }

                else
                {
                    Console.WriteLine("Sorry, you failed.");
                }

                // Ask user if they want to retake  the quiz
                Console.WriteLine("\nTo retake the quiz, please press enter\n" +
                    "To exit the program, please press escape.");
                ConsoleKey userInput2 = Console.ReadKey().Key;
                if (userInput2 == sentinelValue)
                {
                    break;
                }

            
            } // End of while loop


            if (userInput == sentinelValue) 
            {
                Console.WriteLine("Thank you for taking the .NET Core quiz");
                Environment.Exit(0);
            }

                    
        }// end of main
    } // end of class
}
