namespace Coding_Exerciseee29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NotHungryCats("O~~O~O~O F O~O~"));   
        }
        public static int NotHungryCats(string kitchen)
        {
            kitchen=kitchen.Replace(" ", "");
            string[] cats = kitchen.Split('F');
            string left = cats[0];
            string right = cats[1];
            int count = 0;
            for (int i = 0; i<left.Length; i=i+2)
            {
                if (left[i]=='O')
                {
                    count++;
                }
            }
            for (int i = 0; i<right.Length; i=i+2)
            {
                if (right[i]=='~')
                {
                    count++;
                }
            }
            return count;

        }
    }
}
