namespace Coding_Exercisee17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();    
            program.PrintWithFinally();
        }
        public void PrintWithFinally()
        {
            try
            {
                Console.WriteLine("Trying...");
            }
            finally
            {
                Console.WriteLine("Finally executed.");
            }
        }
    }
}
