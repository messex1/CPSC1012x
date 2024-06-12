//Purpose:  lab 5
//Input: 
//Output: 
//Written by: michael essex
//Written for: carlos estay
//Section: A04
//Last Modified Date: 11/19/2022

/*
namespace Lab_5
{internal class Program
{ static void Main(string[] args)
{int padding = 11, dollarPadding = 10;

Console.WriteLine("****".PadLeft(padding));

Console.Write("$".PadLeft(dollarPadding));
Console.WriteLine("2,125.50".PadLeft(padding));
Console.Write("$".PadLeft(dollarPadding));
Console.WriteLine("450.50".PadLeft(padding));
Console.Write("$".PadLeft(dollarPadding));
Console.WriteLine("10,750.25".PadLeft(padding));
Console.Write("$".PadLeft(dollarPadding));
Console.WriteLine("900.00".PadLeft(padding));

output looks like:
  $   2,125.50
  $     450.50
  $  10,750.25
  $     900.00}}}*/



//   THIS CODE ONLY DISPLAYS THE CONTENTS FROM THE FILE UNORGANIZED

// To indent a section of the output use \tr 
// to add a space in section to separate data visually use    \n\tS

// The section of outputed data upon execution would be ------>Console.WriteLine("\tR - Add rainbow cookie treats ($1000)\n\tS - Special appetizers ($500)"); 
using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lab_5
{
    internal class Program
    {

        //static double mark;
        //static double percentage;

        static void Main(string[] args)
        {

            try
            {
                using (StreamReader sr = new StreamReader(@"C:\CPSC1012\Lab5\QuizMarks.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file, C:\\CPSC1012\\Lab5\\QuizMarks.txt, does not exist!");
                Console.WriteLine(e.Message);
            }


            // read the file
            String[] lines = File.ReadAllLines(@"C:\CPSC1012\Lab5\QuizMarks.txt");
            Console.WriteLine("class average is: {0:0.00}", lines);

            /*if (CallerLineNumberAttribute < 50) {
                Console.WriteLine("fail");
            }*/
            string path = @"C:\CPSC1012\Lab5\QuizMarks.txt";
            // convert data in Doubles    
            Double[] data = Array.ConvertAll(lines, Double.Parse);

            // use Linq to get what you want (min, max, total, average, ...)
            Double average = data.Average();

            Console.WriteLine("Welcome to the Quiz Mark Calculator");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.WriteLine($"Quiz marks: Quiz Total = 35");
            Console.WriteLine("Mark \n\tS Percentage"/*, mark, percentage*/);
            Console.WriteLine();
            Console.WriteLine("The class average is", average, "%");//DISPLAYS AVERAGE OF MARKS
            Console.WriteLine("There were","pass and","fails");



            //Console.WriteLine(data.Min());//DISPLAYS LOWEST MARK

            //Console.WriteLine(data.Max());//DISPLAYS HIGHEST MARK

            //Console.WriteLine(data.Sum());//DISPLAYS THE SUM OF ALL MARKS

           
        }
                
    }
}/**/
/*
using System;
using System.IO;
using System.Linq;
namespace Lab_5
{
    //public partial
    internal class Program

    {        static double total;
            //String path = @"C:\CPSC1012\Lab5\QuizMarks.txt";  path for your file
        static void Main(string[] args)
            {  

                // CARLOS'S HINTs:   define a method to load data
                static int LoadData(string dataFilePath, double[] marks)
                { 
                string filepath = "C:\\Users\\messe\\OneDrive\\Desktop\\CPSC1012\\git\\MichaelEssexRepo\\Labs\\lab-5\\QuizMarks.txt";
                }

                // CARLOS'S HINTs:   define a method to print the array of marks:
                static void PrintMarks(double[] marks, int markCount) 
                { 
                }

                // CARLOS'S HINTs:   You can define a method to print the return the average percentage as shown below
                static double AveragePercentage(double[] marks, int markCount)
                {
                Double average = AveragePercentage();
                Console.WriteLine(AveragePercentage());//DISPLAYS AVERAGE OF THE MARKS
                }

                //CARLOS'S HINTs:   Instead of creating a method to return the # of passes & # of fails, you could define a method to print the number of passes and fails:
                static void PrintPassesAndFails(double[] marks, int markCount)
                {

                }
            }
    }
}*/
//MAKE  A  1D  ARRAY     ------to load the data & process calculations as you display them. 
//***theres no requirement for parallel or jagged arrays****

//construct a program to calculate:
//          grades as percentages, ** rounded to 2 decimal places
//          class average, and
//          # of students passed/failed the assessment.
//The data of student grades will be loaded from a file.
//The file, which is supplied to you, will contain up to 25 student grades.



/*Use Methods in your solution and have methods do the following:

    Load the array from a file.
    Display the array data as outlined in the sample output below.
    Calculate the average mark.
    Count the number of passing and failing marks (pass mark is 50%; total / 2). 
*/


//TEST YOUR PROGRAM
//test 1:
//Use this file path to place your QuizMarks.txt
//and make sure you use the same file path in your code: C:\CPSC1012\Lab5\QuizMarks.txt:

//Filelocation on my PC---->C:\Users\messe\OneDrive\Desktop\CPSC1012\git\MichaelEssexRepo\Labs\lab-5\QuizMarks.txt



