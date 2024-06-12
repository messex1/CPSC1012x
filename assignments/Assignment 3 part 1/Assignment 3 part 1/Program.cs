/* 
Purpose: Assignment 3 part 1 assessment  
Inputs: menu choice
Outputs: game program, algorithum running game, playagain choice 
Test Plan: games in separate methods, with appropriate error catches
Written by: Michael Essex
Instructor Name : Carlos Estoy
Section No: E01
Last modified: 12-11-2022
*/

namespace Assignment_3_part_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string menuchoice;

            do
            {
                Console.WriteLine("|-------------------|");
                Console.WriteLine("|  CPSC1012 Casino  |");
                Console.WriteLine("|-------------------|");
                Console.WriteLine("| 1. Play Craps     |");
                Console.WriteLine("| 2. Play Pig       |");
                Console.WriteLine("| 0. Exit Program   |");
                Console.WriteLine("|-------------------|\n");

                Console.Write("Enter your menu number choice:  ");
                menuchoice = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();

                if (menuchoice is not "1" and not "2" and not "0")
                {
                    Console.Write("{0} is not a valid menu choice. Try again:  ", menuchoice);
                }

                if (menuchoice == "1")
                {
                    Console.WriteLine("|------------------|");
                    Console.WriteLine("|    Play Craps    |");
                    Console.WriteLine("|------------------|");
                    Console.WriteLine();


                    string playAgainCraps;
                    do
                    {
                        playCraps();
                        Console.WriteLine("Do you want to play again (y/n)");
                        playAgainCraps = Console.ReadLine();

                        if (playAgainCraps is not "y" and not "n")
                        {
                            Console.WriteLine("Error Input Value. y or n");
                        }
                    }
                    while (playAgainCraps != "n");
                }


                if (menuchoice == "2")
                {
                    Console.WriteLine("|------------------|");
                    Console.WriteLine("|   Game of Pig    |");
                    Console.WriteLine("|------------------|");
                    Console.WriteLine();

                    string playAgainPig;
                    do
                    {
                        PlayPig();

                        Console.Write("Do you want to play again (y/n)");
                        playAgainPig = Console.ReadLine();
                        Console.Clear();

                        if (playAgainPig is not "y" and not "n")
                        {
                            Console.Write("Error Input Value. please press y or n (y/n): ");
                            playAgainPig = Console.ReadLine();
                        }
                    }
                    while (playAgainPig != "n");


                }
            }
            while (menuchoice == "0");
            Console.WriteLine("Good-bye and thanks for coming to the CPSC1012 Casino.");
        }
        public static void playCraps()
        {
            Random rnd = new();
            int num1 = rnd.Next(1, 7);
            int num2 = rnd.Next(1, 7);
            int total = num1 + num2;
            int[] number = { 4, 5, 6, 8, 9, 10 };
            int amount;


            Console.Write("Enter your bet amount:  ");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("You rolled {0} + {1} = {2}", num1, num2, total);

            if (total is 2 or 3 or 12)
            {
                Console.WriteLine("You lost $" + amount);
            }
            if (total is 7 or 11)
            {
                Console.WriteLine("You win $" + amount);
            }
            if (number.Contains(total))
            {
                Console.WriteLine("Point is {0}", total);
                int num3 = rnd.Next(1, 7);
                int num4 = rnd.Next(1, 7);
                int total2 = num3 + num4;
                Console.WriteLine("You rolled {0} + {1} = {2}", num3, num4, total2);
                if (total2 == 7 || total2 == total)
                {
                    Console.WriteLine("You lost $" + amount);
                }
                else
                {
                    Console.WriteLine("You Win $" + amount);
                }
            }
        }
        public static void PlayPig()
        {
            char pointValue = ' ';
            int Pointstotal = 0, PointsTotalcomputer = 0;


            Console.Write("Enter the point total to play for: ");
            int pigAmount = int.Parse(Console.ReadLine());


            Console.WriteLine("It's your turn");
            Random rnd = new();


            while (pointValue != 'h')
            {
                int number = rnd.Next(1, 7);
                if (number == 1)
                {
                    Pointstotal = 0;
                    Console.WriteLine("You rolled a {0}", number);
                    Console.WriteLine();
                    Console.WriteLine("Your turn score is {0}", Pointstotal);
                    pointValue = 'h';
                }
                else
                {
                    Console.Write("Enter r to roll or h to hold (r/h):  ");
                    pointValue = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("You rolled a {0}", number);
                    Pointstotal += number;
                }
            }
            Console.WriteLine();
            Console.WriteLine("It's the computer's turn");

            bool computerHolds = false;
            while (PointsTotalcomputer < 10 && computerHolds != true)
            {
                int computerRandom = rnd.Next(2, 7);
                if (computerRandom == 1)
                {
                    Console.WriteLine("Computer rolled a {0}", computerRandom);
                    PointsTotalcomputer = 0;
                    Console.WriteLine();
                    Console.WriteLine("Your turn score is {0}", PointsTotalcomputer);
                    computerHolds = true;

                }
                else
                {
                    Console.WriteLine("Computer rolled a {0}", computerRandom);
                    PointsTotalcomputer += computerRandom;
                    computerHolds = false;
                }
            }

            if (computerHolds == false)
            {
                Console.WriteLine("Computer Hold");
                Console.WriteLine();
                Console.WriteLine("It's your turn");
                while (pointValue != 'h')
                {
                    int number = rnd.Next(1, 7);
                    if (number == 1)
                    {
                        Pointstotal = 0;
                        Console.WriteLine("You rolled a {0}", number);
                        Console.WriteLine();
                        Console.WriteLine("Your turn score is {0}", Pointstotal);
                        pointValue = 'h';
                    }
                    else
                    {
                        Console.Write("Enter r to roll or h to hold (r/h):  ");
                        pointValue = char.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("You rolled a {0}", number);
                        Pointstotal += number;
                    }
                }
            }

            Console.WriteLine("Your total point is {0}", Pointstotal);
            Console.WriteLine();
            Console.WriteLine("Computer total points {0}", PointsTotalcomputer);


            if (Pointstotal > PointsTotalcomputer)
            {
                Console.WriteLine("You Win {0:C}", pigAmount);
            }
            else if (Pointstotal < PointsTotalcomputer)
            {
                Console.WriteLine("You Lost {0:C}", pigAmount);
            }
            else
            {
                Console.WriteLine("Tie {0:C}", pigAmount);
            }
        }
    }
}