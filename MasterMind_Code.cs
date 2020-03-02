// Program to build a C# Console application for MasterMind game prototype.

using System;

public class Mastermind
{

    //Defining the variables
    static string randomnumber = "";
    static string input;
    static string hint = "";

    public static void Main()
    {
        int digitCount = 4;
        int maxattempt = 10;
        int run = 0;
        Random rnd = new Random();

        // Generate a 4 - digit random number with each digit within range 1 to 6.
        for (int i = 0; i <digitCount; i++)
        { 
            randomnumber += rnd.Next(1, 7);
        }

        Console.WriteLine("Greetings! Welcome to the MasterMind with numbers.");
        Console.WriteLine("Instructions to play:");
        Console.WriteLine($"The machine will generate a {digitCount} - digit number with each digit between the numbers 1 and 6 ");
        Console.WriteLine("The player gets 10 attempts to guess the number");
        Console.WriteLine("For each entry the player will get a response from the computer");
        Console.WriteLine("A (+) sign shall be printed for every digit that is both correct and in the correct position ");
        Console.WriteLine("A (-) sign shall be printed for every digit that is correct but in the wrong position");
        Console.WriteLine("Nothing shall be printed for incorrect digits");
        Console.WriteLine("The computer is ready with the number, go ahead and make a guess!");
       Console.WriteLine(randomnumber); 
        try
        {
            do
            {
                //Notifying the player with number of attempts remeaning.
                Console.WriteLine($"{maxattempt - run} attempts remaining.");
                input = Console.ReadLine();

                // If user enters smaller or larger input.
                if (input.Length != digitCount)
                {
                    Console.WriteLine($"Please enter a {digitCount} - digit number");
                }

                // If player's input matches the random number generated.
                if (randomnumber == input)
                {
                    //User's guess is correct
                    Console.WriteLine($"Congratulations, you won! You gussed the number in {run+1} attempts!");
                    break;
                }

                // If the value or position is incorrect
                else
                {
                    hint += Play(0);
                    hint += Play(1);
                    hint += Play(2);
                    hint += Play(3);
                    Console.WriteLine(hint);
                    hint = "";
                }
                run++;
            }
            while (run < maxattempt);

            // If the user is unable to input the correct value after 10 attempts.
            if (input != randomnumber)
            {
                Console.WriteLine("Sorry, You lost");
                Console.WriteLine("You can surely give another try.");
            }
        }

        catch(Exception exe)
        {
            Console.WriteLine(exe.Message);
        }
                   
    }

    // Conditions for giving responses/hints to user on every input.
    static string Play(int index)
    {
        if (randomnumber[index] == input[index])
            return "+";
        else if (randomnumber.Contains(input[index]))
            return "-";
        else
            return " ";
    }
}

//Contributed by Arkish Shah.