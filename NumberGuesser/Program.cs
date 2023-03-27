using System;


// Namespace
namespace NumberGuesser 
{ 
    //Main Class
    class Program 
    {     
        //Entry point Method
        static void Main(string[] args)
        {

            GetAppInfo();

            GreetUser();

            while(true) { 

                // Random a number

                Random random = new();
                int correctNumber = random.Next(1, 10);
                Console.WriteLine(correctNumber);

                // Init guess var

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                // While guess if not correct
                while(guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if(!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use a actual number");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if(guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number. Try again.");
                    }
                }

                // Output success message

                // Change text color
                PrintColorMessage(ConsoleColor.Yellow, "You are correct");
                // Wanna play again? 

                Console.WriteLine("Play Again? [Y, N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                } else if (answer == "N")
                {
                    return;
                }
                {
                    break;
                }

            }
        }
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Gustavo Medeiros";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset Text color
            Console.ResetColor();
        }
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name? ");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}! Let's play a game!", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user this is not a number
            Console.WriteLine(message);

            // Reset Text color
            Console.ResetColor();
        }
    }

}