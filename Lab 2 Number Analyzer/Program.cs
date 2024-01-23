using System;

class NumberAnalyzer
{
    static void Main()
    {
        Console.WriteLine("Welcom to the Number Analyzer! What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}!");

        bool continueRunning = true;

        while (continueRunning)
        {
            Console.Write("Enter an integer between 1 and 100 inclusive: ");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                if (userInput >= 1 && userInput <= 100)
                {
                    if (userInput % 2 == 1 && userInput < 60)
                    {
                        Console.WriteLine($"{userInput} - Odd and less than 60.");
                    }
                    else if (userInput % 2 == 0 && userInput >= 2 && userInput <= 24)
                    {
                        Console.WriteLine("Even and less than 25.");
                    }
                    else if (userInput % 2 == 0 && userInput >= 26 && userInput <= 60)
                    {
                        Console.WriteLine("Even and between 26 and 60 inclusive.");
                    }
                    else if (userInput % 2 == 0 && userInput > 60)
                    {
                        Console.WriteLine($"{userInput} - Even and greater than 60.");
                    }
                    else if (userInput % 2 == 1 && userInput > 60)
                    {
                        Console.WriteLine($"{userInput} - Odd and greater than 60.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a positive integer between 1 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.Write("Do you want to continue? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                continueRunning = false;
            }
        }
    }
}
