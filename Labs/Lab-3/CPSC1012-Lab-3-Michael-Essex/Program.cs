//Purpose:  Lab 3 - 
//Input
//Output: 
//Written by: Michael Essex
//Written for: Carlos Estay-Oyarzo
//Section: A0#
//Last Modified Date: 10/22/2022


//Project should be uploaded to Moodle with
//screen shot of it working with all the test data that has been shown in the above examples.


//Use the following formulas to aid in your solution:

/*monthly interest rate = annualinterestrate/12
balance = balance + balance * MonthlyInterestRate*/

//Use   test data   to check if code if done right

using System.Reflection.Metadata;

namespace CPSC1012_Lab_3_Michael_Essex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double interest, AnnualRoi, balance;
            double irateYear, irateMonth;
            int years;

            

            Console.WriteLine("Enter your starting balance: ");
            balance = double.Parse(Console.ReadLine());
            //case 1:   5000
            //case 2:   10,000
            Console.WriteLine("Enter your savings term: ");
            years = int.Parse(Console.ReadLine());
           
            //case 1: 5 years
            //case 2: 10 years
            Console.WriteLine("Enter the given interest rate: ");
            irateYear = double.Parse(Console.ReadLine());
            irateMonth = irateYear / 12;
            interest = irateMonth;
            //case 1: 0.05  (5 percent)
            //case 2: 0.025 (2.5 percent)

             //AnnualRoi = double.Parse(years);
            interest = irateMonth * Math.Pow(1 + irateMonth, years) / (Math.Pow(1 * irateMonth, years) - 1);



            AnnualRoi = interest;
                //balance + (balance * irateMonth);
            

            //Console.WriteLine("Your annual return on a balance of: ${0:0}", AnnualRoi);

            AnnualRoi = balance;
            Console.WriteLine("year\t\tbalance");

            for (double i = 0; i > balance; i++) //(int i = 0; i < years; i++)
            {
                balance = balance + (balance * irateMonth);
                Console.WriteLine("{0}\t\t${1:0.00}", i + 1, years, balance);
            }
           


            //test case 1
            /*starting balance: 5000
             * interest rate 5%
             * number of years saved 5
             * 
             * expected result: yr 0 = $5000
             *                  yr 1 = $5,255.81
                                yr 2 = $5,524.71
                                yr 3 = $5.807.36
                                yr 4 = $6,104.48
                                yr 5 = $6,416.79*/
        }
    }
}




 


