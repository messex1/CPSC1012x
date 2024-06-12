//Purpose:  lab 4
//Input: years, amount, sum
//Output: sum of digits, a table of values
//Written by: michael essex
//Written for: carlos estay
//Section: A04
//Last Modified Date: 11/5/2022



namespace Lab4
{
    internal class Program
    { /*STEP 1  Create lab
            STEP 2
             * 
             * Write a program that will allow the user to
             * enter the 
             *              original value of an item
             *              and the number of years you wish to calculate 
             *                                                               the depreciated value.*/

        /* FORMULA 1:       if you want to calculate the depreciation of an item over 5 years you would have:
                 Sum Of Digits    =   1 + 2 + 3 + 4 + 5 = 15
                        SumOfDigits = sum of the digits of the remaining years

         FORMULA 2:         The calculation for depreciation per year is:
                 Depreciation = Years * Amount / (Sum Of Digits)

                                Years = Remaining years to depreciate
                                Amount= Remaining balance to depreciate. After the first year of depreciation, 
                                        the balance is the initial amount MINUS the amount depreciated in the first year

        It is recommended to use the validation methods covered in class and the following methods:
                SumOfDigits
                    Input: years
                    Output: sum of the digits
                DisplayDepreciation
                    Input: amount, years, sum
                    Output: a table of values (see sample outputs below)


         Sum Of Digits    =   1 + 2 + 3 + 4 + 5 = 15
         Depreciation = Years * Amount / (Sum Of Digits)*/
        static void Main(string[] args)
        {   int input;
            int amount, years, sum, depreciation;
            Console.WriteLine("This program computes depreciation tables using the sum-of-years-digits method.");
            Console.WriteLine();
            Console.WriteLine("Menu of Options");
            Console.WriteLine();
            Console.WriteLine("Enter a new amount and the number of years - 1");
            Console.WriteLine("Display depreciation Table - 2");
            Console.WriteLine("Exit Menu - 3");

            Console.WriteLine("Enter your selection");

            input = int.Parse(Console.ReadLine());

            if (input == 2)
            {
                Console.WriteLine("You must enter an amount and number of years ...");
                Console.WriteLine("This program computes depreciation tables using the sum-of-years-digits method.");
                Console.WriteLine();
                Console.WriteLine("Menu of Options");
                Console.WriteLine();
                Console.WriteLine("Enter a new amount and the number of years - 1");
                Console.WriteLine("Display depreciation Table - 2");
                Console.WriteLine("Exit Menu - 3");

                Console.WriteLine("Enter your selection");
                input = int.Parse(Console.ReadLine());
            }



            if (input == 1)
            {
                Console.Write("enter amount: ");
                amount = int.Parse(Console.ReadLine());
                Console.Write("Enter years: ");
                years = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Menu of Options");
                Console.WriteLine();
                Console.WriteLine("Enter a new amount and the number of years - 1");
                Console.WriteLine("Display depreciation Table - 2");
                Console.WriteLine("Exit Menu - 3");

                Console.WriteLine("Enter your selection");
                input = int.Parse(Console.ReadLine());

                if (input == 2)
                {
                    
                    Console.WriteLine("Menu of Options");
                    Console.WriteLine();
                    Console.WriteLine("Enter a new amount and the number of years - 1");
                    Console.WriteLine("Display depreciation Table - 2");
                    Console.WriteLine("Exit Menu - 3");
                }
            }

            if (input == 3)
            {
                Console.WriteLine("Good-bye and thanks for using the program.");
            }

        } 

}
}