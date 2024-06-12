namespace Assignment2
{
    internal class program
    {
        static void Main(String[] args)
        {

            int tracklength;
            int computerpos = 0, playerpos = 0, computerroll = 0, playerroll = 0;
            char playagain = 'y';
            int gameswon = 0, gameslost = 0, gamestied = 0;
            bool gameended = false;
            int gameroll;

            /*int justrolluser = 0, justrollcomputer = 0, rollnumber = 0;
            int rows = 7; 
            char lengthsymbol = '-'; 
            char usersymbol = '*';
            char computersymbol = '*';
            int columncount1 = 0, columncount2 = 0;
            const int minnumber = 1;
            const int maxnumber = 6;
            Random keygen1 = new Random();
            Random keygen2 = new Random();
            ConsoleKey key;
            */

            Console.Clear();
            Console.WriteLine("Welcome to the Unicorn Racing Game!\n");

            while (playagain == 'y')
            {
                gameroll = 0;
                computerpos = playerpos = 0;
                gameended = false;
                Console.WriteLine("Enter the tracklenght");

            }





            do
            {
                do
                {
                    Console.WriteLine("Enter the Length of the track: ");
                    tracklength = int.Parse(Console.ReadLine());
                    if (tracklength < 6)
                    {
                        Console.WriteLine("Invalid input value. Please enter an integer >= 6");
                    }
                }while (tracklength < 6);
             Console.Clear();


            while(columncount1 <= tracklength && columncount2 <= tracklength)
            {
                for(int currentrow = 1; currentrow <= rows; currentrow++)
                {
                    for(int currentcolumn = 1; currentcolumn <= tracklength; currentcolumn++)
                    {
                        if ( currentrow == 1 || currentrow == rows)
                        {
                            Console.WriteLine(lengthsymbol);
                        }
                        else if (currentrow == 3 && currentcolumn == 1)
                        {
                            Console.Write($"{usersymbol}".PadLeft (columncount1));
                        }
                        else if (currentrow == 5 && currentcolumn == 1)
                        {
                            Console.Write($"{computersymbol}".PadLeft(columncount2));
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"Roll #{rollnumber}");
                rollnumber++;
                Console.WriteLine($"{"Roll",16}{"Position",11}");
                Console.WriteLine($"{"Player"}{justrolluser,10}{columncount1,11}");
                Console.WriteLine("Hit enter to roll");
                key = Console.ReadKey().Key;
                Console.Clear();

                if (key == ConsoleKey.Enter)
                {
                    justrolluser = keygen1.Next(minnumber, maxnumber + 1);
                    columncount1 = columncount1 + justrolluser;
                    justrollcomputer = keygen2.Next(minnumber, maxnumber +1);
                    columncount2 = columncount2 + justrollcomputer;
                }
            }
            if (columncount2 > tracklength)
            {
                Console.WriteLine("User Wins!");
                gameswon++;
            }
            else if (columncount1 > tracklength && columncount2 > tracklength)
            {
                Console.WriteLine("Its a tie!");
                gamestied++;
            }
            else
            {
                Console.WriteLine("Error");
            }
            columncount1 = 0;
            columncount2 = 0;
            rollnumber = 0;
            do
            {
                Console.Write("Would you like to play again? (y/n):  ");
                playagain = char.Parse(Console.ReadLine());
                playagain = char.ToUpper(playagain);
                if (playagain != 'Y' && playagain != 'N')
                {
                    Console.WriteLine("Invalid input value. Please enter y or n");
                }
            } while (playagain != 'Y' && playagain != 'N');
            Console.Clear();
            }while (playagain != 'Y') ;
            Console.WriteLine($"You won{gameswon} games.");
            Console.WriteLine($"You lost {gameslost} games. ");
            Console.WriteLine($"You tied {gamestied} games. ");




        }
    }
}




