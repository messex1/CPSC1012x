//Purpose: create program that refects the costs of sponsoring Unicorns with the Unicorn Rescue Society.

//Input: Donation amount; Width of side walls, back walls, gates; Heights of gates; Types of gates, paint, meal upgrades
//Output: Total donation amount, wall cost, gate cost, gate paint cost, meal upgrade cost

//Written by: Michael Essex
//Written for: Carlos Estay
//Section: A04
//Last Modified Date: November 2, 2022


//Declare inputs and outputs

using System;


internal class Program
{
    private static void Main(string[] args)
    {
        double sponsorcostamount = 0;
        double donationamount = 0;
        double onedonation = 0;
        double monthlydonation;
        double uldonationamount = 0;
        double sidewidth, backwidth, gatewidth, gateheight;
        double wallcost1 = 0;
        double wallcost2 = 0;
        double gatecost1 = 0;
        double gatecost2 = 0;
        double gatecost3 = 0;
        string paintcostnone = "original";
        double paintcost1 = 0;
        double paintcost2 = 0;
        double paintcost3 = 0;
        double mealcost1 = 0;
        double mealcost2 = 0;
        int months;



        Console.WriteLine("**********  Welcome To Unicorn Rescue Society Sponsor Estimator  **********");
        Console.WriteLine();
        Console.WriteLine();

        //Input 1:  Sponsor name
        Console.Write("What is the name of the sponsor? ");
        string ownername = Console.ReadLine();
        //Input 2:  Unicorn name
        Console.Write("What would you like to call the unicorn? ");
        string uniname = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("All sponsors must make a donation");
        Console.WriteLine();
        Console.WriteLine("Donation type selection");
        Console.WriteLine("\tU - Unlimited; same amount for each month forever\n\tM - Monthly; same amount for each month for a predetermined number of months\n\tO - One Time; one time donation amount");
        Console.WriteLine();
        //Input 3:  Decision 1 - Donation type selection
        Console.Write("What donation type would you like to make? ");
        char donationtype = char.Parse(Console.ReadLine());
        donationtype = char.ToUpper(donationtype);
        Console.WriteLine();

        //Process 1 - donation type - switch case
        switch (donationtype)
        {
            case 'U':
                {
                    Console.Write("How much per month? ");
                    uldonationamount = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Total donation amount per month is {uldonationamount:C}");
                    Console.WriteLine();
                }
                break;
            case 'M':
                {
                    Console.Write("How much per month? ");
                    monthlydonation = double.Parse(Console.ReadLine());
                    Console.Write("How many months? ");
                    months = int.Parse(Console.ReadLine());
                    donationamount = monthlydonation * months;
                    Console.WriteLine();
                    Console.WriteLine($"Total donation amount is {donationamount:C}");
                    Console.WriteLine();
                }
                break;
            case 'O':
                {
                    Console.Write("How much would you like to donate? ");
                    onedonation = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Total donation amount is {onedonation:C}");
                    Console.WriteLine();
                }
                break;
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("*** Pen Accommodations dimensions ***");
        Console.WriteLine();
        //input: Dimensions for side walls
        Console.Write("What is the width of the 2 side walls (in feet)? ");
        sidewidth = double.Parse(Console.ReadLine());

        //input:Dimensions for back wall
        Console.Write("What is the width of the back wall (in feet)? ");
        backwidth = double.Parse(Console.ReadLine());

        //input: Dimensions for gate width
        Console.Write("What is the width of the gate (in feet)? ");
        gatewidth = double.Parse(Console.ReadLine());
        Console.WriteLine();

        //input: Dimensions for gate height
        Console.Write("What is the height  of the gate (in feet)? ");
        gateheight = double.Parse(Console.ReadLine());

        //Process 2 - pen dimension calculation
        if (gatewidth == backwidth)
        {

            wallcost1 = (sidewidth + sidewidth + backwidth) * 12 * 4;

        }
        else if (gatewidth < backwidth)
        {
            wallcost2 = (sidewidth + sidewidth + backwidth + (backwidth - gatewidth)) * 12 * 4;

        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("****** Gate Style selection ******");
        Console.WriteLine();
        Console.WriteLine("Available gates (prices per square foot): ");
        Console.WriteLine("\tW - Wooden ($3)\n\tS - Silver ($8)\n\tG - Gold ($12)");

        //Input 5: decision 3 - Gate style selection
        Console.Write("What kind of gate would you like? ");
        char gatetype = char.Parse(Console.ReadLine());
        gatetype = char.ToUpper(gatetype);

        //Process 3 - gate style switch case
        switch (gatetype)
        {
            case 'W':
                gatecost1 = gatewidth * gateheight * 3;
                break;
            case 'S':
                gatecost2 = gatewidth * gateheight * 8;
                break;
            case 'G':
                gatecost3 = gatewidth * gateheight * 12;
                break;
        }

        Console.WriteLine();
        Console.WriteLine();

        //input 6: Decision 4 - Gate Paint selection
        Console.Write("Would you like to change the gate paint (Y/N)? ");
        char gatepaint = char.Parse(Console.ReadLine());
        gatepaint = char.ToUpper(gatepaint);


        //Process 4 - gate Paint choice 
        Console.WriteLine("Available paints");
        Console.WriteLine("\tM - Mood: changes color based on mood ($200)\n\tA - Magic: changes color several times a day ($300)\n\tR - Reflective: reflects like a mirror ($150)");
        Console.WriteLine();

        //Input 7: gate paint choice
        Console.Write("Which paint would you like? ");
        char painttype = char.Parse(Console.ReadLine());
        painttype = char.ToUpper(painttype);

        if (gatepaint == 'Y')
        {
            switch (painttype)
            {
                case 'M':
                    paintcost1 = 200.00;
                    break;
                case 'A':
                    paintcost2 = 300.00;
                    break;
                case 'R':
                    paintcost3 = 150.00;
                    break;
            }
        }
        else if (gatepaint == 'N')
        {
            Console.WriteLine("original");
        }
        Console.WriteLine();
        Console.WriteLine();

        //Input 8: Meal Upgrade Decision
        Console.Write("Would you like a meal upgrade (Y/N)? ");
        char mealup = char.Parse(Console.ReadLine());
        mealup = char.ToUpper(mealup);

        //Process 5 Meal Upgrade
        if (mealup == 'Y')
        {
            Console.WriteLine("Available meal upgrades");
            Console.WriteLine("\tR - Add rainbow cookie treats ($1000)\n\tS - Special appetizers ($500)");
            Console.WriteLine();

            //Input 9: Meal Upgrade Choice
            Console.Write("What meal upgrade would you like? ");
            char mealchoice = char.Parse(Console.ReadLine());
            mealchoice = char.ToUpper(mealchoice);

            switch (mealchoice)
            {
                case 'R':
                    mealcost1 = 1000.00;

                    Console.WriteLine($"{mealup} {mealcost1,-20}");
                    break;
                case 'S':
                    mealcost2 = 500.00;
                    Console.WriteLine($"{mealup} {mealcost2,-20}");
                    break;
            }
        }

        else if (mealup == 'N')
        {
            string mealnone = "None";
            Console.WriteLine($"{mealup} {mealnone,-20}");
        }
        //process to display column title
        switch (mealup)
        {
            case 'R':
                {
                    Console.WriteLine($"{"Meal Upgrade",-28}{mealcost1,-28}");
                }
                break;
            case 'S':
                {
                    Console.WriteLine($"{"Meal Upgrade",-28}{mealcost2,-28}");
                }
                break;
        }



        Console.WriteLine();
        Console.WriteLine("**** Summary ****");
        Console.WriteLine();
        Console.WriteLine($"{"Sponsor",-21}{ownername,-20}");
        Console.WriteLine($"{"Unicorn Name",-21}{uniname,-20}");
        Console.WriteLine($"{"Meal Upgrade",-21}{mealup,-20}");

        switch (donationtype)
        {
            case 'U':
                {
                    Console.WriteLine($"{"Donation Amount",-28}{uldonationamount,-28}");
                }
                break;
            case 'M':
                {
                    Console.WriteLine($"{"Monthly Donation",-28}{donationamount,-28}");
                }
                break;
            case 'O':
                {
                    Console.WriteLine($"{"Donation Amount",-28}{onedonation,-28}");
                }
                break;
        }

        if (gatewidth == backwidth)
        {
            Console.WriteLine($"{"Wall Cost",-28}{wallcost1,-28}");
            sponsorcostamount = donationamount + gatepaint + +mealup + wallcost1;
        }
        else if (gatewidth < backwidth)
        {
            Console.WriteLine($"{"Wall Cost",-28}{wallcost2,-28}");
            sponsorcostamount = donationamount + gatepaint + mealup + wallcost2;
        }

        //process to display column title
        switch (gatetype)
        {
            case 'W':
                {
                    Console.WriteLine($"{"Gate Cost",-28}${gatecost1,-28}");
                }
                break;
            case 'S':
                {
                    Console.WriteLine($"{"Gate Cost",-28}${gatecost2,-28}");
                }
                break;
            case 'G':
                {
                    Console.WriteLine($"{"Gate Cost",-28}${gatecost3,-28}");
                }
                break;
        }
        //process to display column title


        switch (gatepaint)
        {
            case 'M':
                {
                    Console.WriteLine($"{"Gate Paint Cost",-28}{paintcost1,-28}");
                }
                break;
            case 'A':
                {
                    Console.WriteLine($"{"Gate Paint Cost",-28}{paintcost2,-28}");
                }
                break;
            case 'R':
                {
                    Console.WriteLine($"{"Gate Paint Cost",-28}{paintcost3,-28}");
                }
                break;
            default:
                {
                    Console.WriteLine($"{"Gate Paint Cost",-28}{"Original",-28}");
                    break;
                }
        }
        Console.WriteLine();
        Console.WriteLine();



        Console.Write(ownername);
        Console.Write(", the total cost to sponsor ");
        Console.Write(uniname);
        Console.Write(" is $");
        Console.Write(sponsorcostamount);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
