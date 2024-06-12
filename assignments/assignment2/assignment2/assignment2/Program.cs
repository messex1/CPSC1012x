/*
Purpose:Assignment 2
Inputs:track length as int, and user decision as y/n
Outputs: visuals to display a track race game with the computer
Algorithm: random number generator in response to user input
CPSC1012 Assignment 2 - Fall 2022 Term
Test Plan: Assignment 2 racing game with computer
Test Case       Test Data         Expected Results
assignment 2    tracklength       random number generated in the form of a game
Written by: Michael Essex
Written for: carlos estay
Section No: a03
Last modified: 2022-12-10
*/

int trackLength;
int rows = 7;
char lengthSymbol = '=';
char userSymbol = '☺', computerSymbol = '*';
int columnCount1 = 0, columnCount2 = 0;
const int minNumber = 1;
const int maxNumber = 6;
Random keygen1 = new(), keygen2 = new();
int justRollUser = 0, justRollComputer = 0, rollNumber = 0;
ConsoleKey key;
char playAgain;
int gamesWon = 0, gamesLost = 0, gamesTied = 0;

Console.WriteLine("            Welcome to the Unicorn Racing Game!    ");
Console.WriteLine("____________________________________________________");              //FYI       I used a few Console.WriteLine(); 's as a way to space out the output data for aestetics and easier readability.   Hopefully that doesnt warrant docked marks.
Console.WriteLine();
do
{
    do
    {
        Console.Write("Enter the length of the track: ");
        trackLength = int.Parse(Console.ReadLine());
        /*exception for invalid number outside of programs range*/

        if (trackLength < 6)
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input value. Please enter an integer >= 6");

            //string tracklength = Console.ReadLine();
            //if (!int.TryParse(tracklength, out trackLength))
            //{
            //    Console.WriteLine("{0} is not an integer", tracklength);
            //}                                                                         I attempted to split my exception handling by data type and provide different error message outputs, although i was unsuccessful
        }
    }
    while (trackLength < 6);
    Console.Clear();

    while (columnCount1 <= trackLength && columnCount2 <= trackLength)
    {
        for (int currentRow = 1; currentRow <= rows; currentRow++)
        {
            for (int currentColumn = 1; currentColumn <= trackLength; currentColumn++)
            {
                if (currentRow == 1 || currentRow == rows)
                {
                    Console.Write(lengthSymbol);
                }
                else if (currentRow == 3 && currentColumn == 1)
                {
                    Console.Write($"{userSymbol}".PadLeft(columnCount1));
                }
                else if (currentRow == 5 && currentColumn == 1)
                {
                    Console.Write($"{computerSymbol}".PadLeft(columnCount2));
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Rol1 #{rollNumber}");
        rollNumber++;
        Console.WriteLine($"{"Roll",16}{"Position",11}");
        Console.WriteLine($"{"Player"}{justRollUser,10}{columnCount1,11}");
        Console.WriteLine($"{"Computer"}{justRollComputer,8}{columnCount2,11}");
        Console.WriteLine("---------------------------------");
        Console.WriteLine();
        Console.WriteLine("Hit Enter to roll");
        key = Console.ReadKey().Key;
        Console.Clear();
        if (key == ConsoleKey.Enter)
        {
            justRollUser = keygen1.Next(minNumber, maxNumber + 1);
            columnCount1 += justRollUser;
            justRollComputer = keygen2.Next(minNumber, maxNumber + 1);
            columnCount2 += justRollComputer;
        }
    }
    if (columnCount1 > trackLength)
    {
        Console.WriteLine("User Wins!");
        Console.WriteLine();
        gamesWon++;
    }
    else if (columnCount2 > trackLength)
    {
        Console.WriteLine("Computer Wins!");
        Console.WriteLine();
        gamesLost++;
    }
    else if (columnCount1 > trackLength && columnCount2 > trackLength)
    {
        Console.WriteLine("Its a tie!");
        Console.WriteLine();
        gamesTied++;
    }
    else
    {
        Console.WriteLine("Error");
    }
    columnCount1 = 0;
    columnCount2 = 0;
    rollNumber = 0;
    do
    {
        Console.WriteLine();
        Console.Write("Would you like to play again? (y/n): ");
        playAgain = char.Parse(Console.ReadLine());
        playAgain = char.ToUpper(playAgain);
        if (playAgain is not 'Y' and not 'N')
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input value. Please enter y or n");
        }
    }
    while (playAgain is not 'Y' and not 'N');
    Console.Clear();
}
while (playAgain == 'Y');

Console.WriteLine();
Console.WriteLine($"You WON  {gamesWon}   games.");
Console.WriteLine();
Console.WriteLine($"You lost {gamesLost}  games.");
Console.WriteLine();
Console.WriteLine($"You tied {gamesTied}  games.");