namespace Coding_Exercisee14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); 
            program.CheckAny();
        }
        public void CheckAny()
        {

            List<int> myNumbers = new List<int> { 1, 6, 3 };

            foreach (int i in myNumbers)
            {
                if (i > 5)
                {
                    Console.WriteLine("True");
                }
            }
        }
    }
}
