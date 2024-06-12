//Purpose:  lab 6 -  Creating simple class with properties, constructor, and a instance-level method  
//Input: int minutes, int km, int tip
//Output: double fare
//Written by: Michael Essex
//Written for: Carlos estay
//Section: OE01
//Last Modified Date: 12/3/2022

namespace CPSC1012_lab6_michaelessex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutes = 0;
            int km = 0;
            int tip = 0;
            double fare = 0;
            do
            {
                try
                {

                    Console.WriteLine("Welcome to the Taxi Fare Calculator");

                    //TIME PROCESSOR
                    Console.Write("Enter the time, in whole minutes, the trip took (min 10 minutes):  ");

                    while (!int.TryParse(Console.ReadLine(), out minutes))
                    {
                        Console.WriteLine("Invalid Input, please try again...");
                        Console.Write("Enter the time, in whole minutes, the trip took (min 10 minutes):  ");
                    }


                    //DISTANCE PROCESSOR
                    Console.Write("Enter the distance, in whole kilometers, the trip was (min 2 km): ");

                    while (!int.TryParse(Console.ReadLine(), out km))
                    {
                        Console.WriteLine("Invalid Input, please try again...");
                        Console.Write("Enter the distance, in whole kilometers, the trip was (min 2 km): ");
                    }

                    //TIP PROCESSOR
                    Console.Write("Would you like to tip? in whole dollars (minimum is 5 Dollars):  ");

                    while (!int.TryParse(Console.ReadLine(), out tip))
                    {
                        Console.WriteLine("Caffinating your driver is required, please tip 5 dollars...");
                        Console.Write("Would you like to tip? in whole dollars (minimum is 5 Dollars):  ");
                    }

                    TaxiFare taxi = new TaxiFare(minutes, km, tip);
                    fare = taxi.CalculateFare(minutes, km, tip);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(1);    //Exiting the program if there is an exception
                }
            }





            while (minutes < 10 || km < 2 || tip < 5);
            {
                if (tip > 5)
                {
                    Console.WriteLine("thank you for your generosity, your driver will be pleased.", tip);
                    Console.WriteLine("The fare for the passenger(s) is {0:C}", fare);
                }

                else
                {
                    Console.WriteLine("The fare for the passenger(s) is {0:C}", fare);

                }

            }
            

        }



    }
}
