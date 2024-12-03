namespace Coding_Exercisee18
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Program program = new Program();
            program.HandleMultipleExceptions("abc", 1);
        }
        public void HandleMultipleExceptions(string input, int index)
        {
            int[] numbers = { 1, 2, 3 };

            try
            {
                int parsedValue = int.Parse(input);

                Console.WriteLine(numbers[index]);
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid format.");
            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("Index out of range.");
            }
        }
    }
}
