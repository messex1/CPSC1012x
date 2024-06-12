
namespace Sept_28_FileReader1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;
            reader = new StreamReader(@"C:\CPSC1012\Lab5\QuizMarks.txt");

            Console.WriteLine("File reader");



            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
            reader.Close();
        }

    }
}