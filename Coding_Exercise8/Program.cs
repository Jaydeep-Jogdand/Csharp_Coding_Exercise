namespace Coding_Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < 3; i++)
            {
                int rowSum = 0;


                for (int j = 0; j < 3; j++)
                {
                    rowSum += numbers[i, j];
                }


                Console.WriteLine(rowSum);
            }
        }
    }
}
