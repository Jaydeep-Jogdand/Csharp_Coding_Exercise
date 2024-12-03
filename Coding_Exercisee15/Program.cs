namespace Coding_Exercisee15
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Program program = new Program();
            program.PrintDictionaryValues();
        }
        public void PrintDictionaryValues()
        {

            Dictionary<string, List<int>> myDictionary = new Dictionary<string, List<int>>();


            myDictionary["Numbers"] = new List<int> { 1, 2, 3 };

            foreach (var item in myDictionary)
            {
                foreach (var number in item.Value)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}

