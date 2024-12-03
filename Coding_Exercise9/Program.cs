namespace Coding_Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            double[] temperatures = { 10.5, 12.3, 23.5 };
            program.PrintAverage(temperatures);
        }

        public void PrintAverage(double[] temperatures)
        {
            double average = CalculateAverage(temperatures);
            Console.WriteLine($"The average temperature is: {average:F1}");
        }

        public double CalculateAverage(double[] temperatures)
        {
            double sum = 0;
            foreach (double i in temperatures)
            {
                sum+=i;
            }
            return (sum/temperatures.Length);
        }
    }
}
