namespace array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that will allow the user to 
             * enter up to 25 numbers into an array. 
               Calculate and display the mean average of the numbers*/

            int arraysize = 10;
            //numbers entered are int value

            double[] numbers = new double[arraysize];
            //PART1:
                //declares the array with the new declared value "double[] numbers".
                //array is indicated by the [] brackets after data type double
                //its double because the average is likely more than 1 character (ex. 11, 36, 48, etc...)
            //PART 2:
                //Declared the fillable array with the incoming values in the rest of the code
                //indicated by "new double[arraysize]
                //to which we declared that it will contain values of double data type

            double sum = 0, average = 0;

            //Fill the array from elements entered through the console
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("input your numbers:  ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            //read the elements from the array and add them to the variable sum

            for (int i = 0; i < arraysize; i++)
            {
                sum += numbers[i];
            }

            //Divide the sum by the number of elements
            average = sum / arraysize;


            Console.WriteLine("the average is {0:0.00}", average);

        }
    }
}
/*      OUTPUT LOOKS LIKE THIS
 
input your numbers:  4
input your numbers:  5
input your numbers:  3
input your numbers:  9
input your numbers:  1
input your numbers:  3
input your numbers:  8
input your numbers:  4
input your numbers:  5
input your numbers:  2
the average is 4.40

*/   
 