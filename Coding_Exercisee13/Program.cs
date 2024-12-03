namespace Coding_Exercisee13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Program program = new Program();
            program.PrintNumbers();
        }
        public void PrintNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3 };


            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
