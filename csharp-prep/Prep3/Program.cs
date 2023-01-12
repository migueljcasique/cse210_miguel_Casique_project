using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber;
        String userGuess;
        int iUserGuess;
        String input = "yes";
        while (input == "yes")
        {   iUserGuess = 0;
            magicNumber = randomGenerator.Next(1, 101);
            //prompting the user for the game information.
            while (iUserGuess != magicNumber)
            {           
                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                iUserGuess = int.Parse(userGuess);

                //code that makes the game works.
                if (iUserGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (iUserGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else 
                {
                    Console.WriteLine("You guessed it!");
                }
            
            }
        Console.Write("Do you want to continue (yes/no)? ");
        string newInput = Console.ReadLine();
        if (newInput == "no")
        {
            input= newInput;
        }
        else
        {
            input = "yes";
        }
        }           
    }
}